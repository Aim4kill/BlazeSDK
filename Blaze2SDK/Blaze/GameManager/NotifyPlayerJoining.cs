using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class NotifyPlayerJoining : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameId", "mGameId", 0x9E990000, TdfType.UInt32, 0, true), // GID
        new TdfMemberInfo("JoiningPlayer", "mJoiningPlayer", 0xC2487400, TdfType.Struct, 1, true), // PDAT
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _gameId = new(__typeInfos[0]);
    private TdfStruct<Blaze2SDK.Blaze.GameManager.ReplicatedGamePlayer?> _joiningPlayer = new(__typeInfos[1]);

    public NotifyPlayerJoining()
    {
        __members = [
            _gameId,
            _joiningPlayer,
        ];
    }

    public override Tdf CreateNew() => new NotifyPlayerJoining();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NotifyPlayerJoining";
    public override string GetFullClassName() => "Blaze::GameManager::NotifyPlayerJoining";

    public uint GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public Blaze2SDK.Blaze.GameManager.ReplicatedGamePlayer? JoiningPlayer
    {
        get => _joiningPlayer.Value;
        set => _joiningPlayer.Value = value;
    }

}

