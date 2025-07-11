using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Rooms;

public class LookupRoomDataList : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("RoomDataList", "mRoomDataList", 0xCADCEC00, TdfType.List, 0, true), // RMSL
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze2SDK.Blaze.Rooms.RoomData> _roomDataList = new(__typeInfos[0]);

    public LookupRoomDataList()
    {
        __members = [
            _roomDataList,
        ];
    }

    public override Tdf CreateNew() => new LookupRoomDataList();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "LookupRoomDataList";
    public override string GetFullClassName() => "Blaze::Rooms::LookupRoomDataList";

    public IList<Blaze2SDK.Blaze.Rooms.RoomData> RoomDataList
    {
        get => _roomDataList.Value;
        set => _roomDataList.Value = value;
    }

}

