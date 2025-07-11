using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GpsContentController;

public class FetchContentResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AttributeMap", "mAttributeMap", 0x86EDB000, TdfType.Map, 0, true), // ANVP
        new TdfMemberInfo("ExternalURL", "mExternalURL", 0x975CAC00, TdfType.String, 1, true), // EURL
    ];
    private ITdfMember[] __members;

    private TdfMap<string, string> _attributeMap = new(__typeInfos[0]);
    private TdfString _externalURL = new(__typeInfos[1]);

    public FetchContentResponse()
    {
        __members = [
            _attributeMap,
            _externalURL,
        ];
    }

    public override Tdf CreateNew() => new FetchContentResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "FetchContentResponse";
    public override string GetFullClassName() => "Blaze::GpsContentController::FetchContentResponse";

    public IDictionary<string, string> AttributeMap
    {
        get => _attributeMap.Value;
        set => _attributeMap.Value = value;
    }

    public string ExternalURL
    {
        get => _externalURL.Value;
        set => _externalURL.Value = value;
    }

}

