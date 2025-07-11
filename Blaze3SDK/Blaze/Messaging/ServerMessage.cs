using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Messaging;

public class ServerMessage : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Flags", "mFlags", 0x9AC86700, TdfType.Enum, 0, true), // FLAG
        new TdfMemberInfo("MessageId", "mMessageId", 0xB67A6400, TdfType.UInt32, 1, true), // MGID
        new TdfMemberInfo("SourceName", "mSourceName", 0xBA1B6500, TdfType.String, 2, true), // NAME
        new TdfMemberInfo("Payload", "mPayload", 0xC39B2400, TdfType.Struct, 3, true), // PYLD
        new TdfMemberInfo("Source", "mSource", 0xCF28E500, TdfType.ObjectId, 4, true), // SRCE
        new TdfMemberInfo("Timestamp", "mTimestamp", 0xD29B6500, TdfType.UInt32, 5, true), // TIME
    ];
    private ITdfMember[] __members;

    private TdfEnum<Blaze3SDK.Blaze.Messaging.ServerFlags> _flags = new(__typeInfos[0]);
    private TdfUInt32 _messageId = new(__typeInfos[1]);
    private TdfString _sourceName = new(__typeInfos[2]);
    private TdfStruct<Blaze3SDK.Blaze.Messaging.ClientMessage?> _payload = new(__typeInfos[3]);
    private TdfObjectId _source = new(__typeInfos[4]);
    private TdfUInt32 _timestamp = new(__typeInfos[5]);

    public ServerMessage()
    {
        __members = [
            _flags,
            _messageId,
            _sourceName,
            _payload,
            _source,
            _timestamp,
        ];
    }

    public override Tdf CreateNew() => new ServerMessage();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ServerMessage";
    public override string GetFullClassName() => "Blaze::Messaging::ServerMessage";

    public Blaze3SDK.Blaze.Messaging.ServerFlags Flags
    {
        get => _flags.Value;
        set => _flags.Value = value;
    }

    public uint MessageId
    {
        get => _messageId.Value;
        set => _messageId.Value = value;
    }

    public string SourceName
    {
        get => _sourceName.Value;
        set => _sourceName.Value = value;
    }

    public Blaze3SDK.Blaze.Messaging.ClientMessage? Payload
    {
        get => _payload.Value;
        set => _payload.Value = value;
    }

    public ObjectId Source
    {
        get => _source.Value;
        set => _source.Value = value;
    }

    public uint Timestamp
    {
        get => _timestamp.Value;
        set => _timestamp.Value = value;
    }

}

