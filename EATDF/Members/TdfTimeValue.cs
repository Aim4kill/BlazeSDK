using EATDF.Types;
using EATDF.Visitors;

namespace EATDF.Members;

public class TdfTimeValue : TdfMember<TimeValue>
{
    public TdfTimeValue(TdfMemberInfo typeInfo) : base(typeInfo)
    {
    }

    public override TimeValue DefaultValue()
    {
        return new TimeValue();
    }

    public override TimeValue InitValue()
    {
        return new TimeValue();
    }

    public override bool IsSet()
    {
        return UserSet;
    }

    public override bool Visit(ITdfVisitor visitor, Tdf parent)
    {
        return visitor.VisitTimeValue(this, parent);
    }

    public override string ToString()
    {
        return Value.ToString();
    }
}
