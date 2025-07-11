using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class SkillRuleStatus : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("RuleName", "mRuleName", 0xBA1B6500, TdfType.String, 0, true), // NAME
        new TdfMemberInfo("MinSkillAccepted", "mMinSkillAccepted", 0xCEBB6E00, TdfType.Int32, 1, true), // SKMN
        new TdfMemberInfo("MaxSkillAccepted", "mMaxSkillAccepted", 0xCEBB7800, TdfType.Int32, 2, true), // SKMX
    ];
    private ITdfMember[] __members;

    private TdfString _ruleName = new(__typeInfos[0]);
    private TdfInt32 _minSkillAccepted = new(__typeInfos[1]);
    private TdfInt32 _maxSkillAccepted = new(__typeInfos[2]);

    public SkillRuleStatus()
    {
        __members = [
            _ruleName,
            _minSkillAccepted,
            _maxSkillAccepted,
        ];
    }

    public override Tdf CreateNew() => new SkillRuleStatus();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "SkillRuleStatus";
    public override string GetFullClassName() => "Blaze::GameManager::SkillRuleStatus";

    public string RuleName
    {
        get => _ruleName.Value;
        set => _ruleName.Value = value;
    }

    public int MinSkillAccepted
    {
        get => _minSkillAccepted.Value;
        set => _minSkillAccepted.Value = value;
    }

    public int MaxSkillAccepted
    {
        get => _maxSkillAccepted.Value;
        set => _maxSkillAccepted.Value = value;
    }

}

