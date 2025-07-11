using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.CommerceInfo;

public class PricePoint : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CurrencyType", "mCurrencyType", 0xC23D3000, TdfType.String, 0, true), // PCTP
        new TdfMemberInfo("Currency", "mCurrency", 0xC23D7900, TdfType.String, 1, true), // PCUY
        new TdfMemberInfo("Price", "mPrice", 0xC3000000, TdfType.String, 2, true), // PP
        new TdfMemberInfo("Locale", "mLocale", 0xC30B2300, TdfType.String, 3, true), // PPLC
        new TdfMemberInfo("PriceType", "mPriceType", 0xC30D0000, TdfType.String, 4, true), // PPT
    ];
    private ITdfMember[] __members;

    private TdfString _currencyType = new(__typeInfos[0]);
    private TdfString _currency = new(__typeInfos[1]);
    private TdfString _price = new(__typeInfos[2]);
    private TdfString _locale = new(__typeInfos[3]);
    private TdfString _priceType = new(__typeInfos[4]);

    public PricePoint()
    {
        __members = [
            _currencyType,
            _currency,
            _price,
            _locale,
            _priceType,
        ];
    }

    public override Tdf CreateNew() => new PricePoint();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PricePoint";
    public override string GetFullClassName() => "Blaze::CommerceInfo::PricePoint";

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

    public string Price
    {
        get => _price.Value;
        set => _price.Value = value;
    }

    public string Locale
    {
        get => _locale.Value;
        set => _locale.Value = value;
    }

    public string PriceType
    {
        get => _priceType.Value;
        set => _priceType.Value = value;
    }

}

