using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class StartMatchmakingRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameAttribs", "mGameAttribs", 0x874D3200, TdfType.Map, 0, true), // ATTR
        new TdfMemberInfo("GroupId", "mGroupId", 0x8B4C2C00, TdfType.ObjectId, 1, true), // BTPL
        new TdfMemberInfo("CriteriaData", "mCriteriaData", 0x8F2A7400, TdfType.Struct, 2, true), // CRIT
        new TdfMemberInfo("SessionDurationMS", "mSessionDurationMS", 0x935C8000, TdfType.UInt32, 3, true), // DUR
        new TdfMemberInfo("EntryCriteriaMap", "mEntryCriteriaMap", 0x963CA900, TdfType.Map, 4, true), // ECRI
        new TdfMemberInfo("GameEntryType", "mGameEntryType", 0x9E5BB400, TdfType.Enum, 5, true), // GENT
        new TdfMemberInfo("GameName", "mGameName", 0x9EE86D00, TdfType.String, 6, true), // GNAM
        new TdfMemberInfo("GameSettings", "mGameSettings", 0x9F397400, TdfType.Enum, 7, true), // GSET
        new TdfMemberInfo("GameProtocolVersionString", "mGameProtocolVersionString", 0x9F697200, TdfType.String, 8, true), // GVER
        new TdfMemberInfo("IgnoreEntryCriteriaWithInvite", "mIgnoreEntryCriteriaWithInvite", 0xA67BAF00, TdfType.Bool, 9, true), // IGNO
        new TdfMemberInfo("SessionMode", "mSessionMode", 0xB6F92500, TdfType.Enum, 10, true), // MODE
        new TdfMemberInfo("NetworkTopology", "mNetworkTopology", 0xBB4BF000, TdfType.Enum, 11, true), // NTOP
        new TdfMemberInfo("PlayerAttribs", "mPlayerAttribs", 0xC21D3400, TdfType.Map, 12, true), // PATT
        new TdfMemberInfo("PlayerIdList", "mPlayerIdList", 0xC2CCF400, TdfType.List, 13, true), // PLST
        new TdfMemberInfo("MaxPlayerCapacity", "mMaxPlayerCapacity", 0xC2D87800, TdfType.UInt16, 14, true), // PMAX
        new TdfMemberInfo("PlayerNetworkAddress", "mPlayerNetworkAddress", 0xC2E97400, TdfType.Union, 15, true), // PNET
        new TdfMemberInfo("QueueCapacity", "mQueueCapacity", 0xC6387000, TdfType.UInt16, 16, true), // QCAP
        new TdfMemberInfo("SessionIdList", "mSessionIdList", 0xCE992C00, TdfType.List, 17, true), // SIDL
        new TdfMemberInfo("VoipNetwork", "mVoipNetwork", 0xDAFA7000, TdfType.Enum, 18, true), // VOIP
    ];
    private ITdfMember[] __members;

    private TdfMap<string, string> _gameAttribs = new(__typeInfos[0]);
    private TdfObjectId _groupId = new(__typeInfos[1]);
    private TdfStruct<Blaze3SDK.Blaze.GameManager.MatchmakingCriteriaData?> _criteriaData = new(__typeInfos[2]);
    private TdfUInt32 _sessionDurationMS = new(__typeInfos[3]);
    private TdfMap<string, string> _entryCriteriaMap = new(__typeInfos[4]);
    private TdfEnum<Blaze3SDK.Blaze.GameManager.GameEntryType> _gameEntryType = new(__typeInfos[5]);
    private TdfString _gameName = new(__typeInfos[6]);
    private TdfEnum<Blaze3SDK.Blaze.GameManager.GameSettings> _gameSettings = new(__typeInfos[7]);
    private TdfString _gameProtocolVersionString = new(__typeInfos[8]);
    private TdfBool _ignoreEntryCriteriaWithInvite = new(__typeInfos[9]);
    private TdfEnum<Blaze3SDK.Blaze.GameManager.MatchmakingSessionMode> _sessionMode = new(__typeInfos[10]);
    private TdfEnum<Blaze3SDK.Blaze.GameNetworkTopology> _networkTopology = new(__typeInfos[11]);
    private TdfMap<string, string> _playerAttribs = new(__typeInfos[12]);
    private TdfList<long> _playerIdList = new(__typeInfos[13]);
    private TdfUInt16 _maxPlayerCapacity = new(__typeInfos[14]);
    private TdfUnion<Blaze3SDK.Blaze.NetworkAddress> _playerNetworkAddress = new(__typeInfos[15]);
    private TdfUInt16 _queueCapacity = new(__typeInfos[16]);
    private TdfList<uint> _sessionIdList = new(__typeInfos[17]);
    private TdfEnum<Blaze3SDK.Blaze.VoipTopology> _voipNetwork = new(__typeInfos[18]);

    public StartMatchmakingRequest()
    {
        __members = [
            _gameAttribs,
            _groupId,
            _criteriaData,
            _sessionDurationMS,
            _entryCriteriaMap,
            _gameEntryType,
            _gameName,
            _gameSettings,
            _gameProtocolVersionString,
            _ignoreEntryCriteriaWithInvite,
            _sessionMode,
            _networkTopology,
            _playerAttribs,
            _playerIdList,
            _maxPlayerCapacity,
            _playerNetworkAddress,
            _queueCapacity,
            _sessionIdList,
            _voipNetwork,
        ];
    }

    public override Tdf CreateNew() => new StartMatchmakingRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "StartMatchmakingRequest";
    public override string GetFullClassName() => "Blaze::GameManager::StartMatchmakingRequest";

    public IDictionary<string, string> GameAttribs
    {
        get => _gameAttribs.Value;
        set => _gameAttribs.Value = value;
    }

    public ObjectId GroupId
    {
        get => _groupId.Value;
        set => _groupId.Value = value;
    }

    public Blaze3SDK.Blaze.GameManager.MatchmakingCriteriaData? CriteriaData
    {
        get => _criteriaData.Value;
        set => _criteriaData.Value = value;
    }

    public uint SessionDurationMS
    {
        get => _sessionDurationMS.Value;
        set => _sessionDurationMS.Value = value;
    }

    public IDictionary<string, string> EntryCriteriaMap
    {
        get => _entryCriteriaMap.Value;
        set => _entryCriteriaMap.Value = value;
    }

    public Blaze3SDK.Blaze.GameManager.GameEntryType GameEntryType
    {
        get => _gameEntryType.Value;
        set => _gameEntryType.Value = value;
    }

    public string GameName
    {
        get => _gameName.Value;
        set => _gameName.Value = value;
    }

    public Blaze3SDK.Blaze.GameManager.GameSettings GameSettings
    {
        get => _gameSettings.Value;
        set => _gameSettings.Value = value;
    }

    public string GameProtocolVersionString
    {
        get => _gameProtocolVersionString.Value;
        set => _gameProtocolVersionString.Value = value;
    }

    public bool IgnoreEntryCriteriaWithInvite
    {
        get => _ignoreEntryCriteriaWithInvite.Value;
        set => _ignoreEntryCriteriaWithInvite.Value = value;
    }

    public Blaze3SDK.Blaze.GameManager.MatchmakingSessionMode SessionMode
    {
        get => _sessionMode.Value;
        set => _sessionMode.Value = value;
    }

    public Blaze3SDK.Blaze.GameNetworkTopology NetworkTopology
    {
        get => _networkTopology.Value;
        set => _networkTopology.Value = value;
    }

    public IDictionary<string, string> PlayerAttribs
    {
        get => _playerAttribs.Value;
        set => _playerAttribs.Value = value;
    }

    public IList<long> PlayerIdList
    {
        get => _playerIdList.Value;
        set => _playerIdList.Value = value;
    }

    public ushort MaxPlayerCapacity
    {
        get => _maxPlayerCapacity.Value;
        set => _maxPlayerCapacity.Value = value;
    }

    public Blaze3SDK.Blaze.NetworkAddress PlayerNetworkAddress
    {
        get => _playerNetworkAddress.Value;
        set => _playerNetworkAddress.Value = value;
    }

    public ushort QueueCapacity
    {
        get => _queueCapacity.Value;
        set => _queueCapacity.Value = value;
    }

    public IList<uint> SessionIdList
    {
        get => _sessionIdList.Value;
        set => _sessionIdList.Value = value;
    }

    public Blaze3SDK.Blaze.VoipTopology VoipNetwork
    {
        get => _voipNetwork.Value;
        set => _voipNetwork.Value = value;
    }

}

