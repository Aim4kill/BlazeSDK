using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class RemovePlayerFromBannedListRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameId", "mGameId", 0x9E990000, TdfType.UInt32, 0, true), // GID
        new TdfMemberInfo("BlazeId", "mBlazeId", 0xC2990000, TdfType.Int64, 1, true), // PID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _gameId = new(__typeInfos[0]);
    private TdfInt64 _blazeId = new(__typeInfos[1]);

    public RemovePlayerFromBannedListRequest()
    {
        __members = [
            _gameId,
            _blazeId,
        ];
    }

    public override Tdf CreateNew() => new RemovePlayerFromBannedListRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "RemovePlayerFromBannedListRequest";
    public override string GetFullClassName() => "Blaze::GameManager::RemovePlayerFromBannedListRequest";

    public uint GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public long BlazeId
    {
        get => _blazeId.Value;
        set => _blazeId.Value = value;
    }

}

