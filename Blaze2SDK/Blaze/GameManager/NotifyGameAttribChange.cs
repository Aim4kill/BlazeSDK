using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class NotifyGameAttribChange : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameAttribs", "mGameAttribs", 0x874D3200, TdfType.Map, 0, true), // ATTR
        new TdfMemberInfo("GameId", "mGameId", 0x9E990000, TdfType.UInt32, 1, true), // GID
    ];
    private ITdfMember[] __members;

    private TdfMap<string, string> _gameAttribs = new(__typeInfos[0]);
    private TdfUInt32 _gameId = new(__typeInfos[1]);

    public NotifyGameAttribChange()
    {
        __members = [
            _gameAttribs,
            _gameId,
        ];
    }

    public override Tdf CreateNew() => new NotifyGameAttribChange();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NotifyGameAttribChange";
    public override string GetFullClassName() => "Blaze::GameManager::NotifyGameAttribChange";

    public IDictionary<string, string> GameAttribs
    {
        get => _gameAttribs.Value;
        set => _gameAttribs.Value = value;
    }

    public uint GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

}

