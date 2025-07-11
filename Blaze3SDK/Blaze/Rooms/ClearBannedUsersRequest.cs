using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rooms;

public class ClearBannedUsersRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("RoomId", "mRoomId", 0xCADA6400, TdfType.UInt32, 0, true), // RMID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _roomId = new(__typeInfos[0]);

    public ClearBannedUsersRequest()
    {
        __members = [
            _roomId,
        ];
    }

    public override Tdf CreateNew() => new ClearBannedUsersRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ClearBannedUsersRequest";
    public override string GetFullClassName() => "Blaze::Rooms::ClearBannedUsersRequest";

    public uint RoomId
    {
        get => _roomId.Value;
        set => _roomId.Value = value;
    }

}

