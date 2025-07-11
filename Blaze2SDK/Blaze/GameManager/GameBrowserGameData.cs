using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class GameBrowserGameData : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AdminPlayerList", "mAdminPlayerList", 0x864B6E00, TdfType.List, 0, true), // ADMN
        new TdfMemberInfo("GameAttribs", "mGameAttribs", 0x874D3200, TdfType.Map, 1, true), // ATTR
        new TdfMemberInfo("SlotCapacities", "mSlotCapacities", 0x8E1C0000, TdfType.List, 2, true), // CAP
        new TdfMemberInfo("EntryCriteriaMap", "mEntryCriteriaMap", 0x8F2A7400, TdfType.Map, 3, true), // CRIT
        new TdfMemberInfo("FitScore", "mFitScore", 0x9A9D0000, TdfType.UInt32, 4, true), // FIT
        new TdfMemberInfo("GameId", "mGameId", 0x9E990000, TdfType.UInt32, 5, true), // GID
        new TdfMemberInfo("GameName", "mGameName", 0x9EE86D00, TdfType.String, 6, true), // GNAM
        new TdfMemberInfo("GameSettings", "mGameSettings", 0x9F397400, TdfType.Enum, 7, true), // GSET
        new TdfMemberInfo("GameState", "mGameState", 0x9F3D2100, TdfType.Enum, 8, true), // GSTA
        new TdfMemberInfo("GameProtocolVersion", "mGameProtocolVersion", 0x9F697200, TdfType.Int32, 9, true), // GVER
        new TdfMemberInfo("HostNetworkAddressList", "mHostNetworkAddressList", 0xA2E97400, TdfType.List, 10, true), // HNET
        new TdfMemberInfo("HostId", "mHostId", 0xA2FCF400, TdfType.UInt32, 11, true), // HOST
        new TdfMemberInfo("PlayerCounts", "mPlayerCounts", 0xC23BB400, TdfType.List, 12, true), // PCNT
        new TdfMemberInfo("PersistedGameId", "mPersistedGameId", 0xC33A6400, TdfType.String, 13, true), // PSID
        new TdfMemberInfo("QueueCapacity", "mQueueCapacity", 0xC6387000, TdfType.UInt16, 14, true), // QCAP
        new TdfMemberInfo("QueueCount", "mQueueCount", 0xC63BB400, TdfType.UInt16, 15, true), // QCNT
        new TdfMemberInfo("GameRoster", "mGameRoster", 0xCAFCF400, TdfType.List, 16, true), // ROST
        new TdfMemberInfo("ExternalSessionId", "mExternalSessionId", 0xCE990000, TdfType.UInt64, 17, true), // SID
        new TdfMemberInfo("GameBrowserTeamInfoVector", "mGameBrowserTeamInfoVector", 0xD29BA600, TdfType.List, 18, true), // TINF
        new TdfMemberInfo("VoipTopology", "mVoipTopology", 0xDAFA7000, TdfType.Enum, 19, true), // VOIP
        new TdfMemberInfo("GameProtocolVersionString", "mGameProtocolVersionString", 0xDB3D3200, TdfType.String, 20, true), // VSTR
    ];
    private ITdfMember[] __members;

    private TdfList<uint> _adminPlayerList = new(__typeInfos[0]);
    private TdfMap<string, string> _gameAttribs = new(__typeInfos[1]);
    private TdfList<ushort> _slotCapacities = new(__typeInfos[2]);
    private TdfMap<string, string> _entryCriteriaMap = new(__typeInfos[3]);
    private TdfUInt32 _fitScore = new(__typeInfos[4]);
    private TdfUInt32 _gameId = new(__typeInfos[5]);
    private TdfString _gameName = new(__typeInfos[6]);
    private TdfEnum<Blaze2SDK.Blaze.GameManager.GameSettings> _gameSettings = new(__typeInfos[7]);
    private TdfEnum<Blaze2SDK.Blaze.GameManager.GameState> _gameState = new(__typeInfos[8]);
    private TdfInt32 _gameProtocolVersion = new(__typeInfos[9]);
    private TdfList<Blaze2SDK.Blaze.NetworkAddress> _hostNetworkAddressList = new(__typeInfos[10]);
    private TdfUInt32 _hostId = new(__typeInfos[11]);
    private TdfList<ushort> _playerCounts = new(__typeInfos[12]);
    private TdfString _persistedGameId = new(__typeInfos[13]);
    private TdfUInt16 _queueCapacity = new(__typeInfos[14]);
    private TdfUInt16 _queueCount = new(__typeInfos[15]);
    private TdfList<Blaze2SDK.Blaze.GameManager.GameBrowserPlayerData> _gameRoster = new(__typeInfos[16]);
    private TdfUInt64 _externalSessionId = new(__typeInfos[17]);
    private TdfList<Blaze2SDK.Blaze.GameManager.GameBrowserTeamInfo> _gameBrowserTeamInfoVector = new(__typeInfos[18]);
    private TdfEnum<Blaze2SDK.Blaze.VoipTopology> _voipTopology = new(__typeInfos[19]);
    private TdfString _gameProtocolVersionString = new(__typeInfos[20]);

    public GameBrowserGameData()
    {
        __members = [
            _adminPlayerList,
            _gameAttribs,
            _slotCapacities,
            _entryCriteriaMap,
            _fitScore,
            _gameId,
            _gameName,
            _gameSettings,
            _gameState,
            _gameProtocolVersion,
            _hostNetworkAddressList,
            _hostId,
            _playerCounts,
            _persistedGameId,
            _queueCapacity,
            _queueCount,
            _gameRoster,
            _externalSessionId,
            _gameBrowserTeamInfoVector,
            _voipTopology,
            _gameProtocolVersionString,
        ];
    }

    public override Tdf CreateNew() => new GameBrowserGameData();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GameBrowserGameData";
    public override string GetFullClassName() => "Blaze::GameManager::GameBrowserGameData";

    public IList<uint> AdminPlayerList
    {
        get => _adminPlayerList.Value;
        set => _adminPlayerList.Value = value;
    }

    public IDictionary<string, string> GameAttribs
    {
        get => _gameAttribs.Value;
        set => _gameAttribs.Value = value;
    }

    public IList<ushort> SlotCapacities
    {
        get => _slotCapacities.Value;
        set => _slotCapacities.Value = value;
    }

    public IDictionary<string, string> EntryCriteriaMap
    {
        get => _entryCriteriaMap.Value;
        set => _entryCriteriaMap.Value = value;
    }

    public uint FitScore
    {
        get => _fitScore.Value;
        set => _fitScore.Value = value;
    }

    public uint GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public string GameName
    {
        get => _gameName.Value;
        set => _gameName.Value = value;
    }

    public Blaze2SDK.Blaze.GameManager.GameSettings GameSettings
    {
        get => _gameSettings.Value;
        set => _gameSettings.Value = value;
    }

    public Blaze2SDK.Blaze.GameManager.GameState GameState
    {
        get => _gameState.Value;
        set => _gameState.Value = value;
    }

    public int GameProtocolVersion
    {
        get => _gameProtocolVersion.Value;
        set => _gameProtocolVersion.Value = value;
    }

    public IList<Blaze2SDK.Blaze.NetworkAddress> HostNetworkAddressList
    {
        get => _hostNetworkAddressList.Value;
        set => _hostNetworkAddressList.Value = value;
    }

    public uint HostId
    {
        get => _hostId.Value;
        set => _hostId.Value = value;
    }

    public IList<ushort> PlayerCounts
    {
        get => _playerCounts.Value;
        set => _playerCounts.Value = value;
    }

    public string PersistedGameId
    {
        get => _persistedGameId.Value;
        set => _persistedGameId.Value = value;
    }

    public ushort QueueCapacity
    {
        get => _queueCapacity.Value;
        set => _queueCapacity.Value = value;
    }

    public ushort QueueCount
    {
        get => _queueCount.Value;
        set => _queueCount.Value = value;
    }

    public IList<Blaze2SDK.Blaze.GameManager.GameBrowserPlayerData> GameRoster
    {
        get => _gameRoster.Value;
        set => _gameRoster.Value = value;
    }

    public ulong ExternalSessionId
    {
        get => _externalSessionId.Value;
        set => _externalSessionId.Value = value;
    }

    public IList<Blaze2SDK.Blaze.GameManager.GameBrowserTeamInfo> GameBrowserTeamInfoVector
    {
        get => _gameBrowserTeamInfoVector.Value;
        set => _gameBrowserTeamInfoVector.Value = value;
    }

    public Blaze2SDK.Blaze.VoipTopology VoipTopology
    {
        get => _voipTopology.Value;
        set => _voipTopology.Value = value;
    }

    public string GameProtocolVersionString
    {
        get => _gameProtocolVersionString.Value;
        set => _gameProtocolVersionString.Value = value;
    }

}

