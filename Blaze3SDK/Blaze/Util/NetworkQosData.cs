using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Util;

public class NetworkQosData : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("DownstreamBitsPerSecond", "mDownstreamBitsPerSecond", 0x922C3300, TdfType.UInt32, 0, true), // DBPS
        new TdfMemberInfo("NatType", "mNatType", 0xBA1D3400, TdfType.Enum, 1, true), // NATT
        new TdfMemberInfo("UpstreamBitsPerSecond", "mUpstreamBitsPerSecond", 0xD62C3300, TdfType.UInt32, 2, true), // UBPS
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _downstreamBitsPerSecond = new(__typeInfos[0]);
    private TdfEnum<Blaze3SDK.Blaze.Util.NatType> _natType = new(__typeInfos[1]);
    private TdfUInt32 _upstreamBitsPerSecond = new(__typeInfos[2]);

    public NetworkQosData()
    {
        __members = [
            _downstreamBitsPerSecond,
            _natType,
            _upstreamBitsPerSecond,
        ];
    }

    public override Tdf CreateNew() => new NetworkQosData();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NetworkQosData";
    public override string GetFullClassName() => "Blaze::Util::NetworkQosData";

    public uint DownstreamBitsPerSecond
    {
        get => _downstreamBitsPerSecond.Value;
        set => _downstreamBitsPerSecond.Value = value;
    }

    public Blaze3SDK.Blaze.Util.NatType NatType
    {
        get => _natType.Value;
        set => _natType.Value = value;
    }

    public uint UpstreamBitsPerSecond
    {
        get => _upstreamBitsPerSecond.Value;
        set => _upstreamBitsPerSecond.Value = value;
    }

}

