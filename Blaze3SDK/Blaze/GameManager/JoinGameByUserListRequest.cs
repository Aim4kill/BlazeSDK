using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class JoinGameByUserListRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("PlayerAttribs", "mPlayerAttribs", 0x874D3200, TdfType.Map, 0, true), // ATTR
        new TdfMemberInfo("GameEntryType", "mGameEntryType", 0x9E5BB400, TdfType.Enum, 1, true), // GENT
        new TdfMemberInfo("GameId", "mGameId", 0x9E990000, TdfType.UInt32, 2, true), // GID
        new TdfMemberInfo("GameProtocolVersionString", "mGameProtocolVersionString", 0x9F697200, TdfType.String, 3, true), // GVER
        new TdfMemberInfo("JoinMethod", "mJoinMethod", 0xAAD97400, TdfType.Enum, 4, true), // JMET
        new TdfMemberInfo("PlayerIdList", "mPlayerIdList", 0xC2CCF400, TdfType.List, 5, true), // PLST
        new TdfMemberInfo("PlayerNetworkAddress", "mPlayerNetworkAddress", 0xC2E97400, TdfType.Union, 6, true), // PNET
        new TdfMemberInfo("RequestedSlotType", "mRequestedSlotType", 0xCECBF400, TdfType.Enum, 7, true), // SLOT
        new TdfMemberInfo("JoiningTeamIndex", "mJoiningTeamIndex", 0xD2993800, TdfType.UInt16, 8, true), // TIDX
    ];
    private ITdfMember[] __members;

    private TdfMap<string, string> _playerAttribs = new(__typeInfos[0]);
    private TdfEnum<Blaze3SDK.Blaze.GameManager.GameEntryType> _gameEntryType = new(__typeInfos[1]);
    private TdfUInt32 _gameId = new(__typeInfos[2]);
    private TdfString _gameProtocolVersionString = new(__typeInfos[3]);
    private TdfEnum<Blaze3SDK.Blaze.GameManager.JoinMethod> _joinMethod = new(__typeInfos[4]);
    private TdfList<long> _playerIdList = new(__typeInfos[5]);
    private TdfUnion<Blaze3SDK.Blaze.NetworkAddress> _playerNetworkAddress = new(__typeInfos[6]);
    private TdfEnum<Blaze3SDK.Blaze.GameManager.SlotType> _requestedSlotType = new(__typeInfos[7]);
    private TdfUInt16 _joiningTeamIndex = new(__typeInfos[8]);

    public JoinGameByUserListRequest()
    {
        __members = [
            _playerAttribs,
            _gameEntryType,
            _gameId,
            _gameProtocolVersionString,
            _joinMethod,
            _playerIdList,
            _playerNetworkAddress,
            _requestedSlotType,
            _joiningTeamIndex,
        ];
    }

    public override Tdf CreateNew() => new JoinGameByUserListRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "JoinGameByUserListRequest";
    public override string GetFullClassName() => "Blaze::GameManager::JoinGameByUserListRequest";

    public IDictionary<string, string> PlayerAttribs
    {
        get => _playerAttribs.Value;
        set => _playerAttribs.Value = value;
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

    public IList<long> PlayerIdList
    {
        get => _playerIdList.Value;
        set => _playerIdList.Value = value;
    }

    public Blaze3SDK.Blaze.NetworkAddress PlayerNetworkAddress
    {
        get => _playerNetworkAddress.Value;
        set => _playerNetworkAddress.Value = value;
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

}

