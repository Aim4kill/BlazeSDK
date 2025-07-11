using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Clubs;

public class GetClubRecordbookResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClubRecordList", "mClubRecordList", 0x8ECCAC00, TdfType.List, 0, true), // CLRL
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze2SDK.Blaze.Clubs.ClubRecord> _clubRecordList = new(__typeInfos[0]);

    public GetClubRecordbookResponse()
    {
        __members = [
            _clubRecordList,
        ];
    }

    public override Tdf CreateNew() => new GetClubRecordbookResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetClubRecordbookResponse";
    public override string GetFullClassName() => "Blaze::Clubs::GetClubRecordbookResponse";

    public IList<Blaze2SDK.Blaze.Clubs.ClubRecord> ClubRecordList
    {
        get => _clubRecordList.Value;
        set => _clubRecordList.Value = value;
    }

}

