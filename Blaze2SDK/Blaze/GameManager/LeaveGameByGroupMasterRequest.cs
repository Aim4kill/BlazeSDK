using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class LeaveGameByGroupMasterRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("PlayerRemovedTitleContext", "mPlayerRemovedTitleContext", 0x8EED3800, TdfType.UInt16, 0, true), // CNTX
        new TdfMemberInfo("GameId", "mGameId", 0x9E990000, TdfType.UInt32, 1, true), // GID
        new TdfMemberInfo("SessionIdList", "mSessionIdList", 0xCE992C00, TdfType.List, 2, true), // SIDL
    ];
    private ITdfMember[] __members;

    private TdfUInt16 _playerRemovedTitleContext = new(__typeInfos[0]);
    private TdfUInt32 _gameId = new(__typeInfos[1]);
    private TdfList<uint> _sessionIdList = new(__typeInfos[2]);

    public LeaveGameByGroupMasterRequest()
    {
        __members = [
            _playerRemovedTitleContext,
            _gameId,
            _sessionIdList,
        ];
    }

    public override Tdf CreateNew() => new LeaveGameByGroupMasterRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "LeaveGameByGroupMasterRequest";
    public override string GetFullClassName() => "Blaze::GameManager::LeaveGameByGroupMasterRequest";

    public ushort PlayerRemovedTitleContext
    {
        get => _playerRemovedTitleContext.Value;
        set => _playerRemovedTitleContext.Value = value;
    }

    public uint GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public IList<uint> SessionIdList
    {
        get => _sessionIdList.Value;
        set => _sessionIdList.Value = value;
    }

}

