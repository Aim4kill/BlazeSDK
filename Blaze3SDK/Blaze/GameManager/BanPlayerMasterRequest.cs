using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class BanPlayerMasterRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AccountIds", "mAccountIds", 0x86CCF400, TdfType.List, 0, true), // ALST
        new TdfMemberInfo("PlayerRemovedTitleContext", "mPlayerRemovedTitleContext", 0x8EED3800, TdfType.UInt16, 1, true), // CNTX
        new TdfMemberInfo("GameId", "mGameId", 0x9E990000, TdfType.UInt32, 2, true), // GID
        new TdfMemberInfo("PlayerIds", "mPlayerIds", 0xC2CCF400, TdfType.List, 3, true), // PLST
    ];
    private ITdfMember[] __members;

    private TdfList<long> _accountIds = new(__typeInfos[0]);
    private TdfUInt16 _playerRemovedTitleContext = new(__typeInfos[1]);
    private TdfUInt32 _gameId = new(__typeInfos[2]);
    private TdfList<long> _playerIds = new(__typeInfos[3]);

    public BanPlayerMasterRequest()
    {
        __members = [
            _accountIds,
            _playerRemovedTitleContext,
            _gameId,
            _playerIds,
        ];
    }

    public override Tdf CreateNew() => new BanPlayerMasterRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "BanPlayerMasterRequest";
    public override string GetFullClassName() => "Blaze::GameManager::BanPlayerMasterRequest";

    public IList<long> AccountIds
    {
        get => _accountIds.Value;
        set => _accountIds.Value = value;
    }

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

    public IList<long> PlayerIds
    {
        get => _playerIds.Value;
        set => _playerIds.Value = value;
    }

}

