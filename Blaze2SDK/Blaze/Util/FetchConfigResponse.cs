using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Util;

public class FetchConfigResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Config", "mConfig", 0x8EFBA600, TdfType.Map, 0, true), // CONF
    ];
    private ITdfMember[] __members;

    private TdfMap<string, string> _config = new(__typeInfos[0]);

    public FetchConfigResponse()
    {
        __members = [
            _config,
        ];
    }

    public override Tdf CreateNew() => new FetchConfigResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "FetchConfigResponse";
    public override string GetFullClassName() => "Blaze::Util::FetchConfigResponse";

    public IDictionary<string, string> Config
    {
        get => _config.Value;
        set => _config.Value = value;
    }

}

