using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class PlayerConnectionStatus : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("TargetPlayer", "mTargetPlayer", 0xC2990000, TdfType.UInt32, 0, true), // PID
        new TdfMemberInfo("PlayerNetConnectionStatus", "mPlayerNetConnectionStatus", 0xCF487400, TdfType.Enum, 1, true), // STAT
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _targetPlayer = new(__typeInfos[0]);
    private TdfEnum<Blaze2SDK.Blaze.GameManager.PlayerNetConnectionStatus> _playerNetConnectionStatus = new(__typeInfos[1]);

    public PlayerConnectionStatus()
    {
        __members = [
            _targetPlayer,
            _playerNetConnectionStatus,
        ];
    }

    public override Tdf CreateNew() => new PlayerConnectionStatus();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PlayerConnectionStatus";
    public override string GetFullClassName() => "Blaze::GameManager::PlayerConnectionStatus";

    public uint TargetPlayer
    {
        get => _targetPlayer.Value;
        set => _targetPlayer.Value = value;
    }

    public Blaze2SDK.Blaze.GameManager.PlayerNetConnectionStatus PlayerNetConnectionStatus
    {
        get => _playerNetConnectionStatus.Value;
        set => _playerNetConnectionStatus.Value = value;
    }

}

