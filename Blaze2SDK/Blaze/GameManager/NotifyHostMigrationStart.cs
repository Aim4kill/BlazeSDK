using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class NotifyHostMigrationStart : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameId", "mGameId", 0x9E990000, TdfType.UInt32, 0, true), // GID
        new TdfMemberInfo("NewHostId", "mNewHostId", 0xA2FCF400, TdfType.UInt32, 1, true), // HOST
        new TdfMemberInfo("MigrationType", "mMigrationType", 0xC2DA6700, TdfType.Enum, 2, true), // PMIG
        new TdfMemberInfo("NewHostSlotId", "mNewHostSlotId", 0xCECBF400, TdfType.UInt8, 3, true), // SLOT
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _gameId = new(__typeInfos[0]);
    private TdfUInt32 _newHostId = new(__typeInfos[1]);
    private TdfEnum<Blaze2SDK.Blaze.GameManager.HostMigrationType> _migrationType = new(__typeInfos[2]);
    private TdfUInt8 _newHostSlotId = new(__typeInfos[3]);

    public NotifyHostMigrationStart()
    {
        __members = [
            _gameId,
            _newHostId,
            _migrationType,
            _newHostSlotId,
        ];
    }

    public override Tdf CreateNew() => new NotifyHostMigrationStart();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NotifyHostMigrationStart";
    public override string GetFullClassName() => "Blaze::GameManager::NotifyHostMigrationStart";

    public uint GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public uint NewHostId
    {
        get => _newHostId.Value;
        set => _newHostId.Value = value;
    }

    public Blaze2SDK.Blaze.GameManager.HostMigrationType MigrationType
    {
        get => _migrationType.Value;
        set => _migrationType.Value = value;
    }

    public byte NewHostSlotId
    {
        get => _newHostSlotId.Value;
        set => _newHostSlotId.Value = value;
    }

}

