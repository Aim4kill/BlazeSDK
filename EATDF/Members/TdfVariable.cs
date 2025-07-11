using EATDF.Visitors;

namespace EATDF.Members;

public class TdfVariable : TdfMember<object?>
{
    public TdfVariable(TdfMemberInfo typeInfo) : base(typeInfo)
    {
    }

    public override object? DefaultValue()
    {
        return null;
    }

    public override object? InitValue()
    {
        return null;
    }

    public override bool IsSet()
    {
        return UserSet;
    }

    public override bool Visit(ITdfVisitor visitor, Tdf parent)
    {
        return visitor.VisitVariable(this, parent);
    }

    public override string ToString()
    {
        return Value?.ToString() ?? "(null)";
    }
}

