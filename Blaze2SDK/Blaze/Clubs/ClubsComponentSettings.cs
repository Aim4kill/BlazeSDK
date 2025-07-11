using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Clubs;

public class ClubsComponentSettings : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AwardSettings", "mAwardSettings", 0x877CF400, TdfType.List, 0, true), // AWST
        new TdfMemberInfo("ClubDivisionSize", "mClubDivisionSize", 0x8EC93300, TdfType.UInt16, 1, true), // CLDS
        new TdfMemberInfo("MaxInactiveDays", "mMaxInactiveDays", 0xA6E86300, TdfType.UInt16, 2, true), // INAC
        new TdfMemberInfo("MaxEvents", "mMaxEvents", 0xB7897600, TdfType.UInt16, 3, true), // MXEV
        new TdfMemberInfo("MaxGMs", "mMaxGMs", 0xB789ED00, TdfType.UInt16, 4, true), // MXGM
        new TdfMemberInfo("MaxInvitesPerUserOrClub", "mMaxInvitesPerUserOrClub", 0xB78A6E00, TdfType.UInt16, 5, true), // MXIN
        new TdfMemberInfo("MaxMembers", "mMaxMembers", 0xB78B6500, TdfType.UInt16, 6, true), // MXME
        new TdfMemberInfo("MaxNews", "mMaxNews", 0xB78BA500, TdfType.UInt16, 7, true), // MXNE
        new TdfMemberInfo("MaxRivalsPerClub", "mMaxRivalsPerClub", 0xB78CB600, TdfType.UInt16, 8, true), // MXRV
        new TdfMemberInfo("PurgeHour", "mPurgeHour", 0xC35A3200, TdfType.UInt16, 9, true), // PUHR
        new TdfMemberInfo("RecordSettings", "mRecordSettings", 0xCA5CF400, TdfType.List, 10, true), // REST
        new TdfMemberInfo("SeasonRolloverTime", "mSeasonRolloverTime", 0xCEFDB200, TdfType.Int32, 11, true), // SOVR
        new TdfMemberInfo("SeasonStartTime", "mSeasonStartTime", 0xCF4CB400, TdfType.Int32, 12, true), // STRT
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze2SDK.Blaze.Clubs.AwardSettings> _awardSettings = new(__typeInfos[0]);
    private TdfUInt16 _clubDivisionSize = new(__typeInfos[1]);
    private TdfUInt16 _maxInactiveDays = new(__typeInfos[2]);
    private TdfUInt16 _maxEvents = new(__typeInfos[3]);
    private TdfUInt16 _maxGMs = new(__typeInfos[4]);
    private TdfUInt16 _maxInvitesPerUserOrClub = new(__typeInfos[5]);
    private TdfUInt16 _maxMembers = new(__typeInfos[6]);
    private TdfUInt16 _maxNews = new(__typeInfos[7]);
    private TdfUInt16 _maxRivalsPerClub = new(__typeInfos[8]);
    private TdfUInt16 _purgeHour = new(__typeInfos[9]);
    private TdfList<Blaze2SDK.Blaze.Clubs.RecordSettings> _recordSettings = new(__typeInfos[10]);
    private TdfInt32 _seasonRolloverTime = new(__typeInfos[11]);
    private TdfInt32 _seasonStartTime = new(__typeInfos[12]);

    public ClubsComponentSettings()
    {
        __members = [
            _awardSettings,
            _clubDivisionSize,
            _maxInactiveDays,
            _maxEvents,
            _maxGMs,
            _maxInvitesPerUserOrClub,
            _maxMembers,
            _maxNews,
            _maxRivalsPerClub,
            _purgeHour,
            _recordSettings,
            _seasonRolloverTime,
            _seasonStartTime,
        ];
    }

    public override Tdf CreateNew() => new ClubsComponentSettings();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ClubsComponentSettings";
    public override string GetFullClassName() => "Blaze::Clubs::ClubsComponentSettings";

    public IList<Blaze2SDK.Blaze.Clubs.AwardSettings> AwardSettings
    {
        get => _awardSettings.Value;
        set => _awardSettings.Value = value;
    }

    public ushort ClubDivisionSize
    {
        get => _clubDivisionSize.Value;
        set => _clubDivisionSize.Value = value;
    }

    public ushort MaxInactiveDays
    {
        get => _maxInactiveDays.Value;
        set => _maxInactiveDays.Value = value;
    }

    public ushort MaxEvents
    {
        get => _maxEvents.Value;
        set => _maxEvents.Value = value;
    }

    public ushort MaxGMs
    {
        get => _maxGMs.Value;
        set => _maxGMs.Value = value;
    }

    public ushort MaxInvitesPerUserOrClub
    {
        get => _maxInvitesPerUserOrClub.Value;
        set => _maxInvitesPerUserOrClub.Value = value;
    }

    public ushort MaxMembers
    {
        get => _maxMembers.Value;
        set => _maxMembers.Value = value;
    }

    public ushort MaxNews
    {
        get => _maxNews.Value;
        set => _maxNews.Value = value;
    }

    public ushort MaxRivalsPerClub
    {
        get => _maxRivalsPerClub.Value;
        set => _maxRivalsPerClub.Value = value;
    }

    public ushort PurgeHour
    {
        get => _purgeHour.Value;
        set => _purgeHour.Value = value;
    }

    public IList<Blaze2SDK.Blaze.Clubs.RecordSettings> RecordSettings
    {
        get => _recordSettings.Value;
        set => _recordSettings.Value = value;
    }

    public int SeasonRolloverTime
    {
        get => _seasonRolloverTime.Value;
        set => _seasonRolloverTime.Value = value;
    }

    public int SeasonStartTime
    {
        get => _seasonStartTime.Value;
        set => _seasonStartTime.Value = value;
    }

}

