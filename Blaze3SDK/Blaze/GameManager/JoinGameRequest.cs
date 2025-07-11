using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class JoinGameRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("PlayerAttribs", "mPlayerAttribs", 0x874D3200, TdfType.Map, 0, true), // ATTR
        new TdfMemberInfo("GroupId", "mGroupId", 0x8B4C2C00, TdfType.ObjectId, 1, true), // BTPL
        new TdfMemberInfo("GameEntryType", "mGameEntryType", 0x9E5BB400, TdfType.Enum, 2, true), // GENT
        new TdfMemberInfo("GameId", "mGameId", 0x9E990000, TdfType.UInt32, 3, true), // GID
        new TdfMemberInfo("GameProtocolVersionString", "mGameProtocolVersionString", 0x9F697200, TdfType.String, 4, true), // GVER
        new TdfMemberInfo("JoinMethod", "mJoinMethod", 0xAAD97400, TdfType.Enum, 5, true), // JMET
        new TdfMemberInfo("AdditionalPlayerIdList", "mAdditionalPlayerIdList", 0xC2CCF400, TdfType.List, 6, true), // PLST
        new TdfMemberInfo("PlayerNetworkAddress", "mPlayerNetworkAddress", 0xC2E97400, TdfType.Union, 7, true), // PNET
        new TdfMemberInfo("RequestedSlotId", "mRequestedSlotId", 0xCECA6400, TdfType.UInt8, 8, true), // SLID
        new TdfMemberInfo("RequestedSlotType", "mRequestedSlotType", 0xCECBF400, TdfType.Enum, 9, true), // SLOT
        new TdfMemberInfo("JoiningTeamIndex", "mJoiningTeamIndex", 0xD2993800, TdfType.UInt16, 10, true), // TIDX
        new TdfMemberInfo("User", "mUser", 0xD7397200, TdfType.Struct, 11, true), // USER
    ];
    private ITdfMember[] __members;

    private TdfMap<string, string> _playerAttribs = new(__typeInfos[0]);
    private TdfObjectId _groupId = new(__typeInfos[1]);
    private TdfEnum<Blaze3SDK.Blaze.GameManager.GameEntryType> _gameEntryType = new(__typeInfos[2]);
    private TdfUInt32 _gameId = new(__typeInfos[3]);
    private TdfString _gameProtocolVersionString = new(__typeInfos[4]);
    private TdfEnum<Blaze3SDK.Blaze.GameManager.JoinMethod> _joinMethod = new(__typeInfos[5]);
    private TdfList<long> _additionalPlayerIdList = new(__typeInfos[6]);
    private TdfUnion<Blaze3SDK.Blaze.NetworkAddress> _playerNetworkAddress = new(__typeInfos[7]);
    private TdfUInt8 _requestedSlotId = new(__typeInfos[8]);
    private TdfEnum<Blaze3SDK.Blaze.GameManager.SlotType> _requestedSlotType = new(__typeInfos[9]);
    private TdfUInt16 _joiningTeamIndex = new(__typeInfos[10]);
    private TdfStruct<Blaze3SDK.Blaze.UserIdentification?> _user = new(__typeInfos[11]);

    public JoinGameRequest()
    {
        __members = [
            _playerAttribs,
            _groupId,
            _gameEntryType,
            _gameId,
            _gameProtocolVersionString,
            _joinMethod,
            _additionalPlayerIdList,
            _playerNetworkAddress,
            _requestedSlotId,
            _requestedSlotType,
            _joiningTeamIndex,
            _user,
        ];
    }

    public override Tdf CreateNew() => new JoinGameRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "JoinGameRequest";
    public override string GetFullClassName() => "Blaze::GameManager::JoinGameRequest";

    public IDictionary<string, string> PlayerAttribs
    {
        get => _playerAttribs.Value;
        set => _playerAttribs.Value = value;
    }

    public ObjectId GroupId
    {
        get => _groupId.Value;
        set => _groupId.Value = value;
    }

    public Blaze3SDK.Blaze.GameManager.GameEntryType GameEntryType
    {
        get => _gameEntryType.Value;
        set => _gameEntryType.Value = value;
    }

    public uint GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public string GameProtocolVersionString
    {
        get => _gameProtocolVersionString.Value;
        set => _gameProtocolVersionString.Value = value;
    }

    public Blaze3SDK.Blaze.GameManager.JoinMethod JoinMethod
    {
        get => _joinMethod.Value;
        set => _joinMethod.Value = value;
    }

    public IList<long> AdditionalPlayerIdList
    {
        get => _additionalPlayerIdList.Value;
        set => _additionalPlayerIdList.Value = value;
    }

    public Blaze3SDK.Blaze.NetworkAddress PlayerNetworkAddress
    {
        get => _playerNetworkAddress.Value;
        set => _playerNetworkAddress.Value = value;
    }

    public byte RequestedSlotId
    {
        get => _requestedSlotId.Value;
        set => _requestedSlotId.Value = value;
    }

    public Blaze3SDK.Blaze.GameManager.SlotType RequestedSlotType
    {
        get => _requestedSlotType.Value;
        set => _requestedSlotType.Value = value;
    }

    public ushort JoiningTeamIndex
    {
        get => _joiningTeamIndex.Value;
        set => _joiningTeamIndex.Value = value;
    }

    public Blaze3SDK.Blaze.UserIdentification? User
    {
        get => _user.Value;
        set => _user.Value = value;
    }

}

