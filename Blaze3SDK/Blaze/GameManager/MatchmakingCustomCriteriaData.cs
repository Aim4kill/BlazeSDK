using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class MatchmakingCustomCriteriaData : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
    ];
    private ITdfMember[] __members;


    public MatchmakingCustomCriteriaData()
    {
        __members = [
        ];
    }

    public override Tdf CreateNew() => new MatchmakingCustomCriteriaData();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "MatchmakingCustomCriteriaData";
    public override string GetFullClassName() => "Blaze::GameManager::MatchmakingCustomCriteriaData";

}

