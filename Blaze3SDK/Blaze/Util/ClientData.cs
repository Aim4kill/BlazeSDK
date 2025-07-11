using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Util;

public class ClientData : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("IgnoreInactivityTimeout", "mIgnoreInactivityTimeout", 0xA69D2F00, TdfType.Bool, 0, true), // IITO
        new TdfMemberInfo("Locale", "mLocale", 0xB21BA700, TdfType.UInt32, 1, true), // LANG
        new TdfMemberInfo("ServiceName", "mServiceName", 0xCF68EE00, TdfType.String, 2, true), // SVCN
        new TdfMemberInfo("ClientType", "mClientType", 0xD39C2500, TdfType.Enum, 3, true), // TYPE
    ];
    private ITdfMember[] __members;

    private TdfBool _ignoreInactivityTimeout = new(__typeInfos[0]);
    private TdfUInt32 _locale = new(__typeInfos[1]);
    private TdfString _serviceName = new(__typeInfos[2]);
    private TdfEnum<Blaze3SDK.Blaze.ClientType> _clientType = new(__typeInfos[3]);

    public ClientData()
    {
        __members = [
            _ignoreInactivityTimeout,
            _locale,
            _serviceName,
            _clientType,
        ];
    }

    public override Tdf CreateNew() => new ClientData();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ClientData";
    public override string GetFullClassName() => "Blaze::Util::ClientData";

    public bool IgnoreInactivityTimeout
    {
        get => _ignoreInactivityTimeout.Value;
        set => _ignoreInactivityTimeout.Value = value;
    }

    public uint Locale
    {
        get => _locale.Value;
        set => _locale.Value = value;
    }

    public string ServiceName
    {
        get => _serviceName.Value;
        set => _serviceName.Value = value;
    }

    public Blaze3SDK.Blaze.ClientType ClientType
    {
        get => _clientType.Value;
        set => _clientType.Value = value;
    }

}

