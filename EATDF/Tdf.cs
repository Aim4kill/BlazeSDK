using EATDF.Members;
using EATDF.Types;
using EATDF.Visitors;
using System.Diagnostics.CodeAnalysis;

namespace EATDF;

public abstract class Tdf
{
    IList<ITdfMember> _unknownMembers = new List<ITdfMember>();

    public virtual Tdf DeepClone()
    {
        //TODO: Implement in code generator and make it abstract
        throw new NotImplementedException();
    }

    public abstract Tdf CreateNew();
    public abstract ITdfMember[] GetMembers();
    public abstract TdfMemberInfo[] GetMemberInfos();
    public abstract string GetClassName();
    public abstract string GetFullClassName();

    public IList<ITdfMember> GetUnknownMembers()
    {
        return _unknownMembers;
    }

    public IOrderedEnumerable<ITdfMember> AllMembers()
    {
        return GetMembers().Concat(GetUnknownMembers()).Distinct().OrderBy(m => m.TdfInfo.Tag);
    }

    public bool TryGetMember(string tagString, [NotNullWhen(true)] out ITdfMember? member)
    {
        tagString = tagString.ToUpperInvariant();
        member = AllMembers().Where(m => m.TdfInfo.TagString == tagString).FirstOrDefault();
        return member != null;
    }

    public virtual uint GetTdfId()
    {
        //TODO: Figure out how Tdf id's are generated and implement in code generator + make it abstract
        return 0;
    }

    public override string ToString()
    {
        PrintVisitor visitor = new();
        visitor.VisitTdf(this);
        return visitor.ToString();
    }
}
