using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Authentication;

public class ConsoleCreateAccountRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CreateAccountParameters", "mCreateAccountParameters", 0x8F297100, TdfType.Struct, 0, true), // CREQ
        new TdfMemberInfo("ExtName", "mExtName", 0xC25CB300, TdfType.String, 1, true), // PERS
        new TdfMemberInfo("TicketBlob", "mTicketBlob", 0xD298EB00, TdfType.Blob, 2, true), // TICK
        new TdfMemberInfo("UserId", "mUserId", 0xD6990000, TdfType.Int64, 3, true), // UID
        new TdfMemberInfo("ExtId", "mExtId", 0xE3296600, TdfType.UInt64, 4, true), // XREF
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze3SDK.Blaze.Authentication.CreateAccountParameters?> _createAccountParameters = new(__typeInfos[0]);
    private TdfString _extName = new(__typeInfos[1]);
    private TdfBlob _ticketBlob = new(__typeInfos[2]);
    private TdfInt64 _userId = new(__typeInfos[3]);
    private TdfUInt64 _extId = new(__typeInfos[4]);

    public ConsoleCreateAccountRequest()
    {
        __members = [
            _createAccountParameters,
            _extName,
            _ticketBlob,
            _userId,
            _extId,
        ];
    }

    public override Tdf CreateNew() => new ConsoleCreateAccountRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ConsoleCreateAccountRequest";
    public override string GetFullClassName() => "Blaze::Authentication::ConsoleCreateAccountRequest";

    public Blaze3SDK.Blaze.Authentication.CreateAccountParameters? CreateAccountParameters
    {
        get => _createAccountParameters.Value;
        set => _createAccountParameters.Value = value;
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

    public long UserId
    {
        get => _userId.Value;
        set => _userId.Value = value;
    }

    public ulong ExtId
    {
        get => _extId.Value;
        set => _extId.Value = value;
    }

}

