using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Stats;

public class FilteredLeaderboardStatsRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("IncludeStatlessEntities", "mIncludeStatlessEntities", 0x9A9B3400, TdfType.Bool, 0, true), // FILT
        new TdfMemberInfo("ListOfIds", "mListOfIds", 0xA64B3300, TdfType.List, 1, true), // IDLS
        new TdfMemberInfo("KeyScopeNameValueMap", "mKeyScopeNameValueMap", 0xAF3D6D00, TdfType.Map, 2, true), // KSUM
        new TdfMemberInfo("BoardId", "mBoardId", 0xB22A6400, TdfType.Int32, 3, true), // LBID
        new TdfMemberInfo("BoardName", "mBoardName", 0xBA1B6500, TdfType.String, 4, true), // NAME
        new TdfMemberInfo("PeriodOffset", "mPeriodOffset", 0xC2F9A600, TdfType.Int32, 5, true), // POFF
        new TdfMemberInfo("Time", "mTime", 0xD29B6500, TdfType.Int32, 6, true), // TIME
        new TdfMemberInfo("UserSetId", "mUserSetId", 0xD7397400, TdfType.ObjectId, 7, true), // USET
    ];
    private ITdfMember[] __members;

    private TdfBool _includeStatlessEntities = new(__typeInfos[0]);
    private TdfList<long> _listOfIds = new(__typeInfos[1]);
    private TdfMap<string, long> _keyScopeNameValueMap = new(__typeInfos[2]);
    private TdfInt32 _boardId = new(__typeInfos[3]);
    private TdfString _boardName = new(__typeInfos[4]);
    private TdfInt32 _periodOffset = new(__typeInfos[5]);
    private TdfInt32 _time = new(__typeInfos[6]);
    private TdfObjectId _userSetId = new(__typeInfos[7]);

    public FilteredLeaderboardStatsRequest()
    {
        __members = [
            _includeStatlessEntities,
            _listOfIds,
            _keyScopeNameValueMap,
            _boardId,
            _boardName,
            _periodOffset,
            _time,
            _userSetId,
        ];
    }

    public override Tdf CreateNew() => new FilteredLeaderboardStatsRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "FilteredLeaderboardStatsRequest";
    public override string GetFullClassName() => "Blaze::Stats::FilteredLeaderboardStatsRequest";

    public bool IncludeStatlessEntities
    {
        get => _includeStatlessEntities.Value;
        set => _includeStatlessEntities.Value = value;
    }

    public IList<long> ListOfIds
    {
        get => _listOfIds.Value;
        set => _listOfIds.Value = value;
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

