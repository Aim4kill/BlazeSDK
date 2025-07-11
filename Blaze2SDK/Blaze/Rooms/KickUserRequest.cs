using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Rooms;

public class KickUserRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("BanUser", "mBanUser", 0x8A1BB500, TdfType.Bool, 0, true), // BANU
        new TdfMemberInfo("UserId", "mUserId", 0xB62A6400, TdfType.UInt32, 1, true), // MBID
        new TdfMemberInfo("RoomId", "mRoomId", 0xCADA6400, TdfType.UInt32, 2, true), // RMID
    ];
    private ITdfMember[] __members;

    private TdfBool _banUser = new(__typeInfos[0]);
    private TdfUInt32 _userId = new(__typeInfos[1]);
    private TdfUInt32 _roomId = new(__typeInfos[2]);

    public KickUserRequest()
    {
        __members = [
            _banUser,
            _userId,
            _roomId,
        ];
    }

    public override Tdf CreateNew() => new KickUserRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "KickUserRequest";
    public override string GetFullClassName() => "Blaze::Rooms::KickUserRequest";

    public bool BanUser
    {
        get => _banUser.Value;
        set => _banUser.Value = value;
    }

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

