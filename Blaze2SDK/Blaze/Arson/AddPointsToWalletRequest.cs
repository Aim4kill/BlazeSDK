using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Arson;

public class AddPointsToWalletRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Amount", "mAmount", 0x86DD0000, TdfType.UInt32, 0, true), // AMT
        new TdfMemberInfo("WalletName", "mWalletName", 0xDEEB4000, TdfType.String, 1, true), // WNM
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _amount = new(__typeInfos[0]);
    private TdfString _walletName = new(__typeInfos[1]);

    public AddPointsToWalletRequest()
    {
        __members = [
            _amount,
            _walletName,
        ];
    }

    public override Tdf CreateNew() => new AddPointsToWalletRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "AddPointsToWalletRequest";
    public override string GetFullClassName() => "Blaze::Arson::AddPointsToWalletRequest";

    public uint Amount
    {
        get => _amount.Value;
        set => _amount.Value = value;
    }

    public string WalletName
    {
        get => _walletName.Value;
        set => _walletName.Value = value;
    }

}

