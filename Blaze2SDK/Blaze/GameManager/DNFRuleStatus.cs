using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class DNFRuleStatus : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MyDNFValue", "mMyDNFValue", 0xB64BA600, TdfType.Int32, 0, true), // MDNF
        new TdfMemberInfo("MaxDNFValue", "mMaxDNFValue", 0xE24BA600, TdfType.Int32, 1, true), // XDNF
    ];
    private ITdfMember[] __members;

    private TdfInt32 _myDNFValue = new(__typeInfos[0]);
    private TdfInt32 _maxDNFValue = new(__typeInfos[1]);

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

    public int MyDNFValue
    {
        get => _myDNFValue.Value;
        set => _myDNFValue.Value = value;
    }

    public int MaxDNFValue
    {
        get => _maxDNFValue.Value;
        set => _maxDNFValue.Value = value;
    }

}

