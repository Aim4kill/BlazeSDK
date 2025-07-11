using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Clubs;

public class GetClubsRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClubIdList", "mClubIdList", 0x8ECA6400, TdfType.List, 0, true), // CLID
    ];
    private ITdfMember[] __members;

    private TdfList<uint> _clubIdList = new(__typeInfos[0]);

    public GetClubsRequest()
    {
        __members = [
            _clubIdList,
        ];
    }

    public override Tdf CreateNew() => new GetClubsRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetClubsRequest";
    public override string GetFullClassName() => "Blaze::Clubs::GetClubsRequest";

    public IList<uint> ClubIdList
    {
        get => _clubIdList.Value;
        set => _clubIdList.Value = value;
    }

}

