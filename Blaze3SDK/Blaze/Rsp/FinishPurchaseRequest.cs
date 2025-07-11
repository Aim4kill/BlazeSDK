using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rsp;

public class FinishPurchaseRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("PurchaseId", "mPurchaseId", 0xC2990000, TdfType.UInt32, 0, true), // PID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _purchaseId = new(__typeInfos[0]);

    public FinishPurchaseRequest()
    {
        __members = [
            _purchaseId,
        ];
    }

    public override Tdf CreateNew() => new FinishPurchaseRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "FinishPurchaseRequest";
    public override string GetFullClassName() => "Blaze::Rsp::FinishPurchaseRequest";

    public uint PurchaseId
    {
        get => _purchaseId.Value;
        set => _purchaseId.Value = value;
    }

}

