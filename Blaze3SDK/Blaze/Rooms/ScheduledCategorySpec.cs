using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rooms;

public class ScheduledCategorySpec : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CategoryData", "mCategoryData", 0x8E1D3300, TdfType.Struct, 0, true), // CATS
        new TdfMemberInfo("Duration", "mDuration", 0x935CA100, TdfType.UInt32, 1, true), // DURA
        new TdfMemberInfo("Recurrence", "mRecurrence", 0xCA58F500, TdfType.UInt32, 2, true), // RECU
        new TdfMemberInfo("Start", "mStart", 0xCF487200, TdfType.UInt32, 3, true), // STAR
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze3SDK.Blaze.Rooms.RoomCategoryData?> _categoryData = new(__typeInfos[0]);
    private TdfUInt32 _duration = new(__typeInfos[1]);
    private TdfUInt32 _recurrence = new(__typeInfos[2]);
    private TdfUInt32 _start = new(__typeInfos[3]);

    public ScheduledCategorySpec()
    {
        __members = [
            _categoryData,
            _duration,
            _recurrence,
            _start,
        ];
    }

    public override Tdf CreateNew() => new ScheduledCategorySpec();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ScheduledCategorySpec";
    public override string GetFullClassName() => "Blaze::Rooms::ScheduledCategorySpec";

    public Blaze3SDK.Blaze.Rooms.RoomCategoryData? CategoryData
    {
        get => _categoryData.Value;
        set => _categoryData.Value = value;
    }

    public uint Duration
    {
        get => _duration.Value;
        set => _duration.Value = value;
    }

    public uint Recurrence
    {
        get => _recurrence.Value;
        set => _recurrence.Value = value;
    }

    public uint Start
    {
        get => _start.Value;
        set => _start.Value = value;
    }

}

