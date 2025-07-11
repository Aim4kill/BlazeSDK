using EATDF.Types;
using Microsoft.VisualBasic.FileIO;
using System.Collections;

namespace EATDF.Heat;

internal class HeatUtil
{
    public static HeatType? ToHeatType(TdfType tdfType)
    {
        switch (tdfType)
        {
            case TdfType.Struct:
                return HeatType.Struct;
            case TdfType.String:
                return HeatType.String;
            case TdfType.Bool:
            case TdfType.Int8:
                return HeatType.Int8;
            case TdfType.UInt8:
                return HeatType.UInt8;
            case TdfType.Int16:
                return HeatType.Int16;
            case TdfType.UInt16:
                return HeatType.UInt16;
            case TdfType.Int32:
                return HeatType.Int32;
            case TdfType.UInt32:
                return HeatType.UInt32;
            case TdfType.Int64:
                return HeatType.Int64;
            case TdfType.UInt64:
                return HeatType.UInt64;
            case TdfType.List:
                return HeatType.Array;
            case TdfType.Map:
                return HeatType.Map;
            case TdfType.Blob:
                return HeatType.Blob;
            case TdfType.Union:
                return HeatType.Union;
            default:
                return null;
        }
    }

    public static HeatType? ToHeatType(Type type)
    {
        switch (Type.GetTypeCode(type))
        {
            case TypeCode.Boolean:
            case TypeCode.SByte:
                return HeatType.Int8;
            case TypeCode.Byte:
                return HeatType.UInt8;
            case TypeCode.Int16:
                return HeatType.Int16;
            case TypeCode.UInt16:
                return HeatType.UInt16;
            case TypeCode.Int32:
                return HeatType.Int32;
            case TypeCode.UInt32:
                return HeatType.UInt32;
            case TypeCode.Int64:
                return HeatType.Int64;
            case TypeCode.UInt64:
                return HeatType.UInt64;
            case TypeCode.String:
                return HeatType.String;
        }

        // union must be before tdf, because union is also tdf
        if (type.IsSubclassOf(typeof(Union)))
            return HeatType.Union;

        if (type.IsSubclassOf(typeof(Tdf)))
            return HeatType.Struct;

        if (Helpers.IsList(type))
            return HeatType.Array;

        if (Helpers.IsDictionary(type))
            return HeatType.Map;

        if (type == typeof(byte[]))
            return HeatType.Blob;

        return null;
    }


    public static byte GetDefaultTypeSize(HeatType heatType)
    {
        switch (heatType)
        {
            case HeatType.Struct:
                return 0;
            case HeatType.String:
                return 15;
            case HeatType.Int8:
                return sizeof(sbyte);
            case HeatType.UInt8:
                return sizeof(byte);
            case HeatType.Int16:
                return sizeof(short);
            case HeatType.UInt16:
                return sizeof(ushort);
            case HeatType.Int32:
                return sizeof(int);
            case HeatType.UInt32:
                return sizeof(uint);
            case HeatType.Int64:
                return sizeof(long);
            case HeatType.UInt64:
                return sizeof(ulong);
            case HeatType.Array:
                return 1;
            case HeatType.Blob:
                return 15;
            case HeatType.Map:
                return 15;
            case HeatType.Union:
                return 0;
            default:
                return 0;
        }
    }

    public static TdfType ToTdfType(HeatType heatType, Type? typeHint = null)
    {
        switch (heatType)
        {
            case HeatType.Struct:
                return TdfType.Struct;
            case HeatType.String:
                return TdfType.String;
            case HeatType.Int8:
                if (typeHint == typeof(bool))
                    return TdfType.Bool;

                if (typeHint?.IsEnum == true)
                    return TdfType.Enum;

                return TdfType.Int8;
            case HeatType.UInt8:
                if (typeHint?.IsEnum == true)
                    return TdfType.Enum;
                return TdfType.UInt8;
            case HeatType.Int16:
                if (typeHint?.IsEnum == true)
                    return TdfType.Enum;
                return TdfType.Int16;
            case HeatType.UInt16:
                if (typeHint?.IsEnum == true)
                    return TdfType.Enum;
                return TdfType.UInt16;
            case HeatType.Int32:
                if (typeHint?.IsEnum == true)
                    return TdfType.Enum;
                return TdfType.Int32;
            case HeatType.UInt32:
                if (typeHint?.IsEnum == true)
                    return TdfType.Enum;
                return TdfType.UInt32;
            case HeatType.Int64:
                if (typeHint?.IsEnum == true)
                    return TdfType.Enum;
                return TdfType.Int64;
            case HeatType.UInt64:
                if (typeHint?.IsEnum == true)
                    return TdfType.Enum;
                return TdfType.UInt64;
            case HeatType.Array:
                return TdfType.List;
            case HeatType.Map:
                return TdfType.Map;
            case HeatType.Blob:
                return TdfType.Blob;
            case HeatType.Union:
                return TdfType.Union;
            default:
                throw new ArgumentOutOfRangeException(nameof(heatType));
        }
    }

    public static bool CanAssignHeatTypeToType(Type type, HeatType heatType)
    {
        switch (heatType)
        {
            case HeatType.Struct:
                return type.IsSubclassOf(typeof(Tdf));
            case HeatType.String:
                return type == typeof(string);
            case HeatType.Int8:
                return type == typeof(bool) || type == typeof(sbyte) || type == typeof(short) || type == typeof(int) || type == typeof(long);
            case HeatType.UInt8:
                return type == typeof(byte) || type == typeof(ushort) || type == typeof(uint) || type == typeof(ulong);
            case HeatType.Int16:
                return type == typeof(short) || type == typeof(int) || type == typeof(long);
            case HeatType.UInt16:
                return type == typeof(ushort) || type == typeof(uint) || type == typeof(ulong);
            case HeatType.Int32:
                return type == typeof(int) || type == typeof(long);
            case HeatType.UInt32:
                return type == typeof(uint) || type == typeof(ulong);
            case HeatType.Int64:
                return type == typeof(long);
            case HeatType.UInt64:
                return type == typeof(ulong);
            case HeatType.Array:
                return Helpers.IsList(type);
            case HeatType.Blob:
                return type == typeof(byte[]);
            case HeatType.Map:
                return Helpers.IsDictionary(type);
            case HeatType.Union:
                return type.IsSubclassOf(typeof(Union));
            default:
                return false;
        }
    }

    public static bool AreTypesCompatible(Type type, HeatType heatType)
    {
        switch (heatType)
        {
            case HeatType.Struct:
                return type.IsSubclassOf(typeof(Tdf)) || type == typeof(Tdf);
            case HeatType.String:
                return type == typeof(string);
            case HeatType.Int8:
                return type == typeof(sbyte) || type == typeof(bool);
            case HeatType.UInt8:
                return type == typeof(byte);
            case HeatType.Int16:
                return type == typeof(short);
            case HeatType.UInt16:
                return type == typeof(ushort);
            case HeatType.Int32:
                return type == typeof(int);
            case HeatType.UInt32:
                return type == typeof(uint);
            case HeatType.Int64:
                return type == typeof(long);
            case HeatType.UInt64:
                return type == typeof(ulong);
            case HeatType.Array:
                return Helpers.IsList(type);
            case HeatType.Blob:
                return type == typeof(byte[]);
            case HeatType.Map:
                return Helpers.IsDictionary(type);
            case HeatType.Union:
                return type.IsSubclassOf(typeof(Union)) || type == typeof(Union);
            default:
                return false;
        }
    }

    public static IList CreateListOfType(HeatType heatType, Type? typeHint = null)
    {
        TdfType tdfType = ToTdfType(heatType, typeHint);
        return Helpers.CreateListOfType(tdfType, typeHint);
    }

    public static IDictionary CreateDictionaryOfType(HeatType keyType, HeatType valueType, Type? keyTypeHint = null, Type? valueTypeHint = null)
    {
        TdfType keyTdfType = ToTdfType(keyType, keyTypeHint);
        TdfType valueTdfType = ToTdfType(valueType, valueTypeHint);
        return Helpers.CreateDictionaryOfType(keyTdfType, valueTdfType, keyTypeHint, valueTypeHint);
    }

    internal static Type ToType(HeatType keyType)
    {
        switch (keyType)
        {
            case HeatType.Struct:
                return typeof(Tdf);
            case HeatType.String:
                return typeof(string);
            case HeatType.Int8:
                return typeof(sbyte);
            case HeatType.UInt8:
                return typeof(byte);
            case HeatType.Int16:
                return typeof(short);
            case HeatType.UInt16:
                return typeof(ushort);
            case HeatType.Int32:
                return typeof(int);
            case HeatType.UInt32:
                return typeof(uint);
            case HeatType.Int64:
                return typeof(long);
            case HeatType.UInt64:
                return typeof(ulong);
            case HeatType.Array:
                return typeof(IList);
            case HeatType.Blob:
                return typeof(byte[]);
            case HeatType.Map:
                return typeof(IDictionary);
            case HeatType.Union:
                return typeof(Union);
            default:
                throw new ArgumentOutOfRangeException(nameof(keyType));
        }
    }
}
