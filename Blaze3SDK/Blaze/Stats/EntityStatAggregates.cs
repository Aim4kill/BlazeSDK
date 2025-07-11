using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Stats;

public class EntityStatAggregates : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AggrValues", "mAggrValues", 0x8679F200, TdfType.List, 0, true), // AGGR
        new TdfMemberInfo("Type", "mType", 0xD39C2500, TdfType.Enum, 1, true), // TYPE
    ];
    private ITdfMember[] __members;

    private TdfList<string> _aggrValues = new(__typeInfos[0]);
    private TdfEnum<Blaze3SDK.Blaze.Stats.AggregateType> _type = new(__typeInfos[1]);

    public EntityStatAggregates()
    {
        __members = [
            _aggrValues,
            _type,
        ];
    }

    public override Tdf CreateNew() => new EntityStatAggregates();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "EntityStatAggregates";
    public override string GetFullClassName() => "Blaze::Stats::EntityStatAggregates";

    public IList<string> AggrValues
    {
        get => _aggrValues.Value;
        set => _aggrValues.Value = value;
    }

    public Blaze3SDK.Blaze.Stats.AggregateType Type
    {
        get => _type.Value;
        set => _type.Value = value;
    }

}

