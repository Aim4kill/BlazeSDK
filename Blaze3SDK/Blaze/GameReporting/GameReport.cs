using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameReporting;

public class GameReport : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Report", "mReport", 0x9E1B6500, TdfType.Variable, 0, true), // GAME
        new TdfMemberInfo("GameReportingId", "mGameReportingId", 0x9F2A6400, TdfType.UInt64, 1, true), // GRID
        new TdfMemberInfo("GameTypeName", "mGameTypeName", 0x9F4E7000, TdfType.String, 2, true), // GTYP
    ];
    private ITdfMember[] __members;

    private TdfVariable _report = new(__typeInfos[0]);
    private TdfUInt64 _gameReportingId = new(__typeInfos[1]);
    private TdfString _gameTypeName = new(__typeInfos[2]);

    public GameReport()
    {
        __members = [
            _report,
            _gameReportingId,
            _gameTypeName,
        ];
    }

    public override Tdf CreateNew() => new GameReport();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GameReport";
    public override string GetFullClassName() => "Blaze::GameReporting::GameReport";

    public object? Report
    {
        get => _report.Value;
        set => _report.Value = value;
    }

    public ulong GameReportingId
    {
        get => _gameReportingId.Value;
        set => _gameReportingId.Value = value;
    }

    public string GameTypeName
    {
        get => _gameTypeName.Value;
        set => _gameTypeName.Value = value;
    }

}

