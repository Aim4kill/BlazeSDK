using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.CommerceInfo;

public class WalletBalance : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Balance", "mBalance", 0xDE286C00, TdfType.String, 0, true), // WBAL
        new TdfMemberInfo("Currency", "mCurrency", 0xDEC8F200, TdfType.String, 1, true), // WLCR
    ];
    private ITdfMember[] __members;

    private TdfString _balance = new(__typeInfos[0]);
    private TdfString _currency = new(__typeInfos[1]);

    public WalletBalance()
    {
        __members = [
            _balance,
            _currency,
        ];
    }

    public override Tdf CreateNew() => new WalletBalance();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "WalletBalance";
    public override string GetFullClassName() => "Blaze::CommerceInfo::WalletBalance";

    public string Balance
    {
        get => _balance.Value;
        set => _balance.Value = value;
    }

    public string Currency
    {
        get => _currency.Value;
        set => _currency.Value = value;
    }

}

