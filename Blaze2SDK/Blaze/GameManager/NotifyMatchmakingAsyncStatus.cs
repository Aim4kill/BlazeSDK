using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class NotifyMatchmakingAsyncStatus : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MatchmakingAsyncStatusList", "mMatchmakingAsyncStatusList", 0x873A6C00, TdfType.List, 0, true), // ASIL
        new TdfMemberInfo("MatchmakingSessionId", "mMatchmakingSessionId", 0xB73A6400, TdfType.UInt32, 1, true), // MSID
        new TdfMemberInfo("UserSessionId", "mUserSessionId", 0xD73A6400, TdfType.UInt32, 2, true), // USID
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze2SDK.Blaze.GameManager.MatchmakingAsyncStatus> _matchmakingAsyncStatusList = new(__typeInfos[0]);
    private TdfUInt32 _matchmakingSessionId = new(__typeInfos[1]);
    private TdfUInt32 _userSessionId = new(__typeInfos[2]);

    public NotifyMatchmakingAsyncStatus()
    {
        __members = [
            _matchmakingAsyncStatusList,
            _matchmakingSessionId,
            _userSessionId,
        ];
    }

    public override Tdf CreateNew() => new NotifyMatchmakingAsyncStatus();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NotifyMatchmakingAsyncStatus";
    public override string GetFullClassName() => "Blaze::GameManager::NotifyMatchmakingAsyncStatus";

    public IList<Blaze2SDK.Blaze.GameManager.MatchmakingAsyncStatus> MatchmakingAsyncStatusList
    {
        get => _matchmakingAsyncStatusList.Value;
        set => _matchmakingAsyncStatusList.Value = value;
    }

    public uint MatchmakingSessionId
    {
        get => _matchmakingSessionId.Value;
        set => _matchmakingSessionId.Value = value;
    }

    public uint UserSessionId
    {
        get => _userSessionId.Value;
        set => _userSessionId.Value = value;
    }

}

