using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rsp;

public class PresetSetting : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Key", "mKey", 0xAE5E4000, TdfType.String, 0, true), // KEY
        new TdfMemberInfo("Locked", "mLocked", 0xB2F8EB00, TdfType.Bool, 1, true), // LOCK
        new TdfMemberInfo("Value", "mValue", 0xDA1B0000, TdfType.Int16, 2, true), // VAL
    ];
    private ITdfMember[] __members;

    private TdfString _key = new(__typeInfos[0]);
    private TdfBool _locked = new(__typeInfos[1]);
    private TdfInt16 _value = new(__typeInfos[2]);

    public PresetSetting()
    {
        __members = [
            _key,
            _locked,
            _value,
        ];
    }

    public override Tdf CreateNew() => new PresetSetting();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PresetSetting";
    public override string GetFullClassName() => "Blaze::Rsp::PresetSetting";

    public string Key
    {
        get => _key.Value;
        set => _key.Value = value;
    }

    public bool Locked
    {
        get => _locked.Value;
        set => _locked.Value = value;
    }

    public short Value
    {
        get => _value.Value;
        set => _value.Value = value;
    }

}

