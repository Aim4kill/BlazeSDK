using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameReporting;

public class GameReportViewInfosList : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ViewInfo", "mViewInfo", 0xA6E9AF00, TdfType.List, 0, true), // INFO
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze3SDK.Blaze.GameReporting.GameReportViewInfo> _viewInfo = new(__typeInfos[0]);

    public GameReportViewInfosList()
    {
        __members = [
            _viewInfo,
        ];
    }

    public override Tdf CreateNew() => new GameReportViewInfosList();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GameReportViewInfosList";
    public override string GetFullClassName() => "Blaze::GameReporting::GameReportViewInfosList";

    public IList<Blaze3SDK.Blaze.GameReporting.GameReportViewInfo> ViewInfo
    {
        get => _viewInfo.Value;
        set => _viewInfo.Value = value;
    }

}

