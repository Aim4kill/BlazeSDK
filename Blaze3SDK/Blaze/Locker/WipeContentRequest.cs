using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Locker;

public class WipeContentRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ContentCategory", "mContentCategory", 0x8E387400, TdfType.String, 0, true), // CCAT
        new TdfMemberInfo("ContentIds", "mContentIds", 0x8E993300, TdfType.List, 1, true), // CIDS
        new TdfMemberInfo("DateRange", "mDateRange", 0x934CA700, TdfType.Struct, 2, true), // DTRG
    ];
    private ITdfMember[] __members;

    private TdfString _contentCategory = new(__typeInfos[0]);
    private TdfList<int> _contentIds = new(__typeInfos[1]);
    private TdfStruct<Blaze3SDK.Blaze.Locker.DateRange?> _dateRange = new(__typeInfos[2]);

    public WipeContentRequest()
    {
        __members = [
            _contentCategory,
            _contentIds,
            _dateRange,
        ];
    }

    public override Tdf CreateNew() => new WipeContentRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "WipeContentRequest";
    public override string GetFullClassName() => "Blaze::Locker::WipeContentRequest";

    public string ContentCategory
    {
        get => _contentCategory.Value;
        set => _contentCategory.Value = value;
    }

    public IList<int> ContentIds
    {
        get => _contentIds.Value;
        set => _contentIds.Value = value;
    }

    public Blaze3SDK.Blaze.Locker.DateRange? DateRange
    {
        get => _dateRange.Value;
        set => _dateRange.Value = value;
    }

}

