using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Authentication;

public class CheckAgeReqRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("BirthDay", "mBirthDay", 0x8A487900, TdfType.Int32, 0, true), // BDAY
        new TdfMemberInfo("BirthMonth", "mBirthMonth", 0x8ADBEE00, TdfType.Int32, 1, true), // BMON
        new TdfMemberInfo("BirthYear", "mBirthYear", 0x8B9C8000, TdfType.Int32, 2, true), // BYR
        new TdfMemberInfo("IsoCountryCode", "mIsoCountryCode", 0x8F4CB900, TdfType.String, 3, true), // CTRY
    ];
    private ITdfMember[] __members;

    private TdfInt32 _birthDay = new(__typeInfos[0]);
    private TdfInt32 _birthMonth = new(__typeInfos[1]);
    private TdfInt32 _birthYear = new(__typeInfos[2]);
    private TdfString _isoCountryCode = new(__typeInfos[3]);

    public CheckAgeReqRequest()
    {
        __members = [
            _birthDay,
            _birthMonth,
            _birthYear,
            _isoCountryCode,
        ];
    }

    public override Tdf CreateNew() => new CheckAgeReqRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "CheckAgeReqRequest";
    public override string GetFullClassName() => "Blaze::Authentication::CheckAgeReqRequest";

    public int BirthDay
    {
        get => _birthDay.Value;
        set => _birthDay.Value = value;
    }

    public int BirthMonth
    {
        get => _birthMonth.Value;
        set => _birthMonth.Value = value;
    }

    public int BirthYear
    {
        get => _birthYear.Value;
        set => _birthYear.Value = value;
    }

    public string IsoCountryCode
    {
        get => _isoCountryCode.Value;
        set => _isoCountryCode.Value = value;
    }

}

