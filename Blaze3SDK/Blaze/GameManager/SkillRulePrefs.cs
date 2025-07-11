using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class SkillRulePrefs : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("SkillValueOverride", "mSkillValueOverride", 0xCEB93300, TdfType.Int64, 0, true), // SKDS
        new TdfMemberInfo("RuleName", "mRuleName", 0xCEBCAE00, TdfType.String, 1, true), // SKRN
        new TdfMemberInfo("UseSkillValueOverride", "mUseSkillValueOverride", 0xCF6BF200, TdfType.Enum, 2, true), // SVOR
        new TdfMemberInfo("MinFitThresholdName", "mMinFitThresholdName", 0xD28B2400, TdfType.String, 3, true), // THLD
    ];
    private ITdfMember[] __members;

    private TdfInt64 _skillValueOverride = new(__typeInfos[0]);
    private TdfString _ruleName = new(__typeInfos[1]);
    private TdfEnum<Blaze3SDK.Blaze.GameManager.SkillValueOverride> _useSkillValueOverride = new(__typeInfos[2]);
    private TdfString _minFitThresholdName = new(__typeInfos[3]);

    public SkillRulePrefs()
    {
        __members = [
            _skillValueOverride,
            _ruleName,
            _useSkillValueOverride,
            _minFitThresholdName,
        ];
    }

    public override Tdf CreateNew() => new SkillRulePrefs();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "SkillRulePrefs";
    public override string GetFullClassName() => "Blaze::GameManager::SkillRulePrefs";

    public long SkillValueOverride
    {
        get => _skillValueOverride.Value;
        set => _skillValueOverride.Value = value;
    }

    public string RuleName
    {
        get => _ruleName.Value;
        set => _ruleName.Value = value;
    }

    public Blaze3SDK.Blaze.GameManager.SkillValueOverride UseSkillValueOverride
    {
        get => _useSkillValueOverride.Value;
        set => _useSkillValueOverride.Value = value;
    }

    public string MinFitThresholdName
    {
        get => _minFitThresholdName.Value;
        set => _minFitThresholdName.Value = value;
    }

}

