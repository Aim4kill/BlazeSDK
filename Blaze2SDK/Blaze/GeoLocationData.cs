using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze;

public class GeoLocationData : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Country", "mCountry", 0x8EED3900, TdfType.String, 0, true), // CNTY
        new TdfMemberInfo("City", "mCity", 0x8F4E4000, TdfType.String, 1, true), // CTY
        new TdfMemberInfo("BlazeId", "mBlazeId", 0xA6400000, TdfType.UInt32, 2, true), // ID
        new TdfMemberInfo("Latitude", "mLatitude", 0xB21D0000, TdfType.Int32, 3, true), // LAT
        new TdfMemberInfo("Longitude", "mLongitude", 0xB2FB8000, TdfType.Int32, 4, true), // LON
        new TdfMemberInfo("OptOut", "mOptOut", 0xBF0D0000, TdfType.Bool, 5, true), // OPT
        new TdfMemberInfo("StateRegion", "mStateRegion", 0xCF400000, TdfType.String, 6, true), // ST
    ];
    private ITdfMember[] __members;

    private TdfString _country = new(__typeInfos[0]);
    private TdfString _city = new(__typeInfos[1]);
    private TdfUInt32 _blazeId = new(__typeInfos[2]);
    private TdfInt32 _latitude = new(__typeInfos[3]);
    private TdfInt32 _longitude = new(__typeInfos[4]);
    private TdfBool _optOut = new(__typeInfos[5]);
    private TdfString _stateRegion = new(__typeInfos[6]);

    public GeoLocationData()
    {
        __members = [
            _country,
            _city,
            _blazeId,
            _latitude,
            _longitude,
            _optOut,
            _stateRegion,
        ];
    }

    public override Tdf CreateNew() => new GeoLocationData();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GeoLocationData";
    public override string GetFullClassName() => "Blaze::GeoLocationData";

    public string Country
    {
        get => _country.Value;
        set => _country.Value = value;
    }

    public string City
    {
        get => _city.Value;
        set => _city.Value = value;
    }

    public uint BlazeId
    {
        get => _blazeId.Value;
        set => _blazeId.Value = value;
    }

    public int Latitude
    {
        get => _latitude.Value;
        set => _latitude.Value = value;
    }

    public int Longitude
    {
        get => _longitude.Value;
        set => _longitude.Value = value;
    }

    public bool OptOut
    {
        get => _optOut.Value;
        set => _optOut.Value = value;
    }

    public string StateRegion
    {
        get => _stateRegion.Value;
        set => _stateRegion.Value = value;
    }

}

