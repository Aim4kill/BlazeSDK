using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameReporting;

public class GameEvents : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameEvents", "mGameEvents", 0x9ED97300, TdfType.List, 0, true), // GMES
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze2SDK.Blaze.GameReporting.GameEvent> _gameEvents = new(__typeInfos[0]);

    public GameEvents()
    {
        __members = [
            _gameEvents,
        ];
    }

    public override Tdf CreateNew() => new GameEvents();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GameEvents";
    public override string GetFullClassName() => "Blaze::GameReporting::GameEvents";

    public IList<Blaze2SDK.Blaze.GameReporting.GameEvent> mGameEvents
    {
        get => _gameEvents.Value;
        set => _gameEvents.Value = value;
    }

}

