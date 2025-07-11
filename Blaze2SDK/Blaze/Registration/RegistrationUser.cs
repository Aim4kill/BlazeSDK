using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Registration;

public class RegistrationUser : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("IsBanned", "mIsBanned", 0x8A1B8000, TdfType.UInt8, 0, true), // BAN
        new TdfMemberInfo("CreateDate", "mCreateDate", 0x8E487400, TdfType.String, 1, true), // CDAT
        new TdfMemberInfo("Country", "mCountry", 0x8EF00000, TdfType.String, 2, true), // CO
        new TdfMemberInfo("DOB", "mDOB", 0x92F88000, TdfType.String, 3, true), // DOB
        new TdfMemberInfo("EventID", "mEventID", 0x976A6400, TdfType.Int32, 4, true), // EVID
        new TdfMemberInfo("Flags", "mFlags", 0x9AC9F300, TdfType.UInt32, 5, true), // FLGS
        new TdfMemberInfo("FirstName", "mFirstName", 0x9AE86D00, TdfType.String, 6, true), // FNAM
        new TdfMemberInfo("LastName", "mLastName", 0xB2E86D00, TdfType.String, 7, true), // LNAM
        new TdfMemberInfo("Email", "mEmail", 0xB61A6C00, TdfType.String, 8, true), // MAIL
        new TdfMemberInfo("Note", "mNote", 0xBAFD2500, TdfType.String, 9, true), // NOTE
        new TdfMemberInfo("GamePlatform", "mGamePlatform", 0xC26CAD00, TdfType.String, 10, true), // PFRM
        new TdfMemberInfo("Persona", "mPersona", 0xC33BA100, TdfType.String, 11, true), // PSNA
        new TdfMemberInfo("Password", "mPassword", 0xC3700000, TdfType.String, 12, true), // PW
        new TdfMemberInfo("SecruityAnswer", "mSecruityAnswer", 0xCE58E100, TdfType.String, 13, true), // SECA
        new TdfMemberInfo("SecurityQuestion", "mSecurityQuestion", 0xCE58F100, TdfType.Int32, 14, true), // SECQ
        new TdfMemberInfo("WithThird", "mWithThird", 0xD28A7200, TdfType.UInt8, 15, true), // THIR
        new TdfMemberInfo("GameTitle", "mGameTitle", 0xD29D2C00, TdfType.String, 16, true), // TITL
        new TdfMemberInfo("UserID", "mUserID", 0xD6990000, TdfType.String, 17, true), // UID
        new TdfMemberInfo("WhoBan", "mWhoBan", 0xDE8BE200, TdfType.String, 18, true), // WHOB
        new TdfMemberInfo("WhyBan", "mWhyBan", 0xDE8E6200, TdfType.String, 19, true), // WHYB
        new TdfMemberInfo("ZipCode", "mZipCode", 0xEA9C0000, TdfType.String, 20, true), // ZIP
    ];
    private ITdfMember[] __members;

    private TdfUInt8 _isBanned = new(__typeInfos[0]);
    private TdfString _createDate = new(__typeInfos[1]);
    private TdfString _country = new(__typeInfos[2]);
    private TdfString _dOB = new(__typeInfos[3]);
    private TdfInt32 _eventID = new(__typeInfos[4]);
    private TdfUInt32 _flags = new(__typeInfos[5]);
    private TdfString _firstName = new(__typeInfos[6]);
    private TdfString _lastName = new(__typeInfos[7]);
    private TdfString _email = new(__typeInfos[8]);
    private TdfString _note = new(__typeInfos[9]);
    private TdfString _gamePlatform = new(__typeInfos[10]);
    private TdfString _persona = new(__typeInfos[11]);
    private TdfString _password = new(__typeInfos[12]);
    private TdfString _secruityAnswer = new(__typeInfos[13]);
    private TdfInt32 _securityQuestion = new(__typeInfos[14]);
    private TdfUInt8 _withThird = new(__typeInfos[15]);
    private TdfString _gameTitle = new(__typeInfos[16]);
    private TdfString _userID = new(__typeInfos[17]);
    private TdfString _whoBan = new(__typeInfos[18]);
    private TdfString _whyBan = new(__typeInfos[19]);
    private TdfString _zipCode = new(__typeInfos[20]);

    public RegistrationUser()
    {
        __members = [
            _isBanned,
            _createDate,
            _country,
            _dOB,
            _eventID,
            _flags,
            _firstName,
            _lastName,
            _email,
            _note,
            _gamePlatform,
            _persona,
            _password,
            _secruityAnswer,
            _securityQuestion,
            _withThird,
            _gameTitle,
            _userID,
            _whoBan,
            _whyBan,
            _zipCode,
        ];
    }

    public override Tdf CreateNew() => new RegistrationUser();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "RegistrationUser";
    public override string GetFullClassName() => "Blaze::Registration::RegistrationUser";

    public byte IsBanned
    {
        get => _isBanned.Value;
        set => _isBanned.Value = value;
    }

    public string CreateDate
    {
        get => _createDate.Value;
        set => _createDate.Value = value;
    }

    public string Country
    {
        get => _country.Value;
        set => _country.Value = value;
    }

    public string DOB
    {
        get => _dOB.Value;
        set => _dOB.Value = value;
    }

    public int EventID
    {
        get => _eventID.Value;
        set => _eventID.Value = value;
    }

    public uint Flags
    {
        get => _flags.Value;
        set => _flags.Value = value;
    }

    public string FirstName
    {
        get => _firstName.Value;
        set => _firstName.Value = value;
    }

    public string LastName
    {
        get => _lastName.Value;
        set => _lastName.Value = value;
    }

    public string Email
    {
        get => _email.Value;
        set => _email.Value = value;
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

    public string Persona
    {
        get => _persona.Value;
        set => _persona.Value = value;
    }

    public string Password
    {
        get => _password.Value;
        set => _password.Value = value;
    }

    public string SecruityAnswer
    {
        get => _secruityAnswer.Value;
        set => _secruityAnswer.Value = value;
    }

    public int SecurityQuestion
    {
        get => _securityQuestion.Value;
        set => _securityQuestion.Value = value;
    }

    public byte WithThird
    {
        get => _withThird.Value;
        set => _withThird.Value = value;
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

    public string ZipCode
    {
        get => _zipCode.Value;
        set => _zipCode.Value = value;
    }

}

