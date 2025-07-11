using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.League;

public class GetMembersRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("LeagueId", "mLeagueId", 0xB27A6400, TdfType.UInt32, 0, true), // LGID
        new TdfMemberInfo("SkipGamesRemaining", "mSkipGamesRemaining", 0xCEBA7000, TdfType.Int32, 1, true), // SKIP
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _leagueId = new(__typeInfos[0]);
    private TdfInt32 _skipGamesRemaining = new(__typeInfos[1]);

    public GetMembersRequest()
    {
        __members = [
            _leagueId,
            _skipGamesRemaining,
        ];
    }

    public override Tdf CreateNew() => new GetMembersRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetMembersRequest";
    public override string GetFullClassName() => "Blaze::League::GetMembersRequest";

    public uint LeagueId
    {
        get => _leagueId.Value;
        set => _leagueId.Value = value;
    }

    public int SkipGamesRemaining
    {
        get => _skipGamesRemaining.Value;
        set => _skipGamesRemaining.Value = value;
    }

}

