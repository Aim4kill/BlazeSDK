using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Arson;

public class GetRoomCategoryClientMetaDataResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Attributes", "mAttributes", 0x874D3200, TdfType.Map, 0, true), // ATTR
    ];
    private ITdfMember[] __members;

    private TdfMap<string, string> _attributes = new(__typeInfos[0]);

    public GetRoomCategoryClientMetaDataResponse()
    {
        __members = [
            _attributes,
        ];
    }

    public override Tdf CreateNew() => new GetRoomCategoryClientMetaDataResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetRoomCategoryClientMetaDataResponse";
    public override string GetFullClassName() => "Blaze::Arson::GetRoomCategoryClientMetaDataResponse";

    public IDictionary<string, string> Attributes
    {
        get => _attributes.Value;
        set => _attributes.Value = value;
    }

}

