using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Authentication;

public class OriginLoginRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AuthToken", "mAuthToken", 0x875D2800, TdfType.String, 0, true), // AUTH
        new TdfMemberInfo("TokenType", "mTokenType", 0xD39C2500, TdfType.Enum, 1, true), // TYPE
    ];
    private ITdfMember[] __members;

    private TdfString _authToken = new(__typeInfos[0]);
    private TdfEnum<Blaze3SDK.Blaze.Authentication.TOKENTYPE> _tokenType = new(__typeInfos[1]);

    public OriginLoginRequest()
    {
        __members = [
            _authToken,
            _tokenType,
        ];
    }

    public override Tdf CreateNew() => new OriginLoginRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "OriginLoginRequest";
    public override string GetFullClassName() => "Blaze::Authentication::OriginLoginRequest";

    public string AuthToken
    {
        get => _authToken.Value;
        set => _authToken.Value = value;
    }

    public Blaze3SDK.Blaze.Authentication.TOKENTYPE TokenType
    {
        get => _tokenType.Value;
        set => _tokenType.Value = value;
    }

}

