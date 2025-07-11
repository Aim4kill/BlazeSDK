using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.League;

public class FindLeaguesRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Abbrev", "mAbbrev", 0x8628B200, TdfType.String, 0, true), // ABBR
        new TdfMemberInfo("MaxDNF", "mMaxDNF", 0x92E98000, TdfType.Int32, 1, true), // DNF
        new TdfMemberInfo("DraftEnabled", "mDraftEnabled", 0x9329B400, TdfType.Int32, 2, true), // DRFT
        new TdfMemberInfo("NumGames", "mNumGames", 0x9E1B6500, TdfType.Int32, 3, true), // GAME
        new TdfMemberInfo("JoinsEnabled", "mJoinsEnabled", 0xAAFA6E00, TdfType.Int32, 4, true), // JOIN
        new TdfMemberInfo("Name", "mName", 0xB27BAD00, TdfType.String, 5, true), // LGNM
        new TdfMemberInfo("MaxMembers", "mMaxMembers", 0xB61E2D00, TdfType.Int32, 6, true), // MAXM
        new TdfMemberInfo("MaxResults", "mMaxResults", 0xB61E3200, TdfType.UInt32, 7, true), // MAXR
        new TdfMemberInfo("RetrieveMetadata", "mRetrieveMetadata", 0xB65D2100, TdfType.UInt8, 8, true), // META
        new TdfMemberInfo("Options", "mOptions", 0xBF0D3300, TdfType.List, 9, true), // OPTS
        new TdfMemberInfo("PlayoffsEnabled", "mPlayoffsEnabled", 0xC2F9A600, TdfType.Int32, 10, true), // POFF
        new TdfMemberInfo("PlayerStatsEnabled", "mPlayerStatsEnabled", 0xC33D2100, TdfType.Int32, 11, true), // PSTA
        new TdfMemberInfo("MinReputation", "mMinReputation", 0xCA5C0000, TdfType.Int32, 12, true), // REP
        new TdfMemberInfo("PreferredTeamId", "mPreferredTeamId", 0xD2586D00, TdfType.Int32, 13, true), // TEAM
        new TdfMemberInfo("TradesEnabled", "mTradesEnabled", 0xD3286400, TdfType.Int32, 14, true), // TRAD
        new TdfMemberInfo("UniqueTeamsEnabled", "mUniqueTeamsEnabled", 0xD6EA7100, TdfType.Int32, 15, true), // UNIQ
    ];
    private ITdfMember[] __members;

    private TdfString _abbrev = new(__typeInfos[0]);
    private TdfInt32 _maxDNF = new(__typeInfos[1]);
    private TdfInt32 _draftEnabled = new(__typeInfos[2]);
    private TdfInt32 _numGames = new(__typeInfos[3]);
    private TdfInt32 _joinsEnabled = new(__typeInfos[4]);
    private TdfString _name = new(__typeInfos[5]);
    private TdfInt32 _maxMembers = new(__typeInfos[6]);
    private TdfUInt32 _maxResults = new(__typeInfos[7]);
    private TdfUInt8 _retrieveMetadata = new(__typeInfos[8]);
    private TdfList<int> _options = new(__typeInfos[9]);
    private TdfInt32 _playoffsEnabled = new(__typeInfos[10]);
    private TdfInt32 _playerStatsEnabled = new(__typeInfos[11]);
    private TdfInt32 _minReputation = new(__typeInfos[12]);
    private TdfInt32 _preferredTeamId = new(__typeInfos[13]);
    private TdfInt32 _tradesEnabled = new(__typeInfos[14]);
    private TdfInt32 _uniqueTeamsEnabled = new(__typeInfos[15]);

    public FindLeaguesRequest()
    {
        __members = [
            _abbrev,
            _maxDNF,
            _draftEnabled,
            _numGames,
            _joinsEnabled,
            _name,
            _maxMembers,
            _maxResults,
            _retrieveMetadata,
            _options,
            _playoffsEnabled,
            _playerStatsEnabled,
            _minReputation,
            _preferredTeamId,
            _tradesEnabled,
            _uniqueTeamsEnabled,
        ];
    }

    public override Tdf CreateNew() => new FindLeaguesRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "FindLeaguesRequest";
    public override string GetFullClassName() => "Blaze::League::FindLeaguesRequest";

    public string Abbrev
    {
        get => _abbrev.Value;
        set => _abbrev.Value = value;
    }

    public int MaxDNF
    {
        get => _maxDNF.Value;
        set => _maxDNF.Value = value;
    }

    public int DraftEnabled
    {
        get => _draftEnabled.Value;
        set => _draftEnabled.Value = value;
    }

    public int NumGames
    {
        get => _numGames.Value;
        set => _numGames.Value = value;
    }

    public int JoinsEnabled
    {
        get => _joinsEnabled.Value;
        set => _joinsEnabled.Value = value;
    }

    public string Name
    {
        get => _name.Value;
        set => _name.Value = value;
    }

    public int MaxMembers
    {
        get => _maxMembers.Value;
        set => _maxMembers.Value = value;
    }

    public uint MaxResults
    {
        get => _maxResults.Value;
        set => _maxResults.Value = value;
    }

    public byte RetrieveMetadata
    {
        get => _retrieveMetadata.Value;
        set => _retrieveMetadata.Value = value;
    }

    public IList<int> Options
    {
        get => _options.Value;
        set => _options.Value = value;
    }

    public int PlayoffsEnabled
    {
        get => _playoffsEnabled.Value;
        set => _playoffsEnabled.Value = value;
    }

    public int PlayerStatsEnabled
    {
        get => _playerStatsEnabled.Value;
        set => _playerStatsEnabled.Value = value;
    }

    public int MinReputation
    {
        get => _minReputation.Value;
        set => _minReputation.Value = value;
    }

    public int PreferredTeamId
    {
        get => _preferredTeamId.Value;
        set => _preferredTeamId.Value = value;
    }

    public int TradesEnabled
    {
        get => _tradesEnabled.Value;
        set => _tradesEnabled.Value = value;
    }

    public int UniqueTeamsEnabled
    {
        get => _uniqueTeamsEnabled.Value;
        set => _uniqueTeamsEnabled.Value = value;
    }

}

