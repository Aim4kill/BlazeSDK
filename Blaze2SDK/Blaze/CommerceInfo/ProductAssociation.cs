using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.CommerceInfo;

public class ProductAssociation : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("SrcCatalog", "mSrcCatalog", 0x8E387400, TdfType.String, 0, true), // CCAT
        new TdfMemberInfo("SrcProductId", "mSrcProductId", 0x8F0CA400, TdfType.String, 1, true), // CPRD
        new TdfMemberInfo("IsDefault", "mIsDefault", 0xCF092600, TdfType.Bool, 2, true), // SPDF
    ];
    private ITdfMember[] __members;

    private TdfString _srcCatalog = new(__typeInfos[0]);
    private TdfString _srcProductId = new(__typeInfos[1]);
    private TdfBool _isDefault = new(__typeInfos[2]);

    public ProductAssociation()
    {
        __members = [
            _srcCatalog,
            _srcProductId,
            _isDefault,
        ];
    }

    public override Tdf CreateNew() => new ProductAssociation();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ProductAssociation";
    public override string GetFullClassName() => "Blaze::CommerceInfo::ProductAssociation";

    public string SrcCatalog
    {
        get => _srcCatalog.Value;
        set => _srcCatalog.Value = value;
    }

    public string SrcProductId
    {
        get => _srcProductId.Value;
        set => _srcProductId.Value = value;
    }

    public bool IsDefault
    {
        get => _isDefault.Value;
        set => _isDefault.Value = value;
    }

}

