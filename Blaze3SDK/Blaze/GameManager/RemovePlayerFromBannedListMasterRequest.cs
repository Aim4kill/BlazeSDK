using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class RemovePlayerFromBannedListMasterRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameId", "mGameId", 0x9E990000, TdfType.UInt32, 0, true), // GID
        new TdfMemberInfo("AccountId", "mAccountId", 0xBA990000, TdfType.Int64, 1, true), // NID
        new TdfMemberInfo("PlayerId", "mPlayerId", 0xC2990000, TdfType.Int64, 2, true), // PID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _gameId = new(__typeInfos[0]);
    private TdfInt64 _accountId = new(__typeInfos[1]);
    private TdfInt64 _playerId = new(__typeInfos[2]);

    public RemovePlayerFromBannedListMasterRequest()
    {
        __members = [
            _gameId,
            _accountId,
            _playerId,
        ];
    }

    public override Tdf CreateNew() => new RemovePlayerFromBannedListMasterRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "RemovePlayerFromBannedListMasterRequest";
    public override string GetFullClassName() => "Blaze::GameManager::RemovePlayerFromBannedListMasterRequest";

    public uint GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public long AccountId
    {
        get => _accountId.Value;
        set => _accountId.Value = value;
    }

    public long PlayerId
    {
        get => _playerId.Value;
        set => _playerId.Value = value;
    }

}

