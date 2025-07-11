using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class NotifyGamePlayerStateChange : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameId", "mGameId", 0x9E990000, TdfType.UInt32, 0, true), // GID
        new TdfMemberInfo("PlayerId", "mPlayerId", 0xC2990000, TdfType.UInt32, 1, true), // PID
        new TdfMemberInfo("PlayerState", "mPlayerState", 0xCF487400, TdfType.Enum, 2, true), // STAT
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _gameId = new(__typeInfos[0]);
    private TdfUInt32 _playerId = new(__typeInfos[1]);
    private TdfEnum<Blaze2SDK.Blaze.GameManager.PlayerState> _playerState = new(__typeInfos[2]);

    public NotifyGamePlayerStateChange()
    {
        __members = [
            _gameId,
            _playerId,
            _playerState,
        ];
    }

    public override Tdf CreateNew() => new NotifyGamePlayerStateChange();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NotifyGamePlayerStateChange";
    public override string GetFullClassName() => "Blaze::GameManager::NotifyGamePlayerStateChange";

    public uint GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public uint PlayerId
    {
        get => _playerId.Value;
        set => _playerId.Value = value;
    }

    public Blaze2SDK.Blaze.GameManager.PlayerState PlayerState
    {
        get => _playerState.Value;
        set => _playerState.Value = value;
    }

}

