using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.CommerceInfo;

public class CheckoutProduct : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ProductId", "mProductId", 0xC24A6400, TdfType.String, 0, true), // PDID
        new TdfMemberInfo("Quantity", "mQuantity", 0xC24CAE00, TdfType.UInt32, 1, true), // PDRN
    ];
    private ITdfMember[] __members;

    private TdfString _productId = new(__typeInfos[0]);
    private TdfUInt32 _quantity = new(__typeInfos[1]);

    public CheckoutProduct()
    {
        __members = [
            _productId,
            _quantity,
        ];
    }

    public override Tdf CreateNew() => new CheckoutProduct();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "CheckoutProduct";
    public override string GetFullClassName() => "Blaze::CommerceInfo::CheckoutProduct";

    public string ProductId
    {
        get => _productId.Value;
        set => _productId.Value = value;
    }

    public uint Quantity
    {
        get => _quantity.Value;
        set => _quantity.Value = value;
    }

}

