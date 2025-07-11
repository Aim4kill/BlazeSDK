using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class GenericRulePrefs : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("RuleName", "mRuleName", 0xBA1B6500, TdfType.String, 0, true), // NAME
        new TdfMemberInfo("MinFitThresholdName", "mMinFitThresholdName", 0xD28B2400, TdfType.String, 1, true), // THLD
        new TdfMemberInfo("DesiredValues", "mDesiredValues", 0xDA1B3500, TdfType.List, 2, true), // VALU
    ];
    private ITdfMember[] __members;

    private TdfString _ruleName = new(__typeInfos[0]);
    private TdfString _minFitThresholdName = new(__typeInfos[1]);
    private TdfList<string> _desiredValues = new(__typeInfos[2]);

    public GenericRulePrefs()
    {
        __members = [
            _ruleName,
            _minFitThresholdName,
            _desiredValues,
        ];
    }

    public override Tdf CreateNew() => new GenericRulePrefs();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GenericRulePrefs";
    public override string GetFullClassName() => "Blaze::GameManager::GenericRulePrefs";

    public string RuleName
    {
        get => _ruleName.Value;
        set => _ruleName.Value = value;
    }

    public string MinFitThresholdName
    {
        get => _minFitThresholdName.Value;
        set => _minFitThresholdName.Value = value;
    }

    public IList<string> DesiredValues
    {
        get => _desiredValues.Value;
        set => _desiredValues.Value = value;
    }

}

