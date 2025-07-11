using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class PredefinedRuleConfig : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("RuleName", "mRuleName", 0xCAEB6500, TdfType.String, 0, true), // RNME
        new TdfMemberInfo("ThresholdNames", "mThresholdNames", 0xD28B3300, TdfType.List, 1, true), // THLS
        new TdfMemberInfo("Weight", "mWeight", 0xDE7A3400, TdfType.UInt32, 2, true), // WGHT
    ];
    private ITdfMember[] __members;

    private TdfString _ruleName = new(__typeInfos[0]);
    private TdfList<string> _thresholdNames = new(__typeInfos[1]);
    private TdfUInt32 _weight = new(__typeInfos[2]);

    public PredefinedRuleConfig()
    {
        __members = [
            _ruleName,
            _thresholdNames,
            _weight,
        ];
    }

    public override Tdf CreateNew() => new PredefinedRuleConfig();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PredefinedRuleConfig";
    public override string GetFullClassName() => "Blaze::GameManager::PredefinedRuleConfig";

    public string RuleName
    {
        get => _ruleName.Value;
        set => _ruleName.Value = value;
    }

    public IList<string> ThresholdNames
    {
        get => _thresholdNames.Value;
        set => _thresholdNames.Value = value;
    }

    public uint Weight
    {
        get => _weight.Value;
        set => _weight.Value = value;
    }

}

