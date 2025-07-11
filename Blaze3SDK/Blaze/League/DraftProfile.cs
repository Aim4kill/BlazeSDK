using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.League;

public class DraftProfile : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Players", "mPlayers", 0xC2CCB300, TdfType.List, 0, true), // PLRS
        new TdfMemberInfo("RoundPositionPrefs", "mRoundPositionPrefs", 0xCA4C2600, TdfType.List, 1, true), // RDPF
        new TdfMemberInfo("StartingRank", "mStartingRank", 0xCF4CB400, TdfType.UInt16, 2, true), // STRT
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze3SDK.Blaze.League.Player> _players = new(__typeInfos[0]);
    private TdfList<Blaze3SDK.Blaze.League.PositionPref> _roundPositionPrefs = new(__typeInfos[1]);
    private TdfUInt16 _startingRank = new(__typeInfos[2]);

    public DraftProfile()
    {
        __members = [
            _players,
            _roundPositionPrefs,
            _startingRank,
        ];
    }

    public override Tdf CreateNew() => new DraftProfile();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "DraftProfile";
    public override string GetFullClassName() => "Blaze::League::DraftProfile";

    public IList<Blaze3SDK.Blaze.League.Player> Players
    {
        get => _players.Value;
        set => _players.Value = value;
    }

    public IList<Blaze3SDK.Blaze.League.PositionPref> RoundPositionPrefs
    {
        get => _roundPositionPrefs.Value;
        set => _roundPositionPrefs.Value = value;
    }

    public ushort StartingRank
    {
        get => _startingRank.Value;
        set => _startingRank.Value = value;
    }

}

