using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.League;

public class Roster : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Count", "mCount", 0x8EFBB400, TdfType.UInt32, 0, true), // CONT
        new TdfMemberInfo("Crc", "mCrc", 0x8F28C000, TdfType.UInt32, 1, true), // CRC
        new TdfMemberInfo("LeagueId", "mLeagueId", 0xB27A6400, TdfType.UInt32, 2, true), // LGID
        new TdfMemberInfo("Member", "mMember", 0xB6D8B200, TdfType.Struct, 3, true), // MMBR
        new TdfMemberInfo("Players", "mPlayers", 0xC2CE7200, TdfType.List, 4, true), // PLYR
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _count = new(__typeInfos[0]);
    private TdfUInt32 _crc = new(__typeInfos[1]);
    private TdfUInt32 _leagueId = new(__typeInfos[2]);
    private TdfStruct<Blaze2SDK.Blaze.League.LeagueUser?> _member = new(__typeInfos[3]);
    private TdfList<Blaze2SDK.Blaze.League.Player> _players = new(__typeInfos[4]);

    public Roster()
    {
        __members = [
            _count,
            _crc,
            _leagueId,
            _member,
            _players,
        ];
    }

    public override Tdf CreateNew() => new Roster();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "Roster";
    public override string GetFullClassName() => "Blaze::League::Roster";

    public uint Count
    {
        get => _count.Value;
        set => _count.Value = value;
    }

    public uint Crc
    {
        get => _crc.Value;
        set => _crc.Value = value;
    }

    public uint LeagueId
    {
        get => _leagueId.Value;
        set => _leagueId.Value = value;
    }

    public Blaze2SDK.Blaze.League.LeagueUser? Member
    {
        get => _member.Value;
        set => _member.Value = value;
    }

    public IList<Blaze2SDK.Blaze.League.Player> Players
    {
        get => _players.Value;
        set => _players.Value = value;
    }

}

