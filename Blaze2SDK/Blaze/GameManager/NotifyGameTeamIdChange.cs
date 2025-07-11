using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class NotifyGameTeamIdChange : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameId", "mGameId", 0x9E990000, TdfType.UInt32, 0, true), // GID
        new TdfMemberInfo("NewTeamId", "mNewTeamId", 0xBB4A6400, TdfType.UInt16, 1, true), // NTID
        new TdfMemberInfo("OldTeamId", "mOldTeamId", 0xBF4A6400, TdfType.UInt16, 2, true), // OTID
        new TdfMemberInfo("TeamIndex", "mTeamIndex", 0xD2993800, TdfType.UInt16, 3, true), // TIDX
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _gameId = new(__typeInfos[0]);
    private TdfUInt16 _newTeamId = new(__typeInfos[1]);
    private TdfUInt16 _oldTeamId = new(__typeInfos[2]);
    private TdfUInt16 _teamIndex = new(__typeInfos[3]);

    public NotifyGameTeamIdChange()
    {
        __members = [
            _gameId,
            _newTeamId,
            _oldTeamId,
            _teamIndex,
        ];
    }

    public override Tdf CreateNew() => new NotifyGameTeamIdChange();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NotifyGameTeamIdChange";
    public override string GetFullClassName() => "Blaze::GameManager::NotifyGameTeamIdChange";

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

    public ushort OldTeamId
    {
        get => _oldTeamId.Value;
        set => _oldTeamId.Value = value;
    }

    public ushort TeamIndex
    {
        get => _teamIndex.Value;
        set => _teamIndex.Value = value;
    }

}

