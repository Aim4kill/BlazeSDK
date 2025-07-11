using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.League;

public class MemberStats : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GoalsAgainst", "mGoalsAgainst", 0x9EFB2100, TdfType.Int32, 0, true), // GOLA
        new TdfMemberInfo("GoalsFor", "mGoalsFor", 0x9EFB2600, TdfType.Int32, 1, true), // GOLF
        new TdfMemberInfo("Losses", "mLosses", 0xB2FCF300, TdfType.Int32, 2, true), // LOSS
        new TdfMemberInfo("Persona", "mPersona", 0xBA1B6500, TdfType.String, 3, true), // NAME
        new TdfMemberInfo("Points", "mPoints", 0xC2ED3300, TdfType.Int32, 4, true), // PNTS
        new TdfMemberInfo("Rank", "mRank", 0xCA1BAB00, TdfType.Int32, 5, true), // RANK
        new TdfMemberInfo("Ties", "mTies", 0xD2997300, TdfType.Int32, 6, true), // TIES
        new TdfMemberInfo("Wins", "mWins", 0xDE9BB300, TdfType.Int32, 7, true), // WINS
    ];
    private ITdfMember[] __members;

    private TdfInt32 _goalsAgainst = new(__typeInfos[0]);
    private TdfInt32 _goalsFor = new(__typeInfos[1]);
    private TdfInt32 _losses = new(__typeInfos[2]);
    private TdfString _persona = new(__typeInfos[3]);
    private TdfInt32 _points = new(__typeInfos[4]);
    private TdfInt32 _rank = new(__typeInfos[5]);
    private TdfInt32 _ties = new(__typeInfos[6]);
    private TdfInt32 _wins = new(__typeInfos[7]);

    public MemberStats()
    {
        __members = [
            _goalsAgainst,
            _goalsFor,
            _losses,
            _persona,
            _points,
            _rank,
            _ties,
            _wins,
        ];
    }

    public override Tdf CreateNew() => new MemberStats();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "MemberStats";
    public override string GetFullClassName() => "Blaze::League::MemberStats";

    public int GoalsAgainst
    {
        get => _goalsAgainst.Value;
        set => _goalsAgainst.Value = value;
    }

    public int GoalsFor
    {
        get => _goalsFor.Value;
        set => _goalsFor.Value = value;
    }

    public int Losses
    {
        get => _losses.Value;
        set => _losses.Value = value;
    }

    public string Persona
    {
        get => _persona.Value;
        set => _persona.Value = value;
    }

    public int Points
    {
        get => _points.Value;
        set => _points.Value = value;
    }

    public int Rank
    {
        get => _rank.Value;
        set => _rank.Value = value;
    }

    public int Ties
    {
        get => _ties.Value;
        set => _ties.Value = value;
    }

    public int Wins
    {
        get => _wins.Value;
        set => _wins.Value = value;
    }

}

