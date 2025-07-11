using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class NotifyGroupPreJoinedGame : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameId", "mGameId", 0x9E990000, TdfType.UInt32, 0, true), // GID
        new TdfMemberInfo("UserGroupId", "mUserGroupId", 0x9F2A6400, TdfType.UInt64, 1, true), // GRID
        new TdfMemberInfo("JoinMethod", "mJoinMethod", 0xAAD97400, TdfType.Enum, 2, true), // JMET
        new TdfMemberInfo("MatchmakingSessionId", "mMatchmakingSessionId", 0xB6DA6400, TdfType.UInt32, 3, true), // MMID
        new TdfMemberInfo("UserSessionId", "mUserSessionId", 0xCE990000, TdfType.UInt32, 4, true), // SID
        new TdfMemberInfo("RequestedSlotType", "mRequestedSlotType", 0xCECBF400, TdfType.Enum, 5, true), // SLOT
        new TdfMemberInfo("JoiningTeamId", "mJoiningTeamId", 0xD2586D00, TdfType.UInt16, 6, true), // TEAM
        new TdfMemberInfo("JoiningTeamIndex", "mJoiningTeamIndex", 0xD2993800, TdfType.UInt16, 7, true), // TIDX
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _gameId = new(__typeInfos[0]);
    private TdfUInt64 _userGroupId = new(__typeInfos[1]);
    private TdfEnum<Blaze2SDK.Blaze.GameManager.JoinMethod> _joinMethod = new(__typeInfos[2]);
    private TdfUInt32 _matchmakingSessionId = new(__typeInfos[3]);
    private TdfUInt32 _userSessionId = new(__typeInfos[4]);
    private TdfEnum<Blaze2SDK.Blaze.GameManager.SlotType> _requestedSlotType = new(__typeInfos[5]);
    private TdfUInt16 _joiningTeamId = new(__typeInfos[6]);
    private TdfUInt16 _joiningTeamIndex = new(__typeInfos[7]);

    public NotifyGroupPreJoinedGame()
    {
        __members = [
            _gameId,
            _userGroupId,
            _joinMethod,
            _matchmakingSessionId,
            _userSessionId,
            _requestedSlotType,
            _joiningTeamId,
            _joiningTeamIndex,
        ];
    }

    public override Tdf CreateNew() => new NotifyGroupPreJoinedGame();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NotifyGroupPreJoinedGame";
    public override string GetFullClassName() => "Blaze::GameManager::NotifyGroupPreJoinedGame";

    public uint GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public ulong UserGroupId
    {
        get => _userGroupId.Value;
        set => _userGroupId.Value = value;
    }

    public Blaze2SDK.Blaze.GameManager.JoinMethod JoinMethod
    {
        get => _joinMethod.Value;
        set => _joinMethod.Value = value;
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

    public Blaze2SDK.Blaze.GameManager.SlotType RequestedSlotType
    {
        get => _requestedSlotType.Value;
        set => _requestedSlotType.Value = value;
    }

    public ushort JoiningTeamId
    {
        get => _joiningTeamId.Value;
        set => _joiningTeamId.Value = value;
    }

    public ushort JoiningTeamIndex
    {
        get => _joiningTeamIndex.Value;
        set => _joiningTeamIndex.Value = value;
    }

}

