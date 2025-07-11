using EATDF.Types;
using EATDF.Visitors;

namespace EATDF.Members;

public class TdfStruct<TStruct> : TdfMember<TStruct> where TStruct : Tdf?, new()
{
    public TdfStruct(TdfMemberInfo typeInfo) : base(typeInfo)
    {
    }

    public override TStruct DefaultValue()
    {
        return new TStruct();
    }

    public override TStruct InitValue()
    {
        // All structures (classes) must be initialized as null to avoid infinite recursion if the class is a member of itself.
        return null!;
    }

    public override bool IsSet()
    {
        return UserSet && Value != null;
    }

    public override bool Visit(ITdfVisitor visitor, Tdf parent)
    {
        return visitor.VisitStruct(this, parent);
    }

    public override string ToString()
    {
        if (Value == null)
            return "(null)";

        PrintVisitor visitor = new();
        visitor.VisitTdf(Value);
        return visitor.ToString();
    }
}