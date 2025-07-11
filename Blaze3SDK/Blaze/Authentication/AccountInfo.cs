using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Authentication;

public class AccountInfo : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AnonymousUser", "mAnonymousUser", 0x86DD4000, TdfType.Bool, 0, true), // AMU
        new TdfMemberInfo("AuthenticationSource", "mAuthenticationSource", 0x873CA300, TdfType.String, 1, true), // ASRC
        new TdfMemberInfo("Country", "mCountry", 0x8EF00000, TdfType.String, 2, true), // CO
        new TdfMemberInfo("DOB", "mDOB", 0x92F88000, TdfType.String, 3, true), // DOB
        new TdfMemberInfo("DateCreated", "mDateCreated", 0x9348F200, TdfType.String, 4, true), // DTCR
        new TdfMemberInfo("GlobalOptin", "mGlobalOptin", 0x9EFC3400, TdfType.UInt8, 5, true), // GOPT
        new TdfMemberInfo("LastAuth", "mLastAuth", 0xB21D2800, TdfType.String, 6, true), // LATH
        new TdfMemberInfo("Language", "mLanguage", 0xB2E00000, TdfType.String, 7, true), // LN
        new TdfMemberInfo("Email", "mEmail", 0xB61A6C00, TdfType.String, 8, true), // MAIL
        new TdfMemberInfo("ParentalEmail", "mParentalEmail", 0xC2DB0000, TdfType.String, 9, true), // PML
        new TdfMemberInfo("ReasonCode", "mReasonCode", 0xCA300000, TdfType.Enum, 10, true), // RC
        new TdfMemberInfo("Status", "mStatus", 0xCF487300, TdfType.Enum, 11, true), // STAS
        new TdfMemberInfo("EmailStatus", "mEmailStatus", 0xCF487400, TdfType.Enum, 12, true), // STAT
        new TdfMemberInfo("TosVersion", "mTosVersion", 0xD2FCF600, TdfType.String, 13, true), // TOSV
        new TdfMemberInfo("ThirdPartyOptin", "mThirdPartyOptin", 0xD30BF400, TdfType.UInt8, 14, true), // TPOT
        new TdfMemberInfo("UnderageUser", "mUnderageUser", 0xD64D4000, TdfType.Bool, 15, true), // UDU
        new TdfMemberInfo("UserId", "mUserId", 0xD6990000, TdfType.Int64, 16, true), // UID
    ];
    private ITdfMember[] __members;

    private TdfBool _anonymousUser = new(__typeInfos[0]);
    private TdfString _authenticationSource = new(__typeInfos[1]);
    private TdfString _country = new(__typeInfos[2]);
    private TdfString _dOB = new(__typeInfos[3]);
    private TdfString _dateCreated = new(__typeInfos[4]);
    private TdfUInt8 _globalOptin = new(__typeInfos[5]);
    private TdfString _lastAuth = new(__typeInfos[6]);
    private TdfString _language = new(__typeInfos[7]);
    private TdfString _email = new(__typeInfos[8]);
    private TdfString _parentalEmail = new(__typeInfos[9]);
    private TdfEnum<Blaze3SDK.Blaze.Authentication.StatusReason> _reasonCode = new(__typeInfos[10]);
    private TdfEnum<Blaze3SDK.Blaze.Authentication.AccountStatus> _status = new(__typeInfos[11]);
    private TdfEnum<Blaze3SDK.Blaze.Authentication.EmailStatus> _emailStatus = new(__typeInfos[12]);
    private TdfString _tosVersion = new(__typeInfos[13]);
    private TdfUInt8 _thirdPartyOptin = new(__typeInfos[14]);
    private TdfBool _underageUser = new(__typeInfos[15]);
    private TdfInt64 _userId = new(__typeInfos[16]);

    public AccountInfo()
    {
        __members = [
            _anonymousUser,
            _authenticationSource,
            _country,
            _dOB,
            _dateCreated,
            _globalOptin,
            _lastAuth,
            _language,
            _email,
            _parentalEmail,
            _reasonCode,
            _status,
            _emailStatus,
            _tosVersion,
            _thirdPartyOptin,
            _underageUser,
            _userId,
        ];
    }

    public override Tdf CreateNew() => new AccountInfo();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "AccountInfo";
    public override string GetFullClassName() => "Blaze::Authentication::AccountInfo";

    public bool AnonymousUser
    {
        get => _anonymousUser.Value;
        set => _anonymousUser.Value = value;
    }

    public string AuthenticationSource
    {
        get => _authenticationSource.Value;
        set => _authenticationSource.Value = value;
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

    public string DateCreated
    {
        get => _dateCreated.Value;
        set => _dateCreated.Value = value;
    }

    public byte GlobalOptin
    {
        get => _globalOptin.Value;
        set => _globalOptin.Value = value;
    }

    public string LastAuth
    {
        get => _lastAuth.Value;
        set => _lastAuth.Value = value;
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

    public string ParentalEmail
    {
        get => _parentalEmail.Value;
        set => _parentalEmail.Value = value;
    }

    public Blaze3SDK.Blaze.Authentication.StatusReason ReasonCode
    {
        get => _reasonCode.Value;
        set => _reasonCode.Value = value;
    }

    public Blaze3SDK.Blaze.Authentication.AccountStatus Status
    {
        get => _status.Value;
        set => _status.Value = value;
    }

    public Blaze3SDK.Blaze.Authentication.EmailStatus EmailStatus
    {
        get => _emailStatus.Value;
        set => _emailStatus.Value = value;
    }

    public string TosVersion
    {
        get => _tosVersion.Value;
        set => _tosVersion.Value = value;
    }

    public byte ThirdPartyOptin
    {
        get => _thirdPartyOptin.Value;
        set => _thirdPartyOptin.Value = value;
    }

    public bool UnderageUser
    {
        get => _underageUser.Value;
        set => _underageUser.Value = value;
    }

    public long UserId
    {
        get => _userId.Value;
        set => _userId.Value = value;
    }

}

