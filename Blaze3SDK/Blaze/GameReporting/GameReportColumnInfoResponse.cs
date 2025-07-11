using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameReporting;

public class GameReportColumnInfoResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ColumnInfoList", "mColumnInfoList", 0x8E9B0000, TdfType.List, 0, true), // CIL
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze3SDK.Blaze.GameReporting.GameReportColumnInfo> _columnInfoList = new(__typeInfos[0]);

    public GameReportColumnInfoResponse()
    {
        __members = [
            _columnInfoList,
        ];
    }

    public override Tdf CreateNew() => new GameReportColumnInfoResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GameReportColumnInfoResponse";
    public override string GetFullClassName() => "Blaze::GameReporting::GameReportColumnInfoResponse";

    public IList<Blaze3SDK.Blaze.GameReporting.GameReportColumnInfo> ColumnInfoList
    {
        get => _columnInfoList.Value;
        set => _columnInfoList.Value = value;
    }

}

