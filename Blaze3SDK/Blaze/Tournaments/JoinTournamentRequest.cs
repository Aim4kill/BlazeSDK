using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Tournaments;

public class JoinTournamentRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("TournAttribute", "mTournAttribute", 0x874D3200, TdfType.String, 0, true), // ATTR
        new TdfMemberInfo("Team", "mTeam", 0xD2586D00, TdfType.Int32, 1, true), // TEAM
        new TdfMemberInfo("Id", "mId", 0xD2EA6400, TdfType.UInt32, 2, true), // TNID
    ];
    private ITdfMember[] __members;

    private TdfString _tournAttribute = new(__typeInfos[0]);
    private TdfInt32 _team = new(__typeInfos[1]);
    private TdfUInt32 _id = new(__typeInfos[2]);

    public JoinTournamentRequest()
    {
        __members = [
            _tournAttribute,
            _team,
            _id,
        ];
    }

    public override Tdf CreateNew() => new JoinTournamentRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "JoinTournamentRequest";
    public override string GetFullClassName() => "Blaze::Tournaments::JoinTournamentRequest";

    public string TournAttribute
    {
        get => _tournAttribute.Value;
        set => _tournAttribute.Value = value;
    }

    public int Team
    {
        get => _team.Value;
        set => _team.Value = value;
    }

    public uint Id
    {
        get => _id.Value;
        set => _id.Value = value;
    }

}

