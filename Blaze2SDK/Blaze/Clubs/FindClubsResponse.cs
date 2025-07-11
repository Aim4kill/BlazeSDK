using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Clubs;

public class FindClubsResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClubList", "mClubList", 0x8ECCF400, TdfType.List, 0, true), // CLST
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze2SDK.Blaze.Clubs.Club> _clubList = new(__typeInfos[0]);

    public FindClubsResponse()
    {
        __members = [
            _clubList,
        ];
    }

    public override Tdf CreateNew() => new FindClubsResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "FindClubsResponse";
    public override string GetFullClassName() => "Blaze::Clubs::FindClubsResponse";

    public IList<Blaze2SDK.Blaze.Clubs.Club> ClubList
    {
        get => _clubList.Value;
        set => _clubList.Value = value;
    }

}

