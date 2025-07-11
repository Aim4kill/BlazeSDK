using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Tournaments;

public class GetTournamentsResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Tournaments", "mTournaments", 0xD32BB300, TdfType.List, 0, true), // TRNS
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze2SDK.Blaze.Tournaments.TournamentData> _tournaments = new(__typeInfos[0]);

    public GetTournamentsResponse()
    {
        __members = [
            _tournaments,
        ];
    }

    public override Tdf CreateNew() => new GetTournamentsResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetTournamentsResponse";
    public override string GetFullClassName() => "Blaze::Tournaments::GetTournamentsResponse";

    public IList<Blaze2SDK.Blaze.Tournaments.TournamentData> Tournaments
    {
        get => _tournaments.Value;
        set => _tournaments.Value = value;
    }

}

