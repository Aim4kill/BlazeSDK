using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Stats;

public class GetStatsByGroupRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AggrFlags", "mAggrFlags", 0x8679F200, TdfType.Enum, 0, true), // AGGR
        new TdfMemberInfo("EntityIds", "mEntityIds", 0x96990000, TdfType.List, 1, true), // EID
        new TdfMemberInfo("KeyScopeNameValueMap", "mKeyScopeNameValueMap", 0xAF3D6D00, TdfType.Map, 2, true), // KSUM
        new TdfMemberInfo("GroupName", "mGroupName", 0xBA1B6500, TdfType.String, 3, true), // NAME
        new TdfMemberInfo("PeriodCtr", "mPeriodCtr", 0xC23D3200, TdfType.Int32, 4, true), // PCTR
        new TdfMemberInfo("PeriodOffset", "mPeriodOffset", 0xC2F9A600, TdfType.Int32, 5, true), // POFF
        new TdfMemberInfo("PeriodType", "mPeriodType", 0xC34E7000, TdfType.Int32, 6, true), // PTYP
        new TdfMemberInfo("Time", "mTime", 0xD29B6500, TdfType.Int32, 7, true), // TIME
        new TdfMemberInfo("ViewId", "mViewId", 0xDA990000, TdfType.UInt32, 8, true), // VID
    ];
    private ITdfMember[] __members;

    private TdfEnum<Blaze3SDK.Blaze.Stats.AggregateCalcFlags> _aggrFlags = new(__typeInfos[0]);
    private TdfList<long> _entityIds = new(__typeInfos[1]);
    private TdfMap<string, long> _keyScopeNameValueMap = new(__typeInfos[2]);
    private TdfString _groupName = new(__typeInfos[3]);
    private TdfInt32 _periodCtr = new(__typeInfos[4]);
    private TdfInt32 _periodOffset = new(__typeInfos[5]);
    private TdfInt32 _periodType = new(__typeInfos[6]);
    private TdfInt32 _time = new(__typeInfos[7]);
    private TdfUInt32 _viewId = new(__typeInfos[8]);

    public GetStatsByGroupRequest()
    {
        __members = [
            _aggrFlags,
            _entityIds,
            _keyScopeNameValueMap,
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

    public Blaze3SDK.Blaze.Stats.AggregateCalcFlags AggrFlags
    {
        get => _aggrFlags.Value;
        set => _aggrFlags.Value = value;
    }

    public IList<long> EntityIds
    {
        get => _entityIds.Value;
        set => _entityIds.Value = value;
    }

    public IDictionary<string, long> KeyScopeNameValueMap
    {
        get => _keyScopeNameValueMap.Value;
        set => _keyScopeNameValueMap.Value = value;
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

