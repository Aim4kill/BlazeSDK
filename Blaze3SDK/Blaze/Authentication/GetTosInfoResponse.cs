using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Authentication;

public class GetTosInfoResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("EaMayContact", "mEaMayContact", 0x961B6300, TdfType.UInt32, 0, true), // EAMC
        new TdfMemberInfo("PartnersMayContact", "mPartnersMayContact", 0xC2D8C000, TdfType.UInt32, 1, true), // PMC
        new TdfMemberInfo("PrivacyPolicyUri", "mPrivacyPolicyUri", 0xC32A7600, TdfType.String, 2, true), // PRIV
        new TdfMemberInfo("TosHost", "mTosHost", 0xD28CF400, TdfType.String, 3, true), // THST
        new TdfMemberInfo("TosUri", "mTosUri", 0xD35CA900, TdfType.String, 4, true), // TURI
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _eaMayContact = new(__typeInfos[0]);
    private TdfUInt32 _partnersMayContact = new(__typeInfos[1]);
    private TdfString _privacyPolicyUri = new(__typeInfos[2]);
    private TdfString _tosHost = new(__typeInfos[3]);
    private TdfString _tosUri = new(__typeInfos[4]);

    public GetTosInfoResponse()
    {
        __members = [
            _eaMayContact,
            _partnersMayContact,
            _privacyPolicyUri,
            _tosHost,
            _tosUri,
        ];
    }

    public override Tdf CreateNew() => new GetTosInfoResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetTosInfoResponse";
    public override string GetFullClassName() => "Blaze::Authentication::GetTosInfoResponse";

    public uint EaMayContact
    {
        get => _eaMayContact.Value;
        set => _eaMayContact.Value = value;
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

    public string TosHost
    {
        get => _tosHost.Value;
        set => _tosHost.Value = value;
    }

    public string TosUri
    {
        get => _tosUri.Value;
        set => _tosUri.Value = value;
    }

}

