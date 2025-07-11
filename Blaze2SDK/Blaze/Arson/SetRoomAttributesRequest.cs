using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Arson;

public class SetRoomAttributesRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Attributes", "mAttributes", 0x874D3200, TdfType.Map, 0, true), // ATTR
        new TdfMemberInfo("roomId", "roomId", 0xCA990000, TdfType.UInt32, 1, true), // RID
    ];
    private ITdfMember[] __members;

    private TdfMap<string, string> _attributes = new(__typeInfos[0]);
    private TdfUInt32 _roomId = new(__typeInfos[1]);

    public SetRoomAttributesRequest()
    {
        __members = [
            _attributes,
            _roomId,
        ];
    }

    public override Tdf CreateNew() => new SetRoomAttributesRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "SetRoomAttributesRequest";
    public override string GetFullClassName() => "Blaze::Arson::SetRoomAttributesRequest";

    public IDictionary<string, string> Attributes
    {
        get => _attributes.Value;
        set => _attributes.Value = value;
    }

    public uint roomId
    {
        get => _roomId.Value;
        set => _roomId.Value = value;
    }

}

