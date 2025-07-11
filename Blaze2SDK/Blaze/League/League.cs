using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.League;

public class League : Tdf
{
    public enum LeagueState : int
    {
        LEAGUE_STATE_NONE = 0,
        LEAGUE_STATE_REGISTRATION = 1,
        LEAGUE_STATE_DRAFT = 2,
        LEAGUE_STATE_REGULAR_SEASON = 3,
        LEAGUE_STATE_PLAYOFFS = 4,
        LEAGUE_STATE_COMPLETED = 5,
    }
    
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Abbrev", "mAbbrev", 0x8628B200, TdfType.String, 0, true), // ABBR
        new TdfMemberInfo("LastActiveTime", "mLastActiveTime", 0x863D3600, TdfType.UInt32, 1, true), // ACTV
        new TdfMemberInfo("CurrChampion", "mCurrChampion", 0x8E8B7000, TdfType.Struct, 2, true), // CHMP
        new TdfMemberInfo("Creator", "mCreator", 0x8F296100, TdfType.Struct, 3, true), // CREA
        new TdfMemberInfo("CurrRound", "mCurrRound", 0x8F2BA400, TdfType.UInt8, 4, true), // CRND
        new TdfMemberInfo("CreationTime", "mCreationTime", 0x8F2D2D00, TdfType.UInt32, 5, true), // CRTM
        new TdfMemberInfo("NumMembers", "mNumMembers", 0x8F5CAD00, TdfType.UInt16, 6, true), // CURM
        new TdfMemberInfo("Description", "mDescription", 0x925CE300, TdfType.String, 7, true), // DESC
        new TdfMemberInfo("MaxDNF", "mMaxDNF", 0x92E98000, TdfType.Int16, 8, true), // DNF
        new TdfMemberInfo("NumGames", "mNumGames", 0x9E1B7300, TdfType.UInt8, 9, true), // GAMS
        new TdfMemberInfo("IsGM", "mIsGM", 0xA739ED00, TdfType.UInt8, 10, true), // ISGM
        new TdfMemberInfo("LeagueFlags", "mLeagueFlags", 0xB26B2700, TdfType.Enum, 11, true), // LFLG
        new TdfMemberInfo("LeagueId", "mLeagueId", 0xB27A6400, TdfType.UInt32, 12, true), // LGID
        new TdfMemberInfo("Logo", "mLogo", 0xB2F9EF00, TdfType.UInt16, 13, true), // LOGO
        new TdfMemberInfo("MaxMembers", "mMaxMembers", 0xB61E2D00, TdfType.UInt16, 14, true), // MAXM
        new TdfMemberInfo("Metadata", "mMetadata", 0xB65D2100, TdfType.Blob, 15, true), // META
        new TdfMemberInfo("Name", "mName", 0xBA1B6500, TdfType.String, 16, true), // NAME
        new TdfMemberInfo("NumberOfMembersOnline", "mNumberOfMembersOnline", 0xBEEB2E00, TdfType.UInt8, 17, true), // ONLN
        new TdfMemberInfo("Options", "mOptions", 0xBF0D3300, TdfType.List, 18, true), // OPTS
        new TdfMemberInfo("Password", "mPassword", 0xC21CF300, TdfType.String, 19, true), // PASS
        new TdfMemberInfo("NumPlayoffGames", "mNumPlayoffGames", 0xC2CBEE00, TdfType.UInt8, 20, true), // PLON
        new TdfMemberInfo("PlayoffType", "mPlayoffType", 0xC34E7000, TdfType.Enum, 21, true), // PTYP
        new TdfMemberInfo("MinReputation", "mMinReputation", 0xCA5C0000, TdfType.Int16, 22, true), // REP
        new TdfMemberInfo("NumRounds", "mNumRounds", 0xCAE93300, TdfType.UInt8, 23, true), // RNDS
        new TdfMemberInfo("GameTeamRoster", "mGameTeamRoster", 0xCAFCF400, TdfType.String, 24, true), // ROST
        new TdfMemberInfo("ScheduleType", "mScheduleType", 0xCE3A2400, TdfType.Enum, 25, true), // SCHD
        new TdfMemberInfo("CurrSeason", "mCurrSeason", 0xCE587300, TdfType.UInt16, 26, true), // SEAS
        new TdfMemberInfo("IsStringMetadata", "mIsStringMetadata", 0xCED97400, TdfType.UInt8, 27, true), // SMET
        new TdfMemberInfo("ChampionNumWins", "mChampionNumWins", 0xCF4CAB00, TdfType.UInt8, 28, true), // STRK
        new TdfMemberInfo("LeagueState", "mLeagueState", 0xCF4D3300, TdfType.Enum, 29, true), // STTS
        new TdfMemberInfo("TeamsInUse", "mTeamsInUse", 0xD25B7300, TdfType.List, 30, true), // TEMS
        new TdfMemberInfo("Trophy", "mTrophy", 0xD32C2800, TdfType.UInt32, 31, true), // TRPH
        new TdfMemberInfo("TradeType", "mTradeType", 0xD34E7000, TdfType.Enum, 32, true), // TTYP
    ];
    private ITdfMember[] __members;

    private TdfString _abbrev = new(__typeInfos[0]);
    private TdfUInt32 _lastActiveTime = new(__typeInfos[1]);
    private TdfStruct<Blaze2SDK.Blaze.League.LeagueUser?> _currChampion = new(__typeInfos[2]);
    private TdfStruct<Blaze2SDK.Blaze.League.LeagueUser?> _creator = new(__typeInfos[3]);
    private TdfUInt8 _currRound = new(__typeInfos[4]);
    private TdfUInt32 _creationTime = new(__typeInfos[5]);
    private TdfUInt16 _numMembers = new(__typeInfos[6]);
    private TdfString _description = new(__typeInfos[7]);
    private TdfInt16 _maxDNF = new(__typeInfos[8]);
    private TdfUInt8 _numGames = new(__typeInfos[9]);
    private TdfUInt8 _isGM = new(__typeInfos[10]);
    private TdfEnum<Blaze2SDK.Blaze.League.LeagueFlags> _leagueFlags = new(__typeInfos[11]);
    private TdfUInt32 _leagueId = new(__typeInfos[12]);
    private TdfUInt16 _logo = new(__typeInfos[13]);
    private TdfUInt16 _maxMembers = new(__typeInfos[14]);
    private TdfBlob _metadata = new(__typeInfos[15]);
    private TdfString _name = new(__typeInfos[16]);
    private TdfUInt8 _numberOfMembersOnline = new(__typeInfos[17]);
    private TdfList<uint> _options = new(__typeInfos[18]);
    private TdfString _password = new(__typeInfos[19]);
    private TdfUInt8 _numPlayoffGames = new(__typeInfos[20]);
    private TdfEnum<Blaze2SDK.Blaze.League.PlayoffType> _playoffType = new(__typeInfos[21]);
    private TdfInt16 _minReputation = new(__typeInfos[22]);
    private TdfUInt8 _numRounds = new(__typeInfos[23]);
    private TdfString _gameTeamRoster = new(__typeInfos[24]);
    private TdfEnum<Blaze2SDK.Blaze.League.ScheduleType> _scheduleType = new(__typeInfos[25]);
    private TdfUInt16 _currSeason = new(__typeInfos[26]);
    private TdfUInt8 _isStringMetadata = new(__typeInfos[27]);
    private TdfUInt8 _championNumWins = new(__typeInfos[28]);
    private TdfEnum<Blaze2SDK.Blaze.League.League.LeagueState> _leagueState = new(__typeInfos[29]);
    private TdfList<uint> _teamsInUse = new(__typeInfos[30]);
    private TdfUInt32 _trophy = new(__typeInfos[31]);
    private TdfEnum<Blaze2SDK.Blaze.League.TradeType> _tradeType = new(__typeInfos[32]);

    public League()
    {
        __members = [
            _abbrev,
            _lastActiveTime,
            _currChampion,
            _creator,
            _currRound,
            _creationTime,
            _numMembers,
            _description,
            _maxDNF,
            _numGames,
            _isGM,
            _leagueFlags,
            _leagueId,
            _logo,
            _maxMembers,
            _metadata,
            _name,
            _numberOfMembersOnline,
            _options,
            _password,
            _numPlayoffGames,
            _playoffType,
            _minReputation,
            _numRounds,
            _gameTeamRoster,
            _scheduleType,
            _currSeason,
            _isStringMetadata,
            _championNumWins,
            _leagueState,
            _teamsInUse,
            _trophy,
            _tradeType,
        ];
    }

    public override Tdf CreateNew() => new League();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "League";
    public override string GetFullClassName() => "Blaze::League::League";

    public string Abbrev
    {
        get => _abbrev.Value;
        set => _abbrev.Value = value;
    }

    public uint LastActiveTime
    {
        get => _lastActiveTime.Value;
        set => _lastActiveTime.Value = value;
    }

    public Blaze2SDK.Blaze.League.LeagueUser? CurrChampion
    {
        get => _currChampion.Value;
        set => _currChampion.Value = value;
    }

    public Blaze2SDK.Blaze.League.LeagueUser? Creator
    {
        get => _creator.Value;
        set => _creator.Value = value;
    }

    public byte CurrRound
    {
        get => _currRound.Value;
        set => _currRound.Value = value;
    }

    public uint CreationTime
    {
        get => _creationTime.Value;
        set => _creationTime.Value = value;
    }

    public ushort NumMembers
    {
        get => _numMembers.Value;
        set => _numMembers.Value = value;
    }

    public string Description
    {
        get => _description.Value;
        set => _description.Value = value;
    }

    public short MaxDNF
    {
        get => _maxDNF.Value;
        set => _maxDNF.Value = value;
    }

    public byte NumGames
    {
        get => _numGames.Value;
        set => _numGames.Value = value;
    }

    public byte IsGM
    {
        get => _isGM.Value;
        set => _isGM.Value = value;
    }

    public Blaze2SDK.Blaze.League.LeagueFlags LeagueFlags
    {
        get => _leagueFlags.Value;
        set => _leagueFlags.Value = value;
    }

    public uint LeagueId
    {
        get => _leagueId.Value;
        set => _leagueId.Value = value;
    }

    public ushort Logo
    {
        get => _logo.Value;
        set => _logo.Value = value;
    }

    public ushort MaxMembers
    {
        get => _maxMembers.Value;
        set => _maxMembers.Value = value;
    }

    public byte[] Metadata
    {
        get => _metadata.Value;
        set => _metadata.Value = value;
    }

    public string Name
    {
        get => _name.Value;
        set => _name.Value = value;
    }

    public byte NumberOfMembersOnline
    {
        get => _numberOfMembersOnline.Value;
        set => _numberOfMembersOnline.Value = value;
    }

    public IList<uint> Options
    {
        get => _options.Value;
        set => _options.Value = value;
    }

    public string Password
    {
        get => _password.Value;
        set => _password.Value = value;
    }

    public byte NumPlayoffGames
    {
        get => _numPlayoffGames.Value;
        set => _numPlayoffGames.Value = value;
    }

    public Blaze2SDK.Blaze.League.PlayoffType PlayoffType
    {
        get => _playoffType.Value;
        set => _playoffType.Value = value;
    }

    public short MinReputation
    {
        get => _minReputation.Value;
        set => _minReputation.Value = value;
    }

    public byte NumRounds
    {
        get => _numRounds.Value;
        set => _numRounds.Value = value;
    }

    public string GameTeamRoster
    {
        get => _gameTeamRoster.Value;
        set => _gameTeamRoster.Value = value;
    }

    public Blaze2SDK.Blaze.League.ScheduleType ScheduleType
    {
        get => _scheduleType.Value;
        set => _scheduleType.Value = value;
    }

    public ushort CurrSeason
    {
        get => _currSeason.Value;
        set => _currSeason.Value = value;
    }

    public byte IsStringMetadata
    {
        get => _isStringMetadata.Value;
        set => _isStringMetadata.Value = value;
    }

    public byte ChampionNumWins
    {
        get => _championNumWins.Value;
        set => _championNumWins.Value = value;
    }

    public Blaze2SDK.Blaze.League.League.LeagueState mLeagueState
    {
        get => _leagueState.Value;
        set => _leagueState.Value = value;
    }

    public IList<uint> TeamsInUse
    {
        get => _teamsInUse.Value;
        set => _teamsInUse.Value = value;
    }

    public uint Trophy
    {
        get => _trophy.Value;
        set => _trophy.Value = value;
    }

    public Blaze2SDK.Blaze.League.TradeType TradeType
    {
        get => _tradeType.Value;
        set => _tradeType.Value = value;
    }

}

