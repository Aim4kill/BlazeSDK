using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Authentication;

public class GrantEntitlement2Request : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("UserId", "mUserId", 0x8B5A6400, TdfType.Int64, 0, true), // BUID
        new TdfMemberInfo("UseCount", "mUseCount", 0x8EFD6E00, TdfType.String, 1, true), // COUN
        new TdfMemberInfo("DeviceId", "mDeviceId", 0x925A6400, TdfType.String, 2, true), // DEID
        new TdfMemberInfo("Termination", "mTermination", 0x978C2900, TdfType.String, 3, true), // EXPI
        new TdfMemberInfo("GrantDate", "mGrantDate", 0x9E487900, TdfType.String, 4, true), // GDAY
        new TdfMemberInfo("GroupName", "mGroupName", 0x9EE86D00, TdfType.String, 5, true), // GNAM
        new TdfMemberInfo("IsSearch", "mIsSearch", 0xA73CE500, TdfType.Bool, 6, true), // ISSE
        new TdfMemberInfo("ManagedLifecycle", "mManagedLifecycle", 0xB61B2900, TdfType.Bool, 7, true), // MALI
        new TdfMemberInfo("PersonaId", "mPersonaId", 0xC25A6400, TdfType.Int64, 8, true), // PEID
        new TdfMemberInfo("WithPersona", "mWithPersona", 0xC25CB300, TdfType.Bool, 9, true), // PERS
        new TdfMemberInfo("ProjectId", "mProjectId", 0xC2AA6400, TdfType.String, 10, true), // PJID
        new TdfMemberInfo("ProductCatalog", "mProductCatalog", 0xC328E100, TdfType.Enum, 11, true), // PRCA
        new TdfMemberInfo("ProductId", "mProductId", 0xC32A6400, TdfType.String, 12, true), // PRID
        new TdfMemberInfo("Status", "mStatus", 0xCF487400, TdfType.Enum, 13, true), // STAT
        new TdfMemberInfo("StatusReasonCode", "mStatusReasonCode", 0xCF4CA500, TdfType.Enum, 14, true), // STRE
        new TdfMemberInfo("EntitlementTag", "mEntitlementTag", 0xD219C000, TdfType.String, 15, true), // TAG
        new TdfMemberInfo("EntitlementType", "mEntitlementType", 0xD39C2500, TdfType.Enum, 16, true), // TYPE
    ];
    private ITdfMember[] __members;

    private TdfInt64 _userId = new(__typeInfos[0]);
    private TdfString _useCount = new(__typeInfos[1]);
    private TdfString _deviceId = new(__typeInfos[2]);
    private TdfString _termination = new(__typeInfos[3]);
    private TdfString _grantDate = new(__typeInfos[4]);
    private TdfString _groupName = new(__typeInfos[5]);
    private TdfBool _isSearch = new(__typeInfos[6]);
    private TdfBool _managedLifecycle = new(__typeInfos[7]);
    private TdfInt64 _personaId = new(__typeInfos[8]);
    private TdfBool _withPersona = new(__typeInfos[9]);
    private TdfString _projectId = new(__typeInfos[10]);
    private TdfEnum<Blaze3SDK.Blaze.Authentication.ProductCatalog> _productCatalog = new(__typeInfos[11]);
    private TdfString _productId = new(__typeInfos[12]);
    private TdfEnum<Blaze3SDK.Blaze.Authentication.EntitlementStatus> _status = new(__typeInfos[13]);
    private TdfEnum<Blaze3SDK.Blaze.Authentication.StatusReason> _statusReasonCode = new(__typeInfos[14]);
    private TdfString _entitlementTag = new(__typeInfos[15]);
    private TdfEnum<Blaze3SDK.Blaze.Authentication.EntitlementType> _entitlementType = new(__typeInfos[16]);

    public GrantEntitlement2Request()
    {
        __members = [
            _userId,
            _useCount,
            _deviceId,
            _termination,
            _grantDate,
            _groupName,
            _isSearch,
            _managedLifecycle,
            _personaId,
            _withPersona,
            _projectId,
            _productCatalog,
            _productId,
            _status,
            _statusReasonCode,
            _entitlementTag,
            _entitlementType,
        ];
    }

    public override Tdf CreateNew() => new GrantEntitlement2Request();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GrantEntitlement2Request";
    public override string GetFullClassName() => "Blaze::Authentication::GrantEntitlement2Request";

    public long UserId
    {
        get => _userId.Value;
        set => _userId.Value = value;
    }

    public string UseCount
    {
        get => _useCount.Value;
        set => _useCount.Value = value;
    }

    public string DeviceId
    {
        get => _deviceId.Value;
        set => _deviceId.Value = value;
    }

    public string Termination
    {
        get => _termination.Value;
        set => _termination.Value = value;
    }

    public string GrantDate
    {
        get => _grantDate.Value;
        set => _grantDate.Value = value;
    }

    public string GroupName
    {
        get => _groupName.Value;
        set => _groupName.Value = value;
    }

    public bool IsSearch
    {
        get => _isSearch.Value;
        set => _isSearch.Value = value;
    }

    public bool ManagedLifecycle
    {
        get => _managedLifecycle.Value;
        set => _managedLifecycle.Value = value;
    }

    public long PersonaId
    {
        get => _personaId.Value;
        set => _personaId.Value = value;
    }

    public bool WithPersona
    {
        get => _withPersona.Value;
        set => _withPersona.Value = value;
    }

    public string ProjectId
    {
        get => _projectId.Value;
        set => _projectId.Value = value;
    }

    public Blaze3SDK.Blaze.Authentication.ProductCatalog ProductCatalog
    {
        get => _productCatalog.Value;
        set => _productCatalog.Value = value;
    }

    public string ProductId
    {
        get => _productId.Value;
        set => _productId.Value = value;
    }

    public Blaze3SDK.Blaze.Authentication.EntitlementStatus Status
    {
        get => _status.Value;
        set => _status.Value = value;
    }

    public Blaze3SDK.Blaze.Authentication.StatusReason StatusReasonCode
    {
        get => _statusReasonCode.Value;
        set => _statusReasonCode.Value = value;
    }

    public string EntitlementTag
    {
        get => _entitlementTag.Value;
        set => _entitlementTag.Value = value;
    }

    public Blaze3SDK.Blaze.Authentication.EntitlementType EntitlementType
    {
        get => _entitlementType.Value;
        set => _entitlementType.Value = value;
    }

}

