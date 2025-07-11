using EATDF.Visitors;

namespace EATDF.Members;

public class TdfString : TdfMember<string>
{
    public TdfString(TdfMemberInfo typeInfo) : base(typeInfo)
    {
    }

    public override string DefaultValue()
    {
        return string.Empty;
    }

    public override string InitValue()
    {
        return string.Empty;
    }

    public override bool IsSet()
    {
        return UserSet && Value != null;
    }

    public override bool Visit(ITdfVisitor visitor, Tdf parent)
    {
        return visitor.VisitString(this, parent);
    }

    public override string ToString()
    {
        return Value;
    }
}
