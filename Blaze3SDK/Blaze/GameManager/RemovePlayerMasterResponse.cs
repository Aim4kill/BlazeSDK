using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class RemovePlayerMasterResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameId", "mGameId", 0x9E990000, TdfType.UInt32, 0, true), // GID
        new TdfMemberInfo("Player", "mPlayer", 0x9F0B3900, TdfType.Struct, 1, true), // GPLY
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _gameId = new(__typeInfos[0]);
    private TdfStruct<Blaze3SDK.Blaze.GameManager.ReplicatedGamePlayer?> _player = new(__typeInfos[1]);

    public RemovePlayerMasterResponse()
    {
        __members = [
            _gameId,
            _player,
        ];
    }

    public override Tdf CreateNew() => new RemovePlayerMasterResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "RemovePlayerMasterResponse";
    public override string GetFullClassName() => "Blaze::GameManager::RemovePlayerMasterResponse";

    public uint GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public Blaze3SDK.Blaze.GameManager.ReplicatedGamePlayer? Player
    {
        get => _player.Value;
        set => _player.Value = value;
    }

}

