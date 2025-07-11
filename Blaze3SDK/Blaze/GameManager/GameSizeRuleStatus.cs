using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class GameSizeRuleStatus : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MaxPlayerCountAccepted", "mMaxPlayerCountAccepted", 0xC2D87800, TdfType.UInt32, 0, true), // PMAX
        new TdfMemberInfo("MinPlayerCountAccepted", "mMinPlayerCountAccepted", 0xC2DA6E00, TdfType.UInt32, 1, true), // PMIN
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _maxPlayerCountAccepted = new(__typeInfos[0]);
    private TdfUInt32 _minPlayerCountAccepted = new(__typeInfos[1]);

    public GameSizeRuleStatus()
    {
        __members = [
            _maxPlayerCountAccepted,
            _minPlayerCountAccepted,
        ];
    }

    public override Tdf CreateNew() => new GameSizeRuleStatus();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GameSizeRuleStatus";
    public override string GetFullClassName() => "Blaze::GameManager::GameSizeRuleStatus";

    public uint MaxPlayerCountAccepted
    {
        get => _maxPlayerCountAccepted.Value;
        set => _maxPlayerCountAccepted.Value = value;
    }

    public uint MinPlayerCountAccepted
    {
        get => _minPlayerCountAccepted.Value;
        set => _minPlayerCountAccepted.Value = value;
    }

}

