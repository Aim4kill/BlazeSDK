using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Tournaments;

public class JoinTournamentResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Tournament", "mTournament", 0xD2487400, TdfType.Struct, 0, true), // TDAT
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze3SDK.Blaze.Tournaments.TournamentData?> _tournament = new(__typeInfos[0]);

    public JoinTournamentResponse()
    {
        __members = [
            _tournament,
        ];
    }

    public override Tdf CreateNew() => new JoinTournamentResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "JoinTournamentResponse";
    public override string GetFullClassName() => "Blaze::Tournaments::JoinTournamentResponse";

    public Blaze3SDK.Blaze.Tournaments.TournamentData? Tournament
    {
        get => _tournament.Value;
        set => _tournament.Value = value;
    }

}

