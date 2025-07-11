using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class UpdateHostConnectionRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameId", "mGameId", 0x9E990000, TdfType.UInt32, 0, true), // GID
        new TdfMemberInfo("PlayerNetConnectionStatus", "mPlayerNetConnectionStatus", 0xCF487400, TdfType.Enum, 1, true), // STAT
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _gameId = new(__typeInfos[0]);
    private TdfEnum<Blaze2SDK.Blaze.GameManager.PlayerNetConnectionStatus> _playerNetConnectionStatus = new(__typeInfos[1]);

    public UpdateHostConnectionRequest()
    {
        __members = [
            _gameId,
            _playerNetConnectionStatus,
        ];
    }

    public override Tdf CreateNew() => new UpdateHostConnectionRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpdateHostConnectionRequest";
    public override string GetFullClassName() => "Blaze::GameManager::UpdateHostConnectionRequest";

    public uint GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public Blaze2SDK.Blaze.GameManager.PlayerNetConnectionStatus PlayerNetConnectionStatus
    {
        get => _playerNetConnectionStatus.Value;
        set => _playerNetConnectionStatus.Value = value;
    }

}

