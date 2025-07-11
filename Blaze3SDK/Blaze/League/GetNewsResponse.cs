using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.League;

public class GetNewsResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("NewsItems", "mNewsItems", 0xA74B7300, TdfType.List, 0, true), // ITMS
        new TdfMemberInfo("TotalItems", "mTotalItems", 0xD2FD2C00, TdfType.UInt32, 1, true), // TOTL
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze3SDK.Blaze.League.NewsItem> _newsItems = new(__typeInfos[0]);
    private TdfUInt32 _totalItems = new(__typeInfos[1]);

    public GetNewsResponse()
    {
        __members = [
            _newsItems,
            _totalItems,
        ];
    }

    public override Tdf CreateNew() => new GetNewsResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetNewsResponse";
    public override string GetFullClassName() => "Blaze::League::GetNewsResponse";

    public IList<Blaze3SDK.Blaze.League.NewsItem> NewsItems
    {
        get => _newsItems.Value;
        set => _newsItems.Value = value;
    }

    public uint TotalItems
    {
        get => _totalItems.Value;
        set => _totalItems.Value = value;
    }

}

