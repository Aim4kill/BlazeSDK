using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Locker;

public class ContentReferenceRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ContentCategory", "mContentCategory", 0x8E387400, TdfType.String, 0, true), // CCAT
        new TdfMemberInfo("ContentId", "mContentId", 0x8E990000, TdfType.Int32, 1, true), // CID
        new TdfMemberInfo("ReferenceType", "mReferenceType", 0xCA59B400, TdfType.Enum, 2, true), // REFT
    ];
    private ITdfMember[] __members;

    private TdfString _contentCategory = new(__typeInfos[0]);
    private TdfInt32 _contentId = new(__typeInfos[1]);
    private TdfEnum<Blaze2SDK.Blaze.Locker.ReferenceType> _referenceType = new(__typeInfos[2]);

    public ContentReferenceRequest()
    {
        __members = [
            _contentCategory,
            _contentId,
            _referenceType,
        ];
    }

    public override Tdf CreateNew() => new ContentReferenceRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ContentReferenceRequest";
    public override string GetFullClassName() => "Blaze::Locker::ContentReferenceRequest";

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

    public Blaze2SDK.Blaze.Locker.ReferenceType ReferenceType
    {
        get => _referenceType.Value;
        set => _referenceType.Value = value;
    }

}

