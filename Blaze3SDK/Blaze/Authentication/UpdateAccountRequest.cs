using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Authentication;

public class UpdateAccountRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CurrentPassword", "mCurrentPassword", 0x8F0DE400, TdfType.String, 0, true), // CPWD
        new TdfMemberInfo("Country", "mCountry", 0x8F4CB900, TdfType.String, 1, true), // CTRY
        new TdfMemberInfo("DOB", "mDOB", 0x92F88000, TdfType.String, 2, true), // DOB
        new TdfMemberInfo("Language", "mLanguage", 0xB21BA700, TdfType.String, 3, true), // LANG
        new TdfMemberInfo("Email", "mEmail", 0xB61A6C00, TdfType.String, 4, true), // MAIL
        new TdfMemberInfo("GlobalOptin", "mGlobalOptin", 0xBF0D1100, TdfType.UInt8, 5, true), // OPT1
        new TdfMemberInfo("ThirdPartyOptin", "mThirdPartyOptin", 0xBF0D1300, TdfType.UInt8, 6, true), // OPT3
        new TdfMemberInfo("Password", "mPassword", 0xC21CF300, TdfType.String, 7, true), // PASS
        new TdfMemberInfo("ParentalEmail", "mParentalEmail", 0xC32BB400, TdfType.String, 8, true), // PRNT
        new TdfMemberInfo("UserId", "mUserId", 0xD6990000, TdfType.Int64, 9, true), // UID
    ];
    private ITdfMember[] __members;

    private TdfString _currentPassword = new(__typeInfos[0]);
    private TdfString _country = new(__typeInfos[1]);
    private TdfString _dOB = new(__typeInfos[2]);
    private TdfString _language = new(__typeInfos[3]);
    private TdfString _email = new(__typeInfos[4]);
    private TdfUInt8 _globalOptin = new(__typeInfos[5]);
    private TdfUInt8 _thirdPartyOptin = new(__typeInfos[6]);
    private TdfString _password = new(__typeInfos[7]);
    private TdfString _parentalEmail = new(__typeInfos[8]);
    private TdfInt64 _userId = new(__typeInfos[9]);

    public UpdateAccountRequest()
    {
        __members = [
            _currentPassword,
            _country,
            _dOB,
            _language,
            _email,
            _globalOptin,
            _thirdPartyOptin,
            _password,
            _parentalEmail,
            _userId,
        ];
    }

    public override Tdf CreateNew() => new UpdateAccountRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpdateAccountRequest";
    public override string GetFullClassName() => "Blaze::Authentication::UpdateAccountRequest";

    public string CurrentPassword
    {
        get => _currentPassword.Value;
        set => _currentPassword.Value = value;
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

    public string Language
    {
        get => _language.Value;
        set => _language.Value = value;
    }

    public string Email
    {
        get => _email.Value;
        set => _email.Value = value;
    }

    public byte GlobalOptin
    {
        get => _globalOptin.Value;
        set => _globalOptin.Value = value;
    }

    public byte ThirdPartyOptin
    {
        get => _thirdPartyOptin.Value;
        set => _thirdPartyOptin.Value = value;
    }

    public string Password
    {
        get => _password.Value;
        set => _password.Value = value;
    }

    public string ParentalEmail
    {
        get => _parentalEmail.Value;
        set => _parentalEmail.Value = value;
    }

    public long UserId
    {
        get => _userId.Value;
        set => _userId.Value = value;
    }

}

