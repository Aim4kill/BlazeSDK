using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rsp;

public class Purchase : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ConsumableId", "mConsumableId", 0x8E990000, TdfType.UInt32, 0, true), // CID
        new TdfMemberInfo("PurchaseId", "mPurchaseId", 0xC2990000, TdfType.UInt32, 1, true), // PID
        new TdfMemberInfo("Quantity", "mQuantity", 0xC7586E00, TdfType.UInt32, 2, true), // QUAN
        new TdfMemberInfo("ServerId", "mServerId", 0xCE990000, TdfType.UInt32, 3, true), // SID
        new TdfMemberInfo("PingSiteAlias", "mPingSiteAlias", 0xCE9D2500, TdfType.String, 4, true), // SITE
        new TdfMemberInfo("Status", "mStatus", 0xCF487400, TdfType.Enum, 5, true), // STAT
        new TdfMemberInfo("UserId", "mUserId", 0xD6990000, TdfType.Int64, 6, true), // UID
        new TdfMemberInfo("UpdatedDate", "mUpdatedDate", 0xD7092100, TdfType.TimeValue, 7, true), // UPDA
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _consumableId = new(__typeInfos[0]);
    private TdfUInt32 _purchaseId = new(__typeInfos[1]);
    private TdfUInt32 _quantity = new(__typeInfos[2]);
    private TdfUInt32 _serverId = new(__typeInfos[3]);
    private TdfString _pingSiteAlias = new(__typeInfos[4]);
    private TdfEnum<Blaze3SDK.Blaze.Rsp.PurchaseStatus> _status = new(__typeInfos[5]);
    private TdfInt64 _userId = new(__typeInfos[6]);
    private TdfTimeValue _updatedDate = new(__typeInfos[7]);

    public Purchase()
    {
        __members = [
            _consumableId,
            _purchaseId,
            _quantity,
            _serverId,
            _pingSiteAlias,
            _status,
            _userId,
            _updatedDate,
        ];
    }

    public override Tdf CreateNew() => new Purchase();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "Purchase";
    public override string GetFullClassName() => "Blaze::Rsp::Purchase";

    public uint ConsumableId
    {
        get => _consumableId.Value;
        set => _consumableId.Value = value;
    }

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

    public uint ServerId
    {
        get => _serverId.Value;
        set => _serverId.Value = value;
    }

    public string PingSiteAlias
    {
        get => _pingSiteAlias.Value;
        set => _pingSiteAlias.Value = value;
    }

    public Blaze3SDK.Blaze.Rsp.PurchaseStatus Status
    {
        get => _status.Value;
        set => _status.Value = value;
    }

    public long UserId
    {
        get => _userId.Value;
        set => _userId.Value = value;
    }

    public TimeValue UpdatedDate
    {
        get => _updatedDate.Value;
        set => _updatedDate.Value = value;
    }

}

