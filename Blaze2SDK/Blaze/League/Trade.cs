using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.League;

public class Trade : Tdf
{
    public enum TradeOp : int
    {
        TRADE_ACCEPT = 0,
        TRADE_REJECT = 1,
        TRADE_REVOKE = 2,
    }
    
    public enum TradeType : int
    {
        LEAGUE_TRADES_NONE = 0,
        LEAGUE_TRADES_SIMPLE = 1,
        LEAGUE_TRADES_RESTRICTED = 2,
    }
    
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CreationTime", "mCreationTime", 0x8F2D2D00, TdfType.UInt32, 0, true), // CRTM
        new TdfMemberInfo("Originator", "mOriginator", 0x9AFCAD00, TdfType.Struct, 1, true), // FORM
        new TdfMemberInfo("OriginatorPlayerId", "mOriginatorPlayerId", 0x9AFCB000, TdfType.UInt32, 2, true), // FORP
        new TdfMemberInfo("RecipientPlayerId", "mRecipientPlayerId", 0xB21D3000, TdfType.UInt32, 3, true), // LATP
        new TdfMemberInfo("Recipient", "mRecipient", 0xB21D3400, TdfType.Struct, 4, true), // LATT
        new TdfMemberInfo("LeagueId", "mLeagueId", 0xB27A6400, TdfType.UInt32, 5, true), // LGID
        new TdfMemberInfo("TradeId", "mTradeId", 0xD24A6400, TdfType.UInt32, 6, true), // TDID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _creationTime = new(__typeInfos[0]);
    private TdfStruct<Blaze2SDK.Blaze.League.LeagueUser?> _originator = new(__typeInfos[1]);
    private TdfUInt32 _originatorPlayerId = new(__typeInfos[2]);
    private TdfUInt32 _recipientPlayerId = new(__typeInfos[3]);
    private TdfStruct<Blaze2SDK.Blaze.League.LeagueUser?> _recipient = new(__typeInfos[4]);
    private TdfUInt32 _leagueId = new(__typeInfos[5]);
    private TdfUInt32 _tradeId = new(__typeInfos[6]);

    public Trade()
    {
        __members = [
            _creationTime,
            _originator,
            _originatorPlayerId,
            _recipientPlayerId,
            _recipient,
            _leagueId,
            _tradeId,
        ];
    }

    public override Tdf CreateNew() => new Trade();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "Trade";
    public override string GetFullClassName() => "Blaze::League::Trade";

    public uint CreationTime
    {
        get => _creationTime.Value;
        set => _creationTime.Value = value;
    }

    public Blaze2SDK.Blaze.League.LeagueUser? Originator
    {
        get => _originator.Value;
        set => _originator.Value = value;
    }

    public uint OriginatorPlayerId
    {
        get => _originatorPlayerId.Value;
        set => _originatorPlayerId.Value = value;
    }

    public uint RecipientPlayerId
    {
        get => _recipientPlayerId.Value;
        set => _recipientPlayerId.Value = value;
    }

    public Blaze2SDK.Blaze.League.LeagueUser? Recipient
    {
        get => _recipient.Value;
        set => _recipient.Value = value;
    }

    public uint LeagueId
    {
        get => _leagueId.Value;
        set => _leagueId.Value = value;
    }

    public uint TradeId
    {
        get => _tradeId.Value;
        set => _tradeId.Value = value;
    }

}

