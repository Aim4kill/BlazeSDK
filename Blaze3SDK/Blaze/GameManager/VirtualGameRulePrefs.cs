using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class VirtualGameRulePrefs : Tdf
{
    public enum VirtualGameDesiredValue : int
    {
        STANDARD = 1,
        VIRTUALIZED = 2,
        ABSTAIN = 8,
    }
    
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MinFitThresholdName", "mMinFitThresholdName", 0xD28B2400, TdfType.String, 0, true), // THLD
        new TdfMemberInfo("DesiredVirtualGameValue", "mDesiredVirtualGameValue", 0xDA1B3500, TdfType.Enum, 1, true), // VALU
    ];
    private ITdfMember[] __members;

    private TdfString _minFitThresholdName = new(__typeInfos[0]);
    private TdfEnum<Blaze3SDK.Blaze.GameManager.VirtualGameRulePrefs.VirtualGameDesiredValue> _desiredVirtualGameValue = new(__typeInfos[1]);

    public VirtualGameRulePrefs()
    {
        __members = [
            _minFitThresholdName,
            _desiredVirtualGameValue,
        ];
    }

    public override Tdf CreateNew() => new VirtualGameRulePrefs();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "VirtualGameRulePrefs";
    public override string GetFullClassName() => "Blaze::GameManager::VirtualGameRulePrefs";

    public string MinFitThresholdName
    {
        get => _minFitThresholdName.Value;
        set => _minFitThresholdName.Value = value;
    }

    public Blaze3SDK.Blaze.GameManager.VirtualGameRulePrefs.VirtualGameDesiredValue DesiredVirtualGameValue
    {
        get => _desiredVirtualGameValue.Value;
        set => _desiredVirtualGameValue.Value = value;
    }

}

