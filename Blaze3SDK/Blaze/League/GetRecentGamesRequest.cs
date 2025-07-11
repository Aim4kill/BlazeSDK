using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.League;

public class GetRecentGamesRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Count", "mCount", 0x8EFBB400, TdfType.UInt32, 0, true), // CONT
        new TdfMemberInfo("LeagueId", "mLeagueId", 0xB27A6400, TdfType.UInt32, 1, true), // LGID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _count = new(__typeInfos[0]);
    private TdfUInt32 _leagueId = new(__typeInfos[1]);

    public GetRecentGamesRequest()
    {
        __members = [
            _count,
            _leagueId,
        ];
    }

    public override Tdf CreateNew() => new GetRecentGamesRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetRecentGamesRequest";
    public override string GetFullClassName() => "Blaze::League::GetRecentGamesRequest";

    public uint Count
    {
        get => _count.Value;
        set => _count.Value = value;
    }

    public uint LeagueId
    {
        get => _leagueId.Value;
        set => _leagueId.Value = value;
    }

}

