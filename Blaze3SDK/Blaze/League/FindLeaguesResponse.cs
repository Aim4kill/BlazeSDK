using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.League;

public class FindLeaguesResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Leagues", "mLeagues", 0xB2CCF400, TdfType.List, 0, true), // LLST
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze3SDK.Blaze.League.League> _leagues = new(__typeInfos[0]);

    public FindLeaguesResponse()
    {
        __members = [
            _leagues,
        ];
    }

    public override Tdf CreateNew() => new FindLeaguesResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "FindLeaguesResponse";
    public override string GetFullClassName() => "Blaze::League::FindLeaguesResponse";

    public IList<Blaze3SDK.Blaze.League.League> Leagues
    {
        get => _leagues.Value;
        set => _leagues.Value = value;
    }

}

