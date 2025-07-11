using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.League;

public class GetNewsRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("FirstItem", "mFirstItem", 0x9B2CF400, TdfType.UInt16, 0, true), // FRST
        new TdfMemberInfo("LeagueId", "mLeagueId", 0xB27A6400, TdfType.UInt32, 1, true), // LGID
        new TdfMemberInfo("Locale", "mLocale", 0xB2F8C000, TdfType.UInt32, 2, true), // LOC
        new TdfMemberInfo("MsgType", "mMsgType", 0xBB4E7000, TdfType.Enum, 3, true), // NTYP
        new TdfMemberInfo("NumItems", "mNumItems", 0xBB5B4000, TdfType.UInt16, 4, true), // NUM
    ];
    private ITdfMember[] __members;

    private TdfUInt16 _firstItem = new(__typeInfos[0]);
    private TdfUInt32 _leagueId = new(__typeInfos[1]);
    private TdfUInt32 _locale = new(__typeInfos[2]);
    private TdfEnum<Blaze2SDK.Blaze.League.NewsMsgType> _msgType = new(__typeInfos[3]);
    private TdfUInt16 _numItems = new(__typeInfos[4]);

    public GetNewsRequest()
    {
        __members = [
            _firstItem,
            _leagueId,
            _locale,
            _msgType,
            _numItems,
        ];
    }

    public override Tdf CreateNew() => new GetNewsRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetNewsRequest";
    public override string GetFullClassName() => "Blaze::League::GetNewsRequest";

    public ushort FirstItem
    {
        get => _firstItem.Value;
        set => _firstItem.Value = value;
    }

    public uint LeagueId
    {
        get => _leagueId.Value;
        set => _leagueId.Value = value;
    }

    public uint Locale
    {
        get => _locale.Value;
        set => _locale.Value = value;
    }

    public Blaze2SDK.Blaze.League.NewsMsgType MsgType
    {
        get => _msgType.Value;
        set => _msgType.Value = value;
    }

    public ushort NumItems
    {
        get => _numItems.Value;
        set => _numItems.Value = value;
    }

}

