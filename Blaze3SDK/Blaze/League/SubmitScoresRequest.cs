using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.League;

public class SubmitScoresRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("LeagueId", "mLeagueId", 0xB27A6400, TdfType.UInt32, 0, true), // LGID
        new TdfMemberInfo("Score0", "mScore0", 0xCE3C9000, TdfType.UInt32, 1, true), // SCR0
        new TdfMemberInfo("Score1", "mScore1", 0xCE3C9100, TdfType.UInt32, 2, true), // SCR1
        new TdfMemberInfo("Simulated", "mSimulated", 0xCE9B7500, TdfType.UInt8, 3, true), // SIMU
        new TdfMemberInfo("User0", "mUser0", 0xD73C9000, TdfType.Int64, 4, true), // USR0
        new TdfMemberInfo("User1", "mUser1", 0xD73C9100, TdfType.Int64, 5, true), // USR1
        new TdfMemberInfo("Wlt0", "mWlt0", 0xDECD1000, TdfType.UInt32, 6, true), // WLT0
        new TdfMemberInfo("Wlt1", "mWlt1", 0xDECD1100, TdfType.UInt32, 7, true), // WLT1
        new TdfMemberInfo("Wtyp0", "mWtyp0", 0xDF4C1000, TdfType.UInt32, 8, true), // WTP0
        new TdfMemberInfo("Wtyp1", "mWtyp1", 0xDF4C1100, TdfType.UInt32, 9, true), // WTP1
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _leagueId = new(__typeInfos[0]);
    private TdfUInt32 _score0 = new(__typeInfos[1]);
    private TdfUInt32 _score1 = new(__typeInfos[2]);
    private TdfUInt8 _simulated = new(__typeInfos[3]);
    private TdfInt64 _user0 = new(__typeInfos[4]);
    private TdfInt64 _user1 = new(__typeInfos[5]);
    private TdfUInt32 _wlt0 = new(__typeInfos[6]);
    private TdfUInt32 _wlt1 = new(__typeInfos[7]);
    private TdfUInt32 _wtyp0 = new(__typeInfos[8]);
    private TdfUInt32 _wtyp1 = new(__typeInfos[9]);

    public SubmitScoresRequest()
    {
        __members = [
            _leagueId,
            _score0,
            _score1,
            _simulated,
            _user0,
            _user1,
            _wlt0,
            _wlt1,
            _wtyp0,
            _wtyp1,
        ];
    }

    public override Tdf CreateNew() => new SubmitScoresRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "SubmitScoresRequest";
    public override string GetFullClassName() => "Blaze::League::SubmitScoresRequest";

    public uint LeagueId
    {
        get => _leagueId.Value;
        set => _leagueId.Value = value;
    }

    public uint Score0
    {
        get => _score0.Value;
        set => _score0.Value = value;
    }

    public uint Score1
    {
        get => _score1.Value;
        set => _score1.Value = value;
    }

    public byte Simulated
    {
        get => _simulated.Value;
        set => _simulated.Value = value;
    }

    public long User0
    {
        get => _user0.Value;
        set => _user0.Value = value;
    }

    public long User1
    {
        get => _user1.Value;
        set => _user1.Value = value;
    }

    public uint Wlt0
    {
        get => _wlt0.Value;
        set => _wlt0.Value = value;
    }

    public uint Wlt1
    {
        get => _wlt1.Value;
        set => _wlt1.Value = value;
    }

    public uint Wtyp0
    {
        get => _wtyp0.Value;
        set => _wtyp0.Value = value;
    }

    public uint Wtyp1
    {
        get => _wtyp1.Value;
        set => _wtyp1.Value = value;
    }

}

