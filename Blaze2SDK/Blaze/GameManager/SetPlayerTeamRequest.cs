using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class SetPlayerTeamRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameId", "mGameId", 0x9E990000, TdfType.UInt32, 0, true), // GID
        new TdfMemberInfo("PlayerId", "mPlayerId", 0xC2990000, TdfType.UInt32, 1, true), // PID
        new TdfMemberInfo("TeamId", "mTeamId", 0xD2586D00, TdfType.UInt16, 2, true), // TEAM
        new TdfMemberInfo("TeamIndex", "mTeamIndex", 0xD2993800, TdfType.UInt16, 3, true), // TIDX
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _gameId = new(__typeInfos[0]);
    private TdfUInt32 _playerId = new(__typeInfos[1]);
    private TdfUInt16 _teamId = new(__typeInfos[2]);
    private TdfUInt16 _teamIndex = new(__typeInfos[3]);

    public SetPlayerTeamRequest()
    {
        __members = [
            _gameId,
            _playerId,
            _teamId,
            _teamIndex,
        ];
    }

    public override Tdf CreateNew() => new SetPlayerTeamRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "SetPlayerTeamRequest";
    public override string GetFullClassName() => "Blaze::GameManager::SetPlayerTeamRequest";

    public uint GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public uint PlayerId
    {
        get => _playerId.Value;
        set => _playerId.Value = value;
    }

    public ushort TeamId
    {
        get => _teamId.Value;
        set => _teamId.Value = value;
    }

    public ushort TeamIndex
    {
        get => _teamIndex.Value;
        set => _teamIndex.Value = value;
    }

}

