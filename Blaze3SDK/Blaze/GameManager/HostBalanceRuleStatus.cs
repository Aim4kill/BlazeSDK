using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class HostBalanceRuleStatus : Tdf
{
    public enum HostBalanceValues : int
    {
        HOSTS_STRICTLY_BALANCED = 0,
        HOSTS_BALANCED = 1,
        HOSTS_UNBALANCED = 2,
    }
    
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MatchedHostBalanceValue", "mMatchedHostBalanceValue", 0x8B686C00, TdfType.Enum, 0, true), // BVAL
    ];
    private ITdfMember[] __members;

    private TdfEnum<Blaze3SDK.Blaze.GameManager.HostBalanceRuleStatus.HostBalanceValues> _matchedHostBalanceValue = new(__typeInfos[0]);

    public HostBalanceRuleStatus()
    {
        __members = [
            _matchedHostBalanceValue,
        ];
    }

    public override Tdf CreateNew() => new HostBalanceRuleStatus();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "HostBalanceRuleStatus";
    public override string GetFullClassName() => "Blaze::GameManager::HostBalanceRuleStatus";

    public Blaze3SDK.Blaze.GameManager.HostBalanceRuleStatus.HostBalanceValues MatchedHostBalanceValue
    {
        get => _matchedHostBalanceValue.Value;
        set => _matchedHostBalanceValue.Value = value;
    }

}

