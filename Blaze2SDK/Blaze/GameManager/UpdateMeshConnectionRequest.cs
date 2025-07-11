using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class UpdateMeshConnectionRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameId", "mGameId", 0x9E990000, TdfType.UInt32, 0, true), // GID
        new TdfMemberInfo("MeshConnectionStatusList", "mMeshConnectionStatusList", 0xD21CA700, TdfType.List, 1, true), // TARG
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _gameId = new(__typeInfos[0]);
    private TdfList<Blaze2SDK.Blaze.GameManager.PlayerConnectionStatus> _meshConnectionStatusList = new(__typeInfos[1]);

    public UpdateMeshConnectionRequest()
    {
        __members = [
            _gameId,
            _meshConnectionStatusList,
        ];
    }

    public override Tdf CreateNew() => new UpdateMeshConnectionRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpdateMeshConnectionRequest";
    public override string GetFullClassName() => "Blaze::GameManager::UpdateMeshConnectionRequest";

    public uint GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public IList<Blaze2SDK.Blaze.GameManager.PlayerConnectionStatus> MeshConnectionStatusList
    {
        get => _meshConnectionStatusList.Value;
        set => _meshConnectionStatusList.Value = value;
    }

}

