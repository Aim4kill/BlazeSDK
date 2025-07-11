using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Stats;

public class StatRowUpdate : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Category", "mCategory", 0x8E1D0000, TdfType.String, 0, true), // CAT
        new TdfMemberInfo("EntityId", "mEntityId", 0x96990000, TdfType.Int64, 1, true), // EID
        new TdfMemberInfo("KeyScopeNameValueMap", "mKeyScopeNameValueMap", 0xAF3D6D00, TdfType.Map, 2, true), // KSUM
        new TdfMemberInfo("PeriodTypes", "mPeriodTypes", 0xC34E7000, TdfType.List, 3, true), // PTYP
        new TdfMemberInfo("Updates", "mUpdates", 0xD7093400, TdfType.List, 4, true), // UPDT
    ];
    private ITdfMember[] __members;

    private TdfString _category = new(__typeInfos[0]);
    private TdfInt64 _entityId = new(__typeInfos[1]);
    private TdfMap<string, long> _keyScopeNameValueMap = new(__typeInfos[2]);
    private TdfList<int> _periodTypes = new(__typeInfos[3]);
    private TdfList<Blaze3SDK.Blaze.Stats.StatUpdate> _updates = new(__typeInfos[4]);

    public StatRowUpdate()
    {
        __members = [
            _category,
            _entityId,
            _keyScopeNameValueMap,
            _periodTypes,
            _updates,
        ];
    }

    public override Tdf CreateNew() => new StatRowUpdate();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "StatRowUpdate";
    public override string GetFullClassName() => "Blaze::Stats::StatRowUpdate";

    public string Category
    {
        get => _category.Value;
        set => _category.Value = value;
    }

    public long EntityId
    {
        get => _entityId.Value;
        set => _entityId.Value = value;
    }

    public IDictionary<string, long> KeyScopeNameValueMap
    {
        get => _keyScopeNameValueMap.Value;
        set => _keyScopeNameValueMap.Value = value;
    }

    public IList<int> PeriodTypes
    {
        get => _periodTypes.Value;
        set => _periodTypes.Value = value;
    }

    public IList<Blaze3SDK.Blaze.Stats.StatUpdate> Updates
    {
        get => _updates.Value;
        set => _updates.Value = value;
    }

}

