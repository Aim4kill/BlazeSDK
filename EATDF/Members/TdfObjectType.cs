using EATDF.Types;
using EATDF.Visitors;

namespace EATDF.Members;

public class TdfObjectType : TdfMember<ObjectType>
{
    public TdfObjectType(TdfMemberInfo typeInfo) : base(typeInfo)
    {
    }

    public override ObjectType DefaultValue()
    {
        return new ObjectType();
    }

    public override ObjectType InitValue()
    {
        return new ObjectType();
    }

    public override bool IsSet()
    {
        return UserSet;
    }

    public override bool Visit(ITdfVisitor visitor, Tdf parent)
    {
        return visitor.VisitBlazeObjectType(this, parent);
    }

    public override string ToString()
    {
        return Value.ToString();
    }
}
