using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Arson;

public class GetTournamentMemberStatusResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("TournAttribute", "mTournAttribute", 0x874D3200, TdfType.String, 0, true), // ATTR
        new TdfMemberInfo("UserId", "mUserId", 0x8BAA6400, TdfType.UInt32, 1, true), // BZID
        new TdfMemberInfo("IsActive", "mIsActive", 0xA7386300, TdfType.Bool, 2, true), // ISAC
        new TdfMemberInfo("Level", "mLevel", 0xB25DAC00, TdfType.UInt32, 3, true), // LEVL
        new TdfMemberInfo("LastMatchId", "mLastMatchId", 0xB2D8E800, TdfType.UInt32, 4, true), // LMCH
        new TdfMemberInfo("TournamentId", "mTournamentId", 0xD2990000, TdfType.UInt32, 5, true), // TID
    ];
    private ITdfMember[] __members;

    private TdfString _tournAttribute = new(__typeInfos[0]);
    private TdfUInt32 _userId = new(__typeInfos[1]);
    private TdfBool _isActive = new(__typeInfos[2]);
    private TdfUInt32 _level = new(__typeInfos[3]);
    private TdfUInt32 _lastMatchId = new(__typeInfos[4]);
    private TdfUInt32 _tournamentId = new(__typeInfos[5]);

    public GetTournamentMemberStatusResponse()
    {
        __members = [
            _tournAttribute,
            _userId,
            _isActive,
            _level,
            _lastMatchId,
            _tournamentId,
        ];
    }

    public override Tdf CreateNew() => new GetTournamentMemberStatusResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetTournamentMemberStatusResponse";
    public override string GetFullClassName() => "Blaze::Arson::GetTournamentMemberStatusResponse";

    public string TournAttribute
    {
        get => _tournAttribute.Value;
        set => _tournAttribute.Value = value;
    }

    public uint UserId
    {
        get => _userId.Value;
        set => _userId.Value = value;
    }

    public bool IsActive
    {
        get => _isActive.Value;
        set => _isActive.Value = value;
    }

    public uint Level
    {
        get => _level.Value;
        set => _level.Value = value;
    }

    public uint LastMatchId
    {
        get => _lastMatchId.Value;
        set => _lastMatchId.Value = value;
    }

    public uint TournamentId
    {
        get => _tournamentId.Value;
        set => _tournamentId.Value = value;
    }

}

