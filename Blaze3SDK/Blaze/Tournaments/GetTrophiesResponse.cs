using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Tournaments;

public class GetTrophiesResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Trophies", "mTrophies", 0xD32BF000, TdfType.List, 0, true), // TROP
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze3SDK.Blaze.Tournaments.TournamentTrophyData> _trophies = new(__typeInfos[0]);

    public GetTrophiesResponse()
    {
        __members = [
            _trophies,
        ];
    }

    public override Tdf CreateNew() => new GetTrophiesResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetTrophiesResponse";
    public override string GetFullClassName() => "Blaze::Tournaments::GetTrophiesResponse";

    public IList<Blaze3SDK.Blaze.Tournaments.TournamentTrophyData> Trophies
    {
        get => _trophies.Value;
        set => _trophies.Value = value;
    }

}

