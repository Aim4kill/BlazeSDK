using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class GameManagerCensusData : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("NumOfActiveGame", "mNumOfActiveGame", 0x867B8000, TdfType.UInt32, 0, true), // AGN
        new TdfMemberInfo("GameAttributesData", "mGameAttributesData", 0x9E18E400, TdfType.List, 1, true), // GACD
        new TdfMemberInfo("NumOfJoinedPlayer", "mNumOfJoinedPlayer", 0xAB0B8000, TdfType.UInt32, 2, true), // JPN
        new TdfMemberInfo("NumOfLoggedSession", "mNumOfLoggedSession", 0xB33B8000, TdfType.UInt32, 3, true), // LSN
        new TdfMemberInfo("NumOfMatchmakingSession", "mNumOfMatchmakingSession", 0xB6DCEE00, TdfType.UInt32, 4, true), // MMSN
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _numOfActiveGame = new(__typeInfos[0]);
    private TdfList<Blaze2SDK.Blaze.GameManager.GameAttributeCensusData> _gameAttributesData = new(__typeInfos[1]);
    private TdfUInt32 _numOfJoinedPlayer = new(__typeInfos[2]);
    private TdfUInt32 _numOfLoggedSession = new(__typeInfos[3]);
    private TdfUInt32 _numOfMatchmakingSession = new(__typeInfos[4]);

    public GameManagerCensusData()
    {
        __members = [
            _numOfActiveGame,
            _gameAttributesData,
            _numOfJoinedPlayer,
            _numOfLoggedSession,
            _numOfMatchmakingSession,
        ];
    }

    public override Tdf CreateNew() => new GameManagerCensusData();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GameManagerCensusData";
    public override string GetFullClassName() => "Blaze::GameManager::GameManagerCensusData";

    public uint NumOfActiveGame
    {
        get => _numOfActiveGame.Value;
        set => _numOfActiveGame.Value = value;
    }

    public IList<Blaze2SDK.Blaze.GameManager.GameAttributeCensusData> GameAttributesData
    {
        get => _gameAttributesData.Value;
        set => _gameAttributesData.Value = value;
    }

    public uint NumOfJoinedPlayer
    {
        get => _numOfJoinedPlayer.Value;
        set => _numOfJoinedPlayer.Value = value;
    }

    public uint NumOfLoggedSession
    {
        get => _numOfLoggedSession.Value;
        set => _numOfLoggedSession.Value = value;
    }

    public uint NumOfMatchmakingSession
    {
        get => _numOfMatchmakingSession.Value;
        set => _numOfMatchmakingSession.Value = value;
    }

}

