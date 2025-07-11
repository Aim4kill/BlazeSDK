using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Authentication;

public class AcceptLegalDocsRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("PrivacyPolicyUri", "mPrivacyPolicyUri", 0xC32A7600, TdfType.String, 0, true), // PRIV
        new TdfMemberInfo("TermsOfServiceUri", "mTermsOfServiceUri", 0xD33D6900, TdfType.String, 1, true), // TSUI
    ];
    private ITdfMember[] __members;

    private TdfString _privacyPolicyUri = new(__typeInfos[0]);
    private TdfString _termsOfServiceUri = new(__typeInfos[1]);

    public AcceptLegalDocsRequest()
    {
        __members = [
            _privacyPolicyUri,
            _termsOfServiceUri,
        ];
    }

    public override Tdf CreateNew() => new AcceptLegalDocsRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "AcceptLegalDocsRequest";
    public override string GetFullClassName() => "Blaze::Authentication::AcceptLegalDocsRequest";

    public string PrivacyPolicyUri
    {
        get => _privacyPolicyUri.Value;
        set => _privacyPolicyUri.Value = value;
    }

    public string TermsOfServiceUri
    {
        get => _termsOfServiceUri.Value;
        set => _termsOfServiceUri.Value = value;
    }

}

