using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.League;

public class GameResult : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameId", "mGameId", 0x9EDA6400, TdfType.UInt32, 0, true), // GMID
        new TdfMemberInfo("Participants", "mParticipants", 0xC2CCB300, TdfType.List, 1, true), // PLRS
        new TdfMemberInfo("Scores", "mScores", 0xCE3CB300, TdfType.List, 2, true), // SCRS
        new TdfMemberInfo("IsSimulated", "mIsSimulated", 0xCE9B4000, TdfType.UInt8, 3, true), // SIM
        new TdfMemberInfo("Size", "mSize", 0xCE9EA500, TdfType.UInt32, 4, true), // SIZE
        new TdfMemberInfo("Time", "mTime", 0xD29B6500, TdfType.UInt32, 5, true), // TIME
        new TdfMemberInfo("Winner", "mWinner", 0xDECD3300, TdfType.UInt32, 6, true), // WLTS
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _gameId = new(__typeInfos[0]);
    private TdfList<Blaze3SDK.Blaze.League.LeagueUser> _participants = new(__typeInfos[1]);
    private TdfList<uint> _scores = new(__typeInfos[2]);
    private TdfUInt8 _isSimulated = new(__typeInfos[3]);
    private TdfUInt32 _size = new(__typeInfos[4]);
    private TdfUInt32 _time = new(__typeInfos[5]);
    private TdfUInt32 _winner = new(__typeInfos[6]);

    public GameResult()
    {
        __members = [
            _gameId,
            _participants,
            _scores,
            _isSimulated,
            _size,
            _time,
            _winner,
        ];
    }

    public override Tdf CreateNew() => new GameResult();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GameResult";
    public override string GetFullClassName() => "Blaze::League::GameResult";

    public uint GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public IList<Blaze3SDK.Blaze.League.LeagueUser> Participants
    {
        get => _participants.Value;
        set => _participants.Value = value;
    }

    public IList<uint> Scores
    {
        get => _scores.Value;
        set => _scores.Value = value;
    }

    public byte IsSimulated
    {
        get => _isSimulated.Value;
        set => _isSimulated.Value = value;
    }

    public uint Size
    {
        get => _size.Value;
        set => _size.Value = value;
    }

    public uint Time
    {
        get => _time.Value;
        set => _time.Value = value;
    }

    public uint Winner
    {
        get => _winner.Value;
        set => _winner.Value = value;
    }

}

