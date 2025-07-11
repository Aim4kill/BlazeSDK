using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Authentication;

public class ConsoleLoginResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CanAgeUp", "mCanAgeUp", 0x867D7000, TdfType.Bool, 0, true), // AGUP
        new TdfMemberInfo("LegalDocHost", "mLegalDocHost", 0xB24A3400, TdfType.String, 1, true), // LDHT
        new TdfMemberInfo("NeedsLegalDoc", "mNeedsLegalDoc", 0xBB4BF300, TdfType.Bool, 2, true), // NTOS
        new TdfMemberInfo("PrivacyPolicyUri", "mPrivacyPolicyUri", 0xC32A7600, TdfType.String, 3, true), // PRIV
        new TdfMemberInfo("SessionInfo", "mSessionInfo", 0xCE5CF300, TdfType.Struct, 4, true), // SESS
        new TdfMemberInfo("IsOfLegalContactAge", "mIsOfLegalContactAge", 0xCF086D00, TdfType.Bool, 5, true), // SPAM
        new TdfMemberInfo("TosHost", "mTosHost", 0xD28CF400, TdfType.String, 6, true), // THST
        new TdfMemberInfo("TermsOfServiceUri", "mTermsOfServiceUri", 0xD33D6900, TdfType.String, 7, true), // TSUI
        new TdfMemberInfo("TosUri", "mTosUri", 0xD35CA900, TdfType.String, 8, true), // TURI
    ];
    private ITdfMember[] __members;

    private TdfBool _canAgeUp = new(__typeInfos[0]);
    private TdfString _legalDocHost = new(__typeInfos[1]);
    private TdfBool _needsLegalDoc = new(__typeInfos[2]);
    private TdfString _privacyPolicyUri = new(__typeInfos[3]);
    private TdfStruct<Blaze3SDK.Blaze.Authentication.SessionInfo?> _sessionInfo = new(__typeInfos[4]);
    private TdfBool _isOfLegalContactAge = new(__typeInfos[5]);
    private TdfString _tosHost = new(__typeInfos[6]);
    private TdfString _termsOfServiceUri = new(__typeInfos[7]);
    private TdfString _tosUri = new(__typeInfos[8]);

    public ConsoleLoginResponse()
    {
        __members = [
            _canAgeUp,
            _legalDocHost,
            _needsLegalDoc,
            _privacyPolicyUri,
            _sessionInfo,
            _isOfLegalContactAge,
            _tosHost,
            _termsOfServiceUri,
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

    public string LegalDocHost
    {
        get => _legalDocHost.Value;
        set => _legalDocHost.Value = value;
    }

    public bool NeedsLegalDoc
    {
        get => _needsLegalDoc.Value;
        set => _needsLegalDoc.Value = value;
    }

    public string PrivacyPolicyUri
    {
        get => _privacyPolicyUri.Value;
        set => _privacyPolicyUri.Value = value;
    }

    public Blaze3SDK.Blaze.Authentication.SessionInfo? SessionInfo
    {
        get => _sessionInfo.Value;
        set => _sessionInfo.Value = value;
    }

    public bool IsOfLegalContactAge
    {
        get => _isOfLegalContactAge.Value;
        set => _isOfLegalContactAge.Value = value;
    }

    public string TosHost
    {
        get => _tosHost.Value;
        set => _tosHost.Value = value;
    }

    public string TermsOfServiceUri
    {
        get => _termsOfServiceUri.Value;
        set => _termsOfServiceUri.Value = value;
    }

    public string TosUri
    {
        get => _tosUri.Value;
        set => _tosUri.Value = value;
    }

}

