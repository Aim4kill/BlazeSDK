using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Authentication;

public class SilentLoginRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AuthToken", "mAuthToken", 0x875D2800, TdfType.String, 0, true), // AUTH
        new TdfMemberInfo("PersonaId", "mPersonaId", 0xC2990000, TdfType.Int64, 1, true), // PID
        new TdfMemberInfo("TokenType", "mTokenType", 0xD39C2500, TdfType.Enum, 2, true), // TYPE
    ];
    private ITdfMember[] __members;

    private TdfString _authToken = new(__typeInfos[0]);
    private TdfInt64 _personaId = new(__typeInfos[1]);
    private TdfEnum<Blaze2SDK.Blaze.Authentication.TOKENTYPE> _tokenType = new(__typeInfos[2]);

    public SilentLoginRequest()
    {
        __members = [
            _authToken,
            _personaId,
            _tokenType,
        ];
    }

    public override Tdf CreateNew() => new SilentLoginRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "SilentLoginRequest";
    public override string GetFullClassName() => "Blaze::Authentication::SilentLoginRequest";

    public string AuthToken
    {
        get => _authToken.Value;
        set => _authToken.Value = value;
    }

    public long PersonaId
    {
        get => _personaId.Value;
        set => _personaId.Value = value;
    }

    public Blaze2SDK.Blaze.Authentication.TOKENTYPE TokenType
    {
        get => _tokenType.Value;
        set => _tokenType.Value = value;
    }

}

