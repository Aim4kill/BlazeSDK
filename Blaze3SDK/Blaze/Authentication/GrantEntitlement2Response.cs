using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Authentication;

public class GrantEntitlement2Response : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("EntitlementInfo", "mEntitlementInfo", 0x96ED2900, TdfType.Struct, 0, true), // ENTI
        new TdfMemberInfo("IsGranted", "mIsGranted", 0xA739F200, TdfType.Bool, 1, true), // ISGR
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze3SDK.Blaze.Authentication.Entitlement?> _entitlementInfo = new(__typeInfos[0]);
    private TdfBool _isGranted = new(__typeInfos[1]);

    public GrantEntitlement2Response()
    {
        __members = [
            _entitlementInfo,
            _isGranted,
        ];
    }

    public override Tdf CreateNew() => new GrantEntitlement2Response();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GrantEntitlement2Response";
    public override string GetFullClassName() => "Blaze::Authentication::GrantEntitlement2Response";

    public Blaze3SDK.Blaze.Authentication.Entitlement? EntitlementInfo
    {
        get => _entitlementInfo.Value;
        set => _entitlementInfo.Value = value;
    }

    public bool IsGranted
    {
        get => _isGranted.Value;
        set => _isGranted.Value = value;
    }

}

