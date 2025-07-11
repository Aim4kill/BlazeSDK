using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Registration;

public class RegistrationUpdatenoteRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("EventID", "mEventID", 0x976A6400, TdfType.Int32, 0, true), // EVID
        new TdfMemberInfo("Note", "mNote", 0xBAFD2500, TdfType.String, 1, true), // NOTE
        new TdfMemberInfo("GamePlatform", "mGamePlatform", 0xC26CAD00, TdfType.String, 2, true), // PFRM
        new TdfMemberInfo("GameTitle", "mGameTitle", 0xD29D2C00, TdfType.String, 3, true), // TITL
        new TdfMemberInfo("UserID", "mUserID", 0xD6990000, TdfType.String, 4, true), // UID
    ];
    private ITdfMember[] __members;

    private TdfInt32 _eventID = new(__typeInfos[0]);
    private TdfString _note = new(__typeInfos[1]);
    private TdfString _gamePlatform = new(__typeInfos[2]);
    private TdfString _gameTitle = new(__typeInfos[3]);
    private TdfString _userID = new(__typeInfos[4]);

    public RegistrationUpdatenoteRequest()
    {
        __members = [
            _eventID,
            _note,
            _gamePlatform,
            _gameTitle,
            _userID,
        ];
    }

    public override Tdf CreateNew() => new RegistrationUpdatenoteRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "RegistrationUpdatenoteRequest";
    public override string GetFullClassName() => "Blaze::Registration::RegistrationUpdatenoteRequest";

    public int EventID
    {
        get => _eventID.Value;
        set => _eventID.Value = value;
    }

    public string Note
    {
        get => _note.Value;
        set => _note.Value = value;
    }

    public string GamePlatform
    {
        get => _gamePlatform.Value;
        set => _gamePlatform.Value = value;
    }

    public string GameTitle
    {
        get => _gameTitle.Value;
        set => _gameTitle.Value = value;
    }

    public string UserID
    {
        get => _userID.Value;
        set => _userID.Value = value;
    }

}

