using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Clubs;

public class ResetClubRecordsRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClubId", "mClubId", 0x8ECA6400, TdfType.UInt32, 0, true), // CLID
        new TdfMemberInfo("RecordIdList", "mRecordIdList", 0xCA3A6400, TdfType.List, 1, true), // RCID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _clubId = new(__typeInfos[0]);
    private TdfList<uint> _recordIdList = new(__typeInfos[1]);

    public ResetClubRecordsRequest()
    {
        __members = [
            _clubId,
            _recordIdList,
        ];
    }

    public override Tdf CreateNew() => new ResetClubRecordsRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ResetClubRecordsRequest";
    public override string GetFullClassName() => "Blaze::Clubs::ResetClubRecordsRequest";

    public uint ClubId
    {
        get => _clubId.Value;
        set => _clubId.Value = value;
    }

    public IList<uint> RecordIdList
    {
        get => _recordIdList.Value;
        set => _recordIdList.Value = value;
    }

}

