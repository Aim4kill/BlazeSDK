using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.CommerceInfo;

public class GetProductsResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ProductVector", "mProductVector", 0xC24CAC00, TdfType.List, 0, true), // PDRL
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze3SDK.Blaze.CommerceInfo.Product> _productVector = new(__typeInfos[0]);

    public GetProductsResponse()
    {
        __members = [
            _productVector,
        ];
    }

    public override Tdf CreateNew() => new GetProductsResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetProductsResponse";
    public override string GetFullClassName() => "Blaze::CommerceInfo::GetProductsResponse";

    public IList<Blaze3SDK.Blaze.CommerceInfo.Product> ProductVector
    {
        get => _productVector.Value;
        set => _productVector.Value = value;
    }

}

