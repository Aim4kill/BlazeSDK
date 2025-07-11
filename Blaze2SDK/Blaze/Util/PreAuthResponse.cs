using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Util;

public class PreAuthResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ComponentIds", "mComponentIds", 0x8E993300, TdfType.List, 0, true), // CIDS
        new TdfMemberInfo("Config", "mConfig", 0x8EFBA600, TdfType.Struct, 1, true), // CONF
        new TdfMemberInfo("QosSettings", "mQosSettings", 0xC6FCF300, TdfType.Struct, 2, true), // QOSS
        new TdfMemberInfo("ServerVersion", "mServerVersion", 0xCF697200, TdfType.String, 3, true), // SVER
    ];
    private ITdfMember[] __members;

    private TdfList<ushort> _componentIds = new(__typeInfos[0]);
    private TdfStruct<Blaze2SDK.Blaze.Util.FetchConfigResponse?> _config = new(__typeInfos[1]);
    private TdfStruct<Blaze2SDK.Blaze.QosConfigInfo?> _qosSettings = new(__typeInfos[2]);
    private TdfString _serverVersion = new(__typeInfos[3]);

    public PreAuthResponse()
    {
        __members = [
            _componentIds,
            _config,
            _qosSettings,
            _serverVersion,
        ];
    }

    public override Tdf CreateNew() => new PreAuthResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PreAuthResponse";
    public override string GetFullClassName() => "Blaze::Util::PreAuthResponse";

    public IList<ushort> ComponentIds
    {
        get => _componentIds.Value;
        set => _componentIds.Value = value;
    }

    public Blaze2SDK.Blaze.Util.FetchConfigResponse? Config
    {
        get => _config.Value;
        set => _config.Value = value;
    }

    public Blaze2SDK.Blaze.QosConfigInfo? QosSettings
    {
        get => _qosSettings.Value;
        set => _qosSettings.Value = value;
    }

    public string ServerVersion
    {
        get => _serverVersion.Value;
        set => _serverVersion.Value = value;
    }

}

