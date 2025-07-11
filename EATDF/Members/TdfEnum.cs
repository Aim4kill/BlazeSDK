using EATDF.Visitors;

namespace EATDF.Members;

public class TdfEnum<TEnum> : TdfMember<TEnum> where TEnum : Enum, new()
{
    public TdfType UnderlyingType { get; }

    public TdfEnum(TdfMemberInfo typeInfo) : base(typeInfo)
    {
        UnderlyingType = Type.GetTypeCode(typeof(TEnum)) switch
        {
            TypeCode.SByte => TdfType.Int8,
            TypeCode.Int16 => TdfType.Int16,
            TypeCode.Int32 => TdfType.Int32,
            TypeCode.Int64 => TdfType.Int64,

            TypeCode.Byte => TdfType.UInt8,
            TypeCode.UInt16 => TdfType.UInt16,
            TypeCode.UInt32 => TdfType.UInt32,
            TypeCode.UInt64 => TdfType.UInt64,

            // should never happen
            _ => throw new NotSupportedException("Unsupported enum type")
        };

    }

    public override TEnum DefaultValue()
    {
        return new TEnum();
    }

    public override TEnum InitValue()
    {
        return new TEnum();
    }

    public override bool IsSet()
    {
        return UserSet;
    }

    public override bool Visit(ITdfVisitor visitor, Tdf parent)
    {
        return visitor.VisitEnum(this, parent);
    }
}
