using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class GameSizeRulePrefs : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("IsSingleGroupMatch", "mIsSingleGroupMatch", 0xA73CE700, TdfType.UInt8, 0, true), // ISSG
        new TdfMemberInfo("MaxPlayerCapacity", "mMaxPlayerCapacity", 0xC2387000, TdfType.UInt16, 1, true), // PCAP
        new TdfMemberInfo("DesiredPlayerCount", "mDesiredPlayerCount", 0xC23BB400, TdfType.UInt16, 2, true), // PCNT
        new TdfMemberInfo("MinPlayerCount", "mMinPlayerCount", 0xC2DA6E00, TdfType.UInt16, 3, true), // PMIN
        new TdfMemberInfo("MinFitThresholdName", "mMinFitThresholdName", 0xD28B2400, TdfType.String, 4, true), // THLD
    ];
    private ITdfMember[] __members;

    private TdfUInt8 _isSingleGroupMatch = new(__typeInfos[0]);
    private TdfUInt16 _maxPlayerCapacity = new(__typeInfos[1]);
    private TdfUInt16 _desiredPlayerCount = new(__typeInfos[2]);
    private TdfUInt16 _minPlayerCount = new(__typeInfos[3]);
    private TdfString _minFitThresholdName = new(__typeInfos[4]);

    public GameSizeRulePrefs()
    {
        __members = [
            _isSingleGroupMatch,
            _maxPlayerCapacity,
            _desiredPlayerCount,
            _minPlayerCount,
            _minFitThresholdName,
        ];
    }

    public override Tdf CreateNew() => new GameSizeRulePrefs();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GameSizeRulePrefs";
    public override string GetFullClassName() => "Blaze::GameManager::GameSizeRulePrefs";

    public byte IsSingleGroupMatch
    {
        get => _isSingleGroupMatch.Value;
        set => _isSingleGroupMatch.Value = value;
    }

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

    public string MinFitThresholdName
    {
        get => _minFitThresholdName.Value;
        set => _minFitThresholdName.Value = value;
    }

}

