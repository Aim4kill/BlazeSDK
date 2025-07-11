using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class TeamSizeRuleStatus : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AcceptableTeamSizeVector", "mAcceptableTeamSizeVector", 0xD2586D00, TdfType.List, 0, true), // TEAM
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze2SDK.Blaze.GameManager.TeamSizeStatus> _acceptableTeamSizeVector = new(__typeInfos[0]);

    public TeamSizeRuleStatus()
    {
        __members = [
            _acceptableTeamSizeVector,
        ];
    }

    public override Tdf CreateNew() => new TeamSizeRuleStatus();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "TeamSizeRuleStatus";
    public override string GetFullClassName() => "Blaze::GameManager::TeamSizeRuleStatus";

    public IList<Blaze2SDK.Blaze.GameManager.TeamSizeStatus> AcceptableTeamSizeVector
    {
        get => _acceptableTeamSizeVector.Value;
        set => _acceptableTeamSizeVector.Value = value;
    }

}

