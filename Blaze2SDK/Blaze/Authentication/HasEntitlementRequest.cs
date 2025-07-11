using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Authentication;

public class HasEntitlementRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("UserId", "mUserId", 0x8B5A6400, TdfType.UInt32, 0, true), // BUID
        new TdfMemberInfo("ConsoleId", "mConsoleId", 0x8EEA6400, TdfType.Blob, 1, true), // CNID
        new TdfMemberInfo("EntitlementTag", "mEntitlementTag", 0x97486700, TdfType.String, 2, true), // ETAG
        new TdfMemberInfo("EntitlementSearchFlag", "mEntitlementSearchFlag", 0x9AC86700, TdfType.Enum, 3, true), // FLAG
        new TdfMemberInfo("GroupNameList", "mGroupNameList", 0x9EEB3300, TdfType.List, 4, true), // GNLS
        new TdfMemberInfo("PersonaId", "mPersonaId", 0xC2990000, TdfType.Int64, 5, true), // PID
        new TdfMemberInfo("ProjectId", "mProjectId", 0xC2AA6400, TdfType.String, 6, true), // PJID
        new TdfMemberInfo("ProductId", "mProductId", 0xC32A6400, TdfType.String, 7, true), // PRID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _userId = new(__typeInfos[0]);
    private TdfBlob _consoleId = new(__typeInfos[1]);
    private TdfString _entitlementTag = new(__typeInfos[2]);
    private TdfEnum<Blaze2SDK.Blaze.Authentication.EntitlementSearchFlag> _entitlementSearchFlag = new(__typeInfos[3]);
    private TdfList<string> _groupNameList = new(__typeInfos[4]);
    private TdfInt64 _personaId = new(__typeInfos[5]);
    private TdfString _projectId = new(__typeInfos[6]);
    private TdfString _productId = new(__typeInfos[7]);

    public HasEntitlementRequest()
    {
        __members = [
            _userId,
            _consoleId,
            _entitlementTag,
            _entitlementSearchFlag,
            _groupNameList,
            _personaId,
            _projectId,
            _productId,
        ];
    }

    public override Tdf CreateNew() => new HasEntitlementRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "HasEntitlementRequest";
    public override string GetFullClassName() => "Blaze::Authentication::HasEntitlementRequest";

    public uint UserId
    {
        get => _userId.Value;
        set => _userId.Value = value;
    }

    public byte[] ConsoleId
    {
        get => _consoleId.Value;
        set => _consoleId.Value = value;
    }

    public string EntitlementTag
    {
        get => _entitlementTag.Value;
        set => _entitlementTag.Value = value;
    }

    public Blaze2SDK.Blaze.Authentication.EntitlementSearchFlag EntitlementSearchFlag
    {
        get => _entitlementSearchFlag.Value;
        set => _entitlementSearchFlag.Value = value;
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

}

