using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class RosterSizeRulePrefs : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MaxPlayerCount", "mMaxPlayerCount", 0xC2387000, TdfType.UInt16, 0, true), // PCAP
        new TdfMemberInfo("MinPlayerCount", "mMinPlayerCount", 0xC2DA6E00, TdfType.UInt16, 1, true), // PMIN
    ];
    private ITdfMember[] __members;

    private TdfUInt16 _maxPlayerCount = new(__typeInfos[0]);
    private TdfUInt16 _minPlayerCount = new(__typeInfos[1]);

    public RosterSizeRulePrefs()
    {
        __members = [
            _maxPlayerCount,
            _minPlayerCount,
        ];
    }

    public override Tdf CreateNew() => new RosterSizeRulePrefs();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "RosterSizeRulePrefs";
    public override string GetFullClassName() => "Blaze::GameManager::RosterSizeRulePrefs";

    public ushort MaxPlayerCount
    {
        get => _maxPlayerCount.Value;
        set => _maxPlayerCount.Value = value;
    }

    public ushort MinPlayerCount
    {
        get => _minPlayerCount.Value;
        set => _minPlayerCount.Value = value;
    }

}

