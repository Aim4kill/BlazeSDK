using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rsp;

public class GetConfigResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AdminConfig", "mAdminConfig", 0x8639A700, TdfType.Struct, 0, true), // ACFG
        new TdfMemberInfo("GameProtocolVersionString", "mGameProtocolVersionString", 0x9F0DB300, TdfType.String, 1, true), // GPVS
        new TdfMemberInfo("MapRotations", "mMapRotations", 0xB6CCF400, TdfType.List, 2, true), // MLST
        new TdfMemberInfo("MapRotationSettings", "mMapRotationSettings", 0xB7397400, TdfType.List, 3, true), // MSET
        new TdfMemberInfo("Presets", "mPresets", 0xC2CCF400, TdfType.List, 4, true), // PLST
        new TdfMemberInfo("PresetSettings", "mPresetSettings", 0xC3397400, TdfType.List, 5, true), // PSET
        new TdfMemberInfo("PingSites", "mPingSites", 0xC33B3300, TdfType.List, 6, true), // PSLS
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze3SDK.Blaze.Rsp.AdminConfig?> _adminConfig = new(__typeInfos[0]);
    private TdfString _gameProtocolVersionString = new(__typeInfos[1]);
    private TdfList<Blaze3SDK.Blaze.Rsp.MapRotation> _mapRotations = new(__typeInfos[2]);
    private TdfList<Blaze3SDK.Blaze.Rsp.PresetSettingConfig> _mapRotationSettings = new(__typeInfos[3]);
    private TdfList<Blaze3SDK.Blaze.Rsp.Preset> _presets = new(__typeInfos[4]);
    private TdfList<Blaze3SDK.Blaze.Rsp.PresetSettingConfig> _presetSettings = new(__typeInfos[5]);
    private TdfList<Blaze3SDK.Blaze.Rsp.RspPingSiteInfo> _pingSites = new(__typeInfos[6]);

    public GetConfigResponse()
    {
        __members = [
            _adminConfig,
            _gameProtocolVersionString,
            _mapRotations,
            _mapRotationSettings,
            _presets,
            _presetSettings,
            _pingSites,
        ];
    }

    public override Tdf CreateNew() => new GetConfigResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetConfigResponse";
    public override string GetFullClassName() => "Blaze::Rsp::GetConfigResponse";

    public Blaze3SDK.Blaze.Rsp.AdminConfig? AdminConfig
    {
        get => _adminConfig.Value;
        set => _adminConfig.Value = value;
    }

    public string GameProtocolVersionString
    {
        get => _gameProtocolVersionString.Value;
        set => _gameProtocolVersionString.Value = value;
    }

    public IList<Blaze3SDK.Blaze.Rsp.MapRotation> MapRotations
    {
        get => _mapRotations.Value;
        set => _mapRotations.Value = value;
    }

    public IList<Blaze3SDK.Blaze.Rsp.PresetSettingConfig> MapRotationSettings
    {
        get => _mapRotationSettings.Value;
        set => _mapRotationSettings.Value = value;
    }

    public IList<Blaze3SDK.Blaze.Rsp.Preset> Presets
    {
        get => _presets.Value;
        set => _presets.Value = value;
    }

    public IList<Blaze3SDK.Blaze.Rsp.PresetSettingConfig> PresetSettings
    {
        get => _presetSettings.Value;
        set => _presetSettings.Value = value;
    }

    public IList<Blaze3SDK.Blaze.Rsp.RspPingSiteInfo> PingSites
    {
        get => _pingSites.Value;
        set => _pingSites.Value = value;
    }

}

