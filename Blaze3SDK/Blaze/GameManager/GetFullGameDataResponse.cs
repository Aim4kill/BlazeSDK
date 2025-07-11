using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class GetFullGameDataResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Games", "mGames", 0xB2786D00, TdfType.List, 0, true), // LGAM
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze3SDK.Blaze.GameManager.ListGameData> _games = new(__typeInfos[0]);

    public GetFullGameDataResponse()
    {
        __members = [
            _games,
        ];
    }

    public override Tdf CreateNew() => new GetFullGameDataResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetFullGameDataResponse";
    public override string GetFullClassName() => "Blaze::GameManager::GetFullGameDataResponse";

    public IList<Blaze3SDK.Blaze.GameManager.ListGameData> Games
    {
        get => _games.Value;
        set => _games.Value = value;
    }

}

