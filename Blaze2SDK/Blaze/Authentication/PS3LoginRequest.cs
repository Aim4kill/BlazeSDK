using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Authentication;

public class PS3LoginRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Email", "mEmail", 0xB61A6C00, TdfType.String, 0, true), // MAIL
        new TdfMemberInfo("PS3Ticket", "mPS3Ticket", 0xD23AF400, TdfType.Blob, 1, true), // TCKT
    ];
    private ITdfMember[] __members;

    private TdfString _email = new(__typeInfos[0]);
    private TdfBlob _pS3Ticket = new(__typeInfos[1]);

    public PS3LoginRequest()
    {
        __members = [
            _email,
            _pS3Ticket,
        ];
    }

    public override Tdf CreateNew() => new PS3LoginRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PS3LoginRequest";
    public override string GetFullClassName() => "Blaze::Authentication::PS3LoginRequest";

    public string Email
    {
        get => _email.Value;
        set => _email.Value = value;
    }

    public byte[] PS3Ticket
    {
        get => _pS3Ticket.Value;
        set => _pS3Ticket.Value = value;
    }

}

