using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.League;

public class NewsItem : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Creator", "mCreator", 0x8F296100, TdfType.Struct, 0, true), // CREA
        new TdfMemberInfo("Format", "mFormat", 0x9ADD0000, TdfType.Enum, 1, true), // FMT
        new TdfMemberInfo("News", "mNews", 0xBA5DF300, TdfType.String, 2, true), // NEWS
        new TdfMemberInfo("MsgType", "mMsgType", 0xBB4E7000, TdfType.Enum, 3, true), // NTYP
        new TdfMemberInfo("NewsId", "mNewsId", 0xBB7A6400, TdfType.UInt32, 4, true), // NWID
        new TdfMemberInfo("Params", "mParams", 0xC21CAD00, TdfType.List, 5, true), // PARM
        new TdfMemberInfo("CreationTime", "mCreationTime", 0xD29B6500, TdfType.UInt32, 6, true), // TIME
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze2SDK.Blaze.League.LeagueUser?> _creator = new(__typeInfos[0]);
    private TdfEnum<Blaze2SDK.Blaze.League.NewsFormat> _format = new(__typeInfos[1]);
    private TdfString _news = new(__typeInfos[2]);
    private TdfEnum<Blaze2SDK.Blaze.League.NewsMsgType> _msgType = new(__typeInfos[3]);
    private TdfUInt32 _newsId = new(__typeInfos[4]);
    private TdfList<Blaze2SDK.Blaze.League.NewsItemParam> _params = new(__typeInfos[5]);
    private TdfUInt32 _creationTime = new(__typeInfos[6]);

    public NewsItem()
    {
        __members = [
            _creator,
            _format,
            _news,
            _msgType,
            _newsId,
            _params,
            _creationTime,
        ];
    }

    public override Tdf CreateNew() => new NewsItem();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NewsItem";
    public override string GetFullClassName() => "Blaze::League::NewsItem";

    public Blaze2SDK.Blaze.League.LeagueUser? Creator
    {
        get => _creator.Value;
        set => _creator.Value = value;
    }

    public Blaze2SDK.Blaze.League.NewsFormat Format
    {
        get => _format.Value;
        set => _format.Value = value;
    }

    public string News
    {
        get => _news.Value;
        set => _news.Value = value;
    }

    public Blaze2SDK.Blaze.League.NewsMsgType MsgType
    {
        get => _msgType.Value;
        set => _msgType.Value = value;
    }

    public uint NewsId
    {
        get => _newsId.Value;
        set => _newsId.Value = value;
    }

    public IList<Blaze2SDK.Blaze.League.NewsItemParam> Params
    {
        get => _params.Value;
        set => _params.Value = value;
    }

    public uint CreationTime
    {
        get => _creationTime.Value;
        set => _creationTime.Value = value;
    }

}

