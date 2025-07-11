using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameReportingLegacy;

public class GetGameReportViewInfo : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Name", "mName", 0xDAE86D00, TdfType.String, 0, true), // VNAM
    ];
    private ITdfMember[] __members;

    private TdfString _name = new(__typeInfos[0]);

    public GetGameReportViewInfo()
    {
        __members = [
            _name,
        ];
    }

    public override Tdf CreateNew() => new GetGameReportViewInfo();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetGameReportViewInfo";
    public override string GetFullClassName() => "Blaze::GameReportingLegacy::GetGameReportViewInfo";

    public string Name
    {
        get => _name.Value;
        set => _name.Value = value;
    }

}

