using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Clubs;

public class GetMembersResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClubMemberList", "mClubMemberList", 0x8EDB3300, TdfType.List, 0, true), // CMLS
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze2SDK.Blaze.Clubs.ClubMember> _clubMemberList = new(__typeInfos[0]);

    public GetMembersResponse()
    {
        __members = [
            _clubMemberList,
        ];
    }

    public override Tdf CreateNew() => new GetMembersResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetMembersResponse";
    public override string GetFullClassName() => "Blaze::Clubs::GetMembersResponse";

    public IList<Blaze2SDK.Blaze.Clubs.ClubMember> ClubMemberList
    {
        get => _clubMemberList.Value;
        set => _clubMemberList.Value = value;
    }

}

