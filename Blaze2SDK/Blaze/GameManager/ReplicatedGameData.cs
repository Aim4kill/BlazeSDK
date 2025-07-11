using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class ReplicatedGameData : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AdminPlayerList", "mAdminPlayerList", 0x864B6E00, TdfType.List, 0, true), // ADMN
        new TdfMemberInfo("GameAttribs", "mGameAttribs", 0x874D3200, TdfType.Map, 1, true), // ATTR
        new TdfMemberInfo("SlotCapacities", "mSlotCapacities", 0x8E1C0000, TdfType.List, 2, true), // CAP
        new TdfMemberInfo("EntryCriteriaMap", "mEntryCriteriaMap", 0x8F2A7400, TdfType.Map, 3, true), // CRIT
        new TdfMemberInfo("GameId", "mGameId", 0x9E990000, TdfType.UInt32, 4, true), // GID
        new TdfMemberInfo("GameName", "mGameName", 0x9EE86D00, TdfType.String, 5, true), // GNAM
        new TdfMemberInfo("GameProtocolVersionHash", "mGameProtocolVersionHash", 0x9F0DA800, TdfType.UInt64, 6, true), // GPVH
        new TdfMemberInfo("GameSettings", "mGameSettings", 0x9F397400, TdfType.Enum, 7, true), // GSET
        new TdfMemberInfo("GameReportingId", "mGameReportingId", 0x9F3A6400, TdfType.UInt32, 8, true), // GSID
        new TdfMemberInfo("GameState", "mGameState", 0x9F3D2100, TdfType.Enum, 9, true), // GSTA
        new TdfMemberInfo("GameProtocolVersion", "mGameProtocolVersion", 0x9F697200, TdfType.Int32, 10, true), // GVER
        new TdfMemberInfo("HostNetworkAddressList", "mHostNetworkAddressList", 0xA2E97400, TdfType.List, 11, true), // HNET
        new TdfMemberInfo("TopologyHostSessionId", "mTopologyHostSessionId", 0xA3397300, TdfType.UInt32, 12, true), // HSES
        new TdfMemberInfo("IgnoreEntryCriteriaWithInvite", "mIgnoreEntryCriteriaWithInvite", 0xA67BAF00, TdfType.Bool, 13, true), // IGNO
        new TdfMemberInfo("MeshAttribs", "mMeshAttribs", 0xB61D3200, TdfType.Map, 14, true), // MATR
        new TdfMemberInfo("MaxPlayerCapacity", "mMaxPlayerCapacity", 0xB6387000, TdfType.UInt16, 15, true), // MCAP
        new TdfMemberInfo("NetworkQosData", "mNetworkQosData", 0xBB1BF300, TdfType.Struct, 16, true), // NQOS
        new TdfMemberInfo("NetworkTopology", "mNetworkTopology", 0xBB4BF000, TdfType.Enum, 17, true), // NTOP
        new TdfMemberInfo("PersistedGameId", "mPersistedGameId", 0xC27A6400, TdfType.String, 18, true), // PGID
        new TdfMemberInfo("PersistedGameIdSecret", "mPersistedGameIdSecret", 0xC27CF200, TdfType.Blob, 19, true), // PGSR
        new TdfMemberInfo("PlatformHostInfo", "mPlatformHostInfo", 0xC28CF400, TdfType.Struct, 20, true), // PHST
        new TdfMemberInfo("PingSiteAlias", "mPingSiteAlias", 0xC3387300, TdfType.String, 21, true), // PSAS
        new TdfMemberInfo("QueueCapacity", "mQueueCapacity", 0xC6387000, TdfType.UInt16, 22, true), // QCAP
        new TdfMemberInfo("SharedSeed", "mSharedSeed", 0xCE596400, TdfType.UInt32, 23, true), // SEED
        new TdfMemberInfo("TeamCapacities", "mTeamCapacities", 0xD2387000, TdfType.List, 24, true), // TCAP
        new TdfMemberInfo("TopologyHostInfo", "mTopologyHostInfo", 0xD28CF400, TdfType.Struct, 25, true), // THST
        new TdfMemberInfo("UUID", "mUUID", 0xD75A6400, TdfType.String, 26, true), // UUID
        new TdfMemberInfo("VoipNetwork", "mVoipNetwork", 0xDAFA7000, TdfType.Enum, 27, true), // VOIP
        new TdfMemberInfo("GameProtocolVersionString", "mGameProtocolVersionString", 0xDB3D3200, TdfType.String, 28, true), // VSTR
        new TdfMemberInfo("XnetNonce", "mXnetNonce", 0xE2EBA300, TdfType.Blob, 29, true), // XNNC
        new TdfMemberInfo("XnetSession", "mXnetSession", 0xE3397300, TdfType.Blob, 30, true), // XSES
    ];
    private ITdfMember[] __members;

    private TdfList<uint> _adminPlayerList = new(__typeInfos[0]);
    private TdfMap<string, string> _gameAttribs = new(__typeInfos[1]);
    private TdfList<ushort> _slotCapacities = new(__typeInfos[2]);
    private TdfMap<string, string> _entryCriteriaMap = new(__typeInfos[3]);
    private TdfUInt32 _gameId = new(__typeInfos[4]);
    private TdfString _gameName = new(__typeInfos[5]);
    private TdfUInt64 _gameProtocolVersionHash = new(__typeInfos[6]);
    private TdfEnum<Blaze2SDK.Blaze.GameManager.GameSettings> _gameSettings = new(__typeInfos[7]);
    private TdfUInt32 _gameReportingId = new(__typeInfos[8]);
    private TdfEnum<Blaze2SDK.Blaze.GameManager.GameState> _gameState = new(__typeInfos[9]);
    private TdfInt32 _gameProtocolVersion = new(__typeInfos[10]);
    private TdfList<Blaze2SDK.Blaze.NetworkAddress> _hostNetworkAddressList = new(__typeInfos[11]);
    private TdfUInt32 _topologyHostSessionId = new(__typeInfos[12]);
    private TdfBool _ignoreEntryCriteriaWithInvite = new(__typeInfos[13]);
    private TdfMap<string, string> _meshAttribs = new(__typeInfos[14]);
    private TdfUInt16 _maxPlayerCapacity = new(__typeInfos[15]);
    private TdfStruct<Blaze2SDK.Blaze.Util.NetworkQosData?> _networkQosData = new(__typeInfos[16]);
    private TdfEnum<Blaze2SDK.Blaze.GameNetworkTopology> _networkTopology = new(__typeInfos[17]);
    private TdfString _persistedGameId = new(__typeInfos[18]);
    private TdfBlob _persistedGameIdSecret = new(__typeInfos[19]);
    private TdfStruct<Blaze2SDK.Blaze.GameManager.HostInfo?> _platformHostInfo = new(__typeInfos[20]);
    private TdfString _pingSiteAlias = new(__typeInfos[21]);
    private TdfUInt16 _queueCapacity = new(__typeInfos[22]);
    private TdfUInt32 _sharedSeed = new(__typeInfos[23]);
    private TdfList<Blaze2SDK.Blaze.GameManager.TeamCapacity> _teamCapacities = new(__typeInfos[24]);
    private TdfStruct<Blaze2SDK.Blaze.GameManager.HostInfo?> _topologyHostInfo = new(__typeInfos[25]);
    private TdfString _uUID = new(__typeInfos[26]);
    private TdfEnum<Blaze2SDK.Blaze.VoipTopology> _voipNetwork = new(__typeInfos[27]);
    private TdfString _gameProtocolVersionString = new(__typeInfos[28]);
    private TdfBlob _xnetNonce = new(__typeInfos[29]);
    private TdfBlob _xnetSession = new(__typeInfos[30]);

    public ReplicatedGameData()
    {
        __members = [
            _adminPlayerList,
            _gameAttribs,
            _slotCapacities,
            _entryCriteriaMap,
            _gameId,
            _gameName,
            _gameProtocolVersionHash,
            _gameSettings,
            _gameReportingId,
            _gameState,
            _gameProtocolVersion,
            _hostNetworkAddressList,
            _topologyHostSessionId,
            _ignoreEntryCriteriaWithInvite,
            _meshAttribs,
            _maxPlayerCapacity,
            _networkQosData,
            _networkTopology,
            _persistedGameId,
            _persistedGameIdSecret,
            _platformHostInfo,
            _pingSiteAlias,
            _queueCapacity,
            _sharedSeed,
            _teamCapacities,
            _topologyHostInfo,
            _uUID,
            _voipNetwork,
            _gameProtocolVersionString,
            _xnetNonce,
            _xnetSession,
        ];
    }

    public override Tdf CreateNew() => new ReplicatedGameData();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ReplicatedGameData";
    public override string GetFullClassName() => "Blaze::GameManager::ReplicatedGameData";

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

    public ulong GameProtocolVersionHash
    {
        get => _gameProtocolVersionHash.Value;
        set => _gameProtocolVersionHash.Value = value;
    }

    public Blaze2SDK.Blaze.GameManager.GameSettings GameSettings
    {
        get => _gameSettings.Value;
        set => _gameSettings.Value = value;
    }

    public uint GameReportingId
    {
        get => _gameReportingId.Value;
        set => _gameReportingId.Value = value;
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

    public uint TopologyHostSessionId
    {
        get => _topologyHostSessionId.Value;
        set => _topologyHostSessionId.Value = value;
    }

    public bool IgnoreEntryCriteriaWithInvite
    {
        get => _ignoreEntryCriteriaWithInvite.Value;
        set => _ignoreEntryCriteriaWithInvite.Value = value;
    }

    public IDictionary<string, string> MeshAttribs
    {
        get => _meshAttribs.Value;
        set => _meshAttribs.Value = value;
    }

    public ushort MaxPlayerCapacity
    {
        get => _maxPlayerCapacity.Value;
        set => _maxPlayerCapacity.Value = value;
    }

    public Blaze2SDK.Blaze.Util.NetworkQosData? NetworkQosData
    {
        get => _networkQosData.Value;
        set => _networkQosData.Value = value;
    }

    public Blaze2SDK.Blaze.GameNetworkTopology NetworkTopology
    {
        get => _networkTopology.Value;
        set => _networkTopology.Value = value;
    }

    public string PersistedGameId
    {
        get => _persistedGameId.Value;
        set => _persistedGameId.Value = value;
    }

    public byte[] PersistedGameIdSecret
    {
        get => _persistedGameIdSecret.Value;
        set => _persistedGameIdSecret.Value = value;
    }

    public Blaze2SDK.Blaze.GameManager.HostInfo? PlatformHostInfo
    {
        get => _platformHostInfo.Value;
        set => _platformHostInfo.Value = value;
    }

    public string PingSiteAlias
    {
        get => _pingSiteAlias.Value;
        set => _pingSiteAlias.Value = value;
    }

    public ushort QueueCapacity
    {
        get => _queueCapacity.Value;
        set => _queueCapacity.Value = value;
    }

    public uint SharedSeed
    {
        get => _sharedSeed.Value;
        set => _sharedSeed.Value = value;
    }

    public IList<Blaze2SDK.Blaze.GameManager.TeamCapacity> TeamCapacities
    {
        get => _teamCapacities.Value;
        set => _teamCapacities.Value = value;
    }

    public Blaze2SDK.Blaze.GameManager.HostInfo? TopologyHostInfo
    {
        get => _topologyHostInfo.Value;
        set => _topologyHostInfo.Value = value;
    }

    public string UUID
    {
        get => _uUID.Value;
        set => _uUID.Value = value;
    }

    public Blaze2SDK.Blaze.VoipTopology VoipNetwork
    {
        get => _voipNetwork.Value;
        set => _voipNetwork.Value = value;
    }

    public string GameProtocolVersionString
    {
        get => _gameProtocolVersionString.Value;
        set => _gameProtocolVersionString.Value = value;
    }

    public byte[] XnetNonce
    {
        get => _xnetNonce.Value;
        set => _xnetNonce.Value = value;
    }

    public byte[] XnetSession
    {
        get => _xnetSession.Value;
        set => _xnetSession.Value = value;
    }

}

