using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rsp;

public class ListPurchasesResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("PurchaseList", "mPurchaseList", 0xC2CCF400, TdfType.List, 0, true), // PLST
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze3SDK.Blaze.Rsp.Purchase> _purchaseList = new(__typeInfos[0]);

    public ListPurchasesResponse()
    {
        __members = [
            _purchaseList,
        ];
    }

    public override Tdf CreateNew() => new ListPurchasesResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ListPurchasesResponse";
    public override string GetFullClassName() => "Blaze::Rsp::ListPurchasesResponse";

    public IList<Blaze3SDK.Blaze.Rsp.Purchase> PurchaseList
    {
        get => _purchaseList.Value;
        set => _purchaseList.Value = value;
    }

}

