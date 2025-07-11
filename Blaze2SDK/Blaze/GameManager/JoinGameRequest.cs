using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class JoinGameRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("PlayerAttribs", "mPlayerAttribs", 0x874D3200, TdfType.Map, 0, true), // ATTR
        new TdfMemberInfo("GroupId", "mGroupId", 0x8B4C2C00, TdfType.UInt64, 1, true), // BTPL
        new TdfMemberInfo("GameId", "mGameId", 0x9E990000, TdfType.UInt32, 2, true), // GID
        new TdfMemberInfo("GameProtocolVersionString", "mGameProtocolVersionString", 0x9F697200, TdfType.String, 3, true), // GVER
        new TdfMemberInfo("JoinMethod", "mJoinMethod", 0xAAD97400, TdfType.Enum, 4, true), // JMET
        new TdfMemberInfo("PlayerNetworkAddress", "mPlayerNetworkAddress", 0xC2E97400, TdfType.Union, 5, true), // PNET
        new TdfMemberInfo("RequestedSlotType", "mRequestedSlotType", 0xCECBF400, TdfType.Enum, 6, true), // SLOT
        new TdfMemberInfo("JoiningTeamId", "mJoiningTeamId", 0xD2586D00, TdfType.UInt16, 7, true), // TEAM
        new TdfMemberInfo("JoiningTeamIndex", "mJoiningTeamIndex", 0xD2993800, TdfType.UInt16, 8, true), // TIDX
        new TdfMemberInfo("User", "mUser", 0xD7397200, TdfType.Struct, 9, true), // USER
    ];
    private ITdfMember[] __members;

    private TdfMap<string, string> _playerAttribs = new(__typeInfos[0]);
    private TdfUInt64 _groupId = new(__typeInfos[1]);
    private TdfUInt32 _gameId = new(__typeInfos[2]);
    private TdfString _gameProtocolVersionString = new(__typeInfos[3]);
    private TdfEnum<Blaze2SDK.Blaze.GameManager.JoinMethod> _joinMethod = new(__typeInfos[4]);
    private TdfUnion<Blaze2SDK.Blaze.NetworkAddress> _playerNetworkAddress = new(__typeInfos[5]);
    private TdfEnum<Blaze2SDK.Blaze.GameManager.SlotType> _requestedSlotType = new(__typeInfos[6]);
    private TdfUInt16 _joiningTeamId = new(__typeInfos[7]);
    private TdfUInt16 _joiningTeamIndex = new(__typeInfos[8]);
    private TdfStruct<Blaze2SDK.Blaze.UserIdentification?> _user = new(__typeInfos[9]);

    public JoinGameRequest()
    {
        __members = [
            _playerAttribs,
            _groupId,
            _gameId,
            _gameProtocolVersionString,
            _joinMethod,
            _playerNetworkAddress,
            _requestedSlotType,
            _joiningTeamId,
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

    public ulong GroupId
    {
        get => _groupId.Value;
        set => _groupId.Value = value;
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

    public Blaze2SDK.Blaze.GameManager.JoinMethod JoinMethod
    {
        get => _joinMethod.Value;
        set => _joinMethod.Value = value;
    }

    public Blaze2SDK.Blaze.NetworkAddress PlayerNetworkAddress
    {
        get => _playerNetworkAddress.Value;
        set => _playerNetworkAddress.Value = value;
    }

    public Blaze2SDK.Blaze.GameManager.SlotType RequestedSlotType
    {
        get => _requestedSlotType.Value;
        set => _requestedSlotType.Value = value;
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

    public Blaze2SDK.Blaze.UserIdentification? User
    {
        get => _user.Value;
        set => _user.Value = value;
    }

}

