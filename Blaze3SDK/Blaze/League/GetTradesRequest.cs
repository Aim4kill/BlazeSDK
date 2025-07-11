using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.League;

public class GetTradesRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MemberId", "mMemberId", 0x9AFCAD00, TdfType.Int64, 0, true), // FORM
        new TdfMemberInfo("LeagueId", "mLeagueId", 0xB27A6400, TdfType.UInt32, 1, true), // LGID
    ];
    private ITdfMember[] __members;

    private TdfInt64 _memberId = new(__typeInfos[0]);
    private TdfUInt32 _leagueId = new(__typeInfos[1]);

    public GetTradesRequest()
    {
        __members = [
            _memberId,
            _leagueId,
        ];
    }

    public override Tdf CreateNew() => new GetTradesRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetTradesRequest";
    public override string GetFullClassName() => "Blaze::League::GetTradesRequest";

    public long MemberId
    {
        get => _memberId.Value;
        set => _memberId.Value = value;
    }

    public uint LeagueId
    {
        get => _leagueId.Value;
        set => _leagueId.Value = value;
    }

}

