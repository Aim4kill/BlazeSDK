using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameReporting;

public class SubmitGameReportRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("FinishedStatus", "mFinishedStatus", 0x9AECE800, TdfType.Enum, 0, true), // FNSH
        new TdfMemberInfo("PrivateReport", "mPrivateReport", 0xC32DB400, TdfType.Variable, 1, true), // PRVT
        new TdfMemberInfo("GameReport", "mGameReport", 0xCB0CB400, TdfType.Struct, 2, true), // RPRT
    ];
    private ITdfMember[] __members;

    private TdfEnum<Blaze3SDK.Blaze.GameReporting.GameReportPlayerFinishedStatus> _finishedStatus = new(__typeInfos[0]);
    private TdfVariable _privateReport = new(__typeInfos[1]);
    private TdfStruct<Blaze3SDK.Blaze.GameReporting.GameReport?> _gameReport = new(__typeInfos[2]);

    public SubmitGameReportRequest()
    {
        __members = [
            _finishedStatus,
            _privateReport,
            _gameReport,
        ];
    }

    public override Tdf CreateNew() => new SubmitGameReportRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "SubmitGameReportRequest";
    public override string GetFullClassName() => "Blaze::GameReporting::SubmitGameReportRequest";

    public Blaze3SDK.Blaze.GameReporting.GameReportPlayerFinishedStatus FinishedStatus
    {
        get => _finishedStatus.Value;
        set => _finishedStatus.Value = value;
    }

    public object? PrivateReport
    {
        get => _privateReport.Value;
        set => _privateReport.Value = value;
    }

    public Blaze3SDK.Blaze.GameReporting.GameReport? GameReport
    {
        get => _gameReport.Value;
        set => _gameReport.Value = value;
    }

}

