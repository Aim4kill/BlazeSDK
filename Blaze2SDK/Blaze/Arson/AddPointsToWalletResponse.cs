using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Arson;

public class AddPointsToWalletResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("WalletBalance", "mWalletBalance", 0xDE2B0000, TdfType.Struct, 0, true), // WBL
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze2SDK.Blaze.CommerceInfo.WalletBalance?> _walletBalance = new(__typeInfos[0]);

    public AddPointsToWalletResponse()
    {
        __members = [
            _walletBalance,
        ];
    }

    public override Tdf CreateNew() => new AddPointsToWalletResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "AddPointsToWalletResponse";
    public override string GetFullClassName() => "Blaze::Arson::AddPointsToWalletResponse";

    public Blaze2SDK.Blaze.CommerceInfo.WalletBalance? WalletBalance
    {
        get => _walletBalance.Value;
        set => _walletBalance.Value = value;
    }

}

