using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GpsContentController;

public class FetchContentResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("attributeMap", "attributeMap", 0x86EDB000, TdfType.Map, 0, true), // ANVP
    ];
    private ITdfMember[] __members;

    private TdfMap<string, string> _attributeMap = new(__typeInfos[0]);

    public FetchContentResponse()
    {
        __members = [
            _attributeMap,
        ];
    }

    public override Tdf CreateNew() => new FetchContentResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "FetchContentResponse";
    public override string GetFullClassName() => "Blaze::GpsContentController::FetchContentResponse";

    public IDictionary<string, string> attributeMap
    {
        get => _attributeMap.Value;
        set => _attributeMap.Value = value;
    }

}

