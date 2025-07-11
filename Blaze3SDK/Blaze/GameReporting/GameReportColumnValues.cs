using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameReporting;

public class GameReportColumnValues : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Values", "mValues", 0xDA1B3500, TdfType.List, 0, true), // VALU
    ];
    private ITdfMember[] __members;

    private TdfList<string> _values = new(__typeInfos[0]);

    public GameReportColumnValues()
    {
        __members = [
            _values,
        ];
    }

    public override Tdf CreateNew() => new GameReportColumnValues();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GameReportColumnValues";
    public override string GetFullClassName() => "Blaze::GameReporting::GameReportColumnValues";

    public IList<string> Values
    {
        get => _values.Value;
        set => _values.Value = value;
    }

}

