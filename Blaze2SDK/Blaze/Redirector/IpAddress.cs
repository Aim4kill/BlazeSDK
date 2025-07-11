using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Redirector;

public class IpAddress : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Hostname", "mHostname", 0xA2FCF400, TdfType.String, 0, true), // HOST
        new TdfMemberInfo("Ip", "mIp", 0xA7000000, TdfType.UInt32, 1, true), // IP
        new TdfMemberInfo("Port", "mPort", 0xC2FCB400, TdfType.UInt16, 2, true), // PORT
    ];
    private ITdfMember[] __members;

    private TdfString _hostname = new(__typeInfos[0]);
    private TdfUInt32 _ip = new(__typeInfos[1]);
    private TdfUInt16 _port = new(__typeInfos[2]);

    public IpAddress()
    {
        __members = [
            _hostname,
            _ip,
            _port,
        ];
    }

    public override Tdf CreateNew() => new IpAddress();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "IpAddress";
    public override string GetFullClassName() => "Blaze::Redirector::IpAddress";

    public string Hostname
    {
        get => _hostname.Value;
        set => _hostname.Value = value;
    }

    public uint Ip
    {
        get => _ip.Value;
        set => _ip.Value = value;
    }

    public ushort Port
    {
        get => _port.Value;
        set => _port.Value = value;
    }

}

