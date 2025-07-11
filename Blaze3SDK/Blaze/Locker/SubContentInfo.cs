using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Locker;

public class SubContentInfo : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GetURL", "mGetURL", 0x9F5CAC00, TdfType.String, 0, true), // GURL
        new TdfMemberInfo("Status", "mStatus", 0xCF4D3300, TdfType.Enum, 1, true), // STTS
        new TdfMemberInfo("UploadURL", "mUploadURL", 0xD75CAC00, TdfType.String, 2, true), // UURL
        new TdfMemberInfo("XrefId", "mXrefId", 0xE2990000, TdfType.String, 3, true), // XID
    ];
    private ITdfMember[] __members;

    private TdfString _getURL = new(__typeInfos[0]);
    private TdfEnum<Blaze3SDK.Blaze.Locker.Status> _status = new(__typeInfos[1]);
    private TdfString _uploadURL = new(__typeInfos[2]);
    private TdfString _xrefId = new(__typeInfos[3]);

    public SubContentInfo()
    {
        __members = [
            _getURL,
            _status,
            _uploadURL,
            _xrefId,
        ];
    }

    public override Tdf CreateNew() => new SubContentInfo();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "SubContentInfo";
    public override string GetFullClassName() => "Blaze::Locker::SubContentInfo";

    public string GetURL
    {
        get => _getURL.Value;
        set => _getURL.Value = value;
    }

    public Blaze3SDK.Blaze.Locker.Status Status
    {
        get => _status.Value;
        set => _status.Value = value;
    }

    public string UploadURL
    {
        get => _uploadURL.Value;
        set => _uploadURL.Value = value;
    }

    public string XrefId
    {
        get => _xrefId.Value;
        set => _xrefId.Value = value;
    }

}

