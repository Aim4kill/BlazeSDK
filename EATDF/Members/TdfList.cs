using EATDF.Printer;
using EATDF.Visitors;

namespace EATDF.Members;

public class TdfList<T> : TdfMember<IList<T>>
{
    public TdfList(TdfMemberInfo typeInfo) : base(typeInfo)
    {
    }

    public Type ElementType => typeof(T);

    public override IList<T> DefaultValue()
    {
        return new List<T>();
    }

    public override IList<T> InitValue()
    {
        return new List<T>();
    }

    public override bool IsSet()
    {
        return Value != null && (UserSet || Value.Count > 0);
    }

    public override bool Visit(ITdfVisitor visitor, Tdf parent)
    {
        return visitor.VisitList(this, parent);
    }

    public override string ToString()
    {
        return StringFormatter.FormatList(Value);
    }

}
