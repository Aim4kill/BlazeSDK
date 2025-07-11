using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameReporting;

public class GetGameReportColumnInfo : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Name", "mName", 0xBA1B6500, TdfType.String, 0, true), // NAME
    ];
    private ITdfMember[] __members;

    private TdfString _name = new(__typeInfos[0]);

    public GetGameReportColumnInfo()
    {
        __members = [
            _name,
        ];
    }

    public override Tdf CreateNew() => new GetGameReportColumnInfo();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetGameReportColumnInfo";
    public override string GetFullClassName() => "Blaze::GameReporting::GetGameReportColumnInfo";

    public string Name
    {
        get => _name.Value;
        set => _name.Value = value;
    }

}

