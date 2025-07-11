using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.League;

public class JoinLeagueRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("DNF", "mDNF", 0x92E98000, TdfType.Int32, 0, true), // DNF
        new TdfMemberInfo("LeagueId", "mLeagueId", 0xB27A6400, TdfType.UInt32, 1, true), // LGID
        new TdfMemberInfo("Inviter", "mInviter", 0xB6D8B200, TdfType.Int64, 2, true), // MMBR
        new TdfMemberInfo("Password", "mPassword", 0xC21CF300, TdfType.String, 3, true), // PASS
        new TdfMemberInfo("TeamId", "mTeamId", 0xD2586D00, TdfType.UInt32, 4, true), // TEAM
    ];
    private ITdfMember[] __members;

    private TdfInt32 _dNF = new(__typeInfos[0]);
    private TdfUInt32 _leagueId = new(__typeInfos[1]);
    private TdfInt64 _inviter = new(__typeInfos[2]);
    private TdfString _password = new(__typeInfos[3]);
    private TdfUInt32 _teamId = new(__typeInfos[4]);

    public JoinLeagueRequest()
    {
        __members = [
            _dNF,
            _leagueId,
            _inviter,
            _password,
            _teamId,
        ];
    }

    public override Tdf CreateNew() => new JoinLeagueRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "JoinLeagueRequest";
    public override string GetFullClassName() => "Blaze::League::JoinLeagueRequest";

    public int DNF
    {
        get => _dNF.Value;
        set => _dNF.Value = value;
    }

    public uint LeagueId
    {
        get => _leagueId.Value;
        set => _leagueId.Value = value;
    }

    public long Inviter
    {
        get => _inviter.Value;
        set => _inviter.Value = value;
    }

    public string Password
    {
        get => _password.Value;
        set => _password.Value = value;
    }

    public uint TeamId
    {
        get => _teamId.Value;
        set => _teamId.Value = value;
    }

}

