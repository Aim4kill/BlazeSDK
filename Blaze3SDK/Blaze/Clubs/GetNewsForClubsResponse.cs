using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Clubs;

public class GetNewsForClubsResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("LocalizedNewsListMap", "mLocalizedNewsListMap", 0xBACB7000, TdfType.Map, 0, true), // NLMP
        new TdfMemberInfo("TotalPages", "mTotalPages", 0xD2CC2700, TdfType.UInt16, 1, true), // TLPG
    ];
    private ITdfMember[] __members;

    private TdfMap<uint, IList<Blaze3SDK.Blaze.Clubs.ClubLocalizedNews>> _localizedNewsListMap = new(__typeInfos[0]);
    private TdfUInt16 _totalPages = new(__typeInfos[1]);

    public GetNewsForClubsResponse()
    {
        __members = [
            _localizedNewsListMap,
            _totalPages,
        ];
    }

    public override Tdf CreateNew() => new GetNewsForClubsResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetNewsForClubsResponse";
    public override string GetFullClassName() => "Blaze::Clubs::GetNewsForClubsResponse";

    public IDictionary<uint, IList<Blaze3SDK.Blaze.Clubs.ClubLocalizedNews>> LocalizedNewsListMap
    {
        get => _localizedNewsListMap.Value;
        set => _localizedNewsListMap.Value = value;
    }

    public ushort TotalPages
    {
        get => _totalPages.Value;
        set => _totalPages.Value = value;
    }

}

