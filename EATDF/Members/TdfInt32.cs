using EATDF.Visitors;

namespace EATDF.Members;

public class TdfInt32 : TdfMember<int>
{
    public TdfInt32(TdfMemberInfo typeInfo) : base(typeInfo)
    {
    }

    public override int DefaultValue()
    {
        return 0;
    }

    public override int InitValue()
    {
        return 0;
    }

    public override bool IsSet()
    {
        return UserSet;
    }

    public override bool Visit(ITdfVisitor visitor, Tdf parent)
    {
        return visitor.VisitInt32(this, parent);
    }

    public override string ToString()
    {
        return $"{Value} (0x{Value:X8})";
    }

}
