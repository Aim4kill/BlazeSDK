using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class UpdateGameNameRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameId", "mGameId", 0x9E990000, TdfType.UInt32, 0, true), // GID
        new TdfMemberInfo("GameName", "mGameName", 0x9EE86D00, TdfType.String, 1, true), // GNAM
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _gameId = new(__typeInfos[0]);
    private TdfString _gameName = new(__typeInfos[1]);

    public UpdateGameNameRequest()
    {
        __members = [
            _gameId,
            _gameName,
        ];
    }

    public override Tdf CreateNew() => new UpdateGameNameRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpdateGameNameRequest";
    public override string GetFullClassName() => "Blaze::GameManager::UpdateGameNameRequest";

    public uint GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public string GameName
    {
        get => _gameName.Value;
        set => _gameName.Value = value;
    }

}

