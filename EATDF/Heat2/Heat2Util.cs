using EATDF.Heat;
using EATDF.Types;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EATDF.Heat2;

internal class Heat2Util
{
    public static TdfType ToTdfType(Heat2Type heat2Type, Type? typeHint = null)
    {
        switch (heat2Type)
        {
            case Heat2Type.Integer:
                {
                    if (typeHint == null)
                        return TdfType.Int64;

                    if (typeHint.IsEnum == true)
                        return TdfType.Enum;

                    switch (Type.GetTypeCode(typeHint))
                    {
                        case TypeCode.Boolean:
                            return TdfType.Bool;
                        case TypeCode.SByte:
                            return TdfType.Int8;
                        case TypeCode.Byte:
                            return TdfType.UInt8;
                        case TypeCode.Int16:
                            return TdfType.Int16;
                        case TypeCode.UInt16:
                            return TdfType.UInt16;
                        case TypeCode.Int32:
                            return TdfType.Int32;
                        case TypeCode.UInt32:
                            return TdfType.UInt32;
                        case TypeCode.Int64:
                            return TdfType.Int64;
                        case TypeCode.UInt64:
                            return TdfType.UInt64;
                    }

                    if(typeHint == typeof(TimeValue))
                        return TdfType.TimeValue;

                    return TdfType.Int64;
                }
            case Heat2Type.String:
                return TdfType.String;
            case Heat2Type.Binary:
                return TdfType.Blob;
            case Heat2Type.Struct:
                return TdfType.Struct;
            case Heat2Type.List:
                return TdfType.List;
            case Heat2Type.Map:
                return TdfType.Map;
            case Heat2Type.Union:
                return TdfType.Union;
            case Heat2Type.Variable:
                return TdfType.Variable;
            case Heat2Type.BlazeObjectType:
                return TdfType.ObjectType;
            case Heat2Type.BlazeObjectId:
                return TdfType.ObjectId;
            case Heat2Type.Float:
                return TdfType.Float;
            case Heat2Type.TimeValue:
                return TdfType.TimeValue;
            default:
                throw new ArgumentOutOfRangeException(nameof(heat2Type));
        }
    }

    public static Type ToType(Heat2Type heat2Type)
    {
        return heat2Type switch
        {
            Heat2Type.Integer => typeof(long),
            Heat2Type.String => typeof(string),
            Heat2Type.Binary => typeof(byte[]),
            Heat2Type.Struct => typeof(EmptyMessage),
            Heat2Type.List => typeof(IList),
            Heat2Type.Map => typeof(IDictionary),
            Heat2Type.Union => typeof(Union),
            Heat2Type.Variable => typeof(object),
            Heat2Type.BlazeObjectType => typeof(ObjectType),
            Heat2Type.BlazeObjectId => typeof(ObjectId),
            Heat2Type.Float => typeof(float),
            Heat2Type.TimeValue => typeof(TimeValue),
            _ => throw new ArgumentOutOfRangeException(nameof(heat2Type)),
        };
    }

    public static IList CreateListOfType(Heat2Type heatType, Type? typeHint = null)
    {
        TdfType tdfType = ToTdfType(heatType, typeHint);
        return Helpers.CreateListOfType(tdfType, typeHint);
    }

    public static IDictionary CreateDictionaryOfType(Heat2Type keyType, Heat2Type valueType, Type? keyTypeHint = null, Type? valueTypeHint = null)
    {
        TdfType keyTdfType = ToTdfType(keyType, keyTypeHint);
        TdfType valueTdfType = ToTdfType(valueType, valueTypeHint);
        return Helpers.CreateDictionaryOfType(keyTdfType, valueTdfType, keyTypeHint, valueTypeHint);
    }

    internal static bool AreTypesCompatible(Type type, Heat2Type heat2Type)
    {
        switch (heat2Type)
        {
            case Heat2Type.Integer:
                return type == typeof(bool) || type == typeof(sbyte) ||
                    type == typeof(byte) || type == typeof(short) ||
                    type == typeof(ushort) || type == typeof(int) ||
                    type == typeof(uint) || type == typeof(long) ||
                    type == typeof(ulong) || type == typeof(TimeValue);
            case Heat2Type.String:
                return type == typeof(string);
            case Heat2Type.Binary:
                return type == typeof(byte[]);
            case Heat2Type.Struct:
                return type.IsSubclassOf(typeof(Tdf));
            case Heat2Type.List:
                return Helpers.IsList(type);
            case Heat2Type.Map:
                return Helpers.IsDictionary(type);
            case Heat2Type.Union:
                return type.IsSubclassOf(typeof(Union));
            case Heat2Type.Variable:
                return type == typeof(object);
            case Heat2Type.BlazeObjectType:
                return type == typeof(ObjectType);
            case Heat2Type.BlazeObjectId:
                return type == typeof(ObjectId);
            case Heat2Type.Float:
                return type == typeof(float);
            case Heat2Type.TimeValue:
                return type == typeof(TimeValue);
            default:
                return false;
        }
    }

    internal static Heat2Type? ToHeat2Type(Type type)
    {
        switch (Type.GetTypeCode(type))
        {
            case TypeCode.String:
                return Heat2Type.String;
            case TypeCode.Boolean:
            case TypeCode.SByte:
            case TypeCode.Byte:
            case TypeCode.Int16:
            case TypeCode.UInt16:
            case TypeCode.Int32:
            case TypeCode.UInt32:
            case TypeCode.Int64:
            case TypeCode.UInt64:
                return Heat2Type.Integer;
            case TypeCode.Single:
                return Heat2Type.Float;
        }

        if (type.IsSubclassOf(typeof(Tdf)))
            return Heat2Type.Struct;

        if (Helpers.IsList(type))
            return Heat2Type.List;

        if (Helpers.IsDictionary(type))
            return Heat2Type.Map;

        if (type == typeof(byte[]))
            return Heat2Type.Binary;

        if (type.IsSubclassOf(typeof(Union)))
            return Heat2Type.Union;

        if (type == typeof(ObjectType))
            return Heat2Type.BlazeObjectType;

        if (type == typeof(ObjectId))
            return Heat2Type.BlazeObjectId;

        if (type == typeof(TimeValue))
            return Heat2Type.Integer;

        if (type == typeof(byte[]))
            return Heat2Type.Variable;

        if (type == typeof(object))
            return Heat2Type.Variable;

        return null;
    }
}