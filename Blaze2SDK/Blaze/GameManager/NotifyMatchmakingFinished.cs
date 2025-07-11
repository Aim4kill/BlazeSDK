using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class NotifyMatchmakingFinished : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("FitScore", "mFitScore", 0x9A9D0000, TdfType.UInt32, 0, true), // FIT
        new TdfMemberInfo("GameId", "mGameId", 0x9E990000, TdfType.UInt32, 1, true), // GID
        new TdfMemberInfo("MaxPossibleFitScore", "mMaxPossibleFitScore", 0xB61E2600, TdfType.UInt32, 2, true), // MAXF
        new TdfMemberInfo("SessionId", "mSessionId", 0xB73A6400, TdfType.UInt32, 3, true), // MSID
        new TdfMemberInfo("MatchmakingResult", "mMatchmakingResult", 0xCB3B3400, TdfType.Enum, 4, true), // RSLT
        new TdfMemberInfo("UserSessionId", "mUserSessionId", 0xD73A6400, TdfType.UInt32, 5, true), // USID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _fitScore = new(__typeInfos[0]);
    private TdfUInt32 _gameId = new(__typeInfos[1]);
    private TdfUInt32 _maxPossibleFitScore = new(__typeInfos[2]);
    private TdfUInt32 _sessionId = new(__typeInfos[3]);
    private TdfEnum<Blaze2SDK.Blaze.GameManager.MatchmakingResult> _matchmakingResult = new(__typeInfos[4]);
    private TdfUInt32 _userSessionId = new(__typeInfos[5]);

    public NotifyMatchmakingFinished()
    {
        __members = [
            _fitScore,
            _gameId,
            _maxPossibleFitScore,
            _sessionId,
            _matchmakingResult,
            _userSessionId,
        ];
    }

    public override Tdf CreateNew() => new NotifyMatchmakingFinished();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NotifyMatchmakingFinished";
    public override string GetFullClassName() => "Blaze::GameManager::NotifyMatchmakingFinished";

    public uint FitScore
    {
        get => _fitScore.Value;
        set => _fitScore.Value = value;
    }

    public uint GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public uint MaxPossibleFitScore
    {
        get => _maxPossibleFitScore.Value;
        set => _maxPossibleFitScore.Value = value;
    }

    public uint SessionId
    {
        get => _sessionId.Value;
        set => _sessionId.Value = value;
    }

    public Blaze2SDK.Blaze.GameManager.MatchmakingResult MatchmakingResult
    {
        get => _matchmakingResult.Value;
        set => _matchmakingResult.Value = value;
    }

    public uint UserSessionId
    {
        get => _userSessionId.Value;
        set => _userSessionId.Value = value;
    }

}

