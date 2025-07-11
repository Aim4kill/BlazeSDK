using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class MatchmakingCustomAsyncStatus : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
    ];
    private ITdfMember[] __members;


    public MatchmakingCustomAsyncStatus()
    {
        __members = [
        ];
    }

    public override Tdf CreateNew() => new MatchmakingCustomAsyncStatus();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "MatchmakingCustomAsyncStatus";
    public override string GetFullClassName() => "Blaze::GameManager::MatchmakingCustomAsyncStatus";

}

