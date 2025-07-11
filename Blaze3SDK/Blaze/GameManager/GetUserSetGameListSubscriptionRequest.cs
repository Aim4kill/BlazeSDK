using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class GetUserSetGameListSubscriptionRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("UserSetId", "mUserSetId", 0xD73A6400, TdfType.ObjectId, 0, true), // USID
    ];
    private ITdfMember[] __members;

    private TdfObjectId _userSetId = new(__typeInfos[0]);

    public GetUserSetGameListSubscriptionRequest()
    {
        __members = [
            _userSetId,
        ];
    }

    public override Tdf CreateNew() => new GetUserSetGameListSubscriptionRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetUserSetGameListSubscriptionRequest";
    public override string GetFullClassName() => "Blaze::GameManager::GetUserSetGameListSubscriptionRequest";

    public ObjectId UserSetId
    {
        get => _userSetId.Value;
        set => _userSetId.Value = value;
    }

}

