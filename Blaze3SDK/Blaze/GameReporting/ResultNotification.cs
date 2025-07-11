using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameReporting;

public class ResultNotification : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CustomData", "mCustomData", 0x921D2100, TdfType.Variable, 0, true), // DATA
        new TdfMemberInfo("BlazeError", "mBlazeError", 0x972BF200, TdfType.Int32, 1, true), // EROR
        new TdfMemberInfo("FinalResult", "mFinalResult", 0x9AEB0000, TdfType.Bool, 2, true), // FNL
        new TdfMemberInfo("GameHistoryId", "mGameHistoryId", 0x9E8A6400, TdfType.UInt64, 3, true), // GHID
        new TdfMemberInfo("GameReportingId", "mGameReportingId", 0x9F2A6400, TdfType.UInt64, 4, true), // GRID
    ];
    private ITdfMember[] __members;

    private TdfVariable _customData = new(__typeInfos[0]);
    private TdfInt32 _blazeError = new(__typeInfos[1]);
    private TdfBool _finalResult = new(__typeInfos[2]);
    private TdfUInt64 _gameHistoryId = new(__typeInfos[3]);
    private TdfUInt64 _gameReportingId = new(__typeInfos[4]);

    public ResultNotification()
    {
        __members = [
            _customData,
            _blazeError,
            _finalResult,
            _gameHistoryId,
            _gameReportingId,
        ];
    }

    public override Tdf CreateNew() => new ResultNotification();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ResultNotification";
    public override string GetFullClassName() => "Blaze::GameReporting::ResultNotification";

    public object? CustomData
    {
        get => _customData.Value;
        set => _customData.Value = value;
    }

    public int BlazeError
    {
        get => _blazeError.Value;
        set => _blazeError.Value = value;
    }

    public bool FinalResult
    {
        get => _finalResult.Value;
        set => _finalResult.Value = value;
    }

    public ulong GameHistoryId
    {
        get => _gameHistoryId.Value;
        set => _gameHistoryId.Value = value;
    }

    public ulong GameReportingId
    {
        get => _gameReportingId.Value;
        set => _gameReportingId.Value = value;
    }

}

