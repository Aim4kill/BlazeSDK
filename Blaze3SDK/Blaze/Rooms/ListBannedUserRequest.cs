using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rooms;

public class ListBannedUserRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("RoomId", "mRoomId", 0xCADA6400, TdfType.UInt32, 0, true), // RMID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _roomId = new(__typeInfos[0]);

    public ListBannedUserRequest()
    {
        __members = [
            _roomId,
        ];
    }

    public override Tdf CreateNew() => new ListBannedUserRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ListBannedUserRequest";
    public override string GetFullClassName() => "Blaze::Rooms::ListBannedUserRequest";

    public uint RoomId
    {
        get => _roomId.Value;
        set => _roomId.Value = value;
    }

}

