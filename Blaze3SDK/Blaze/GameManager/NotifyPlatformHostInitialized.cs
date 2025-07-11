using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class NotifyPlatformHostInitialized : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameId", "mGameId", 0x9E990000, TdfType.UInt32, 0, true), // GID
        new TdfMemberInfo("PlatformHostSlotId", "mPlatformHostSlotId", 0xC28CF400, TdfType.UInt8, 1, true), // PHST
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _gameId = new(__typeInfos[0]);
    private TdfUInt8 _platformHostSlotId = new(__typeInfos[1]);

    public NotifyPlatformHostInitialized()
    {
        __members = [
            _gameId,
            _platformHostSlotId,
        ];
    }

    public override Tdf CreateNew() => new NotifyPlatformHostInitialized();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NotifyPlatformHostInitialized";
    public override string GetFullClassName() => "Blaze::GameManager::NotifyPlatformHostInitialized";

    public uint GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public byte PlatformHostSlotId
    {
        get => _platformHostSlotId.Value;
        set => _platformHostSlotId.Value = value;
    }

}

