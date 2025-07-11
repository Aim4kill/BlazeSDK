using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Util;

public class PingResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ServerTime", "mServerTime", 0xCF4A6D00, TdfType.UInt32, 0, true), // STIM
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _serverTime = new(__typeInfos[0]);

    public PingResponse()
    {
        __members = [
            _serverTime,
        ];
    }

    public override Tdf CreateNew() => new PingResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PingResponse";
    public override string GetFullClassName() => "Blaze::Util::PingResponse";

    public uint ServerTime
    {
        get => _serverTime.Value;
        set => _serverTime.Value = value;
    }

}

