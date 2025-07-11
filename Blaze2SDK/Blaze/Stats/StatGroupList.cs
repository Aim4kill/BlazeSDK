using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Stats;

public class StatGroupList : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Groups", "mGroups", 0x9F2C3300, TdfType.List, 0, true), // GRPS
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze2SDK.Blaze.Stats.StatGroupSummary> _groups = new(__typeInfos[0]);

    public StatGroupList()
    {
        __members = [
            _groups,
        ];
    }

    public override Tdf CreateNew() => new StatGroupList();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "StatGroupList";
    public override string GetFullClassName() => "Blaze::Stats::StatGroupList";

    public IList<Blaze2SDK.Blaze.Stats.StatGroupSummary> Groups
    {
        get => _groups.Value;
        set => _groups.Value = value;
    }

}

