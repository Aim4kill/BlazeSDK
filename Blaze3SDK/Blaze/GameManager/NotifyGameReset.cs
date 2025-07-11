using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class NotifyGameReset : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameData", "mGameData", 0x921D2100, TdfType.Struct, 0, true), // DATA
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze3SDK.Blaze.GameManager.ReplicatedGameData?> _gameData = new(__typeInfos[0]);

    public NotifyGameReset()
    {
        __members = [
            _gameData,
        ];
    }

    public override Tdf CreateNew() => new NotifyGameReset();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NotifyGameReset";
    public override string GetFullClassName() => "Blaze::GameManager::NotifyGameReset";

    public Blaze3SDK.Blaze.GameManager.ReplicatedGameData? GameData
    {
        get => _gameData.Value;
        set => _gameData.Value = value;
    }

}

