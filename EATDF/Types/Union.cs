using EATDF.Members;
using EATDF.Visitors;

namespace EATDF.Types;

public class Union : Tdf
{
    public const byte UnsetIndex = 0x7F;
    public byte ActiveIndex { get; protected set; }

    public Union()
    {
        Reset();
    }

    public void SwitchActiveIndex(byte index)
    {
        if (ActiveIndex == index)
            return;

        GetActiveMember()?.Reset();
        ActiveIndex = index;
    }

    public void Reset()
    {
        GetUnknownMembers().Clear();
        GetActiveMember()?.Reset();
        ActiveIndex = UnsetIndex;
    }

    public virtual ITdfMember? GetActiveMember()
    {
        IList<ITdfMember> unknownMembers = GetUnknownMembers();
        if (unknownMembers.Count > 0)
            return unknownMembers[0];
        return null;
    }

    public bool Visit(ITdfVisitor visitor, Tdf parent)
    {
        ITdfMember? activeMember = GetActiveMember();
        if (activeMember == null)
            return false;

        return activeMember.Visit(visitor, parent);
    }

    public override ITdfMember[] GetMembers()
    {
        ITdfMember? activeMember = GetActiveMember();

        if (activeMember != null)
            return [activeMember];
        return [];
    }

    public override TdfMemberInfo[] GetMemberInfos()
    {
        ITdfMember? activeMember = GetActiveMember();

        if (activeMember != null)
            return [activeMember.TdfInfo];

        return [];
    }

    public override string GetClassName()
    {
        return nameof(Union);
    }

    public override string GetFullClassName()
    {
        return typeof(Union).FullName ?? nameof(Union);
    }

    public override Tdf CreateNew()
    {
        return new Union();
    }
}
