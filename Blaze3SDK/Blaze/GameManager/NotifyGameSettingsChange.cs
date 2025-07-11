using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class NotifyGameSettingsChange : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameSettings", "mGameSettings", 0x874D3200, TdfType.Enum, 0, true), // ATTR
        new TdfMemberInfo("GameId", "mGameId", 0x9E990000, TdfType.UInt32, 1, true), // GID
    ];
    private ITdfMember[] __members;

    private TdfEnum<Blaze3SDK.Blaze.GameManager.GameSettings> _gameSettings = new(__typeInfos[0]);
    private TdfUInt32 _gameId = new(__typeInfos[1]);

    public NotifyGameSettingsChange()
    {
        __members = [
            _gameSettings,
            _gameId,
        ];
    }

    public override Tdf CreateNew() => new NotifyGameSettingsChange();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NotifyGameSettingsChange";
    public override string GetFullClassName() => "Blaze::GameManager::NotifyGameSettingsChange";

    public Blaze3SDK.Blaze.GameManager.GameSettings GameSettings
    {
        get => _gameSettings.Value;
        set => _gameSettings.Value = value;
    }

    public uint GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

}

