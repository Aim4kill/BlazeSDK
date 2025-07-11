using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.CommerceInfo;

public class Catalog : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CurrencyType", "mCurrencyType", 0x8E3D3000, TdfType.String, 0, true), // CCTP
        new TdfMemberInfo("Currency", "mCurrency", 0x8E3D7900, TdfType.String, 1, true), // CCUY
        new TdfMemberInfo("Id", "mId", 0x8E7A6400, TdfType.String, 2, true), // CGID
        new TdfMemberInfo("Attribs", "mAttribs", 0xB21B7000, TdfType.Map, 3, true), // LAMP
    ];
    private ITdfMember[] __members;

    private TdfString _currencyType = new(__typeInfos[0]);
    private TdfString _currency = new(__typeInfos[1]);
    private TdfString _id = new(__typeInfos[2]);
    private TdfMap<string, string> _attribs = new(__typeInfos[3]);

    public Catalog()
    {
        __members = [
            _currencyType,
            _currency,
            _id,
            _attribs,
        ];
    }

    public override Tdf CreateNew() => new Catalog();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "Catalog";
    public override string GetFullClassName() => "Blaze::CommerceInfo::Catalog";

    public string CurrencyType
    {
        get => _currencyType.Value;
        set => _currencyType.Value = value;
    }

    public string Currency
    {
        get => _currency.Value;
        set => _currency.Value = value;
    }

    public string Id
    {
        get => _id.Value;
        set => _id.Value = value;
    }

    public IDictionary<string, string> Attribs
    {
        get => _attribs.Value;
        set => _attribs.Value = value;
    }

}

