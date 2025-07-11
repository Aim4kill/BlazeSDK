using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class CreateGameResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameData", "mGameData", 0x921D2100, TdfType.Struct, 0, true), // DATA
        new TdfMemberInfo("GameId", "mGameId", 0x9E990000, TdfType.UInt32, 1, true), // GID
        new TdfMemberInfo("HostId", "mHostId", 0xA2990000, TdfType.UInt32, 2, true), // HID
        new TdfMemberInfo("GameRoster", "mGameRoster", 0xC32BF300, TdfType.List, 3, true), // PROS
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze2SDK.Blaze.GameManager.ReplicatedGameData?> _gameData = new(__typeInfos[0]);
    private TdfUInt32 _gameId = new(__typeInfos[1]);
    private TdfUInt32 _hostId = new(__typeInfos[2]);
    private TdfList<Blaze2SDK.Blaze.GameManager.ReplicatedGamePlayer> _gameRoster = new(__typeInfos[3]);

    public CreateGameResponse()
    {
        __members = [
            _gameData,
            _gameId,
            _hostId,
            _gameRoster,
        ];
    }

    public override Tdf CreateNew() => new CreateGameResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "CreateGameResponse";
    public override string GetFullClassName() => "Blaze::GameManager::CreateGameResponse";

    public Blaze2SDK.Blaze.GameManager.ReplicatedGameData? GameData
    {
        get => _gameData.Value;
        set => _gameData.Value = value;
    }

    public uint GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public uint HostId
    {
        get => _hostId.Value;
        set => _hostId.Value = value;
    }

    public IList<Blaze2SDK.Blaze.GameManager.ReplicatedGamePlayer> GameRoster
    {
        get => _gameRoster.Value;
        set => _gameRoster.Value = value;
    }

}

