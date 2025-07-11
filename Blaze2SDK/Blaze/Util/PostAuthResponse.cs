using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Util;

public class PostAuthResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("TelemetryServer", "mTelemetryServer", 0xD25B2500, TdfType.Struct, 0, true), // TELE
        new TdfMemberInfo("TickerServer", "mTickerServer", 0xD298EB00, TdfType.Struct, 1, true), // TICK
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze2SDK.Blaze.Util.GetTelemetryServerResponse?> _telemetryServer = new(__typeInfos[0]);
    private TdfStruct<Blaze2SDK.Blaze.Util.GetTickerServerResponse?> _tickerServer = new(__typeInfos[1]);

    public PostAuthResponse()
    {
        __members = [
            _telemetryServer,
            _tickerServer,
        ];
    }

    public override Tdf CreateNew() => new PostAuthResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PostAuthResponse";
    public override string GetFullClassName() => "Blaze::Util::PostAuthResponse";

    public Blaze2SDK.Blaze.Util.GetTelemetryServerResponse? TelemetryServer
    {
        get => _telemetryServer.Value;
        set => _telemetryServer.Value = value;
    }

    public Blaze2SDK.Blaze.Util.GetTickerServerResponse? TickerServer
    {
        get => _tickerServer.Value;
        set => _tickerServer.Value = value;
    }

}

