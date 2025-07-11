using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze;

public class QosConfigInfo : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("BandwidthPingSiteInfo", "mBandwidthPingSiteInfo", 0x8B7C3300, TdfType.Struct, 0, true), // BWPS
        new TdfMemberInfo("NumLatencyProbes", "mNumLatencyProbes", 0xB2EC0000, TdfType.UInt16, 1, true), // LNP
        new TdfMemberInfo("PingSiteInfoByAliasMap", "mPingSiteInfoByAliasMap", 0xB34C3300, TdfType.Map, 2, true), // LTPS
        new TdfMemberInfo("ServiceId", "mServiceId", 0xCF6A6400, TdfType.UInt32, 3, true), // SVID
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze2SDK.Blaze.QosPingSiteInfo?> _bandwidthPingSiteInfo = new(__typeInfos[0]);
    private TdfUInt16 _numLatencyProbes = new(__typeInfos[1]);
    private TdfMap<string, Blaze2SDK.Blaze.QosPingSiteInfo> _pingSiteInfoByAliasMap = new(__typeInfos[2]);
    private TdfUInt32 _serviceId = new(__typeInfos[3]);

    public QosConfigInfo()
    {
        __members = [
            _bandwidthPingSiteInfo,
            _numLatencyProbes,
            _pingSiteInfoByAliasMap,
            _serviceId,
        ];
    }

    public override Tdf CreateNew() => new QosConfigInfo();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "QosConfigInfo";
    public override string GetFullClassName() => "Blaze::QosConfigInfo";

    public Blaze2SDK.Blaze.QosPingSiteInfo? BandwidthPingSiteInfo
    {
        get => _bandwidthPingSiteInfo.Value;
        set => _bandwidthPingSiteInfo.Value = value;
    }

    public ushort NumLatencyProbes
    {
        get => _numLatencyProbes.Value;
        set => _numLatencyProbes.Value = value;
    }

    public IDictionary<string, Blaze2SDK.Blaze.QosPingSiteInfo> PingSiteInfoByAliasMap
    {
        get => _pingSiteInfoByAliasMap.Value;
        set => _pingSiteInfoByAliasMap.Value = value;
    }

    public uint ServiceId
    {
        get => _serviceId.Value;
        set => _serviceId.Value = value;
    }

}

