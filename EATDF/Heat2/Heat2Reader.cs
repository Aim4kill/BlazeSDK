using EATDF.Extensions;
using EATDF.Heat;
using EATDF.Internal;
using EATDF.Members;
using EATDF.Types;
using EATDF.Visitors;
using System;
using System.Buffers;
using System.Buffers.Binary;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EATDF.Heat2;

internal class Heat2Reader(Heat2Decoder decoder, Stream stream)
{
    /// <summary>
    /// Maximum allowed size to stack allocate before falling back to heap allocation.
    /// </summary>
    const int MaxStackAlloc = 512;

    /// <summary>
    /// The string encoder to use for decoding strings.
    /// </summary>
    static readonly Encoding StringEncoder = Encoding.UTF8;

    /// <summary>
    /// 3 bytes for tag, 1 byte for type
    /// </summary>
    public const int HeaderSize = 4;

    /// <summary>
    /// The decoder that created this reader
    /// </summary>
    public Heat2Decoder Decoder { get; } = decoder;

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
    /// <returns>True if the value was read successfully, otherwise false. False does not necessarily mean, that the stream is corrupted, it just means that the value could not be read.</returns>
    delegate bool TypeReader<T>(Heat2Reader reader, [NotNullWhen(true)] out T value);
    delegate bool TypeReader(Heat2Reader reader, [NotNullWhen(true)] out object? value);

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
        [typeof(ObjectType)] = new TypeReader<ObjectType>(TryReadObjectType),
        [typeof(ObjectId)] = new TypeReader<ObjectId>(TryReadObjectId),
        [typeof(float)] = new TypeReader<float>(TryReadFloat),

        //// for lists and maps of unknown type arguments
        [typeof(IList)] = new TypeReader<IList>(TryReadUnknownList),
        [typeof(IDictionary)] = new TypeReader<IDictionary>(TryReadUnknownMap),
    };

    static readonly ConcurrentDictionary<Heat2Type, TypeReader> _heat2TypeReaders = new ConcurrentDictionary<Heat2Type, TypeReader>()
    {
        [Heat2Type.Integer] = ToSimpleTypeReader<long>(TryReadInt64),
        [Heat2Type.String] = ToSimpleTypeReader<string>(TryReadString),
        [Heat2Type.Binary] = ToSimpleTypeReader<byte[]>(TryReadBlob),
        [Heat2Type.Struct] = ToSimpleTypeReader<EmptyMessage?>(TryReadStruct),
        [Heat2Type.List] = ToSimpleTypeReader<IList>(TryReadUnknownList),
        [Heat2Type.Map] = ToSimpleTypeReader<IDictionary>(TryReadUnknownMap),
        [Heat2Type.Union] = ToSimpleTypeReader<Union>(TryReadUnion),
        [Heat2Type.Variable] = ToSimpleTypeReader<object?>(TryReadVariable),
        [Heat2Type.BlazeObjectType] = ToSimpleTypeReader<ObjectType>(TryReadObjectType),
        [Heat2Type.BlazeObjectId] = ToSimpleTypeReader<ObjectId>(TryReadObjectId),
        [Heat2Type.Float] = ToSimpleTypeReader<float>(TryReadFloat),
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

    static TypeReader GetTypeReader(Heat2Type type)
    {
        if (_heat2TypeReaders.TryGetValue(type, out TypeReader? reader))
            return reader;

        // Unknown type :(
        return (Heat2Reader reader, [NotNullWhen(true)] out object? value) =>
        {
            reader.OnFatalDecodeError();
            value = null;
            return false;
        };

    }

    static TypeReader ToSimpleTypeReader<T>(TypeReader<T> typeReader)
    {
        return (Heat2Reader reader, [NotNullWhen(true)] out object? value) =>
        {
            if (!typeReader(reader, out T val))
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

        if (type.IsSubclassOf(typeof(Union)))
            return (Heat2Reader reader, [NotNullWhen(true)] out T value) =>
            {
                Union union = (Union)Activator.CreateInstance(type)!;
                value = (T)(object)union!;
                return reader.TryReadUnion(union);
            };


        if (type.IsSubclassOf(typeof(Tdf)))
            return (Heat2Reader reader, [NotNullWhen(true)] out T value) =>
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

        // Unknown type :(
        return (Heat2Reader reader, [NotNullWhen(true)] out T value) =>
        {
            reader.OnFatalDecodeError();
            value = default!;
            return false;
        };
    }


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


    /// <summary>
    /// Checks if the reader has enough data to read the specified amount of bytes.
    /// </summary>
    /// <param name="byteCount">The amount of bytes to check for.</param>
    /// <returns>True if the reader has enough data, otherwise false.</returns>
    public bool HasData(int byteCount)
    {
        return Stream.Length - Stream.Position >= byteCount;
    }

    /// <summary>
    /// Reads the header of the next value from the stream.
    /// </summary>
    /// <returns>True if the header was read successfully, otherwise false. False also indicates fatal decode error.</returns>
    public bool TryReadHeat2MemberHeader(out Heat2MemberHeader header)
    {
        Span<byte> bytes = stackalloc byte[HeaderSize];

        if (!Stream.ReadAll(bytes))
        {
            OnFatalDecodeError();
            header = Heat2MemberHeader.Invalid;
            return false;
        }

        header = new Heat2MemberHeader()
        {
            Tag = unchecked((uint)(bytes[0] << 24 | bytes[1] << 16 | bytes[2] << 8)),
            Type = (Heat2Type)(bytes[3])
        };

        // Check if correct data type was provided (float is the last type) (timevalue type is not used)
        if (header.Type > Heat2Type.Float)
        {
            OnFatalDecodeError();
            return false;
        }

        return true;
    }

    public bool TryPeekHeat2MemberHeader(out Heat2MemberHeader header)
    {
        RestorePoint rp = CreateRestorePoint();
        bool result = TryReadHeat2MemberHeader(out header);
        RestoreTo(rp);
        return result;
    }

    public void OnFatalDecodeError()
    {
        StreamValid = false;
    }

    #region VarInt
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

        byte i = 6;

        bool negative = (value & 0x40) != 0;
        bool readNext = (value & 0x80) != 0;
        value &= 0x3F;

        while (readNext)
        {
            b = Stream.ReadByte();
            if (b == -1)
            {
                OnFatalDecodeError();
                return false;
            }

            value |= (b & 0x7F) << i;
            i += 7;

            readNext = b >> 7 != 0;
        }

        if (negative)
        {
            if (value != 0)
                value = -value;
            else
                value = long.MinValue;
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
    /// <returns>True if the value was read successfully, otherwise false. False also indicates fatal decode error.</returns>
    public static bool TryReadBool(Heat2Reader reader, out bool value)
    {
        return reader.TryReadBool(out value);
    }

    /// <summary>
    /// Reads a boolean value from the stream.
    /// </summary>
    /// <param name="value">The read value.</param>
    /// <returns>True if the value was read successfully, otherwise false. False also indicates fatal decode error.</returns>
    public bool TryReadBool(out bool value)
    {
        if (!TryReadVarInt(out long val))
        {
            value = false;
            return false;
        }

        value = val != 0;
        return true;
    }

    #endregion

    #region Int8

    /// <summary>
    /// Reads a signed byte value from the stream.
    /// </summary>
    /// <param name="reader">The reader that will perform the read operation.</param>
    /// <param name="value">The read value.</param>
    /// <returns>True if the value was read successfully, otherwise false. False also indicates fatal decode error.</returns>
    public static bool TryReadInt8(Heat2Reader reader, out sbyte value)
    {
        return reader.TryReadInt8(out value);
    }

    /// <summary>
    /// Reads a signed byte value from the stream.
    /// </summary>
    /// <param name="value">The read value.</param>
    /// <returns>True if the value was read successfully, otherwise false. False also indicates fatal decode error.</returns>
    public bool TryReadInt8(out sbyte value)
    {
        if (!TryReadVarInt(out long val))
        {
            value = 0;
            return false;
        }

        value = unchecked((sbyte)val);
        return true;
    }

    #endregion

    #region UInt8

    /// <summary>
    /// Reads an unsigned byte value from the stream.
    /// </summary>
    /// <param name="reader">The reader that will perform the read operation.</param>
    /// <param name="value">The read value.</param>
    /// <returns>True if the value was read successfully, otherwise false. False also indicates fatal decode error.</returns>
    public static bool TryReadUInt8(Heat2Reader reader, out byte value)
    {
        return reader.TryReadUInt8(out value);
    }

    /// <summary>
    /// Reads an unsigned byte value from the stream.
    /// </summary>
    /// <param name="value">The read value.</param>
    /// <returns>True if the value was read successfully, otherwise false. False also indicates fatal decode error.</returns>
    public bool TryReadUInt8(out byte value)
    {
        if (!TryReadVarInt(out long val))
        {
            value = 0;
            return false;
        }

        value = unchecked((byte)val);
        return true;
    }

    #endregion

    #region Int16

    /// <summary>
    /// Reads a signed short value from the stream.
    /// </summary>
    /// <param name="reader">The reader that will perform the read operation.</param>
    /// <param name="value">The read value.</param>
    /// <returns>True if the value was read successfully, otherwise false. False also indicates fatal decode error.</returns>
    public static bool TryReadInt16(Heat2Reader reader, out short value)
    {
        return reader.TryReadInt16(out value);
    }

    /// <summary>
    /// Reads a signed short value from the stream.
    /// </summary>
    /// <param name="value">The read value.</param>
    /// <returns>True if the value was read successfully, otherwise false. False also indicates fatal decode error.</returns>
    public bool TryReadInt16(out short value)
    {
        if (!TryReadVarInt(out long val))
        {
            value = 0;
            return false;
        }

        value = unchecked((short)val);
        return true;
    }

    #endregion

    #region UInt16

    /// <summary>
    /// Reads an unsigned short value from the stream.
    /// </summary>
    /// <param name="reader">The reader that will perform the read operation.</param>
    /// <param name="value">The read value.</param>
    /// <returns>True if the value was read successfully, otherwise false. False also indicates fatal decode error.</returns>
    public static bool TryReadUInt16(Heat2Reader reader, out ushort value)
    {
        return reader.TryReadUInt16(out value);
    }

    /// <summary>
    /// Reads an unsigned short value from the stream.
    /// </summary>
    /// <param name="value">The read value.</param>
    /// <returns>True if the value was read successfully, otherwise false. False also indicates fatal decode error.</returns>
    public bool TryReadUInt16(out ushort value)
    {
        if (!TryReadVarInt(out long val))
        {
            value = 0;
            return false;
        }

        value = unchecked((ushort)val);
        return true;
    }

    #endregion

    #region Int32

    /// <summary>
    /// Reads a signed integer value from the stream.
    /// </summary>
    /// <param name="reader">The reader that will perform the read operation.</param>
    /// <param name="value">The read value.</param>
    /// <returns>True if the value was read successfully, otherwise false. False also indicates fatal decode error.</returns>
    public static bool TryReadInt32(Heat2Reader reader, out int value)
    {
        return reader.TryReadInt32(out value);
    }

    /// <summary>
    /// Reads a signed integer value from the stream.
    /// </summary>
    /// <param name="value">The read value.</param>
    /// <returns>True if the value was read successfully, otherwise false. False also indicates fatal decode error.</returns>
    public bool TryReadInt32(out int value)
    {
        if (!TryReadVarInt(out long val))
        {
            value = 0;
            return false;
        }

        value = unchecked((int)val);
        return true;
    }

    #endregion

    #region UInt32

    /// <summary>
    /// Reads an unsigned integer value from the stream.
    /// </summary>
    /// <param name="reader">The reader that will perform the read operation.</param>
    /// <param name="value">The read value.</param>
    /// <returns>True if the value was read successfully, otherwise false. False also indicates fatal decode error.</returns>
    public static bool TryReadUInt32(Heat2Reader reader, out uint value)
    {
        return reader.TryReadUInt32(out value);
    }

    /// <summary>
    /// Reads an unsigned integer value from the stream.
    /// </summary>
    /// <param name="value">The read value.</param>
    /// <returns>True if the value was read successfully, otherwise false. False also indicates fatal decode error.</returns>
    public bool TryReadUInt32(out uint value)
    {
        if (!TryReadVarInt(out long val))
        {
            value = 0;
            return false;
        }

        value = unchecked((uint)val);
        return true;
    }

    #endregion

    #region Int64

    /// <summary>
    /// Reads a signed long value from the stream.
    /// </summary>
    /// <param name="reader">The reader that will perform the read operation.</param>
    /// <param name="value">The read value.</param>
    /// <returns>True if the value was read successfully, otherwise false. False also indicates fatal decode error.</returns>
    public static bool TryReadInt64(Heat2Reader reader, out long value)
    {
        return reader.TryReadInt64(out value);
    }

    /// <summary>
    /// Reads a signed long value from the stream.
    /// </summary>
    /// <param name="value">The read value.</param>
    /// <returns>True if the value was read successfully, otherwise false. False also indicates fatal decode error.</returns>
    public bool TryReadInt64(out long value)
    {
        return TryReadVarInt(out value);
    }

    #endregion

    #region UInt64

    /// <summary>
    /// Reads an unsigned long value from the stream.
    /// </summary>
    /// <param name="reader">The reader that will perform the read operation.</param>
    /// <param name="value">The read value.</param>
    /// <returns>True if the value was read successfully, otherwise false. False also indicates fatal decode error.</returns>
    public static bool TryReadUInt64(Heat2Reader reader, out ulong value)
    {
        return reader.TryReadUInt64(out value);
    }

    /// <summary>
    /// Reads an unsigned long value from the stream.
    /// </summary>
    /// <param name="value">The read value.</param>
    /// <returns>True if the value was read successfully, otherwise false. False also indicates fatal decode error.</returns>
    public bool TryReadUInt64(out ulong value)
    {
        if (!TryReadVarInt(out long val))
        {
            value = 0;
            return false;
        }

        value = unchecked((ulong)val);
        return true;
    }

    #endregion

    #region Enum

    public bool TryReadEnum<TEnum>(out TEnum value) where TEnum : Enum, new()
    {
        Type valueType = typeof(TEnum);
        TypeReader<TEnum> reader = (TypeReader<TEnum>)_typeReaders.GetOrAdd(valueType, createEnumTypeReader<TEnum>);
        return reader(this, out value);
    }

    static TypeReader<TEnum> createEnumTypeReader<TEnum>(Type type)
    {
        return Type.GetTypeCode(typeof(TEnum)) switch
        {
            TypeCode.SByte => (Heat2Reader reader, [NotNullWhen(true)] out TEnum value) =>
            {
                bool result = reader.TryReadInt8(out sbyte val);
                value = (TEnum)Enum.ToObject(typeof(TEnum), val);
                return result;
            }
            ,
            TypeCode.Byte => (Heat2Reader reader, [NotNullWhen(true)] out TEnum value) =>
            {
                bool result = reader.TryReadUInt8(out byte val);
                value = (TEnum)Enum.ToObject(typeof(TEnum), val);
                return result;
            }
            ,
            TypeCode.Int16 => (Heat2Reader reader, [NotNullWhen(true)] out TEnum value) =>
            {
                bool result = reader.TryReadInt16(out short val);
                value = (TEnum)Enum.ToObject(typeof(TEnum), val);
                return result;
            }
            ,
            TypeCode.UInt16 => (Heat2Reader reader, [NotNullWhen(true)] out TEnum value) =>
            {
                bool result = reader.TryReadUInt16(out ushort val);
                value = (TEnum)Enum.ToObject(typeof(TEnum), val);
                return result;
            }
            ,
            TypeCode.Int32 => (Heat2Reader reader, [NotNullWhen(true)] out TEnum value) =>
            {
                bool result = reader.TryReadInt32(out int val);
                value = (TEnum)Enum.ToObject(typeof(TEnum), val);
                return result;
            }
            ,
            TypeCode.UInt32 => (Heat2Reader reader, [NotNullWhen(true)] out TEnum value) =>
            {
                bool result = reader.TryReadUInt32(out uint val);
                value = (TEnum)Enum.ToObject(typeof(TEnum), val);
                return result;
            }
            ,
            TypeCode.Int64 => (Heat2Reader reader, [NotNullWhen(true)] out TEnum value) =>
            {
                bool result = reader.TryReadInt64(out long val);
                value = (TEnum)Enum.ToObject(typeof(TEnum), val);
                return result;
            }
            ,
            TypeCode.UInt64 => (Heat2Reader reader, [NotNullWhen(true)] out TEnum value) =>
            {
                bool result = reader.TryReadUInt64(out ulong val);
                value = (TEnum)Enum.ToObject(typeof(TEnum), val);
                return result;
            }
            ,
            _ => (Heat2Reader reader, [NotNullWhen(true)] out TEnum value) =>
            {
                reader.OnFatalDecodeError();
                value = default!;
                return false;
            }
        };
    }

    #endregion

    #region String

    /// <summary>
    /// Reads a string value from the stream.
    /// </summary>
    /// <param name="reader">The reader that will perform the read operation.</param>
    /// <param name="value">The read value.</param>
    /// <returns>True if the value was read successfully, otherwise false. False also indicates fatal decode error.</returns>
    public static bool TryReadString(Heat2Reader reader, out string value)
    {
        return reader.TryReadString(out value);
    }

    /// <summary>
    /// Reads a string value from the stream.
    /// </summary>
    /// <param name="value">The read value.</param>
    /// <returns>True if the value was read successfully, otherwise false. False also indicates fatal decode error.</returns>
    public bool TryReadString(out string value)
    {
        if (!TryReadVarInt(out long strLen) || strLen < 0)
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

    #region Blob

    /// <summary>
    /// Reads a blob value from the stream.
    /// </summary>
    /// <param name="reader">The reader that will perform the read operation.</param>
    /// <param name="value">The read value.</param>
    /// <returns>True if the value was read successfully, otherwise false. False also indicates fatal decode error.</returns>
    public static bool TryReadBlob(Heat2Reader reader, out byte[] value)
    {
        return reader.TryReadBlob(out value);
    }

    /// <summary>
    /// Reads a blob value from the stream.
    /// </summary>
    /// <param name="value">The read value.</param>
    /// <returns>True if the value was read successfully, otherwise false. False also indicates fatal decode error.</returns>
    public bool TryReadBlob(out byte[] value)
    {
        if (!TryReadVarInt(out long length) || length < 0)
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

    #region Struct

    public static bool TryReadStruct<TStruct>(Heat2Reader reader, [NotNullWhen(true)] out TStruct? val) where TStruct : Tdf?, new()
    {
        return reader.TryReadStruct(out val);
    }

    public bool TryReadStruct<TStruct>([NotNull] out TStruct? val) where TStruct : Tdf?, new()
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
                while (currentMember < members.Length && members[currentMember].TdfInfo.Tag == member.TdfInfo.Tag)
                    currentMember++;
            }

        }

        return true;
    }

    #endregion

    #region List

    public bool TryReadList<T>(out IList<T> val)
    {
        Type valueType = typeof(IList<T>);
        TypeReader<IList<T>> reader = (TypeReader<IList<T>>)_typeReaders.GetOrAdd(valueType, createListTypeReader<T>);
        return reader(this, out val);
    }

    bool peekListType(out Heat2Type type)
    {
        RestorePoint rp = CreateRestorePoint();

        if (!TryReadHeat2Type(out type))
            return false;

        RestoreTo(rp);
        return true;
    }

    ITdfMember? createNewListMember(TdfMemberInfo info)
    {
        if (!peekListType(out Heat2Type listType))
            return null;

        return listType switch
        {
            Heat2Type.Integer => new TdfList<long>(info),
            Heat2Type.String => new TdfList<string>(info),
            Heat2Type.Binary => new TdfList<byte[]>(info),
            Heat2Type.Struct => new TdfList<EmptyMessage>(info),
            Heat2Type.List => new TdfList<IList>(info), // we can't determine the list type, so generic IList is used
            Heat2Type.Map => new TdfList<IDictionary>(info), // same as above
            Heat2Type.Union => new TdfList<Union>(info),
            Heat2Type.Variable => new TdfList<object?>(info),
            Heat2Type.BlazeObjectType => new TdfList<ObjectType>(info),
            Heat2Type.BlazeObjectId => new TdfList<ObjectId>(info),
            Heat2Type.Float => new TdfList<float>(info),
            //Heat2Type.TimeValue => new TdfList<TimeValue>(info), // TimeValue type is not used
            _ => null
        };
    }

    static TypeReader<IList<T>> createListTypeReader<T>(Type listType)
    {
        TypeReader<T> itemReader = GetTypeReader<T>();

        return (Heat2Reader reader, out IList<T> value) =>
        {
            RestorePoint checkpoint = reader.CreateRestorePoint();

            if(!reader.TryReadHeat2Type(out Heat2Type type))
            {
                value = new List<T>();
                return false;
            }

            if (!reader.TryReadVarInt(out long count) || count < 0)
            {
                value = new List<T>();
                return false;
            };

            //TODO: Check for heat bug

            if (!Heat2Util.AreTypesCompatible(typeof(T), type))
            {
                //Note: this is not a fatal error, we have to restore the reader to the previous state
                value = new List<T>();
                reader.RestoreTo(checkpoint);
                return false;
            }

            value = new List<T>((int)count);

            for (long i = 0; i < count; i++)
            {
                if (!itemReader(reader, out T item))
                    return false;

                value.Add(item);
            }

            return true;
        };
    }

    public static bool TryReadUnknownList(Heat2Reader reader, out IList value)
    {
        if(!reader.TryReadHeat2Type(out Heat2Type itemType))
        {
            value = new List<object>();
            return false;
        }

        if (!reader.TryReadVarInt(out long count) || count < 0)
        {
            value = new List<object>();
            return false;
        };

        //TODO: Check for heat bug

        value = Heat2Util.CreateListOfType(itemType);
        TypeReader itemReader = GetTypeReader(itemType);

        for (long i = 0; i < count; i++)
        {
            if (!itemReader(reader, out object? item))
                return false;

            value.Add(item);
        }

        return true;
    }

    #endregion

    #region Map

    public bool TryReadMap<TKey, TValue>(out IDictionary<TKey, TValue> val) where TKey : notnull
    {
        Type valueType = typeof(IDictionary<TKey, TValue>);
        TypeReader<IDictionary<TKey, TValue>> reader = (TypeReader<IDictionary<TKey, TValue>>)_typeReaders.GetOrAdd(valueType, createMapTypeReader<TKey, TValue>);
        return reader(this, out val);
    }

    bool peekMapType(out Heat2Type keyType, out Heat2Type valueType)
    {
        RestorePoint rp = CreateRestorePoint();

        if (!TryReadHeat2Type(out keyType))
        {
            valueType = Heat2Type.Integer;
            return false;
        }

        if (!TryReadHeat2Type(out valueType))
            return false;
        
        RestoreTo(rp);
        return true;
    }

    ITdfMember? createNewMapMember(TdfMemberInfo info)
    {
        if (!peekMapType(out Heat2Type keyHeatType, out Heat2Type valueHeatType))
            return null;

        Type keyType = Heat2Util.ToType(keyHeatType);
        Type valueType = Heat2Util.ToType(valueHeatType);

        return (ITdfMember?)Activator.CreateInstance(typeof(TdfMap<,>).MakeGenericType(keyType, valueType), info);
    }

    static TypeReader<IDictionary<TKey, TValue>> createMapTypeReader<TKey, TValue>(Type mapType) where TKey : notnull
    {
        TypeReader<TKey> keyReader = GetTypeReader<TKey>();
        TypeReader<TValue> valueReader = GetTypeReader<TValue>();

        return (Heat2Reader reader, out IDictionary<TKey, TValue> value) =>
        {
            RestorePoint rp = reader.CreateRestorePoint();

            if(!reader.TryReadHeat2Type(out Heat2Type keyType))
            {
                value = new SortedDictionary<TKey, TValue>();
                return false;
            }

            if (!Heat2Util.AreTypesCompatible(typeof(TKey), keyType))
            {
                value = new SortedDictionary<TKey, TValue>();
                reader.RestoreTo(rp);
                return false;
            }

            if (!reader.TryReadHeat2Type(out Heat2Type valueType))
            {
                value = new SortedDictionary<TKey, TValue>();
                return false;
            }

            if (!Heat2Util.AreTypesCompatible(typeof(TValue), valueType))
            {
                value = new SortedDictionary<TKey, TValue>();
                reader.RestoreTo(rp);
                return false;
            }

            if (!reader.TryReadVarInt(out long count) || count < 0)
            {
                value = new SortedDictionary<TKey, TValue>();
                return false;
            };

            value = new SortedDictionary<TKey, TValue>();

            // Read the rest of the map
            for (long i = 0; i < count; i++)
            {
                if (!keyReader(reader, out TKey key))
                    return false;

                if (!valueReader(reader, out TValue val))
                    return false;

                value.Add(key, val);
            }

            return true;
        };
    }

    public static bool TryReadUnknownMap(Heat2Reader reader, out IDictionary value)
    {
        if (!reader.TryReadHeat2Type(out Heat2Type keyType))
        {
            value = new SortedDictionary<object, object>();
            return false;
        }

        if (!reader.TryReadHeat2Type(out Heat2Type valueType))
        {
            value = new SortedDictionary<object, object>();
            return false;
        }

        if (!reader.TryReadVarInt(out long count) || count < 0)
        {
            value = new SortedDictionary<object, object>();
            return false;
        };

        value = Heat2Util.CreateDictionaryOfType(keyType, valueType);
        TypeReader keyReader = GetTypeReader(keyType);
        TypeReader valueReader = GetTypeReader(valueType);

        for (long i = 0; i < count; i++)
        {
            if (!keyReader(reader, out object? key))
                return false;

            if (!valueReader(reader, out object? val))
                return false;

            value.Add(key, val);
        }

        return true;
    }

    #endregion

    #region Union

    public static bool TryReadUnion<TUnion>(Heat2Reader reader, out TUnion val) where TUnion : Union, new()
    {
        return reader.TryReadUnion(out val);
    }

    public bool TryReadUnion<TUnion>(out TUnion val) where TUnion : Union, new()
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

    #endregion

    #region Variable

    public static bool TryReadVariable(Heat2Reader reader, [NotNullWhen(true)] out object? val)
    {
        return reader.TryReadVariable(out val);
    }

    public bool TryReadVariable(out object? val)
    {
        int present = Stream.ReadByte();
        if (present == -1)
        {
            OnFatalDecodeError();
            val = null;
            return false;
        }

        bool isPresent = present != 0;
        if(!isPresent)
        {
            val = null;
            return true;
        }

        if(!TryReadUInt32(out uint tdfId))
        {
            val = null;
            return false;
        }

        if(!TryReadHeat2MemberHeader(out Heat2MemberHeader header))
        {
            val = null;
            return false;
        }

        if(header.Type == Heat2Type.Struct)
        {
            Tdf? tdf = Decoder.Registry.CreateTdf(tdfId);
            if (tdf == null)
                tdf = new EmptyMessage();

            if(!TryReadStruct(tdf))
            {
                val = null;
                return false;
            }

            val = tdf;
            return true;
        }


        ITdfMember? member = createNewMemberFromHeader(header);
        if (member == null)
        {
            OnFatalDecodeError();
            val = null;
            return false;
        }

        if(!member.Visit(Decoder, new EmptyMessage()))
        {
            val = null;
            return false;
        }

        val = member.GetValue();
        return true;


        //throw new NotImplementedException("This variable probably is some sort of base type, which is not implemented");









    }


    #endregion

    #region ObjectType

    public static bool TryReadObjectType(Heat2Reader reader, [NotNullWhen(true)] out ObjectType val)
    {
        return reader.TryReadObjectType(out val);
    }

    public bool TryReadObjectType(out ObjectType val)
    {
        if (!TryReadUInt16(out ushort component))
        {
            val = new ObjectType();
            return false;
        }

        if (!TryReadUInt16(out ushort type))
        {
            val = new ObjectType();
            return false;
        }

        val = new ObjectType(component, type);
        return true;
    }

    #endregion

    #region ObjectId

    public static bool TryReadObjectId(Heat2Reader reader, [NotNullWhen(true)] out ObjectId val)
    {
        return reader.TryReadObjectId(out val);
    }

    public bool TryReadObjectId(out ObjectId val)
    {
        if (!TryReadObjectType(out ObjectType type))
        {
            val = new ObjectId();
            return false;
        }

        if (!TryReadInt64(out long id))
        {
            val = new ObjectId();
            return false;
        }

        val = new ObjectId(id, type);
        return true;
    }

    #endregion

    #region Float

    public static bool TryReadFloat(Heat2Reader reader, out float val)
    {
        return reader.TryReadFloat(out val);
    }

    public bool TryReadFloat(out float val)
    {
        Span<byte> buf = stackalloc byte[4];
        if (!Stream.ReadAll(buf))
        {
            OnFatalDecodeError();
            val = 0;
            return false;
        }

        val = BinaryPrimitives.ReadSingleBigEndian(buf);
        return true;
    }

    #endregion

    #region TimeValue

    public static bool TryReadTimeValue(Heat2Reader reader, out TimeValue val)
    {
        return reader.TryReadTimeValue(out val);
    }

    public bool TryReadTimeValue(out TimeValue val)
    {
        if (!TryReadInt64(out long time))
        {
            val = new TimeValue();
            return false;
        }

        val = new TimeValue(time);
        return true;
    }

    #endregion

    public bool TrySkipNextElement(Tdf parent)
    {
        if (!StreamValid)
            return false;

        RestorePoint rp = CreateRestorePoint();

        if (!TryReadHeat2MemberHeader(out Heat2MemberHeader header))
            return false;

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

    ITdfMember? createNewMemberFromHeader(Heat2MemberHeader header)
    {
        TdfType asTdfType = Heat2Util.ToTdfType(header.Type);
        TdfMemberInfo info = new TdfMemberInfo(header.Tag, asTdfType);

        return header.Type switch
        {
            Heat2Type.Integer => new TdfInt64(info),
            Heat2Type.String => new TdfString(info),
            Heat2Type.Binary => new TdfBlob(info),
            Heat2Type.Struct => new TdfStruct<EmptyMessage>(info),
            Heat2Type.List => createNewListMember(info),
            Heat2Type.Map => createNewMapMember(info),
            Heat2Type.Union => new TdfUnion<Union>(info),
            Heat2Type.Variable => new TdfVariable(info),
            Heat2Type.BlazeObjectType => new TdfObjectType(info),
            Heat2Type.BlazeObjectId => new TdfObjectId(info),
            Heat2Type.Float => new TdfFloat(info),
            //Heat2Type.TimeValue => new TdfTimeValue(info), // TimeValue type is not used
            _ => null,
        };
    }

    public bool TryReadHeat2Type(out Heat2Type type)
    {
        int b = Stream.ReadByte();
        if (b == -1)
        {
            OnFatalDecodeError();
            type = Heat2Type.Integer;
            return false;
        }

        type = (Heat2Type)b;
        if(type > Heat2Type.Float)
        {
            OnFatalDecodeError();
            return false;
        }

        return true;
    }
}
