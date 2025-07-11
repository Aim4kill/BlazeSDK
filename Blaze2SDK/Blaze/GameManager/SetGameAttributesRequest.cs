using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class SetGameAttributesRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameAttributes", "mGameAttributes", 0x874D3200, TdfType.Map, 0, true), // ATTR
        new TdfMemberInfo("GameId", "mGameId", 0x9E990000, TdfType.UInt32, 1, true), // GID
    ];
    private ITdfMember[] __members;

    private TdfMap<string, string> _gameAttributes = new(__typeInfos[0]);
    private TdfUInt32 _gameId = new(__typeInfos[1]);

    public SetGameAttributesRequest()
    {
        __members = [
            _gameAttributes,
            _gameId,
        ];
    }

    public override Tdf CreateNew() => new SetGameAttributesRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "SetGameAttributesRequest";
    public override string GetFullClassName() => "Blaze::GameManager::SetGameAttributesRequest";

    public IDictionary<string, string> GameAttributes
    {
        get => _gameAttributes.Value;
        set => _gameAttributes.Value = value;
    }

    public uint GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

}

