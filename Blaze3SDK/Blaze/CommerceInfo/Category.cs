using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.CommerceInfo;

public class Category : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Id", "mId", 0x8E7A6400, TdfType.String, 0, true), // CGID
        new TdfMemberInfo("Type", "mType", 0x8F4E7000, TdfType.String, 1, true), // CTYP
        new TdfMemberInfo("DefaultLocale", "mDefaultLocale", 0x92CBE300, TdfType.UInt32, 2, true), // DLOC
        new TdfMemberInfo("Attribs", "mAttribs", 0xB21B7000, TdfType.Map, 3, true), // LAMP
        new TdfMemberInfo("ProductCount", "mProductCount", 0xC23BB400, TdfType.UInt32, 4, true), // PCNT
        new TdfMemberInfo("SubCategoryList", "mSubCategoryList", 0xCECCF400, TdfType.List, 5, true), // SLST
        new TdfMemberInfo("IsTopCategory", "mIsTopCategory", 0xD23D2500, TdfType.Bool, 6, true), // TCTE
    ];
    private ITdfMember[] __members;

    private TdfString _id = new(__typeInfos[0]);
    private TdfString _type = new(__typeInfos[1]);
    private TdfUInt32 _defaultLocale = new(__typeInfos[2]);
    private TdfMap<string, string> _attribs = new(__typeInfos[3]);
    private TdfUInt32 _productCount = new(__typeInfos[4]);
    private TdfList<string> _subCategoryList = new(__typeInfos[5]);
    private TdfBool _isTopCategory = new(__typeInfos[6]);

    public Category()
    {
        __members = [
            _id,
            _type,
            _defaultLocale,
            _attribs,
            _productCount,
            _subCategoryList,
            _isTopCategory,
        ];
    }

    public override Tdf CreateNew() => new Category();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "Category";
    public override string GetFullClassName() => "Blaze::CommerceInfo::Category";

    public string Id
    {
        get => _id.Value;
        set => _id.Value = value;
    }

    public string Type
    {
        get => _type.Value;
        set => _type.Value = value;
    }

    public uint DefaultLocale
    {
        get => _defaultLocale.Value;
        set => _defaultLocale.Value = value;
    }

    public IDictionary<string, string> Attribs
    {
        get => _attribs.Value;
        set => _attribs.Value = value;
    }

    public uint ProductCount
    {
        get => _productCount.Value;
        set => _productCount.Value = value;
    }

    public IList<string> SubCategoryList
    {
        get => _subCategoryList.Value;
        set => _subCategoryList.Value = value;
    }

    public bool IsTopCategory
    {
        get => _isTopCategory.Value;
        set => _isTopCategory.Value = value;
    }

}

