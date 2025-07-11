using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Arson;

public class GetRoomAttributesRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("RoomId", "mRoomId", 0xCA990000, TdfType.UInt32, 0, true), // RID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _roomId = new(__typeInfos[0]);

    public GetRoomAttributesRequest()
    {
        __members = [
            _roomId,
        ];
    }

    public override Tdf CreateNew() => new GetRoomAttributesRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetRoomAttributesRequest";
    public override string GetFullClassName() => "Blaze::Arson::GetRoomAttributesRequest";

    public uint RoomId
    {
        get => _roomId.Value;
        set => _roomId.Value = value;
    }

}

