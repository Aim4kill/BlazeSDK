using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Tournaments;

public class TournamentTrophyData : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("UserId", "mUserId", 0x8BAA6400, TdfType.UInt32, 0, true), // BZID
        new TdfMemberInfo("AwardCount", "mAwardCount", 0x8EFBB400, TdfType.UInt32, 1, true), // CONT
        new TdfMemberInfo("TrophyMetaData", "mTrophyMetaData", 0xB65D2100, TdfType.String, 2, true), // META
        new TdfMemberInfo("AwardTime", "mAwardTime", 0xD29B6500, TdfType.UInt32, 3, true), // TIME
        new TdfMemberInfo("TrophyNameLocKey", "mTrophyNameLocKey", 0xD2CBE300, TdfType.String, 4, true), // TLOC
        new TdfMemberInfo("TrophyName", "mTrophyName", 0xD2E86D00, TdfType.String, 5, true), // TNAM
        new TdfMemberInfo("TournamentId", "mTournamentId", 0xD2EA6400, TdfType.UInt32, 6, true), // TNID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _userId = new(__typeInfos[0]);
    private TdfUInt32 _awardCount = new(__typeInfos[1]);
    private TdfString _trophyMetaData = new(__typeInfos[2]);
    private TdfUInt32 _awardTime = new(__typeInfos[3]);
    private TdfString _trophyNameLocKey = new(__typeInfos[4]);
    private TdfString _trophyName = new(__typeInfos[5]);
    private TdfUInt32 _tournamentId = new(__typeInfos[6]);

    public TournamentTrophyData()
    {
        __members = [
            _userId,
            _awardCount,
            _trophyMetaData,
            _awardTime,
            _trophyNameLocKey,
            _trophyName,
            _tournamentId,
        ];
    }

    public override Tdf CreateNew() => new TournamentTrophyData();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "TournamentTrophyData";
    public override string GetFullClassName() => "Blaze::Tournaments::TournamentTrophyData";

    public uint UserId
    {
        get => _userId.Value;
        set => _userId.Value = value;
    }

    public uint AwardCount
    {
        get => _awardCount.Value;
        set => _awardCount.Value = value;
    }

    public string TrophyMetaData
    {
        get => _trophyMetaData.Value;
        set => _trophyMetaData.Value = value;
    }

    public uint AwardTime
    {
        get => _awardTime.Value;
        set => _awardTime.Value = value;
    }

    public string TrophyNameLocKey
    {
        get => _trophyNameLocKey.Value;
        set => _trophyNameLocKey.Value = value;
    }

    public string TrophyName
    {
        get => _trophyName.Value;
        set => _trophyName.Value = value;
    }

    public uint TournamentId
    {
        get => _tournamentId.Value;
        set => _tournamentId.Value = value;
    }

}

