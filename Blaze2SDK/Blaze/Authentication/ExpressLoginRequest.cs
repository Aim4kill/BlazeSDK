using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Authentication;

public class ExpressLoginRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Email", "mEmail", 0xB61A6C00, TdfType.String, 0, true), // MAIL
        new TdfMemberInfo("Password", "mPassword", 0xC21CF300, TdfType.String, 1, true), // PASS
        new TdfMemberInfo("PersonaName", "mPersonaName", 0xC2E86D00, TdfType.String, 2, true), // PNAM
    ];
    private ITdfMember[] __members;

    private TdfString _email = new(__typeInfos[0]);
    private TdfString _password = new(__typeInfos[1]);
    private TdfString _personaName = new(__typeInfos[2]);

    public ExpressLoginRequest()
    {
        __members = [
            _email,
            _password,
            _personaName,
        ];
    }

    public override Tdf CreateNew() => new ExpressLoginRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ExpressLoginRequest";
    public override string GetFullClassName() => "Blaze::Authentication::ExpressLoginRequest";

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

    public string PersonaName
    {
        get => _personaName.Value;
        set => _personaName.Value = value;
    }

}

