using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.CommerceInfo;

public class GetProducts : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CategoryName", "mCategoryName", 0x8E7BAD00, TdfType.String, 0, true), // CGNM
        new TdfMemberInfo("CatalogName", "mCatalogName", 0x8ECBAD00, TdfType.String, 1, true), // CLNM
        new TdfMemberInfo("PageNo", "mPageNo", 0xC30CEE00, TdfType.UInt16, 2, true), // PPSN
        new TdfMemberInfo("PageSize", "mPageSize", 0xC30CFA00, TdfType.UInt16, 3, true), // PPSZ
    ];
    private ITdfMember[] __members;

    private TdfString _categoryName = new(__typeInfos[0]);
    private TdfString _catalogName = new(__typeInfos[1]);
    private TdfUInt16 _pageNo = new(__typeInfos[2]);
    private TdfUInt16 _pageSize = new(__typeInfos[3]);

    public GetProducts()
    {
        __members = [
            _categoryName,
            _catalogName,
            _pageNo,
            _pageSize,
        ];
    }

    public override Tdf CreateNew() => new GetProducts();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetProducts";
    public override string GetFullClassName() => "Blaze::CommerceInfo::GetProducts";

    public string CategoryName
    {
        get => _categoryName.Value;
        set => _categoryName.Value = value;
    }

    public string CatalogName
    {
        get => _catalogName.Value;
        set => _catalogName.Value = value;
    }

    public ushort PageNo
    {
        get => _pageNo.Value;
        set => _pageNo.Value = value;
    }

    public ushort PageSize
    {
        get => _pageSize.Value;
        set => _pageSize.Value = value;
    }

}

