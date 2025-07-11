using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rooms;

public class ScheduledCategory : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ScheduledSpec", "mScheduledSpec", 0xCE3A3300, TdfType.Struct, 0, true), // SCHS
        new TdfMemberInfo("ScheduledId", "mScheduledId", 0xCEFA6400, TdfType.UInt32, 1, true), // SOID
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze3SDK.Blaze.Rooms.ScheduledCategorySpec?> _scheduledSpec = new(__typeInfos[0]);
    private TdfUInt32 _scheduledId = new(__typeInfos[1]);

    public ScheduledCategory()
    {
        __members = [
            _scheduledSpec,
            _scheduledId,
        ];
    }

    public override Tdf CreateNew() => new ScheduledCategory();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ScheduledCategory";
    public override string GetFullClassName() => "Blaze::Rooms::ScheduledCategory";

    public Blaze3SDK.Blaze.Rooms.ScheduledCategorySpec? ScheduledSpec
    {
        get => _scheduledSpec.Value;
        set => _scheduledSpec.Value = value;
    }

    public uint ScheduledId
    {
        get => _scheduledId.Value;
        set => _scheduledId.Value = value;
    }

}

