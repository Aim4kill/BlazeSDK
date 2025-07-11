using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class BanPlayerMasterRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("PlayerRemovedTitleContext", "mPlayerRemovedTitleContext", 0x8EED3800, TdfType.UInt16, 0, true), // CNTX
        new TdfMemberInfo("GameId", "mGameId", 0x9E990000, TdfType.UInt32, 1, true), // GID
        new TdfMemberInfo("NucleusId", "mNucleusId", 0xBA990000, TdfType.Int64, 2, true), // NID
        new TdfMemberInfo("BlazeId", "mBlazeId", 0xC2990000, TdfType.UInt32, 3, true), // PID
    ];
    private ITdfMember[] __members;

    private TdfUInt16 _playerRemovedTitleContext = new(__typeInfos[0]);
    private TdfUInt32 _gameId = new(__typeInfos[1]);
    private TdfInt64 _nucleusId = new(__typeInfos[2]);
    private TdfUInt32 _blazeId = new(__typeInfos[3]);

    public BanPlayerMasterRequest()
    {
        __members = [
            _playerRemovedTitleContext,
            _gameId,
            _nucleusId,
            _blazeId,
        ];
    }

    public override Tdf CreateNew() => new BanPlayerMasterRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "BanPlayerMasterRequest";
    public override string GetFullClassName() => "Blaze::GameManager::BanPlayerMasterRequest";

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

    public long NucleusId
    {
        get => _nucleusId.Value;
        set => _nucleusId.Value = value;
    }

    public uint BlazeId
    {
        get => _blazeId.Value;
        set => _blazeId.Value = value;
    }

}

