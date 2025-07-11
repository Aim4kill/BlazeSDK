using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Authentication;

public class LoginResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("LegalDocHost", "mLegalDocHost", 0xB24A3400, TdfType.String, 0, true), // LDHT
        new TdfMemberInfo("NeedsLegalDoc", "mNeedsLegalDoc", 0xBB4BF300, TdfType.Bool, 1, true), // NTOS
        new TdfMemberInfo("PCLoginToken", "mPCLoginToken", 0xC23D2B00, TdfType.String, 2, true), // PCTK
        new TdfMemberInfo("PersonaDetailsList", "mPersonaDetailsList", 0xC2CCF400, TdfType.List, 3, true), // PLST
        new TdfMemberInfo("PrivacyPolicyUri", "mPrivacyPolicyUri", 0xC32A7600, TdfType.String, 4, true), // PRIV
        new TdfMemberInfo("SessionKey", "mSessionKey", 0xCEB97900, TdfType.String, 5, true), // SKEY
        new TdfMemberInfo("IsOfLegalContactAge", "mIsOfLegalContactAge", 0xCF086D00, TdfType.Bool, 6, true), // SPAM
        new TdfMemberInfo("TosHost", "mTosHost", 0xD28CF400, TdfType.String, 7, true), // THST
        new TdfMemberInfo("TermsOfServiceUri", "mTermsOfServiceUri", 0xD33D6900, TdfType.String, 8, true), // TSUI
        new TdfMemberInfo("TosUri", "mTosUri", 0xD35CA900, TdfType.String, 9, true), // TURI
        new TdfMemberInfo("UserId", "mUserId", 0xD6990000, TdfType.Int64, 10, true), // UID
    ];
    private ITdfMember[] __members;

    private TdfString _legalDocHost = new(__typeInfos[0]);
    private TdfBool _needsLegalDoc = new(__typeInfos[1]);
    private TdfString _pCLoginToken = new(__typeInfos[2]);
    private TdfList<Blaze3SDK.Blaze.Authentication.PersonaDetails> _personaDetailsList = new(__typeInfos[3]);
    private TdfString _privacyPolicyUri = new(__typeInfos[4]);
    private TdfString _sessionKey = new(__typeInfos[5]);
    private TdfBool _isOfLegalContactAge = new(__typeInfos[6]);
    private TdfString _tosHost = new(__typeInfos[7]);
    private TdfString _termsOfServiceUri = new(__typeInfos[8]);
    private TdfString _tosUri = new(__typeInfos[9]);
    private TdfInt64 _userId = new(__typeInfos[10]);

    public LoginResponse()
    {
        __members = [
            _legalDocHost,
            _needsLegalDoc,
            _pCLoginToken,
            _personaDetailsList,
            _privacyPolicyUri,
            _sessionKey,
            _isOfLegalContactAge,
            _tosHost,
            _termsOfServiceUri,
            _tosUri,
            _userId,
        ];
    }

    public override Tdf CreateNew() => new LoginResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "LoginResponse";
    public override string GetFullClassName() => "Blaze::Authentication::LoginResponse";

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

    public string PCLoginToken
    {
        get => _pCLoginToken.Value;
        set => _pCLoginToken.Value = value;
    }

    public IList<Blaze3SDK.Blaze.Authentication.PersonaDetails> PersonaDetailsList
    {
        get => _personaDetailsList.Value;
        set => _personaDetailsList.Value = value;
    }

    public string PrivacyPolicyUri
    {
        get => _privacyPolicyUri.Value;
        set => _privacyPolicyUri.Value = value;
    }

    public string SessionKey
    {
        get => _sessionKey.Value;
        set => _sessionKey.Value = value;
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

    public long UserId
    {
        get => _userId.Value;
        set => _userId.Value = value;
    }

}

