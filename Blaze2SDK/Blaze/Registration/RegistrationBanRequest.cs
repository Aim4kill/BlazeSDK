using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Registration;

public class RegistrationBanRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("IsBanned", "mIsBanned", 0x8A1B8000, TdfType.UInt8, 0, true), // BAN
        new TdfMemberInfo("EventID", "mEventID", 0x976A6400, TdfType.Int32, 1, true), // EVID
        new TdfMemberInfo("GamePlatform", "mGamePlatform", 0xC26CAD00, TdfType.String, 2, true), // PFRM
        new TdfMemberInfo("GameTitle", "mGameTitle", 0xD29D2C00, TdfType.String, 3, true), // TITL
        new TdfMemberInfo("UserID", "mUserID", 0xD6990000, TdfType.String, 4, true), // UID
        new TdfMemberInfo("WhoBan", "mWhoBan", 0xDE8BE200, TdfType.String, 5, true), // WHOB
        new TdfMemberInfo("WhyBan", "mWhyBan", 0xDE8E6200, TdfType.String, 6, true), // WHYB
    ];
    private ITdfMember[] __members;

    private TdfUInt8 _isBanned = new(__typeInfos[0]);
    private TdfInt32 _eventID = new(__typeInfos[1]);
    private TdfString _gamePlatform = new(__typeInfos[2]);
    private TdfString _gameTitle = new(__typeInfos[3]);
    private TdfString _userID = new(__typeInfos[4]);
    private TdfString _whoBan = new(__typeInfos[5]);
    private TdfString _whyBan = new(__typeInfos[6]);

    public RegistrationBanRequest()
    {
        __members = [
            _isBanned,
            _eventID,
            _gamePlatform,
            _gameTitle,
            _userID,
            _whoBan,
            _whyBan,
        ];
    }

    public override Tdf CreateNew() => new RegistrationBanRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "RegistrationBanRequest";
    public override string GetFullClassName() => "Blaze::Registration::RegistrationBanRequest";

    public byte IsBanned
    {
        get => _isBanned.Value;
        set => _isBanned.Value = value;
    }

    public int EventID
    {
        get => _eventID.Value;
        set => _eventID.Value = value;
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

    public string WhoBan
    {
        get => _whoBan.Value;
        set => _whoBan.Value = value;
    }

    public string WhyBan
    {
        get => _whyBan.Value;
        set => _whyBan.Value = value;
    }

}

