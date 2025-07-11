using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Authentication;

public class Entitlements : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Entitlements", "mEntitlements", 0xBACCF400, TdfType.List, 0, true), // NLST
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze3SDK.Blaze.Authentication.Entitlement> _entitlements = new(__typeInfos[0]);

    public Entitlements()
    {
        __members = [
            _entitlements,
        ];
    }

    public override Tdf CreateNew() => new Entitlements();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "Entitlements";
    public override string GetFullClassName() => "Blaze::Authentication::Entitlements";

    public IList<Blaze3SDK.Blaze.Authentication.Entitlement> mEntitlements
    {
        get => _entitlements.Value;
        set => _entitlements.Value = value;
    }

}

