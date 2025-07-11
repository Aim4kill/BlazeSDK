using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Authentication;

public class ConsoleLoginResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CanAgeUp", "mCanAgeUp", 0x867D7000, TdfType.Bool, 0, true), // AGUP
        new TdfMemberInfo("PrivacyPolicyUri", "mPrivacyPolicyUri", 0xC32A7600, TdfType.String, 1, true), // PRIV
        new TdfMemberInfo("SessionInfo", "mSessionInfo", 0xCE5CF300, TdfType.Struct, 2, true), // SESS
        new TdfMemberInfo("IsSpammable", "mIsSpammable", 0xCF086D00, TdfType.Bool, 3, true), // SPAM
        new TdfMemberInfo("TosHost", "mTosHost", 0xD28CF400, TdfType.String, 4, true), // THST
        new TdfMemberInfo("TosUri", "mTosUri", 0xD35CA900, TdfType.String, 5, true), // TURI
    ];
    private ITdfMember[] __members;

    private TdfBool _canAgeUp = new(__typeInfos[0]);
    private TdfString _privacyPolicyUri = new(__typeInfos[1]);
    private TdfStruct<Blaze2SDK.Blaze.Authentication.SessionInfo?> _sessionInfo = new(__typeInfos[2]);
    private TdfBool _isSpammable = new(__typeInfos[3]);
    private TdfString _tosHost = new(__typeInfos[4]);
    private TdfString _tosUri = new(__typeInfos[5]);

    public ConsoleLoginResponse()
    {
        __members = [
            _canAgeUp,
            _privacyPolicyUri,
            _sessionInfo,
            _isSpammable,
            _tosHost,
            _tosUri,
        ];
    }

    public override Tdf CreateNew() => new ConsoleLoginResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ConsoleLoginResponse";
    public override string GetFullClassName() => "Blaze::Authentication::ConsoleLoginResponse";

    public bool CanAgeUp
    {
        get => _canAgeUp.Value;
        set => _canAgeUp.Value = value;
    }

    public string PrivacyPolicyUri
    {
        get => _privacyPolicyUri.Value;
        set => _privacyPolicyUri.Value = value;
    }

    public Blaze2SDK.Blaze.Authentication.SessionInfo? SessionInfo
    {
        get => _sessionInfo.Value;
        set => _sessionInfo.Value = value;
    }

    public bool IsSpammable
    {
        get => _isSpammable.Value;
        set => _isSpammable.Value = value;
    }

    public string TosHost
    {
        get => _tosHost.Value;
        set => _tosHost.Value = value;
    }

    public string TosUri
    {
        get => _tosUri.Value;
        set => _tosUri.Value = value;
    }

}

