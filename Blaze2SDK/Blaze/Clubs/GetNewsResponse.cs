using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Clubs;

public class GetNewsResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("LocalizedNewsList", "mLocalizedNewsList", 0xBB7B2900, TdfType.List, 0, true), // NWLI
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze2SDK.Blaze.Clubs.ClubLocalizedNews> _localizedNewsList = new(__typeInfos[0]);

    public GetNewsResponse()
    {
        __members = [
            _localizedNewsList,
        ];
    }

    public override Tdf CreateNew() => new GetNewsResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetNewsResponse";
    public override string GetFullClassName() => "Blaze::Clubs::GetNewsResponse";

    public IList<Blaze2SDK.Blaze.Clubs.ClubLocalizedNews> LocalizedNewsList
    {
        get => _localizedNewsList.Value;
        set => _localizedNewsList.Value = value;
    }

}

