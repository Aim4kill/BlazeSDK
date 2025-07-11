using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameReportingLegacy;

public class GameEvent : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AttributeMap", "mAttributeMap", 0x961D3200, TdfType.Map, 0, true), // EATR
        new TdfMemberInfo("GameEventType", "mGameEventType", 0x9ED97400, TdfType.UInt32, 1, true), // GMET
    ];
    private ITdfMember[] __members;

    private TdfMap<string, string> _attributeMap = new(__typeInfos[0]);
    private TdfUInt32 _gameEventType = new(__typeInfos[1]);

    public GameEvent()
    {
        __members = [
            _attributeMap,
            _gameEventType,
        ];
    }

    public override Tdf CreateNew() => new GameEvent();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GameEvent";
    public override string GetFullClassName() => "Blaze::GameReportingLegacy::GameEvent";

    public IDictionary<string, string> AttributeMap
    {
        get => _attributeMap.Value;
        set => _attributeMap.Value = value;
    }

    public uint GameEventType
    {
        get => _gameEventType.Value;
        set => _gameEventType.Value = value;
    }

}

