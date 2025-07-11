using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rooms;

public class JoinRoomResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CategoryData", "mCategoryData", 0x8E487400, TdfType.Struct, 0, true), // CDAT
        new TdfMemberInfo("FailedCriteria", "mFailedCriteria", 0x8F2A7400, TdfType.String, 1, true), // CRIT
        new TdfMemberInfo("MemberData", "mMemberData", 0xB6487400, TdfType.Struct, 2, true), // MDAT
        new TdfMemberInfo("RoomData", "mRoomData", 0xCA487400, TdfType.Struct, 3, true), // RDAT
        new TdfMemberInfo("ViewData", "mViewData", 0xDA487400, TdfType.Struct, 4, true), // VDAT
        new TdfMemberInfo("MapVersion", "mMapVersion", 0xDA5CB300, TdfType.UInt32, 5, true), // VERS
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze3SDK.Blaze.Rooms.RoomCategoryData?> _categoryData = new(__typeInfos[0]);
    private TdfString _failedCriteria = new(__typeInfos[1]);
    private TdfStruct<Blaze3SDK.Blaze.Rooms.RoomMemberData?> _memberData = new(__typeInfos[2]);
    private TdfStruct<Blaze3SDK.Blaze.Rooms.RoomData?> _roomData = new(__typeInfos[3]);
    private TdfStruct<Blaze3SDK.Blaze.Rooms.RoomViewData?> _viewData = new(__typeInfos[4]);
    private TdfUInt32 _mapVersion = new(__typeInfos[5]);

    public JoinRoomResponse()
    {
        __members = [
            _categoryData,
            _failedCriteria,
            _memberData,
            _roomData,
            _viewData,
            _mapVersion,
        ];
    }

    public override Tdf CreateNew() => new JoinRoomResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "JoinRoomResponse";
    public override string GetFullClassName() => "Blaze::Rooms::JoinRoomResponse";

    public Blaze3SDK.Blaze.Rooms.RoomCategoryData? CategoryData
    {
        get => _categoryData.Value;
        set => _categoryData.Value = value;
    }

    public string FailedCriteria
    {
        get => _failedCriteria.Value;
        set => _failedCriteria.Value = value;
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

    public uint MapVersion
    {
        get => _mapVersion.Value;
        set => _mapVersion.Value = value;
    }

}

