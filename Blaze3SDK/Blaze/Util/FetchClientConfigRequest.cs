using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Util;

public class FetchClientConfigRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ConfigSection", "mConfigSection", 0x8E6A6400, TdfType.String, 0, true), // CFID
    ];
    private ITdfMember[] __members;

    private TdfString _configSection = new(__typeInfos[0]);

    public FetchClientConfigRequest()
    {
        __members = [
            _configSection,
        ];
    }

    public override Tdf CreateNew() => new FetchClientConfigRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "FetchClientConfigRequest";
    public override string GetFullClassName() => "Blaze::Util::FetchClientConfigRequest";

    public string ConfigSection
    {
        get => _configSection.Value;
        set => _configSection.Value = value;
    }

}

