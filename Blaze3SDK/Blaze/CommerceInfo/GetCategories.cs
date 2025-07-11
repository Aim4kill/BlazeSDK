using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.CommerceInfo;

public class GetCategories : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CatalogName", "mCatalogName", 0x8ECBAD00, TdfType.String, 0, true), // CLNM
    ];
    private ITdfMember[] __members;

    private TdfString _catalogName = new(__typeInfos[0]);

    public GetCategories()
    {
        __members = [
            _catalogName,
        ];
    }

    public override Tdf CreateNew() => new GetCategories();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetCategories";
    public override string GetFullClassName() => "Blaze::CommerceInfo::GetCategories";

    public string CatalogName
    {
        get => _catalogName.Value;
        set => _catalogName.Value = value;
    }

}

