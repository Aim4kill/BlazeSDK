using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class CreateGameStatus : Tdf
{
    [Flags]
    public enum EvaluateStatus : int
    {
        PlayerCountSufficient = 1,
        AcceptableHostFound = 2,
        TeamSizesSufficient = 4,
    }
    
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("EvaluateStatus", "mEvaluateStatus", 0x976CF400, TdfType.Enum, 0, true), // EVST
        new TdfMemberInfo("NumOfMatchmakingSession", "mNumOfMatchmakingSession", 0xB6DCEE00, TdfType.UInt32, 1, true), // MMSN
        new TdfMemberInfo("NumOfMatchedPlayers", "mNumOfMatchedPlayers", 0xBAFB7000, TdfType.UInt32, 2, true), // NOMP
    ];
    private ITdfMember[] __members;

    private TdfEnum<Blaze3SDK.Blaze.GameManager.CreateGameStatus.EvaluateStatus> _evaluateStatus = new(__typeInfos[0]);
    private TdfUInt32 _numOfMatchmakingSession = new(__typeInfos[1]);
    private TdfUInt32 _numOfMatchedPlayers = new(__typeInfos[2]);

    public CreateGameStatus()
    {
        __members = [
            _evaluateStatus,
            _numOfMatchmakingSession,
            _numOfMatchedPlayers,
        ];
    }

    public override Tdf CreateNew() => new CreateGameStatus();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "CreateGameStatus";
    public override string GetFullClassName() => "Blaze::GameManager::CreateGameStatus";

    public Blaze3SDK.Blaze.GameManager.CreateGameStatus.EvaluateStatus mEvaluateStatus
    {
        get => _evaluateStatus.Value;
        set => _evaluateStatus.Value = value;
    }

    public uint NumOfMatchmakingSession
    {
        get => _numOfMatchmakingSession.Value;
        set => _numOfMatchmakingSession.Value = value;
    }

    public uint NumOfMatchedPlayers
    {
        get => _numOfMatchedPlayers.Value;
        set => _numOfMatchedPlayers.Value = value;
    }

}

