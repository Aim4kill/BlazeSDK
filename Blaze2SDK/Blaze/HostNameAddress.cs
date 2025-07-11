using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze;

public class HostNameAddress : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("HostName", "HostName", 0xBA1B6500, TdfType.String, 0, true), // NAME
        new TdfMemberInfo("Port", "Port", 0xC2FCB400, TdfType.UInt16, 1, true), // PORT
    ];
    private ITdfMember[] __members;

    private TdfString _hostName = new(__typeInfos[0]);
    private TdfUInt16 _port = new(__typeInfos[1]);

    public HostNameAddress()
    {
        __members = [
            _hostName,
            _port,
        ];
    }

    public override Tdf CreateNew() => new HostNameAddress();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "HostNameAddress";
    public override string GetFullClassName() => "Blaze::HostNameAddress";

    public string HostName
    {
        get => _hostName.Value;
        set => _hostName.Value = value;
    }

    public ushort Port
    {
        get => _port.Value;
        set => _port.Value = value;
    }

}

