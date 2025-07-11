using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class NotifyPlayerAttribChange : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("PlayerAttribs", "mPlayerAttribs", 0x874D3200, TdfType.Map, 0, true), // ATTR
        new TdfMemberInfo("GameId", "mGameId", 0x9E990000, TdfType.UInt32, 1, true), // GID
        new TdfMemberInfo("PlayerId", "mPlayerId", 0xC2990000, TdfType.UInt32, 2, true), // PID
    ];
    private ITdfMember[] __members;

    private TdfMap<string, string> _playerAttribs = new(__typeInfos[0]);
    private TdfUInt32 _gameId = new(__typeInfos[1]);
    private TdfUInt32 _playerId = new(__typeInfos[2]);

    public NotifyPlayerAttribChange()
    {
        __members = [
            _playerAttribs,
            _gameId,
            _playerId,
        ];
    }

    public override Tdf CreateNew() => new NotifyPlayerAttribChange();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NotifyPlayerAttribChange";
    public override string GetFullClassName() => "Blaze::GameManager::NotifyPlayerAttribChange";

    public IDictionary<string, string> PlayerAttribs
    {
        get => _playerAttribs.Value;
        set => _playerAttribs.Value = value;
    }

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

}

