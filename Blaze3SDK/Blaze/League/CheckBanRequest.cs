using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.League;

public class CheckBanRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("LeagueId", "mLeagueId", 0xB27A6400, TdfType.UInt32, 0, true), // LGID
        new TdfMemberInfo("UserId", "mUserId", 0xD7397200, TdfType.Int64, 1, true), // USER
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _leagueId = new(__typeInfos[0]);
    private TdfInt64 _userId = new(__typeInfos[1]);

    public CheckBanRequest()
    {
        __members = [
            _leagueId,
            _userId,
        ];
    }

    public override Tdf CreateNew() => new CheckBanRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "CheckBanRequest";
    public override string GetFullClassName() => "Blaze::League::CheckBanRequest";

    public uint LeagueId
    {
        get => _leagueId.Value;
        set => _leagueId.Value = value;
    }

    public long UserId
    {
        get => _userId.Value;
        set => _userId.Value = value;
    }

}

