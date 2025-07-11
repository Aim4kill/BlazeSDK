using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameReporting;

public class GameReportView : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("EntityIds", "mEntityIds", 0x96EA6400, TdfType.List, 0, true), // ENID
        new TdfMemberInfo("Columns", "mColumns", 0xB27CA300, TdfType.List, 1, true), // LGRC
    ];
    private ITdfMember[] __members;

    private TdfList<uint> _entityIds = new(__typeInfos[0]);
    private TdfList<Blaze2SDK.Blaze.GameReporting.GameReportColumn> _columns = new(__typeInfos[1]);

    public GameReportView()
    {
        __members = [
            _entityIds,
            _columns,
        ];
    }

    public override Tdf CreateNew() => new GameReportView();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GameReportView";
    public override string GetFullClassName() => "Blaze::GameReporting::GameReportView";

    public IList<uint> EntityIds
    {
        get => _entityIds.Value;
        set => _entityIds.Value = value;
    }

    public IList<Blaze2SDK.Blaze.GameReporting.GameReportColumn> Columns
    {
        get => _columns.Value;
        set => _columns.Value = value;
    }

}

