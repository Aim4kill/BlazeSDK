using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class NotifyQueueChanged : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameId", "mGameId", 0x9E990000, TdfType.UInt32, 0, true), // GID
        new TdfMemberInfo("PlayerIdList", "mPlayerIdList", 0xC2992C00, TdfType.List, 1, true), // PIDL
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _gameId = new(__typeInfos[0]);
    private TdfList<uint> _playerIdList = new(__typeInfos[1]);

    public NotifyQueueChanged()
    {
        __members = [
            _gameId,
            _playerIdList,
        ];
    }

    public override Tdf CreateNew() => new NotifyQueueChanged();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NotifyQueueChanged";
    public override string GetFullClassName() => "Blaze::GameManager::NotifyQueueChanged";

    public uint GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public IList<uint> PlayerIdList
    {
        get => _playerIdList.Value;
        set => _playerIdList.Value = value;
    }

}

