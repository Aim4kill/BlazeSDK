using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rooms;

public class LookupRoomDataRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("RoomIdList", "mRoomIdList", 0xCADA6400, TdfType.List, 0, true), // RMID
    ];
    private ITdfMember[] __members;

    private TdfList<uint> _roomIdList = new(__typeInfos[0]);

    public LookupRoomDataRequest()
    {
        __members = [
            _roomIdList,
        ];
    }

    public override Tdf CreateNew() => new LookupRoomDataRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "LookupRoomDataRequest";
    public override string GetFullClassName() => "Blaze::Rooms::LookupRoomDataRequest";

    public IList<uint> RoomIdList
    {
        get => _roomIdList.Value;
        set => _roomIdList.Value = value;
    }

}

