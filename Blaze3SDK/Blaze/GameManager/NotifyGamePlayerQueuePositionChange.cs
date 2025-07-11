using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class NotifyGamePlayerQueuePositionChange : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameId", "mGameId", 0x9E990000, TdfType.UInt32, 0, true), // GID
        new TdfMemberInfo("PlayerId", "mPlayerId", 0xC2990000, TdfType.Int64, 1, true), // PID
        new TdfMemberInfo("QueueIndex", "mQueueIndex", 0xC6990000, TdfType.UInt8, 2, true), // QID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _gameId = new(__typeInfos[0]);
    private TdfInt64 _playerId = new(__typeInfos[1]);
    private TdfUInt8 _queueIndex = new(__typeInfos[2]);

    public NotifyGamePlayerQueuePositionChange()
    {
        __members = [
            _gameId,
            _playerId,
            _queueIndex,
        ];
    }

    public override Tdf CreateNew() => new NotifyGamePlayerQueuePositionChange();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NotifyGamePlayerQueuePositionChange";
    public override string GetFullClassName() => "Blaze::GameManager::NotifyGamePlayerQueuePositionChange";

    public uint GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public long PlayerId
    {
        get => _playerId.Value;
        set => _playerId.Value = value;
    }

    public byte QueueIndex
    {
        get => _queueIndex.Value;
        set => _queueIndex.Value = value;
    }

}

