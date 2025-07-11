using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameReportingLegacy;

public class GameReportViewInfo : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Desc", "mDesc", 0x925CE300, TdfType.String, 0, true), // DESC
        new TdfMemberInfo("Metadata", "mMetadata", 0xB65D2100, TdfType.String, 1, true), // META
        new TdfMemberInfo("Name", "mName", 0xDAE86D00, TdfType.String, 2, true), // VNAM
    ];
    private ITdfMember[] __members;

    private TdfString _desc = new(__typeInfos[0]);
    private TdfString _metadata = new(__typeInfos[1]);
    private TdfString _name = new(__typeInfos[2]);

    public GameReportViewInfo()
    {
        __members = [
            _desc,
            _metadata,
            _name,
        ];
    }

    public override Tdf CreateNew() => new GameReportViewInfo();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GameReportViewInfo";
    public override string GetFullClassName() => "Blaze::GameReportingLegacy::GameReportViewInfo";

    public string Desc
    {
        get => _desc.Value;
        set => _desc.Value = value;
    }

    public string Metadata
    {
        get => _metadata.Value;
        set => _metadata.Value = value;
    }

    public string Name
    {
        get => _name.Value;
        set => _name.Value = value;
    }

}

