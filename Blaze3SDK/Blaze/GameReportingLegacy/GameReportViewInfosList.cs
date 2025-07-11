using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameReportingLegacy;

public class GameReportViewInfosList : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ViewInfo", "mViewInfo", 0x9F2C3300, TdfType.List, 0, true), // GRPS
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze3SDK.Blaze.GameReportingLegacy.GameReportViewInfo> _viewInfo = new(__typeInfos[0]);

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
    public override string GetFullClassName() => "Blaze::GameReportingLegacy::GameReportViewInfosList";

    public IList<Blaze3SDK.Blaze.GameReportingLegacy.GameReportViewInfo> ViewInfo
    {
        get => _viewInfo.Value;
        set => _viewInfo.Value = value;
    }

}

