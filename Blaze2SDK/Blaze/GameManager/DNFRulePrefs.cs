using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class DNFRulePrefs : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MaxDNFValue", "mMaxDNFValue", 0x92E98000, TdfType.Int32, 0, true), // DNF
    ];
    private ITdfMember[] __members;

    private TdfInt32 _maxDNFValue = new(__typeInfos[0]);

    public DNFRulePrefs()
    {
        __members = [
            _maxDNFValue,
        ];
    }

    public override Tdf CreateNew() => new DNFRulePrefs();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "DNFRulePrefs";
    public override string GetFullClassName() => "Blaze::GameManager::DNFRulePrefs";

    public int MaxDNFValue
    {
        get => _maxDNFValue.Value;
        set => _maxDNFValue.Value = value;
    }

}

