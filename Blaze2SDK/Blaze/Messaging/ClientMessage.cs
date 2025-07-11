using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Messaging;

public class ClientMessage : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AttrMap", "mAttrMap", 0x874D3200, TdfType.Map, 0, true), // ATTR
        new TdfMemberInfo("Flags", "mFlags", 0x9AC86700, TdfType.Enum, 1, true), // FLAG
        new TdfMemberInfo("Status", "mStatus", 0xCF487400, TdfType.UInt32, 2, true), // STAT
        new TdfMemberInfo("Tag", "mTag", 0xD219C000, TdfType.UInt32, 3, true), // TAG
        new TdfMemberInfo("Target", "mTarget", 0xD21CA700, TdfType.UInt64, 4, true), // TARG
        new TdfMemberInfo("Type", "mType", 0xD39C2500, TdfType.UInt32, 5, true), // TYPE
    ];
    private ITdfMember[] __members;

    private TdfMap<uint, string> _attrMap = new(__typeInfos[0]);
    private TdfEnum<Blaze2SDK.Blaze.Messaging.MessageFlags> _flags = new(__typeInfos[1]);
    private TdfUInt32 _status = new(__typeInfos[2]);
    private TdfUInt32 _tag = new(__typeInfos[3]);
    private TdfUInt64 _target = new(__typeInfos[4]);
    private TdfUInt32 _type = new(__typeInfos[5]);

    public ClientMessage()
    {
        __members = [
            _attrMap,
            _flags,
            _status,
            _tag,
            _target,
            _type,
        ];
    }

    public override Tdf CreateNew() => new ClientMessage();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ClientMessage";
    public override string GetFullClassName() => "Blaze::Messaging::ClientMessage";

    public IDictionary<uint, string> AttrMap
    {
        get => _attrMap.Value;
        set => _attrMap.Value = value;
    }

    public Blaze2SDK.Blaze.Messaging.MessageFlags Flags
    {
        get => _flags.Value;
        set => _flags.Value = value;
    }

    public uint Status
    {
        get => _status.Value;
        set => _status.Value = value;
    }

    public uint Tag
    {
        get => _tag.Value;
        set => _tag.Value = value;
    }

    public ulong Target
    {
        get => _target.Value;
        set => _target.Value = value;
    }

    public uint Type
    {
        get => _type.Value;
        set => _type.Value = value;
    }

}

