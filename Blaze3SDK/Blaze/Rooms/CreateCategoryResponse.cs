using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rooms;

public class CreateCategoryResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CategoryData", "mCategoryData", 0x8E487400, TdfType.Struct, 0, true), // CDAT
        new TdfMemberInfo("MemberData", "mMemberData", 0xB6487400, TdfType.Struct, 1, true), // MDAT
        new TdfMemberInfo("RoomData", "mRoomData", 0xCA487400, TdfType.Struct, 2, true), // RDAT
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze3SDK.Blaze.Rooms.RoomCategoryData?> _categoryData = new(__typeInfos[0]);
    private TdfStruct<Blaze3SDK.Blaze.Rooms.RoomMemberData?> _memberData = new(__typeInfos[1]);
    private TdfStruct<Blaze3SDK.Blaze.Rooms.RoomData?> _roomData = new(__typeInfos[2]);

    public CreateCategoryResponse()
    {
        __members = [
            _categoryData,
            _memberData,
            _roomData,
        ];
    }

    public override Tdf CreateNew() => new CreateCategoryResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "CreateCategoryResponse";
    public override string GetFullClassName() => "Blaze::Rooms::CreateCategoryResponse";

    public Blaze3SDK.Blaze.Rooms.RoomCategoryData? CategoryData
    {
        get => _categoryData.Value;
        set => _categoryData.Value = value;
    }

    public Blaze3SDK.Blaze.Rooms.RoomMemberData? MemberData
    {
        get => _memberData.Value;
        set => _memberData.Value = value;
    }

    public Blaze3SDK.Blaze.Rooms.RoomData? RoomData
    {
        get => _roomData.Value;
        set => _roomData.Value = value;
    }

}

