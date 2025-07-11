using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze;

public class NetworkAddress : Union
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("XboxClientAddress", "mXboxClientAddress", 0xDA1B3500, TdfType.Struct, 0, false), // VALU
        new TdfMemberInfo("XboxServerAddress", "mXboxServerAddress", 0xDA1B3500, TdfType.Struct, 1, false), // VALU
        new TdfMemberInfo("IpPairAddress", "mIpPairAddress", 0xDA1B3500, TdfType.Struct, 2, false), // VALU
        new TdfMemberInfo("IpAddress", "mIpAddress", 0xDA1B3500, TdfType.Struct, 3, false), // VALU
        new TdfMemberInfo("HostNameAddress", "mHostNameAddress", 0xDA1B3500, TdfType.Struct, 4, false), // VALU
    ];

    private TdfStruct<Blaze3SDK.Blaze.XboxClientAddress?> _xboxClientAddress = new(__typeInfos[0]);
    private TdfStruct<Blaze3SDK.Blaze.XboxServerAddress?> _xboxServerAddress = new(__typeInfos[1]);
    private TdfStruct<Blaze3SDK.Blaze.IpPairAddress?> _ipPairAddress = new(__typeInfos[2]);
    private TdfStruct<Blaze3SDK.Blaze.IpAddress?> _ipAddress = new(__typeInfos[3]);
    private TdfStruct<Blaze3SDK.Blaze.HostNameAddress?> _hostNameAddress = new(__typeInfos[4]);

    public override ITdfMember? GetActiveMember()
    {
        return ActiveIndex switch
        {
            0 => _xboxClientAddress,
            1 => _xboxServerAddress,
            2 => _ipPairAddress,
            3 => _ipAddress,
            4 => _hostNameAddress,
            _ => null
        };
    }
    public override Tdf CreateNew() => new NetworkAddress();
    public override string GetClassName() => "NetworkAddress";
    public override string GetFullClassName() => "Blaze::NetworkAddress";

    public Blaze3SDK.Blaze.XboxClientAddress? XboxClientAddress
    {
        get => _xboxClientAddress.Value;
        set
        {
            SwitchActiveIndex(0);
            _xboxClientAddress.Value = value;
        }
    }

    public Blaze3SDK.Blaze.XboxServerAddress? XboxServerAddress
    {
        get => _xboxServerAddress.Value;
        set
        {
            SwitchActiveIndex(1);
            _xboxServerAddress.Value = value;
        }
    }

    public Blaze3SDK.Blaze.IpPairAddress? IpPairAddress
    {
        get => _ipPairAddress.Value;
        set
        {
            SwitchActiveIndex(2);
            _ipPairAddress.Value = value;
        }
    }

    public Blaze3SDK.Blaze.IpAddress? IpAddress
    {
        get => _ipAddress.Value;
        set
        {
            SwitchActiveIndex(3);
            _ipAddress.Value = value;
        }
    }

    public Blaze3SDK.Blaze.HostNameAddress? HostNameAddress
    {
        get => _hostNameAddress.Value;
        set
        {
            SwitchActiveIndex(4);
            _hostNameAddress.Value = value;
        }
    }

}

