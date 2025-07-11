using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Stats;

public class FilteredLeaderboardStatsRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ListName", "mListName", 0x86E86D00, TdfType.String, 0, true), // ANAM
        new TdfMemberInfo("ContextId", "mContextId", 0x8E990000, TdfType.UInt32, 1, true), // CID
        new TdfMemberInfo("ListOfIds", "mListOfIds", 0xA64B3300, TdfType.List, 2, true), // IDLS
        new TdfMemberInfo("ScopeValueMap", "mScopeValueMap", 0xAF3D6D00, TdfType.Map, 3, true), // KSUM
        new TdfMemberInfo("BoardId", "mBoardId", 0xB22A6400, TdfType.Int32, 4, true), // LBID
        new TdfMemberInfo("BoardName", "mBoardName", 0xBA1B6500, TdfType.String, 5, true), // NAME
        new TdfMemberInfo("PeriodOffset", "mPeriodOffset", 0xC2F9A600, TdfType.Int32, 6, true), // POFF
        new TdfMemberInfo("Time", "mTime", 0xD29B6500, TdfType.Int32, 7, true), // TIME
    ];
    private ITdfMember[] __members;

    private TdfString _listName = new(__typeInfos[0]);
    private TdfUInt32 _contextId = new(__typeInfos[1]);
    private TdfList<uint> _listOfIds = new(__typeInfos[2]);
    private TdfMap<string, string> _scopeValueMap = new(__typeInfos[3]);
    private TdfInt32 _boardId = new(__typeInfos[4]);
    private TdfString _boardName = new(__typeInfos[5]);
    private TdfInt32 _periodOffset = new(__typeInfos[6]);
    private TdfInt32 _time = new(__typeInfos[7]);

    public FilteredLeaderboardStatsRequest()
    {
        __members = [
            _listName,
            _contextId,
            _listOfIds,
            _scopeValueMap,
            _boardId,
            _boardName,
            _periodOffset,
            _time,
        ];
    }

    public override Tdf CreateNew() => new FilteredLeaderboardStatsRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "FilteredLeaderboardStatsRequest";
    public override string GetFullClassName() => "Blaze::Stats::FilteredLeaderboardStatsRequest";

    public string ListName
    {
        get => _listName.Value;
        set => _listName.Value = value;
    }

    public uint ContextId
    {
        get => _contextId.Value;
        set => _contextId.Value = value;
    }

    public IList<uint> ListOfIds
    {
        get => _listOfIds.Value;
        set => _listOfIds.Value = value;
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

