using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Rooms;

public class ScheduledCategorySpecs : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("SpecMap", "mSpecMap", 0x8ED87000, TdfType.Map, 0, true), // CMAP
    ];
    private ITdfMember[] __members;

    private TdfMap<uint, Blaze2SDK.Blaze.Rooms.ScheduledCategorySpec> _specMap = new(__typeInfos[0]);

    public ScheduledCategorySpecs()
    {
        __members = [
            _specMap,
        ];
    }

    public override Tdf CreateNew() => new ScheduledCategorySpecs();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ScheduledCategorySpecs";
    public override string GetFullClassName() => "Blaze::Rooms::ScheduledCategorySpecs";

    public IDictionary<uint, Blaze2SDK.Blaze.Rooms.ScheduledCategorySpec> SpecMap
    {
        get => _specMap.Value;
        set => _specMap.Value = value;
    }

}

