using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.League;

public class PostNewsRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Format", "mFormat", 0x9B2B7400, TdfType.Enum, 0, true), // FRMT
        new TdfMemberInfo("LeagueId", "mLeagueId", 0xB27A6400, TdfType.UInt32, 1, true), // LGID
        new TdfMemberInfo("News", "mNews", 0xBA5DF300, TdfType.String, 2, true), // NEWS
        new TdfMemberInfo("MsgType", "mMsgType", 0xBB4E7000, TdfType.Enum, 3, true), // NTYP
    ];
    private ITdfMember[] __members;

    private TdfEnum<Blaze2SDK.Blaze.League.NewsFormat> _format = new(__typeInfos[0]);
    private TdfUInt32 _leagueId = new(__typeInfos[1]);
    private TdfString _news = new(__typeInfos[2]);
    private TdfEnum<Blaze2SDK.Blaze.League.NewsMsgType> _msgType = new(__typeInfos[3]);

    public PostNewsRequest()
    {
        __members = [
            _format,
            _leagueId,
            _news,
            _msgType,
        ];
    }

    public override Tdf CreateNew() => new PostNewsRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PostNewsRequest";
    public override string GetFullClassName() => "Blaze::League::PostNewsRequest";

    public Blaze2SDK.Blaze.League.NewsFormat Format
    {
        get => _format.Value;
        set => _format.Value = value;
    }

    public uint LeagueId
    {
        get => _leagueId.Value;
        set => _leagueId.Value = value;
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

}

