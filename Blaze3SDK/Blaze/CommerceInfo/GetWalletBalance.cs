using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.CommerceInfo;

public class GetWalletBalance : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("WalletName", "mWalletName", 0xDECBAD00, TdfType.String, 0, true), // WLNM
    ];
    private ITdfMember[] __members;

    private TdfString _walletName = new(__typeInfos[0]);

    public GetWalletBalance()
    {
        __members = [
            _walletName,
        ];
    }

    public override Tdf CreateNew() => new GetWalletBalance();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetWalletBalance";
    public override string GetFullClassName() => "Blaze::CommerceInfo::GetWalletBalance";

    public string WalletName
    {
        get => _walletName.Value;
        set => _walletName.Value = value;
    }

}

