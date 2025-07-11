using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class UpdatePlayerMeshConnectionRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameId", "mGameId", 0x9E990000, TdfType.UInt32, 0, true), // GID
        new TdfMemberInfo("PlayersMeshConnection", "mPlayersMeshConnection", 0xD21CA700, TdfType.List, 1, true), // TARG
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _gameId = new(__typeInfos[0]);
    private TdfList<Blaze2SDK.Blaze.GameManager.PlayerConnectionStatus> _playersMeshConnection = new(__typeInfos[1]);

    public UpdatePlayerMeshConnectionRequest()
    {
        __members = [
            _gameId,
            _playersMeshConnection,
        ];
    }

    public override Tdf CreateNew() => new UpdatePlayerMeshConnectionRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpdatePlayerMeshConnectionRequest";
    public override string GetFullClassName() => "Blaze::GameManager::UpdatePlayerMeshConnectionRequest";

    public uint GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public IList<Blaze2SDK.Blaze.GameManager.PlayerConnectionStatus> PlayersMeshConnection
    {
        get => _playersMeshConnection.Value;
        set => _playersMeshConnection.Value = value;
    }

}

