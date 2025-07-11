using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rooms;

public class RoomViewReplicationContext : Tdf
{
    public enum RoomViewUpdateReason : int
    {
        CONFIG_RELOADED = 0,
        USER_ROOM_CREATED = 1,
        USER_ROOM_DESTROYED = 2,
    }
    
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("UpdateReason", "mUpdateReason", 0xD70CA500, TdfType.Enum, 0, true), // UPRE
    ];
    private ITdfMember[] __members;

    private TdfEnum<Blaze3SDK.Blaze.Rooms.RoomViewReplicationContext.RoomViewUpdateReason> _updateReason = new(__typeInfos[0]);

    public RoomViewReplicationContext()
    {
        __members = [
            _updateReason,
        ];
    }

    public override Tdf CreateNew() => new RoomViewReplicationContext();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "RoomViewReplicationContext";
    public override string GetFullClassName() => "Blaze::Rooms::RoomViewReplicationContext";

    public Blaze3SDK.Blaze.Rooms.RoomViewReplicationContext.RoomViewUpdateReason UpdateReason
    {
        get => _updateReason.Value;
        set => _updateReason.Value = value;
    }

}

