using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class ListGamesResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Games", "mGames", 0xB2786D00, TdfType.List, 0, true), // LGAM
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze2SDK.Blaze.GameManager.ListGameData> _games = new(__typeInfos[0]);

    public ListGamesResponse()
    {
        __members = [
            _games,
        ];
    }

    public override Tdf CreateNew() => new ListGamesResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ListGamesResponse";
    public override string GetFullClassName() => "Blaze::GameManager::ListGamesResponse";

    public IList<Blaze2SDK.Blaze.GameManager.ListGameData> Games
    {
        get => _games.Value;
        set => _games.Value = value;
    }

}

