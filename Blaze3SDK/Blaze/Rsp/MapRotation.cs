using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rsp;

public class MapRotation : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Description", "mDescription", 0x925CE300, TdfType.String, 0, true), // DESC
        new TdfMemberInfo("Maps", "mMaps", 0xB6CCF400, TdfType.List, 1, true), // MLST
        new TdfMemberInfo("Mod", "mMod", 0xB6F90000, TdfType.String, 2, true), // MOD
        new TdfMemberInfo("MapRotationId", "mMapRotationId", 0xB72A6400, TdfType.UInt8, 3, true), // MRID
        new TdfMemberInfo("Name", "mName", 0xBA1B6500, TdfType.String, 4, true), // NAME
        new TdfMemberInfo("RandomStartMap", "mRandomStartMap", 0xCA1BA400, TdfType.Bool, 5, true), // RAND
        new TdfMemberInfo("Settings", "mSettings", 0xCECCF400, TdfType.List, 6, true), // SLST
    ];
    private ITdfMember[] __members;

    private TdfString _description = new(__typeInfos[0]);
    private TdfList<Blaze3SDK.Blaze.Rsp.MapRotationEntry> _maps = new(__typeInfos[1]);
    private TdfString _mod = new(__typeInfos[2]);
    private TdfUInt8 _mapRotationId = new(__typeInfos[3]);
    private TdfString _name = new(__typeInfos[4]);
    private TdfBool _randomStartMap = new(__typeInfos[5]);
    private TdfList<Blaze3SDK.Blaze.Rsp.PresetSetting> _settings = new(__typeInfos[6]);

    public MapRotation()
    {
        __members = [
            _description,
            _maps,
            _mod,
            _mapRotationId,
            _name,
            _randomStartMap,
            _settings,
        ];
    }

    public override Tdf CreateNew() => new MapRotation();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "MapRotation";
    public override string GetFullClassName() => "Blaze::Rsp::MapRotation";

    public string Description
    {
        get => _description.Value;
        set => _description.Value = value;
    }

    public IList<Blaze3SDK.Blaze.Rsp.MapRotationEntry> Maps
    {
        get => _maps.Value;
        set => _maps.Value = value;
    }

    public string Mod
    {
        get => _mod.Value;
        set => _mod.Value = value;
    }

    public byte MapRotationId
    {
        get => _mapRotationId.Value;
        set => _mapRotationId.Value = value;
    }

    public string Name
    {
        get => _name.Value;
        set => _name.Value = value;
    }

    public bool RandomStartMap
    {
        get => _randomStartMap.Value;
        set => _randomStartMap.Value = value;
    }

    public IList<Blaze3SDK.Blaze.Rsp.PresetSetting> Settings
    {
        get => _settings.Value;
        set => _settings.Value = value;
    }

}

