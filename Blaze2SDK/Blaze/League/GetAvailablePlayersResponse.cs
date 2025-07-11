using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.League;

public class GetAvailablePlayersResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Players", "mPlayers", 0xB73B3200, TdfType.Map, 0, true), // MSLR
    ];
    private ITdfMember[] __members;

    private TdfMap<uint, Blaze2SDK.Blaze.League.AvailablePlayer> _players = new(__typeInfos[0]);

    public GetAvailablePlayersResponse()
    {
        __members = [
            _players,
        ];
    }

    public override Tdf CreateNew() => new GetAvailablePlayersResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetAvailablePlayersResponse";
    public override string GetFullClassName() => "Blaze::League::GetAvailablePlayersResponse";

    public IDictionary<uint, Blaze2SDK.Blaze.League.AvailablePlayer> Players
    {
        get => _players.Value;
        set => _players.Value = value;
    }

}

