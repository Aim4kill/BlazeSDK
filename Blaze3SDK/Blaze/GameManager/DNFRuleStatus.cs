using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class DNFRuleStatus : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MyDNFValue", "mMyDNFValue", 0xB64BA600, TdfType.Int64, 0, true), // MDNF
        new TdfMemberInfo("MaxDNFValue", "mMaxDNFValue", 0xE24BA600, TdfType.Int64, 1, true), // XDNF
    ];
    private ITdfMember[] __members;

    private TdfInt64 _myDNFValue = new(__typeInfos[0]);
    private TdfInt64 _maxDNFValue = new(__typeInfos[1]);

    public DNFRuleStatus()
    {
        __members = [
            _myDNFValue,
            _maxDNFValue,
        ];
    }

    public override Tdf CreateNew() => new DNFRuleStatus();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "DNFRuleStatus";
    public override string GetFullClassName() => "Blaze::GameManager::DNFRuleStatus";

    public long MyDNFValue
    {
        get => _myDNFValue.Value;
        set => _myDNFValue.Value = value;
    }

    public long MaxDNFValue
    {
        get => _maxDNFValue.Value;
        set => _maxDNFValue.Value = value;
    }

}

