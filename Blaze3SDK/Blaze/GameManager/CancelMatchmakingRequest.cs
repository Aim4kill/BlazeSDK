using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class CancelMatchmakingRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MatchmakingSessionId", "mMatchmakingSessionId", 0xB73A6400, TdfType.UInt32, 0, true), // MSID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _matchmakingSessionId = new(__typeInfos[0]);

    public CancelMatchmakingRequest()
    {
        __members = [
            _matchmakingSessionId,
        ];
    }

    public override Tdf CreateNew() => new CancelMatchmakingRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "CancelMatchmakingRequest";
    public override string GetFullClassName() => "Blaze::GameManager::CancelMatchmakingRequest";

    public uint MatchmakingSessionId
    {
        get => _matchmakingSessionId.Value;
        set => _matchmakingSessionId.Value = value;
    }

}

