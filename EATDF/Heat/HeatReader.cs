using EATDF.Extensions;
using EATDF.Internal;
using EATDF.Members;
using EATDF.Types;
using EATDF.Visitors;
using System.Buffers;
using System.Buffers.Binary;
using System.Collections;
using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Text;

namespace EATDF.Heat;

internal class HeatReader(HeatDecoder decoder, Stream stream)
{
    const int MaxStackAlloc = 512;

    static readonly Encoding StringEncoder = Encoding.UTF8;

    /// <summary>
    /// 3 bytes for tag, 1 byte for type(4 bits) and size(4 bits)
    /// Size is from 0 to 15, if size is 15, then the actual size will be read from the stream
    /// </summary>
    public const int HeaderSize = 4;

    /// <summary>
    /// The decoder that created this reader
    /// </summary>
    public HeatDecoder Decoder { get; } = decoder;

    /// <summary>
    /// The stream to read from
    /// </summary>
    public Stream Stream { get; } = stream;

    /// <summary>
    /// Returns true if the stream is valid and can be read from. False if the stream is invalid or corrupted.
    /// </summary>
    public bool StreamValid { get; private set; } = true;


    /// <summary>
    /// Reads the specified type value from the stream.
    /// </summary>
    /// <typeparam name="T">The type of the value to read.</typeparam>
    /// <param name="reader">The reader which performs the read operation.</param>
    /// <param name="value">The read value.</param>
    /// <param name="sizeHint">The value size hint.</param>
    /// <returns>True if the value was read successfully, otherwise false. False does not necessarily mean, that the stream is corrupted, it just means that the value could not be read.</returns>
    delegate bool TypeReader<T>(HeatReader reader, [NotNullWhen(true)] out T value, byte sizeHint);
    delegate bool TypeReader(HeatReader reader, [NotNullWhen(true)] out object? value, byte sizeHint);

    /// <summary>
    /// Initial type readers for basic types.
    /// </summary>
    static readonly ConcurrentDictionary<Type, Delegate> _typeReaders = new ConcurrentDictionary<Type, Delegate>()
    {
        [typeof(bool)] = new TypeReader<bool>(TryReadBool),
        [typeof(sbyte)] = new TypeReader<sbyte>(TryReadInt8),
        [typeof(byte)] = new TypeReader<byte>(TryReadUInt8),
        [typeof(short)] = new TypeReader<short>(TryReadInt16),
        [typeof(ushort)] = new TypeReader<ushort>(TryReadUInt16),
        [typeof(int)] = new TypeReader<int>(TryReadInt32),
        [typeof(uint)] = new TypeReader<uint>(TryReadUInt32),
        [typeof(long)] = new TypeReader<long>(TryReadInt64),
        [typeof(ulong)] = new TypeReader<ulong>(TryReadUInt64),
        [typeof(string)] = new TypeReader<string>(TryReadString),
        [typeof(byte[])] = new TypeReader<byte[]>(TryReadBlob),

        // for lists and maps of unknown type arguments
        [typeof(IList)] = new TypeReader<IList>(TryReadUnknownList),
        [typeof(IDictionary)] = new TypeReader<IDictionary>(TryReadUnknownMap),
    };


    static readonly ConcurrentDictionary<HeatType, TypeReader> _heatTypeReaders = new ConcurrentDictionary<HeatType, TypeReader>()
    {
        [HeatType.Struct] = ToSimpleTypeReader<EmptyMessage?>(TryReadStruct<EmptyMessage>),
        [HeatType.String] = ToSimpleTypeReader<string>(TryReadString),
        [HeatType.Int8] = ToSimpleTypeReader<sbyte>(TryReadInt8),
        [HeatType.UInt8] = ToSimpleTypeReader<byte>(TryReadUInt8),
        [HeatType.Int16] = ToSimpleTypeReader<short>(TryReadInt16),
        [HeatType.UInt16] = ToSimpleTypeReader<ushort>(TryReadUInt16),
        [HeatType.Int32] = ToSimpleTypeReader<int>(TryReadInt32),
        [HeatType.UInt32] = ToSimpleTypeReader<uint>(TryReadUInt32),
        [HeatType.Int64] = ToSimpleTypeReader<long>(TryReadInt64),
        [HeatType.UInt64] = ToSimpleTypeReader<ulong>(TryReadUInt64),
        [HeatType.Array] = ToSimpleTypeReader<IList>(TryReadUnknownList),
        [HeatType.Blob] = ToSimpleTypeReader<byte[]>(TryReadBlob),
        [HeatType.Map] = ToSimpleTypeReader<IDictionary>(TryReadUnknownMap),
        [HeatType.Union] = ToSimpleTypeReader<Union>(TryReadUnion<Union>)

    };


    static MethodInfo _createListReaderMethod = typeof(HeatReader).GetMethod(nameof(createListTypeReader), BindingFlags.NonPublic | BindingFlags.Static)!;
    static MethodInfo _createMapReaderMethod = typeof(HeatReader).GetMethod(nameof(createMapTypeReader), BindingFlags.NonPublic | BindingFlags.Static)!;

    /// <summary>
    /// Returns the reader for the specified type.
    /// </summary>
    /// <typeparam name="T">The type to get the reader for.</typeparam>
    /// <returns>The reader for the specified type.</returns>
    static TypeReader<T> GetTypeReader<T>()
    {
        Type valueType = typeof(T);
        return (TypeReader<T>)_typeReaders.GetOrAdd(valueType, CreateCustomReader<T>);
    }

    static TypeReader GetTypeReader(HeatType type)
    {
        if (_heatTypeReaders.TryGetValue(type, out TypeReader? reader))
            return reader;

        // Unknown type :(
        return (HeatReader reader, [NotNullWhen(true)] out object? value, byte size) =>
        {
            reader.OnFatalDecodeError();
            value = null;
            return false;
        };

    }


    static TypeReader ToSimpleTypeReader<T>(TypeReader<T> typeReader)
    {
        return (HeatReader reader, [NotNullWhen(true)] out object? value, byte sizeHint) =>
        {
            if (!typeReader(reader, out T val, sizeHint))
            {
                value = default;
                return false;
            }

            value = val;
            return true;
        };

    }


    /// <summary>
    /// Creates a new reader for the specified type.
    /// </summary>
    /// <typeparam name="T">The type to create the reader for.</typeparam>
    /// <param name="type">The type to create the reader for.</param>
    /// <returns>The created reader.</returns>
    /// <remarks>If the type is not supported, a reader that always returns false is returned.</remarks>
    static TypeReader<T> CreateCustomReader<T>(Type type)
    {
        if (type.IsEnum)
            return createEnumTypeReader<T>(type);

        if (type.IsSubclassOf(typeof(Union)) || type == typeof(Union))
            return (HeatReader reader, [NotNullWhen(true)] out T value, byte size) =>
            {
                Union union = (Union)Activator.CreateInstance(type)!;
                value = (T)(object)union!;
                return reader.TryReadUnion(union);
            };


        if (type.IsSubclassOf(typeof(Tdf)))
            return (HeatReader reader, [NotNullWhen(true)] out T value, byte size) =>
            {
                Tdf tdf = (Tdf)Activator.CreateInstance(type)!;
                value = (T)(object)tdf!;
                return reader.TryReadStruct(tdf);
            };

        if (Helpers.IsList(type))
        {
            Type[] typeArgs = type.GetGenericArguments();
            return (TypeReader<T>)_createListReaderMethod.MakeGenericMethod(typeArgs).Invoke(null, null)!;
        }

        if (Helpers.IsDictionary(type))
        {
            Type[] typeArgs = type.GetGenericArguments();
            return (TypeReader<T>)_createMapReaderMethod.MakeGenericMethod(typeArgs).Invoke(null, null)!;
        }

        if (type == typeof(Tdf))
            return (HeatReader reader, [NotNullWhen(true)] out T value, byte size) =>
            {
                Tdf tdf = new EmptyMessage();
                value = (T)(object)tdf!;
                return reader.TryReadStruct(tdf);
            };

        // Unknown type :(
        return (HeatReader reader, [NotNullWhen(true)] out T value, byte size) =>
        {
            reader.OnFatalDecodeError();
            value = default!;
            return false;
        };
    }

    /// <summary>
    /// Reads the header of the next value from the stream.
    /// </summary>
    /// <param name="tag">The read tag.</param>
    /// <param name="type">The read type.</param>
    /// <param name="size">The read size.</param>
    /// <returns>True if the header was read successfully, otherwise false. False also indicates fatal decode error.</returns>
    public bool TryReadHeatMemberHeader(out HeatMemberHeader header)
    {
        Span<byte> bytes = stackalloc byte[HeaderSize];

        if (!Stream.ReadAll(bytes))
        {
            OnFatalDecodeError();
            header = HeatMemberHeader.Invalid;
            return false;
        }

        header = new HeatMemberHeader()
        {
            Tag = unchecked((uint)(bytes[0] << 24 | bytes[1] << 16 | bytes[2] << 8)),
            Type = (HeatType)(bytes[3] >> 4),
            SizeHint = (byte)(bytes[3] & 0xF)
        };

        // Check if correct data type was provided (union is the last type)
        if (header.Type > HeatType.Union)
        {
            OnFatalDecodeError();
            return false;
        }

        return true;
    }




    /// <summary>
    /// Reads the type and size of the next value from the stream.
    /// </summary>
    /// <param name="type">The read type.</param>
    /// <param name="size">The read size.</param>
    /// <returns>True if the header was read successfully, otherwise false. False also indicates fatal decode error.</returns>
    public bool TryReadTypeAndSize(out HeatType type, out byte size)
    {
        int b = Stream.ReadByte();
        if (b == -1)
        {
            OnFatalDecodeError();
            type = HeatType.Struct;
            size = 0;
            return false;
        }

        type = (HeatType)(b >> 4);
        size = (byte)(b & 0xF);

        // Check if correct data type was provided (union is the last type)
        if (type > HeatType.Union)
        {
            OnFatalDecodeError();
            return false;
        }
        return true;
    }

    /// <summary>
    /// Checks if the reader has enough data to read the specified amount of bytes.
    /// </summary>
    /// <param name="byteCount">The amount of bytes to check for.</param>
    /// <returns>True if the reader has enough data, otherwise false.</returns>
    public bool HasData(int byteCount)
    {
        return Stream.Length - Stream.Position >= byteCount;
    }

    #region VarInt

    /// <summary>
    /// Reads an variable sized integer from the stream.
    /// </summary>
    /// <param name="value">The read value.</param>
    /// <param name="valueHint">The hint for the value.</param>
    /// <returns>True if the value was read successfully, otherwise false. False also indicates fatal decode error.</returns>
    public bool TryReadVarInt(out long value, byte valueHint)
    {
        if (valueHint < 15)
        {
            value = valueHint;
            return true;
        }

        return TryReadVarInt(out value);
    }

    /// <summary>
    /// Reads an variable sized integer from the stream.
    /// </summary>
    /// <param name="value">The read value.</param>
    /// <returns>True if the value was read successfully, otherwise false. False also indicates fatal decode error.</returns>
    public bool TryReadVarInt(out long value)
    {
        long b = Stream.ReadByte();
        value = b;
        if (value == -1)
        {
            OnFatalDecodeError();
            return false;
        }

        bool readNext = (value & 0x80) != 0;
        value &= 0x7F;

        while (readNext)
        {
            b = Stream.ReadByte();
            if (b == -1)
            {
                OnFatalDecodeError();
                return false;
            }

            value = (value << 7) | (b & 0x7F);
            readNext = b >> 7 != 0;
        }

        return true;
    }

    #endregion

    #region Bool

    /// <summary>
    /// Reads a boolean value from the stream.
    /// </summary>
    /// <param name="reader">The reader that will perform the read operation.</param>
    /// <param name="value">The read value.</param>
    /// <param name="sizeHint">The value size hint.</param>
    /// <returns>True if the value was read successfully, otherwise false. False also indicates fatal decode error.</returns>
    public static bool TryReadBool(HeatReader reader, out bool value, byte sizeHint)
    {
        return reader.TryReadBool(out value, sizeHint);
    }

    /// <summary>
    /// Reads a boolean value from the stream.
    /// </summary>
    /// <param name="value">The read value.</param>
    /// <param name="sizeHint"></param>
    /// <returns>True if the value was read successfully, otherwise false. False also indicates fatal decode error.</returns>
    public bool TryReadBool(out bool value, byte sizeHint)
    {
        // Int8 is used to read and write bool values in heat
        if (sizeHint != sizeof(sbyte))
        {
            OnFatalDecodeError();
            value = false;
            return false;
        }

        int b = Stream.ReadByte();
        value = b != 0;
        bool result = b != -1;
        if (!result)
            OnFatalDecodeError();
        return result;
    }

    #endregion

    #region Int8

    /// <summary>
    /// Reads a signed byte value from the stream.
    /// </summary>
    /// <param name="reader">The reader that will perform the read operation.</param>
    /// <param name="value">The read value.</param>
    /// <param name="sizeHint">The value size hint.</param>
    /// <returns>True if the value was read successfully, otherwise false. False also indicates fatal decode error.</returns>
    public static bool TryReadInt8(HeatReader reader, out sbyte value, byte sizeHint)
    {
        return reader.TryReadInt8(out value, sizeHint);
    }

    /// <summary>
    /// Reads a signed byte value from the stream.
    /// </summary>
    /// <param name="value">The read value.</param>
    /// <param name="sizeHint">The value size hint.</param>
    /// <returns>True if the value was read successfully, otherwise false. False also indicates fatal decode error.</returns>
    public bool TryReadInt8(out sbyte value, byte sizeHint)
    {
        if (sizeHint != sizeof(sbyte))
        {
            OnFatalDecodeError();
            value = 0;
            return false;
        }

        int b = Stream.ReadByte();
        value = unchecked((sbyte)b);
        bool result = b != -1;
        if (!result)
            OnFatalDecodeError();
        return result;
    }

    #endregion

    #region UInt8

    /// <summary>
    /// Reads an unsigned byte value from the stream.
    /// </summary>
    /// <param name="reader">The reader that will perform the read operation.</param>
    /// <param name="value">The read value.</param>
    /// <param name="sizeHint">The value size hint.</param>
    /// <returns>True if the value was read successfully, otherwise false. False also indicates fatal decode error.</returns>
    public static bool TryReadUInt8(HeatReader reader, out byte value, byte sizeHint)
    {
        return reader.TryReadUInt8(out value, sizeHint);
    }

    /// <summary>
    /// Reads an unsigned byte value from the stream.
    /// </summary>
    /// <param name="value">The read value.</param>
    /// <param name="sizeHint">The value size hint.</param>
    /// <returns>True if the value was read successfully, otherwise false. False also indicates fatal decode error.</returns>
    public bool TryReadUInt8(out byte value, byte sizeHint)
    {
        if (sizeHint != sizeof(byte))
        {
            OnFatalDecodeError();
            value = 0;
            return false;
        }

        int b = Stream.ReadByte();
        value = unchecked((byte)b);
        bool result = b != -1;
        if (!result)
            OnFatalDecodeError();
        return result;
    }

    #endregion

    #region Int16

    /// <summary>
    /// Reads a signed short value from the stream.
    /// </summary>
    /// <param name="reader">The reader that will perform the read operation.</param>
    /// <param name="value">The read value.</param>
    /// <param name="sizeHint">The value size hint.</param>
    /// <returns>True if the value was read successfully, otherwise false. False also indicates fatal decode error.</returns>
    public static bool TryReadInt16(HeatReader reader, out short value, byte sizeHint)
    {
        return reader.TryReadInt16(out value, sizeHint);
    }

    /// <summary>
    /// Reads a signed short value from the stream.
    /// </summary>
    /// <param name="value">The read value.</param>
    /// <param name="sizeHint">The value size hint.</param>
    /// <returns>True if the value was read successfully, otherwise false. False also indicates fatal decode error.</returns>
    public bool TryReadInt16(out short value, byte sizeHint)
    {
        if (sizeHint != sizeof(short))
        {
            OnFatalDecodeError();
            value = 0;
            return false;
        }

        Span<byte> bytes = stackalloc byte[sizeof(short)];
        if (!Stream.ReadAll(bytes))
        {
            OnFatalDecodeError();
            value = 0;
            return false;
        }

        value = BinaryPrimitives.ReadInt16BigEndian(bytes);
        return true;
    }

    #endregion

    #region UInt16

    /// <summary>
    /// Reads an unsigned short value from the stream.
    /// </summary>
    /// <param name="reader">The reader that will perform the read operation.</param>
    /// <param name="value">The read value.</param>
    /// <param name="sizeHint">The value size hint.</param>
    /// <returns>True if the value was read successfully, otherwise false. False also indicates fatal decode error.</returns>
    public static bool TryReadUInt16(HeatReader reader, out ushort value, byte sizeHint)
    {
        return reader.TryReadUInt16(out value, sizeHint);
    }

    /// <summary>
    /// Reads an unsigned short value from the stream.
    /// </summary>
    /// <param name="value">The read value.</param>
    /// <param name="sizeHint">The value size hint.</param>
    /// <returns>True if the value was read successfully, otherwise false. False also indicates fatal decode error.</returns>
    public bool TryReadUInt16(out ushort value, byte sizeHint)
    {
        if (sizeHint != sizeof(ushort))
        {
            OnFatalDecodeError();
            value = 0;
            return false;
        }

        Span<byte> bytes = stackalloc byte[sizeof(ushort)];
        if (!Stream.ReadAll(bytes))
        {
            OnFatalDecodeError();
            value = 0;
            return false;
        }

        value = BinaryPrimitives.ReadUInt16BigEndian(bytes);
        return true;
    }

    #endregion

    #region Int32

    /// <summary>
    /// Reads a signed integer value from the stream.
    /// </summary>
    /// <param name="reader">The reader that will perform the read operation.</param>
    /// <param name="value">The read value.</param>
    /// <param name="sizeHint">The value size hint.</param>
    /// <returns>True if the value was read successfully, otherwise false. False also indicates fatal decode error.</returns>
    public static bool TryReadInt32(HeatReader reader, out int value, byte sizeHint)
    {
        return reader.TryReadInt32(out value, sizeHint);
    }

    /// <summary>
    /// Reads a signed integer value from the stream.
    /// </summary>
    /// <param name="value">The read value.</param>
    /// <param name="sizeHint">The value size hint.</param>
    /// <returns>True if the value was read successfully, otherwise false. False also indicates fatal decode error.</returns>
    public bool TryReadInt32(out int value, byte sizeHint)
    {
        if (sizeHint != sizeof(int))
        {
            OnFatalDecodeError();
            value = 0;
            return false;
        }

        Span<byte> bytes = stackalloc byte[sizeof(int)];
        if (!Stream.ReadAll(bytes))
        {
            OnFatalDecodeError();
            value = 0;
            return false;
        }

        value = BinaryPrimitives.ReadInt32BigEndian(bytes);
        return true;
    }

    #endregion

    #region UInt32

    /// <summary>
    /// Reads an unsigned integer value from the stream.
    /// </summary>
    /// <param name="reader">The reader that will perform the read operation.</param>
    /// <param name="value">The read value.</param>
    /// <param name="sizeHint">The value size hint.</param>
    /// <returns>True if the value was read successfully, otherwise false. False also indicates fatal decode error.</returns>
    public static bool TryReadUInt32(HeatReader reader, out uint value, byte sizeHint)
    {
        return reader.TryReadUInt32(out value, sizeHint);
    }

    /// <summary>
    /// Reads an unsigned integer value from the stream.
    /// </summary>
    /// <param name="value">The read value.</param>
    /// <param name="sizeHint">The value size hint.</param>
    /// <returns>True if the value was read successfully, otherwise false. False also indicates fatal decode error.</returns>
    public bool TryReadUInt32(out uint value, byte sizeHint)
    {
        if (sizeHint != sizeof(uint))
        {
            OnFatalDecodeError();
            value = 0;
            return false;
        }

        Span<byte> bytes = stackalloc byte[sizeof(uint)];
        if (!Stream.ReadAll(bytes))
        {
            OnFatalDecodeError();
            value = 0;
            return false;
        }

        value = BinaryPrimitives.ReadUInt32BigEndian(bytes);
        return true;
    }

    #endregion

    #region Int64

    /// <summary>
    /// Reads a signed long value from the stream.
    /// </summary>
    /// <param name="reader">The reader that will perform the read operation.</param>
    /// <param name="value">The read value.</param>
    /// <param name="sizeHint">The value size hint.</param>
    /// <returns>True if the value was read successfully, otherwise false. False also indicates fatal decode error.</returns>
    public static bool TryReadInt64(HeatReader reader, out long value, byte sizeHint)
    {
        return reader.TryReadInt64(out value, sizeHint);
    }

    /// <summary>
    /// Reads a signed long value from the stream.
    /// </summary>
    /// <param name="value">The read value.</param>
    /// <param name="sizeHint">The value size hint.</param>
    /// <returns>True if the value was read successfully, otherwise false. False also indicates fatal decode error.</returns>
    public bool TryReadInt64(out long value, byte sizeHint)
    {
        if (sizeHint != sizeof(long))
        {
            OnFatalDecodeError();
            value = 0;
            return false;
        }

        Span<byte> bytes = stackalloc byte[sizeof(long)];
        if (!Stream.ReadAll(bytes))
        {
            OnFatalDecodeError();
            value = 0;
            return false;
        }

        value = BinaryPrimitives.ReadInt64BigEndian(bytes);
        return true;
    }

    #endregion

    #region UInt64

    /// <summary>
    /// Reads an unsigned long value from the stream.
    /// </summary>
    /// <param name="reader">The reader that will perform the read operation.</param>
    /// <param name="value">The read value.</param>
    /// <param name="sizeHint">The value size hint.</param>
    /// <returns>True if the value was read successfully, otherwise false. False also indicates fatal decode error.</returns>
    public static bool TryReadUInt64(HeatReader reader, out ulong value, byte sizeHint)
    {
        return reader.TryReadUInt64(out value, sizeHint);
    }

    /// <summary>
    /// Reads an unsigned long value from the stream.
    /// </summary>
    /// <param name="value">The read value.</param>
    /// <param name="sizeHint">The value size hint.</param>
    /// <returns>True if the value was read successfully, otherwise false. False also indicates fatal decode error.</returns>
    public bool TryReadUInt64(out ulong value, byte sizeHint)
    {
        if (sizeHint != sizeof(ulong))
        {
            OnFatalDecodeError();
            value = 0;
            return false;
        }

        Span<byte> bytes = stackalloc byte[sizeof(ulong)];
        if (!Stream.ReadAll(bytes))
        {
            OnFatalDecodeError();
            value = 0;
            return false;
        }

        value = BinaryPrimitives.ReadUInt64BigEndian(bytes);
        return true;
    }

    #endregion

    #region Blob

    /// <summary>
    /// Reads a blob value from the stream.
    /// </summary>
    /// <param name="reader">The reader that will perform the read operation.</param>
    /// <param name="value">The read value.</param>
    /// <param name="sizeHint">The value size hint.</param>
    /// <returns>True if the value was read successfully, otherwise false. False also indicates fatal decode error.</returns>
    public static bool TryReadBlob(HeatReader reader, out byte[] value, byte sizeHint)
    {
        return reader.TryReadBlob(out value, sizeHint);
    }

    /// <summary>
    /// Reads a blob value from the stream.
    /// </summary>
    /// <param name="value">The read value.</param>
    /// <param name="sizeHint">The value size hint.</param>
    /// <returns>True if the value was read successfully, otherwise false. False also indicates fatal decode error.</returns>
    public bool TryReadBlob(out byte[] value, byte sizeHint)
    {
        if (!TryReadVarInt(out long length, sizeHint) || length < 0)
        {
            value = Array.Empty<byte>();
            return false;
        }

        value = new byte[length];
        if (!Stream.ReadAll(value))
        {
            OnFatalDecodeError();
            return false;
        }

        return true;
    }

    #endregion

    #region String

    /// <summary>
    /// Reads a string value from the stream.
    /// </summary>
    /// <param name="reader">The reader that will perform the read operation.</param>
    /// <param name="value">The read value.</param>
    /// <param name="sizeHint">The value size hint.</param>
    /// <returns>True if the value was read successfully, otherwise false. False also indicates fatal decode error.</returns>
    public static bool TryReadString(HeatReader reader, out string value, byte sizeHint)
    {
        return reader.TryReadString(out value, sizeHint);
    }

    /// <summary>
    /// Reads a string value from the stream.
    /// </summary>
    /// <param name="value">The read value.</param>
    /// <param name="sizeHint">The value size hint.</param>
    /// <returns>True if the value was read successfully, otherwise false. False also indicates fatal decode error.</returns>
    public bool TryReadString(out string value, byte sizeHint)
    {
        if (!TryReadVarInt(out long strLen, sizeHint) || strLen < 0)
        {
            value = string.Empty;
            return false;
        }

        int length = (int)strLen;

        byte[]? rentedPool = null;

        Span<byte> bytes =
            length > MaxStackAlloc
            ? new Span<byte>(rentedPool = ArrayPool<byte>.Shared.Rent(length), 0, length)
            : stackalloc byte[length];

        if (!Stream.ReadAll(bytes))
        {
            OnFatalDecodeError();
            value = string.Empty;
            return false;
        }

        int len = bytes.Length;
        if (len > 0)
        {
            int lengthWithoutTrailingByte = len - 1;
            if (bytes[lengthWithoutTrailingByte] == 0x00)
                len = lengthWithoutTrailingByte;
        }

        Span<byte> strBytes = bytes.Slice(0, len);
        value = StringEncoder.GetString(strBytes);

        // return the rented pool if used
        if (rentedPool != null)
            ArrayPool<byte>.Shared.Return(rentedPool);

        return true;
    }

    #endregion

    #region List

    /// <summary>
    /// Reads a list value from the stream.
    /// </summary>
    /// <typeparam name="T">The type of the list elements.</typeparam>
    /// <param name="value">The read value.</param>
    /// <param name="sizeHint">The value size hint.</param>
    /// <returns>True if the value was read successfully, otherwise false. False does not necessarily mean, that the stream is corrupted, it just means that the value could not be read (for e.g. with the specified list type). If there isn't a fatal error, the reader will be restored to the state before the read operation.</returns>
    public bool TryReadList<T>(out IList<T> value, byte sizeHint)
    {
        Type valueType = typeof(IList<T>);
        TypeReader<IList<T>> reader = (TypeReader<IList<T>>)_typeReaders.GetOrAdd(valueType, createListTypeReader<T>);
        return reader(this, out value, sizeHint);
    }

    public static bool TryReadUnknownList(HeatReader reader, out IList value, byte sizeHint)
    {
        RestorePoint checkpoint = reader.CreateRestorePoint();

        if (!reader.TryReadVarInt(out long count, sizeHint) || count < 0)
        {
            value = new List<object>();
            return false;
        };

        if (!reader.TryReadTypeAndSize(out HeatType type, out byte elementSizeHint))
        {
            value = new List<object>();
            return false;
        }

        value = HeatUtil.CreateListOfType(type);
        TypeReader itemReader = GetTypeReader(type);

        for (long i = 0; i < count; i++)
        {
            if (!itemReader(reader, out object? item, elementSizeHint))
                return false;

            value.Add(item);
        }

        return true;
    }

    static TypeReader<IList<T>> createListTypeReader<T>(Type listType)
    {
        TypeReader<T> itemReader = GetTypeReader<T>();

        return (HeatReader reader, out IList<T> value, byte sizeHint) =>
        {
            RestorePoint checkpoint = reader.CreateRestorePoint();

            if (!reader.TryReadVarInt(out long count) || count < 0)
            {
                value = new List<T>();
                return false;
            };

            if (!reader.TryReadTypeAndSize(out HeatType type, out byte elementSizeHint))
            {
                value = new List<T>();
                return false;
            }

            if (!HeatUtil.AreTypesCompatible(typeof(T), type))
            {
                //Note: this is not a fatal error, we have to restore the reader to the previous state
                value = new List<T>();
                reader.RestoreTo(checkpoint);
                return false;
            }

            value = new List<T>((int)count);

            for (long i = 0; i < count; i++)
            {
                if (!itemReader(reader, out T item, elementSizeHint))
                    return false;

                value.Add(item);
            }

            return true;
        };
    }

    #endregion

    #region Map

    /// <summary>
    /// Reads a map value from the stream.
    /// </summary>
    /// <typeparam name="TKey">The key type of the map.</typeparam>
    /// <typeparam name="TValue">The value type of the map.</typeparam>
    /// <param name="value">The read value.</param>
    /// <param name="sizeHint">The value size hint.</param>
    /// <returns>True if the value was read successfully, otherwise false. False does not necessarily mean, that the stream is corrupted, it just means that the value could not be read (for e.g. with the specified map type). If there isn't a fatal error, the reader will be restored to the state before the read operation.</returns>
    public bool TryReadMap<TKey, TValue>(out IDictionary<TKey, TValue> value, byte sizeHint) where TKey : notnull
    {
        Type valueType = typeof(IDictionary<TKey, TValue>);
        TypeReader<IDictionary<TKey, TValue>> reader = (TypeReader<IDictionary<TKey, TValue>>)_typeReaders.GetOrAdd(valueType, createMapTypeReader<TKey, TValue>);
        return reader(this, out value, sizeHint);
    }

    static bool TryReadUnknownMap(HeatReader reader, out IDictionary value, byte sizeHint)
    {
        RestorePoint rp = reader.CreateRestorePoint();

        if (!reader.TryReadVarInt(out long count, sizeHint) || count < 0)
        {
            value = new SortedDictionary<object, object>();
            return false;
        };

        if (!reader.TryReadTypeAndSize(out HeatType keyType, out byte keySize))
        {
            value = new SortedDictionary<object, object>();
            return false;
        }

        TypeReader keyReader = GetTypeReader(keyType);
        if (!keyReader(reader, out object? firstPairKey, keySize))
        {
            value = new SortedDictionary<object, object>();
            return false;
        }

        if (!reader.TryReadTypeAndSize(out HeatType valueType, out byte valueSize))
        {
            value = new SortedDictionary<object, object>();
            return false;
        }

        TypeReader valueReader = GetTypeReader(valueType);
        if (!valueReader(reader, out object? firstPairValue, valueSize))
        {
            value = new SortedDictionary<object, object>();
            return false;
        }

        value = HeatUtil.CreateDictionaryOfType(keyType, valueType);
        value.Add(firstPairKey!, firstPairValue);

        // Read the rest of the map
        for (long i = 1; i < count; i++)
        {
            if (!keyReader(reader, out object? key, keySize))
                return false;

            if (!valueReader(reader, out object? val, valueSize))
                return false;

            value.Add(key!, val);
        }

        return true;
    }

    static TypeReader<IDictionary<TKey, TValue>> createMapTypeReader<TKey, TValue>(Type mapType) where TKey : notnull
    {
        TypeReader<TKey> keyReader = GetTypeReader<TKey>();
        TypeReader<TValue> valueReader = GetTypeReader<TValue>();

        return (HeatReader reader, out IDictionary<TKey, TValue> value, byte sizeHint) =>
        {
            RestorePoint rp = reader.CreateRestorePoint();

            if (!reader.TryReadVarInt(out long count, sizeHint) || count < 0)
            {
                value = new SortedDictionary<TKey, TValue>();
                return false;
            };

            if (!reader.TryReadTypeAndSize(out HeatType keyType, out byte keySize))
            {
                value = new SortedDictionary<TKey, TValue>();
                return false;
            }

            if (!HeatUtil.AreTypesCompatible(typeof(TKey), keyType))
            {
                value = new SortedDictionary<TKey, TValue>();
                reader.RestoreTo(rp);
                return false;
            }

            if (!keyReader(reader, out TKey firstPairKey, keySize))
            {
                value = new SortedDictionary<TKey, TValue>();
                return false;
            }

            if (!reader.TryReadTypeAndSize(out HeatType valueType, out byte valueSize))
            {
                value = new SortedDictionary<TKey, TValue>();
                return false;
            }

            if (!HeatUtil.AreTypesCompatible(typeof(TValue), valueType))
            {
                value = new SortedDictionary<TKey, TValue>();
                reader.RestoreTo(rp);
                return false;
            }

            if (!valueReader(reader, out TValue firstPairValue, valueSize))
            {
                value = new SortedDictionary<TKey, TValue>();
                return false;
            }

            value = new SortedDictionary<TKey, TValue>()
            {
                { firstPairKey, firstPairValue }
            };

            // Read the rest of the map
            for (long i = 1; i < count; i++)
            {
                if (!keyReader(reader, out TKey key, keySize))
                    return false;

                if (!valueReader(reader, out TValue val, valueSize))
                    return false;

                value.Add(key, val);
            }

            return true;
        };
    }

    #endregion

    #region Restore points
    public RestorePoint CreateRestorePoint()
    {
        return new RestorePoint(Stream.Position, StreamValid);
    }

    public void RestoreTo(RestorePoint restorePoint)
    {
        Stream.Position = restorePoint.Position;
        StreamValid = restorePoint.StreamValid;
    }
    #endregion


    public bool TrySkipNextElement(Tdf parent)
    {
        if(!StreamValid)
            return false;

        RestorePoint rp = CreateRestorePoint();

        if (!TryReadHeatMemberHeader(out HeatMemberHeader header))
        {
            OnFatalDecodeError();
            return false;
        }
            
        ITdfMember? member = createNewMemberFromHeader(header);
        if (member == null)
        {
            OnFatalDecodeError();
            return false;
        }

        RestoreTo(rp);

        parent.GetUnknownMembers().Add(member);
        return member.Visit(Decoder, parent);
    }

    ITdfMember? createNewMemberFromHeader(HeatMemberHeader header)
    {
        TdfType asTdfType = HeatUtil.ToTdfType(header.Type);
        TdfMemberInfo info = new TdfMemberInfo(header.Tag, asTdfType);

        RestorePoint rp = CreateRestorePoint();

        return header.Type switch
        {
            HeatType.Struct => new TdfStruct<EmptyMessage>(info),
            HeatType.String => new TdfString(info),
            HeatType.Int8 => new TdfInt8(info),
            HeatType.UInt8 => new TdfUInt8(info),
            HeatType.Int16 => new TdfInt16(info),
            HeatType.UInt16 => new TdfUInt16(info),
            HeatType.Int32 => new TdfInt32(info),
            HeatType.UInt32 => new TdfUInt32(info),
            HeatType.Int64 => new TdfInt64(info),
            HeatType.UInt64 => new TdfUInt64(info),
            HeatType.Array => createNewListMember(info),
            HeatType.Blob => new TdfBlob(info),
            HeatType.Map => createNewMapMember(info, header.SizeHint),
            HeatType.Union => new TdfUnion<Union>(info),
            _ => null,
        };
    }

    ITdfMember? createNewListMember(TdfMemberInfo info)
    {
        if (!peekListType(out HeatType listType))
            return null;

        return listType switch
        {
            HeatType.Struct => new TdfList<EmptyMessage>(info),
            HeatType.String => new TdfList<string>(info),
            HeatType.Int8 => new TdfList<sbyte>(info),
            HeatType.UInt8 => new TdfList<byte>(info),
            HeatType.Int16 => new TdfList<short>(info),
            HeatType.UInt16 => new TdfList<ushort>(info),
            HeatType.Int32 => new TdfList<int>(info),
            HeatType.UInt32 => new TdfList<uint>(info),
            HeatType.Int64 => new TdfList<long>(info),
            HeatType.UInt64 => new TdfList<ulong>(info),
            HeatType.Array => new TdfList<IList>(info), // we can't determine the list type, so generic IList is used
            HeatType.Blob => new TdfList<byte[]>(info),
            HeatType.Map => new TdfList<IDictionary>(info), // same as above
            HeatType.Union => new TdfList<Union>(info),
            _ => null
        };
    }

    ITdfMember? createNewMapMember(TdfMemberInfo info, byte mapSizeHint)
    {
        if (!peekMapType(mapSizeHint, out HeatType keyHeatType, out HeatType valueHeatType))
            return null;

        Type keyType = HeatUtil.ToType(keyHeatType);
        Type valueType = HeatUtil.ToType(valueHeatType);

        return (ITdfMember?)Activator.CreateInstance(typeof(TdfMap<,>).MakeGenericType(keyType, valueType), info);
    }


    bool peekListType(out HeatType listType)
    {
        RestorePoint rp = CreateRestorePoint();

        // count
        if (!TryReadVarInt(out long count) || count <= 0)
        {
            RestoreTo(rp);
            listType = HeatType.Struct;
            return false;
        };

        bool success = TryReadTypeAndSize(out listType, out _);
        RestoreTo(rp);
        return success;
    }


    bool peekMapType(byte mapSizeHint, out HeatType keyType, out HeatType valueType)
    {
        keyType = HeatType.Struct;
        valueType = HeatType.Struct;

        RestorePoint rp = CreateRestorePoint();

        // count
        if (!TryReadVarInt(out long count, mapSizeHint) || count <= 0)
        {
            RestoreTo(rp);
            return false;
        };

        if (!TryReadTypeAndSize(out keyType, out byte keySize))
        {
            RestoreTo(rp);
            return false;
        }

        TypeReader keyReader = GetTypeReader(keyType);

        if (!keyReader(this, out _, keySize))
        {
            RestoreTo(rp);
            return false;
        }

        if (!TryReadTypeAndSize(out valueType, out _))
        {
            RestoreTo(rp);
            return false;
        }

        RestoreTo(rp);
        return true;
    }

    public void OnFatalDecodeError()
    {
        StreamValid = false;
    }

    public static bool TryReadStruct<TStruct>(HeatReader reader, [NotNullWhen(true)] out TStruct? val, byte sizeHint) where TStruct : Tdf?, new()
    {
        return reader.TryReadStruct(out val, sizeHint);
    }

    public bool TryReadStruct<TStruct>([NotNull] out TStruct? val, byte sizeHint) where TStruct : Tdf?, new()
    {
        val = new TStruct();
        return TryReadStruct(val);
    }

    public bool TryReadStruct(Tdf val)
    {
        ITdfMember[] members = val.GetMembers();
        int currentMember = 0;

        int b;
        while ((b = Stream.ReadByte()) != 0x00)
        {
            if (b == -1)
            {
                // Unexpected end of stream
                OnFatalDecodeError();
                return false;
            }

            // go back one byte
            Stream.Position--;

            if (currentMember >= members.Length)
            {
                if (!TrySkipNextElement(val))
                    return false;

                continue;
            }

            ITdfMember member = members[currentMember++];
            bool visited = member.Visit(Decoder, val);

            if (visited && !member.TdfInfo.IsUnique)
            {
                // Skip all other members with the same tag (field id)
                while(currentMember < members.Length && members[currentMember].TdfInfo.Tag == member.TdfInfo.Tag)
                    currentMember++;
            }

        }
        return true;
    }

    public static bool TryReadUnion<TUnion>(HeatReader reader, out TUnion val, byte sizeHint) where TUnion : Union, new()
    {
        return reader.TryReadUnion(out val, sizeHint);
    }

    internal bool TryReadUnion<TUnion>(out TUnion val, byte sizeHint) where TUnion : Union, new()
    {
        val = new TUnion();
        return TryReadUnion(val);
    }

    public bool TryReadUnion(Union val)
    {
        int activeIndex = Stream.ReadByte();
        if (activeIndex == -1)
        {
            OnFatalDecodeError();
            return false;
        }

        if (activeIndex == Union.UnsetIndex)
        {
            val.Reset();
            return true;
        }

        val.SwitchActiveIndex((byte)activeIndex);

        if (!val.Visit(Decoder, val))
            return TrySkipNextElement(val);

        return true;
    }

    internal bool TryReadEnum<TEnum>(out TEnum value, byte sizeHint) where TEnum : Enum, new()
    {
        Type valueType = typeof(TEnum);
        TypeReader<TEnum> reader = (TypeReader<TEnum>)_typeReaders.GetOrAdd(valueType, createEnumTypeReader<TEnum>);
        return reader(this, out value, sizeHint);
    }

    static TypeReader<TEnum> createEnumTypeReader<TEnum>(Type type)
    {
        return Type.GetTypeCode(typeof(TEnum)) switch
        {
            TypeCode.SByte => (HeatReader reader, [NotNullWhen(true)] out TEnum value, byte sizeHint) =>
            {
                bool result = reader.TryReadInt8(out sbyte val, sizeHint);
                value = (TEnum)Enum.ToObject(typeof(TEnum), val);
                return result;
            }
            ,
            TypeCode.Byte => (HeatReader reader, [NotNullWhen(true)] out TEnum value, byte sizeHint) =>
            {
                bool result = reader.TryReadUInt8(out byte val, sizeHint);
                value = (TEnum)Enum.ToObject(typeof(TEnum), val);
                return result;
            }
            ,
            TypeCode.Int16 => (HeatReader reader, [NotNullWhen(true)] out TEnum value, byte sizeHint) =>
            {
                bool result = reader.TryReadInt16(out short val, sizeHint);
                value = (TEnum)Enum.ToObject(typeof(TEnum), val);
                return result;
            }
            ,
            TypeCode.UInt16 => (HeatReader reader, [NotNullWhen(true)] out TEnum value, byte sizeHint) =>
            {
                bool result = reader.TryReadUInt16(out ushort val, sizeHint);
                value = (TEnum)Enum.ToObject(typeof(TEnum), val);
                return result;
            }
            ,
            TypeCode.Int32 => (HeatReader reader, [NotNullWhen(true)] out TEnum value, byte sizeHint) =>
            {
                bool result = reader.TryReadInt32(out int val, sizeHint);
                value = (TEnum)Enum.ToObject(typeof(TEnum), val);
                return result;
            }
            ,
            TypeCode.UInt32 => (HeatReader reader, [NotNullWhen(true)] out TEnum value, byte sizeHint) =>
            {
                bool result = reader.TryReadUInt32(out uint val, sizeHint);
                value = (TEnum)Enum.ToObject(typeof(TEnum), val);
                return result;
            }
            ,
            TypeCode.Int64 => (HeatReader reader, [NotNullWhen(true)] out TEnum value, byte sizeHint) =>
            {
                bool result = reader.TryReadInt64(out long val, sizeHint);
                value = (TEnum)Enum.ToObject(typeof(TEnum), val);
                return result;
            }
            ,
            TypeCode.UInt64 => (HeatReader reader, [NotNullWhen(true)] out TEnum value, byte sizeHint) =>
            {
                bool result = reader.TryReadUInt64(out ulong val, sizeHint);
                value = (TEnum)Enum.ToObject(typeof(TEnum), val);
                return result;
            }
            ,
            _ => (HeatReader reader, [NotNullWhen(true)] out TEnum value, byte sizeHint) =>
            {
                reader.OnFatalDecodeError();
                value = default!;
                return false;
            }
        };
    }
}
