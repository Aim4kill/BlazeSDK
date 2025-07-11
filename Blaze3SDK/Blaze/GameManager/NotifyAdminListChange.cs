using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class NotifyAdminListChange : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AdminPlayerId", "mAdminPlayerId", 0x86CCF400, TdfType.Int64, 0, true), // ALST
        new TdfMemberInfo("GameId", "mGameId", 0x9E990000, TdfType.UInt32, 1, true), // GID
        new TdfMemberInfo("Operation", "mOperation", 0xBF097200, TdfType.Enum, 2, true), // OPER
        new TdfMemberInfo("UpdaterPlayerId", "mUpdaterPlayerId", 0xD6990000, TdfType.Int64, 3, true), // UID
    ];
    private ITdfMember[] __members;

    private TdfInt64 _adminPlayerId = new(__typeInfos[0]);
    private TdfUInt32 _gameId = new(__typeInfos[1]);
    private TdfEnum<Blaze3SDK.Blaze.GameManager.UpdateAdminListOperation> _operation = new(__typeInfos[2]);
    private TdfInt64 _updaterPlayerId = new(__typeInfos[3]);

    public NotifyAdminListChange()
    {
        __members = [
            _adminPlayerId,
            _gameId,
            _operation,
            _updaterPlayerId,
        ];
    }

    public override Tdf CreateNew() => new NotifyAdminListChange();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NotifyAdminListChange";
    public override string GetFullClassName() => "Blaze::GameManager::NotifyAdminListChange";

    public long AdminPlayerId
    {
        get => _adminPlayerId.Value;
        set => _adminPlayerId.Value = value;
    }

    public uint GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public Blaze3SDK.Blaze.GameManager.UpdateAdminListOperation Operation
    {
        get => _operation.Value;
        set => _operation.Value = value;
    }

    public long UpdaterPlayerId
    {
        get => _updaterPlayerId.Value;
        set => _updaterPlayerId.Value = value;
    }

}

