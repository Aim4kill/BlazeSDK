using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Stats;

public class GetStatsByGroupRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AggrFlags", "mAggrFlags", 0x8679F200, TdfType.Enum, 0, true), // AGGR
        new TdfMemberInfo("ContextId", "mContextId", 0x8E990000, TdfType.UInt32, 1, true), // CID
        new TdfMemberInfo("EntityIds", "mEntityIds", 0x96990000, TdfType.List, 2, true), // EID
        new TdfMemberInfo("KeyScopeUnitMap", "mKeyScopeUnitMap", 0xAF3D6D00, TdfType.Map, 3, true), // KSUM
        new TdfMemberInfo("GroupName", "mGroupName", 0xBA1B6500, TdfType.String, 4, true), // NAME
        new TdfMemberInfo("PeriodCtr", "mPeriodCtr", 0xC23D3200, TdfType.Int32, 5, true), // PCTR
        new TdfMemberInfo("PeriodOffset", "mPeriodOffset", 0xC2F9A600, TdfType.Int32, 6, true), // POFF
        new TdfMemberInfo("PeriodType", "mPeriodType", 0xC34E7000, TdfType.Int32, 7, true), // PTYP
        new TdfMemberInfo("Time", "mTime", 0xD29B6500, TdfType.Int32, 8, true), // TIME
        new TdfMemberInfo("ViewId", "mViewId", 0xDA990000, TdfType.UInt32, 9, true), // VID
    ];
    private ITdfMember[] __members;

    private TdfEnum<Blaze2SDK.Blaze.Stats.AggregateCalcFlags> _aggrFlags = new(__typeInfos[0]);
    private TdfUInt32 _contextId = new(__typeInfos[1]);
    private TdfList<uint> _entityIds = new(__typeInfos[2]);
    private TdfMap<string, string> _keyScopeUnitMap = new(__typeInfos[3]);
    private TdfString _groupName = new(__typeInfos[4]);
    private TdfInt32 _periodCtr = new(__typeInfos[5]);
    private TdfInt32 _periodOffset = new(__typeInfos[6]);
    private TdfInt32 _periodType = new(__typeInfos[7]);
    private TdfInt32 _time = new(__typeInfos[8]);
    private TdfUInt32 _viewId = new(__typeInfos[9]);

    public GetStatsByGroupRequest()
    {
        __members = [
            _aggrFlags,
            _contextId,
            _entityIds,
            _keyScopeUnitMap,
            _groupName,
            _periodCtr,
            _periodOffset,
            _periodType,
            _time,
            _viewId,
        ];
    }

    public override Tdf CreateNew() => new GetStatsByGroupRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetStatsByGroupRequest";
    public override string GetFullClassName() => "Blaze::Stats::GetStatsByGroupRequest";

    public Blaze2SDK.Blaze.Stats.AggregateCalcFlags AggrFlags
    {
        get => _aggrFlags.Value;
        set => _aggrFlags.Value = value;
    }

    public uint ContextId
    {
        get => _contextId.Value;
        set => _contextId.Value = value;
    }

    public IList<uint> EntityIds
    {
        get => _entityIds.Value;
        set => _entityIds.Value = value;
    }

    public IDictionary<string, string> KeyScopeUnitMap
    {
        get => _keyScopeUnitMap.Value;
        set => _keyScopeUnitMap.Value = value;
    }

    public string GroupName
    {
        get => _groupName.Value;
        set => _groupName.Value = value;
    }

    public int PeriodCtr
    {
        get => _periodCtr.Value;
        set => _periodCtr.Value = value;
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

    public int Time
    {
        get => _time.Value;
        set => _time.Value = value;
    }

    public uint ViewId
    {
        get => _viewId.Value;
        set => _viewId.Value = value;
    }

}

