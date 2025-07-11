using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rsp;

public class GetServerDetailsResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AdminList", "mAdminList", 0x86CCF400, TdfType.List, 0, true), // ALST
        new TdfMemberInfo("BanList", "mBanList", 0x8ACCF400, TdfType.List, 1, true), // BLST
        new TdfMemberInfo("MapRotations", "mMapRotations", 0xB6CCF400, TdfType.List, 2, true), // MLST
        new TdfMemberInfo("Presets", "mPresets", 0xC2CCF400, TdfType.List, 3, true), // PLST
        new TdfMemberInfo("Server", "mServer", 0xCE5CB600, TdfType.Struct, 4, true), // SERV
        new TdfMemberInfo("ServerSettings", "mServerSettings", 0xCE5D3400, TdfType.Struct, 5, true), // SETT
        new TdfMemberInfo("VipList", "mVipList", 0xDACCF400, TdfType.List, 6, true), // VLST
    ];
    private ITdfMember[] __members;

    private TdfList<long> _adminList = new(__typeInfos[0]);
    private TdfList<long> _banList = new(__typeInfos[1]);
    private TdfList<Blaze3SDK.Blaze.Rsp.MapRotation> _mapRotations = new(__typeInfos[2]);
    private TdfList<Blaze3SDK.Blaze.Rsp.Preset> _presets = new(__typeInfos[3]);
    private TdfStruct<Blaze3SDK.Blaze.Rsp.Server?> _server = new(__typeInfos[4]);
    private TdfStruct<Blaze3SDK.Blaze.Rsp.ServerSettings?> _serverSettings = new(__typeInfos[5]);
    private TdfList<long> _vipList = new(__typeInfos[6]);

    public GetServerDetailsResponse()
    {
        __members = [
            _adminList,
            _banList,
            _mapRotations,
            _presets,
            _server,
            _serverSettings,
            _vipList,
        ];
    }

    public override Tdf CreateNew() => new GetServerDetailsResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetServerDetailsResponse";
    public override string GetFullClassName() => "Blaze::Rsp::GetServerDetailsResponse";

    public IList<long> AdminList
    {
        get => _adminList.Value;
        set => _adminList.Value = value;
    }

    public IList<long> BanList
    {
        get => _banList.Value;
        set => _banList.Value = value;
    }

    public IList<Blaze3SDK.Blaze.Rsp.MapRotation> MapRotations
    {
        get => _mapRotations.Value;
        set => _mapRotations.Value = value;
    }

    public IList<Blaze3SDK.Blaze.Rsp.Preset> Presets
    {
        get => _presets.Value;
        set => _presets.Value = value;
    }

    public Blaze3SDK.Blaze.Rsp.Server? Server
    {
        get => _server.Value;
        set => _server.Value = value;
    }

    public Blaze3SDK.Blaze.Rsp.ServerSettings? ServerSettings
    {
        get => _serverSettings.Value;
        set => _serverSettings.Value = value;
    }

    public IList<long> VipList
    {
        get => _vipList.Value;
        set => _vipList.Value = value;
    }

}

