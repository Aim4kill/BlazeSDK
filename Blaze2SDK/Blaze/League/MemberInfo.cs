using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.League;

public class MemberInfo : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GamesRemaining", "mGamesRemaining", 0x9F296D00, TdfType.UInt8, 0, true), // GREM
        new TdfMemberInfo("IsDraftProfileSubmitted", "mIsDraftProfileSubmitted", 0xA7393000, TdfType.UInt8, 1, true), // ISDP
        new TdfMemberInfo("IsGM", "mIsGM", 0xA739ED00, TdfType.UInt8, 2, true), // ISGM
        new TdfMemberInfo("IsOnline", "mIsOnline", 0xA73BEE00, TdfType.UInt8, 3, true), // ISON
        new TdfMemberInfo("LeagueId", "mLeagueId", 0xB27A6400, TdfType.UInt32, 4, true), // LGID
        new TdfMemberInfo("Metadata", "mMetadata", 0xB65D2100, TdfType.Blob, 5, true), // META
        new TdfMemberInfo("Member", "mMember", 0xB6D8B200, TdfType.Struct, 6, true), // MMBR
        new TdfMemberInfo("IsStringMetadata", "mIsStringMetadata", 0xCED97400, TdfType.UInt8, 7, true), // SMET
        new TdfMemberInfo("Stats", "mStats", 0xCF487400, TdfType.Struct, 8, true), // STAT
        new TdfMemberInfo("TeamId", "mTeamId", 0xD2586D00, TdfType.UInt32, 9, true), // TEAM
    ];
    private ITdfMember[] __members;

    private TdfUInt8 _gamesRemaining = new(__typeInfos[0]);
    private TdfUInt8 _isDraftProfileSubmitted = new(__typeInfos[1]);
    private TdfUInt8 _isGM = new(__typeInfos[2]);
    private TdfUInt8 _isOnline = new(__typeInfos[3]);
    private TdfUInt32 _leagueId = new(__typeInfos[4]);
    private TdfBlob _metadata = new(__typeInfos[5]);
    private TdfStruct<Blaze2SDK.Blaze.League.LeagueUser?> _member = new(__typeInfos[6]);
    private TdfUInt8 _isStringMetadata = new(__typeInfos[7]);
    private TdfStruct<Blaze2SDK.Blaze.League.MemberStats?> _stats = new(__typeInfos[8]);
    private TdfUInt32 _teamId = new(__typeInfos[9]);

    public MemberInfo()
    {
        __members = [
            _gamesRemaining,
            _isDraftProfileSubmitted,
            _isGM,
            _isOnline,
            _leagueId,
            _metadata,
            _member,
            _isStringMetadata,
            _stats,
            _teamId,
        ];
    }

    public override Tdf CreateNew() => new MemberInfo();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "MemberInfo";
    public override string GetFullClassName() => "Blaze::League::MemberInfo";

    public byte GamesRemaining
    {
        get => _gamesRemaining.Value;
        set => _gamesRemaining.Value = value;
    }

    public byte IsDraftProfileSubmitted
    {
        get => _isDraftProfileSubmitted.Value;
        set => _isDraftProfileSubmitted.Value = value;
    }

    public byte IsGM
    {
        get => _isGM.Value;
        set => _isGM.Value = value;
    }

    public byte IsOnline
    {
        get => _isOnline.Value;
        set => _isOnline.Value = value;
    }

    public uint LeagueId
    {
        get => _leagueId.Value;
        set => _leagueId.Value = value;
    }

    public byte[] Metadata
    {
        get => _metadata.Value;
        set => _metadata.Value = value;
    }

    public Blaze2SDK.Blaze.League.LeagueUser? Member
    {
        get => _member.Value;
        set => _member.Value = value;
    }

    public byte IsStringMetadata
    {
        get => _isStringMetadata.Value;
        set => _isStringMetadata.Value = value;
    }

    public Blaze2SDK.Blaze.League.MemberStats? Stats
    {
        get => _stats.Value;
        set => _stats.Value = value;
    }

    public uint TeamId
    {
        get => _teamId.Value;
        set => _teamId.Value = value;
    }

}

