using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Tournaments;

public class GetMemberCountsResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("TotalMemberCount", "mTotalMemberCount", 0x8EFBB400, TdfType.UInt32, 0, true), // CONT
        new TdfMemberInfo("OnlineMemberCount", "mOnlineMemberCount", 0xBE3BEE00, TdfType.UInt32, 1, true), // OCON
        new TdfMemberInfo("TournamentId", "mTournamentId", 0xD2EA6400, TdfType.UInt32, 2, true), // TNID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _totalMemberCount = new(__typeInfos[0]);
    private TdfUInt32 _onlineMemberCount = new(__typeInfos[1]);
    private TdfUInt32 _tournamentId = new(__typeInfos[2]);

    public GetMemberCountsResponse()
    {
        __members = [
            _totalMemberCount,
            _onlineMemberCount,
            _tournamentId,
        ];
    }

    public override Tdf CreateNew() => new GetMemberCountsResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetMemberCountsResponse";
    public override string GetFullClassName() => "Blaze::Tournaments::GetMemberCountsResponse";

    public uint TotalMemberCount
    {
        get => _totalMemberCount.Value;
        set => _totalMemberCount.Value = value;
    }

    public uint OnlineMemberCount
    {
        get => _onlineMemberCount.Value;
        set => _onlineMemberCount.Value = value;
    }

    public uint TournamentId
    {
        get => _tournamentId.Value;
        set => _tournamentId.Value = value;
    }

}

