using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Tournaments;

public class TournamentNode : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("UserOneAttribute", "mUserOneAttribute", 0x874D2F00, TdfType.String, 0, true), // ATTO
        new TdfMemberInfo("UserTwoAttribute", "mUserTwoAttribute", 0x874D3400, TdfType.String, 1, true), // ATTT
        new TdfMemberInfo("UserOneMetaData", "mUserOneMetaData", 0xB65D2F00, TdfType.String, 2, true), // METO
        new TdfMemberInfo("UserTwoMetaData", "mUserTwoMetaData", 0xB65D3400, TdfType.String, 3, true), // METT
        new TdfMemberInfo("UserOneName", "mUserOneName", 0xBA1B6F00, TdfType.String, 4, true), // NAMO
        new TdfMemberInfo("UserTwoName", "mUserTwoName", 0xBA1B7400, TdfType.String, 5, true), // NAMT
        new TdfMemberInfo("NodeId", "mNodeId", 0xBAFA6400, TdfType.UInt32, 6, true), // NOID
        new TdfMemberInfo("UserOneScore", "mUserOneScore", 0xCE3BEF00, TdfType.UInt32, 7, true), // SCOO
        new TdfMemberInfo("UserTwoScore", "mUserTwoScore", 0xCE3BF400, TdfType.UInt32, 8, true), // SCOT
        new TdfMemberInfo("UserOneTeam", "mUserOneTeam", 0xD2586F00, TdfType.Int32, 9, true), // TEAO
        new TdfMemberInfo("UserTwoTeam", "mUserTwoTeam", 0xD2587400, TdfType.Int32, 10, true), // TEAT
        new TdfMemberInfo("UserOneId", "mUserOneId", 0xD6992F00, TdfType.Int64, 11, true), // UIDO
        new TdfMemberInfo("UserTwoId", "mUserTwoId", 0xD6993400, TdfType.Int64, 12, true), // UIDT
    ];
    private ITdfMember[] __members;

    private TdfString _userOneAttribute = new(__typeInfos[0]);
    private TdfString _userTwoAttribute = new(__typeInfos[1]);
    private TdfString _userOneMetaData = new(__typeInfos[2]);
    private TdfString _userTwoMetaData = new(__typeInfos[3]);
    private TdfString _userOneName = new(__typeInfos[4]);
    private TdfString _userTwoName = new(__typeInfos[5]);
    private TdfUInt32 _nodeId = new(__typeInfos[6]);
    private TdfUInt32 _userOneScore = new(__typeInfos[7]);
    private TdfUInt32 _userTwoScore = new(__typeInfos[8]);
    private TdfInt32 _userOneTeam = new(__typeInfos[9]);
    private TdfInt32 _userTwoTeam = new(__typeInfos[10]);
    private TdfInt64 _userOneId = new(__typeInfos[11]);
    private TdfInt64 _userTwoId = new(__typeInfos[12]);

    public TournamentNode()
    {
        __members = [
            _userOneAttribute,
            _userTwoAttribute,
            _userOneMetaData,
            _userTwoMetaData,
            _userOneName,
            _userTwoName,
            _nodeId,
            _userOneScore,
            _userTwoScore,
            _userOneTeam,
            _userTwoTeam,
            _userOneId,
            _userTwoId,
        ];
    }

    public override Tdf CreateNew() => new TournamentNode();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "TournamentNode";
    public override string GetFullClassName() => "Blaze::Tournaments::TournamentNode";

    public string UserOneAttribute
    {
        get => _userOneAttribute.Value;
        set => _userOneAttribute.Value = value;
    }

    public string UserTwoAttribute
    {
        get => _userTwoAttribute.Value;
        set => _userTwoAttribute.Value = value;
    }

    public string UserOneMetaData
    {
        get => _userOneMetaData.Value;
        set => _userOneMetaData.Value = value;
    }

    public string UserTwoMetaData
    {
        get => _userTwoMetaData.Value;
        set => _userTwoMetaData.Value = value;
    }

    public string UserOneName
    {
        get => _userOneName.Value;
        set => _userOneName.Value = value;
    }

    public string UserTwoName
    {
        get => _userTwoName.Value;
        set => _userTwoName.Value = value;
    }

    public uint NodeId
    {
        get => _nodeId.Value;
        set => _nodeId.Value = value;
    }

    public uint UserOneScore
    {
        get => _userOneScore.Value;
        set => _userOneScore.Value = value;
    }

    public uint UserTwoScore
    {
        get => _userTwoScore.Value;
        set => _userTwoScore.Value = value;
    }

    public int UserOneTeam
    {
        get => _userOneTeam.Value;
        set => _userOneTeam.Value = value;
    }

    public int UserTwoTeam
    {
        get => _userTwoTeam.Value;
        set => _userTwoTeam.Value = value;
    }

    public long UserOneId
    {
        get => _userOneId.Value;
        set => _userOneId.Value = value;
    }

    public long UserTwoId
    {
        get => _userTwoId.Value;
        set => _userTwoId.Value = value;
    }

}

