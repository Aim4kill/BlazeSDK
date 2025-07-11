using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Arson;

public class ReportTournamentResultsRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("TournId", "mTournId", 0xD2990000, TdfType.UInt32, 0, true), // TID
        new TdfMemberInfo("UserOneId", "mUserOneId", 0xD6FA6400, TdfType.UInt32, 1, true), // UOID
        new TdfMemberInfo("UserOneMetaData", "mUserOneMetaData", 0xD6FB6500, TdfType.String, 2, true), // UOME
        new TdfMemberInfo("UserOneScore", "mUserOneScore", 0xD6FCE300, TdfType.UInt32, 3, true), // UOSC
        new TdfMemberInfo("UserOneTeam", "mUserOneTeam", 0xD6FD2500, TdfType.Int32, 4, true), // UOTE
        new TdfMemberInfo("UserTwoId", "mUserTwoId", 0xD74A6400, TdfType.UInt32, 5, true), // UTID
        new TdfMemberInfo("UserTwoMetaData", "mUserTwoMetaData", 0xD74B6500, TdfType.String, 6, true), // UTME
        new TdfMemberInfo("UserTwoScore", "mUserTwoScore", 0xD74CE300, TdfType.UInt32, 7, true), // UTSC
        new TdfMemberInfo("UserTwoTeam", "mUserTwoTeam", 0xD74D2500, TdfType.Int32, 8, true), // UTTE
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _tournId = new(__typeInfos[0]);
    private TdfUInt32 _userOneId = new(__typeInfos[1]);
    private TdfString _userOneMetaData = new(__typeInfos[2]);
    private TdfUInt32 _userOneScore = new(__typeInfos[3]);
    private TdfInt32 _userOneTeam = new(__typeInfos[4]);
    private TdfUInt32 _userTwoId = new(__typeInfos[5]);
    private TdfString _userTwoMetaData = new(__typeInfos[6]);
    private TdfUInt32 _userTwoScore = new(__typeInfos[7]);
    private TdfInt32 _userTwoTeam = new(__typeInfos[8]);

    public ReportTournamentResultsRequest()
    {
        __members = [
            _tournId,
            _userOneId,
            _userOneMetaData,
            _userOneScore,
            _userOneTeam,
            _userTwoId,
            _userTwoMetaData,
            _userTwoScore,
            _userTwoTeam,
        ];
    }

    public override Tdf CreateNew() => new ReportTournamentResultsRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ReportTournamentResultsRequest";
    public override string GetFullClassName() => "Blaze::Arson::ReportTournamentResultsRequest";

    public uint TournId
    {
        get => _tournId.Value;
        set => _tournId.Value = value;
    }

    public uint UserOneId
    {
        get => _userOneId.Value;
        set => _userOneId.Value = value;
    }

    public string UserOneMetaData
    {
        get => _userOneMetaData.Value;
        set => _userOneMetaData.Value = value;
    }

    public uint UserOneScore
    {
        get => _userOneScore.Value;
        set => _userOneScore.Value = value;
    }

    public int UserOneTeam
    {
        get => _userOneTeam.Value;
        set => _userOneTeam.Value = value;
    }

    public uint UserTwoId
    {
        get => _userTwoId.Value;
        set => _userTwoId.Value = value;
    }

    public string UserTwoMetaData
    {
        get => _userTwoMetaData.Value;
        set => _userTwoMetaData.Value = value;
    }

    public uint UserTwoScore
    {
        get => _userTwoScore.Value;
        set => _userTwoScore.Value = value;
    }

    public int UserTwoTeam
    {
        get => _userTwoTeam.Value;
        set => _userTwoTeam.Value = value;
    }

}

