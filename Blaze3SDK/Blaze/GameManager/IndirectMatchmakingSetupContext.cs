using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class IndirectMatchmakingSetupContext : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("FitScore", "mFitScore", 0x9A9D0000, TdfType.UInt32, 0, true), // FIT
        new TdfMemberInfo("UserGroupId", "mUserGroupId", 0x9F2A6400, TdfType.ObjectId, 1, true), // GRID
        new TdfMemberInfo("MaxPossibleFitScore", "mMaxPossibleFitScore", 0xB61E2600, TdfType.UInt32, 2, true), // MAXF
        new TdfMemberInfo("SessionId", "mSessionId", 0xB73A6400, TdfType.UInt32, 3, true), // MSID
        new TdfMemberInfo("RequiresClientVersionCheck", "mRequiresClientVersionCheck", 0xCB0DA300, TdfType.Bool, 4, true), // RPVC
        new TdfMemberInfo("MatchmakingResult", "mMatchmakingResult", 0xCB3B3400, TdfType.Enum, 5, true), // RSLT
        new TdfMemberInfo("UserSessionId", "mUserSessionId", 0xD73A6400, TdfType.UInt32, 6, true), // USID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _fitScore = new(__typeInfos[0]);
    private TdfObjectId _userGroupId = new(__typeInfos[1]);
    private TdfUInt32 _maxPossibleFitScore = new(__typeInfos[2]);
    private TdfUInt32 _sessionId = new(__typeInfos[3]);
    private TdfBool _requiresClientVersionCheck = new(__typeInfos[4]);
    private TdfEnum<Blaze3SDK.Blaze.GameManager.MatchmakingResult> _matchmakingResult = new(__typeInfos[5]);
    private TdfUInt32 _userSessionId = new(__typeInfos[6]);

    public IndirectMatchmakingSetupContext()
    {
        __members = [
            _fitScore,
            _userGroupId,
            _maxPossibleFitScore,
            _sessionId,
            _requiresClientVersionCheck,
            _matchmakingResult,
            _userSessionId,
        ];
    }

    public override Tdf CreateNew() => new IndirectMatchmakingSetupContext();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "IndirectMatchmakingSetupContext";
    public override string GetFullClassName() => "Blaze::GameManager::IndirectMatchmakingSetupContext";

    public uint FitScore
    {
        get => _fitScore.Value;
        set => _fitScore.Value = value;
    }

    public ObjectId UserGroupId
    {
        get => _userGroupId.Value;
        set => _userGroupId.Value = value;
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

    public bool RequiresClientVersionCheck
    {
        get => _requiresClientVersionCheck.Value;
        set => _requiresClientVersionCheck.Value = value;
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

