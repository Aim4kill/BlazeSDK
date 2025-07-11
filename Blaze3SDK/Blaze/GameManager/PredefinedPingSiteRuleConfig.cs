using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class PredefinedPingSiteRuleConfig : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("PredefinedRuleConfig", "mPredefinedRuleConfig", 0xC24CA300, TdfType.Struct, 0, true), // PDRC
        new TdfMemberInfo("PossibleValues", "mPossibleValues", 0xC2FCF600, TdfType.List, 1, true), // POSV
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze3SDK.Blaze.GameManager.PredefinedRuleConfig?> _predefinedRuleConfig = new(__typeInfos[0]);
    private TdfList<string> _possibleValues = new(__typeInfos[1]);

    public PredefinedPingSiteRuleConfig()
    {
        __members = [
            _predefinedRuleConfig,
            _possibleValues,
        ];
    }

    public override Tdf CreateNew() => new PredefinedPingSiteRuleConfig();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PredefinedPingSiteRuleConfig";
    public override string GetFullClassName() => "Blaze::GameManager::PredefinedPingSiteRuleConfig";

    public Blaze3SDK.Blaze.GameManager.PredefinedRuleConfig? PredefinedRuleConfig
    {
        get => _predefinedRuleConfig.Value;
        set => _predefinedRuleConfig.Value = value;
    }

    public IList<string> PossibleValues
    {
        get => _possibleValues.Value;
        set => _possibleValues.Value = value;
    }

}

