using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Authentication;

public class LoginPersonaRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("PersonaName", "mPersonaName", 0xC2E86D00, TdfType.String, 0, true), // PNAM
    ];
    private ITdfMember[] __members;

    private TdfString _personaName = new(__typeInfos[0]);

    public LoginPersonaRequest()
    {
        __members = [
            _personaName,
        ];
    }

    public override Tdf CreateNew() => new LoginPersonaRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "LoginPersonaRequest";
    public override string GetFullClassName() => "Blaze::Authentication::LoginPersonaRequest";

    public string PersonaName
    {
        get => _personaName.Value;
        set => _personaName.Value = value;
    }

}

