using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Registration;

public class RegistrationReturnusersRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("EventID", "mEventID", 0x976A6400, TdfType.Int32, 0, true), // EVID
        new TdfMemberInfo("RowCount", "mRowCount", 0xBB2BF700, TdfType.Int32, 1, true), // NROW
        new TdfMemberInfo("Offset", "mOffset", 0xBE69B300, TdfType.Int32, 2, true), // OFFS
        new TdfMemberInfo("GamePlatform", "mGamePlatform", 0xC26CAD00, TdfType.String, 3, true), // PFRM
        new TdfMemberInfo("GameTitle", "mGameTitle", 0xD29D2C00, TdfType.String, 4, true), // TITL
        new TdfMemberInfo("UserID", "mUserID", 0xD6990000, TdfType.String, 5, true), // UID
    ];
    private ITdfMember[] __members;

    private TdfInt32 _eventID = new(__typeInfos[0]);
    private TdfInt32 _rowCount = new(__typeInfos[1]);
    private TdfInt32 _offset = new(__typeInfos[2]);
    private TdfString _gamePlatform = new(__typeInfos[3]);
    private TdfString _gameTitle = new(__typeInfos[4]);
    private TdfString _userID = new(__typeInfos[5]);

    public RegistrationReturnusersRequest()
    {
        __members = [
            _eventID,
            _rowCount,
            _offset,
            _gamePlatform,
            _gameTitle,
            _userID,
        ];
    }

    public override Tdf CreateNew() => new RegistrationReturnusersRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "RegistrationReturnusersRequest";
    public override string GetFullClassName() => "Blaze::Registration::RegistrationReturnusersRequest";

    public int EventID
    {
        get => _eventID.Value;
        set => _eventID.Value = value;
    }

    public int RowCount
    {
        get => _rowCount.Value;
        set => _rowCount.Value = value;
    }

    public int Offset
    {
        get => _offset.Value;
        set => _offset.Value = value;
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

