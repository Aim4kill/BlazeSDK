using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class UpdateAdminListRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameId", "mGameId", 0x9E990000, TdfType.UInt32, 0, true), // GID
        new TdfMemberInfo("AdminPlayerId", "mAdminPlayerId", 0xC2990000, TdfType.UInt32, 1, true), // PID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _gameId = new(__typeInfos[0]);
    private TdfUInt32 _adminPlayerId = new(__typeInfos[1]);

    public UpdateAdminListRequest()
    {
        __members = [
            _gameId,
            _adminPlayerId,
        ];
    }

    public override Tdf CreateNew() => new UpdateAdminListRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpdateAdminListRequest";
    public override string GetFullClassName() => "Blaze::GameManager::UpdateAdminListRequest";

    public uint GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public uint AdminPlayerId
    {
        get => _adminPlayerId.Value;
        set => _adminPlayerId.Value = value;
    }

}

