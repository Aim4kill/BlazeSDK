using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rsp;

public class StartPurchaseResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("PurchaseId", "mPurchaseId", 0xC2990000, TdfType.UInt32, 0, true), // PID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _purchaseId = new(__typeInfos[0]);

    public StartPurchaseResponse()
    {
        __members = [
            _purchaseId,
        ];
    }

    public override Tdf CreateNew() => new StartPurchaseResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "StartPurchaseResponse";
    public override string GetFullClassName() => "Blaze::Rsp::StartPurchaseResponse";

    public uint PurchaseId
    {
        get => _purchaseId.Value;
        set => _purchaseId.Value = value;
    }

}

