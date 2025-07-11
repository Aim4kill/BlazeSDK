using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class ChangeTeamIdRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameId", "mGameId", 0x9E990000, TdfType.UInt32, 0, true), // GID
        new TdfMemberInfo("NewTeamId", "mNewTeamId", 0xBB4A6400, TdfType.UInt16, 1, true), // NTID
        new TdfMemberInfo("TeamIndex", "mTeamIndex", 0xD2993800, TdfType.UInt16, 2, true), // TIDX
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _gameId = new(__typeInfos[0]);
    private TdfUInt16 _newTeamId = new(__typeInfos[1]);
    private TdfUInt16 _teamIndex = new(__typeInfos[2]);

    public ChangeTeamIdRequest()
    {
        __members = [
            _gameId,
            _newTeamId,
            _teamIndex,
        ];
    }

    public override Tdf CreateNew() => new ChangeTeamIdRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ChangeTeamIdRequest";
    public override string GetFullClassName() => "Blaze::GameManager::ChangeTeamIdRequest";

    public uint GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public ushort NewTeamId
    {
        get => _newTeamId.Value;
        set => _newTeamId.Value = value;
    }

    public ushort TeamIndex
    {
        get => _teamIndex.Value;
        set => _teamIndex.Value = value;
    }

}

