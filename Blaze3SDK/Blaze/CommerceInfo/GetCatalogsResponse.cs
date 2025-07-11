using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.CommerceInfo;

public class GetCatalogsResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CatalogMap", "mCatalogMap", 0x8ECBAD00, TdfType.Map, 0, true), // CLNM
    ];
    private ITdfMember[] __members;

    private TdfMap<string, Blaze3SDK.Blaze.CommerceInfo.Catalog> _catalogMap = new(__typeInfos[0]);

    public GetCatalogsResponse()
    {
        __members = [
            _catalogMap,
        ];
    }

    public override Tdf CreateNew() => new GetCatalogsResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetCatalogsResponse";
    public override string GetFullClassName() => "Blaze::CommerceInfo::GetCatalogsResponse";

    public IDictionary<string, Blaze3SDK.Blaze.CommerceInfo.Catalog> CatalogMap
    {
        get => _catalogMap.Value;
        set => _catalogMap.Value = value;
    }

}

