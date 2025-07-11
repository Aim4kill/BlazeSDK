using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Messaging;

public class TouchMessageRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Flags", "mFlags", 0x9AC86700, TdfType.Enum, 0, true), // FLAG
        new TdfMemberInfo("MessageId", "mMessageId", 0xB67A6400, TdfType.UInt32, 1, true), // MGID
        new TdfMemberInfo("StatusMask", "mStatusMask", 0xCEDCEB00, TdfType.UInt32, 2, true), // SMSK
        new TdfMemberInfo("Source", "mSource", 0xCF28E500, TdfType.UInt64, 3, true), // SRCE
        new TdfMemberInfo("Status", "mStatus", 0xCF487400, TdfType.UInt32, 4, true), // STAT
        new TdfMemberInfo("Target", "mTarget", 0xD21CA700, TdfType.UInt64, 5, true), // TARG
        new TdfMemberInfo("TouchStatusMask", "mTouchStatusMask", 0xD2DCEB00, TdfType.UInt32, 6, true), // TMSK
        new TdfMemberInfo("TouchStatus", "mTouchStatus", 0xD33D2100, TdfType.UInt32, 7, true), // TSTA
        new TdfMemberInfo("Type", "mType", 0xD39C2500, TdfType.UInt32, 8, true), // TYPE
    ];
    private ITdfMember[] __members;

    private TdfEnum<Blaze2SDK.Blaze.Messaging.MatchFlags> _flags = new(__typeInfos[0]);
    private TdfUInt32 _messageId = new(__typeInfos[1]);
    private TdfUInt32 _statusMask = new(__typeInfos[2]);
    private TdfUInt64 _source = new(__typeInfos[3]);
    private TdfUInt32 _status = new(__typeInfos[4]);
    private TdfUInt64 _target = new(__typeInfos[5]);
    private TdfUInt32 _touchStatusMask = new(__typeInfos[6]);
    private TdfUInt32 _touchStatus = new(__typeInfos[7]);
    private TdfUInt32 _type = new(__typeInfos[8]);

    public TouchMessageRequest()
    {
        __members = [
            _flags,
            _messageId,
            _statusMask,
            _source,
            _status,
            _target,
            _touchStatusMask,
            _touchStatus,
            _type,
        ];
    }

    public override Tdf CreateNew() => new TouchMessageRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "TouchMessageRequest";
    public override string GetFullClassName() => "Blaze::Messaging::TouchMessageRequest";

    public Blaze2SDK.Blaze.Messaging.MatchFlags Flags
    {
        get => _flags.Value;
        set => _flags.Value = value;
    }

    public uint MessageId
    {
        get => _messageId.Value;
        set => _messageId.Value = value;
    }

    public uint StatusMask
    {
        get => _statusMask.Value;
        set => _statusMask.Value = value;
    }

    public ulong Source
    {
        get => _source.Value;
        set => _source.Value = value;
    }

    public uint Status
    {
        get => _status.Value;
        set => _status.Value = value;
    }

    public ulong Target
    {
        get => _target.Value;
        set => _target.Value = value;
    }

    public uint TouchStatusMask
    {
        get => _touchStatusMask.Value;
        set => _touchStatusMask.Value = value;
    }

    public uint TouchStatus
    {
        get => _touchStatus.Value;
        set => _touchStatus.Value = value;
    }

    public uint Type
    {
        get => _type.Value;
        set => _type.Value = value;
    }

}

