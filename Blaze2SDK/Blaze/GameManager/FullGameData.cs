using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class FullGameData : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Game", "mGame", 0x9E1B6500, TdfType.Struct, 0, true), // GAME
        new TdfMemberInfo("GameRoster", "mGameRoster", 0xC32BF300, TdfType.List, 1, true), // PROS
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze2SDK.Blaze.GameManager.ReplicatedGameData?> _game = new(__typeInfos[0]);
    private TdfList<Blaze2SDK.Blaze.GameManager.ReplicatedGamePlayer> _gameRoster = new(__typeInfos[1]);

    public FullGameData()
    {
        __members = [
            _game,
            _gameRoster,
        ];
    }

    public override Tdf CreateNew() => new FullGameData();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "FullGameData";
    public override string GetFullClassName() => "Blaze::GameManager::FullGameData";

    public Blaze2SDK.Blaze.GameManager.ReplicatedGameData? Game
    {
        get => _game.Value;
        set => _game.Value = value;
    }

    public IList<Blaze2SDK.Blaze.GameManager.ReplicatedGamePlayer> GameRoster
    {
        get => _gameRoster.Value;
        set => _gameRoster.Value = value;
    }

}

