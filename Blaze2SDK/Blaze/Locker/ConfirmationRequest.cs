using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Locker;

public class ConfirmationRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ContentInfo", "mContentInfo", 0xA6E9AF00, TdfType.Struct, 0, true), // INFO
        new TdfMemberInfo("UploadStatus", "mUploadStatus", 0xCF4CF400, TdfType.Enum, 1, true), // STST
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze2SDK.Blaze.Locker.ContentInfo?> _contentInfo = new(__typeInfos[0]);
    private TdfEnum<Blaze2SDK.Blaze.Locker.UploadStatus> _uploadStatus = new(__typeInfos[1]);

    public ConfirmationRequest()
    {
        __members = [
            _contentInfo,
            _uploadStatus,
        ];
    }

    public override Tdf CreateNew() => new ConfirmationRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ConfirmationRequest";
    public override string GetFullClassName() => "Blaze::Locker::ConfirmationRequest";

    public Blaze2SDK.Blaze.Locker.ContentInfo? ContentInfo
    {
        get => _contentInfo.Value;
        set => _contentInfo.Value = value;
    }

    public Blaze2SDK.Blaze.Locker.UploadStatus UploadStatus
    {
        get => _uploadStatus.Value;
        set => _uploadStatus.Value = value;
    }

}

