using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Clubs;

public class CountMessagesRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClubId", "mClubId", 0x8ECA6400, TdfType.UInt32, 0, true), // CLID
        new TdfMemberInfo("MessageType", "mMessageType", 0xB73D3900, TdfType.Enum, 1, true), // MSTY
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _clubId = new(__typeInfos[0]);
    private TdfEnum<Blaze3SDK.Blaze.Clubs.MessageType> _messageType = new(__typeInfos[1]);

    public CountMessagesRequest()
    {
        __members = [
            _clubId,
            _messageType,
        ];
    }

    public override Tdf CreateNew() => new CountMessagesRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "CountMessagesRequest";
    public override string GetFullClassName() => "Blaze::Clubs::CountMessagesRequest";

    public uint ClubId
    {
        get => _clubId.Value;
        set => _clubId.Value = value;
    }

    public Blaze3SDK.Blaze.Clubs.MessageType MessageType
    {
        get => _messageType.Value;
        set => _messageType.Value = value;
    }

}

