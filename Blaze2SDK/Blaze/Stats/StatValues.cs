using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Stats;

public class StatValues : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("EntityAggrList", "mEntityAggrList", 0x8679F200, TdfType.List, 0, true), // AGGR
        new TdfMemberInfo("EntityStatsList", "mEntityStatsList", 0xCF487400, TdfType.List, 1, true), // STAT
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze2SDK.Blaze.Stats.EntityStatAggregates> _entityAggrList = new(__typeInfos[0]);
    private TdfList<Blaze2SDK.Blaze.Stats.EntityStats> _entityStatsList = new(__typeInfos[1]);

    public StatValues()
    {
        __members = [
            _entityAggrList,
            _entityStatsList,
        ];
    }

    public override Tdf CreateNew() => new StatValues();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "StatValues";
    public override string GetFullClassName() => "Blaze::Stats::StatValues";

    public IList<Blaze2SDK.Blaze.Stats.EntityStatAggregates> EntityAggrList
    {
        get => _entityAggrList.Value;
        set => _entityAggrList.Value = value;
    }

    public IList<Blaze2SDK.Blaze.Stats.EntityStats> EntityStatsList
    {
        get => _entityStatsList.Value;
        set => _entityStatsList.Value = value;
    }

}

