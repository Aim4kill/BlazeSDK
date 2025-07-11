using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rsp;

public class UpdateServerSettingsRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ServerSettings", "mServerSettings", 0xCE5D3400, TdfType.Struct, 0, true), // SETT
        new TdfMemberInfo("ServerId", "mServerId", 0xCE990000, TdfType.UInt32, 1, true), // SID
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze3SDK.Blaze.Rsp.ServerSettings?> _serverSettings = new(__typeInfos[0]);
    private TdfUInt32 _serverId = new(__typeInfos[1]);

    public UpdateServerSettingsRequest()
    {
        __members = [
            _serverSettings,
            _serverId,
        ];
    }

    public override Tdf CreateNew() => new UpdateServerSettingsRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpdateServerSettingsRequest";
    public override string GetFullClassName() => "Blaze::Rsp::UpdateServerSettingsRequest";

    public Blaze3SDK.Blaze.Rsp.ServerSettings? ServerSettings
    {
        get => _serverSettings.Value;
        set => _serverSettings.Value = value;
    }

    public uint ServerId
    {
        get => _serverId.Value;
        set => _serverId.Value = value;
    }

}

