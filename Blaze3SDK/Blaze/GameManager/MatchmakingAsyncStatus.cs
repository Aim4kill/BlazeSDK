using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class MatchmakingAsyncStatus : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CreateGameStatus", "mCreateGameStatus", 0x8E7CC000, TdfType.Struct, 0, true), // CGS
        new TdfMemberInfo("CustomAsynStatus", "mCustomAsynStatus", 0x8F5CF400, TdfType.Struct, 1, true), // CUST
        new TdfMemberInfo("DNFRuleStatus", "mDNFRuleStatus", 0x92E9B300, TdfType.Struct, 2, true), // DNFS
        new TdfMemberInfo("FindGameStatus", "mFindGameStatus", 0x9A7CC000, TdfType.Struct, 3, true), // FGS
        new TdfMemberInfo("GeoLocationRuleStatus", "mGeoLocationRuleStatus", 0x9E5BF300, TdfType.Struct, 4, true), // GEOS
        new TdfMemberInfo("GenericRuleStatusMap", "mGenericRuleStatusMap", 0x9F292100, TdfType.Map, 5, true), // GRDA
        new TdfMemberInfo("GameSizeRuleStatus", "mGameSizeRuleStatus", 0x9F3CA400, TdfType.Struct, 6, true), // GSRD
        new TdfMemberInfo("HostBalanceRuleStatus", "mHostBalanceRuleStatus", 0xA22CA400, TdfType.Struct, 7, true), // HBRD
        new TdfMemberInfo("HostViabilityRuleStatus", "mHostViabilityRuleStatus", 0xA36CA400, TdfType.Struct, 8, true), // HVRD
        new TdfMemberInfo("PingSiteRuleStatus", "mPingSiteRuleStatus", 0xC33CB300, TdfType.Struct, 9, true), // PSRS
        new TdfMemberInfo("RankRuleStatus", "mRankRuleStatus", 0xCB292100, TdfType.Struct, 10, true), // RRDA
        new TdfMemberInfo("SkillRuleStatusMap", "mSkillRuleStatusMap", 0xCEBCB300, TdfType.Map, 11, true), // SKRS
        new TdfMemberInfo("TeamSizeRuleStatus", "mTeamSizeRuleStatus", 0xD33CB300, TdfType.Struct, 12, true), // TSRS
        new TdfMemberInfo("UEDRuleStatusMap", "mUEDRuleStatusMap", 0xD6593300, TdfType.Map, 13, true), // UEDS
        new TdfMemberInfo("VirtualGameRuleStatus", "mVirtualGameRuleStatus", 0xDA7CB300, TdfType.Struct, 14, true), // VGRS
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze3SDK.Blaze.GameManager.CreateGameStatus?> _createGameStatus = new(__typeInfos[0]);
    private TdfStruct<Blaze3SDK.Blaze.GameManager.MatchmakingCustomAsyncStatus?> _customAsynStatus = new(__typeInfos[1]);
    private TdfStruct<Blaze3SDK.Blaze.GameManager.DNFRuleStatus?> _dNFRuleStatus = new(__typeInfos[2]);
    private TdfStruct<Blaze3SDK.Blaze.GameManager.FindGameStatus?> _findGameStatus = new(__typeInfos[3]);
    private TdfStruct<Blaze3SDK.Blaze.GameManager.GeoLocationRuleStatus?> _geoLocationRuleStatus = new(__typeInfos[4]);
    private TdfMap<string, Blaze3SDK.Blaze.GameManager.GenericRuleStatus> _genericRuleStatusMap = new(__typeInfos[5]);
    private TdfStruct<Blaze3SDK.Blaze.GameManager.GameSizeRuleStatus?> _gameSizeRuleStatus = new(__typeInfos[6]);
    private TdfStruct<Blaze3SDK.Blaze.GameManager.HostBalanceRuleStatus?> _hostBalanceRuleStatus = new(__typeInfos[7]);
    private TdfStruct<Blaze3SDK.Blaze.GameManager.HostViabilityRuleStatus?> _hostViabilityRuleStatus = new(__typeInfos[8]);
    private TdfStruct<Blaze3SDK.Blaze.GameManager.PingSiteRuleStatus?> _pingSiteRuleStatus = new(__typeInfos[9]);
    private TdfStruct<Blaze3SDK.Blaze.GameManager.RankRuleStatus?> _rankRuleStatus = new(__typeInfos[10]);
    private TdfMap<string, Blaze3SDK.Blaze.GameManager.SkillRuleStatus> _skillRuleStatusMap = new(__typeInfos[11]);
    private TdfStruct<Blaze3SDK.Blaze.GameManager.TeamSizeRuleStatus?> _teamSizeRuleStatus = new(__typeInfos[12]);
    private TdfMap<string, Blaze3SDK.Blaze.GameManager.UEDRuleStatus> _uEDRuleStatusMap = new(__typeInfos[13]);
    private TdfStruct<Blaze3SDK.Blaze.GameManager.VirtualGameRuleStatus?> _virtualGameRuleStatus = new(__typeInfos[14]);

    public MatchmakingAsyncStatus()
    {
        __members = [
            _createGameStatus,
            _customAsynStatus,
            _dNFRuleStatus,
            _findGameStatus,
            _geoLocationRuleStatus,
            _genericRuleStatusMap,
            _gameSizeRuleStatus,
            _hostBalanceRuleStatus,
            _hostViabilityRuleStatus,
            _pingSiteRuleStatus,
            _rankRuleStatus,
            _skillRuleStatusMap,
            _teamSizeRuleStatus,
            _uEDRuleStatusMap,
            _virtualGameRuleStatus,
        ];
    }

    public override Tdf CreateNew() => new MatchmakingAsyncStatus();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "MatchmakingAsyncStatus";
    public override string GetFullClassName() => "Blaze::GameManager::MatchmakingAsyncStatus";

    public Blaze3SDK.Blaze.GameManager.CreateGameStatus? CreateGameStatus
    {
        get => _createGameStatus.Value;
        set => _createGameStatus.Value = value;
    }

    public Blaze3SDK.Blaze.GameManager.MatchmakingCustomAsyncStatus? CustomAsynStatus
    {
        get => _customAsynStatus.Value;
        set => _customAsynStatus.Value = value;
    }

    public Blaze3SDK.Blaze.GameManager.DNFRuleStatus? DNFRuleStatus
    {
        get => _dNFRuleStatus.Value;
        set => _dNFRuleStatus.Value = value;
    }

    public Blaze3SDK.Blaze.GameManager.FindGameStatus? FindGameStatus
    {
        get => _findGameStatus.Value;
        set => _findGameStatus.Value = value;
    }

    public Blaze3SDK.Blaze.GameManager.GeoLocationRuleStatus? GeoLocationRuleStatus
    {
        get => _geoLocationRuleStatus.Value;
        set => _geoLocationRuleStatus.Value = value;
    }

    public IDictionary<string, Blaze3SDK.Blaze.GameManager.GenericRuleStatus> GenericRuleStatusMap
    {
        get => _genericRuleStatusMap.Value;
        set => _genericRuleStatusMap.Value = value;
    }

    public Blaze3SDK.Blaze.GameManager.GameSizeRuleStatus? GameSizeRuleStatus
    {
        get => _gameSizeRuleStatus.Value;
        set => _gameSizeRuleStatus.Value = value;
    }

    public Blaze3SDK.Blaze.GameManager.HostBalanceRuleStatus? HostBalanceRuleStatus
    {
        get => _hostBalanceRuleStatus.Value;
        set => _hostBalanceRuleStatus.Value = value;
    }

    public Blaze3SDK.Blaze.GameManager.HostViabilityRuleStatus? HostViabilityRuleStatus
    {
        get => _hostViabilityRuleStatus.Value;
        set => _hostViabilityRuleStatus.Value = value;
    }

    public Blaze3SDK.Blaze.GameManager.PingSiteRuleStatus? PingSiteRuleStatus
    {
        get => _pingSiteRuleStatus.Value;
        set => _pingSiteRuleStatus.Value = value;
    }

    public Blaze3SDK.Blaze.GameManager.RankRuleStatus? RankRuleStatus
    {
        get => _rankRuleStatus.Value;
        set => _rankRuleStatus.Value = value;
    }

    public IDictionary<string, Blaze3SDK.Blaze.GameManager.SkillRuleStatus> SkillRuleStatusMap
    {
        get => _skillRuleStatusMap.Value;
        set => _skillRuleStatusMap.Value = value;
    }

    public Blaze3SDK.Blaze.GameManager.TeamSizeRuleStatus? TeamSizeRuleStatus
    {
        get => _teamSizeRuleStatus.Value;
        set => _teamSizeRuleStatus.Value = value;
    }

    public IDictionary<string, Blaze3SDK.Blaze.GameManager.UEDRuleStatus> UEDRuleStatusMap
    {
        get => _uEDRuleStatusMap.Value;
        set => _uEDRuleStatusMap.Value = value;
    }

    public Blaze3SDK.Blaze.GameManager.VirtualGameRuleStatus? VirtualGameRuleStatus
    {
        get => _virtualGameRuleStatus.Value;
        set => _virtualGameRuleStatus.Value = value;
    }

}

