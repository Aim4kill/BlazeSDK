using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Stats;

public class GetDateRangeRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Category", "mCategory", 0x8E1D0000, TdfType.String, 0, true), // CAT
        new TdfMemberInfo("PeriodOffset", "mPeriodOffset", 0xC2F9A600, TdfType.Int32, 1, true), // POFF
        new TdfMemberInfo("PeriodType", "mPeriodType", 0xC34E7000, TdfType.Int32, 2, true), // PTYP
    ];
    private ITdfMember[] __members;

    private TdfString _category = new(__typeInfos[0]);
    private TdfInt32 _periodOffset = new(__typeInfos[1]);
    private TdfInt32 _periodType = new(__typeInfos[2]);

    public GetDateRangeRequest()
    {
        __members = [
            _category,
            _periodOffset,
            _periodType,
        ];
    }

    public override Tdf CreateNew() => new GetDateRangeRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetDateRangeRequest";
    public override string GetFullClassName() => "Blaze::Stats::GetDateRangeRequest";

    public string Category
    {
        get => _category.Value;
        set => _category.Value = value;
    }

    public int PeriodOffset
    {
        get => _periodOffset.Value;
        set => _periodOffset.Value = value;
    }

    public int PeriodType
    {
        get => _periodType.Value;
        set => _periodType.Value = value;
    }

}

