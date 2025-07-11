using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.League;

public class Player : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Lineup", "mLineup", 0xB29BA500, TdfType.UInt32, 0, true), // LINE
        new TdfMemberInfo("PlayerId", "mPlayerId", 0xC2CA6400, TdfType.UInt32, 1, true), // PLID
        new TdfMemberInfo("Position", "mPosition", 0xC2FCE900, TdfType.UInt32, 2, true), // POSI
        new TdfMemberInfo("Rating", "mRating", 0xCB4BA700, TdfType.UInt32, 3, true), // RTNG
        new TdfMemberInfo("TeamId", "mTeamId", 0xD2586D00, TdfType.UInt32, 4, true), // TEAM
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _lineup = new(__typeInfos[0]);
    private TdfUInt32 _playerId = new(__typeInfos[1]);
    private TdfUInt32 _position = new(__typeInfos[2]);
    private TdfUInt32 _rating = new(__typeInfos[3]);
    private TdfUInt32 _teamId = new(__typeInfos[4]);

    public Player()
    {
        __members = [
            _lineup,
            _playerId,
            _position,
            _rating,
            _teamId,
        ];
    }

    public override Tdf CreateNew() => new Player();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "Player";
    public override string GetFullClassName() => "Blaze::League::Player";

    public uint Lineup
    {
        get => _lineup.Value;
        set => _lineup.Value = value;
    }

    public uint PlayerId
    {
        get => _playerId.Value;
        set => _playerId.Value = value;
    }

    public uint Position
    {
        get => _position.Value;
        set => _position.Value = value;
    }

    public uint Rating
    {
        get => _rating.Value;
        set => _rating.Value = value;
    }

    public uint TeamId
    {
        get => _teamId.Value;
        set => _teamId.Value = value;
    }

}

