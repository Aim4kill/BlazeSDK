using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.League;

public class CreateLeagueRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Abbrev", "mAbbrev", 0x8628B200, TdfType.String, 0, true), // ABBR
        new TdfMemberInfo("Description", "mDescription", 0x925CE300, TdfType.String, 1, true), // DESC
        new TdfMemberInfo("MaxDNF", "mMaxDNF", 0x92E98000, TdfType.Int32, 2, true), // DNF
        new TdfMemberInfo("NumGames", "mNumGames", 0x9E1B7300, TdfType.UInt8, 3, true), // GAMS
        new TdfMemberInfo("LeagueFlags", "mLeagueFlags", 0xB26B2700, TdfType.Enum, 4, true), // LFLG
        new TdfMemberInfo("Logo", "mLogo", 0xB2F9EF00, TdfType.UInt16, 5, true), // LOGO
        new TdfMemberInfo("MaxMembers", "mMaxMembers", 0xB61E2D00, TdfType.UInt16, 6, true), // MAXM
        new TdfMemberInfo("Metadata", "mMetadata", 0xB65D2100, TdfType.Blob, 7, true), // META
        new TdfMemberInfo("Name", "mName", 0xBA1B6500, TdfType.String, 8, true), // NAME
        new TdfMemberInfo("Options", "mOptions", 0xBF0D3300, TdfType.List, 9, true), // OPTS
        new TdfMemberInfo("Password", "mPassword", 0xC21CF300, TdfType.String, 10, true), // PASS
        new TdfMemberInfo("NumPlayoffGames", "mNumPlayoffGames", 0xC2CBEE00, TdfType.UInt8, 11, true), // PLON
        new TdfMemberInfo("PlayoffType", "mPlayoffType", 0xC34E7000, TdfType.Enum, 12, true), // PTYP
        new TdfMemberInfo("MinReputation", "mMinReputation", 0xCA5C0000, TdfType.Int32, 13, true), // REP
        new TdfMemberInfo("NumRounds", "mNumRounds", 0xCAE93300, TdfType.UInt8, 14, true), // RNDS
        new TdfMemberInfo("GameTeamRoster", "mGameTeamRoster", 0xCAFCF400, TdfType.String, 15, true), // ROST
        new TdfMemberInfo("ScheduleType", "mScheduleType", 0xCE3A2400, TdfType.Enum, 16, true), // SCHD
        new TdfMemberInfo("IsStringMetadata", "mIsStringMetadata", 0xCED97400, TdfType.UInt8, 17, true), // SMET
        new TdfMemberInfo("CreatorTeamId", "mCreatorTeamId", 0xD2586D00, TdfType.UInt32, 18, true), // TEAM
        new TdfMemberInfo("Trophy", "mTrophy", 0xD32C2800, TdfType.UInt32, 19, true), // TRPH
        new TdfMemberInfo("TradeType", "mTradeType", 0xD34E7000, TdfType.Enum, 20, true), // TTYP
    ];
    private ITdfMember[] __members;

    private TdfString _abbrev = new(__typeInfos[0]);
    private TdfString _description = new(__typeInfos[1]);
    private TdfInt32 _maxDNF = new(__typeInfos[2]);
    private TdfUInt8 _numGames = new(__typeInfos[3]);
    private TdfEnum<Blaze3SDK.Blaze.League.LeagueFlags> _leagueFlags = new(__typeInfos[4]);
    private TdfUInt16 _logo = new(__typeInfos[5]);
    private TdfUInt16 _maxMembers = new(__typeInfos[6]);
    private TdfBlob _metadata = new(__typeInfos[7]);
    private TdfString _name = new(__typeInfos[8]);
    private TdfList<int> _options = new(__typeInfos[9]);
    private TdfString _password = new(__typeInfos[10]);
    private TdfUInt8 _numPlayoffGames = new(__typeInfos[11]);
    private TdfEnum<Blaze3SDK.Blaze.League.PlayoffType> _playoffType = new(__typeInfos[12]);
    private TdfInt32 _minReputation = new(__typeInfos[13]);
    private TdfUInt8 _numRounds = new(__typeInfos[14]);
    private TdfString _gameTeamRoster = new(__typeInfos[15]);
    private TdfEnum<Blaze3SDK.Blaze.League.ScheduleType> _scheduleType = new(__typeInfos[16]);
    private TdfUInt8 _isStringMetadata = new(__typeInfos[17]);
    private TdfUInt32 _creatorTeamId = new(__typeInfos[18]);
    private TdfUInt32 _trophy = new(__typeInfos[19]);
    private TdfEnum<Blaze3SDK.Blaze.League.TradeType> _tradeType = new(__typeInfos[20]);

    public CreateLeagueRequest()
    {
        __members = [
            _abbrev,
            _description,
            _maxDNF,
            _numGames,
            _leagueFlags,
            _logo,
            _maxMembers,
            _metadata,
            _name,
            _options,
            _password,
            _numPlayoffGames,
            _playoffType,
            _minReputation,
            _numRounds,
            _gameTeamRoster,
            _scheduleType,
            _isStringMetadata,
            _creatorTeamId,
            _trophy,
            _tradeType,
        ];
    }

    public override Tdf CreateNew() => new CreateLeagueRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "CreateLeagueRequest";
    public override string GetFullClassName() => "Blaze::League::CreateLeagueRequest";

    public string Abbrev
    {
        get => _abbrev.Value;
        set => _abbrev.Value = value;
    }

    public string Description
    {
        get => _description.Value;
        set => _description.Value = value;
    }

    public int MaxDNF
    {
        get => _maxDNF.Value;
        set => _maxDNF.Value = value;
    }

    public byte NumGames
    {
        get => _numGames.Value;
        set => _numGames.Value = value;
    }

    public Blaze3SDK.Blaze.League.LeagueFlags LeagueFlags
    {
        get => _leagueFlags.Value;
        set => _leagueFlags.Value = value;
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

    public IList<int> Options
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

    public Blaze3SDK.Blaze.League.PlayoffType PlayoffType
    {
        get => _playoffType.Value;
        set => _playoffType.Value = value;
    }

    public int MinReputation
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

    public Blaze3SDK.Blaze.League.ScheduleType ScheduleType
    {
        get => _scheduleType.Value;
        set => _scheduleType.Value = value;
    }

    public byte IsStringMetadata
    {
        get => _isStringMetadata.Value;
        set => _isStringMetadata.Value = value;
    }

    public uint CreatorTeamId
    {
        get => _creatorTeamId.Value;
        set => _creatorTeamId.Value = value;
    }

    public uint Trophy
    {
        get => _trophy.Value;
        set => _trophy.Value = value;
    }

    public Blaze3SDK.Blaze.League.TradeType TradeType
    {
        get => _tradeType.Value;
        set => _tradeType.Value = value;
    }

}

