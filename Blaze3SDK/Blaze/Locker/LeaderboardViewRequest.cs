using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Locker;

public class LeaderboardViewRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ContentCategory", "mContentCategory", 0x8E387400, TdfType.String, 0, true), // CCAT
        new TdfMemberInfo("LeaderboardType", "mLeaderboardType", 0xB2200000, TdfType.Enum, 1, true), // LB
        new TdfMemberInfo("LeaderboardView", "mLeaderboardView", 0xDA997700, TdfType.String, 2, true), // VIEW
    ];
    private ITdfMember[] __members;

    private TdfString _contentCategory = new(__typeInfos[0]);
    private TdfEnum<Blaze3SDK.Blaze.Locker.LeaderboardType> _leaderboardType = new(__typeInfos[1]);
    private TdfString _leaderboardView = new(__typeInfos[2]);

    public LeaderboardViewRequest()
    {
        __members = [
            _contentCategory,
            _leaderboardType,
            _leaderboardView,
        ];
    }

    public override Tdf CreateNew() => new LeaderboardViewRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "LeaderboardViewRequest";
    public override string GetFullClassName() => "Blaze::Locker::LeaderboardViewRequest";

    public string ContentCategory
    {
        get => _contentCategory.Value;
        set => _contentCategory.Value = value;
    }

    public Blaze3SDK.Blaze.Locker.LeaderboardType LeaderboardType
    {
        get => _leaderboardType.Value;
        set => _leaderboardType.Value = value;
    }

    public string LeaderboardView
    {
        get => _leaderboardView.Value;
        set => _leaderboardView.Value = value;
    }

}

