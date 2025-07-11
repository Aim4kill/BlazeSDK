using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class TeamSizeStatus : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("TeamId", "mTeamId", 0xD2586D00, TdfType.UInt16, 0, true), // TEAM
        new TdfMemberInfo("MaxTeamSizeAccepted", "mMaxTeamSizeAccepted", 0xD2D87800, TdfType.UInt16, 1, true), // TMAX
        new TdfMemberInfo("MinTeamSizeAccepted", "mMinTeamSizeAccepted", 0xD2DA6E00, TdfType.UInt16, 2, true), // TMIN
    ];
    private ITdfMember[] __members;

    private TdfUInt16 _teamId = new(__typeInfos[0]);
    private TdfUInt16 _maxTeamSizeAccepted = new(__typeInfos[1]);
    private TdfUInt16 _minTeamSizeAccepted = new(__typeInfos[2]);

    public TeamSizeStatus()
    {
        __members = [
            _teamId,
            _maxTeamSizeAccepted,
            _minTeamSizeAccepted,
        ];
    }

    public override Tdf CreateNew() => new TeamSizeStatus();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "TeamSizeStatus";
    public override string GetFullClassName() => "Blaze::GameManager::TeamSizeStatus";

    public ushort TeamId
    {
        get => _teamId.Value;
        set => _teamId.Value = value;
    }

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

