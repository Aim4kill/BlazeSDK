using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Stats;

public class DateRange : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("End", "mEnd", 0x96E90000, TdfType.UInt32, 0, true), // END
        new TdfMemberInfo("Start", "mStart", 0xCF4CB400, TdfType.UInt32, 1, true), // STRT
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _end = new(__typeInfos[0]);
    private TdfUInt32 _start = new(__typeInfos[1]);

    public DateRange()
    {
        __members = [
            _end,
            _start,
        ];
    }

    public override Tdf CreateNew() => new DateRange();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "DateRange";
    public override string GetFullClassName() => "Blaze::Stats::DateRange";

    public uint End
    {
        get => _end.Value;
        set => _end.Value = value;
    }

    public uint Start
    {
        get => _start.Value;
        set => _start.Value = value;
    }

}

