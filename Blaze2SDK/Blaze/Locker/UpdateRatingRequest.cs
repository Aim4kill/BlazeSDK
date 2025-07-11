using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Locker;

public class UpdateRatingRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ContentCategory", "mContentCategory", 0x8E387400, TdfType.String, 0, true), // CCAT
        new TdfMemberInfo("ContentId", "mContentId", 0x8E990000, TdfType.Int32, 1, true), // CID
        new TdfMemberInfo("Rating", "mRating", 0xCA1D2500, TdfType.Int32, 2, true), // RATE
    ];
    private ITdfMember[] __members;

    private TdfString _contentCategory = new(__typeInfos[0]);
    private TdfInt32 _contentId = new(__typeInfos[1]);
    private TdfInt32 _rating = new(__typeInfos[2]);

    public UpdateRatingRequest()
    {
        __members = [
            _contentCategory,
            _contentId,
            _rating,
        ];
    }

    public override Tdf CreateNew() => new UpdateRatingRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpdateRatingRequest";
    public override string GetFullClassName() => "Blaze::Locker::UpdateRatingRequest";

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

    public int Rating
    {
        get => _rating.Value;
        set => _rating.Value = value;
    }

}

