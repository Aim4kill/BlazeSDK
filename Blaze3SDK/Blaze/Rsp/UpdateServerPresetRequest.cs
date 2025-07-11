using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rsp;

public class UpdateServerPresetRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Preset", "mPreset", 0xC3297300, TdfType.Struct, 0, true), // PRES
        new TdfMemberInfo("ServerId", "mServerId", 0xCE990000, TdfType.UInt32, 1, true), // SID
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze3SDK.Blaze.Rsp.Preset?> _preset = new(__typeInfos[0]);
    private TdfUInt32 _serverId = new(__typeInfos[1]);

    public UpdateServerPresetRequest()
    {
        __members = [
            _preset,
            _serverId,
        ];
    }

    public override Tdf CreateNew() => new UpdateServerPresetRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpdateServerPresetRequest";
    public override string GetFullClassName() => "Blaze::Rsp::UpdateServerPresetRequest";

    public Blaze3SDK.Blaze.Rsp.Preset? Preset
    {
        get => _preset.Value;
        set => _preset.Value = value;
    }

    public uint ServerId
    {
        get => _serverId.Value;
        set => _serverId.Value = value;
    }

}

