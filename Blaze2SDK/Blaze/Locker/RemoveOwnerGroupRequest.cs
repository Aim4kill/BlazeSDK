using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Locker;

public class RemoveOwnerGroupRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Category", "mCategory", 0x8E387400, TdfType.String, 0, true), // CCAT
        new TdfMemberInfo("ContentId", "mContentId", 0x8E990000, TdfType.Int32, 1, true), // CID
    ];
    private ITdfMember[] __members;

    private TdfString _category = new(__typeInfos[0]);
    private TdfInt32 _contentId = new(__typeInfos[1]);

    public RemoveOwnerGroupRequest()
    {
        __members = [
            _category,
            _contentId,
        ];
    }

    public override Tdf CreateNew() => new RemoveOwnerGroupRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "RemoveOwnerGroupRequest";
    public override string GetFullClassName() => "Blaze::Locker::RemoveOwnerGroupRequest";

    public string Category
    {
        get => _category.Value;
        set => _category.Value = value;
    }

    public int ContentId
    {
        get => _contentId.Value;
        set => _contentId.Value = value;
    }

}

