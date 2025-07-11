using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class GetMatchmakingConfigResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GenericRules", "mGenericRules", 0x9ECCF400, TdfType.List, 0, true), // GLST
        new TdfMemberInfo("PingSiteRule", "mPingSiteRule", 0xC30CF200, TdfType.Struct, 1, true), // PPSR
        new TdfMemberInfo("PredefinedRules", "mPredefinedRules", 0xCACCF400, TdfType.List, 2, true), // RLST
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze2SDK.Blaze.GameManager.GenericRuleConfig> _genericRules = new(__typeInfos[0]);
    private TdfStruct<Blaze2SDK.Blaze.GameManager.PredefinedPingSiteRuleConfig?> _pingSiteRule = new(__typeInfos[1]);
    private TdfList<Blaze2SDK.Blaze.GameManager.PredefinedRuleConfig> _predefinedRules = new(__typeInfos[2]);

    public GetMatchmakingConfigResponse()
    {
        __members = [
            _genericRules,
            _pingSiteRule,
            _predefinedRules,
        ];
    }

    public override Tdf CreateNew() => new GetMatchmakingConfigResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetMatchmakingConfigResponse";
    public override string GetFullClassName() => "Blaze::GameManager::GetMatchmakingConfigResponse";

    public IList<Blaze2SDK.Blaze.GameManager.GenericRuleConfig> GenericRules
    {
        get => _genericRules.Value;
        set => _genericRules.Value = value;
    }

    public Blaze2SDK.Blaze.GameManager.PredefinedPingSiteRuleConfig? PingSiteRule
    {
        get => _pingSiteRule.Value;
        set => _pingSiteRule.Value = value;
    }

    public IList<Blaze2SDK.Blaze.GameManager.PredefinedRuleConfig> PredefinedRules
    {
        get => _predefinedRules.Value;
        set => _predefinedRules.Value = value;
    }

}

