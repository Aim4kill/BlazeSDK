using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rsp;

public class Preset : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Description", "mDescription", 0x925CE300, TdfType.String, 0, true), // DESC
        new TdfMemberInfo("Name", "mName", 0xBA1B6500, TdfType.String, 1, true), // NAME
        new TdfMemberInfo("PresetId", "mPresetId", 0xC2990000, TdfType.UInt8, 2, true), // PID
        new TdfMemberInfo("Predefined", "mPredefined", 0xC3296400, TdfType.Bool, 3, true), // PRED
        new TdfMemberInfo("Ranked", "mRanked", 0xCA1BAB00, TdfType.Bool, 4, true), // RANK
        new TdfMemberInfo("Settings", "mSettings", 0xCECCF400, TdfType.List, 5, true), // SLST
        new TdfMemberInfo("Type", "mType", 0xD39C2500, TdfType.String, 6, true), // TYPE
    ];
    private ITdfMember[] __members;

    private TdfString _description = new(__typeInfos[0]);
    private TdfString _name = new(__typeInfos[1]);
    private TdfUInt8 _presetId = new(__typeInfos[2]);
    private TdfBool _predefined = new(__typeInfos[3]);
    private TdfBool _ranked = new(__typeInfos[4]);
    private TdfList<Blaze3SDK.Blaze.Rsp.PresetSetting> _settings = new(__typeInfos[5]);
    private TdfString _type = new(__typeInfos[6]);

    public Preset()
    {
        __members = [
            _description,
            _name,
            _presetId,
            _predefined,
            _ranked,
            _settings,
            _type,
        ];
    }

    public override Tdf CreateNew() => new Preset();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "Preset";
    public override string GetFullClassName() => "Blaze::Rsp::Preset";

    public string Description
    {
        get => _description.Value;
        set => _description.Value = value;
    }

    public string Name
    {
        get => _name.Value;
        set => _name.Value = value;
    }

    public byte PresetId
    {
        get => _presetId.Value;
        set => _presetId.Value = value;
    }

    public bool Predefined
    {
        get => _predefined.Value;
        set => _predefined.Value = value;
    }

    public bool Ranked
    {
        get => _ranked.Value;
        set => _ranked.Value = value;
    }

    public IList<Blaze3SDK.Blaze.Rsp.PresetSetting> Settings
    {
        get => _settings.Value;
        set => _settings.Value = value;
    }

    public string Type
    {
        get => _type.Value;
        set => _type.Value = value;
    }

}

