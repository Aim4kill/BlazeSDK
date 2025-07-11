using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Locker;

public class GetContentTopNRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ContentCategory", "mContentCategory", 0x8E387400, TdfType.String, 0, true), // CCAT
        new TdfMemberInfo("Count", "mCount", 0x8EFD6E00, TdfType.Int32, 1, true), // COUN
        new TdfMemberInfo("Filters", "mFilters", 0x9ACD3200, TdfType.List, 2, true), // FLTR
        new TdfMemberInfo("LeaderboardType", "mLeaderboardType", 0xB2200000, TdfType.Enum, 3, true), // LB
        new TdfMemberInfo("Start", "mStart", 0xCF4CB400, TdfType.Int32, 4, true), // STRT
        new TdfMemberInfo("Tag", "mTag", 0xD219C000, TdfType.String, 5, true), // TAG
        new TdfMemberInfo("LeaderboardView", "mLeaderboardView", 0xDA997700, TdfType.String, 6, true), // VIEW
    ];
    private ITdfMember[] __members;

    private TdfString _contentCategory = new(__typeInfos[0]);
    private TdfInt32 _count = new(__typeInfos[1]);
    private TdfList<Blaze3SDK.Blaze.Locker.LeaderboardFilter> _filters = new(__typeInfos[2]);
    private TdfEnum<Blaze3SDK.Blaze.Locker.LeaderboardType> _leaderboardType = new(__typeInfos[3]);
    private TdfInt32 _start = new(__typeInfos[4]);
    private TdfString _tag = new(__typeInfos[5]);
    private TdfString _leaderboardView = new(__typeInfos[6]);

    public GetContentTopNRequest()
    {
        __members = [
            _contentCategory,
            _count,
            _filters,
            _leaderboardType,
            _start,
            _tag,
            _leaderboardView,
        ];
    }

    public override Tdf CreateNew() => new GetContentTopNRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetContentTopNRequest";
    public override string GetFullClassName() => "Blaze::Locker::GetContentTopNRequest";

    public string ContentCategory
    {
        get => _contentCategory.Value;
        set => _contentCategory.Value = value;
    }

    public int Count
    {
        get => _count.Value;
        set => _count.Value = value;
    }

    public IList<Blaze3SDK.Blaze.Locker.LeaderboardFilter> Filters
    {
        get => _filters.Value;
        set => _filters.Value = value;
    }

    public Blaze3SDK.Blaze.Locker.LeaderboardType LeaderboardType
    {
        get => _leaderboardType.Value;
        set => _leaderboardType.Value = value;
    }

    public int Start
    {
        get => _start.Value;
        set => _start.Value = value;
    }

    public string Tag
    {
        get => _tag.Value;
        set => _tag.Value = value;
    }

    public string LeaderboardView
    {
        get => _leaderboardView.Value;
        set => _leaderboardView.Value = value;
    }

}

