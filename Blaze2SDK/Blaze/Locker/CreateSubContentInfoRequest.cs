using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Locker;

public class CreateSubContentInfoRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ContentCategory", "mContentCategory", 0x8E387400, TdfType.String, 0, true), // CCAT
        new TdfMemberInfo("ContentId", "mContentId", 0x8E990000, TdfType.Int32, 1, true), // CID
        new TdfMemberInfo("SubContentNames", "mSubContentNames", 0xCF58AC00, TdfType.List, 2, true), // SUBL
    ];
    private ITdfMember[] __members;

    private TdfString _contentCategory = new(__typeInfos[0]);
    private TdfInt32 _contentId = new(__typeInfos[1]);
    private TdfList<string> _subContentNames = new(__typeInfos[2]);

    public CreateSubContentInfoRequest()
    {
        __members = [
            _contentCategory,
            _contentId,
            _subContentNames,
        ];
    }

    public override Tdf CreateNew() => new CreateSubContentInfoRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "CreateSubContentInfoRequest";
    public override string GetFullClassName() => "Blaze::Locker::CreateSubContentInfoRequest";

    public string ContentCategory
    {
        get => _contentCategory.Value;
        set => _contentCategory.Value = value;
    }

    public int ContentId
    {
        get => _contentId.Value;
        set => _contentId.Value = value;
    }

    public IList<string> SubContentNames
    {
        get => _subContentNames.Value;
        set => _subContentNames.Value = value;
    }

}

