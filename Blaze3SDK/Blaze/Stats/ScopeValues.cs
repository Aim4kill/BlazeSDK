using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Stats;

public class ScopeValues : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("KeyScopeValues", "mKeyScopeValues", 0xAF3DAC00, TdfType.Map, 0, true), // KSVL
    ];
    private ITdfMember[] __members;

    private TdfMap<long, long> _keyScopeValues = new(__typeInfos[0]);

    public ScopeValues()
    {
        __members = [
            _keyScopeValues,
        ];
    }

    public override Tdf CreateNew() => new ScopeValues();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ScopeValues";
    public override string GetFullClassName() => "Blaze::Stats::ScopeValues";

    public IDictionary<long, long> KeyScopeValues
    {
        get => _keyScopeValues.Value;
        set => _keyScopeValues.Value = value;
    }

}

