using EATDF.Types;
using System.Collections.Concurrent;

namespace EATDF.Printer;

internal static class StringFormatter
{
    delegate string FormatTypeDel<T>(T value);
    static readonly ConcurrentDictionary<Type, Delegate> _typeFormatters = new ConcurrentDictionary<Type, Delegate>()
    {
        [typeof(bool)] = new FormatTypeDel<bool>(FormatBool),
        [typeof(sbyte)] = new FormatTypeDel<sbyte>(FormatInt8),
        [typeof(byte)] = new FormatTypeDel<byte>(FormatUInt8),
        [typeof(short)] = new FormatTypeDel<short>(FormatInt16),
        [typeof(ushort)] = new FormatTypeDel<ushort>(FormatUInt16),
        [typeof(int)] = new FormatTypeDel<int>(FormatInt32),
        [typeof(uint)] = new FormatTypeDel<uint>(FormatUInt32),
        [typeof(long)] = new FormatTypeDel<long>(FormatInt64),
        [typeof(ulong)] = new FormatTypeDel<ulong>(FormatUInt64),
        [typeof(string)] = new FormatTypeDel<string>(FormatString),
        [typeof(byte[])] = new FormatTypeDel<byte[]>(FormatBytes),
        [typeof(float)] = new FormatTypeDel<float>(FormatFloat),
        [typeof(ObjectType)] = new FormatTypeDel<ObjectType>(FormatBlazeObjectType),
        [typeof(ObjectId)] = new FormatTypeDel<ObjectId>(FormatBlazeObjectId),
        [typeof(TimeValue)] = new FormatTypeDel<TimeValue>(FormatTimeValue),
    };

    public static string FormatString(string? value)
    {
        if (value == null)
            return "(null)";

        return $"\"{value}\"";
    }
    public static string FormatBool(bool value)
    {
        return value ? "true" : "false";
    }
    public static string FormatInt8(sbyte value)
    {
        return $"{value} (0x{value:X2})";
    }
    public static string FormatUInt8(byte value)
    {
        return $"{value} (0x{value:X2})";
    }
    public static string FormatInt16(short value)
    {
        return $"{value} (0x{value:X4})";
    }
    public static string FormatUInt16(ushort value)
    {
        return $"{value} (0x{value:X4})";
    }
    public static string FormatInt32(int value)
    {
        return $"{value} (0x{value:X8})";
    }
    public static string FormatUInt32(uint value)
    {
        return $"{value} (0x{value:X8})";
    }
    public static string FormatInt64(long value)
    {
        return $"{value} (0x{value:X16})";
    }
    public static string FormatUInt64(ulong value)
    {
        return $"{value} (0x{value:X16})";
    }

    public static string FormatFloat(float value)
    {
        return value.ToString();
    }

    internal static string FormatVariable(object? value)
    {
        return value?.ToString() ?? "(null)";
    }

    public static string FormatType<T>(T value)
    {
        FormatTypeDel<T> formatter = GetFormatter<T>();
        return formatter(value);
    }

    static FormatTypeDel<T> GetFormatter<T>()
    {
        Type valueType = typeof(T);
        return (FormatTypeDel<T>)_typeFormatters.GetOrAdd(valueType, CreateCustomFormatter<T>);
    }

    static FormatTypeDel<T> CreateCustomFormatter<T>(Type type)
    {
        if (type.IsEnum)
        {
            return (value) =>
            {
                int number = Convert.ToInt32(value);
                return $"{value} ({number}) (0x{number:X8})";
            };
        }

        if (type.IsSubclassOf(typeof(Union)))
            return (value) =>
            {
                return "TODO: UNION";

            };


        //if (type.IsSubclassOf(typeof(Tdf)))
        //    return (value) =>
        //    {
        //        Tdf? tdf = (Tdf?)(object?)value;

        //        if (tdf == null)
        //            return "(null)";

        //        return

        //    };

        //if (Helpers.IsList(type))
        //{
        //    FormatTypeDel listFormatter = BasicStringFormatter.GetFormatter(type);
        //    return (value) => listFormatter(value); ;
        //}

        //if (Helpers.IsDictionary(type))
        //{
        //    FormatTypeDel mapFormatter = BasicStringFormatter.GetFormatter(type);
        //    return (value) => mapFormatter(value); ;
        //}

        return (value) => value?.ToString() ?? "(null)";
    }

    public static string FormatList<T>(IList<T>? value)
    {
        if (value == null)
            return "(null)";

        TabbedStringBuilder sb = new TabbedStringBuilder();
        sb.AppendLine($"[");
        sb.AddTab();

        FormatTypeDel<T> formatter = GetFormatter<T>();

        int count = value.Count;
        //if (count > 64)
        //    count = 64;

        for (int i = 0; i < count; i++)
            sb.AppendLine($"[{i}] = {formatter(value[i])}");

        //if (value.Count > 64)
        //    sb.AppendLine($"    and {value.Count - 64} more... (total: {value.Count})");

        sb.RemoveTab();
        sb.Append("]");
        return sb.ToString();
    }

    public static string FormatBytes(byte[]? value)
    {
        if (value == null)
            return "(null)";

        TabbedStringBuilder sb = new TabbedStringBuilder();
        sb.AppendLine($"[");
        sb.AddTab();

        int count = value.Length;
        //if (count > 256)
        //    count = 256;

        for (int i = 0; i < count; i += 16)
        {
            if (i % 16 == 0)
                sb.WriteTab();

            int start = i;
            int end = Math.Min(i + 16, count);
            int extra = 16 - (end - start);

            for (int j = start; j < end; j++)
                sb.Append($"{value[j]:x2} ");

            for (int j = 0; j < extra; j++)
                sb.Append("   ");

            //print ascii
            sb.Append("  ");
            for (int j = start; j < end; j++)
            {
                char c = (char)value[j];
                if (char.IsControl(c))
                    c = '.';
                sb.Append(c);
            }

            sb.AppendLine();
        }

        ////write how much bytes remaining
        //if (value.Length > 256)
        //    sb.AppendLine($"    and {value.Length - 256} bytes... (total: {value.Length} bytes)");

        sb.RemoveTab();
        sb.Append("]");
        return sb.ToString();
    }

    public static string FormatMap<TKey, TValue>(IDictionary<TKey, TValue>? value)
    {
        if (value == null)
            return "(null)";

        TabbedStringBuilder sb = new TabbedStringBuilder();
        sb.AppendLine($"[");
        sb.AddTab();

        FormatTypeDel<TKey> keyFormatter = GetFormatter<TKey>();
        FormatTypeDel<TValue> valueFormatter = GetFormatter<TValue>();

        int count = value.Count;
        //if (count > 64)
        //    count = 64;

        for (int i = 0; i < count; i++)
        {
            var pair = value.ElementAt(i);
            sb.AppendLine($"({keyFormatter(pair.Key)}, {valueFormatter(pair.Value)})");
        }

        //if (value.Count > 64)
        //    sb.AppendLine($"    and {value.Count - 64} more... (total: {value.Count})");

        sb.RemoveTab();
        sb.Append("]");
        return sb.ToString();
    }

    public static string FormatBlazeObjectType(ObjectType value)
    {
        return value.ToString();
    }

    public static string FormatBlazeObjectId(ObjectId value)
    {
        return value.ToString();
    }

    public static string FormatTimeValue(TimeValue value)
    {
        return value.ToString();
    }

    public static string FormatEnum<T>(T value)
    {
        TypeCode typeCode = Type.GetTypeCode(typeof(T));

        switch (typeCode)
        {
            case TypeCode.Byte:
                {
                    byte val = Convert.ToByte(value);
                    return $"{value} ({val}) (0x{val:X2})";
                }
            case TypeCode.SByte:
                {
                    sbyte val = Convert.ToSByte(value);
                    return $"{value} ({val}) (0x{val:X2})";
                }
            case TypeCode.Int16:
                {
                    short val = Convert.ToInt16(value);
                    return $"{value} ({val}) (0x{val:X4})";
                }
            case TypeCode.UInt16:
                {
                    ushort val = Convert.ToUInt16(value);
                    return $"{value} ({val}) (0x{val:X4})";
                }
            case TypeCode.Int32:
                {
                    int val = Convert.ToInt32(value);
                    return $"{value} ({val}) (0x{val:X8})";
                }
            case TypeCode.UInt32:
                {
                    uint val = Convert.ToUInt32(value);
                    return $"{value} ({val}) (0x{val:X8})";
                }
            case TypeCode.Int64:
                {
                    long val = Convert.ToInt64(value);
                    return $"{value} ({val}) (0x{val:X16})";
                }
            case TypeCode.UInt64:
                {
                    ulong val = Convert.ToUInt64(value);
                    return $"{value} ({val}) (0x{val:X16})";
                }
            default:
                return value?.ToString() ?? "(null)";
        }
    }

    public static string FormatUnion(Union value)
    {
        return "TODO: UNION";
    }
}
