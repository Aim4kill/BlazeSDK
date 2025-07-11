using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Clubs;

public class SetClubTickerMessagesSubscriptionRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClubId", "mClubId", 0x8ECA6400, TdfType.UInt32, 0, true), // CLID
        new TdfMemberInfo("IsSubscribed", "mIsSubscribed", 0xA73CF500, TdfType.Bool, 1, true), // ISSU
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _clubId = new(__typeInfos[0]);
    private TdfBool _isSubscribed = new(__typeInfos[1]);

    public SetClubTickerMessagesSubscriptionRequest()
    {
        __members = [
            _clubId,
            _isSubscribed,
        ];
    }

    public override Tdf CreateNew() => new SetClubTickerMessagesSubscriptionRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "SetClubTickerMessagesSubscriptionRequest";
    public override string GetFullClassName() => "Blaze::Clubs::SetClubTickerMessagesSubscriptionRequest";

    public uint ClubId
    {
        get => _clubId.Value;
        set => _clubId.Value = value;
    }

    public bool IsSubscribed
    {
        get => _isSubscribed.Value;
        set => _isSubscribed.Value = value;
    }

}

