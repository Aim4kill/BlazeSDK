using EATDF.Members;

namespace EATDF.Types;

public class EmptyMessage : Tdf
{
    public override Tdf CreateNew()
    {
        return new EmptyMessage();
    }

    public override string GetClassName()
    {
        return nameof(EmptyMessage);
    }

    public override string GetFullClassName()
    {
        return typeof(EmptyMessage).FullName ?? nameof(EmptyMessage);
    }

    public override TdfMemberInfo[] GetMemberInfos()
    {
        return Array.Empty<TdfMemberInfo>();
    }

    public override ITdfMember[] GetMembers()
    {
        return Array.Empty<ITdfMember>();
    }
}
