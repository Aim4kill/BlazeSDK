using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class NotifyPlayerCustomDataChange : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CustomData", "mCustomData", 0x8E487400, TdfType.Blob, 0, true), // CDAT
        new TdfMemberInfo("GameId", "mGameId", 0x9E990000, TdfType.UInt32, 1, true), // GID
        new TdfMemberInfo("PlayerId", "mPlayerId", 0xC2990000, TdfType.Int64, 2, true), // PID
    ];
    private ITdfMember[] __members;

    private TdfBlob _customData = new(__typeInfos[0]);
    private TdfUInt32 _gameId = new(__typeInfos[1]);
    private TdfInt64 _playerId = new(__typeInfos[2]);

    public NotifyPlayerCustomDataChange()
    {
        __members = [
            _customData,
            _gameId,
            _playerId,
        ];
    }

    public override Tdf CreateNew() => new NotifyPlayerCustomDataChange();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NotifyPlayerCustomDataChange";
    public override string GetFullClassName() => "Blaze::GameManager::NotifyPlayerCustomDataChange";

    public byte[] CustomData
    {
        get => _customData.Value;
        set => _customData.Value = value;
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

}

