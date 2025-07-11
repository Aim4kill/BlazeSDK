using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.CommerceInfo;

public class CheckoutProducts : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CheckoutProducts", "mCheckoutProducts", 0xC24B3300, TdfType.List, 0, true), // PDLS
        new TdfMemberInfo("WalletName", "mWalletName", 0xDECBAD00, TdfType.String, 1, true), // WLNM
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze3SDK.Blaze.CommerceInfo.CheckoutProduct> _checkoutProducts = new(__typeInfos[0]);
    private TdfString _walletName = new(__typeInfos[1]);

    public CheckoutProducts()
    {
        __members = [
            _checkoutProducts,
            _walletName,
        ];
    }

    public override Tdf CreateNew() => new CheckoutProducts();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "CheckoutProducts";
    public override string GetFullClassName() => "Blaze::CommerceInfo::CheckoutProducts";

    public IList<Blaze3SDK.Blaze.CommerceInfo.CheckoutProduct> mCheckoutProducts
    {
        get => _checkoutProducts.Value;
        set => _checkoutProducts.Value = value;
    }

    public string WalletName
    {
        get => _walletName.Value;
        set => _walletName.Value = value;
    }

}

