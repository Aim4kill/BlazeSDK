using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Redirector;

public class XboxServerAddress : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Port", "mPort", 0xC2FCB400, TdfType.UInt16, 0, true), // PORT
        new TdfMemberInfo("ServiceId", "mServiceId", 0xCE990000, TdfType.UInt32, 1, true), // SID
        new TdfMemberInfo("SiteName", "mSiteName", 0xCE9D2500, TdfType.String, 2, true), // SITE
    ];
    private ITdfMember[] __members;

    private TdfUInt16 _port = new(__typeInfos[0]);
    private TdfUInt32 _serviceId = new(__typeInfos[1]);
    private TdfString _siteName = new(__typeInfos[2]);

    public XboxServerAddress()
    {
        __members = [
            _port,
            _serviceId,
            _siteName,
        ];
    }

    public override Tdf CreateNew() => new XboxServerAddress();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "XboxServerAddress";
    public override string GetFullClassName() => "Blaze::Redirector::XboxServerAddress";

    public ushort Port
    {
        get => _port.Value;
        set => _port.Value = value;
    }

    public uint ServiceId
    {
        get => _serviceId.Value;
        set => _serviceId.Value = value;
    }

    public string SiteName
    {
        get => _siteName.Value;
        set => _siteName.Value = value;
    }

}

