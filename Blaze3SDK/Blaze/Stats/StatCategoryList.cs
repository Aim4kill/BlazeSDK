using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Stats;

public class StatCategoryList : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Categories", "mCategories", 0x8E1D3300, TdfType.List, 0, true), // CATS
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze3SDK.Blaze.Stats.StatCategorySummary> _categories = new(__typeInfos[0]);

    public StatCategoryList()
    {
        __members = [
            _categories,
        ];
    }

    public override Tdf CreateNew() => new StatCategoryList();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "StatCategoryList";
    public override string GetFullClassName() => "Blaze::Stats::StatCategoryList";

    public IList<Blaze3SDK.Blaze.Stats.StatCategorySummary> Categories
    {
        get => _categories.Value;
        set => _categories.Value = value;
    }

}

