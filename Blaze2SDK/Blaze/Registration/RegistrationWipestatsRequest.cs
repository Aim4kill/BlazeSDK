using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Registration;

public class RegistrationWipestatsRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("EventID", "mEventID", 0x976A6400, TdfType.Int32, 0, true), // EVID
        new TdfMemberInfo("UserID", "mUserID", 0xD73A6400, TdfType.UInt32, 1, true), // USID
    ];
    private ITdfMember[] __members;

    private TdfInt32 _eventID = new(__typeInfos[0]);
    private TdfUInt32 _userID = new(__typeInfos[1]);

    public RegistrationWipestatsRequest()
    {
        __members = [
            _eventID,
            _userID,
        ];
    }

    public override Tdf CreateNew() => new RegistrationWipestatsRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "RegistrationWipestatsRequest";
    public override string GetFullClassName() => "Blaze::Registration::RegistrationWipestatsRequest";

    public int EventID
    {
        get => _eventID.Value;
        set => _eventID.Value = value;
    }

    public uint UserID
    {
        get => _userID.Value;
        set => _userID.Value = value;
    }

}

