using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Authentication;

public class ConsoleAssociateAccountRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Email", "mEmail", 0xB61A6C00, TdfType.String, 0, true), // MAIL
        new TdfMemberInfo("Password", "mPassword", 0xC21CF300, TdfType.String, 1, true), // PASS
        new TdfMemberInfo("ExtName", "mExtName", 0xC25CB300, TdfType.String, 2, true), // PERS
        new TdfMemberInfo("TicketBlob", "mTicketBlob", 0xD298EB00, TdfType.Blob, 3, true), // TICK
        new TdfMemberInfo("ExtId", "mExtId", 0xE3296600, TdfType.UInt64, 4, true), // XREF
    ];
    private ITdfMember[] __members;

    private TdfString _email = new(__typeInfos[0]);
    private TdfString _password = new(__typeInfos[1]);
    private TdfString _extName = new(__typeInfos[2]);
    private TdfBlob _ticketBlob = new(__typeInfos[3]);
    private TdfUInt64 _extId = new(__typeInfos[4]);

    public ConsoleAssociateAccountRequest()
    {
        __members = [
            _email,
            _password,
            _extName,
            _ticketBlob,
            _extId,
        ];
    }

    public override Tdf CreateNew() => new ConsoleAssociateAccountRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ConsoleAssociateAccountRequest";
    public override string GetFullClassName() => "Blaze::Authentication::ConsoleAssociateAccountRequest";

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

    public string ExtName
    {
        get => _extName.Value;
        set => _extName.Value = value;
    }

    public byte[] TicketBlob
    {
        get => _ticketBlob.Value;
        set => _ticketBlob.Value = value;
    }

    public ulong ExtId
    {
        get => _extId.Value;
        set => _extId.Value = value;
    }

}

