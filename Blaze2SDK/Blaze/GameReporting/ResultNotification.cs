using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameReporting;

public class ResultNotification : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("BlazeError", "mBlazeError", 0x972BF200, TdfType.Int32, 0, true), // EROR
        new TdfMemberInfo("FinalResult", "mFinalResult", 0x9AEB0000, TdfType.Bool, 1, true), // FNL
        new TdfMemberInfo("GameReportingId", "mGameReportingId", 0x9F2A6400, TdfType.UInt32, 2, true), // GRID
    ];
    private ITdfMember[] __members;

    private TdfInt32 _blazeError = new(__typeInfos[0]);
    private TdfBool _finalResult = new(__typeInfos[1]);
    private TdfUInt32 _gameReportingId = new(__typeInfos[2]);

    public ResultNotification()
    {
        __members = [
            _blazeError,
            _finalResult,
            _gameReportingId,
        ];
    }

    public override Tdf CreateNew() => new ResultNotification();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ResultNotification";
    public override string GetFullClassName() => "Blaze::GameReporting::ResultNotification";

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

    public uint GameReportingId
    {
        get => _gameReportingId.Value;
        set => _gameReportingId.Value = value;
    }

}

