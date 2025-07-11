using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Authentication;

public class LoginResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("PCLoginToken", "mPCLoginToken", 0xC23D2B00, TdfType.String, 0, true), // PCTK
        new TdfMemberInfo("PersonaDetailsList", "mPersonaDetailsList", 0xC2CCF400, TdfType.List, 1, true), // PLST
        new TdfMemberInfo("PrivacyPolicyUri", "mPrivacyPolicyUri", 0xC32A7600, TdfType.String, 2, true), // PRIV
        new TdfMemberInfo("SessionKey", "mSessionKey", 0xCEB97900, TdfType.String, 3, true), // SKEY
        new TdfMemberInfo("IsSpammable", "mIsSpammable", 0xCF086D00, TdfType.Bool, 4, true), // SPAM
        new TdfMemberInfo("TosHost", "mTosHost", 0xD28CF400, TdfType.String, 5, true), // THST
        new TdfMemberInfo("TosUri", "mTosUri", 0xD35CA900, TdfType.String, 6, true), // TURI
        new TdfMemberInfo("UserId", "mUserId", 0xD6990000, TdfType.Int64, 7, true), // UID
    ];
    private ITdfMember[] __members;

    private TdfString _pCLoginToken = new(__typeInfos[0]);
    private TdfList<Blaze2SDK.Blaze.Authentication.PersonaDetails> _personaDetailsList = new(__typeInfos[1]);
    private TdfString _privacyPolicyUri = new(__typeInfos[2]);
    private TdfString _sessionKey = new(__typeInfos[3]);
    private TdfBool _isSpammable = new(__typeInfos[4]);
    private TdfString _tosHost = new(__typeInfos[5]);
    private TdfString _tosUri = new(__typeInfos[6]);
    private TdfInt64 _userId = new(__typeInfos[7]);

    public LoginResponse()
    {
        __members = [
            _pCLoginToken,
            _personaDetailsList,
            _privacyPolicyUri,
            _sessionKey,
            _isSpammable,
            _tosHost,
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

    public string PCLoginToken
    {
        get => _pCLoginToken.Value;
        set => _pCLoginToken.Value = value;
    }

    public IList<Blaze2SDK.Blaze.Authentication.PersonaDetails> PersonaDetailsList
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

    public long UserId
    {
        get => _userId.Value;
        set => _userId.Value = value;
    }

}

