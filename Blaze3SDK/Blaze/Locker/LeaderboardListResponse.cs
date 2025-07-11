using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Locker;

public class LeaderboardListResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("LeaderboardSummaries", "mLeaderboardSummaries", 0xB29CF400, TdfType.List, 0, true), // LIST
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze3SDK.Blaze.Locker.LeaderboardSummary> _leaderboardSummaries = new(__typeInfos[0]);

    public LeaderboardListResponse()
    {
        __members = [
            _leaderboardSummaries,
        ];
    }

    public override Tdf CreateNew() => new LeaderboardListResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "LeaderboardListResponse";
    public override string GetFullClassName() => "Blaze::Locker::LeaderboardListResponse";

    public IList<Blaze3SDK.Blaze.Locker.LeaderboardSummary> LeaderboardSummaries
    {
        get => _leaderboardSummaries.Value;
        set => _leaderboardSummaries.Value = value;
    }

}

