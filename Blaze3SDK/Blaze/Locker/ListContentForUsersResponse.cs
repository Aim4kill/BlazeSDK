using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Locker;

public class ListContentForUsersResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ContentInfoMap", "mContentInfoMap", 0xB2BCB300, TdfType.Map, 0, true), // LKRS
        new TdfMemberInfo("SizeAllowed", "mSizeAllowed", 0xB73A7A00, TdfType.Int32, 1, true), // MSIZ
        new TdfMemberInfo("TotalCount", "mTotalCount", 0xD23BB400, TdfType.UInt32, 2, true), // TCNT
    ];
    private ITdfMember[] __members;

    private TdfMap<long, Blaze3SDK.Blaze.Locker.ContentInfos> _contentInfoMap = new(__typeInfos[0]);
    private TdfInt32 _sizeAllowed = new(__typeInfos[1]);
    private TdfUInt32 _totalCount = new(__typeInfos[2]);

    public ListContentForUsersResponse()
    {
        __members = [
            _contentInfoMap,
            _sizeAllowed,
            _totalCount,
        ];
    }

    public override Tdf CreateNew() => new ListContentForUsersResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ListContentForUsersResponse";
    public override string GetFullClassName() => "Blaze::Locker::ListContentForUsersResponse";

    public IDictionary<long, Blaze3SDK.Blaze.Locker.ContentInfos> ContentInfoMap
    {
        get => _contentInfoMap.Value;
        set => _contentInfoMap.Value = value;
    }

    public int SizeAllowed
    {
        get => _sizeAllowed.Value;
        set => _sizeAllowed.Value = value;
    }

    public uint TotalCount
    {
        get => _totalCount.Value;
        set => _totalCount.Value = value;
    }

}

