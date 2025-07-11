using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Tournaments;

public class GetMyTournamentDetailsResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("isActive", "isActive", 0x863D2900, TdfType.Bool, 0, true), // ACTI
        new TdfMemberInfo("TournAttribute", "mTournAttribute", 0x874D3200, TdfType.String, 1, true), // ATTR
        new TdfMemberInfo("Level", "mLevel", 0xB25DAC00, TdfType.UInt32, 2, true), // LEVL
        new TdfMemberInfo("Team", "mTeam", 0xD2586D00, TdfType.Int32, 3, true), // TEAM
        new TdfMemberInfo("TournamentId", "mTournamentId", 0xD2990000, TdfType.UInt32, 4, true), // TID
        new TdfMemberInfo("TournamentTree", "mTournamentTree", 0xD3296500, TdfType.List, 5, true), // TREE
    ];
    private ITdfMember[] __members;

    private TdfBool _isActive = new(__typeInfos[0]);
    private TdfString _tournAttribute = new(__typeInfos[1]);
    private TdfUInt32 _level = new(__typeInfos[2]);
    private TdfInt32 _team = new(__typeInfos[3]);
    private TdfUInt32 _tournamentId = new(__typeInfos[4]);
    private TdfList<Blaze2SDK.Blaze.Tournaments.TournamentNode> _tournamentTree = new(__typeInfos[5]);

    public GetMyTournamentDetailsResponse()
    {
        __members = [
            _isActive,
            _tournAttribute,
            _level,
            _team,
            _tournamentId,
            _tournamentTree,
        ];
    }

    public override Tdf CreateNew() => new GetMyTournamentDetailsResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetMyTournamentDetailsResponse";
    public override string GetFullClassName() => "Blaze::Tournaments::GetMyTournamentDetailsResponse";

    public bool isActive
    {
        get => _isActive.Value;
        set => _isActive.Value = value;
    }

    public string TournAttribute
    {
        get => _tournAttribute.Value;
        set => _tournAttribute.Value = value;
    }

    public uint Level
    {
        get => _level.Value;
        set => _level.Value = value;
    }

    public int Team
    {
        get => _team.Value;
        set => _team.Value = value;
    }

    public uint TournamentId
    {
        get => _tournamentId.Value;
        set => _tournamentId.Value = value;
    }

    public IList<Blaze2SDK.Blaze.Tournaments.TournamentNode> TournamentTree
    {
        get => _tournamentTree.Value;
        set => _tournamentTree.Value = value;
    }

}

