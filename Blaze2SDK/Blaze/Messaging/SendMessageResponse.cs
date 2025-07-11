using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Messaging;

public class SendMessageResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MessageId", "mMessageId", 0xB67A6400, TdfType.UInt32, 0, true), // MGID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _messageId = new(__typeInfos[0]);

    public SendMessageResponse()
    {
        __members = [
            _messageId,
        ];
    }

    public override Tdf CreateNew() => new SendMessageResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "SendMessageResponse";
    public override string GetFullClassName() => "Blaze::Messaging::SendMessageResponse";

    public uint MessageId
    {
        get => _messageId.Value;
        set => _messageId.Value = value;
    }

}

