using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class GameBrowserDataList : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameData", "mGameData", 0x9E487400, TdfType.List, 0, true), // GDAT
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze2SDK.Blaze.GameManager.GameBrowserGameData> _gameData = new(__typeInfos[0]);

    public GameBrowserDataList()
    {
        __members = [
            _gameData,
        ];
    }

    public override Tdf CreateNew() => new GameBrowserDataList();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GameBrowserDataList";
    public override string GetFullClassName() => "Blaze::GameManager::GameBrowserDataList";

    public IList<Blaze2SDK.Blaze.GameManager.GameBrowserGameData> GameData
    {
        get => _gameData.Value;
        set => _gameData.Value = value;
    }

}

