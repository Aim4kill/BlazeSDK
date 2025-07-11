using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class CreateGameResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameId", "mGameId", 0x9E990000, TdfType.UInt32, 0, true), // GID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _gameId = new(__typeInfos[0]);

    public CreateGameResponse()
    {
        __members = [
            _gameId,
        ];
    }

    public override Tdf CreateNew() => new CreateGameResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "CreateGameResponse";
    public override string GetFullClassName() => "Blaze::GameManager::CreateGameResponse";

    public uint GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

}

