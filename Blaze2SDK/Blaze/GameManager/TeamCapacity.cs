using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class TeamCapacity : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("TeamCapacity", "mTeamCapacity", 0xD2387000, TdfType.UInt16, 0, true), // TCAP
        new TdfMemberInfo("TeamId", "mTeamId", 0xD2990000, TdfType.UInt16, 1, true), // TID
        new TdfMemberInfo("TeamIndex", "mTeamIndex", 0xD2993800, TdfType.UInt16, 2, true), // TIDX
    ];
    private ITdfMember[] __members;

    private TdfUInt16 _teamCapacity = new(__typeInfos[0]);
    private TdfUInt16 _teamId = new(__typeInfos[1]);
    private TdfUInt16 _teamIndex = new(__typeInfos[2]);

    public TeamCapacity()
    {
        __members = [
            _teamCapacity,
            _teamId,
            _teamIndex,
        ];
    }

    public override Tdf CreateNew() => new TeamCapacity();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "TeamCapacity";
    public override string GetFullClassName() => "Blaze::GameManager::TeamCapacity";

    public ushort mTeamCapacity
    {
        get => _teamCapacity.Value;
        set => _teamCapacity.Value = value;
    }

    public ushort TeamId
    {
        get => _teamId.Value;
        set => _teamId.Value = value;
    }

    public ushort TeamIndex
    {
        get => _teamIndex.Value;
        set => _teamIndex.Value = value;
    }

}

