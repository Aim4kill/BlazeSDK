using EATDF.Visitors;

namespace EATDF.Members;

public class TdfBool : TdfMember<bool>
{
    public TdfBool(TdfMemberInfo typeInfo) : base(typeInfo)
    {
    }

    public override bool DefaultValue()
    {
        return false;
    }

    public override bool InitValue()
    {
        return false;
    }

    public override bool IsSet()
    {
        return UserSet;
    }

    public override bool Visit(ITdfVisitor visitor, Tdf parent)
    {
        return visitor.VisitBool(this, parent);
    }

    public override string ToString()
    {
        return Value ? "true" : "false";
    }
}
