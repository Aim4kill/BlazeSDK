using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class JoinGameByGroupMasterRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GroupId", "mGroupId", 0x8B4C2C00, TdfType.UInt64, 0, true), // BTPL
        new TdfMemberInfo("GameId", "mGameId", 0x9E990000, TdfType.UInt32, 1, true), // GID
        new TdfMemberInfo("JoinMethod", "mJoinMethod", 0xAAD97400, TdfType.Enum, 2, true), // JMET
        new TdfMemberInfo("SessionIdList", "mSessionIdList", 0xCE992C00, TdfType.List, 3, true), // SIDL
        new TdfMemberInfo("RequestedSlotType", "mRequestedSlotType", 0xCECBF400, TdfType.Enum, 4, true), // SLOT
        new TdfMemberInfo("JoiningTeamId", "mJoiningTeamId", 0xD2586D00, TdfType.UInt16, 5, true), // TEAM
        new TdfMemberInfo("JoiningTeamIndex", "mJoiningTeamIndex", 0xD2993800, TdfType.UInt16, 6, true), // TIDX
    ];
    private ITdfMember[] __members;

    private TdfUInt64 _groupId = new(__typeInfos[0]);
    private TdfUInt32 _gameId = new(__typeInfos[1]);
    private TdfEnum<Blaze2SDK.Blaze.GameManager.JoinMethod> _joinMethod = new(__typeInfos[2]);
    private TdfList<uint> _sessionIdList = new(__typeInfos[3]);
    private TdfEnum<Blaze2SDK.Blaze.GameManager.SlotType> _requestedSlotType = new(__typeInfos[4]);
    private TdfUInt16 _joiningTeamId = new(__typeInfos[5]);
    private TdfUInt16 _joiningTeamIndex = new(__typeInfos[6]);

    public JoinGameByGroupMasterRequest()
    {
        __members = [
            _groupId,
            _gameId,
            _joinMethod,
            _sessionIdList,
            _requestedSlotType,
            _joiningTeamId,
            _joiningTeamIndex,
        ];
    }

    public override Tdf CreateNew() => new JoinGameByGroupMasterRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "JoinGameByGroupMasterRequest";
    public override string GetFullClassName() => "Blaze::GameManager::JoinGameByGroupMasterRequest";

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

    public Blaze2SDK.Blaze.GameManager.JoinMethod JoinMethod
    {
        get => _joinMethod.Value;
        set => _joinMethod.Value = value;
    }

    public IList<uint> SessionIdList
    {
        get => _sessionIdList.Value;
        set => _sessionIdList.Value = value;
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

}

