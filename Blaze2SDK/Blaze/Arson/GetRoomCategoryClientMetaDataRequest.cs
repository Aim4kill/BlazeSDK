using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Arson;

public class GetRoomCategoryClientMetaDataRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CategoryId", "mCategoryId", 0x8E990000, TdfType.UInt32, 0, true), // CID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _categoryId = new(__typeInfos[0]);

    public GetRoomCategoryClientMetaDataRequest()
    {
        __members = [
            _categoryId,
        ];
    }

    public override Tdf CreateNew() => new GetRoomCategoryClientMetaDataRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetRoomCategoryClientMetaDataRequest";
    public override string GetFullClassName() => "Blaze::Arson::GetRoomCategoryClientMetaDataRequest";

    public uint CategoryId
    {
        get => _categoryId.Value;
        set => _categoryId.Value = value;
    }

}

