using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Rooms;

public class RoomAttributesSet : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("RoomAttributes", "mRoomAttributes", 0x874D3200, TdfType.Map, 0, true), // ATTR
        new TdfMemberInfo("RoomId", "mRoomId", 0xCADA6400, TdfType.UInt32, 1, true), // RMID
    ];
    private ITdfMember[] __members;

    private TdfMap<string, string> _roomAttributes = new(__typeInfos[0]);
    private TdfUInt32 _roomId = new(__typeInfos[1]);

    public RoomAttributesSet()
    {
        __members = [
            _roomAttributes,
            _roomId,
        ];
    }

    public override Tdf CreateNew() => new RoomAttributesSet();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "RoomAttributesSet";
    public override string GetFullClassName() => "Blaze::Rooms::RoomAttributesSet";

    public IDictionary<string, string> RoomAttributes
    {
        get => _roomAttributes.Value;
        set => _roomAttributes.Value = value;
    }

    public uint RoomId
    {
        get => _roomId.Value;
        set => _roomId.Value = value;
    }

}

