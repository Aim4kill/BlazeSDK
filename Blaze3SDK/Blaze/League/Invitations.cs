using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.League;

public class Invitations : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Invitations", "mInvitations", 0xA6EDB300, TdfType.List, 0, true), // INVS
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze3SDK.Blaze.League.Invitation> _invitations = new(__typeInfos[0]);

    public Invitations()
    {
        __members = [
            _invitations,
        ];
    }

    public override Tdf CreateNew() => new Invitations();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "Invitations";
    public override string GetFullClassName() => "Blaze::League::Invitations";

    public IList<Blaze3SDK.Blaze.League.Invitation> mInvitations
    {
        get => _invitations.Value;
        set => _invitations.Value = value;
    }

}

