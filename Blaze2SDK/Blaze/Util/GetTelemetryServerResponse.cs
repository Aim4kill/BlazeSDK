using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Util;

public class GetTelemetryServerResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Address", "mAddress", 0x864CB300, TdfType.String, 0, true), // ADRS
        new TdfMemberInfo("IsAnonymous", "mIsAnonymous", 0x86EBEE00, TdfType.Bool, 1, true), // ANON
        new TdfMemberInfo("Disable", "mDisable", 0x929CE100, TdfType.String, 2, true), // DISA
        new TdfMemberInfo("Filter", "mFilter", 0x9A9B3400, TdfType.String, 3, true), // FILT
        new TdfMemberInfo("Locale", "mLocale", 0xB2F8C000, TdfType.UInt32, 4, true), // LOC
        new TdfMemberInfo("NoToggleOk", "mNoToggleOk", 0xBAFBEB00, TdfType.String, 5, true), // NOOK
        new TdfMemberInfo("Port", "mPort", 0xC2FCB400, TdfType.UInt32, 6, true), // PORT
        new TdfMemberInfo("SendDelay", "mSendDelay", 0xCE4B3900, TdfType.UInt32, 7, true), // SDLY
        new TdfMemberInfo("Key", "mKey", 0xCEB97900, TdfType.String, 8, true), // SKEY
        new TdfMemberInfo("SendPercentage", "mSendPercentage", 0xCF08F400, TdfType.UInt32, 9, true), // SPCT
    ];
    private ITdfMember[] __members;

    private TdfString _address = new(__typeInfos[0]);
    private TdfBool _isAnonymous = new(__typeInfos[1]);
    private TdfString _disable = new(__typeInfos[2]);
    private TdfString _filter = new(__typeInfos[3]);
    private TdfUInt32 _locale = new(__typeInfos[4]);
    private TdfString _noToggleOk = new(__typeInfos[5]);
    private TdfUInt32 _port = new(__typeInfos[6]);
    private TdfUInt32 _sendDelay = new(__typeInfos[7]);
    private TdfString _key = new(__typeInfos[8]);
    private TdfUInt32 _sendPercentage = new(__typeInfos[9]);

    public GetTelemetryServerResponse()
    {
        __members = [
            _address,
            _isAnonymous,
            _disable,
            _filter,
            _locale,
            _noToggleOk,
            _port,
            _sendDelay,
            _key,
            _sendPercentage,
        ];
    }

    public override Tdf CreateNew() => new GetTelemetryServerResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetTelemetryServerResponse";
    public override string GetFullClassName() => "Blaze::Util::GetTelemetryServerResponse";

    public string Address
    {
        get => _address.Value;
        set => _address.Value = value;
    }

    public bool IsAnonymous
    {
        get => _isAnonymous.Value;
        set => _isAnonymous.Value = value;
    }

    public string Disable
    {
        get => _disable.Value;
        set => _disable.Value = value;
    }

    public string Filter
    {
        get => _filter.Value;
        set => _filter.Value = value;
    }

    public uint Locale
    {
        get => _locale.Value;
        set => _locale.Value = value;
    }

    public string NoToggleOk
    {
        get => _noToggleOk.Value;
        set => _noToggleOk.Value = value;
    }

    public uint Port
    {
        get => _port.Value;
        set => _port.Value = value;
    }

    public uint SendDelay
    {
        get => _sendDelay.Value;
        set => _sendDelay.Value = value;
    }

    public string Key
    {
        get => _key.Value;
        set => _key.Value = value;
    }

    public uint SendPercentage
    {
        get => _sendPercentage.Value;
        set => _sendPercentage.Value = value;
    }

}

