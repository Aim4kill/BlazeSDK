using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Authentication;

public class PostEntitlementRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("DeviceId", "mDeviceId", 0x925A6400, TdfType.UInt32, 0, true), // DEID
        new TdfMemberInfo("GroupName", "mGroupName", 0x9EE86D00, TdfType.String, 1, true), // GNAM
        new TdfMemberInfo("WithPersona", "mWithPersona", 0xC25CB300, TdfType.Bool, 2, true), // PERS
        new TdfMemberInfo("ProjectId", "mProjectId", 0xC2AA6400, TdfType.String, 3, true), // PJID
        new TdfMemberInfo("ProductId", "mProductId", 0xC32A6400, TdfType.String, 4, true), // PRID
        new TdfMemberInfo("Status", "mStatus", 0xCF487400, TdfType.Enum, 5, true), // STAT
        new TdfMemberInfo("EntitlementTag", "mEntitlementTag", 0xD219C000, TdfType.String, 6, true), // TAG
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _deviceId = new(__typeInfos[0]);
    private TdfString _groupName = new(__typeInfos[1]);
    private TdfBool _withPersona = new(__typeInfos[2]);
    private TdfString _projectId = new(__typeInfos[3]);
    private TdfString _productId = new(__typeInfos[4]);
    private TdfEnum<Blaze3SDK.Blaze.Authentication.EntitlementStatus> _status = new(__typeInfos[5]);
    private TdfString _entitlementTag = new(__typeInfos[6]);

    public PostEntitlementRequest()
    {
        __members = [
            _deviceId,
            _groupName,
            _withPersona,
            _projectId,
            _productId,
            _status,
            _entitlementTag,
        ];
    }

    public override Tdf CreateNew() => new PostEntitlementRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PostEntitlementRequest";
    public override string GetFullClassName() => "Blaze::Authentication::PostEntitlementRequest";

    public uint DeviceId
    {
        get => _deviceId.Value;
        set => _deviceId.Value = value;
    }

    public string GroupName
    {
        get => _groupName.Value;
        set => _groupName.Value = value;
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

    public string EntitlementTag
    {
        get => _entitlementTag.Value;
        set => _entitlementTag.Value = value;
    }

}

