using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Stats;

public class StatDescs : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ContextType", "mContextType", 0x8F4E7000, TdfType.UInt32, 0, true), // CTYP
        new TdfMemberInfo("EntityType", "mEntityType", 0x974E7000, TdfType.UInt32, 1, true), // ETYP
        new TdfMemberInfo("StatDescs", "mStatDescs", 0xCF487400, TdfType.List, 2, true), // STAT
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _contextType = new(__typeInfos[0]);
    private TdfUInt32 _entityType = new(__typeInfos[1]);
    private TdfList<Blaze2SDK.Blaze.Stats.StatDescSummary> _statDescs = new(__typeInfos[2]);

    public StatDescs()
    {
        __members = [
            _contextType,
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

    public uint ContextType
    {
        get => _contextType.Value;
        set => _contextType.Value = value;
    }

    public uint EntityType
    {
        get => _entityType.Value;
        set => _entityType.Value = value;
    }

    public IList<Blaze2SDK.Blaze.Stats.StatDescSummary> mStatDescs
    {
        get => _statDescs.Value;
        set => _statDescs.Value = value;
    }

}

