using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Rooms;

public class LeaveRoomResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CategoryId", "mCategoryId", 0x8F4A6400, TdfType.UInt32, 0, true), // CTID
        new TdfMemberInfo("RoomId", "mRoomId", 0xCADA6400, TdfType.UInt32, 1, true), // RMID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _categoryId = new(__typeInfos[0]);
    private TdfUInt32 _roomId = new(__typeInfos[1]);

    public LeaveRoomResponse()
    {
        __members = [
            _categoryId,
            _roomId,
        ];
    }

    public override Tdf CreateNew() => new LeaveRoomResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "LeaveRoomResponse";
    public override string GetFullClassName() => "Blaze::Rooms::LeaveRoomResponse";

    public uint CategoryId
    {
        get => _categoryId.Value;
        set => _categoryId.Value = value;
    }

    public uint RoomId
    {
        get => _roomId.Value;
        set => _roomId.Value = value;
    }

}

