using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class NotifyGameSetup : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameData", "mGameData", 0x9E1B6500, TdfType.Struct, 0, true), // GAME
        new TdfMemberInfo("GameRoster", "mGameRoster", 0xC32BF300, TdfType.List, 1, true), // PROS
        new TdfMemberInfo("GameQueue", "mGameQueue", 0xC7597500, TdfType.List, 2, true), // QUEU
        new TdfMemberInfo("GameSetupReason", "mGameSetupReason", 0xCA587300, TdfType.Union, 3, true), // REAS
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze3SDK.Blaze.GameManager.ReplicatedGameData?> _gameData = new(__typeInfos[0]);
    private TdfList<Blaze3SDK.Blaze.GameManager.ReplicatedGamePlayer> _gameRoster = new(__typeInfos[1]);
    private TdfList<Blaze3SDK.Blaze.GameManager.ReplicatedGamePlayer> _gameQueue = new(__typeInfos[2]);
    private TdfUnion<Blaze3SDK.Blaze.GameManager.GameSetupReason> _gameSetupReason = new(__typeInfos[3]);

    public NotifyGameSetup()
    {
        __members = [
            _gameData,
            _gameRoster,
            _gameQueue,
            _gameSetupReason,
        ];
    }

    public override Tdf CreateNew() => new NotifyGameSetup();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NotifyGameSetup";
    public override string GetFullClassName() => "Blaze::GameManager::NotifyGameSetup";

    public Blaze3SDK.Blaze.GameManager.ReplicatedGameData? GameData
    {
        get => _gameData.Value;
        set => _gameData.Value = value;
    }

    public IList<Blaze3SDK.Blaze.GameManager.ReplicatedGamePlayer> GameRoster
    {
        get => _gameRoster.Value;
        set => _gameRoster.Value = value;
    }

    public IList<Blaze3SDK.Blaze.GameManager.ReplicatedGamePlayer> GameQueue
    {
        get => _gameQueue.Value;
        set => _gameQueue.Value = value;
    }

    public Blaze3SDK.Blaze.GameManager.GameSetupReason GameSetupReason
    {
        get => _gameSetupReason.Value;
        set => _gameSetupReason.Value = value;
    }

}

