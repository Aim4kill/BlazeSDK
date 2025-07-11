using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class NotifyMatchmakingFailed : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MaxPossibleFitScore", "mMaxPossibleFitScore", 0xB61E2600, TdfType.UInt32, 0, true), // MAXF
        new TdfMemberInfo("SessionId", "mSessionId", 0xB73A6400, TdfType.UInt32, 1, true), // MSID
        new TdfMemberInfo("MatchmakingResult", "mMatchmakingResult", 0xCB3B3400, TdfType.Enum, 2, true), // RSLT
        new TdfMemberInfo("UserSessionId", "mUserSessionId", 0xD73A6400, TdfType.UInt32, 3, true), // USID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _maxPossibleFitScore = new(__typeInfos[0]);
    private TdfUInt32 _sessionId = new(__typeInfos[1]);
    private TdfEnum<Blaze3SDK.Blaze.GameManager.MatchmakingResult> _matchmakingResult = new(__typeInfos[2]);
    private TdfUInt32 _userSessionId = new(__typeInfos[3]);

    public NotifyMatchmakingFailed()
    {
        __members = [
            _maxPossibleFitScore,
            _sessionId,
            _matchmakingResult,
            _userSessionId,
        ];
    }

    public override Tdf CreateNew() => new NotifyMatchmakingFailed();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NotifyMatchmakingFailed";
    public override string GetFullClassName() => "Blaze::GameManager::NotifyMatchmakingFailed";

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

    public Blaze3SDK.Blaze.GameManager.MatchmakingResult MatchmakingResult
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

