using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Redirector;

public class FirstPartyId : Union
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("PS3Ticket", "mPS3Ticket", 0xDA1B3500, TdfType.Blob, 0, false), // VALU
        new TdfMemberInfo("XboxId", "mXboxId", 0xDA1B3500, TdfType.Struct, 1, false), // VALU
    ];

    private TdfBlob _pS3Ticket = new(__typeInfos[0]);
    private TdfStruct<Blaze3SDK.Blaze.Redirector.XboxId?> _xboxId = new(__typeInfos[1]);

    public override ITdfMember? GetActiveMember()
    {
        return ActiveIndex switch
        {
            0 => _pS3Ticket,
            1 => _xboxId,
            _ => null
        };
    }
    public override Tdf CreateNew() => new FirstPartyId();
    public override string GetClassName() => "FirstPartyId";
    public override string GetFullClassName() => "Blaze::Redirector::FirstPartyId";

    public byte[] PS3Ticket
    {
        get => _pS3Ticket.Value;
        set
        {
            SwitchActiveIndex(0);
            _pS3Ticket.Value = value;
        }
    }

    public Blaze3SDK.Blaze.Redirector.XboxId? XboxId
    {
        get => _xboxId.Value;
        set
        {
            SwitchActiveIndex(1);
            _xboxId.Value = value;
        }
    }

}

