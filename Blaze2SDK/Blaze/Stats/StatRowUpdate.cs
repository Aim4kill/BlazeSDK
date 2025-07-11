using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Stats;

public class StatRowUpdate : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Category", "mCategory", 0x8E1D0000, TdfType.String, 0, true), // CAT
        new TdfMemberInfo("ContextId", "mContextId", 0x8E990000, TdfType.UInt32, 1, true), // CID
        new TdfMemberInfo("EntityId", "mEntityId", 0x96990000, TdfType.UInt32, 2, true), // EID
        new TdfMemberInfo("KeyScopeIndexMap", "mKeyScopeIndexMap", 0xAF3D6D00, TdfType.Map, 3, true), // KSUM
        new TdfMemberInfo("PeriodTypes", "mPeriodTypes", 0xC34E7000, TdfType.List, 4, true), // PTYP
        new TdfMemberInfo("Updates", "mUpdates", 0xD7093400, TdfType.List, 5, true), // UPDT
    ];
    private ITdfMember[] __members;

    private TdfString _category = new(__typeInfos[0]);
    private TdfUInt32 _contextId = new(__typeInfos[1]);
    private TdfUInt32 _entityId = new(__typeInfos[2]);
    private TdfMap<string, uint> _keyScopeIndexMap = new(__typeInfos[3]);
    private TdfList<int> _periodTypes = new(__typeInfos[4]);
    private TdfList<Blaze2SDK.Blaze.Stats.StatUpdate> _updates = new(__typeInfos[5]);

    public StatRowUpdate()
    {
        __members = [
            _category,
            _contextId,
            _entityId,
            _keyScopeIndexMap,
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

    public uint ContextId
    {
        get => _contextId.Value;
        set => _contextId.Value = value;
    }

    public uint EntityId
    {
        get => _entityId.Value;
        set => _entityId.Value = value;
    }

    public IDictionary<string, uint> KeyScopeIndexMap
    {
        get => _keyScopeIndexMap.Value;
        set => _keyScopeIndexMap.Value = value;
    }

    public IList<int> PeriodTypes
    {
        get => _periodTypes.Value;
        set => _periodTypes.Value = value;
    }

    public IList<Blaze2SDK.Blaze.Stats.StatUpdate> Updates
    {
        get => _updates.Value;
        set => _updates.Value = value;
    }

}

