using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rsp;

public class UpdatePurchaseRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("PurchaseId", "mPurchaseId", 0xC2990000, TdfType.UInt32, 0, true), // PID
        new TdfMemberInfo("Quantity", "mQuantity", 0xC7586E00, TdfType.UInt32, 1, true), // QUAN
        new TdfMemberInfo("Status", "mStatus", 0xCF487400, TdfType.Enum, 2, true), // STAT
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _purchaseId = new(__typeInfos[0]);
    private TdfUInt32 _quantity = new(__typeInfos[1]);
    private TdfEnum<Blaze3SDK.Blaze.Rsp.PurchaseStatus> _status = new(__typeInfos[2]);

    public UpdatePurchaseRequest()
    {
        __members = [
            _purchaseId,
            _quantity,
            _status,
        ];
    }

    public override Tdf CreateNew() => new UpdatePurchaseRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpdatePurchaseRequest";
    public override string GetFullClassName() => "Blaze::Rsp::UpdatePurchaseRequest";

    public uint PurchaseId
    {
        get => _purchaseId.Value;
        set => _purchaseId.Value = value;
    }

    public uint Quantity
    {
        get => _quantity.Value;
        set => _quantity.Value = value;
    }

    public Blaze3SDK.Blaze.Rsp.PurchaseStatus Status
    {
        get => _status.Value;
        set => _status.Value = value;
    }

}

