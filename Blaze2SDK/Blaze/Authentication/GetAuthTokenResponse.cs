using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Authentication;

public class GetAuthTokenResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AuthToken", "mAuthToken", 0x875D2800, TdfType.String, 0, true), // AUTH
    ];
    private ITdfMember[] __members;

    private TdfString _authToken = new(__typeInfos[0]);

    public GetAuthTokenResponse()
    {
        __members = [
            _authToken,
        ];
    }

    public override Tdf CreateNew() => new GetAuthTokenResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetAuthTokenResponse";
    public override string GetFullClassName() => "Blaze::Authentication::GetAuthTokenResponse";

    public string AuthToken
    {
        get => _authToken.Value;
        set => _authToken.Value = value;
    }

}

