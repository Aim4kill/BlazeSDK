using EATDF.Types;
using EATDF.Visitors;

namespace EATDF.Members;

public class TdfUnion<TUnion> : TdfMember<TUnion> where TUnion : Union, new()
{
    public TdfUnion(TdfMemberInfo typeInfo) : base(typeInfo)
    {

    }

    public override TUnion DefaultValue()
    {
        return new TUnion();
    }

    public override TUnion InitValue()
    {
        return new TUnion();
    }

    public override bool IsSet()
    {
        return UserSet && Value != null;
    }

    public override bool Visit(ITdfVisitor visitor, Tdf parent)
    {
        return visitor.VisitUnion(this, parent);
    }

    public override string ToString()
    {
        return Value?.ToString() ?? "(null)";
    }
}