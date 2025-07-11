using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Rooms;

public class RoomRemoved : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("RoomId", "mRoomId", 0xCADA6400, TdfType.UInt32, 0, true), // RMID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _roomId = new(__typeInfos[0]);

    public RoomRemoved()
    {
        __members = [
            _roomId,
        ];
    }

    public override Tdf CreateNew() => new RoomRemoved();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "RoomRemoved";
    public override string GetFullClassName() => "Blaze::Rooms::RoomRemoved";

    public uint RoomId
    {
        get => _roomId.Value;
        set => _roomId.Value = value;
    }

}

