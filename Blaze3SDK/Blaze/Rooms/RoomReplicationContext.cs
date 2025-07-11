using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rooms;

public class RoomReplicationContext : Tdf
{
    public enum RoomUpdateReason : int
    {
        DELETED_EXPANDED_ROOM = 0,
        DELETED_PSEUDO_ROOM = 1,
        DELETED_EMPTY_USER_CREATED = 2,
        DELETED_BY_USER = 3,
        CONFIG_RELOADED = 4,
        HOST_TRANSFER = 5,
        POPULATION_CHANGED = 6,
        USER_CREATED = 7,
        ATTRIBUTES_UPDATE = 8,
        BAN_LIST_MODIFIED = 9,
    }
    
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("UserSessionId", "mUserSessionId", 0xCE5A6400, TdfType.UInt32, 0, true), // SEID
        new TdfMemberInfo("UpdateReason", "mUpdateReason", 0xD70CA500, TdfType.Enum, 1, true), // UPRE
        new TdfMemberInfo("UserId", "mUserId", 0xD73A6400, TdfType.Int64, 2, true), // USID
        new TdfMemberInfo("ViewId", "mViewId", 0xDB7A6400, TdfType.UInt32, 3, true), // VWID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _userSessionId = new(__typeInfos[0]);
    private TdfEnum<Blaze3SDK.Blaze.Rooms.RoomReplicationContext.RoomUpdateReason> _updateReason = new(__typeInfos[1]);
    private TdfInt64 _userId = new(__typeInfos[2]);
    private TdfUInt32 _viewId = new(__typeInfos[3]);

    public RoomReplicationContext()
    {
        __members = [
            _userSessionId,
            _updateReason,
            _userId,
            _viewId,
        ];
    }

    public override Tdf CreateNew() => new RoomReplicationContext();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "RoomReplicationContext";
    public override string GetFullClassName() => "Blaze::Rooms::RoomReplicationContext";

    public uint UserSessionId
    {
        get => _userSessionId.Value;
        set => _userSessionId.Value = value;
    }

    public Blaze3SDK.Blaze.Rooms.RoomReplicationContext.RoomUpdateReason UpdateReason
    {
        get => _updateReason.Value;
        set => _updateReason.Value = value;
    }

    public long UserId
    {
        get => _userId.Value;
        set => _userId.Value = value;
    }

    public uint ViewId
    {
        get => _viewId.Value;
        set => _viewId.Value = value;
    }

}

