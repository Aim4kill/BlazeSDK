using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Clubs;

public class GetClubMembershipForUsersRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("BlazeIdList", "mBlazeIdList", 0xA64B3400, TdfType.List, 0, true), // IDLT
    ];
    private ITdfMember[] __members;

    private TdfList<uint> _blazeIdList = new(__typeInfos[0]);

    public GetClubMembershipForUsersRequest()
    {
        __members = [
            _blazeIdList,
        ];
    }

    public override Tdf CreateNew() => new GetClubMembershipForUsersRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetClubMembershipForUsersRequest";
    public override string GetFullClassName() => "Blaze::Clubs::GetClubMembershipForUsersRequest";

    public IList<uint> BlazeIdList
    {
        get => _blazeIdList.Value;
        set => _blazeIdList.Value = value;
    }

}

