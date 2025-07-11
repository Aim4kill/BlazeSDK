using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class TeamSizeRulePrefs : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MaxTeamSizeDifferenceAllowed", "mMaxTeamSizeDifferenceAllowed", 0xCE4A6600, TdfType.UInt16, 0, true), // SDIF
        new TdfMemberInfo("RangeOffsetListName", "mRangeOffsetListName", 0xD28B2400, TdfType.String, 1, true), // THLD
        new TdfMemberInfo("TeamId", "mTeamId", 0xD2990000, TdfType.UInt16, 2, true), // TID
        new TdfMemberInfo("TeamSizeRequirementsVector", "mTeamSizeRequirementsVector", 0xD2D87000, TdfType.List, 3, true), // TMAP
    ];
    private ITdfMember[] __members;

    private TdfUInt16 _maxTeamSizeDifferenceAllowed = new(__typeInfos[0]);
    private TdfString _rangeOffsetListName = new(__typeInfos[1]);
    private TdfUInt16 _teamId = new(__typeInfos[2]);
    private TdfList<Blaze2SDK.Blaze.GameManager.TeamSizeRequirements> _teamSizeRequirementsVector = new(__typeInfos[3]);

    public TeamSizeRulePrefs()
    {
        __members = [
            _maxTeamSizeDifferenceAllowed,
            _rangeOffsetListName,
            _teamId,
            _teamSizeRequirementsVector,
        ];
    }

    public override Tdf CreateNew() => new TeamSizeRulePrefs();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "TeamSizeRulePrefs";
    public override string GetFullClassName() => "Blaze::GameManager::TeamSizeRulePrefs";

    public ushort MaxTeamSizeDifferenceAllowed
    {
        get => _maxTeamSizeDifferenceAllowed.Value;
        set => _maxTeamSizeDifferenceAllowed.Value = value;
    }

    public string RangeOffsetListName
    {
        get => _rangeOffsetListName.Value;
        set => _rangeOffsetListName.Value = value;
    }

    public ushort TeamId
    {
        get => _teamId.Value;
        set => _teamId.Value = value;
    }

    public IList<Blaze2SDK.Blaze.GameManager.TeamSizeRequirements> TeamSizeRequirementsVector
    {
        get => _teamSizeRequirementsVector.Value;
        set => _teamSizeRequirementsVector.Value = value;
    }

}

