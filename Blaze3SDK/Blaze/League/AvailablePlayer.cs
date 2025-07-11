using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.League;

public class AvailablePlayer : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("PlayerId", "mPlayerId", 0xC2CA6400, TdfType.UInt32, 0, true), // PLID
        new TdfMemberInfo("Position", "mPosition", 0xC2FCF400, TdfType.UInt32, 1, true), // POST
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _playerId = new(__typeInfos[0]);
    private TdfUInt32 _position = new(__typeInfos[1]);

    public AvailablePlayer()
    {
        __members = [
            _playerId,
            _position,
        ];
    }

    public override Tdf CreateNew() => new AvailablePlayer();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "AvailablePlayer";
    public override string GetFullClassName() => "Blaze::League::AvailablePlayer";

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

}

