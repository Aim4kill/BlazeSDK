using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Util;

public class PreAuthRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClientData", "mClientData", 0x8E487400, TdfType.Struct, 0, true), // CDAT
        new TdfMemberInfo("ClientInfo", "mClientInfo", 0x8E9BA600, TdfType.Struct, 1, true), // CINF
        new TdfMemberInfo("FetchClientConfig", "mFetchClientConfig", 0x9A38F200, TdfType.Struct, 2, true), // FCCR
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze2SDK.Blaze.Util.ClientData?> _clientData = new(__typeInfos[0]);
    private TdfStruct<Blaze2SDK.Blaze.ClientInfo?> _clientInfo = new(__typeInfos[1]);
    private TdfStruct<Blaze2SDK.Blaze.Util.FetchClientConfigRequest?> _fetchClientConfig = new(__typeInfos[2]);

    public PreAuthRequest()
    {
        __members = [
            _clientData,
            _clientInfo,
            _fetchClientConfig,
        ];
    }

    public override Tdf CreateNew() => new PreAuthRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PreAuthRequest";
    public override string GetFullClassName() => "Blaze::Util::PreAuthRequest";

    public Blaze2SDK.Blaze.Util.ClientData? ClientData
    {
        get => _clientData.Value;
        set => _clientData.Value = value;
    }

    public Blaze2SDK.Blaze.ClientInfo? ClientInfo
    {
        get => _clientInfo.Value;
        set => _clientInfo.Value = value;
    }

    public Blaze2SDK.Blaze.Util.FetchClientConfigRequest? FetchClientConfig
    {
        get => _fetchClientConfig.Value;
        set => _fetchClientConfig.Value = value;
    }

}

