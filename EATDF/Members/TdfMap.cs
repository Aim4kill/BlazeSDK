using EATDF.Printer;
using EATDF.Visitors;

namespace EATDF.Members;

public class TdfMap<TKey, TValue> : TdfMember<IDictionary<TKey, TValue>> where TKey : notnull
{
    public TdfMap(TdfMemberInfo typeInfo) : base(typeInfo)
    {
    }

    public Type KeyType => typeof(TKey);
    public Type ValueType => typeof(TValue);

    public override IDictionary<TKey, TValue> DefaultValue()
    {
        return new SortedDictionary<TKey, TValue>();
    }

    public override IDictionary<TKey, TValue> InitValue()
    {
        return new SortedDictionary<TKey, TValue>();
    }

    public override bool IsSet()
    {
        return Value != null && (UserSet || Value.Count > 0);
    }

    public override bool Visit(ITdfVisitor visitor, Tdf parent)
    {
        return visitor.VisitMap(this, parent);
    }

    public override string ToString()
    {
        return StringFormatter.FormatMap(Value);
    }
}
