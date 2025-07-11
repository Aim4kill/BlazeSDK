using EATDF.Members;
using EATDF.Types;
using System.Collections;

namespace EATDF;

internal static class Helpers
{
    public static bool IsList(Type type)
    {
        if (!type.IsGenericType)
            return false;

        if (type.GetGenericTypeDefinition() == typeof(IList<>))
            return true;

        return type.GetInterfaces().Any(x =>
            x == typeof(IList) ||
            x.IsGenericType && x.GetGenericTypeDefinition() == typeof(IList<>));
    }

    public static bool IsDictionary(Type type)
    {
        if (!type.IsGenericType)
            return false;

        if (type.GetGenericTypeDefinition() == typeof(IDictionary<,>))
            return true;

        return type.GetInterfaces().Any(x =>
            x == typeof(IDictionary<,>) ||
            x.IsGenericType && x.GetGenericTypeDefinition() == typeof(IDictionary<,>));
    }

    public static IList CreateListOfType(TdfType type, Type? typeHint = null)
    {
        if (typeHint != null)
            return CreateListOfType(typeHint);

        switch (type)
        {
            case TdfType.Struct:
                return new List<Tdf>();
            case TdfType.String:
                return new List<string>();
            case TdfType.Bool:
                return new List<bool>();
            case TdfType.Int8:
                return new List<sbyte>();
            case TdfType.UInt8:
                return new List<byte>();
            case TdfType.Int16:
                return new List<short>();
            case TdfType.UInt16:
                return new List<ushort>();
            case TdfType.Int32:
                return new List<int>();
            case TdfType.UInt32:
                return new List<uint>();
            case TdfType.Int64:
                return new List<long>();
            case TdfType.UInt64:
                return new List<ulong>();
            case TdfType.Enum:
                return new List<Enum>();
            case TdfType.TimeValue:
                return new List<TimeValue>();
            case TdfType.Float:
                return new List<float>();
            case TdfType.List:
                return new List<IList>();
            case TdfType.Map:
                return new List<IDictionary>();
            case TdfType.Blob:
                return new List<byte[]>();
            case TdfType.Union:
                return new List<Union>();
            case TdfType.Variable:
                return new List<object?>(); //TODO: Check if this is correct
            case TdfType.ObjectType:
                return new List<ObjectType>();
            case TdfType.ObjectId:
                return new List<ObjectId>();
            default:
                throw new ArgumentOutOfRangeException(nameof(type), type, null);
        }
    }

    public static IDictionary CreateDictionaryOfType(TdfType keyType, TdfType valueType, Type? keyTypeHint = null, Type? valueTypeHint = null)
    {
        if (keyTypeHint == null)
            keyTypeHint = GetActualBaseType(keyType);
        if (valueTypeHint == null)
            valueTypeHint = GetActualBaseType(valueType);
        return (IDictionary)Activator.CreateInstance(typeof(SortedDictionary<,>).MakeGenericType(keyTypeHint, valueTypeHint))!;
    }

    public static IList CreateListOfType(Type itemType)
    {
        return (IList)Activator.CreateInstance(typeof(List<>).MakeGenericType(itemType))!;
    }

    public static IDictionary CreateDictionaryOfType(Type keyType, Type valueType)
    {
        return (IDictionary)Activator.CreateInstance(typeof(SortedDictionary<,>).MakeGenericType(keyType, valueType))!;
    }

    public static Type GetActualBaseType(TdfType type) => type switch
    {
        TdfType.Struct => typeof(Tdf),
        TdfType.String => typeof(string),
        TdfType.Bool => typeof(bool),
        TdfType.Int8 => typeof(sbyte),
        TdfType.UInt8 => typeof(byte),
        TdfType.Int16 => typeof(short),
        TdfType.UInt16 => typeof(ushort),
        TdfType.Int32 => typeof(int),
        TdfType.UInt32 => typeof(uint),
        TdfType.Int64 => typeof(long),
        TdfType.UInt64 => typeof(ulong),
        TdfType.Enum => typeof(Enum),
        TdfType.TimeValue => typeof(TimeValue),
        TdfType.Float => typeof(float),
        TdfType.List => typeof(IList),
        TdfType.Map => typeof(IDictionary),
        TdfType.Blob => typeof(byte[]),
        TdfType.Union => typeof(Union),
        TdfType.Variable => typeof(object),
        TdfType.ObjectType => typeof(ObjectType),
        TdfType.ObjectId => typeof(ObjectId),
        _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
    };

    public static IOrderedEnumerable<ITdfMember> CombineMembers(IEnumerable<ITdfMember> members1, IEnumerable<ITdfMember> members2)
    {
        return members1
    .       Concat(members2)
            .OrderBy(member => member.TdfInfo.Tag); 
    }
}


