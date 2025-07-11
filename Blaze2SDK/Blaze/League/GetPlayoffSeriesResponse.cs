using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.League;

public class GetPlayoffSeriesResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("LeagueId", "mLeagueId", 0xB27A6400, TdfType.UInt32, 0, true), // LGID
        new TdfMemberInfo("PlayoffSeries", "mPlayoffSeries", 0xCAE93300, TdfType.List, 1, true), // RNDS
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _leagueId = new(__typeInfos[0]);
    private TdfList<Blaze2SDK.Blaze.League.PlayoffSeries> _playoffSeries = new(__typeInfos[1]);

    public GetPlayoffSeriesResponse()
    {
        __members = [
            _leagueId,
            _playoffSeries,
        ];
    }

    public override Tdf CreateNew() => new GetPlayoffSeriesResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetPlayoffSeriesResponse";
    public override string GetFullClassName() => "Blaze::League::GetPlayoffSeriesResponse";

    public uint LeagueId
    {
        get => _leagueId.Value;
        set => _leagueId.Value = value;
    }

    public IList<Blaze2SDK.Blaze.League.PlayoffSeries> PlayoffSeries
    {
        get => _playoffSeries.Value;
        set => _playoffSeries.Value = value;
    }

}

