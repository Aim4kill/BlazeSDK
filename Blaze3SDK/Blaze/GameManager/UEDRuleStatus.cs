using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class UEDRuleStatus : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MaxUEDAccepted", "mMaxUEDAccepted", 0x86D87800, TdfType.Int64, 0, true), // AMAX
        new TdfMemberInfo("MinUEDAccepted", "mMinUEDAccepted", 0x86DA6E00, TdfType.Int64, 1, true), // AMIN
        new TdfMemberInfo("MyUEDValue", "mMyUEDValue", 0xB7596400, TdfType.Int64, 2, true), // MUED
        new TdfMemberInfo("RuleName", "mRuleName", 0xBA1B6500, TdfType.String, 3, true), // NAME
    ];
    private ITdfMember[] __members;

    private TdfInt64 _maxUEDAccepted = new(__typeInfos[0]);
    private TdfInt64 _minUEDAccepted = new(__typeInfos[1]);
    private TdfInt64 _myUEDValue = new(__typeInfos[2]);
    private TdfString _ruleName = new(__typeInfos[3]);

    public UEDRuleStatus()
    {
        __members = [
            _maxUEDAccepted,
            _minUEDAccepted,
            _myUEDValue,
            _ruleName,
        ];
    }

    public override Tdf CreateNew() => new UEDRuleStatus();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UEDRuleStatus";
    public override string GetFullClassName() => "Blaze::GameManager::UEDRuleStatus";

    public long MaxUEDAccepted
    {
        get => _maxUEDAccepted.Value;
        set => _maxUEDAccepted.Value = value;
    }

    public long MinUEDAccepted
    {
        get => _minUEDAccepted.Value;
        set => _minUEDAccepted.Value = value;
    }

    public long MyUEDValue
    {
        get => _myUEDValue.Value;
        set => _myUEDValue.Value = value;
    }

    public string RuleName
    {
        get => _ruleName.Value;
        set => _ruleName.Value = value;
    }

}

