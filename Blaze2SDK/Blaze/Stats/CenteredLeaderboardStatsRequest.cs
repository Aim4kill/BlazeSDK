using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Stats;

public class CenteredLeaderboardStatsRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Center", "mCenter", 0x8E5BB400, TdfType.UInt32, 0, true), // CENT
        new TdfMemberInfo("ContextId", "mContextId", 0x8E990000, TdfType.UInt32, 1, true), // CID
        new TdfMemberInfo("Count", "mCount", 0x8EFD6E00, TdfType.Int32, 2, true), // COUN
        new TdfMemberInfo("ScopeValueMap", "mScopeValueMap", 0xAF3D6D00, TdfType.Map, 3, true), // KSUM
        new TdfMemberInfo("BoardId", "mBoardId", 0xB22A6400, TdfType.Int32, 4, true), // LBID
        new TdfMemberInfo("BoardName", "mBoardName", 0xBA1B6500, TdfType.String, 5, true), // NAME
        new TdfMemberInfo("PeriodOffset", "mPeriodOffset", 0xC2F9A600, TdfType.Int32, 6, true), // POFF
        new TdfMemberInfo("Time", "mTime", 0xD29B6500, TdfType.Int32, 7, true), // TIME
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _center = new(__typeInfos[0]);
    private TdfUInt32 _contextId = new(__typeInfos[1]);
    private TdfInt32 _count = new(__typeInfos[2]);
    private TdfMap<string, string> _scopeValueMap = new(__typeInfos[3]);
    private TdfInt32 _boardId = new(__typeInfos[4]);
    private TdfString _boardName = new(__typeInfos[5]);
    private TdfInt32 _periodOffset = new(__typeInfos[6]);
    private TdfInt32 _time = new(__typeInfos[7]);

    public CenteredLeaderboardStatsRequest()
    {
        __members = [
            _center,
            _contextId,
            _count,
            _scopeValueMap,
            _boardId,
            _boardName,
            _periodOffset,
            _time,
        ];
    }

    public override Tdf CreateNew() => new CenteredLeaderboardStatsRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "CenteredLeaderboardStatsRequest";
    public override string GetFullClassName() => "Blaze::Stats::CenteredLeaderboardStatsRequest";

    public uint Center
    {
        get => _center.Value;
        set => _center.Value = value;
    }

    public uint ContextId
    {
        get => _contextId.Value;
        set => _contextId.Value = value;
    }

    public int Count
    {
        get => _count.Value;
        set => _count.Value = value;
    }

    public IDictionary<string, string> ScopeValueMap
    {
        get => _scopeValueMap.Value;
        set => _scopeValueMap.Value = value;
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

    public int Time
    {
        get => _time.Value;
        set => _time.Value = value;
    }

}

