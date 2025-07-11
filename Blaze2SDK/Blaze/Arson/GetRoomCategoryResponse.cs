using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Arson;

public class GetRoomCategoryResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CategoryData", "mCategoryData", 0x8E1D0000, TdfType.Struct, 0, true), // CAT
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze2SDK.Blaze.Rooms.RoomCategoryData?> _categoryData = new(__typeInfos[0]);

    public GetRoomCategoryResponse()
    {
        __members = [
            _categoryData,
        ];
    }

    public override Tdf CreateNew() => new GetRoomCategoryResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetRoomCategoryResponse";
    public override string GetFullClassName() => "Blaze::Arson::GetRoomCategoryResponse";

    public Blaze2SDK.Blaze.Rooms.RoomCategoryData? CategoryData
    {
        get => _categoryData.Value;
        set => _categoryData.Value = value;
    }

}

