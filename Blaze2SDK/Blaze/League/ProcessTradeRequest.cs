using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.League;

public class ProcessTradeRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("LeagueId", "mLeagueId", 0xB27A6400, TdfType.UInt32, 0, true), // LGID
        new TdfMemberInfo("Operation", "mOperation", 0xCF487400, TdfType.Enum, 1, true), // STAT
        new TdfMemberInfo("TradeId", "mTradeId", 0xD24A6400, TdfType.UInt32, 2, true), // TDID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _leagueId = new(__typeInfos[0]);
    private TdfEnum<Blaze2SDK.Blaze.League.TradeOp> _operation = new(__typeInfos[1]);
    private TdfUInt32 _tradeId = new(__typeInfos[2]);

    public ProcessTradeRequest()
    {
        __members = [
            _leagueId,
            _operation,
            _tradeId,
        ];
    }

    public override Tdf CreateNew() => new ProcessTradeRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ProcessTradeRequest";
    public override string GetFullClassName() => "Blaze::League::ProcessTradeRequest";

    public uint LeagueId
    {
        get => _leagueId.Value;
        set => _leagueId.Value = value;
    }

    public Blaze2SDK.Blaze.League.TradeOp Operation
    {
        get => _operation.Value;
        set => _operation.Value = value;
    }

    public uint TradeId
    {
        get => _tradeId.Value;
        set => _tradeId.Value = value;
    }

}

