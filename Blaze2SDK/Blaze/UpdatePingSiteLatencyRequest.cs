using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze;

public class UpdatePingSiteLatencyRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("PingSiteLatencyByAliasMap", "mPingSiteLatencyByAliasMap", 0xBACB7000, TdfType.Map, 0, true), // NLMP
    ];
    private ITdfMember[] __members;

    private TdfMap<string, int> _pingSiteLatencyByAliasMap = new(__typeInfos[0]);

    public UpdatePingSiteLatencyRequest()
    {
        __members = [
            _pingSiteLatencyByAliasMap,
        ];
    }

    public override Tdf CreateNew() => new UpdatePingSiteLatencyRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpdatePingSiteLatencyRequest";
    public override string GetFullClassName() => "Blaze::UpdatePingSiteLatencyRequest";

    public IDictionary<string, int> PingSiteLatencyByAliasMap
    {
        get => _pingSiteLatencyByAliasMap.Value;
        set => _pingSiteLatencyByAliasMap.Value = value;
    }

}

