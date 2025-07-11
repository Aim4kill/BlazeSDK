using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Stats;

public class StatGroupSummary : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Desc", "mDesc", 0x925CE300, TdfType.String, 0, true), // DESC
        new TdfMemberInfo("KeyScopeUnitMap", "mKeyScopeUnitMap", 0xAF3D6D00, TdfType.Map, 1, true), // KSUM
        new TdfMemberInfo("Metadata", "mMetadata", 0xB65D2100, TdfType.String, 2, true), // META
        new TdfMemberInfo("Name", "mName", 0xBA1B6500, TdfType.String, 3, true), // NAME
    ];
    private ITdfMember[] __members;

    private TdfString _desc = new(__typeInfos[0]);
    private TdfMap<string, string> _keyScopeUnitMap = new(__typeInfos[1]);
    private TdfString _metadata = new(__typeInfos[2]);
    private TdfString _name = new(__typeInfos[3]);

    public StatGroupSummary()
    {
        __members = [
            _desc,
            _keyScopeUnitMap,
            _metadata,
            _name,
        ];
    }

    public override Tdf CreateNew() => new StatGroupSummary();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "StatGroupSummary";
    public override string GetFullClassName() => "Blaze::Stats::StatGroupSummary";

    public string Desc
    {
        get => _desc.Value;
        set => _desc.Value = value;
    }

    public IDictionary<string, string> KeyScopeUnitMap
    {
        get => _keyScopeUnitMap.Value;
        set => _keyScopeUnitMap.Value = value;
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

}

