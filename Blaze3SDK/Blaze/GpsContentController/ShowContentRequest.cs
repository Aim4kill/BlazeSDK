using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GpsContentController;

public class ShowContentRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ContentId", "mContentId", 0x8EFA6400, TdfType.ObjectId, 0, true), // COID
        new TdfMemberInfo("Show", "mShow", 0xCE8BF700, TdfType.Bool, 1, true), // SHOW
    ];
    private ITdfMember[] __members;

    private TdfObjectId _contentId = new(__typeInfos[0]);
    private TdfBool _show = new(__typeInfos[1]);

    public ShowContentRequest()
    {
        __members = [
            _contentId,
            _show,
        ];
    }

    public override Tdf CreateNew() => new ShowContentRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ShowContentRequest";
    public override string GetFullClassName() => "Blaze::GpsContentController::ShowContentRequest";

    public ObjectId ContentId
    {
        get => _contentId.Value;
        set => _contentId.Value = value;
    }

    public bool Show
    {
        get => _show.Value;
        set => _show.Value = value;
    }

}

