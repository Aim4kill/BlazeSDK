using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Authentication;

public class UserDetails : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Email", "mEmail", 0xB61A6C00, TdfType.String, 0, true), // MAIL
        new TdfMemberInfo("PersonaDetailsList", "mPersonaDetailsList", 0xC2CCF400, TdfType.List, 1, true), // PLST
    ];
    private ITdfMember[] __members;

    private TdfString _email = new(__typeInfos[0]);
    private TdfList<Blaze3SDK.Blaze.Authentication.PersonaDetails> _personaDetailsList = new(__typeInfos[1]);

    public UserDetails()
    {
        __members = [
            _email,
            _personaDetailsList,
        ];
    }

    public override Tdf CreateNew() => new UserDetails();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UserDetails";
    public override string GetFullClassName() => "Blaze::Authentication::UserDetails";

    public string Email
    {
        get => _email.Value;
        set => _email.Value = value;
    }

    public IList<Blaze3SDK.Blaze.Authentication.PersonaDetails> PersonaDetailsList
    {
        get => _personaDetailsList.Value;
        set => _personaDetailsList.Value = value;
    }

}

