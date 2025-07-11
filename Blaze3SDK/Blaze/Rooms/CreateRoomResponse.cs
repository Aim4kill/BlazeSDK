using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rooms;

public class CreateRoomResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CategoryData", "mCategoryData", 0x8E487400, TdfType.Struct, 0, true), // CDAT
        new TdfMemberInfo("MemberData", "mMemberData", 0xB6487400, TdfType.Struct, 1, true), // MDAT
        new TdfMemberInfo("RoomData", "mRoomData", 0xCA487400, TdfType.Struct, 2, true), // RDAT
        new TdfMemberInfo("ViewData", "mViewData", 0xDA487400, TdfType.Struct, 3, true), // VDAT
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze3SDK.Blaze.Rooms.RoomCategoryData?> _categoryData = new(__typeInfos[0]);
    private TdfStruct<Blaze3SDK.Blaze.Rooms.RoomMemberData?> _memberData = new(__typeInfos[1]);
    private TdfStruct<Blaze3SDK.Blaze.Rooms.RoomData?> _roomData = new(__typeInfos[2]);
    private TdfStruct<Blaze3SDK.Blaze.Rooms.RoomViewData?> _viewData = new(__typeInfos[3]);

    public CreateRoomResponse()
    {
        __members = [
            _categoryData,
            _memberData,
            _roomData,
            _viewData,
        ];
    }

    public override Tdf CreateNew() => new CreateRoomResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "CreateRoomResponse";
    public override string GetFullClassName() => "Blaze::Rooms::CreateRoomResponse";

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

    public Blaze3SDK.Blaze.Rooms.RoomViewData? ViewData
    {
        get => _viewData.Value;
        set => _viewData.Value = value;
    }

}

