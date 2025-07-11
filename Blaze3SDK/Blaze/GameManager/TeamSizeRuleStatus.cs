using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class TeamSizeRuleStatus : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MaxTeamSizeAccepted", "mMaxTeamSizeAccepted", 0xD2D87800, TdfType.UInt16, 0, true), // TMAX
        new TdfMemberInfo("MinTeamSizeAccepted", "mMinTeamSizeAccepted", 0xD2DA6E00, TdfType.UInt16, 1, true), // TMIN
    ];
    private ITdfMember[] __members;

    private TdfUInt16 _maxTeamSizeAccepted = new(__typeInfos[0]);
    private TdfUInt16 _minTeamSizeAccepted = new(__typeInfos[1]);

    public TeamSizeRuleStatus()
    {
        __members = [
            _maxTeamSizeAccepted,
            _minTeamSizeAccepted,
        ];
    }

    public override Tdf CreateNew() => new TeamSizeRuleStatus();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "TeamSizeRuleStatus";
    public override string GetFullClassName() => "Blaze::GameManager::TeamSizeRuleStatus";

    public ushort MaxTeamSizeAccepted
    {
        get => _maxTeamSizeAccepted.Value;
        set => _maxTeamSizeAccepted.Value = value;
    }

    public ushort MinTeamSizeAccepted
    {
        get => _minTeamSizeAccepted.Value;
        set => _minTeamSizeAccepted.Value = value;
    }

}

