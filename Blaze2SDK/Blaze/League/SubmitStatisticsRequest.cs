using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.League;

public class SubmitStatisticsRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Category", "mCategory", 0x8E1D2500, TdfType.String, 0, true), // CATE
        new TdfMemberInfo("Context", "mContext", 0x8F4E3400, TdfType.Int32, 1, true), // CTXT
        new TdfMemberInfo("Entities", "mEntities", 0x96ED3300, TdfType.List, 2, true), // ENTS
        new TdfMemberInfo("NumEntities", "mNumEntities", 0xBA5BB400, TdfType.Int32, 3, true), // NENT
        new TdfMemberInfo("NumStats", "mNumStats", 0xBB3D2100, TdfType.Int32, 4, true), // NSTA
        new TdfMemberInfo("Stats", "mStats", 0xCF487400, TdfType.List, 5, true), // STAT
    ];
    private ITdfMember[] __members;

    private TdfString _category = new(__typeInfos[0]);
    private TdfInt32 _context = new(__typeInfos[1]);
    private TdfList<uint> _entities = new(__typeInfos[2]);
    private TdfInt32 _numEntities = new(__typeInfos[3]);
    private TdfInt32 _numStats = new(__typeInfos[4]);
    private TdfList<int> _stats = new(__typeInfos[5]);

    public SubmitStatisticsRequest()
    {
        __members = [
            _category,
            _context,
            _entities,
            _numEntities,
            _numStats,
            _stats,
        ];
    }

    public override Tdf CreateNew() => new SubmitStatisticsRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "SubmitStatisticsRequest";
    public override string GetFullClassName() => "Blaze::League::SubmitStatisticsRequest";

    public string Category
    {
        get => _category.Value;
        set => _category.Value = value;
    }

    public int Context
    {
        get => _context.Value;
        set => _context.Value = value;
    }

    public IList<uint> Entities
    {
        get => _entities.Value;
        set => _entities.Value = value;
    }

    public int NumEntities
    {
        get => _numEntities.Value;
        set => _numEntities.Value = value;
    }

    public int NumStats
    {
        get => _numStats.Value;
        set => _numStats.Value = value;
    }

    public IList<int> Stats
    {
        get => _stats.Value;
        set => _stats.Value = value;
    }

}

