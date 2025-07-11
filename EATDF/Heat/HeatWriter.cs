using EATDF.Types;
using EATDF.Visitors;
using System;
using System.Collections.Concurrent;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Reflection.Metadata;
using System.Buffers;
using System.Diagnostics;
using System.Buffers.Binary;

namespace EATDF.Heat;

internal class HeatWriter(HeatEncoder encoder, Stream stream)
{
    const int MaxStackAlloc = 512;

    static readonly Encoding StringEncoder = Encoding.UTF8;

    /// <summary>
    /// 3 bytes for tag, 1 byte for type(4 bits) and size(4 bits)
    /// Size is from 0 to 15, if size is 15, then the actual size will be read from the stream
    /// </summary>
    public const int HeaderSize = 4;

    /// <summary>
    /// The encoder that created this writer
    /// </summary>
    public HeatEncoder Encoder { get; } = encoder;

    /// <summary>
    /// The stream to write to
    /// </summary>
    public Stream Stream { get; } = stream;

    /// <summary>
    /// Writes the specified type value to the stream.
    /// </summary>
    /// <typeparam name="T">The type of the value to write.</typeparam>
    /// <param name="writer">The writer which performs the write operation.</param>
    /// <param name="value">The value to write.</param>
    /// <param name="sizeHint">Pre-encoded size hint.</param>
    delegate void TypeWriter<T>(HeatWriter writer, T value, byte preEncodedSizeHint);
    delegate void TypeWriter(HeatWriter writer, object? value, byte preEncodedSizeHint);

    /// <summary>
    /// Initial type writers for basic types.
    /// </summary>
    static readonly ConcurrentDictionary<Type, Delegate> _typeWriters = new ConcurrentDictionary<Type, Delegate>()
    {
        [typeof(bool)] = new TypeWriter<bool>((writer, value, sizeHint) => writer.WriteBool(value, sizeHint)),
        [typeof(sbyte)] = new TypeWriter<sbyte>((writer, value, sizeHint) => writer.WriteInt8(value, sizeHint)),
        [typeof(byte)] = new TypeWriter<byte>((writer, value, sizeHint) => writer.WriteUInt8(value, sizeHint)),
        [typeof(short)] = new TypeWriter<short>((writer, value, sizeHint) => writer.WriteInt16(value, sizeHint)),
        [typeof(ushort)] = new TypeWriter<ushort>((writer, value, sizeHint) => writer.WriteUInt16(value, sizeHint)),
        [typeof(int)] = new TypeWriter<int>((writer, value, sizeHint) => writer.WriteInt32(value, sizeHint)),
        [typeof(uint)] = new TypeWriter<uint>((writer, value, sizeHint) => writer.WriteUInt32(value, sizeHint)),
        [typeof(long)] = new TypeWriter<long>((writer, value, sizeHint) => writer.WriteInt64(value, sizeHint)),
        [typeof(ulong)] = new TypeWriter<ulong>((writer, value, sizeHint) => writer.WriteUInt64(value, sizeHint)),
        [typeof(string)] = new TypeWriter<string>((writer, value, sizeHint) => writer.WriteString(value, sizeHint)),
        [typeof(byte[])] = new TypeWriter<byte[]>((writer, value, sizeHint) => writer.WriteBlob(value, sizeHint)),

        //// for lists and maps of unknown type arguments
        //[typeof(IList)] = new TypeWriter<IList>(WriteUnknownList),
        //[typeof(IDictionary)] = new TypeWriter<IDictionary>(WriteUnknownMap),
    };

    static MethodInfo _createListWriterMethod = typeof(HeatWriter).GetMethod(nameof(createListTypeWriter), BindingFlags.NonPublic | BindingFlags.Static)!;
    static MethodInfo _createMapWriterMethod = typeof(HeatWriter).GetMethod(nameof(createMapTypeWriter), BindingFlags.NonPublic | BindingFlags.Static)!;

    /// <summary>
    /// Returns the writer for the specified type.
    /// </summary>
    /// <typeparam name="T">The type to get the writer for.</typeparam>
    /// <returns>The writer for the specified type.</returns>
    static TypeWriter<T> GetTypeWriter<T>()
    {
        Type valueType = typeof(T);
        return (TypeWriter<T>)_typeWriters.GetOrAdd(valueType, CreateCustomWriter<T>);
    }

    static TypeWriter<T> CreateCustomWriter<T>(Type type)
    {
        if (type.IsEnum)
            return createEnumTypeWriter<T>(type);

        if (type.IsSubclassOf(typeof(Union)))
            return (HeatWriter writer, T value, byte preEncodedSizeHint) =>
            {
                if (value is Union union)
                {
                    writer.Stream.WriteByte(union.ActiveIndex);
                    writer.Encoder.VisitTdf(union);
                }
            };

        if (type.IsSubclassOf(typeof(Tdf)))
            return (HeatWriter writer, T value, byte preEncodedSizeHint) =>
            {
                if (value is Tdf tdf)
                    writer.Encoder.VisitTdf(tdf);

                writer.Stream.WriteByte(0); // terminator
            };

        if (Helpers.IsList(type))
        {
            Type[] typeArgs = type.GetGenericArguments();
            return (TypeWriter<T>)_createListWriterMethod.MakeGenericMethod(typeArgs).Invoke(null, null)!;
        }

        if (Helpers.IsDictionary(type))
        {
            Type[] typeArgs = type.GetGenericArguments();
            return (TypeWriter<T>)_createMapWriterMethod.MakeGenericMethod(typeArgs).Invoke(null, null)!;
        }

        // Unknown type :(
        return (HeatWriter writer, T value, byte preEncodedSizeHint) =>
        {
            throw new NotSupportedException($"Type is not supported: {typeof(T).FullName}");
        };
    }


    public void WriteVarInt(long value)
    {
        if (value == 0)
        {
            Stream.WriteByte(0);
            return;
        }

        Span<byte> bytes = stackalloc byte[10]; //64 / 7 = 9.14 so 10 bytes is the maximum possible encodable size
        int i = 9;

        bytes[9] = (byte)(value & 0x7F); //this is the last byte, next bit is set to 0;

        for (long val = value >> 7; val > 0; val >>= 7)
            bytes[--i] = (byte)((val | 0x80) & 0xFF); //setting the next bit to 1

        Stream.Write(bytes.Slice(i));
    }

    public void WriteHeader(uint tag, HeatType type, int size, out byte encodedSizeHint)
    {
        //Header is 0xTTTTTTHS
        // T = Tag
        // H = Heat type
        // S = Size Hint (does not mean actual bytes, but hint for the specific type (e.g. string length, array length, etc.))

        byte typeAndSize = (size < 0 || size > 15) ? (byte)15 : (byte)size;
        encodedSizeHint = typeAndSize;
        typeAndSize |= (byte)(((byte)type) << 4);

        Span<byte> headerBytes =
        [
            (byte)((tag >> 24) & 0xFF),
            (byte)((tag >> 16) & 0xFF),
            (byte)((tag >> 8) & 0xFF),
            typeAndSize,
        ];

        Stream.Write(headerBytes);
    }

    public void WriteTypeAndSizeHint(HeatType type, byte size)
    {
        byte typeAndSize = (byte)(((byte)type << 4) | size);
        Stream.WriteByte(typeAndSize);
    }

    public void WriteBool(bool value, byte preEncodedSizeHint)
    {
        Stream.WriteByte((byte)(value ? 1 : 0));
    }

    public void WriteBlob(byte[] blob, byte preEncodedSizeHint)
    {
        if (shouldEncodeSize(preEncodedSizeHint))
            WriteVarInt(blob.Length);
        Stream.Write(blob);
    }

    public void WriteString(string str, byte preEncodedSizeHint)
    {
        int byteCount = StringEncoder.GetByteCount(str);

        if (shouldEncodeSize(preEncodedSizeHint))
            WriteVarInt(byteCount + 1); // +1 for null terminator

        byte[]? rentedPool = null;

        Span<byte> bytes =
            byteCount > MaxStackAlloc
            ? new Span<byte>(rentedPool = ArrayPool<byte>.Shared.Rent(byteCount), 0, byteCount)
            : stackalloc byte[byteCount];

        int bytesReceived = StringEncoder.GetBytes(str, bytes);
        Debug.Assert(byteCount == bytesReceived);

        Stream.Write(bytes);
        Stream.WriteByte(0); // null terminator

        if (rentedPool != null)
            ArrayPool<byte>.Shared.Return(rentedPool);
    }

    public void WriteList<T>(IList<T> value, byte preEncodedSizeHint)
    {
        Type valueType = typeof(IList<T>);
        TypeWriter<IList<T>> writer = (TypeWriter<IList<T>>)_typeWriters.GetOrAdd(valueType, createListTypeWriter<T>);
        writer(this, value, preEncodedSizeHint);
    }

    static TypeWriter<IList<T>> createListTypeWriter<T>(Type listType)
    {
        TypeWriter<T> itemWriter = GetTypeWriter<T>();
        HeatType? itemHeatTypeNullable = HeatUtil.ToHeatType(typeof(T));

        if (itemHeatTypeNullable == null)
            return (HeatWriter writer, IList<T> value, byte preEncodedSizeHint) => throw new NotSupportedException($"List type is not supported: {typeof(T).FullName}");

        HeatType itemHeatType = itemHeatTypeNullable.Value;
        byte defaultTypeSize = HeatUtil.GetDefaultTypeSize(itemHeatType);

        return (HeatWriter writer, IList<T> value, byte preEncodedSizeHint) =>
        {
            writer.WriteVarInt(value.Count);

            if(value.Count == 0)
                return;

            writer.WriteTypeAndSizeHint(itemHeatType, defaultTypeSize);

            foreach(T item in value)
                itemWriter(writer, item, defaultTypeSize);
        };
    }


    static bool shouldEncodeSize(byte preEncodedSizeHint)
    {
        return preEncodedSizeHint == 15;
    }

    public void WriteUnion<TUnion>(TUnion value, byte encodedSizeHint) where TUnion : Union, new()
    {
        Stream.WriteByte(value.ActiveIndex);
        Encoder.VisitTdf(value);

    }

    public void WriteStruct<TStruct>(TStruct value, byte encodedSizeHint) where TStruct : Tdf?, new()
    {
        if(value != null)
            Encoder.VisitTdf(value);
        Stream.WriteByte(0); // terminator
    }

    #region Integers

    public void WriteUInt8(byte value, byte encodedSizeHint)
    {
        Stream.WriteByte(value);
    }

    public void WriteUInt16(ushort value, byte encodedSizeHint)
    {
        Span<byte> bytes = [
            (byte)((value >> 8) & 0xFF),
            (byte)(value & 0xFF),
        ];

        Stream.Write(bytes);
    }

    public void WriteUInt32(uint value, byte encodedSizeHint)
    {
        Span<byte> bytes = [
            (byte)((value >> 24) & 0xFF),
            (byte)((value >> 16) & 0xFF),
            (byte)((value >> 8) & 0xFF),
            (byte)(value & 0xFF),
        ];

        Stream.Write(bytes);
    }

    public void WriteUInt64(ulong value, byte encodedSizeHint)
    {
        Span<byte> bytes = [
            (byte)((value >> 56) & 0xFF),
            (byte)((value >> 48) & 0xFF),
            (byte)((value >> 40) & 0xFF),
            (byte)((value >> 32) & 0xFF),
            (byte)((value >> 24) & 0xFF),
            (byte)((value >> 16) & 0xFF),
            (byte)((value >> 8) & 0xFF),
            (byte)(value & 0xFF),
        ];

        Stream.Write(bytes);
    }

    public void WriteInt8(sbyte value, byte encodedSizeHint)
    {
        byte b = unchecked((byte)value);
        Stream.WriteByte(b);
    }

    public void WriteInt16(short value, byte encodedSizeHint)
    {
        Span<byte> bytes = [
            (byte)((value >> 8) & 0xFF),
            (byte)(value & 0xFF),
        ];

        Stream.Write(bytes);
    }

    public void WriteInt32(int value, byte encodedSizeHint)
    {
        Span<byte> bytes = [
            (byte)((value >> 24) & 0xFF),
            (byte)((value >> 16) & 0xFF),
            (byte)((value >> 8) & 0xFF),
            (byte)(value & 0xFF),
        ];

        Stream.Write(bytes);
    }

    public void WriteInt64(long value, byte encodedSizeHint)
    {
        Span<byte> bytes = [
            (byte)((value >> 56) & 0xFF),
            (byte)((value >> 48) & 0xFF),
            (byte)((value >> 40) & 0xFF),
            (byte)((value >> 32) & 0xFF),
            (byte)((value >> 24) & 0xFF),
            (byte)((value >> 16) & 0xFF),
            (byte)((value >> 8) & 0xFF),
            (byte)(value & 0xFF),
        ];

        Stream.Write(bytes);
    }

    #endregion


    public void WriteMap<TKey, TValue>(IDictionary<TKey, TValue> value, byte encodedSizeHint) where TKey : notnull
    {
        Type valueType = typeof(IDictionary<TKey, TValue>);
        TypeWriter<IDictionary<TKey, TValue>> writer = (TypeWriter<IDictionary<TKey, TValue>>)_typeWriters.GetOrAdd(valueType, createMapTypeWriter<TKey, TValue>);
        writer(this, value, encodedSizeHint);
    }

    static TypeWriter<IDictionary<TKey, TValue>> createMapTypeWriter<TKey, TValue>(Type mapType) where TKey : notnull
    {
        TypeWriter<TKey> keyWriter = GetTypeWriter<TKey>();
        TypeWriter<TValue> valueWriter = GetTypeWriter<TValue>();

        HeatType? keyHeatTypeNullable = HeatUtil.ToHeatType(typeof(TKey));
        if (keyHeatTypeNullable == null)
            return (HeatWriter writer, IDictionary<TKey, TValue> value, byte preEncodedSizeHint) => throw new NotSupportedException($"Map key type is not supported: {typeof(TKey).FullName}");

        HeatType? valueHeatTypeNullable = HeatUtil.ToHeatType(typeof(TValue));
        if (valueHeatTypeNullable == null)
            return (HeatWriter writer, IDictionary<TKey, TValue> value, byte preEncodedSizeHint) => throw new NotSupportedException($"Map value type is not supported: {typeof(TValue).FullName}");

        HeatType keyHeatType = keyHeatTypeNullable.Value;
        HeatType valueHeatType = valueHeatTypeNullable.Value;

        byte defaultKeyTypeSize = HeatUtil.GetDefaultTypeSize(keyHeatType);
        byte defaultValueTypeSize = HeatUtil.GetDefaultTypeSize(valueHeatType);

        return (HeatWriter writer, IDictionary<TKey, TValue> value, byte preEncodedSizeHint) =>
        {
            if (shouldEncodeSize(preEncodedSizeHint))
                writer.WriteVarInt(value.Count);

            if(value.Count == 0)
                return;

            KeyValuePair<TKey, TValue> first = value.First();

            writer.WriteTypeAndSizeHint(keyHeatType, defaultKeyTypeSize);
            keyWriter(writer, first.Key, defaultKeyTypeSize);
            writer.WriteTypeAndSizeHint(valueHeatType, defaultValueTypeSize);
            valueWriter(writer, first.Value, defaultValueTypeSize);

            foreach (KeyValuePair<TKey, TValue> pair in value.Skip(1))
            {
                keyWriter(writer, pair.Key, defaultKeyTypeSize);
                valueWriter(writer, pair.Value, defaultValueTypeSize);
            }
        };
    }

    public void WriteEnum<TEnum>(TEnum value, byte encodedSizeHint) where TEnum : new()
    {
        Type valueType = typeof(TEnum);
        TypeWriter<TEnum> writer = (TypeWriter<TEnum>)_typeWriters.GetOrAdd(valueType, createEnumTypeWriter<TEnum>);
        writer(this, value, encodedSizeHint);
    }

    static TypeWriter<TEnum> createEnumTypeWriter<TEnum>(Type type)
    {
        return Type.GetTypeCode(typeof(TEnum)) switch
        {
            TypeCode.SByte => (HeatWriter writer, TEnum value, byte preEncodedSizeHint) => writer.WriteInt8(Convert.ToSByte(value), preEncodedSizeHint),
            TypeCode.Byte => (HeatWriter writer, TEnum value, byte preEncodedSizeHint) => writer.WriteUInt8(Convert.ToByte(value), preEncodedSizeHint),
            TypeCode.Int16 => (HeatWriter writer, TEnum value, byte preEncodedSizeHint) => writer.WriteInt16(Convert.ToInt16(value), preEncodedSizeHint),
            TypeCode.UInt16 => (HeatWriter writer, TEnum value, byte preEncodedSizeHint) => writer.WriteUInt16(Convert.ToUInt16(value), preEncodedSizeHint),
            TypeCode.Int32 => (HeatWriter writer, TEnum value, byte preEncodedSizeHint) => writer.WriteInt32(Convert.ToInt32(value), preEncodedSizeHint),
            TypeCode.UInt32 => (HeatWriter writer, TEnum value, byte preEncodedSizeHint) => writer.WriteUInt32(Convert.ToUInt32(value), preEncodedSizeHint),
            TypeCode.Int64 => (HeatWriter writer, TEnum value, byte preEncodedSizeHint) => writer.WriteInt64(Convert.ToInt64(value), preEncodedSizeHint),
            TypeCode.UInt64 => (HeatWriter writer, TEnum value, byte preEncodedSizeHint) => writer.WriteUInt64(Convert.ToUInt64(value), preEncodedSizeHint),
            _ => (HeatWriter writer, TEnum value, byte preEncodedSizeHint) => throw new NotSupportedException($"Enum type is not supported: {typeof(TEnum).FullName}"),
        };
    }
}
