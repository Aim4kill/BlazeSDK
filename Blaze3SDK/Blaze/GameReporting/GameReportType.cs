using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameReporting;

public class GameReportType : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameTypeName", "mGameTypeName", 0x9F4BA100, TdfType.String, 0, true), // GTNA
        new TdfMemberInfo("HistoryTables", "mHistoryTables", 0xA29CF400, TdfType.List, 1, true), // HIST
    ];
    private ITdfMember[] __members;

    private TdfString _gameTypeName = new(__typeInfos[0]);
    private TdfList<Blaze3SDK.Blaze.GameReporting.TableData> _historyTables = new(__typeInfos[1]);

    public GameReportType()
    {
        __members = [
            _gameTypeName,
            _historyTables,
        ];
    }

    public override Tdf CreateNew() => new GameReportType();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GameReportType";
    public override string GetFullClassName() => "Blaze::GameReporting::GameReportType";

    public string GameTypeName
    {
        get => _gameTypeName.Value;
        set => _gameTypeName.Value = value;
    }

    public IList<Blaze3SDK.Blaze.GameReporting.TableData> HistoryTables
    {
        get => _historyTables.Value;
        set => _historyTables.Value = value;
    }

}

