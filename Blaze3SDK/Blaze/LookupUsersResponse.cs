using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze;

public class LookupUsersResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("UserIdentificationList", "mUserIdentificationList", 0xD6CCF400, TdfType.List, 0, true), // ULST
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze3SDK.Blaze.UserIdentification> _userIdentificationList = new(__typeInfos[0]);

    public LookupUsersResponse()
    {
        __members = [
            _userIdentificationList,
        ];
    }

    public override Tdf CreateNew() => new LookupUsersResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "LookupUsersResponse";
    public override string GetFullClassName() => "Blaze::LookupUsersResponse";

    public IList<Blaze3SDK.Blaze.UserIdentification> UserIdentificationList
    {
        get => _userIdentificationList.Value;
        set => _userIdentificationList.Value = value;
    }

}

