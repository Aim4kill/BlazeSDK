using EATDF.Visitors;

namespace EATDF.Members;

public class TdfFloat : TdfMember<float>
{
    public TdfFloat(TdfMemberInfo typeInfo) : base(typeInfo)
    {
    }

    public override float DefaultValue()
    {
        return 0.0f;
    }

    public override float InitValue()
    {
        return 0.0f;
    }

    public override bool IsSet()
    {
        return UserSet;
    }

    public override bool Visit(ITdfVisitor visitor, Tdf parent)
    {
        return visitor.VisitFloat(this, parent);
    }

    public override string ToString()
    {
        return Value.ToString();
    }
}