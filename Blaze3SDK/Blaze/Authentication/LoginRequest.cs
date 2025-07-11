using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Authentication;

public class LoginRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("DeviceId", "mDeviceId", 0x936A6400, TdfType.UInt64, 0, true), // DVID
        new TdfMemberInfo("Email", "mEmail", 0xB61A6C00, TdfType.String, 1, true), // MAIL
        new TdfMemberInfo("Password", "mPassword", 0xC21CF300, TdfType.String, 2, true), // PASS
        new TdfMemberInfo("Token", "mToken", 0xD2FAEE00, TdfType.String, 3, true), // TOKN
        new TdfMemberInfo("TokenType", "mTokenType", 0xD39C2500, TdfType.Enum, 4, true), // TYPE
    ];
    private ITdfMember[] __members;

    private TdfUInt64 _deviceId = new(__typeInfos[0]);
    private TdfString _email = new(__typeInfos[1]);
    private TdfString _password = new(__typeInfos[2]);
    private TdfString _token = new(__typeInfos[3]);
    private TdfEnum<Blaze3SDK.Blaze.Authentication.TOKENTYPE> _tokenType = new(__typeInfos[4]);

    public LoginRequest()
    {
        __members = [
            _deviceId,
            _email,
            _password,
            _token,
            _tokenType,
        ];
    }

    public override Tdf CreateNew() => new LoginRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "LoginRequest";
    public override string GetFullClassName() => "Blaze::Authentication::LoginRequest";

    public ulong DeviceId
    {
        get => _deviceId.Value;
        set => _deviceId.Value = value;
    }

    public string Email
    {
        get => _email.Value;
        set => _email.Value = value;
    }

    public string Password
    {
        get => _password.Value;
        set => _password.Value = value;
    }

    public string Token
    {
        get => _token.Value;
        set => _token.Value = value;
    }

    public Blaze3SDK.Blaze.Authentication.TOKENTYPE TokenType
    {
        get => _tokenType.Value;
        set => _tokenType.Value = value;
    }

}

