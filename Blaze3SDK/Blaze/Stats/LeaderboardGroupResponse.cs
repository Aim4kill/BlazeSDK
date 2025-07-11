using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Stats;

public class LeaderboardGroupResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Ascending", "mAscending", 0x8738E400, TdfType.Bool, 0, true), // ASCD
        new TdfMemberInfo("BoardName", "mBoardName", 0x8AE86D00, TdfType.String, 1, true), // BNAM
        new TdfMemberInfo("Desc", "mDesc", 0x925CE300, TdfType.String, 2, true), // DESC
        new TdfMemberInfo("EntityType", "mEntityType", 0x974E7000, TdfType.ObjectType, 3, true), // ETYP
        new TdfMemberInfo("KeyScopeNameValueListMap", "mKeyScopeNameValueListMap", 0xAF3D6D00, TdfType.Map, 4, true), // KSUM
        new TdfMemberInfo("LeaderboardSize", "mLeaderboardSize", 0xB22CFA00, TdfType.Int32, 5, true), // LBSZ
        new TdfMemberInfo("StatKeyColumns", "mStatKeyColumns", 0xB29CF400, TdfType.List, 6, true), // LIST
        new TdfMemberInfo("Metadata", "mMetadata", 0xB65D2100, TdfType.String, 7, true), // META
        new TdfMemberInfo("Name", "mName", 0xBA1B6500, TdfType.String, 8, true), // NAME
        new TdfMemberInfo("StatName", "mStatName", 0xCEE86D00, TdfType.String, 9, true), // SNAM
    ];
    private ITdfMember[] __members;

    private TdfBool _ascending = new(__typeInfos[0]);
    private TdfString _boardName = new(__typeInfos[1]);
    private TdfString _desc = new(__typeInfos[2]);
    private TdfObjectType _entityType = new(__typeInfos[3]);
    private TdfMap<string, Blaze3SDK.Blaze.Stats.ScopeValues> _keyScopeNameValueListMap = new(__typeInfos[4]);
    private TdfInt32 _leaderboardSize = new(__typeInfos[5]);
    private TdfList<Blaze3SDK.Blaze.Stats.StatDescSummary> _statKeyColumns = new(__typeInfos[6]);
    private TdfString _metadata = new(__typeInfos[7]);
    private TdfString _name = new(__typeInfos[8]);
    private TdfString _statName = new(__typeInfos[9]);

    public LeaderboardGroupResponse()
    {
        __members = [
            _ascending,
            _boardName,
            _desc,
            _entityType,
            _keyScopeNameValueListMap,
            _leaderboardSize,
            _statKeyColumns,
            _metadata,
            _name,
            _statName,
        ];
    }

    public override Tdf CreateNew() => new LeaderboardGroupResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "LeaderboardGroupResponse";
    public override string GetFullClassName() => "Blaze::Stats::LeaderboardGroupResponse";

    public bool Ascending
    {
        get => _ascending.Value;
        set => _ascending.Value = value;
    }

    public string BoardName
    {
        get => _boardName.Value;
        set => _boardName.Value = value;
    }

    public string Desc
    {
        get => _desc.Value;
        set => _desc.Value = value;
    }

    public ObjectType EntityType
    {
        get => _entityType.Value;
        set => _entityType.Value = value;
    }

    public IDictionary<string, Blaze3SDK.Blaze.Stats.ScopeValues> KeyScopeNameValueListMap
    {
        get => _keyScopeNameValueListMap.Value;
        set => _keyScopeNameValueListMap.Value = value;
    }

    public int LeaderboardSize
    {
        get => _leaderboardSize.Value;
        set => _leaderboardSize.Value = value;
    }

    public IList<Blaze3SDK.Blaze.Stats.StatDescSummary> StatKeyColumns
    {
        get => _statKeyColumns.Value;
        set => _statKeyColumns.Value = value;
    }

    public string Metadata
    {
        get => _metadata.Value;
        set => _metadata.Value = value;
    }

    public string Name
    {
        get => _name.Value;
        set => _name.Value = value;
    }

    public string StatName
    {
        get => _statName.Value;
        set => _statName.Value = value;
    }

}

