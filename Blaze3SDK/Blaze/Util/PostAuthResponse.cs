using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Util;

public class PostAuthResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("PssConfig", "mPssConfig", 0xC33CC000, TdfType.Struct, 0, true), // PSS
        new TdfMemberInfo("TelemetryServer", "mTelemetryServer", 0xD25B2500, TdfType.Struct, 1, true), // TELE
        new TdfMemberInfo("TickerServer", "mTickerServer", 0xD298EB00, TdfType.Struct, 2, true), // TICK
        new TdfMemberInfo("UserOptions", "mUserOptions", 0xD72BF000, TdfType.Struct, 3, true), // UROP
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze3SDK.Blaze.Util.PssConfig?> _pssConfig = new(__typeInfos[0]);
    private TdfStruct<Blaze3SDK.Blaze.Util.GetTelemetryServerResponse?> _telemetryServer = new(__typeInfos[1]);
    private TdfStruct<Blaze3SDK.Blaze.Util.GetTickerServerResponse?> _tickerServer = new(__typeInfos[2]);
    private TdfStruct<Blaze3SDK.Blaze.Util.UserOptions?> _userOptions = new(__typeInfos[3]);

    public PostAuthResponse()
    {
        __members = [
            _pssConfig,
            _telemetryServer,
            _tickerServer,
            _userOptions,
        ];
    }

    public override Tdf CreateNew() => new PostAuthResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PostAuthResponse";
    public override string GetFullClassName() => "Blaze::Util::PostAuthResponse";

    public Blaze3SDK.Blaze.Util.PssConfig? PssConfig
    {
        get => _pssConfig.Value;
        set => _pssConfig.Value = value;
    }

    public Blaze3SDK.Blaze.Util.GetTelemetryServerResponse? TelemetryServer
    {
        get => _telemetryServer.Value;
        set => _telemetryServer.Value = value;
    }

    public Blaze3SDK.Blaze.Util.GetTickerServerResponse? TickerServer
    {
        get => _tickerServer.Value;
        set => _tickerServer.Value = value;
    }

    public Blaze3SDK.Blaze.Util.UserOptions? UserOptions
    {
        get => _userOptions.Value;
        set => _userOptions.Value = value;
    }

}

