using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Association;

public class SubscriptionInfo : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ListNameVector", "mListNameVector", 0xCF58B200, TdfType.List, 0, true), // SUBR
    ];
    private ITdfMember[] __members;

    private TdfList<string> _listNameVector = new(__typeInfos[0]);

    public SubscriptionInfo()
    {
        __members = [
            _listNameVector,
        ];
    }

    public override Tdf CreateNew() => new SubscriptionInfo();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "SubscriptionInfo";
    public override string GetFullClassName() => "Blaze::Association::SubscriptionInfo";

    public IList<string> ListNameVector
    {
        get => _listNameVector.Value;
        set => _listNameVector.Value = value;
    }

}

