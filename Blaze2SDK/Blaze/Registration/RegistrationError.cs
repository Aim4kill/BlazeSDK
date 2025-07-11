using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Registration;

public class RegistrationError : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Message", "mMessage", 0xB739C000, TdfType.String, 0, true), // MSG
    ];
    private ITdfMember[] __members;

    private TdfString _message = new(__typeInfos[0]);

    public RegistrationError()
    {
        __members = [
            _message,
        ];
    }

    public override Tdf CreateNew() => new RegistrationError();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "RegistrationError";
    public override string GetFullClassName() => "Blaze::Registration::RegistrationError";

    public string Message
    {
        get => _message.Value;
        set => _message.Value = value;
    }

}

