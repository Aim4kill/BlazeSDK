using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GpsContentController;

public class FetchContentRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ContentId", "mContentId", 0x8EFA6400, TdfType.UInt64, 0, true), // COID
    ];
    private ITdfMember[] __members;

    private TdfUInt64 _contentId = new(__typeInfos[0]);

    public FetchContentRequest()
    {
        __members = [
            _contentId,
        ];
    }

    public override Tdf CreateNew() => new FetchContentRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "FetchContentRequest";
    public override string GetFullClassName() => "Blaze::GpsContentController::FetchContentRequest";

    public ulong ContentId
    {
        get => _contentId.Value;
        set => _contentId.Value = value;
    }

}

