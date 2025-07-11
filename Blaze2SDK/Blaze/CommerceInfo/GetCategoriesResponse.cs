using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.CommerceInfo;

public class GetCategoriesResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CategoryMap", "mCategoryMap", 0x8ECBAD00, TdfType.Map, 0, true), // CLNM
    ];
    private ITdfMember[] __members;

    private TdfMap<string, Blaze2SDK.Blaze.CommerceInfo.Category> _categoryMap = new(__typeInfos[0]);

    public GetCategoriesResponse()
    {
        __members = [
            _categoryMap,
        ];
    }

    public override Tdf CreateNew() => new GetCategoriesResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetCategoriesResponse";
    public override string GetFullClassName() => "Blaze::CommerceInfo::GetCategoriesResponse";

    public IDictionary<string, Blaze2SDK.Blaze.CommerceInfo.Category> CategoryMap
    {
        get => _categoryMap.Value;
        set => _categoryMap.Value = value;
    }

}

