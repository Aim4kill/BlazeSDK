using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Clubs;

public class FindClubsAsyncResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Count", "mCount", 0x8EFBB400, TdfType.UInt32, 0, true), // CONT
        new TdfMemberInfo("TotalCount", "mTotalCount", 0x8F48F400, TdfType.UInt32, 1, true), // CTCT
        new TdfMemberInfo("SequenceID", "mSequenceID", 0xCF1A6400, TdfType.UInt32, 2, true), // SQID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _count = new(__typeInfos[0]);
    private TdfUInt32 _totalCount = new(__typeInfos[1]);
    private TdfUInt32 _sequenceID = new(__typeInfos[2]);

    public FindClubsAsyncResponse()
    {
        __members = [
            _count,
            _totalCount,
            _sequenceID,
        ];
    }

    public override Tdf CreateNew() => new FindClubsAsyncResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "FindClubsAsyncResponse";
    public override string GetFullClassName() => "Blaze::Clubs::FindClubsAsyncResponse";

    public uint Count
    {
        get => _count.Value;
        set => _count.Value = value;
    }

    public uint TotalCount
    {
        get => _totalCount.Value;
        set => _totalCount.Value = value;
    }

    public uint SequenceID
    {
        get => _sequenceID.Value;
        set => _sequenceID.Value = value;
    }

}

