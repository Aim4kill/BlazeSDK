using EATDF.Visitors;

namespace EATDF.Members;

public class TdfUInt64 : TdfMember<ulong>
{
    public TdfUInt64(TdfMemberInfo typeInfo) : base(typeInfo)
    {
    }

    public override ulong DefaultValue()
    {
        return 0;
    }

    public override ulong InitValue()
    {
        return 0;
    }

    public override bool IsSet()
    {
        return UserSet;
    }

    public override bool Visit(ITdfVisitor visitor, Tdf parent)
    {
        return visitor.VisitUInt64(this, parent);
    }

    public override string ToString()
    {
        return $"{Value} (0x{Value:X16})";
    }
}
