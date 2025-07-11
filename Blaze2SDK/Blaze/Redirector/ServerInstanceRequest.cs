using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Redirector;

public class ServerInstanceRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("BlazeSDKVersion", "mBlazeSDKVersion", 0x8B392B00, TdfType.String, 0, true), // BSDK
        new TdfMemberInfo("BlazeSDKBuildDate", "mBlazeSDKBuildDate", 0x8B4A6D00, TdfType.String, 1, true), // BTIM
        new TdfMemberInfo("ClientName", "mClientName", 0x8ECBB400, TdfType.String, 2, true), // CLNT
        new TdfMemberInfo("ClientSkuId", "mClientSkuId", 0x8F3AF500, TdfType.String, 3, true), // CSKU
        new TdfMemberInfo("ClientVersion", "mClientVersion", 0x8F697200, TdfType.String, 4, true), // CVER
        new TdfMemberInfo("DirtySDKVersion", "mDirtySDKVersion", 0x93392B00, TdfType.String, 5, true), // DSDK
        new TdfMemberInfo("Environment", "mEnvironment", 0x96ED8000, TdfType.String, 6, true), // ENV
        new TdfMemberInfo("FirstPartyId", "mFirstPartyId", 0x9B0A6400, TdfType.Union, 7, true), // FPID
        new TdfMemberInfo("ClientLocale", "mClientLocale", 0xB2F8C000, TdfType.UInt32, 8, true), // LOC
        new TdfMemberInfo("Name", "mName", 0xBA1B6500, TdfType.String, 9, true), // NAME
        new TdfMemberInfo("Platform", "mPlatform", 0xC2C87400, TdfType.String, 10, true), // PLAT
        new TdfMemberInfo("ConnectionProfile", "mConnectionProfile", 0xC32BE600, TdfType.String, 11, true), // PROF
    ];
    private ITdfMember[] __members;

    private TdfString _blazeSDKVersion = new(__typeInfos[0]);
    private TdfString _blazeSDKBuildDate = new(__typeInfos[1]);
    private TdfString _clientName = new(__typeInfos[2]);
    private TdfString _clientSkuId = new(__typeInfos[3]);
    private TdfString _clientVersion = new(__typeInfos[4]);
    private TdfString _dirtySDKVersion = new(__typeInfos[5]);
    private TdfString _environment = new(__typeInfos[6]);
    private TdfUnion<Blaze2SDK.Blaze.Redirector.FirstPartyId> _firstPartyId = new(__typeInfos[7]);
    private TdfUInt32 _clientLocale = new(__typeInfos[8]);
    private TdfString _name = new(__typeInfos[9]);
    private TdfString _platform = new(__typeInfos[10]);
    private TdfString _connectionProfile = new(__typeInfos[11]);

    public ServerInstanceRequest()
    {
        __members = [
            _blazeSDKVersion,
            _blazeSDKBuildDate,
            _clientName,
            _clientSkuId,
            _clientVersion,
            _dirtySDKVersion,
            _environment,
            _firstPartyId,
            _clientLocale,
            _name,
            _platform,
            _connectionProfile,
        ];
    }

    public override Tdf CreateNew() => new ServerInstanceRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ServerInstanceRequest";
    public override string GetFullClassName() => "Blaze::Redirector::ServerInstanceRequest";

    public string BlazeSDKVersion
    {
        get => _blazeSDKVersion.Value;
        set => _blazeSDKVersion.Value = value;
    }

    public string BlazeSDKBuildDate
    {
        get => _blazeSDKBuildDate.Value;
        set => _blazeSDKBuildDate.Value = value;
    }

    public string ClientName
    {
        get => _clientName.Value;
        set => _clientName.Value = value;
    }

    public string ClientSkuId
    {
        get => _clientSkuId.Value;
        set => _clientSkuId.Value = value;
    }

    public string ClientVersion
    {
        get => _clientVersion.Value;
        set => _clientVersion.Value = value;
    }

    public string DirtySDKVersion
    {
        get => _dirtySDKVersion.Value;
        set => _dirtySDKVersion.Value = value;
    }

    public string Environment
    {
        get => _environment.Value;
        set => _environment.Value = value;
    }

    public Blaze2SDK.Blaze.Redirector.FirstPartyId FirstPartyId
    {
        get => _firstPartyId.Value;
        set => _firstPartyId.Value = value;
    }

    public uint ClientLocale
    {
        get => _clientLocale.Value;
        set => _clientLocale.Value = value;
    }

    public string Name
    {
        get => _name.Value;
        set => _name.Value = value;
    }

    public string Platform
    {
        get => _platform.Value;
        set => _platform.Value = value;
    }

    public string ConnectionProfile
    {
        get => _connectionProfile.Value;
        set => _connectionProfile.Value = value;
    }

}

