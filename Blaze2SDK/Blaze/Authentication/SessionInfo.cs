using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Authentication;

public class SessionInfo : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("BlazeUserId", "mBlazeUserId", 0x8B5A6400, TdfType.UInt32, 0, true), // BUID
        new TdfMemberInfo("IsFirstLogin", "mIsFirstLogin", 0x9B2CF400, TdfType.Bool, 1, true), // FRST
        new TdfMemberInfo("SessionKey", "mSessionKey", 0xAE5E4000, TdfType.String, 2, true), // KEY
        new TdfMemberInfo("LastLoginDateTime", "mLastLoginDateTime", 0xB2CBE700, TdfType.Int64, 3, true), // LLOG
        new TdfMemberInfo("Email", "mEmail", 0xB61A6C00, TdfType.String, 4, true), // MAIL
        new TdfMemberInfo("PersonaDetails", "mPersonaDetails", 0xC24D2C00, TdfType.Struct, 5, true), // PDTL
        new TdfMemberInfo("UserId", "mUserId", 0xD6990000, TdfType.Int64, 6, true), // UID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _blazeUserId = new(__typeInfos[0]);
    private TdfBool _isFirstLogin = new(__typeInfos[1]);
    private TdfString _sessionKey = new(__typeInfos[2]);
    private TdfInt64 _lastLoginDateTime = new(__typeInfos[3]);
    private TdfString _email = new(__typeInfos[4]);
    private TdfStruct<Blaze2SDK.Blaze.Authentication.PersonaDetails?> _personaDetails = new(__typeInfos[5]);
    private TdfInt64 _userId = new(__typeInfos[6]);

    public SessionInfo()
    {
        __members = [
            _blazeUserId,
            _isFirstLogin,
            _sessionKey,
            _lastLoginDateTime,
            _email,
            _personaDetails,
            _userId,
        ];
    }

    public override Tdf CreateNew() => new SessionInfo();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "SessionInfo";
    public override string GetFullClassName() => "Blaze::Authentication::SessionInfo";

    public uint BlazeUserId
    {
        get => _blazeUserId.Value;
        set => _blazeUserId.Value = value;
    }

    public bool IsFirstLogin
    {
        get => _isFirstLogin.Value;
        set => _isFirstLogin.Value = value;
    }

    public string SessionKey
    {
        get => _sessionKey.Value;
        set => _sessionKey.Value = value;
    }

    public long LastLoginDateTime
    {
        get => _lastLoginDateTime.Value;
        set => _lastLoginDateTime.Value = value;
    }

    public string Email
    {
        get => _email.Value;
        set => _email.Value = value;
    }

    public Blaze2SDK.Blaze.Authentication.PersonaDetails? PersonaDetails
    {
        get => _personaDetails.Value;
        set => _personaDetails.Value = value;
    }

    public long UserId
    {
        get => _userId.Value;
        set => _userId.Value = value;
    }

}

