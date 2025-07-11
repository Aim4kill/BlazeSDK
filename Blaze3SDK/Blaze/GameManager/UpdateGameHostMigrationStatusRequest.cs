using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class UpdateGameHostMigrationStatusRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameId", "mGameId", 0x9E990000, TdfType.UInt32, 0, true), // GID
        new TdfMemberInfo("HostMigrationType", "mHostMigrationType", 0xB74E7000, TdfType.Enum, 1, true), // MTYP
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _gameId = new(__typeInfos[0]);
    private TdfEnum<Blaze3SDK.Blaze.GameManager.HostMigrationType> _hostMigrationType = new(__typeInfos[1]);

    public UpdateGameHostMigrationStatusRequest()
    {
        __members = [
            _gameId,
            _hostMigrationType,
        ];
    }

    public override Tdf CreateNew() => new UpdateGameHostMigrationStatusRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpdateGameHostMigrationStatusRequest";
    public override string GetFullClassName() => "Blaze::GameManager::UpdateGameHostMigrationStatusRequest";

    public uint GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public Blaze3SDK.Blaze.GameManager.HostMigrationType HostMigrationType
    {
        get => _hostMigrationType.Value;
        set => _hostMigrationType.Value = value;
    }

}

