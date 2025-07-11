using EATDF.Visitors;

namespace EATDF.Members;

public class TdfInt64 : TdfMember<long>
{
    public TdfInt64(TdfMemberInfo typeInfo) : base(typeInfo)
    {
    }

    public override long DefaultValue()
    {
        return 0;
    }

    public override long InitValue()
    {
        return 0;
    }

    public override bool IsSet()
    {
        return UserSet;
    }

    public override bool Visit(ITdfVisitor visitor, Tdf parent)
    {
        return visitor.VisitInt64(this, parent);
    }

    public override string ToString()
    {
        return $"{Value} (0x{Value:X16})";
    }
}
