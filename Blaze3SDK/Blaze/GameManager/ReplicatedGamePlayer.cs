using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class ReplicatedGamePlayer : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CustomData", "mCustomData", 0x8ACBE200, TdfType.Blob, 0, true), // BLOB
        new TdfMemberInfo("ExternalId", "mExternalId", 0x978A6400, TdfType.UInt64, 1, true), // EXID
        new TdfMemberInfo("GameId", "mGameId", 0x9E990000, TdfType.UInt32, 2, true), // GID
        new TdfMemberInfo("AccountLocale", "mAccountLocale", 0xB2F8C000, TdfType.UInt32, 3, true), // LOC
        new TdfMemberInfo("PlayerName", "mPlayerName", 0xBA1B6500, TdfType.String, 4, true), // NAME
        new TdfMemberInfo("PlayerAttribs", "mPlayerAttribs", 0xC21D3400, TdfType.Map, 5, true), // PATT
        new TdfMemberInfo("PlayerId", "mPlayerId", 0xC2990000, TdfType.Int64, 6, true), // PID
        new TdfMemberInfo("NetworkAddress", "mNetworkAddress", 0xC2E97400, TdfType.Union, 7, true), // PNET
        new TdfMemberInfo("SlotId", "mSlotId", 0xCE990000, TdfType.UInt8, 8, true), // SID
        new TdfMemberInfo("SlotType", "mSlotType", 0xCECBF400, TdfType.Enum, 9, true), // SLOT
        new TdfMemberInfo("PlayerState", "mPlayerState", 0xCF487400, TdfType.Enum, 10, true), // STAT
        new TdfMemberInfo("TeamIndex", "mTeamIndex", 0xD2993800, TdfType.UInt16, 11, true), // TIDX
        new TdfMemberInfo("JoinedGameTimestamp", "mJoinedGameTimestamp", 0xD29B6500, TdfType.Int64, 12, true), // TIME
        new TdfMemberInfo("UserGroupId", "mUserGroupId", 0xD67A6400, TdfType.ObjectId, 13, true), // UGID
        new TdfMemberInfo("PlayerSessionId", "mPlayerSessionId", 0xD6990000, TdfType.UInt32, 14, true), // UID
    ];
    private ITdfMember[] __members;

    private TdfBlob _customData = new(__typeInfos[0]);
    private TdfUInt64 _externalId = new(__typeInfos[1]);
    private TdfUInt32 _gameId = new(__typeInfos[2]);
    private TdfUInt32 _accountLocale = new(__typeInfos[3]);
    private TdfString _playerName = new(__typeInfos[4]);
    private TdfMap<string, string> _playerAttribs = new(__typeInfos[5]);
    private TdfInt64 _playerId = new(__typeInfos[6]);
    private TdfUnion<Blaze3SDK.Blaze.NetworkAddress> _networkAddress = new(__typeInfos[7]);
    private TdfUInt8 _slotId = new(__typeInfos[8]);
    private TdfEnum<Blaze3SDK.Blaze.GameManager.SlotType> _slotType = new(__typeInfos[9]);
    private TdfEnum<Blaze3SDK.Blaze.GameManager.PlayerState> _playerState = new(__typeInfos[10]);
    private TdfUInt16 _teamIndex = new(__typeInfos[11]);
    private TdfInt64 _joinedGameTimestamp = new(__typeInfos[12]);
    private TdfObjectId _userGroupId = new(__typeInfos[13]);
    private TdfUInt32 _playerSessionId = new(__typeInfos[14]);

    public ReplicatedGamePlayer()
    {
        __members = [
            _customData,
            _externalId,
            _gameId,
            _accountLocale,
            _playerName,
            _playerAttribs,
            _playerId,
            _networkAddress,
            _slotId,
            _slotType,
            _playerState,
            _teamIndex,
            _joinedGameTimestamp,
            _userGroupId,
            _playerSessionId,
        ];
    }

    public override Tdf CreateNew() => new ReplicatedGamePlayer();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ReplicatedGamePlayer";
    public override string GetFullClassName() => "Blaze::GameManager::ReplicatedGamePlayer";

    public byte[] CustomData
    {
        get => _customData.Value;
        set => _customData.Value = value;
    }

    public ulong ExternalId
    {
        get => _externalId.Value;
        set => _externalId.Value = value;
    }

    public uint GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public uint AccountLocale
    {
        get => _accountLocale.Value;
        set => _accountLocale.Value = value;
    }

    public string PlayerName
    {
        get => _playerName.Value;
        set => _playerName.Value = value;
    }

    public IDictionary<string, string> PlayerAttribs
    {
        get => _playerAttribs.Value;
        set => _playerAttribs.Value = value;
    }

    public long PlayerId
    {
        get => _playerId.Value;
        set => _playerId.Value = value;
    }

    public Blaze3SDK.Blaze.NetworkAddress NetworkAddress
    {
        get => _networkAddress.Value;
        set => _networkAddress.Value = value;
    }

    public byte SlotId
    {
        get => _slotId.Value;
        set => _slotId.Value = value;
    }

    public Blaze3SDK.Blaze.GameManager.SlotType SlotType
    {
        get => _slotType.Value;
        set => _slotType.Value = value;
    }

    public Blaze3SDK.Blaze.GameManager.PlayerState PlayerState
    {
        get => _playerState.Value;
        set => _playerState.Value = value;
    }

    public ushort TeamIndex
    {
        get => _teamIndex.Value;
        set => _teamIndex.Value = value;
    }

    public long JoinedGameTimestamp
    {
        get => _joinedGameTimestamp.Value;
        set => _joinedGameTimestamp.Value = value;
    }

    public ObjectId UserGroupId
    {
        get => _userGroupId.Value;
        set => _userGroupId.Value = value;
    }

    public uint PlayerSessionId
    {
        get => _playerSessionId.Value;
        set => _playerSessionId.Value = value;
    }

}

