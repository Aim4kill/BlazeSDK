using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameReporting;

public class GetGameReports : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MaxGameReport", "mMaxGameReport", 0xB67CB200, TdfType.UInt32, 0, true), // MGRR
        new TdfMemberInfo("QueryName", "mQueryName", 0xC6E86D00, TdfType.String, 1, true), // QNAM
        new TdfMemberInfo("QueryVarValues", "mQueryVarValues", 0xC7687200, TdfType.List, 2, true), // QVAR
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _maxGameReport = new(__typeInfos[0]);
    private TdfString _queryName = new(__typeInfos[1]);
    private TdfList<string> _queryVarValues = new(__typeInfos[2]);

    public GetGameReports()
    {
        __members = [
            _maxGameReport,
            _queryName,
            _queryVarValues,
        ];
    }

    public override Tdf CreateNew() => new GetGameReports();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetGameReports";
    public override string GetFullClassName() => "Blaze::GameReporting::GetGameReports";

    public uint MaxGameReport
    {
        get => _maxGameReport.Value;
        set => _maxGameReport.Value = value;
    }

    public string QueryName
    {
        get => _queryName.Value;
        set => _queryName.Value = value;
    }

    public IList<string> QueryVarValues
    {
        get => _queryVarValues.Value;
        set => _queryVarValues.Value = value;
    }

}

