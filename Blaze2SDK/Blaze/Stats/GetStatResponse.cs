using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Stats;

public class GetStatResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("KeyScopeStatsValueMap", "mKeyScopeStatsValueMap", 0xAF3CF600, TdfType.Map, 0, true), // KSSV
    ];
    private ITdfMember[] __members;

    private TdfMap<string, Blaze2SDK.Blaze.Stats.StatValues> _keyScopeStatsValueMap = new(__typeInfos[0]);

    public GetStatResponse()
    {
        __members = [
            _keyScopeStatsValueMap,
        ];
    }

    public override Tdf CreateNew() => new GetStatResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetStatResponse";
    public override string GetFullClassName() => "Blaze::Stats::GetStatResponse";

    public IDictionary<string, Blaze2SDK.Blaze.Stats.StatValues> KeyScopeStatsValueMap
    {
        get => _keyScopeStatsValueMap.Value;
        set => _keyScopeStatsValueMap.Value = value;
    }

}

