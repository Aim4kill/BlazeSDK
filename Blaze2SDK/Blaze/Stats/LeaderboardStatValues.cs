using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Stats;

public class LeaderboardStatValues : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Rows", "mRows", 0xB24B3300, TdfType.List, 0, true), // LDLS
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze2SDK.Blaze.Stats.LeaderboardStatValuesRow> _rows = new(__typeInfos[0]);

    public LeaderboardStatValues()
    {
        __members = [
            _rows,
        ];
    }

    public override Tdf CreateNew() => new LeaderboardStatValues();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "LeaderboardStatValues";
    public override string GetFullClassName() => "Blaze::Stats::LeaderboardStatValues";

    public IList<Blaze2SDK.Blaze.Stats.LeaderboardStatValuesRow> Rows
    {
        get => _rows.Value;
        set => _rows.Value = value;
    }

}

