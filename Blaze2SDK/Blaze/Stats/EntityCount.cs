using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Stats;

public class EntityCount : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Count", "mCount", 0x8EED0000, TdfType.Int32, 0, true), // CNT
    ];
    private ITdfMember[] __members;

    private TdfInt32 _count = new(__typeInfos[0]);

    public EntityCount()
    {
        __members = [
            _count,
        ];
    }

    public override Tdf CreateNew() => new EntityCount();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "EntityCount";
    public override string GetFullClassName() => "Blaze::Stats::EntityCount";

    public int Count
    {
        get => _count.Value;
        set => _count.Value = value;
    }

}

