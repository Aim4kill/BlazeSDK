using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Authentication;

public class PostEntitlementRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ConsoleId", "mConsoleId", 0x8EEA6400, TdfType.Blob, 0, true), // CNID
        new TdfMemberInfo("GroupName", "mGroupName", 0x9EE86D00, TdfType.String, 1, true), // GNAM
        new TdfMemberInfo("WithPersona", "mWithPersona", 0xC25CB300, TdfType.Bool, 2, true), // PERS
        new TdfMemberInfo("ProjectId", "mProjectId", 0xC2AA6400, TdfType.String, 3, true), // PJID
        new TdfMemberInfo("ProductId", "mProductId", 0xC32A6400, TdfType.String, 4, true), // PRID
        new TdfMemberInfo("Status", "mStatus", 0xCF487400, TdfType.Enum, 5, true), // STAT
        new TdfMemberInfo("EntitlementTag", "mEntitlementTag", 0xD219C000, TdfType.String, 6, true), // TAG
        new TdfMemberInfo("UserId", "mUserId", 0xD6990000, TdfType.Int64, 7, true), // UID
    ];
    private ITdfMember[] __members;

    private TdfBlob _consoleId = new(__typeInfos[0]);
    private TdfString _groupName = new(__typeInfos[1]);
    private TdfBool _withPersona = new(__typeInfos[2]);
    private TdfString _projectId = new(__typeInfos[3]);
    private TdfString _productId = new(__typeInfos[4]);
    private TdfEnum<Blaze2SDK.Blaze.Authentication.EntitlementStatus> _status = new(__typeInfos[5]);
    private TdfString _entitlementTag = new(__typeInfos[6]);
    private TdfInt64 _userId = new(__typeInfos[7]);

    public PostEntitlementRequest()
    {
        __members = [
            _consoleId,
            _groupName,
            _withPersona,
            _projectId,
            _productId,
            _status,
            _entitlementTag,
            _userId,
        ];
    }

    public override Tdf CreateNew() => new PostEntitlementRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PostEntitlementRequest";
    public override string GetFullClassName() => "Blaze::Authentication::PostEntitlementRequest";

    public byte[] ConsoleId
    {
        get => _consoleId.Value;
        set => _consoleId.Value = value;
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

    public Blaze2SDK.Blaze.Authentication.EntitlementStatus Status
    {
        get => _status.Value;
        set => _status.Value = value;
    }

    public string EntitlementTag
    {
        get => _entitlementTag.Value;
        set => _entitlementTag.Value = value;
    }

    public long UserId
    {
        get => _userId.Value;
        set => _userId.Value = value;
    }

}

