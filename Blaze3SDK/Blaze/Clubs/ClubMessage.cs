using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Clubs;

public class ClubMessage : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClubId", "mClubId", 0x8ECA6400, TdfType.UInt32, 0, true), // CLID
        new TdfMemberInfo("ClubName", "mClubName", 0x8ECBAD00, TdfType.String, 1, true), // CLNM
        new TdfMemberInfo("MessageId", "mMessageId", 0xA6EA6400, TdfType.UInt32, 2, true), // INID
        new TdfMemberInfo("MessageType", "mMessageType", 0xA6EDB400, TdfType.Enum, 3, true), // INVT
        new TdfMemberInfo("ReceiverId", "mReceiverId", 0xCA58F600, TdfType.Int64, 4, true), // RECV
        new TdfMemberInfo("ReceiverPersona", "mReceiverPersona", 0xCB0CB300, TdfType.String, 5, true), // RPRS
        new TdfMemberInfo("SenderId", "mSenderId", 0xCE5BA400, TdfType.Int64, 6, true), // SEND
        new TdfMemberInfo("SenderPersona", "mSenderPersona", 0xCF0CB300, TdfType.String, 7, true), // SPRS
        new TdfMemberInfo("TimeSent", "mTimeSent", 0xD29B6500, TdfType.UInt32, 8, true), // TIME
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _clubId = new(__typeInfos[0]);
    private TdfString _clubName = new(__typeInfos[1]);
    private TdfUInt32 _messageId = new(__typeInfos[2]);
    private TdfEnum<Blaze3SDK.Blaze.Clubs.MessageType> _messageType = new(__typeInfos[3]);
    private TdfInt64 _receiverId = new(__typeInfos[4]);
    private TdfString _receiverPersona = new(__typeInfos[5]);
    private TdfInt64 _senderId = new(__typeInfos[6]);
    private TdfString _senderPersona = new(__typeInfos[7]);
    private TdfUInt32 _timeSent = new(__typeInfos[8]);

    public ClubMessage()
    {
        __members = [
            _clubId,
            _clubName,
            _messageId,
            _messageType,
            _receiverId,
            _receiverPersona,
            _senderId,
            _senderPersona,
            _timeSent,
        ];
    }

    public override Tdf CreateNew() => new ClubMessage();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ClubMessage";
    public override string GetFullClassName() => "Blaze::Clubs::ClubMessage";

    public uint ClubId
    {
        get => _clubId.Value;
        set => _clubId.Value = value;
    }

    public string ClubName
    {
        get => _clubName.Value;
        set => _clubName.Value = value;
    }

    public uint MessageId
    {
        get => _messageId.Value;
        set => _messageId.Value = value;
    }

    public Blaze3SDK.Blaze.Clubs.MessageType MessageType
    {
        get => _messageType.Value;
        set => _messageType.Value = value;
    }

    public long ReceiverId
    {
        get => _receiverId.Value;
        set => _receiverId.Value = value;
    }

    public string ReceiverPersona
    {
        get => _receiverPersona.Value;
        set => _receiverPersona.Value = value;
    }

    public long SenderId
    {
        get => _senderId.Value;
        set => _senderId.Value = value;
    }

    public string SenderPersona
    {
        get => _senderPersona.Value;
        set => _senderPersona.Value = value;
    }

    public uint TimeSent
    {
        get => _timeSent.Value;
        set => _timeSent.Value = value;
    }

}

