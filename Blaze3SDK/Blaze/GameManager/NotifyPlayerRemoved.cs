using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class NotifyPlayerRemoved : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("PlayerRemovedTitleContext", "mPlayerRemovedTitleContext", 0x8EED3800, TdfType.UInt16, 0, true), // CNTX
        new TdfMemberInfo("GameId", "mGameId", 0x9E990000, TdfType.UInt32, 1, true), // GID
        new TdfMemberInfo("PlayerId", "mPlayerId", 0xC2990000, TdfType.Int64, 2, true), // PID
        new TdfMemberInfo("PlayerRemovedReason", "mPlayerRemovedReason", 0xCA587300, TdfType.Enum, 3, true), // REAS
    ];
    private ITdfMember[] __members;

    private TdfUInt16 _playerRemovedTitleContext = new(__typeInfos[0]);
    private TdfUInt32 _gameId = new(__typeInfos[1]);
    private TdfInt64 _playerId = new(__typeInfos[2]);
    private TdfEnum<Blaze3SDK.Blaze.GameManager.PlayerRemovedReason> _playerRemovedReason = new(__typeInfos[3]);

    public NotifyPlayerRemoved()
    {
        __members = [
            _playerRemovedTitleContext,
            _gameId,
            _playerId,
            _playerRemovedReason,
        ];
    }

    public override Tdf CreateNew() => new NotifyPlayerRemoved();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NotifyPlayerRemoved";
    public override string GetFullClassName() => "Blaze::GameManager::NotifyPlayerRemoved";

    public ushort PlayerRemovedTitleContext
    {
        get => _playerRemovedTitleContext.Value;
        set => _playerRemovedTitleContext.Value = value;
    }

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

    public Blaze3SDK.Blaze.GameManager.PlayerRemovedReason PlayerRemovedReason
    {
        get => _playerRemovedReason.Value;
        set => _playerRemovedReason.Value = value;
    }

}

