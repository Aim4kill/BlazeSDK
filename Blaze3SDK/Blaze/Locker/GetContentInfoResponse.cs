using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Locker;

public class GetContentInfoResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ContentInfo", "mContentInfo", 0xA6E9AF00, TdfType.Struct, 0, true), // INFO
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze3SDK.Blaze.Locker.ContentInfo?> _contentInfo = new(__typeInfos[0]);

    public GetContentInfoResponse()
    {
        __members = [
            _contentInfo,
        ];
    }

    public override Tdf CreateNew() => new GetContentInfoResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetContentInfoResponse";
    public override string GetFullClassName() => "Blaze::Locker::GetContentInfoResponse";

    public Blaze3SDK.Blaze.Locker.ContentInfo? ContentInfo
    {
        get => _contentInfo.Value;
        set => _contentInfo.Value = value;
    }

}

