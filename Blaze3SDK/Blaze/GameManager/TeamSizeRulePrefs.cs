using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class TeamSizeRulePrefs : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MaxPlayerCapacity", "mMaxPlayerCapacity", 0xC2387000, TdfType.UInt16, 0, true), // PCAP
        new TdfMemberInfo("DesiredPlayerCount", "mDesiredPlayerCount", 0xC23BB400, TdfType.UInt16, 1, true), // PCNT
        new TdfMemberInfo("MinPlayerCount", "mMinPlayerCount", 0xC2DA6E00, TdfType.UInt16, 2, true), // PMIN
        new TdfMemberInfo("MaxTeamSizeDifferenceAllowed", "mMaxTeamSizeDifferenceAllowed", 0xCE4A6600, TdfType.UInt16, 3, true), // SDIF
        new TdfMemberInfo("RangeOffsetListName", "mRangeOffsetListName", 0xD28B2400, TdfType.String, 4, true), // THLD
        new TdfMemberInfo("TeamId", "mTeamId", 0xD2990000, TdfType.UInt16, 5, true), // TID
        new TdfMemberInfo("TeamIdVector", "mTeamIdVector", 0xD2CCF400, TdfType.List, 6, true), // TLST
    ];
    private ITdfMember[] __members;

    private TdfUInt16 _maxPlayerCapacity = new(__typeInfos[0]);
    private TdfUInt16 _desiredPlayerCount = new(__typeInfos[1]);
    private TdfUInt16 _minPlayerCount = new(__typeInfos[2]);
    private TdfUInt16 _maxTeamSizeDifferenceAllowed = new(__typeInfos[3]);
    private TdfString _rangeOffsetListName = new(__typeInfos[4]);
    private TdfUInt16 _teamId = new(__typeInfos[5]);
    private TdfList<ushort> _teamIdVector = new(__typeInfos[6]);

    public TeamSizeRulePrefs()
    {
        __members = [
            _maxPlayerCapacity,
            _desiredPlayerCount,
            _minPlayerCount,
            _maxTeamSizeDifferenceAllowed,
            _rangeOffsetListName,
            _teamId,
            _teamIdVector,
        ];
    }

    public override Tdf CreateNew() => new TeamSizeRulePrefs();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "TeamSizeRulePrefs";
    public override string GetFullClassName() => "Blaze::GameManager::TeamSizeRulePrefs";

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

    public IList<ushort> TeamIdVector
    {
        get => _teamIdVector.Value;
        set => _teamIdVector.Value = value;
    }

}

