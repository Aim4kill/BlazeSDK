using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze;

public class NetworkInfo : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Address", "mAddress", 0x86493200, TdfType.Union, 0, true), // ADDR
        new TdfMemberInfo("PingSiteLatencyByAliasMap", "mPingSiteLatencyByAliasMap", 0xBACB7000, TdfType.Map, 1, true), // NLMP
        new TdfMemberInfo("QosData", "mQosData", 0xBB1BF300, TdfType.Struct, 2, true), // NQOS
    ];
    private ITdfMember[] __members;

    private TdfUnion<Blaze3SDK.Blaze.NetworkAddress> _address = new(__typeInfos[0]);
    private TdfMap<string, int> _pingSiteLatencyByAliasMap = new(__typeInfos[1]);
    private TdfStruct<Blaze3SDK.Blaze.Util.NetworkQosData?> _qosData = new(__typeInfos[2]);

    public NetworkInfo()
    {
        __members = [
            _address,
            _pingSiteLatencyByAliasMap,
            _qosData,
        ];
    }

    public override Tdf CreateNew() => new NetworkInfo();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NetworkInfo";
    public override string GetFullClassName() => "Blaze::NetworkInfo";

    public Blaze3SDK.Blaze.NetworkAddress Address
    {
        get => _address.Value;
        set => _address.Value = value;
    }

    public IDictionary<string, int> PingSiteLatencyByAliasMap
    {
        get => _pingSiteLatencyByAliasMap.Value;
        set => _pingSiteLatencyByAliasMap.Value = value;
    }

    public Blaze3SDK.Blaze.Util.NetworkQosData? QosData
    {
        get => _qosData.Value;
        set => _qosData.Value = value;
    }

}

