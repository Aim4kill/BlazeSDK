using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class NotifyJoinGame : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("JoinErr", "mJoinErr", 0x972C8000, TdfType.UInt32, 0, true), // ERR
        new TdfMemberInfo("GameData", "mGameData", 0x9E1B6500, TdfType.Struct, 1, true), // GAME
        new TdfMemberInfo("MatchmakingSessionId", "mMatchmakingSessionId", 0xB6DA6400, TdfType.UInt32, 2, true), // MMID
        new TdfMemberInfo("GameRoster", "mGameRoster", 0xC32BF300, TdfType.List, 3, true), // PROS
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _joinErr = new(__typeInfos[0]);
    private TdfStruct<Blaze2SDK.Blaze.GameManager.ReplicatedGameData?> _gameData = new(__typeInfos[1]);
    private TdfUInt32 _matchmakingSessionId = new(__typeInfos[2]);
    private TdfList<Blaze2SDK.Blaze.GameManager.ReplicatedGamePlayer> _gameRoster = new(__typeInfos[3]);

    public NotifyJoinGame()
    {
        __members = [
            _joinErr,
            _gameData,
            _matchmakingSessionId,
            _gameRoster,
        ];
    }

    public override Tdf CreateNew() => new NotifyJoinGame();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NotifyJoinGame";
    public override string GetFullClassName() => "Blaze::GameManager::NotifyJoinGame";

    public uint JoinErr
    {
        get => _joinErr.Value;
        set => _joinErr.Value = value;
    }

    public Blaze2SDK.Blaze.GameManager.ReplicatedGameData? GameData
    {
        get => _gameData.Value;
        set => _gameData.Value = value;
    }

    public uint MatchmakingSessionId
    {
        get => _matchmakingSessionId.Value;
        set => _matchmakingSessionId.Value = value;
    }

    public IList<Blaze2SDK.Blaze.GameManager.ReplicatedGamePlayer> GameRoster
    {
        get => _gameRoster.Value;
        set => _gameRoster.Value = value;
    }

}

