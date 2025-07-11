using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Stats;

public class StatDescs : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("EntityType", "mEntityType", 0x974E7000, TdfType.ObjectType, 0, true), // ETYP
        new TdfMemberInfo("StatDescs", "mStatDescs", 0xCF487400, TdfType.List, 1, true), // STAT
    ];
    private ITdfMember[] __members;

    private TdfObjectType _entityType = new(__typeInfos[0]);
    private TdfList<Blaze3SDK.Blaze.Stats.StatDescSummary> _statDescs = new(__typeInfos[1]);

    public StatDescs()
    {
        __members = [
            _entityType,
            _statDescs,
        ];
    }

    public override Tdf CreateNew() => new StatDescs();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "StatDescs";
    public override string GetFullClassName() => "Blaze::Stats::StatDescs";

    public ObjectType EntityType
    {
        get => _entityType.Value;
        set => _entityType.Value = value;
    }

    public IList<Blaze3SDK.Blaze.Stats.StatDescSummary> mStatDescs
    {
        get => _statDescs.Value;
        set => _statDescs.Value = value;
    }

}

