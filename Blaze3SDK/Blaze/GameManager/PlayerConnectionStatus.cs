using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class PlayerConnectionStatus : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("PlayerNetConnectionFlags", "mPlayerNetConnectionFlags", 0x9AC9F300, TdfType.Enum, 0, true), // FLGS
        new TdfMemberInfo("TargetPlayer", "mTargetPlayer", 0xC2990000, TdfType.Int64, 1, true), // PID
        new TdfMemberInfo("PlayerNetConnectionStatus", "mPlayerNetConnectionStatus", 0xCF487400, TdfType.Enum, 2, true), // STAT
    ];
    private ITdfMember[] __members;

    private TdfEnum<Blaze3SDK.Blaze.GameManager.PlayerNetConnectionFlags> _playerNetConnectionFlags = new(__typeInfos[0]);
    private TdfInt64 _targetPlayer = new(__typeInfos[1]);
    private TdfEnum<Blaze3SDK.Blaze.GameManager.PlayerNetConnectionStatus> _playerNetConnectionStatus = new(__typeInfos[2]);

    public PlayerConnectionStatus()
    {
        __members = [
            _playerNetConnectionFlags,
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

    public Blaze3SDK.Blaze.GameManager.PlayerNetConnectionFlags PlayerNetConnectionFlags
    {
        get => _playerNetConnectionFlags.Value;
        set => _playerNetConnectionFlags.Value = value;
    }

    public long TargetPlayer
    {
        get => _targetPlayer.Value;
        set => _targetPlayer.Value = value;
    }

    public Blaze3SDK.Blaze.GameManager.PlayerNetConnectionStatus PlayerNetConnectionStatus
    {
        get => _playerNetConnectionStatus.Value;
        set => _playerNetConnectionStatus.Value = value;
    }

}

