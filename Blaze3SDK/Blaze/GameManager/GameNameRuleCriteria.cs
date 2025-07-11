using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class GameNameRuleCriteria : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("SearchString", "mSearchString", 0xCF58B300, TdfType.String, 0, true), // SUBS
    ];
    private ITdfMember[] __members;

    private TdfString _searchString = new(__typeInfos[0]);

    public GameNameRuleCriteria()
    {
        __members = [
            _searchString,
        ];
    }

    public override Tdf CreateNew() => new GameNameRuleCriteria();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GameNameRuleCriteria";
    public override string GetFullClassName() => "Blaze::GameManager::GameNameRuleCriteria";

    public string SearchString
    {
        get => _searchString.Value;
        set => _searchString.Value = value;
    }

}

