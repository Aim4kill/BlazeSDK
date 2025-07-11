using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Locker;

public class CategoryListResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CategorySummaries", "mCategorySummaries", 0xB29CF400, TdfType.List, 0, true), // LIST
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze3SDK.Blaze.Locker.CategorySummary> _categorySummaries = new(__typeInfos[0]);

    public CategoryListResponse()
    {
        __members = [
            _categorySummaries,
        ];
    }

    public override Tdf CreateNew() => new CategoryListResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "CategoryListResponse";
    public override string GetFullClassName() => "Blaze::Locker::CategoryListResponse";

    public IList<Blaze3SDK.Blaze.Locker.CategorySummary> CategorySummaries
    {
        get => _categorySummaries.Value;
        set => _categorySummaries.Value = value;
    }

}

