using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Authentication;

public class GetUseCountRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("UserId", "mUserId", 0x8B5A6400, TdfType.Int64, 0, true), // BUID
        new TdfMemberInfo("EntitlementTag", "mEntitlementTag", 0x97486700, TdfType.String, 1, true), // ETAG
        new TdfMemberInfo("GroupName", "mGroupName", 0x9EE86D00, TdfType.String, 2, true), // GNAM
        new TdfMemberInfo("ProjectId", "mProjectId", 0xC2AA6400, TdfType.String, 3, true), // PJID
        new TdfMemberInfo("ProductId", "mProductId", 0xC32A6400, TdfType.String, 4, true), // PRID
    ];
    private ITdfMember[] __members;

    private TdfInt64 _userId = new(__typeInfos[0]);
    private TdfString _entitlementTag = new(__typeInfos[1]);
    private TdfString _groupName = new(__typeInfos[2]);
    private TdfString _projectId = new(__typeInfos[3]);
    private TdfString _productId = new(__typeInfos[4]);

    public GetUseCountRequest()
    {
        __members = [
            _userId,
            _entitlementTag,
            _groupName,
            _projectId,
            _productId,
        ];
    }

    public override Tdf CreateNew() => new GetUseCountRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetUseCountRequest";
    public override string GetFullClassName() => "Blaze::Authentication::GetUseCountRequest";

    public long UserId
    {
        get => _userId.Value;
        set => _userId.Value = value;
    }

    public string EntitlementTag
    {
        get => _entitlementTag.Value;
        set => _entitlementTag.Value = value;
    }

    public string GroupName
    {
        get => _groupName.Value;
        set => _groupName.Value = value;
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

