using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameReporting;

public class GameReportQueriesList : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Queries", "mQueries", 0xC7597200, TdfType.List, 0, true), // QUER
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze3SDK.Blaze.GameReporting.GameReportQuery> _queries = new(__typeInfos[0]);

    public GameReportQueriesList()
    {
        __members = [
            _queries,
        ];
    }

    public override Tdf CreateNew() => new GameReportQueriesList();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GameReportQueriesList";
    public override string GetFullClassName() => "Blaze::GameReporting::GameReportQueriesList";

    public IList<Blaze3SDK.Blaze.GameReporting.GameReportQuery> Queries
    {
        get => _queries.Value;
        set => _queries.Value = value;
    }

}

