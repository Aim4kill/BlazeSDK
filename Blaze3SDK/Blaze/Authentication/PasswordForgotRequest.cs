using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Authentication;

public class PasswordForgotRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Email", "mEmail", 0xB61A6C00, TdfType.String, 0, true), // MAIL
    ];
    private ITdfMember[] __members;

    private TdfString _email = new(__typeInfos[0]);

    public PasswordForgotRequest()
    {
        __members = [
            _email,
        ];
    }

    public override Tdf CreateNew() => new PasswordForgotRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PasswordForgotRequest";
    public override string GetFullClassName() => "Blaze::Authentication::PasswordForgotRequest";

    public string Email
    {
        get => _email.Value;
        set => _email.Value = value;
    }

}

