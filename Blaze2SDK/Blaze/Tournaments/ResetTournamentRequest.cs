using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Tournaments;

public class ResetTournamentRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("BlazeId", "mBlazeId", 0x8BAA6400, TdfType.UInt32, 0, true), // BZID
        new TdfMemberInfo("TournamentId", "mTournamentId", 0xD2EA6400, TdfType.UInt32, 1, true), // TNID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _blazeId = new(__typeInfos[0]);
    private TdfUInt32 _tournamentId = new(__typeInfos[1]);

    public ResetTournamentRequest()
    {
        __members = [
            _blazeId,
            _tournamentId,
        ];
    }

    public override Tdf CreateNew() => new ResetTournamentRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ResetTournamentRequest";
    public override string GetFullClassName() => "Blaze::Tournaments::ResetTournamentRequest";

    public uint BlazeId
    {
        get => _blazeId.Value;
        set => _blazeId.Value = value;
    }

    public uint TournamentId
    {
        get => _tournamentId.Value;
        set => _tournamentId.Value = value;
    }

}

