using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.League;

public class PlayoffSeries : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("WasWonByForfeit", "mWasWonByForfeit", 0x9AFCA600, TdfType.UInt8, 0, true), // FORF
        new TdfMemberInfo("MaxGamesInSeries", "mMaxGamesInSeries", 0xB61E2700, TdfType.UInt8, 1, true), // MAXG
        new TdfMemberInfo("MatchupId", "mMatchupId", 0xB75A6400, TdfType.UInt32, 2, true), // MUID
        new TdfMemberInfo("Player1FinalScore", "mPlayer1FinalScore", 0xC119B300, TdfType.UInt8, 3, true), // P1FS
        new TdfMemberInfo("Player1", "mPlayer1", 0xC11A6400, TdfType.Struct, 4, true), // P1ID
        new TdfMemberInfo("Player1TeamId", "mPlayer1TeamId", 0xC11D2D00, TdfType.UInt32, 5, true), // P1TM
        new TdfMemberInfo("Player2FinalScore", "mPlayer2FinalScore", 0xC129B300, TdfType.UInt8, 6, true), // P2FS
        new TdfMemberInfo("Player2", "mPlayer2", 0xC12A6400, TdfType.Struct, 7, true), // P2ID
        new TdfMemberInfo("Player2TeamId", "mPlayer2TeamId", 0xC12D2D00, TdfType.UInt32, 8, true), // P2TM
        new TdfMemberInfo("GamesPlayed", "mGamesPlayed", 0xC2CE6400, TdfType.UInt8, 9, true), // PLYD
        new TdfMemberInfo("PlayoffType", "mPlayoffType", 0xC34E7000, TdfType.Enum, 10, true), // PTYP
        new TdfMemberInfo("Round", "mRound", 0xCAE90000, TdfType.UInt8, 11, true), // RND
        new TdfMemberInfo("GameScores", "mGameScores", 0xCE3CB300, TdfType.List, 12, true), // SCRS
        new TdfMemberInfo("SeriesWinner", "mSeriesWinner", 0xDE9BB200, TdfType.UInt8, 13, true), // WINR
    ];
    private ITdfMember[] __members;

    private TdfUInt8 _wasWonByForfeit = new(__typeInfos[0]);
    private TdfUInt8 _maxGamesInSeries = new(__typeInfos[1]);
    private TdfUInt32 _matchupId = new(__typeInfos[2]);
    private TdfUInt8 _player1FinalScore = new(__typeInfos[3]);
    private TdfStruct<Blaze2SDK.Blaze.League.LeagueUser?> _player1 = new(__typeInfos[4]);
    private TdfUInt32 _player1TeamId = new(__typeInfos[5]);
    private TdfUInt8 _player2FinalScore = new(__typeInfos[6]);
    private TdfStruct<Blaze2SDK.Blaze.League.LeagueUser?> _player2 = new(__typeInfos[7]);
    private TdfUInt32 _player2TeamId = new(__typeInfos[8]);
    private TdfUInt8 _gamesPlayed = new(__typeInfos[9]);
    private TdfEnum<Blaze2SDK.Blaze.League.PlayoffType> _playoffType = new(__typeInfos[10]);
    private TdfUInt8 _round = new(__typeInfos[11]);
    private TdfList<Blaze2SDK.Blaze.League.PlayoffGameScore> _gameScores = new(__typeInfos[12]);
    private TdfUInt8 _seriesWinner = new(__typeInfos[13]);

    public PlayoffSeries()
    {
        __members = [
            _wasWonByForfeit,
            _maxGamesInSeries,
            _matchupId,
            _player1FinalScore,
            _player1,
            _player1TeamId,
            _player2FinalScore,
            _player2,
            _player2TeamId,
            _gamesPlayed,
            _playoffType,
            _round,
            _gameScores,
            _seriesWinner,
        ];
    }

    public override Tdf CreateNew() => new PlayoffSeries();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PlayoffSeries";
    public override string GetFullClassName() => "Blaze::League::PlayoffSeries";

    public byte WasWonByForfeit
    {
        get => _wasWonByForfeit.Value;
        set => _wasWonByForfeit.Value = value;
    }

    public byte MaxGamesInSeries
    {
        get => _maxGamesInSeries.Value;
        set => _maxGamesInSeries.Value = value;
    }

    public uint MatchupId
    {
        get => _matchupId.Value;
        set => _matchupId.Value = value;
    }

    public byte Player1FinalScore
    {
        get => _player1FinalScore.Value;
        set => _player1FinalScore.Value = value;
    }

    public Blaze2SDK.Blaze.League.LeagueUser? Player1
    {
        get => _player1.Value;
        set => _player1.Value = value;
    }

    public uint Player1TeamId
    {
        get => _player1TeamId.Value;
        set => _player1TeamId.Value = value;
    }

    public byte Player2FinalScore
    {
        get => _player2FinalScore.Value;
        set => _player2FinalScore.Value = value;
    }

    public Blaze2SDK.Blaze.League.LeagueUser? Player2
    {
        get => _player2.Value;
        set => _player2.Value = value;
    }

    public uint Player2TeamId
    {
        get => _player2TeamId.Value;
        set => _player2TeamId.Value = value;
    }

    public byte GamesPlayed
    {
        get => _gamesPlayed.Value;
        set => _gamesPlayed.Value = value;
    }

    public Blaze2SDK.Blaze.League.PlayoffType PlayoffType
    {
        get => _playoffType.Value;
        set => _playoffType.Value = value;
    }

    public byte Round
    {
        get => _round.Value;
        set => _round.Value = value;
    }

    public IList<Blaze2SDK.Blaze.League.PlayoffGameScore> GameScores
    {
        get => _gameScores.Value;
        set => _gameScores.Value = value;
    }

    public byte SeriesWinner
    {
        get => _seriesWinner.Value;
        set => _seriesWinner.Value = value;
    }

}

