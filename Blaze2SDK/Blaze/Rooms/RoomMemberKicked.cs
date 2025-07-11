using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Rooms;

public class RoomMemberKicked : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("UserId", "mUserId", 0xB62A6400, TdfType.UInt32, 0, true), // MBID
        new TdfMemberInfo("RoomId", "mRoomId", 0xCADA6400, TdfType.UInt32, 1, true), // RMID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _userId = new(__typeInfos[0]);
    private TdfUInt32 _roomId = new(__typeInfos[1]);

    public RoomMemberKicked()
    {
        __members = [
            _userId,
            _roomId,
        ];
    }

    public override Tdf CreateNew() => new RoomMemberKicked();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "RoomMemberKicked";
    public override string GetFullClassName() => "Blaze::Rooms::RoomMemberKicked";

    public uint UserId
    {
        get => _userId.Value;
        set => _userId.Value = value;
    }

    public uint RoomId
    {
        get => _roomId.Value;
        set => _roomId.Value = value;
    }

}

