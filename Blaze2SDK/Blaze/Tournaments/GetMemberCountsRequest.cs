using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Tournaments;

public class GetMemberCountsRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("TournamentId", "mTournamentId", 0xD2EA6400, TdfType.UInt32, 0, true), // TNID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _tournamentId = new(__typeInfos[0]);

    public GetMemberCountsRequest()
    {
        __members = [
            _tournamentId,
        ];
    }

    public override Tdf CreateNew() => new GetMemberCountsRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetMemberCountsRequest";
    public override string GetFullClassName() => "Blaze::Tournaments::GetMemberCountsRequest";

    public uint TournamentId
    {
        get => _tournamentId.Value;
        set => _tournamentId.Value = value;
    }

}

