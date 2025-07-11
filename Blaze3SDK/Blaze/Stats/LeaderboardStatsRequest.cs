using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Stats;

public class LeaderboardStatsRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Count", "mCount", 0x8EFD6E00, TdfType.Int32, 0, true), // COUN
        new TdfMemberInfo("KeyScopeNameValueMap", "mKeyScopeNameValueMap", 0xAF3D6D00, TdfType.Map, 1, true), // KSUM
        new TdfMemberInfo("BoardId", "mBoardId", 0xB22A6400, TdfType.Int32, 2, true), // LBID
        new TdfMemberInfo("BoardName", "mBoardName", 0xBA1B6500, TdfType.String, 3, true), // NAME
        new TdfMemberInfo("PeriodOffset", "mPeriodOffset", 0xC2F9A600, TdfType.Int32, 4, true), // POFF
        new TdfMemberInfo("RankStart", "mRankStart", 0xCF4CB400, TdfType.Int32, 5, true), // STRT
        new TdfMemberInfo("Time", "mTime", 0xD29B6500, TdfType.Int32, 6, true), // TIME
        new TdfMemberInfo("UserSetId", "mUserSetId", 0xD7397400, TdfType.ObjectId, 7, true), // USET
    ];
    private ITdfMember[] __members;

    private TdfInt32 _count = new(__typeInfos[0]);
    private TdfMap<string, long> _keyScopeNameValueMap = new(__typeInfos[1]);
    private TdfInt32 _boardId = new(__typeInfos[2]);
    private TdfString _boardName = new(__typeInfos[3]);
    private TdfInt32 _periodOffset = new(__typeInfos[4]);
    private TdfInt32 _rankStart = new(__typeInfos[5]);
    private TdfInt32 _time = new(__typeInfos[6]);
    private TdfObjectId _userSetId = new(__typeInfos[7]);

    public LeaderboardStatsRequest()
    {
        __members = [
            _count,
            _keyScopeNameValueMap,
            _boardId,
            _boardName,
            _periodOffset,
            _rankStart,
            _time,
            _userSetId,
        ];
    }

    public override Tdf CreateNew() => new LeaderboardStatsRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "LeaderboardStatsRequest";
    public override string GetFullClassName() => "Blaze::Stats::LeaderboardStatsRequest";

    public int Count
    {
        get => _count.Value;
        set => _count.Value = value;
    }

    public IDictionary<string, long> KeyScopeNameValueMap
    {
        get => _keyScopeNameValueMap.Value;
        set => _keyScopeNameValueMap.Value = value;
    }

    public int BoardId
    {
        get => _boardId.Value;
        set => _boardId.Value = value;
    }

    public string BoardName
    {
        get => _boardName.Value;
        set => _boardName.Value = value;
    }

    public int PeriodOffset
    {
        get => _periodOffset.Value;
        set => _periodOffset.Value = value;
    }

    public int RankStart
    {
        get => _rankStart.Value;
        set => _rankStart.Value = value;
    }

    public int Time
    {
        get => _time.Value;
        set => _time.Value = value;
    }

    public ObjectId UserSetId
    {
        get => _userSetId.Value;
        set => _userSetId.Value = value;
    }

}

