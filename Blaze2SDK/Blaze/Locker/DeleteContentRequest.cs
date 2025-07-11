using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Locker;

public class DeleteContentRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ContentCategory", "mContentCategory", 0x8E387400, TdfType.String, 0, true), // CCAT
        new TdfMemberInfo("ContentId", "mContentId", 0x8E993300, TdfType.List, 1, true), // CIDS
    ];
    private ITdfMember[] __members;

    private TdfString _contentCategory = new(__typeInfos[0]);
    private TdfList<int> _contentId = new(__typeInfos[1]);

    public DeleteContentRequest()
    {
        __members = [
            _contentCategory,
            _contentId,
        ];
    }

    public override Tdf CreateNew() => new DeleteContentRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "DeleteContentRequest";
    public override string GetFullClassName() => "Blaze::Locker::DeleteContentRequest";

    public string ContentCategory
    {
        get => _contentCategory.Value;
        set => _contentCategory.Value = value;
    }

    public IList<int> ContentId
    {
        get => _contentId.Value;
        set => _contentId.Value = value;
    }

}

