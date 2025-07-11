using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Redirector;

public class NameRemapEntry : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("DstPort", "mDstPort", 0x930CB400, TdfType.UInt16, 0, true), // DPRT
        new TdfMemberInfo("ServiceId", "mServiceId", 0xCE990000, TdfType.UInt32, 1, true), // SID
        new TdfMemberInfo("Hostname", "mHostname", 0xCE9C0000, TdfType.String, 2, true), // SIP
        new TdfMemberInfo("SiteName", "mSiteName", 0xCE9D2500, TdfType.String, 3, true), // SITE
        new TdfMemberInfo("SrcPort", "mSrcPort", 0xCF0CB400, TdfType.UInt16, 4, true), // SPRT
    ];
    private ITdfMember[] __members;

    private TdfUInt16 _dstPort = new(__typeInfos[0]);
    private TdfUInt32 _serviceId = new(__typeInfos[1]);
    private TdfString _hostname = new(__typeInfos[2]);
    private TdfString _siteName = new(__typeInfos[3]);
    private TdfUInt16 _srcPort = new(__typeInfos[4]);

    public NameRemapEntry()
    {
        __members = [
            _dstPort,
            _serviceId,
            _hostname,
            _siteName,
            _srcPort,
        ];
    }

    public override Tdf CreateNew() => new NameRemapEntry();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NameRemapEntry";
    public override string GetFullClassName() => "Blaze::Redirector::NameRemapEntry";

    public ushort DstPort
    {
        get => _dstPort.Value;
        set => _dstPort.Value = value;
    }

    public uint ServiceId
    {
        get => _serviceId.Value;
        set => _serviceId.Value = value;
    }

    public string Hostname
    {
        get => _hostname.Value;
        set => _hostname.Value = value;
    }

    public string SiteName
    {
        get => _siteName.Value;
        set => _siteName.Value = value;
    }

    public ushort SrcPort
    {
        get => _srcPort.Value;
        set => _srcPort.Value = value;
    }

}

