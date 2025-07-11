using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Stats;

public class KeyScopes : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("KeyScopesMap", "mKeyScopesMap", 0xAF3A7400, TdfType.Map, 0, true), // KSIT
    ];
    private ITdfMember[] __members;

    private TdfMap<string, Blaze2SDK.Blaze.Stats.KeyScopeItem> _keyScopesMap = new(__typeInfos[0]);

    public KeyScopes()
    {
        __members = [
            _keyScopesMap,
        ];
    }

    public override Tdf CreateNew() => new KeyScopes();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "KeyScopes";
    public override string GetFullClassName() => "Blaze::Stats::KeyScopes";

    public IDictionary<string, Blaze2SDK.Blaze.Stats.KeyScopeItem> KeyScopesMap
    {
        get => _keyScopesMap.Value;
        set => _keyScopesMap.Value = value;
    }

}

