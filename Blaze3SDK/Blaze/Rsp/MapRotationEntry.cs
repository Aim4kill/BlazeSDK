using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rsp;

public class MapRotationEntry : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Map", "mMap", 0xB61C0000, TdfType.String, 0, true), // MAP
        new TdfMemberInfo("GameMode", "mGameMode", 0xB6F92500, TdfType.String, 1, true), // MODE
    ];
    private ITdfMember[] __members;

    private TdfString _map = new(__typeInfos[0]);
    private TdfString _gameMode = new(__typeInfos[1]);

    public MapRotationEntry()
    {
        __members = [
            _map,
            _gameMode,
        ];
    }

    public override Tdf CreateNew() => new MapRotationEntry();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "MapRotationEntry";
    public override string GetFullClassName() => "Blaze::Rsp::MapRotationEntry";

    public string Map
    {
        get => _map.Value;
        set => _map.Value = value;
    }

    public string GameMode
    {
        get => _gameMode.Value;
        set => _gameMode.Value = value;
    }

}

