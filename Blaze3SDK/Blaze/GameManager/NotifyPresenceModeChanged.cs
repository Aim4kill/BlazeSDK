using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class NotifyPresenceModeChanged : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameId", "mGameId", 0x9E990000, TdfType.UInt32, 0, true), // GID
        new TdfMemberInfo("NewPresenceMode", "mNewPresenceMode", 0xC3297300, TdfType.Enum, 1, true), // PRES
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _gameId = new(__typeInfos[0]);
    private TdfEnum<Blaze3SDK.Blaze.PresenceMode> _newPresenceMode = new(__typeInfos[1]);

    public NotifyPresenceModeChanged()
    {
        __members = [
            _gameId,
            _newPresenceMode,
        ];
    }

    public override Tdf CreateNew() => new NotifyPresenceModeChanged();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NotifyPresenceModeChanged";
    public override string GetFullClassName() => "Blaze::GameManager::NotifyPresenceModeChanged";

    public uint GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public Blaze3SDK.Blaze.PresenceMode NewPresenceMode
    {
        get => _newPresenceMode.Value;
        set => _newPresenceMode.Value = value;
    }

}

