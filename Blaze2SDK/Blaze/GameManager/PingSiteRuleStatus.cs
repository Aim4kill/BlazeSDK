using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class PingSiteRuleStatus : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MatchedValues", "mMatchedValues", 0xDA1B3500, TdfType.List, 0, true), // VALU
    ];
    private ITdfMember[] __members;

    private TdfList<string> _matchedValues = new(__typeInfos[0]);

    public PingSiteRuleStatus()
    {
        __members = [
            _matchedValues,
        ];
    }

    public override Tdf CreateNew() => new PingSiteRuleStatus();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PingSiteRuleStatus";
    public override string GetFullClassName() => "Blaze::GameManager::PingSiteRuleStatus";

    public IList<string> MatchedValues
    {
        get => _matchedValues.Value;
        set => _matchedValues.Value = value;
    }

}

