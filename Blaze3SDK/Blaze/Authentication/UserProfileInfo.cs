using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Authentication;

public class UserProfileInfo : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("City", "mCity", 0x8E9D3900, TdfType.String, 0, true), // CITY
        new TdfMemberInfo("Country", "mCountry", 0x8F4CB900, TdfType.String, 1, true), // CTRY
        new TdfMemberInfo("Gender", "mGender", 0x9EE93200, TdfType.Enum, 2, true), // GNDR
        new TdfMemberInfo("State", "mState", 0xCF487400, TdfType.String, 3, true), // STAT
        new TdfMemberInfo("Street", "mStreet", 0xCF4CB400, TdfType.String, 4, true), // STRT
        new TdfMemberInfo("ZipCode", "mZipCode", 0xEA9C0000, TdfType.String, 5, true), // ZIP
    ];
    private ITdfMember[] __members;

    private TdfString _city = new(__typeInfos[0]);
    private TdfString _country = new(__typeInfos[1]);
    private TdfEnum<Blaze3SDK.Blaze.Authentication.Gender> _gender = new(__typeInfos[2]);
    private TdfString _state = new(__typeInfos[3]);
    private TdfString _street = new(__typeInfos[4]);
    private TdfString _zipCode = new(__typeInfos[5]);

    public UserProfileInfo()
    {
        __members = [
            _city,
            _country,
            _gender,
            _state,
            _street,
            _zipCode,
        ];
    }

    public override Tdf CreateNew() => new UserProfileInfo();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UserProfileInfo";
    public override string GetFullClassName() => "Blaze::Authentication::UserProfileInfo";

    public string City
    {
        get => _city.Value;
        set => _city.Value = value;
    }

    public string Country
    {
        get => _country.Value;
        set => _country.Value = value;
    }

    public Blaze3SDK.Blaze.Authentication.Gender Gender
    {
        get => _gender.Value;
        set => _gender.Value = value;
    }

    public string State
    {
        get => _state.Value;
        set => _state.Value = value;
    }

    public string Street
    {
        get => _street.Value;
        set => _street.Value = value;
    }

    public string ZipCode
    {
        get => _zipCode.Value;
        set => _zipCode.Value = value;
    }

}

