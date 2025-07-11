using EATDF.Visitors;

namespace EATDF.Members;

public class TdfUInt32 : TdfMember<uint>
{
    public TdfUInt32(TdfMemberInfo typeInfo) : base(typeInfo)
    {
    }

    public override uint DefaultValue()
    {
        return 0;
    }

    public override uint InitValue()
    {
        return 0;
    }

    public override bool IsSet()
    {
        return UserSet;
    }

    public override bool Visit(ITdfVisitor visitor, Tdf parent)
    {
        return visitor.VisitUInt32(this, parent);
    }

    public override string ToString()
    {
        return $"{Value} (0x{Value:X8})";
    }
}
