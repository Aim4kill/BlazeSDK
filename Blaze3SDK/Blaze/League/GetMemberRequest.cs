using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.League;

public class GetMemberRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("LeagueId", "mLeagueId", 0xB27A6400, TdfType.UInt32, 0, true), // LGID
        new TdfMemberInfo("MemberId", "mMemberId", 0xB6D8B200, TdfType.Int64, 1, true), // MMBR
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _leagueId = new(__typeInfos[0]);
    private TdfInt64 _memberId = new(__typeInfos[1]);

    public GetMemberRequest()
    {
        __members = [
            _leagueId,
            _memberId,
        ];
    }

    public override Tdf CreateNew() => new GetMemberRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetMemberRequest";
    public override string GetFullClassName() => "Blaze::League::GetMemberRequest";

    public uint LeagueId
    {
        get => _leagueId.Value;
        set => _leagueId.Value = value;
    }

    public long MemberId
    {
        get => _memberId.Value;
        set => _memberId.Value = value;
    }

}

