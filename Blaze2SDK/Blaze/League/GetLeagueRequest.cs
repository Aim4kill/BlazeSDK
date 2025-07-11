using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.League;

public class GetLeagueRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("LeagueId", "mLeagueId", 0xB27A6400, TdfType.UInt32, 0, true), // LGID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _leagueId = new(__typeInfos[0]);

    public GetLeagueRequest()
    {
        __members = [
            _leagueId,
        ];
    }

    public override Tdf CreateNew() => new GetLeagueRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetLeagueRequest";
    public override string GetFullClassName() => "Blaze::League::GetLeagueRequest";

    public uint LeagueId
    {
        get => _leagueId.Value;
        set => _leagueId.Value = value;
    }

}

