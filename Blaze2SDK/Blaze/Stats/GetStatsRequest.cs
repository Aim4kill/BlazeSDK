using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Stats;

public class GetStatsRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Category", "mCategory", 0x8E1D0000, TdfType.String, 0, true), // CAT
        new TdfMemberInfo("ContextId", "mContextId", 0x8E990000, TdfType.UInt32, 1, true), // CID
        new TdfMemberInfo("ContextType", "mContextType", 0x8F4E7000, TdfType.UInt32, 2, true), // CTYP
        new TdfMemberInfo("EntityIds", "mEntityIds", 0x96990000, TdfType.List, 3, true), // EID
        new TdfMemberInfo("EntityType", "mEntityType", 0x974E7000, TdfType.UInt32, 4, true), // ETYP
        new TdfMemberInfo("KeyScopeUnitMap", "mKeyScopeUnitMap", 0xAF3B3300, TdfType.Map, 5, true), // KSLS
        new TdfMemberInfo("StatNames", "mStatNames", 0xBA1B6500, TdfType.List, 6, true), // NAME
        new TdfMemberInfo("PeriodOffset", "mPeriodOffset", 0xC2F9A600, TdfType.Int32, 7, true), // POFF
        new TdfMemberInfo("PeriodType", "mPeriodType", 0xC34E7000, TdfType.Int32, 8, true), // PTYP
    ];
    private ITdfMember[] __members;

    private TdfString _category = new(__typeInfos[0]);
    private TdfUInt32 _contextId = new(__typeInfos[1]);
    private TdfUInt32 _contextType = new(__typeInfos[2]);
    private TdfList<uint> _entityIds = new(__typeInfos[3]);
    private TdfUInt32 _entityType = new(__typeInfos[4]);
    private TdfMap<string, string> _keyScopeUnitMap = new(__typeInfos[5]);
    private TdfList<string> _statNames = new(__typeInfos[6]);
    private TdfInt32 _periodOffset = new(__typeInfos[7]);
    private TdfInt32 _periodType = new(__typeInfos[8]);

    public GetStatsRequest()
    {
        __members = [
            _category,
            _contextId,
            _contextType,
            _entityIds,
            _entityType,
            _keyScopeUnitMap,
            _statNames,
            _periodOffset,
            _periodType,
        ];
    }

    public override Tdf CreateNew() => new GetStatsRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetStatsRequest";
    public override string GetFullClassName() => "Blaze::Stats::GetStatsRequest";

    public string Category
    {
        get => _category.Value;
        set => _category.Value = value;
    }

    public uint ContextId
    {
        get => _contextId.Value;
        set => _contextId.Value = value;
    }

    public uint ContextType
    {
        get => _contextType.Value;
        set => _contextType.Value = value;
    }

    public IList<uint> EntityIds
    {
        get => _entityIds.Value;
        set => _entityIds.Value = value;
    }

    public uint EntityType
    {
        get => _entityType.Value;
        set => _entityType.Value = value;
    }

    public IDictionary<string, string> KeyScopeUnitMap
    {
        get => _keyScopeUnitMap.Value;
        set => _keyScopeUnitMap.Value = value;
    }

    public IList<string> StatNames
    {
        get => _statNames.Value;
        set => _statNames.Value = value;
    }

    public int PeriodOffset
    {
        get => _periodOffset.Value;
        set => _periodOffset.Value = value;
    }

    public int PeriodType
    {
        get => _periodType.Value;
        set => _periodType.Value = value;
    }

}

