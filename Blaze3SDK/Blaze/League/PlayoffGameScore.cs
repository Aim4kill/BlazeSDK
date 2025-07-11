using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.League;

public class PlayoffGameScore : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Player1Score", "mPlayer1Score", 0xC11CE300, TdfType.Int32, 0, true), // P1SC
        new TdfMemberInfo("Player2Score", "mPlayer2Score", 0xC12CE300, TdfType.Int32, 1, true), // P2SC
        new TdfMemberInfo("IsSimulatedGame", "mIsSimulatedGame", 0xCE9B6700, TdfType.UInt8, 2, true), // SIMG
    ];
    private ITdfMember[] __members;

    private TdfInt32 _player1Score = new(__typeInfos[0]);
    private TdfInt32 _player2Score = new(__typeInfos[1]);
    private TdfUInt8 _isSimulatedGame = new(__typeInfos[2]);

    public PlayoffGameScore()
    {
        __members = [
            _player1Score,
            _player2Score,
            _isSimulatedGame,
        ];
    }

    public override Tdf CreateNew() => new PlayoffGameScore();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PlayoffGameScore";
    public override string GetFullClassName() => "Blaze::League::PlayoffGameScore";

    public int Player1Score
    {
        get => _player1Score.Value;
        set => _player1Score.Value = value;
    }

    public int Player2Score
    {
        get => _player2Score.Value;
        set => _player2Score.Value = value;
    }

    public byte IsSimulatedGame
    {
        get => _isSimulatedGame.Value;
        set => _isSimulatedGame.Value = value;
    }

}

