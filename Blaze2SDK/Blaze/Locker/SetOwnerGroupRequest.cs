using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Locker;

public class SetOwnerGroupRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Category", "mCategory", 0x8E387400, TdfType.String, 0, true), // CCAT
        new TdfMemberInfo("ContentId", "mContentId", 0x8E990000, TdfType.Int32, 1, true), // CID
        new TdfMemberInfo("GroupId", "mGroupId", 0x9F0A6400, TdfType.UInt64, 2, true), // GPID
    ];
    private ITdfMember[] __members;

    private TdfString _category = new(__typeInfos[0]);
    private TdfInt32 _contentId = new(__typeInfos[1]);
    private TdfUInt64 _groupId = new(__typeInfos[2]);

    public SetOwnerGroupRequest()
    {
        __members = [
            _category,
            _contentId,
            _groupId,
        ];
    }

    public override Tdf CreateNew() => new SetOwnerGroupRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "SetOwnerGroupRequest";
    public override string GetFullClassName() => "Blaze::Locker::SetOwnerGroupRequest";

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

    public ulong GroupId
    {
        get => _groupId.Value;
        set => _groupId.Value = value;
    }

}

