using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze;

public class XboxServerAddress : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Port", "Port", 0xC2FCB400, TdfType.UInt16, 0, true), // PORT
        new TdfMemberInfo("SiteName", "SiteName", 0xCE9D2500, TdfType.String, 1, true), // SITE
        new TdfMemberInfo("Sid", "Sid", 0xCF6A6400, TdfType.UInt32, 2, true), // SVID
    ];
    private ITdfMember[] __members;

    private TdfUInt16 _port = new(__typeInfos[0]);
    private TdfString _siteName = new(__typeInfos[1]);
    private TdfUInt32 _sid = new(__typeInfos[2]);

    public XboxServerAddress()
    {
        __members = [
            _port,
            _siteName,
            _sid,
        ];
    }

    public override Tdf CreateNew() => new XboxServerAddress();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "XboxServerAddress";
    public override string GetFullClassName() => "Blaze::XboxServerAddress";

    public ushort Port
    {
        get => _port.Value;
        set => _port.Value = value;
    }

    public string SiteName
    {
        get => _siteName.Value;
        set => _siteName.Value = value;
    }

    public uint Sid
    {
        get => _sid.Value;
        set => _sid.Value = value;
    }

}

