using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class RankRuleStatus : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MatchedRankFlags", "mMatchedRankFlags", 0xCB686C00, TdfType.UInt8, 0, true), // RVAL
    ];
    private ITdfMember[] __members;

    private TdfUInt8 _matchedRankFlags = new(__typeInfos[0]);

    public RankRuleStatus()
    {
        __members = [
            _matchedRankFlags,
        ];
    }

    public override Tdf CreateNew() => new RankRuleStatus();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "RankRuleStatus";
    public override string GetFullClassName() => "Blaze::GameManager::RankRuleStatus";

    public byte MatchedRankFlags
    {
        get => _matchedRankFlags.Value;
        set => _matchedRankFlags.Value = value;
    }

}

