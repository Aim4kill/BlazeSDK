using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class SetGameSettingsRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameId", "mGameId", 0x9E990000, TdfType.UInt32, 0, true), // GID
        new TdfMemberInfo("GameSettings", "mGameSettings", 0x9F397400, TdfType.Enum, 1, true), // GSET
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _gameId = new(__typeInfos[0]);
    private TdfEnum<Blaze3SDK.Blaze.GameManager.GameSettings> _gameSettings = new(__typeInfos[1]);

    public SetGameSettingsRequest()
    {
        __members = [
            _gameId,
            _gameSettings,
        ];
    }

    public override Tdf CreateNew() => new SetGameSettingsRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "SetGameSettingsRequest";
    public override string GetFullClassName() => "Blaze::GameManager::SetGameSettingsRequest";

    public uint GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public Blaze3SDK.Blaze.GameManager.GameSettings GameSettings
    {
        get => _gameSettings.Value;
        set => _gameSettings.Value = value;
    }

}

