using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class CreateGameRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AdminPlayerList", "mAdminPlayerList", 0x864B6E00, TdfType.List, 0, true), // ADMN
        new TdfMemberInfo("GameAttribs", "mGameAttribs", 0x874D3200, TdfType.Map, 1, true), // ATTR
        new TdfMemberInfo("GroupId", "mGroupId", 0x8B4C2C00, TdfType.UInt64, 2, true), // BTPL
        new TdfMemberInfo("EntryCriteriaMap", "mEntryCriteriaMap", 0x8F2A7400, TdfType.Map, 3, true), // CRIT
        new TdfMemberInfo("GamePingSiteAlias", "mGamePingSiteAlias", 0x9E3D3200, TdfType.String, 4, true), // GCTR
        new TdfMemberInfo("GameName", "mGameName", 0x9EE86D00, TdfType.String, 5, true), // GNAM
        new TdfMemberInfo("GameSettings", "mGameSettings", 0x9F397400, TdfType.Enum, 6, true), // GSET
        new TdfMemberInfo("GameStatusUrl", "mGameStatusUrl", 0x9F5CAC00, TdfType.String, 7, true), // GURL
        new TdfMemberInfo("GameProtocolVersion", "mGameProtocolVersion", 0x9F697200, TdfType.Int32, 8, true), // GVER
        new TdfMemberInfo("HostNetworkAddressList", "mHostNetworkAddressList", 0xA2E97400, TdfType.List, 9, true), // HNET
        new TdfMemberInfo("IgnoreEntryCriteriaWithInvite", "mIgnoreEntryCriteriaWithInvite", 0xA67BAF00, TdfType.Bool, 10, true), // IGNO
        new TdfMemberInfo("MeshAttribs", "mMeshAttribs", 0xB61D3200, TdfType.Map, 11, true), // MATR
        new TdfMemberInfo("NetworkTopology", "mNetworkTopology", 0xBB4BF000, TdfType.Enum, 12, true), // NTOP
        new TdfMemberInfo("HostPlayerAttribs", "mHostPlayerAttribs", 0xC21D3400, TdfType.Map, 13, true), // PATT
        new TdfMemberInfo("SlotCapacities", "mSlotCapacities", 0xC2387000, TdfType.List, 14, true), // PCAP
        new TdfMemberInfo("PersistedGameId", "mPersistedGameId", 0xC27A6400, TdfType.String, 15, true), // PGID
        new TdfMemberInfo("PersistedGameIdSecret", "mPersistedGameIdSecret", 0xC27CE300, TdfType.Blob, 16, true), // PGSC
        new TdfMemberInfo("MaxPlayerCapacity", "mMaxPlayerCapacity", 0xC2D87800, TdfType.UInt16, 17, true), // PMAX
        new TdfMemberInfo("QueueCapacity", "mQueueCapacity", 0xC6387000, TdfType.UInt16, 18, true), // QCAP
        new TdfMemberInfo("ReservedDynamicDSGameId", "mReservedDynamicDSGameId", 0xCA7A6400, TdfType.UInt32, 19, true), // RGID
        new TdfMemberInfo("ReservedPlayerSeats", "mReservedPlayerSeats", 0xCE587400, TdfType.List, 20, true), // SEAT
        new TdfMemberInfo("SessionIdList", "mSessionIdList", 0xCE992C00, TdfType.List, 21, true), // SIDL
        new TdfMemberInfo("JoiningSlotType", "mJoiningSlotType", 0xCECBF400, TdfType.Enum, 22, true), // SLOT
        new TdfMemberInfo("TeamCapacities", "mTeamCapacities", 0xD2387000, TdfType.List, 23, true), // TCAP
        new TdfMemberInfo("JoiningTeamId", "mJoiningTeamId", 0xD2586D00, TdfType.UInt16, 24, true), // TEAM
        new TdfMemberInfo("JoiningTeamIndex", "mJoiningTeamIndex", 0xD2993800, TdfType.UInt16, 25, true), // TIDX
        new TdfMemberInfo("VoipNetwork", "mVoipNetwork", 0xDAFA7000, TdfType.Enum, 26, true), // VOIP
        new TdfMemberInfo("GameProtocolVersionString", "mGameProtocolVersionString", 0xDB3D3200, TdfType.String, 27, true), // VSTR
    ];
    private ITdfMember[] __members;

    private TdfList<uint> _adminPlayerList = new(__typeInfos[0]);
    private TdfMap<string, string> _gameAttribs = new(__typeInfos[1]);
    private TdfUInt64 _groupId = new(__typeInfos[2]);
    private TdfMap<string, string> _entryCriteriaMap = new(__typeInfos[3]);
    private TdfString _gamePingSiteAlias = new(__typeInfos[4]);
    private TdfString _gameName = new(__typeInfos[5]);
    private TdfEnum<Blaze2SDK.Blaze.GameManager.GameSettings> _gameSettings = new(__typeInfos[6]);
    private TdfString _gameStatusUrl = new(__typeInfos[7]);
    private TdfInt32 _gameProtocolVersion = new(__typeInfos[8]);
    private TdfList<Blaze2SDK.Blaze.NetworkAddress> _hostNetworkAddressList = new(__typeInfos[9]);
    private TdfBool _ignoreEntryCriteriaWithInvite = new(__typeInfos[10]);
    private TdfMap<string, string> _meshAttribs = new(__typeInfos[11]);
    private TdfEnum<Blaze2SDK.Blaze.GameNetworkTopology> _networkTopology = new(__typeInfos[12]);
    private TdfMap<string, string> _hostPlayerAttribs = new(__typeInfos[13]);
    private TdfList<ushort> _slotCapacities = new(__typeInfos[14]);
    private TdfString _persistedGameId = new(__typeInfos[15]);
    private TdfBlob _persistedGameIdSecret = new(__typeInfos[16]);
    private TdfUInt16 _maxPlayerCapacity = new(__typeInfos[17]);
    private TdfUInt16 _queueCapacity = new(__typeInfos[18]);
    private TdfUInt32 _reservedDynamicDSGameId = new(__typeInfos[19]);
    private TdfList<uint> _reservedPlayerSeats = new(__typeInfos[20]);
    private TdfList<uint> _sessionIdList = new(__typeInfos[21]);
    private TdfEnum<Blaze2SDK.Blaze.GameManager.SlotType> _joiningSlotType = new(__typeInfos[22]);
    private TdfList<Blaze2SDK.Blaze.GameManager.TeamCapacity> _teamCapacities = new(__typeInfos[23]);
    private TdfUInt16 _joiningTeamId = new(__typeInfos[24]);
    private TdfUInt16 _joiningTeamIndex = new(__typeInfos[25]);
    private TdfEnum<Blaze2SDK.Blaze.VoipTopology> _voipNetwork = new(__typeInfos[26]);
    private TdfString _gameProtocolVersionString = new(__typeInfos[27]);

    public CreateGameRequest()
    {
        __members = [
            _adminPlayerList,
            _gameAttribs,
            _groupId,
            _entryCriteriaMap,
            _gamePingSiteAlias,
            _gameName,
            _gameSettings,
            _gameStatusUrl,
            _gameProtocolVersion,
            _hostNetworkAddressList,
            _ignoreEntryCriteriaWithInvite,
            _meshAttribs,
            _networkTopology,
            _hostPlayerAttribs,
            _slotCapacities,
            _persistedGameId,
            _persistedGameIdSecret,
            _maxPlayerCapacity,
            _queueCapacity,
            _reservedDynamicDSGameId,
            _reservedPlayerSeats,
            _sessionIdList,
            _joiningSlotType,
            _teamCapacities,
            _joiningTeamId,
            _joiningTeamIndex,
            _voipNetwork,
            _gameProtocolVersionString,
        ];
    }

    public override Tdf CreateNew() => new CreateGameRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "CreateGameRequest";
    public override string GetFullClassName() => "Blaze::GameManager::CreateGameRequest";

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

    public ulong GroupId
    {
        get => _groupId.Value;
        set => _groupId.Value = value;
    }

    public IDictionary<string, string> EntryCriteriaMap
    {
        get => _entryCriteriaMap.Value;
        set => _entryCriteriaMap.Value = value;
    }

    public string GamePingSiteAlias
    {
        get => _gamePingSiteAlias.Value;
        set => _gamePingSiteAlias.Value = value;
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

    public string GameStatusUrl
    {
        get => _gameStatusUrl.Value;
        set => _gameStatusUrl.Value = value;
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

    public Blaze2SDK.Blaze.GameNetworkTopology NetworkTopology
    {
        get => _networkTopology.Value;
        set => _networkTopology.Value = value;
    }

    public IDictionary<string, string> HostPlayerAttribs
    {
        get => _hostPlayerAttribs.Value;
        set => _hostPlayerAttribs.Value = value;
    }

    public IList<ushort> SlotCapacities
    {
        get => _slotCapacities.Value;
        set => _slotCapacities.Value = value;
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

    public ushort MaxPlayerCapacity
    {
        get => _maxPlayerCapacity.Value;
        set => _maxPlayerCapacity.Value = value;
    }

    public ushort QueueCapacity
    {
        get => _queueCapacity.Value;
        set => _queueCapacity.Value = value;
    }

    public uint ReservedDynamicDSGameId
    {
        get => _reservedDynamicDSGameId.Value;
        set => _reservedDynamicDSGameId.Value = value;
    }

    public IList<uint> ReservedPlayerSeats
    {
        get => _reservedPlayerSeats.Value;
        set => _reservedPlayerSeats.Value = value;
    }

    public IList<uint> SessionIdList
    {
        get => _sessionIdList.Value;
        set => _sessionIdList.Value = value;
    }

    public Blaze2SDK.Blaze.GameManager.SlotType JoiningSlotType
    {
        get => _joiningSlotType.Value;
        set => _joiningSlotType.Value = value;
    }

    public IList<Blaze2SDK.Blaze.GameManager.TeamCapacity> TeamCapacities
    {
        get => _teamCapacities.Value;
        set => _teamCapacities.Value = value;
    }

    public ushort JoiningTeamId
    {
        get => _joiningTeamId.Value;
        set => _joiningTeamId.Value = value;
    }

    public ushort JoiningTeamIndex
    {
        get => _joiningTeamIndex.Value;
        set => _joiningTeamIndex.Value = value;
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

}

