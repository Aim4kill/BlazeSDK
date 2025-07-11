using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Authentication;

public class ListEntitlementsRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("UserId", "mUserId", 0x8B5A6400, TdfType.UInt32, 0, true), // BUID
        new TdfMemberInfo("PageNo", "mPageNo", 0x970CEE00, TdfType.UInt16, 1, true), // EPSN
        new TdfMemberInfo("PageSize", "mPageSize", 0x970CFA00, TdfType.UInt16, 2, true), // EPSZ
        new TdfMemberInfo("GroupNameList", "mGroupNameList", 0x9EEB3300, TdfType.List, 3, true), // GNLS
        new TdfMemberInfo("IsLegacy", "mIsLegacy", 0xBEC90000, TdfType.Bool, 4, true), // OLD
        new TdfMemberInfo("Restrictive", "mRestrictive", 0xBEEB3900, TdfType.Bool, 5, true), // ONLY
        new TdfMemberInfo("WithPersona", "mWithPersona", 0xC25CB300, TdfType.Bool, 6, true), // PERS
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _userId = new(__typeInfos[0]);
    private TdfUInt16 _pageNo = new(__typeInfos[1]);
    private TdfUInt16 _pageSize = new(__typeInfos[2]);
    private TdfList<string> _groupNameList = new(__typeInfos[3]);
    private TdfBool _isLegacy = new(__typeInfos[4]);
    private TdfBool _restrictive = new(__typeInfos[5]);
    private TdfBool _withPersona = new(__typeInfos[6]);

    public ListEntitlementsRequest()
    {
        __members = [
            _userId,
            _pageNo,
            _pageSize,
            _groupNameList,
            _isLegacy,
            _restrictive,
            _withPersona,
        ];
    }

    public override Tdf CreateNew() => new ListEntitlementsRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ListEntitlementsRequest";
    public override string GetFullClassName() => "Blaze::Authentication::ListEntitlementsRequest";

    public uint UserId
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

    public IList<string> GroupNameList
    {
        get => _groupNameList.Value;
        set => _groupNameList.Value = value;
    }

    public bool IsLegacy
    {
        get => _isLegacy.Value;
        set => _isLegacy.Value = value;
    }

    public bool Restrictive
    {
        get => _restrictive.Value;
        set => _restrictive.Value = value;
    }

    public bool WithPersona
    {
        get => _withPersona.Value;
        set => _withPersona.Value = value;
    }

}

