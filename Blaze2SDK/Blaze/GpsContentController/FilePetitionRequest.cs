using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GpsContentController;

public class FilePetitionRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("attributeMap", "attributeMap", 0x86EDB000, TdfType.Map, 0, true), // ANVP
        new TdfMemberInfo("ContentId", "mContentId", 0x8EFA6400, TdfType.UInt64, 1, true), // COID
        new TdfMemberInfo("ComplaintType", "mComplaintType", 0x8EFD3900, TdfType.String, 2, true), // COTY
        new TdfMemberInfo("PetitionDetail", "mPetitionDetail", 0xC3492500, TdfType.String, 3, true), // PTDE
        new TdfMemberInfo("Subject", "mSubject", 0xCF58AA00, TdfType.String, 4, true), // SUBJ
        new TdfMemberInfo("TimeZone", "mTimeZone", 0xD2DEAF00, TdfType.String, 5, true), // TMZO
        new TdfMemberInfo("TargetUsers", "mTargetUsers", 0xD329F400, TdfType.List, 6, true), // TRGT
    ];
    private ITdfMember[] __members;

    private TdfMap<string, string> _attributeMap = new(__typeInfos[0]);
    private TdfUInt64 _contentId = new(__typeInfos[1]);
    private TdfString _complaintType = new(__typeInfos[2]);
    private TdfString _petitionDetail = new(__typeInfos[3]);
    private TdfString _subject = new(__typeInfos[4]);
    private TdfString _timeZone = new(__typeInfos[5]);
    private TdfList<uint> _targetUsers = new(__typeInfos[6]);

    public FilePetitionRequest()
    {
        __members = [
            _attributeMap,
            _contentId,
            _complaintType,
            _petitionDetail,
            _subject,
            _timeZone,
            _targetUsers,
        ];
    }

    public override Tdf CreateNew() => new FilePetitionRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "FilePetitionRequest";
    public override string GetFullClassName() => "Blaze::GpsContentController::FilePetitionRequest";

    public IDictionary<string, string> attributeMap
    {
        get => _attributeMap.Value;
        set => _attributeMap.Value = value;
    }

    public ulong ContentId
    {
        get => _contentId.Value;
        set => _contentId.Value = value;
    }

    public string ComplaintType
    {
        get => _complaintType.Value;
        set => _complaintType.Value = value;
    }

    public string PetitionDetail
    {
        get => _petitionDetail.Value;
        set => _petitionDetail.Value = value;
    }

    public string Subject
    {
        get => _subject.Value;
        set => _subject.Value = value;
    }

    public string TimeZone
    {
        get => _timeZone.Value;
        set => _timeZone.Value = value;
    }

    public IList<uint> TargetUsers
    {
        get => _targetUsers.Value;
        set => _targetUsers.Value = value;
    }

}

