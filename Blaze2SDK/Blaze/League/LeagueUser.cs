using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.League;

public class LeagueUser : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("BlazeId", "mBlazeId", 0x8ACA6400, TdfType.UInt32, 0, true), // BLID
        new TdfMemberInfo("Persona", "mPersona", 0xC25CB300, TdfType.String, 1, true), // PERS
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _blazeId = new(__typeInfos[0]);
    private TdfString _persona = new(__typeInfos[1]);

    public LeagueUser()
    {
        __members = [
            _blazeId,
            _persona,
        ];
    }

    public override Tdf CreateNew() => new LeagueUser();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "LeagueUser";
    public override string GetFullClassName() => "Blaze::League::LeagueUser";

    public uint BlazeId
    {
        get => _blazeId.Value;
        set => _blazeId.Value = value;
    }

    public string Persona
    {
        get => _persona.Value;
        set => _persona.Value = value;
    }

}

