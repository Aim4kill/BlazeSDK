using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class TeamSizeRequirements : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MaxPlayerCapacity", "mMaxPlayerCapacity", 0xC2387000, TdfType.UInt16, 0, true), // PCAP
        new TdfMemberInfo("DesiredPlayerCount", "mDesiredPlayerCount", 0xC23BB400, TdfType.UInt16, 1, true), // PCNT
        new TdfMemberInfo("MinPlayerCount", "mMinPlayerCount", 0xC2DA6E00, TdfType.UInt16, 2, true), // PMIN
        new TdfMemberInfo("TeamId", "mTeamId", 0xD2990000, TdfType.UInt16, 3, true), // TID
    ];
    private ITdfMember[] __members;

    private TdfUInt16 _maxPlayerCapacity = new(__typeInfos[0]);
    private TdfUInt16 _desiredPlayerCount = new(__typeInfos[1]);
    private TdfUInt16 _minPlayerCount = new(__typeInfos[2]);
    private TdfUInt16 _teamId = new(__typeInfos[3]);

    public TeamSizeRequirements()
    {
        __members = [
            _maxPlayerCapacity,
            _desiredPlayerCount,
            _minPlayerCount,
            _teamId,
        ];
    }

    public override Tdf CreateNew() => new TeamSizeRequirements();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "TeamSizeRequirements";
    public override string GetFullClassName() => "Blaze::GameManager::TeamSizeRequirements";

    public ushort MaxPlayerCapacity
    {
        get => _maxPlayerCapacity.Value;
        set => _maxPlayerCapacity.Value = value;
    }

    public ushort DesiredPlayerCount
    {
        get => _desiredPlayerCount.Value;
        set => _desiredPlayerCount.Value = value;
    }

    public ushort MinPlayerCount
    {
        get => _minPlayerCount.Value;
        set => _minPlayerCount.Value = value;
    }

    public ushort TeamId
    {
        get => _teamId.Value;
        set => _teamId.Value = value;
    }

}

