using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Authentication;

public class ListEntitlementsRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("UserId", "mUserId", 0x8B5A6400, TdfType.Int64, 0, true), // BUID
        new TdfMemberInfo("PageNo", "mPageNo", 0x970CEE00, TdfType.UInt16, 1, true), // EPSN
        new TdfMemberInfo("PageSize", "mPageSize", 0x970CFA00, TdfType.UInt16, 2, true), // EPSZ
        new TdfMemberInfo("EntitlementSearchFlag", "mEntitlementSearchFlag", 0x9AC86700, TdfType.Enum, 3, true), // FLAG
        new TdfMemberInfo("GroupNameList", "mGroupNameList", 0x9EEB3300, TdfType.List, 4, true), // GNLS
        new TdfMemberInfo("Restrictive", "mRestrictive", 0xBEEB3900, TdfType.Bool, 5, true), // ONLY
    ];
    private ITdfMember[] __members;

    private TdfInt64 _userId = new(__typeInfos[0]);
    private TdfUInt16 _pageNo = new(__typeInfos[1]);
    private TdfUInt16 _pageSize = new(__typeInfos[2]);
    private TdfEnum<Blaze3SDK.Blaze.Authentication.EntitlementSearchFlag> _entitlementSearchFlag = new(__typeInfos[3]);
    private TdfList<string> _groupNameList = new(__typeInfos[4]);
    private TdfBool _restrictive = new(__typeInfos[5]);

    public ListEntitlementsRequest()
    {
        __members = [
            _userId,
            _pageNo,
            _pageSize,
            _entitlementSearchFlag,
            _groupNameList,
            _restrictive,
        ];
    }

    public override Tdf CreateNew() => new ListEntitlementsRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ListEntitlementsRequest";
    public override string GetFullClassName() => "Blaze::Authentication::ListEntitlementsRequest";

    public long UserId
    {
        get => _userId.Value;
        set => _userId.Value = value;
    }

    public ushort PageNo
    {
        get => _pageNo.Value;
        set => _pageNo.Value = value;
    }

    public ushort PageSize
    {
        get => _pageSize.Value;
        set => _pageSize.Value = value;
    }

    public Blaze3SDK.Blaze.Authentication.EntitlementSearchFlag EntitlementSearchFlag
    {
        get => _entitlementSearchFlag.Value;
        set => _entitlementSearchFlag.Value = value;
    }

    public IList<string> GroupNameList
    {
        get => _groupNameList.Value;
        set => _groupNameList.Value = value;
    }

    public bool Restrictive
    {
        get => _restrictive.Value;
        set => _restrictive.Value = value;
    }

}

