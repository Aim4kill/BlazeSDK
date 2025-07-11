using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Rooms;

public class ViewSpecs : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("SpecMap", "mSpecMap", 0xDAD87000, TdfType.Map, 0, true), // VMAP
    ];
    private ITdfMember[] __members;

    private TdfMap<uint, Blaze2SDK.Blaze.Rooms.RoomViewData> _specMap = new(__typeInfos[0]);

    public ViewSpecs()
    {
        __members = [
            _specMap,
        ];
    }

    public override Tdf CreateNew() => new ViewSpecs();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ViewSpecs";
    public override string GetFullClassName() => "Blaze::Rooms::ViewSpecs";

    public IDictionary<uint, Blaze2SDK.Blaze.Rooms.RoomViewData> SpecMap
    {
        get => _specMap.Value;
        set => _specMap.Value = value;
    }

}

