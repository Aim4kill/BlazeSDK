using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze;

public class IpPairAddress : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ExternalAddress", "ExternalAddress", 0x978A7000, TdfType.Struct, 0, true), // EXIP
        new TdfMemberInfo("InternalAddress", "InternalAddress", 0xA6EA7000, TdfType.Struct, 1, true), // INIP
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze2SDK.Blaze.IpAddress?> _externalAddress = new(__typeInfos[0]);
    private TdfStruct<Blaze2SDK.Blaze.IpAddress?> _internalAddress = new(__typeInfos[1]);

    public IpPairAddress()
    {
        __members = [
            _externalAddress,
            _internalAddress,
        ];
    }

    public override Tdf CreateNew() => new IpPairAddress();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "IpPairAddress";
    public override string GetFullClassName() => "Blaze::IpPairAddress";

    public Blaze2SDK.Blaze.IpAddress? ExternalAddress
    {
        get => _externalAddress.Value;
        set => _externalAddress.Value = value;
    }

    public Blaze2SDK.Blaze.IpAddress? InternalAddress
    {
        get => _internalAddress.Value;
        set => _internalAddress.Value = value;
    }

}

