using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class VirtualGameRuleStatus : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MatchedVirtualizedFlags", "mMatchedVirtualizedFlags", 0xDB686C00, TdfType.UInt8, 0, true), // VVAL
    ];
    private ITdfMember[] __members;

    private TdfUInt8 _matchedVirtualizedFlags = new(__typeInfos[0]);

    public VirtualGameRuleStatus()
    {
        __members = [
            _matchedVirtualizedFlags,
        ];
    }

    public override Tdf CreateNew() => new VirtualGameRuleStatus();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "VirtualGameRuleStatus";
    public override string GetFullClassName() => "Blaze::GameManager::VirtualGameRuleStatus";

    public byte MatchedVirtualizedFlags
    {
        get => _matchedVirtualizedFlags.Value;
        set => _matchedVirtualizedFlags.Value = value;
    }

}

