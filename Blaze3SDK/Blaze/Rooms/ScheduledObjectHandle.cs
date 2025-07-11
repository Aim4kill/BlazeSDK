using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rooms;

public class ScheduledObjectHandle : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ScheduledId", "mScheduledId", 0xCEFA6400, TdfType.UInt32, 0, true), // SOID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _scheduledId = new(__typeInfos[0]);

    public ScheduledObjectHandle()
    {
        __members = [
            _scheduledId,
        ];
    }

    public override Tdf CreateNew() => new ScheduledObjectHandle();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ScheduledObjectHandle";
    public override string GetFullClassName() => "Blaze::Rooms::ScheduledObjectHandle";

    public uint ScheduledId
    {
        get => _scheduledId.Value;
        set => _scheduledId.Value = value;
    }

}

