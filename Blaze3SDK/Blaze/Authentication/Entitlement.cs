using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Authentication;

public class Entitlement : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("DeviceUri", "mDeviceUri", 0x925DA900, TdfType.String, 0, true), // DEVI
        new TdfMemberInfo("GrantDate", "mGrantDate", 0x9E487900, TdfType.String, 1, true), // GDAY
        new TdfMemberInfo("GroupName", "mGroupName", 0x9EE86D00, TdfType.String, 2, true), // GNAM
        new TdfMemberInfo("Id", "mId", 0xA6400000, TdfType.UInt64, 3, true), // ID
        new TdfMemberInfo("IsConsumable", "mIsConsumable", 0xA738EF00, TdfType.Bool, 4, true), // ISCO
        new TdfMemberInfo("PersonaId", "mPersonaId", 0xC2990000, TdfType.Int64, 5, true), // PID
        new TdfMemberInfo("ProjectId", "mProjectId", 0xC2AA6400, TdfType.String, 6, true), // PJID
        new TdfMemberInfo("ProductCatalog", "mProductCatalog", 0xC328E100, TdfType.Enum, 7, true), // PRCA
        new TdfMemberInfo("ProductId", "mProductId", 0xC32A6400, TdfType.String, 8, true), // PRID
        new TdfMemberInfo("Status", "mStatus", 0xCF487400, TdfType.Enum, 9, true), // STAT
        new TdfMemberInfo("StatusReasonCode", "mStatusReasonCode", 0xCF4CA300, TdfType.Enum, 10, true), // STRC
        new TdfMemberInfo("EntitlementTag", "mEntitlementTag", 0xD219C000, TdfType.String, 11, true), // TAG
        new TdfMemberInfo("TerminationDate", "mTerminationDate", 0xD2487900, TdfType.String, 12, true), // TDAY
        new TdfMemberInfo("EntitlementType", "mEntitlementType", 0xD39C2500, TdfType.Enum, 13, true), // TYPE
        new TdfMemberInfo("UseCount", "mUseCount", 0xD63BB400, TdfType.UInt32, 14, true), // UCNT
        new TdfMemberInfo("Version", "mVersion", 0xDA5C8000, TdfType.UInt32, 15, true), // VER
    ];
    private ITdfMember[] __members;

    private TdfString _deviceUri = new(__typeInfos[0]);
    private TdfString _grantDate = new(__typeInfos[1]);
    private TdfString _groupName = new(__typeInfos[2]);
    private TdfUInt64 _id = new(__typeInfos[3]);
    private TdfBool _isConsumable = new(__typeInfos[4]);
    private TdfInt64 _personaId = new(__typeInfos[5]);
    private TdfString _projectId = new(__typeInfos[6]);
    private TdfEnum<Blaze3SDK.Blaze.Authentication.ProductCatalog> _productCatalog = new(__typeInfos[7]);
    private TdfString _productId = new(__typeInfos[8]);
    private TdfEnum<Blaze3SDK.Blaze.Authentication.EntitlementStatus> _status = new(__typeInfos[9]);
    private TdfEnum<Blaze3SDK.Blaze.Authentication.StatusReason> _statusReasonCode = new(__typeInfos[10]);
    private TdfString _entitlementTag = new(__typeInfos[11]);
    private TdfString _terminationDate = new(__typeInfos[12]);
    private TdfEnum<Blaze3SDK.Blaze.Authentication.EntitlementType> _entitlementType = new(__typeInfos[13]);
    private TdfUInt32 _useCount = new(__typeInfos[14]);
    private TdfUInt32 _version = new(__typeInfos[15]);

    public Entitlement()
    {
        __members = [
            _deviceUri,
            _grantDate,
            _groupName,
            _id,
            _isConsumable,
            _personaId,
            _projectId,
            _productCatalog,
            _productId,
            _status,
            _statusReasonCode,
            _entitlementTag,
            _terminationDate,
            _entitlementType,
            _useCount,
            _version,
        ];
    }

    public override Tdf CreateNew() => new Entitlement();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "Entitlement";
    public override string GetFullClassName() => "Blaze::Authentication::Entitlement";

    public string DeviceUri
    {
        get => _deviceUri.Value;
        set => _deviceUri.Value = value;
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

    public ulong Id
    {
        get => _id.Value;
        set => _id.Value = value;
    }

    public bool IsConsumable
    {
        get => _isConsumable.Value;
        set => _isConsumable.Value = value;
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

    public uint UseCount
    {
        get => _useCount.Value;
        set => _useCount.Value = value;
    }

    public uint Version
    {
        get => _version.Value;
        set => _version.Value = value;
    }

}

