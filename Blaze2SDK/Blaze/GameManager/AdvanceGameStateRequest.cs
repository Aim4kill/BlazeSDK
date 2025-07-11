using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class AdvanceGameStateRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameId", "mGameId", 0x9E990000, TdfType.UInt32, 0, true), // GID
        new TdfMemberInfo("NewGameState", "mNewGameState", 0x9F3D2100, TdfType.Enum, 1, true), // GSTA
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _gameId = new(__typeInfos[0]);
    private TdfEnum<Blaze2SDK.Blaze.GameManager.GameState> _newGameState = new(__typeInfos[1]);

    public AdvanceGameStateRequest()
    {
        __members = [
            _gameId,
            _newGameState,
        ];
    }

    public override Tdf CreateNew() => new AdvanceGameStateRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "AdvanceGameStateRequest";
    public override string GetFullClassName() => "Blaze::GameManager::AdvanceGameStateRequest";

    public uint GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public Blaze2SDK.Blaze.GameManager.GameState NewGameState
    {
        get => _newGameState.Value;
        set => _newGameState.Value = value;
    }

}

