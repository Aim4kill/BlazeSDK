using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.League;

public class SetDefaultRosterRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("LeagueId", "mLeagueId", 0xB27A6400, TdfType.UInt32, 0, true), // LGID
        new TdfMemberInfo("RosterId", "mRosterId", 0xCAFCF400, TdfType.String, 1, true), // ROST
        new TdfMemberInfo("TeamId", "mTeamId", 0xD2586D00, TdfType.UInt32, 2, true), // TEAM
        new TdfMemberInfo("UserId", "mUserId", 0xD7397200, TdfType.UInt32, 3, true), // USER
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _leagueId = new(__typeInfos[0]);
    private TdfString _rosterId = new(__typeInfos[1]);
    private TdfUInt32 _teamId = new(__typeInfos[2]);
    private TdfUInt32 _userId = new(__typeInfos[3]);

    public SetDefaultRosterRequest()
    {
        __members = [
            _leagueId,
            _rosterId,
            _teamId,
            _userId,
        ];
    }

    public override Tdf CreateNew() => new SetDefaultRosterRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "SetDefaultRosterRequest";
    public override string GetFullClassName() => "Blaze::League::SetDefaultRosterRequest";

    public uint LeagueId
    {
        get => _leagueId.Value;
        set => _leagueId.Value = value;
    }

    public string RosterId
    {
        get => _rosterId.Value;
        set => _rosterId.Value = value;
    }

    public uint TeamId
    {
        get => _teamId.Value;
        set => _teamId.Value = value;
    }

    public uint UserId
    {
        get => _userId.Value;
        set => _userId.Value = value;
    }

}

