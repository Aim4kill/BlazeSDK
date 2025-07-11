using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Authentication;

public class GetLegalDocsInfoResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("EaMayContact", "mEaMayContact", 0x961B6300, TdfType.UInt32, 0, true), // EAMC
        new TdfMemberInfo("LegalDocHost", "mLegalDocHost", 0xB28CF400, TdfType.String, 1, true), // LHST
        new TdfMemberInfo("PartnersMayContact", "mPartnersMayContact", 0xC2D8C000, TdfType.UInt32, 2, true), // PMC
        new TdfMemberInfo("PrivacyPolicyUri", "mPrivacyPolicyUri", 0xC30D6900, TdfType.String, 3, true), // PPUI
        new TdfMemberInfo("TermsOfServiceUri", "mTermsOfServiceUri", 0xD33D6900, TdfType.String, 4, true), // TSUI
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _eaMayContact = new(__typeInfos[0]);
    private TdfString _legalDocHost = new(__typeInfos[1]);
    private TdfUInt32 _partnersMayContact = new(__typeInfos[2]);
    private TdfString _privacyPolicyUri = new(__typeInfos[3]);
    private TdfString _termsOfServiceUri = new(__typeInfos[4]);

    public GetLegalDocsInfoResponse()
    {
        __members = [
            _eaMayContact,
            _legalDocHost,
            _partnersMayContact,
            _privacyPolicyUri,
            _termsOfServiceUri,
        ];
    }

    public override Tdf CreateNew() => new GetLegalDocsInfoResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetLegalDocsInfoResponse";
    public override string GetFullClassName() => "Blaze::Authentication::GetLegalDocsInfoResponse";

    public uint EaMayContact
    {
        get => _eaMayContact.Value;
        set => _eaMayContact.Value = value;
    }

    public string LegalDocHost
    {
        get => _legalDocHost.Value;
        set => _legalDocHost.Value = value;
    }

    public uint PartnersMayContact
    {
        get => _partnersMayContact.Value;
        set => _partnersMayContact.Value = value;
    }

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

