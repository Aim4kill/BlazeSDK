using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Clubs;

public class GetClubsResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClubList", "mClubList", 0x8ECCF400, TdfType.List, 0, true), // CLST
        new TdfMemberInfo("TotalCount", "mTotalCount", 0x8F48F400, TdfType.UInt32, 1, true), // CTCT
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze3SDK.Blaze.Clubs.Club> _clubList = new(__typeInfos[0]);
    private TdfUInt32 _totalCount = new(__typeInfos[1]);

    public GetClubsResponse()
    {
        __members = [
            _clubList,
            _totalCount,
        ];
    }

    public override Tdf CreateNew() => new GetClubsResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetClubsResponse";
    public override string GetFullClassName() => "Blaze::Clubs::GetClubsResponse";

    public IList<Blaze3SDK.Blaze.Clubs.Club> ClubList
    {
        get => _clubList.Value;
        set => _clubList.Value = value;
    }

    public uint TotalCount
    {
        get => _totalCount.Value;
        set => _totalCount.Value = value;
    }

}

