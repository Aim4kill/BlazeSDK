using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rooms;

public class UnbanUserRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("RoomId", "mRoomId", 0xCADA6400, TdfType.UInt32, 0, true), // RMID
        new TdfMemberInfo("UserId", "mUserId", 0xD73A6400, TdfType.Int64, 1, true), // USID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _roomId = new(__typeInfos[0]);
    private TdfInt64 _userId = new(__typeInfos[1]);

    public UnbanUserRequest()
    {
        __members = [
            _roomId,
            _userId,
        ];
    }

    public override Tdf CreateNew() => new UnbanUserRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UnbanUserRequest";
    public override string GetFullClassName() => "Blaze::Rooms::UnbanUserRequest";

    public uint RoomId
    {
        get => _roomId.Value;
        set => _roomId.Value = value;
    }

    public long UserId
    {
        get => _userId.Value;
        set => _userId.Value = value;
    }

}

