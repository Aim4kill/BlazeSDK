using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Registration;

public class RegistrationNumusersRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("EventID", "mEventID", 0x976A6400, TdfType.Int32, 0, true), // EVID
    ];
    private ITdfMember[] __members;

    private TdfInt32 _eventID = new(__typeInfos[0]);

    public RegistrationNumusersRequest()
    {
        __members = [
            _eventID,
        ];
    }

    public override Tdf CreateNew() => new RegistrationNumusersRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "RegistrationNumusersRequest";
    public override string GetFullClassName() => "Blaze::Registration::RegistrationNumusersRequest";

    public int EventID
    {
        get => _eventID.Value;
        set => _eventID.Value = value;
    }

}

