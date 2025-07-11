using EATDF.Printer;
using EATDF.Visitors;

namespace EATDF.Members;

public class TdfBlob : TdfMember<byte[]>
{
    public TdfBlob(TdfMemberInfo typeInfo) : base(typeInfo)
    {
    }

    public override byte[] DefaultValue()
    {
        return Array.Empty<byte>();
    }

    public override byte[] InitValue()
    {
        return Array.Empty<byte>();
    }

    public override bool IsSet()
    {
        return Value != null && (UserSet || Value.Length > 0);
    }

    public override bool Visit(ITdfVisitor visitor, Tdf parent)
    {
        return visitor.VisitBlob(this, parent);
    }

    public override string ToString()
    {
        return StringFormatter.FormatBytes(Value);
    }
}
