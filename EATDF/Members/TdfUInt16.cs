using EATDF.Visitors;

namespace EATDF.Members;

public class TdfUInt16 : TdfMember<ushort>
{
    public TdfUInt16(TdfMemberInfo typeInfo) : base(typeInfo)
    {
    }

    public override ushort DefaultValue()
    {
        return 0;
    }

    public override ushort InitValue()
    {
        return 0;
    }

    public override bool IsSet()
    {
        return UserSet;
    }

    public override bool Visit(ITdfVisitor visitor, Tdf parent)
    {
        return visitor.VisitUInt16(this, parent);
    }

    public override string ToString()
    {
        return $"{Value} (0x{Value:X4})";
    }
}

