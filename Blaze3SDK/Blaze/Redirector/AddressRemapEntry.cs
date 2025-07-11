using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Redirector;

public class AddressRemapEntry : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("DstPort", "mDstPort", 0x930CB400, TdfType.UInt16, 0, true), // DPRT
        new TdfMemberInfo("NetMask", "mNetMask", 0xB61CEB00, TdfType.UInt32, 1, true), // MASK
        new TdfMemberInfo("ServiceId", "mServiceId", 0xCE990000, TdfType.UInt32, 2, true), // SID
        new TdfMemberInfo("SrcIp", "mSrcIp", 0xCE9C0000, TdfType.UInt32, 3, true), // SIP
        new TdfMemberInfo("SrcPort", "mSrcPort", 0xCF0CB400, TdfType.UInt16, 4, true), // SPRT
    ];
    private ITdfMember[] __members;

    private TdfUInt16 _dstPort = new(__typeInfos[0]);
    private TdfUInt32 _netMask = new(__typeInfos[1]);
    private TdfUInt32 _serviceId = new(__typeInfos[2]);
    private TdfUInt32 _srcIp = new(__typeInfos[3]);
    private TdfUInt16 _srcPort = new(__typeInfos[4]);

    public AddressRemapEntry()
    {
        __members = [
            _dstPort,
            _netMask,
            _serviceId,
            _srcIp,
            _srcPort,
        ];
    }

    public override Tdf CreateNew() => new AddressRemapEntry();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "AddressRemapEntry";
    public override string GetFullClassName() => "Blaze::Redirector::AddressRemapEntry";

    public ushort DstPort
    {
        get => _dstPort.Value;
        set => _dstPort.Value = value;
    }

    public uint NetMask
    {
        get => _netMask.Value;
        set => _netMask.Value = value;
    }

    public uint ServiceId
    {
        get => _serviceId.Value;
        set => _serviceId.Value = value;
    }

    public uint SrcIp
    {
        get => _srcIp.Value;
        set => _srcIp.Value = value;
    }

    public ushort SrcPort
    {
        get => _srcPort.Value;
        set => _srcPort.Value = value;
    }

}

