using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class RankedGameRulePrefs : Tdf
{
    public enum RankedGameDesiredValue : int
    {
        UNRANKED = 1,
        RANKED = 2,
        RANDOM = 4,
        ABSTAIN = 8,
    }
    
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MinFitThresholdName", "mMinFitThresholdName", 0xD28B2400, TdfType.String, 0, true), // THLD
        new TdfMemberInfo("DesiredRankedGameValue", "mDesiredRankedGameValue", 0xDA1B3500, TdfType.Enum, 1, true), // VALU
    ];
    private ITdfMember[] __members;

    private TdfString _minFitThresholdName = new(__typeInfos[0]);
    private TdfEnum<Blaze2SDK.Blaze.GameManager.RankedGameRulePrefs.RankedGameDesiredValue> _desiredRankedGameValue = new(__typeInfos[1]);

    public RankedGameRulePrefs()
    {
        __members = [
            _minFitThresholdName,
            _desiredRankedGameValue,
        ];
    }

    public override Tdf CreateNew() => new RankedGameRulePrefs();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "RankedGameRulePrefs";
    public override string GetFullClassName() => "Blaze::GameManager::RankedGameRulePrefs";

    public string MinFitThresholdName
    {
        get => _minFitThresholdName.Value;
        set => _minFitThresholdName.Value = value;
    }

    public Blaze2SDK.Blaze.GameManager.RankedGameRulePrefs.RankedGameDesiredValue DesiredRankedGameValue
    {
        get => _desiredRankedGameValue.Value;
        set => _desiredRankedGameValue.Value = value;
    }

}

