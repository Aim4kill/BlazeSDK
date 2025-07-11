using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Clubs;

public class ClubMemberships : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClubMembershipList", "mClubMembershipList", 0x8EDCEC00, TdfType.List, 0, true), // CMSL
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze3SDK.Blaze.Clubs.ClubMembership> _clubMembershipList = new(__typeInfos[0]);

    public ClubMemberships()
    {
        __members = [
            _clubMembershipList,
        ];
    }

    public override Tdf CreateNew() => new ClubMemberships();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ClubMemberships";
    public override string GetFullClassName() => "Blaze::Clubs::ClubMemberships";

    public IList<Blaze3SDK.Blaze.Clubs.ClubMembership> ClubMembershipList
    {
        get => _clubMembershipList.Value;
        set => _clubMembershipList.Value = value;
    }

}

