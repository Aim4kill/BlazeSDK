using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Clubs;

public class GetClubAwardsResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClubAwardList", "mClubAwardList", 0x877CAC00, TdfType.List, 0, true), // AWRL
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze2SDK.Blaze.Clubs.ClubAward> _clubAwardList = new(__typeInfos[0]);

    public GetClubAwardsResponse()
    {
        __members = [
            _clubAwardList,
        ];
    }

    public override Tdf CreateNew() => new GetClubAwardsResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetClubAwardsResponse";
    public override string GetFullClassName() => "Blaze::Clubs::GetClubAwardsResponse";

    public IList<Blaze2SDK.Blaze.Clubs.ClubAward> ClubAwardList
    {
        get => _clubAwardList.Value;
        set => _clubAwardList.Value = value;
    }

}

