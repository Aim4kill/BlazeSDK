using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Clubs;

public class GetNewsResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("LocalizedNewsList", "mLocalizedNewsList", 0xBB7B2900, TdfType.List, 0, true), // NWLI
        new TdfMemberInfo("TotalPages", "mTotalPages", 0xD2CC2700, TdfType.UInt16, 1, true), // TLPG
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze3SDK.Blaze.Clubs.ClubLocalizedNews> _localizedNewsList = new(__typeInfos[0]);
    private TdfUInt16 _totalPages = new(__typeInfos[1]);

    public GetNewsResponse()
    {
        __members = [
            _localizedNewsList,
            _totalPages,
        ];
    }

    public override Tdf CreateNew() => new GetNewsResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetNewsResponse";
    public override string GetFullClassName() => "Blaze::Clubs::GetNewsResponse";

    public IList<Blaze3SDK.Blaze.Clubs.ClubLocalizedNews> LocalizedNewsList
    {
        get => _localizedNewsList.Value;
        set => _localizedNewsList.Value = value;
    }

    public ushort TotalPages
    {
        get => _totalPages.Value;
        set => _totalPages.Value = value;
    }

}

