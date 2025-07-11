using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze;

public class ClientInfo : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("BlazeSDKVersion", "mBlazeSDKVersion", 0x8B392B00, TdfType.String, 0, true), // BSDK
        new TdfMemberInfo("BlazeSDKBuildDate", "mBlazeSDKBuildDate", 0x8B4A6D00, TdfType.String, 1, true), // BTIM
        new TdfMemberInfo("ClientName", "mClientName", 0x8ECBB400, TdfType.String, 2, true), // CLNT
        new TdfMemberInfo("ClientSkuId", "mClientSkuId", 0x8F3AF500, TdfType.String, 3, true), // CSKU
        new TdfMemberInfo("ClientVersion", "mClientVersion", 0x8F697200, TdfType.String, 4, true), // CVER
        new TdfMemberInfo("DirtySDKVersion", "mDirtySDKVersion", 0x93392B00, TdfType.String, 5, true), // DSDK
        new TdfMemberInfo("Environment", "mEnvironment", 0x96ED8000, TdfType.String, 6, true), // ENV
        new TdfMemberInfo("ClientLocale", "mClientLocale", 0xB2F8C000, TdfType.UInt32, 7, true), // LOC
        new TdfMemberInfo("MacAddress", "mMacAddress", 0xB618C000, TdfType.String, 8, true), // MAC
        new TdfMemberInfo("Platform", "mPlatform", 0xC2C87400, TdfType.String, 9, true), // PLAT
    ];
    private ITdfMember[] __members;

    private TdfString _blazeSDKVersion = new(__typeInfos[0]);
    private TdfString _blazeSDKBuildDate = new(__typeInfos[1]);
    private TdfString _clientName = new(__typeInfos[2]);
    private TdfString _clientSkuId = new(__typeInfos[3]);
    private TdfString _clientVersion = new(__typeInfos[4]);
    private TdfString _dirtySDKVersion = new(__typeInfos[5]);
    private TdfString _environment = new(__typeInfos[6]);
    private TdfUInt32 _clientLocale = new(__typeInfos[7]);
    private TdfString _macAddress = new(__typeInfos[8]);
    private TdfString _platform = new(__typeInfos[9]);

    public ClientInfo()
    {
        __members = [
            _blazeSDKVersion,
            _blazeSDKBuildDate,
            _clientName,
            _clientSkuId,
            _clientVersion,
            _dirtySDKVersion,
            _environment,
            _clientLocale,
            _macAddress,
            _platform,
        ];
    }

    public override Tdf CreateNew() => new ClientInfo();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ClientInfo";
    public override string GetFullClassName() => "Blaze::ClientInfo";

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

    public uint ClientLocale
    {
        get => _clientLocale.Value;
        set => _clientLocale.Value = value;
    }

    public string MacAddress
    {
        get => _macAddress.Value;
        set => _macAddress.Value = value;
    }

    public string Platform
    {
        get => _platform.Value;
        set => _platform.Value = value;
    }

}

