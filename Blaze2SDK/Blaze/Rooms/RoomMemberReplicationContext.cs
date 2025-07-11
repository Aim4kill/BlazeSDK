using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Rooms;

public class RoomMemberReplicationContext : Tdf
{
    public enum RoomMemberReplicationReason : int
    {
        USER_LEFT = 0,
        USER_KICKED = 1,
        USER_JOINED = 2,
        USER_LOGOUT = 3,
        ROOM_CREATED = 4,
        ROOM_DESTROYED = 5,
    }
    
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Reason", "mReason", 0xD70CA500, TdfType.Enum, 0, true), // UPRE
        new TdfMemberInfo("UserId", "mUserId", 0xD73A6400, TdfType.UInt32, 1, true), // USID
    ];
    private ITdfMember[] __members;

    private TdfEnum<Blaze2SDK.Blaze.Rooms.RoomMemberReplicationContext.RoomMemberReplicationReason> _reason = new(__typeInfos[0]);
    private TdfUInt32 _userId = new(__typeInfos[1]);

    public RoomMemberReplicationContext()
    {
        __members = [
            _reason,
            _userId,
        ];
    }

    public override Tdf CreateNew() => new RoomMemberReplicationContext();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "RoomMemberReplicationContext";
    public override string GetFullClassName() => "Blaze::Rooms::RoomMemberReplicationContext";

    public Blaze2SDK.Blaze.Rooms.RoomMemberReplicationContext.RoomMemberReplicationReason Reason
    {
        get => _reason.Value;
        set => _reason.Value = value;
    }

    public uint UserId
    {
        get => _userId.Value;
        set => _userId.Value = value;
    }

}

