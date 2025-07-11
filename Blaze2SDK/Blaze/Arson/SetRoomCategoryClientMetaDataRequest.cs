using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Arson;

public class SetRoomCategoryClientMetaDataRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Attributes", "mAttributes", 0x874D3200, TdfType.Map, 0, true), // ATTR
        new TdfMemberInfo("CategoryId", "mCategoryId", 0x8E990000, TdfType.UInt32, 1, true), // CID
    ];
    private ITdfMember[] __members;

    private TdfMap<string, string> _attributes = new(__typeInfos[0]);
    private TdfUInt32 _categoryId = new(__typeInfos[1]);

    public SetRoomCategoryClientMetaDataRequest()
    {
        __members = [
            _attributes,
            _categoryId,
        ];
    }

    public override Tdf CreateNew() => new SetRoomCategoryClientMetaDataRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "SetRoomCategoryClientMetaDataRequest";
    public override string GetFullClassName() => "Blaze::Arson::SetRoomCategoryClientMetaDataRequest";

    public IDictionary<string, string> Attributes
    {
        get => _attributes.Value;
        set => _attributes.Value = value;
    }

    public uint CategoryId
    {
        get => _categoryId.Value;
        set => _categoryId.Value = value;
    }

}

