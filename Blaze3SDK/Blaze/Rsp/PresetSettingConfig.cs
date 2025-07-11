using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rsp;

public class PresetSettingConfig : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Default", "mDefault", 0x92598000, TdfType.Int16, 0, true), // DEF
        new TdfMemberInfo("Description", "mDescription", 0x925CE300, TdfType.String, 1, true), // DESC
        new TdfMemberInfo("Key", "mKey", 0xAE5E4000, TdfType.String, 2, true), // KEY
        new TdfMemberInfo("Max", "mMax", 0xB61E0000, TdfType.Int16, 3, true), // MAX
        new TdfMemberInfo("Min", "mMin", 0xB69B8000, TdfType.Int16, 4, true), // MIN
        new TdfMemberInfo("Name", "mName", 0xBA1B6500, TdfType.String, 5, true), // NAME
        new TdfMemberInfo("Ranked", "mRanked", 0xCA1BAB00, TdfType.Bool, 6, true), // RANK
    ];
    private ITdfMember[] __members;

    private TdfInt16 _default = new(__typeInfos[0]);
    private TdfString _description = new(__typeInfos[1]);
    private TdfString _key = new(__typeInfos[2]);
    private TdfInt16 _max = new(__typeInfos[3]);
    private TdfInt16 _min = new(__typeInfos[4]);
    private TdfString _name = new(__typeInfos[5]);
    private TdfBool _ranked = new(__typeInfos[6]);

    public PresetSettingConfig()
    {
        __members = [
            _default,
            _description,
            _key,
            _max,
            _min,
            _name,
            _ranked,
        ];
    }

    public override Tdf CreateNew() => new PresetSettingConfig();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PresetSettingConfig";
    public override string GetFullClassName() => "Blaze::Rsp::PresetSettingConfig";

    public short Default
    {
        get => _default.Value;
        set => _default.Value = value;
    }

    public string Description
    {
        get => _description.Value;
        set => _description.Value = value;
    }

    public string Key
    {
        get => _key.Value;
        set => _key.Value = value;
    }

    public short Max
    {
        get => _max.Value;
        set => _max.Value = value;
    }

    public short Min
    {
        get => _min.Value;
        set => _min.Value = value;
    }

    public string Name
    {
        get => _name.Value;
        set => _name.Value = value;
    }

    public bool Ranked
    {
        get => _ranked.Value;
        set => _ranked.Value = value;
    }

}

