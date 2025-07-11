using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rooms;

public class SetCategoryAttributesRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Attributes", "mAttributes", 0x874D3200, TdfType.Map, 0, true), // ATTR
        new TdfMemberInfo("CategoryId", "mCategoryId", 0x8F4A6400, TdfType.UInt32, 1, true), // CTID
    ];
    private ITdfMember[] __members;

    private TdfMap<string, string> _attributes = new(__typeInfos[0]);
    private TdfUInt32 _categoryId = new(__typeInfos[1]);

    public SetCategoryAttributesRequest()
    {
        __members = [
            _attributes,
            _categoryId,
        ];
    }

    public override Tdf CreateNew() => new SetCategoryAttributesRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "SetCategoryAttributesRequest";
    public override string GetFullClassName() => "Blaze::Rooms::SetCategoryAttributesRequest";

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

