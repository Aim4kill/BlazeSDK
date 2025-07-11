using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rooms;

public class SetMemberAttributesRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MemberAttributes", "mMemberAttributes", 0x874D3200, TdfType.Map, 0, true), // ATTR
        new TdfMemberInfo("BlazeId", "mBlazeId", 0x96990000, TdfType.Int64, 1, true), // EID
        new TdfMemberInfo("RoomId", "mRoomId", 0xCADA6400, TdfType.UInt32, 2, true), // RMID
    ];
    private ITdfMember[] __members;

    private TdfMap<string, string> _memberAttributes = new(__typeInfos[0]);
    private TdfInt64 _blazeId = new(__typeInfos[1]);
    private TdfUInt32 _roomId = new(__typeInfos[2]);

    public SetMemberAttributesRequest()
    {
        __members = [
            _memberAttributes,
            _blazeId,
            _roomId,
        ];
    }

    public override Tdf CreateNew() => new SetMemberAttributesRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "SetMemberAttributesRequest";
    public override string GetFullClassName() => "Blaze::Rooms::SetMemberAttributesRequest";

    public IDictionary<string, string> MemberAttributes
    {
        get => _memberAttributes.Value;
        set => _memberAttributes.Value = value;
    }

    public long BlazeId
    {
        get => _blazeId.Value;
        set => _blazeId.Value = value;
    }

    public uint RoomId
    {
        get => _roomId.Value;
        set => _roomId.Value = value;
    }

}

