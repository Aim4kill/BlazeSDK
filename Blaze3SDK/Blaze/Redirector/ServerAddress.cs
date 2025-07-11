using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Redirector;

public class ServerAddress : Union
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("IpAddress", "mIpAddress", 0xDA1B3500, TdfType.Struct, 0, false), // VALU
        new TdfMemberInfo("XboxServerAddress", "mXboxServerAddress", 0xDA1B3500, TdfType.Struct, 1, false), // VALU
    ];

    private TdfStruct<Blaze3SDK.Blaze.Redirector.IpAddress?> _ipAddress = new(__typeInfos[0]);
    private TdfStruct<Blaze3SDK.Blaze.Redirector.XboxServerAddress?> _xboxServerAddress = new(__typeInfos[1]);

    public override ITdfMember? GetActiveMember()
    {
        return ActiveIndex switch
        {
            0 => _ipAddress,
            1 => _xboxServerAddress,
            _ => null
        };
    }
    public override Tdf CreateNew() => new ServerAddress();
    public override string GetClassName() => "ServerAddress";
    public override string GetFullClassName() => "Blaze::Redirector::ServerAddress";

    public Blaze3SDK.Blaze.Redirector.IpAddress? IpAddress
    {
        get => _ipAddress.Value;
        set
        {
            SwitchActiveIndex(0);
            _ipAddress.Value = value;
        }
    }

    public Blaze3SDK.Blaze.Redirector.XboxServerAddress? XboxServerAddress
    {
        get => _xboxServerAddress.Value;
        set
        {
            SwitchActiveIndex(1);
            _xboxServerAddress.Value = value;
        }
    }

}

