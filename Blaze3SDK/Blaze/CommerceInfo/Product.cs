using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.CommerceInfo;

public class Product : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("DefaultLocale", "mDefaultLocale", 0x92CBE300, TdfType.UInt32, 0, true), // DLOC
        new TdfMemberInfo("FinanceId", "mFinanceId", 0x9A990000, TdfType.String, 1, true), // FID
        new TdfMemberInfo("Attribs", "mAttribs", 0xC21D3400, TdfType.Map, 2, true), // PATT
        new TdfMemberInfo("Id", "mId", 0xC2990000, TdfType.String, 3, true), // PID
        new TdfMemberInfo("PlatForm", "mPlatForm", 0xC2C9AD00, TdfType.String, 4, true), // PLFM
        new TdfMemberInfo("Name", "mName", 0xC2E86D00, TdfType.String, 5, true), // PNAM
        new TdfMemberInfo("PricePoints", "mPricePoints", 0xC30C0000, TdfType.Struct, 6, true), // PPP
        new TdfMemberInfo("Type", "mType", 0xC34C2500, TdfType.String, 7, true), // PTPE
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _defaultLocale = new(__typeInfos[0]);
    private TdfString _financeId = new(__typeInfos[1]);
    private TdfMap<string, string> _attribs = new(__typeInfos[2]);
    private TdfString _id = new(__typeInfos[3]);
    private TdfString _platForm = new(__typeInfos[4]);
    private TdfString _name = new(__typeInfos[5]);
    private TdfStruct<Blaze3SDK.Blaze.CommerceInfo.PricePoints?> _pricePoints = new(__typeInfos[6]);
    private TdfString _type = new(__typeInfos[7]);

    public Product()
    {
        __members = [
            _defaultLocale,
            _financeId,
            _attribs,
            _id,
            _platForm,
            _name,
            _pricePoints,
            _type,
        ];
    }

    public override Tdf CreateNew() => new Product();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "Product";
    public override string GetFullClassName() => "Blaze::CommerceInfo::Product";

    public uint DefaultLocale
    {
        get => _defaultLocale.Value;
        set => _defaultLocale.Value = value;
    }

    public string FinanceId
    {
        get => _financeId.Value;
        set => _financeId.Value = value;
    }

    public IDictionary<string, string> Attribs
    {
        get => _attribs.Value;
        set => _attribs.Value = value;
    }

    public string Id
    {
        get => _id.Value;
        set => _id.Value = value;
    }

    public string PlatForm
    {
        get => _platForm.Value;
        set => _platForm.Value = value;
    }

    public string Name
    {
        get => _name.Value;
        set => _name.Value = value;
    }

    public Blaze3SDK.Blaze.CommerceInfo.PricePoints? PricePoints
    {
        get => _pricePoints.Value;
        set => _pricePoints.Value = value;
    }

    public string Type
    {
        get => _type.Value;
        set => _type.Value = value;
    }

}

