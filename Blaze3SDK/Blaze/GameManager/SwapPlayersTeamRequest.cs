using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class SwapPlayersTeamRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameId", "mGameId", 0x9E990000, TdfType.UInt32, 0, true), // GID
        new TdfMemberInfo("SwapPlayersTeam", "mSwapPlayersTeam", 0xB2786D00, TdfType.List, 1, true), // LGAM
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _gameId = new(__typeInfos[0]);
    private TdfList<Blaze3SDK.Blaze.GameManager.SwapPlayerTeamData> _swapPlayersTeam = new(__typeInfos[1]);

    public SwapPlayersTeamRequest()
    {
        __members = [
            _gameId,
            _swapPlayersTeam,
        ];
    }

    public override Tdf CreateNew() => new SwapPlayersTeamRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "SwapPlayersTeamRequest";
    public override string GetFullClassName() => "Blaze::GameManager::SwapPlayersTeamRequest";

    public uint GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public IList<Blaze3SDK.Blaze.GameManager.SwapPlayerTeamData> SwapPlayersTeam
    {
        get => _swapPlayersTeam.Value;
        set => _swapPlayersTeam.Value = value;
    }

}

