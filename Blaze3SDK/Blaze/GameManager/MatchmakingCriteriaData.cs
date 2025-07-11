using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class MatchmakingCriteriaData : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CustomRulePrefs", "mCustomRulePrefs", 0x8F5CF400, TdfType.Struct, 0, true), // CUST
        new TdfMemberInfo("DNFRulePrefs", "mDNFRulePrefs", 0x92E98000, TdfType.Struct, 1, true), // DNF
        new TdfMemberInfo("GeoLocationRuleCriteria", "mGeoLocationRuleCriteria", 0x9E5BC000, TdfType.Struct, 2, true), // GEO
        new TdfMemberInfo("GameNameRuleCriteria", "mGameNameRuleCriteria", 0x9EE86D00, TdfType.Struct, 3, true), // GNAM
        new TdfMemberInfo("HostBalancingRulePrefs", "mHostBalancingRulePrefs", 0xBA1D0000, TdfType.Struct, 4, true), // NAT
        new TdfMemberInfo("PingSiteRulePrefs", "mPingSiteRulePrefs", 0xC33C8000, TdfType.Struct, 5, true), // PSR
        new TdfMemberInfo("RankedGameRulePrefs", "mRankedGameRulePrefs", 0xCA1BAB00, TdfType.Struct, 6, true), // RANK
        new TdfMemberInfo("GenericRulePrefsList", "mGenericRulePrefsList", 0xCACCF400, TdfType.List, 7, true), // RLST
        new TdfMemberInfo("RosterSizeRulePrefs", "mRosterSizeRulePrefs", 0xCB3EB200, TdfType.Struct, 8, true), // RSZR
        new TdfMemberInfo("GameSizeRulePrefs", "mGameSizeRulePrefs", 0xCE9EA500, TdfType.Struct, 9, true), // SIZE
        new TdfMemberInfo("SkillRulePrefsList", "mSkillRulePrefsList", 0xCEBB3A00, TdfType.List, 10, true), // SKLZ
        new TdfMemberInfo("TeamSizeRulePrefs", "mTeamSizeRulePrefs", 0xD2586D00, TdfType.Struct, 11, true), // TEAM
        new TdfMemberInfo("UEDRuleCriteriaMap", "mUEDRuleCriteriaMap", 0xD6590000, TdfType.Map, 12, true), // UED
        new TdfMemberInfo("HostViabilityRulePrefs", "mHostViabilityRulePrefs", 0xDA986200, TdfType.Struct, 13, true), // VIAB
        new TdfMemberInfo("VirtualGameRulePrefs", "mVirtualGameRulePrefs", 0xDA9CB400, TdfType.Struct, 14, true), // VIRT
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze3SDK.Blaze.GameManager.MatchmakingCustomCriteriaData?> _customRulePrefs = new(__typeInfos[0]);
    private TdfStruct<Blaze3SDK.Blaze.GameManager.DNFRulePrefs?> _dNFRulePrefs = new(__typeInfos[1]);
    private TdfStruct<Blaze3SDK.Blaze.GameManager.GeoLocationRuleCriteria?> _geoLocationRuleCriteria = new(__typeInfos[2]);
    private TdfStruct<Blaze3SDK.Blaze.GameManager.GameNameRuleCriteria?> _gameNameRuleCriteria = new(__typeInfos[3]);
    private TdfStruct<Blaze3SDK.Blaze.GameManager.HostBalancingRulePrefs?> _hostBalancingRulePrefs = new(__typeInfos[4]);
    private TdfStruct<Blaze3SDK.Blaze.GameManager.PingSiteRulePrefs?> _pingSiteRulePrefs = new(__typeInfos[5]);
    private TdfStruct<Blaze3SDK.Blaze.GameManager.RankedGameRulePrefs?> _rankedGameRulePrefs = new(__typeInfos[6]);
    private TdfList<Blaze3SDK.Blaze.GameManager.GenericRulePrefs> _genericRulePrefsList = new(__typeInfos[7]);
    private TdfStruct<Blaze3SDK.Blaze.GameManager.RosterSizeRulePrefs?> _rosterSizeRulePrefs = new(__typeInfos[8]);
    private TdfStruct<Blaze3SDK.Blaze.GameManager.GameSizeRulePrefs?> _gameSizeRulePrefs = new(__typeInfos[9]);
    private TdfList<Blaze3SDK.Blaze.GameManager.SkillRulePrefs> _skillRulePrefsList = new(__typeInfos[10]);
    private TdfStruct<Blaze3SDK.Blaze.GameManager.TeamSizeRulePrefs?> _teamSizeRulePrefs = new(__typeInfos[11]);
    private TdfMap<string, Blaze3SDK.Blaze.GameManager.UEDRuleCriteria> _uEDRuleCriteriaMap = new(__typeInfos[12]);
    private TdfStruct<Blaze3SDK.Blaze.GameManager.HostViabilityRulePrefs?> _hostViabilityRulePrefs = new(__typeInfos[13]);
    private TdfStruct<Blaze3SDK.Blaze.GameManager.VirtualGameRulePrefs?> _virtualGameRulePrefs = new(__typeInfos[14]);

    public MatchmakingCriteriaData()
    {
        __members = [
            _customRulePrefs,
            _dNFRulePrefs,
            _geoLocationRuleCriteria,
            _gameNameRuleCriteria,
            _hostBalancingRulePrefs,
            _pingSiteRulePrefs,
            _rankedGameRulePrefs,
            _genericRulePrefsList,
            _rosterSizeRulePrefs,
            _gameSizeRulePrefs,
            _skillRulePrefsList,
            _teamSizeRulePrefs,
            _uEDRuleCriteriaMap,
            _hostViabilityRulePrefs,
            _virtualGameRulePrefs,
        ];
    }

    public override Tdf CreateNew() => new MatchmakingCriteriaData();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "MatchmakingCriteriaData";
    public override string GetFullClassName() => "Blaze::GameManager::MatchmakingCriteriaData";

    public Blaze3SDK.Blaze.GameManager.MatchmakingCustomCriteriaData? CustomRulePrefs
    {
        get => _customRulePrefs.Value;
        set => _customRulePrefs.Value = value;
    }

    public Blaze3SDK.Blaze.GameManager.DNFRulePrefs? DNFRulePrefs
    {
        get => _dNFRulePrefs.Value;
        set => _dNFRulePrefs.Value = value;
    }

    public Blaze3SDK.Blaze.GameManager.GeoLocationRuleCriteria? GeoLocationRuleCriteria
    {
        get => _geoLocationRuleCriteria.Value;
        set => _geoLocationRuleCriteria.Value = value;
    }

    public Blaze3SDK.Blaze.GameManager.GameNameRuleCriteria? GameNameRuleCriteria
    {
        get => _gameNameRuleCriteria.Value;
        set => _gameNameRuleCriteria.Value = value;
    }

    public Blaze3SDK.Blaze.GameManager.HostBalancingRulePrefs? HostBalancingRulePrefs
    {
        get => _hostBalancingRulePrefs.Value;
        set => _hostBalancingRulePrefs.Value = value;
    }

    public Blaze3SDK.Blaze.GameManager.PingSiteRulePrefs? PingSiteRulePrefs
    {
        get => _pingSiteRulePrefs.Value;
        set => _pingSiteRulePrefs.Value = value;
    }

    public Blaze3SDK.Blaze.GameManager.RankedGameRulePrefs? RankedGameRulePrefs
    {
        get => _rankedGameRulePrefs.Value;
        set => _rankedGameRulePrefs.Value = value;
    }

    public IList<Blaze3SDK.Blaze.GameManager.GenericRulePrefs> GenericRulePrefsList
    {
        get => _genericRulePrefsList.Value;
        set => _genericRulePrefsList.Value = value;
    }

    public Blaze3SDK.Blaze.GameManager.RosterSizeRulePrefs? RosterSizeRulePrefs
    {
        get => _rosterSizeRulePrefs.Value;
        set => _rosterSizeRulePrefs.Value = value;
    }

    public Blaze3SDK.Blaze.GameManager.GameSizeRulePrefs? GameSizeRulePrefs
    {
        get => _gameSizeRulePrefs.Value;
        set => _gameSizeRulePrefs.Value = value;
    }

    public IList<Blaze3SDK.Blaze.GameManager.SkillRulePrefs> SkillRulePrefsList
    {
        get => _skillRulePrefsList.Value;
        set => _skillRulePrefsList.Value = value;
    }

    public Blaze3SDK.Blaze.GameManager.TeamSizeRulePrefs? TeamSizeRulePrefs
    {
        get => _teamSizeRulePrefs.Value;
        set => _teamSizeRulePrefs.Value = value;
    }

    public IDictionary<string, Blaze3SDK.Blaze.GameManager.UEDRuleCriteria> UEDRuleCriteriaMap
    {
        get => _uEDRuleCriteriaMap.Value;
        set => _uEDRuleCriteriaMap.Value = value;
    }

    public Blaze3SDK.Blaze.GameManager.HostViabilityRulePrefs? HostViabilityRulePrefs
    {
        get => _hostViabilityRulePrefs.Value;
        set => _hostViabilityRulePrefs.Value = value;
    }

    public Blaze3SDK.Blaze.GameManager.VirtualGameRulePrefs? VirtualGameRulePrefs
    {
        get => _virtualGameRulePrefs.Value;
        set => _virtualGameRulePrefs.Value = value;
    }

}

