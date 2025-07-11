using EATDF.Visitors;

namespace EATDF.Members;

public class TdfInt16 : TdfMember<short>
{
    public TdfInt16(TdfMemberInfo typeInfo) : base(typeInfo)
    {
    }

    public override short DefaultValue()
    {
        return 0;
    }

    public override short InitValue()
    {
        return 0;
    }

    public override bool IsSet()
    {
        return UserSet;
    }

    public override bool Visit(ITdfVisitor visitor, Tdf parent)
    {
        return visitor.VisitInt16(this, parent);
    }

    public override string ToString()
    {
        return $"{Value} (0x{Value:X4})";
    }
}
