using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameReporting;

public class GetGameReportViewRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MaxRows", "mMaxRows", 0xB61E3200, TdfType.UInt32, 0, true), // MAXR
        new TdfMemberInfo("Name", "mName", 0xBA1B6500, TdfType.String, 1, true), // NAME
        new TdfMemberInfo("QueryVarValues", "mQueryVarValues", 0xC7687200, TdfType.List, 2, true), // QVAR
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _maxRows = new(__typeInfos[0]);
    private TdfString _name = new(__typeInfos[1]);
    private TdfList<string> _queryVarValues = new(__typeInfos[2]);

    public GetGameReportViewRequest()
    {
        __members = [
            _maxRows,
            _name,
            _queryVarValues,
        ];
    }

    public override Tdf CreateNew() => new GetGameReportViewRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetGameReportViewRequest";
    public override string GetFullClassName() => "Blaze::GameReporting::GetGameReportViewRequest";

    public uint MaxRows
    {
        get => _maxRows.Value;
        set => _maxRows.Value = value;
    }

    public string Name
    {
        get => _name.Value;
        set => _name.Value = value;
    }

    public IList<string> QueryVarValues
    {
        get => _queryVarValues.Value;
        set => _queryVarValues.Value = value;
    }

}

