using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Authentication;

public class ListPersonaEntitlements2Request : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("PageNo", "mPageNo", 0x970CEE00, TdfType.UInt16, 0, true), // EPSN
        new TdfMemberInfo("PageSize", "mPageSize", 0x970CFA00, TdfType.UInt16, 1, true), // EPSZ
        new TdfMemberInfo("EntitlementTag", "mEntitlementTag", 0x97486700, TdfType.String, 2, true), // ETAG
        new TdfMemberInfo("GrantDate", "mGrantDate", 0x9E487900, TdfType.String, 3, true), // GDAY
        new TdfMemberInfo("GroupNameList", "mGroupNameList", 0x9EEB3300, TdfType.List, 4, true), // GNLS
        new TdfMemberInfo("PersonaId", "mPersonaId", 0xC2990000, TdfType.Int64, 5, true), // PID
        new TdfMemberInfo("ProjectId", "mProjectId", 0xC2AA6400, TdfType.String, 6, true), // PJID
        new TdfMemberInfo("ProductId", "mProductId", 0xC32A6400, TdfType.String, 7, true), // PRID
        new TdfMemberInfo("RecursiveSearch", "mRecursiveSearch", 0xCA58F500, TdfType.Bool, 8, true), // RECU
        new TdfMemberInfo("Status", "mStatus", 0xCF487400, TdfType.Enum, 9, true), // STAT
        new TdfMemberInfo("TerminationDate", "mTerminationDate", 0xD25CA400, TdfType.String, 10, true), // TERD
        new TdfMemberInfo("EntitlementType", "mEntitlementType", 0xD39C2500, TdfType.Enum, 11, true), // TYPE
    ];
    private ITdfMember[] __members;

    private TdfUInt16 _pageNo = new(__typeInfos[0]);
    private TdfUInt16 _pageSize = new(__typeInfos[1]);
    private TdfString _entitlementTag = new(__typeInfos[2]);
    private TdfString _grantDate = new(__typeInfos[3]);
    private TdfList<string> _groupNameList = new(__typeInfos[4]);
    private TdfInt64 _personaId = new(__typeInfos[5]);
    private TdfString _projectId = new(__typeInfos[6]);
    private TdfString _productId = new(__typeInfos[7]);
    private TdfBool _recursiveSearch = new(__typeInfos[8]);
    private TdfEnum<Blaze3SDK.Blaze.Authentication.EntitlementStatus> _status = new(__typeInfos[9]);
    private TdfString _terminationDate = new(__typeInfos[10]);
    private TdfEnum<Blaze3SDK.Blaze.Authentication.EntitlementType> _entitlementType = new(__typeInfos[11]);

    public ListPersonaEntitlements2Request()
    {
        __members = [
            _pageNo,
            _pageSize,
            _entitlementTag,
            _grantDate,
            _groupNameList,
            _personaId,
            _projectId,
            _productId,
            _recursiveSearch,
            _status,
            _terminationDate,
            _entitlementType,
        ];
    }

    public override Tdf CreateNew() => new ListPersonaEntitlements2Request();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ListPersonaEntitlements2Request";
    public override string GetFullClassName() => "Blaze::Authentication::ListPersonaEntitlements2Request";

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

    public string EntitlementTag
    {
        get => _entitlementTag.Value;
        set => _entitlementTag.Value = value;
    }

    public string GrantDate
    {
        get => _grantDate.Value;
        set => _grantDate.Value = value;
    }

    public IList<string> GroupNameList
    {
        get => _groupNameList.Value;
        set => _groupNameList.Value = value;
    }

    public long PersonaId
    {
        get => _personaId.Value;
        set => _personaId.Value = value;
    }

    public string ProjectId
    {
        get => _projectId.Value;
        set => _projectId.Value = value;
    }

    public string ProductId
    {
        get => _productId.Value;
        set => _productId.Value = value;
    }

    public bool RecursiveSearch
    {
        get => _recursiveSearch.Value;
        set => _recursiveSearch.Value = value;
    }

    public Blaze3SDK.Blaze.Authentication.EntitlementStatus Status
    {
        get => _status.Value;
        set => _status.Value = value;
    }

    public string TerminationDate
    {
        get => _terminationDate.Value;
        set => _terminationDate.Value = value;
    }

    public Blaze3SDK.Blaze.Authentication.EntitlementType EntitlementType
    {
        get => _entitlementType.Value;
        set => _entitlementType.Value = value;
    }

}

