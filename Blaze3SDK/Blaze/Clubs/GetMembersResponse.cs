using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Clubs;

public class GetMembersResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClubMemberList", "mClubMemberList", 0x8EDB3300, TdfType.List, 0, true), // CMLS
        new TdfMemberInfo("TotalCount", "mTotalCount", 0xD23BEE00, TdfType.UInt32, 1, true), // TCON
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze3SDK.Blaze.Clubs.ClubMember> _clubMemberList = new(__typeInfos[0]);
    private TdfUInt32 _totalCount = new(__typeInfos[1]);

    public GetMembersResponse()
    {
        __members = [
            _clubMemberList,
            _totalCount,
        ];
    }

    public override Tdf CreateNew() => new GetMembersResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetMembersResponse";
    public override string GetFullClassName() => "Blaze::Clubs::GetMembersResponse";

    public IList<Blaze3SDK.Blaze.Clubs.ClubMember> ClubMemberList
    {
        get => _clubMemberList.Value;
        set => _clubMemberList.Value = value;
    }

    public uint TotalCount
    {
        get => _totalCount.Value;
        set => _totalCount.Value = value;
    }

}

