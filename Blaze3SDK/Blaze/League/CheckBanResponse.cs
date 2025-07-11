using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.League;

public class CheckBanResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("LeagueId", "mLeagueId", 0xB27A6400, TdfType.UInt32, 0, true), // LGID
        new TdfMemberInfo("State", "mState", 0xCF487400, TdfType.UInt32, 1, true), // STAT
        new TdfMemberInfo("UserId", "mUserId", 0xD7397200, TdfType.Int64, 2, true), // USER
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _leagueId = new(__typeInfos[0]);
    private TdfUInt32 _state = new(__typeInfos[1]);
    private TdfInt64 _userId = new(__typeInfos[2]);

    public CheckBanResponse()
    {
        __members = [
            _leagueId,
            _state,
            _userId,
        ];
    }

    public override Tdf CreateNew() => new CheckBanResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "CheckBanResponse";
    public override string GetFullClassName() => "Blaze::League::CheckBanResponse";

    public uint LeagueId
    {
        get => _leagueId.Value;
        set => _leagueId.Value = value;
    }

    public uint State
    {
        get => _state.Value;
        set => _state.Value = value;
    }

    public long UserId
    {
        get => _userId.Value;
        set => _userId.Value = value;
    }

}

