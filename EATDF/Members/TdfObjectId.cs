using EATDF.Types;
using EATDF.Visitors;

namespace EATDF.Members;

public class TdfObjectId : TdfMember<ObjectId>
{
    public TdfObjectId(TdfMemberInfo typeInfo) : base(typeInfo)
    {
    }

    public override ObjectId DefaultValue()
    {
        return new ObjectId();
    }

    public override ObjectId InitValue()
    {
        return new ObjectId();
    }

    public override bool IsSet()
    {
        return UserSet;
    }

    public override bool Visit(ITdfVisitor visitor, Tdf parent)
    {
        return visitor.VisitBlazeObjectId(this, parent);
    }

    public override string ToString()
    {
        return Value.ToString();
    }
}
