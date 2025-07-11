using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Stats;

public class KeyScopeItem : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("KeyScopeType", "mKeyScopeType", 0xAF3A7400, TdfType.Enum, 0, true), // KSIT
        new TdfMemberInfo("KeyScopeList", "mKeyScopeList", 0xAF3DAC00, TdfType.List, 1, true), // KSVL
    ];
    private ITdfMember[] __members;

    private TdfEnum<Blaze2SDK.Blaze.Stats.KeyScopeType> _keyScopeType = new(__typeInfos[0]);
    private TdfList<string> _keyScopeList = new(__typeInfos[1]);

    public KeyScopeItem()
    {
        __members = [
            _keyScopeType,
            _keyScopeList,
        ];
    }

    public override Tdf CreateNew() => new KeyScopeItem();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "KeyScopeItem";
    public override string GetFullClassName() => "Blaze::Stats::KeyScopeItem";

    public Blaze2SDK.Blaze.Stats.KeyScopeType KeyScopeType
    {
        get => _keyScopeType.Value;
        set => _keyScopeType.Value = value;
    }

    public IList<string> KeyScopeList
    {
        get => _keyScopeList.Value;
        set => _keyScopeList.Value = value;
    }

}

