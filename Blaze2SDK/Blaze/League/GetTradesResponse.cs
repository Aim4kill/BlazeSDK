using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.League;

public class GetTradesResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Trades", "mTrades", 0xD32B2900, TdfType.List, 0, true), // TRLI
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze2SDK.Blaze.League.Trade> _trades = new(__typeInfos[0]);

    public GetTradesResponse()
    {
        __members = [
            _trades,
        ];
    }

    public override Tdf CreateNew() => new GetTradesResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetTradesResponse";
    public override string GetFullClassName() => "Blaze::League::GetTradesResponse";

    public IList<Blaze2SDK.Blaze.League.Trade> Trades
    {
        get => _trades.Value;
        set => _trades.Value = value;
    }

}

