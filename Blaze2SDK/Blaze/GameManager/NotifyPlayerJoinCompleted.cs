using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class NotifyPlayerJoinCompleted : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameId", "mGameId", 0x9E990000, TdfType.UInt32, 0, true), // GID
        new TdfMemberInfo("PlayerId", "mPlayerId", 0xC2990000, TdfType.UInt32, 1, true), // PID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _gameId = new(__typeInfos[0]);
    private TdfUInt32 _playerId = new(__typeInfos[1]);

    public NotifyPlayerJoinCompleted()
    {
        __members = [
            _gameId,
            _playerId,
        ];
    }

    public override Tdf CreateNew() => new NotifyPlayerJoinCompleted();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NotifyPlayerJoinCompleted";
    public override string GetFullClassName() => "Blaze::GameManager::NotifyPlayerJoinCompleted";

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

}

