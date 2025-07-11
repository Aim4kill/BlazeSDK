using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Clubs;

public class GetClubMembershipForUsersResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MembershipMap", "mMembershipMap", 0xB6D87000, TdfType.Map, 0, true), // MMAP
    ];
    private ITdfMember[] __members;

    private TdfMap<uint, Blaze2SDK.Blaze.Clubs.ClubMembership> _membershipMap = new(__typeInfos[0]);

    public GetClubMembershipForUsersResponse()
    {
        __members = [
            _membershipMap,
        ];
    }

    public override Tdf CreateNew() => new GetClubMembershipForUsersResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetClubMembershipForUsersResponse";
    public override string GetFullClassName() => "Blaze::Clubs::GetClubMembershipForUsersResponse";

    public IDictionary<uint, Blaze2SDK.Blaze.Clubs.ClubMembership> MembershipMap
    {
        get => _membershipMap.Value;
        set => _membershipMap.Value = value;
    }

}

