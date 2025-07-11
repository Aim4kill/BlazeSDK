using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameReporting;

public class GameEvent : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameEventData", "mGameEventData", 0x921D2100, TdfType.Variable, 0, true), // DATA
        new TdfMemberInfo("GameEventType", "mGameEventType", 0x9ED97400, TdfType.UInt32, 1, true), // GMET
    ];
    private ITdfMember[] __members;

    private TdfVariable _gameEventData = new(__typeInfos[0]);
    private TdfUInt32 _gameEventType = new(__typeInfos[1]);

    public GameEvent()
    {
        __members = [
            _gameEventData,
            _gameEventType,
        ];
    }

    public override Tdf CreateNew() => new GameEvent();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GameEvent";
    public override string GetFullClassName() => "Blaze::GameReporting::GameEvent";

    public object? GameEventData
    {
        get => _gameEventData.Value;
        set => _gameEventData.Value = value;
    }

    public uint GameEventType
    {
        get => _gameEventType.Value;
        set => _gameEventType.Value = value;
    }

}

