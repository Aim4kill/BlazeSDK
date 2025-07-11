using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.League;

public class GetRecentGamesResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Results", "mResults", 0xCA39ED00, TdfType.List, 0, true), // RCGM
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze3SDK.Blaze.League.GameResult> _results = new(__typeInfos[0]);

    public GetRecentGamesResponse()
    {
        __members = [
            _results,
        ];
    }

    public override Tdf CreateNew() => new GetRecentGamesResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetRecentGamesResponse";
    public override string GetFullClassName() => "Blaze::League::GetRecentGamesResponse";

    public IList<Blaze3SDK.Blaze.League.GameResult> Results
    {
        get => _results.Value;
        set => _results.Value = value;
    }

}

