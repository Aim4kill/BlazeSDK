using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameReporting;

public class GameReportQuery : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ColumnKeyList", "mColumnKeyList", 0x8EFB3300, TdfType.List, 0, true), // COLS
        new TdfMemberInfo("FilterList", "mFilterList", 0x9A9B3400, TdfType.List, 1, true), // FILT
        new TdfMemberInfo("TypeName", "mTypeName", 0x9F4E7000, TdfType.String, 2, true), // GTYP
        new TdfMemberInfo("MaxGameReport", "mMaxGameReport", 0xB67CB200, TdfType.UInt32, 3, true), // MGRR
        new TdfMemberInfo("Name", "mName", 0xC6E86D00, TdfType.String, 4, true), // QNAM
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze3SDK.Blaze.GameReporting.GameReportColumnKey> _columnKeyList = new(__typeInfos[0]);
    private TdfList<Blaze3SDK.Blaze.GameReporting.GameReportFilter> _filterList = new(__typeInfos[1]);
    private TdfString _typeName = new(__typeInfos[2]);
    private TdfUInt32 _maxGameReport = new(__typeInfos[3]);
    private TdfString _name = new(__typeInfos[4]);

    public GameReportQuery()
    {
        __members = [
            _columnKeyList,
            _filterList,
            _typeName,
            _maxGameReport,
            _name,
        ];
    }

    public override Tdf CreateNew() => new GameReportQuery();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GameReportQuery";
    public override string GetFullClassName() => "Blaze::GameReporting::GameReportQuery";

    public IList<Blaze3SDK.Blaze.GameReporting.GameReportColumnKey> ColumnKeyList
    {
        get => _columnKeyList.Value;
        set => _columnKeyList.Value = value;
    }

    public IList<Blaze3SDK.Blaze.GameReporting.GameReportFilter> FilterList
    {
        get => _filterList.Value;
        set => _filterList.Value = value;
    }

    public string TypeName
    {
        get => _typeName.Value;
        set => _typeName.Value = value;
    }

    public uint MaxGameReport
    {
        get => _maxGameReport.Value;
        set => _maxGameReport.Value = value;
    }

    public string Name
    {
        get => _name.Value;
        set => _name.Value = value;
    }

}

