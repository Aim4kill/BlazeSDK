using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Rooms;

public class RoomCategoryReplicationContext : Tdf
{
    public enum RoomCategoryUpdateReason : int
    {
        CONFIG_RELOADED = 0,
        USER_CREATED = 1,
        ROOM_EXPANSION_CHANGE = 2,
        ATTRIBUTES_UPDATE = 3,
    }
    
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("UserSessionId", "mUserSessionId", 0xCE5A6400, TdfType.UInt32, 0, true), // SEID
        new TdfMemberInfo("UpdateReason", "mUpdateReason", 0xD70CA500, TdfType.Enum, 1, true), // UPRE
        new TdfMemberInfo("UserId", "mUserId", 0xD73A6400, TdfType.UInt32, 2, true), // USID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _userSessionId = new(__typeInfos[0]);
    private TdfEnum<Blaze2SDK.Blaze.Rooms.RoomCategoryReplicationContext.RoomCategoryUpdateReason> _updateReason = new(__typeInfos[1]);
    private TdfUInt32 _userId = new(__typeInfos[2]);

    public RoomCategoryReplicationContext()
    {
        __members = [
            _userSessionId,
            _updateReason,
            _userId,
        ];
    }

    public override Tdf CreateNew() => new RoomCategoryReplicationContext();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "RoomCategoryReplicationContext";
    public override string GetFullClassName() => "Blaze::Rooms::RoomCategoryReplicationContext";

    public uint UserSessionId
    {
        get => _userSessionId.Value;
        set => _userSessionId.Value = value;
    }

    public Blaze2SDK.Blaze.Rooms.RoomCategoryReplicationContext.RoomCategoryUpdateReason UpdateReason
    {
        get => _updateReason.Value;
        set => _updateReason.Value = value;
    }

    public uint UserId
    {
        get => _userId.Value;
        set => _userId.Value = value;
    }

}

