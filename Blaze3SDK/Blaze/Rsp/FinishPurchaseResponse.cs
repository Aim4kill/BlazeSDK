using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rsp;

public class FinishPurchaseResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ExpirationDate", "mExpirationDate", 0x921D2500, TdfType.TimeValue, 0, true), // DATE
        new TdfMemberInfo("Quantity", "mQuantity", 0xC7586E00, TdfType.UInt32, 1, true), // QUAN
        new TdfMemberInfo("ServerId", "mServerId", 0xCE990000, TdfType.UInt32, 2, true), // SID
    ];
    private ITdfMember[] __members;

    private TdfTimeValue _expirationDate = new(__typeInfos[0]);
    private TdfUInt32 _quantity = new(__typeInfos[1]);
    private TdfUInt32 _serverId = new(__typeInfos[2]);

    public FinishPurchaseResponse()
    {
        __members = [
            _expirationDate,
            _quantity,
            _serverId,
        ];
    }

    public override Tdf CreateNew() => new FinishPurchaseResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "FinishPurchaseResponse";
    public override string GetFullClassName() => "Blaze::Rsp::FinishPurchaseResponse";

    public TimeValue ExpirationDate
    {
        get => _expirationDate.Value;
        set => _expirationDate.Value = value;
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

}

