using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rsp;

public class ListPurchasesRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("IncludeHistory", "mIncludeHistory", 0xA29CF400, TdfType.Bool, 0, true), // HIST
        new TdfMemberInfo("ListCapacity", "mListCapacity", 0xB2387000, TdfType.UInt16, 1, true), // LCAP
        new TdfMemberInfo("UserId", "mUserId", 0xD6990000, TdfType.Int64, 2, true), // UID
    ];
    private ITdfMember[] __members;

    private TdfBool _includeHistory = new(__typeInfos[0]);
    private TdfUInt16 _listCapacity = new(__typeInfos[1]);
    private TdfInt64 _userId = new(__typeInfos[2]);

    public ListPurchasesRequest()
    {
        __members = [
            _includeHistory,
            _listCapacity,
            _userId,
        ];
    }

    public override Tdf CreateNew() => new ListPurchasesRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ListPurchasesRequest";
    public override string GetFullClassName() => "Blaze::Rsp::ListPurchasesRequest";

    public bool IncludeHistory
    {
        get => _includeHistory.Value;
        set => _includeHistory.Value = value;
    }

    public ushort ListCapacity
    {
        get => _listCapacity.Value;
        set => _listCapacity.Value = value;
    }

    public long UserId
    {
        get => _userId.Value;
        set => _userId.Value = value;
    }

}

