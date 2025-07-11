using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Util;

public class PreAuthResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AnonymousChildAccountsEnabled", "mAnonymousChildAccountsEnabled", 0x86EBEE00, TdfType.Bool, 0, true), // ANON
        new TdfMemberInfo("AuthenticationSource", "mAuthenticationSource", 0x873CA300, TdfType.String, 1, true), // ASRC
        new TdfMemberInfo("ComponentIds", "mComponentIds", 0x8E993300, TdfType.List, 2, true), // CIDS
        new TdfMemberInfo("ParentalConsentEntitlementGroupName", "mParentalConsentEntitlementGroupName", 0x8EE9EE00, TdfType.String, 3, true), // CNGN
        new TdfMemberInfo("Config", "mConfig", 0x8EFBA600, TdfType.Struct, 4, true), // CONF
        new TdfMemberInfo("InstanceName", "mInstanceName", 0xA6ECF400, TdfType.String, 5, true), // INST
        new TdfMemberInfo("UnderageSupported", "mUnderageSupported", 0xB69BB200, TdfType.Bool, 6, true), // MINR
        new TdfMemberInfo("PersonaNamespace", "mPersonaNamespace", 0xBA1CF000, TdfType.String, 7, true), // NASP
        new TdfMemberInfo("LegalDocGameIdentifier", "mLegalDocGameIdentifier", 0xC29B2400, TdfType.String, 8, true), // PILD
        new TdfMemberInfo("Platform", "mPlatform", 0xC2C87400, TdfType.String, 9, true), // PLAT
        new TdfMemberInfo("ParentalConsentEntitlementTag", "mParentalConsentEntitlementTag", 0xC3486700, TdfType.String, 10, true), // PTAG
        new TdfMemberInfo("QosSettings", "mQosSettings", 0xC6FCF300, TdfType.Struct, 11, true), // QOSS
        new TdfMemberInfo("RegistrationSource", "mRegistrationSource", 0xCB3CA300, TdfType.String, 12, true), // RSRC
        new TdfMemberInfo("ServerVersion", "mServerVersion", 0xCF697200, TdfType.String, 13, true), // SVER
    ];
    private ITdfMember[] __members;

    private TdfBool _anonymousChildAccountsEnabled = new(__typeInfos[0]);
    private TdfString _authenticationSource = new(__typeInfos[1]);
    private TdfList<ushort> _componentIds = new(__typeInfos[2]);
    private TdfString _parentalConsentEntitlementGroupName = new(__typeInfos[3]);
    private TdfStruct<Blaze3SDK.Blaze.Util.FetchConfigResponse?> _config = new(__typeInfos[4]);
    private TdfString _instanceName = new(__typeInfos[5]);
    private TdfBool _underageSupported = new(__typeInfos[6]);
    private TdfString _personaNamespace = new(__typeInfos[7]);
    private TdfString _legalDocGameIdentifier = new(__typeInfos[8]);
    private TdfString _platform = new(__typeInfos[9]);
    private TdfString _parentalConsentEntitlementTag = new(__typeInfos[10]);
    private TdfStruct<Blaze3SDK.Blaze.QosConfigInfo?> _qosSettings = new(__typeInfos[11]);
    private TdfString _registrationSource = new(__typeInfos[12]);
    private TdfString _serverVersion = new(__typeInfos[13]);

    public PreAuthResponse()
    {
        __members = [
            _anonymousChildAccountsEnabled,
            _authenticationSource,
            _componentIds,
            _parentalConsentEntitlementGroupName,
            _config,
            _instanceName,
            _underageSupported,
            _personaNamespace,
            _legalDocGameIdentifier,
            _platform,
            _parentalConsentEntitlementTag,
            _qosSettings,
            _registrationSource,
            _serverVersion,
        ];
    }

    public override Tdf CreateNew() => new PreAuthResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PreAuthResponse";
    public override string GetFullClassName() => "Blaze::Util::PreAuthResponse";

    public bool AnonymousChildAccountsEnabled
    {
        get => _anonymousChildAccountsEnabled.Value;
        set => _anonymousChildAccountsEnabled.Value = value;
    }

    public string AuthenticationSource
    {
        get => _authenticationSource.Value;
        set => _authenticationSource.Value = value;
    }

    public IList<ushort> ComponentIds
    {
        get => _componentIds.Value;
        set => _componentIds.Value = value;
    }

    public string ParentalConsentEntitlementGroupName
    {
        get => _parentalConsentEntitlementGroupName.Value;
        set => _parentalConsentEntitlementGroupName.Value = value;
    }

    public Blaze3SDK.Blaze.Util.FetchConfigResponse? Config
    {
        get => _config.Value;
        set => _config.Value = value;
    }

    public string InstanceName
    {
        get => _instanceName.Value;
        set => _instanceName.Value = value;
    }

    public bool UnderageSupported
    {
        get => _underageSupported.Value;
        set => _underageSupported.Value = value;
    }

    public string PersonaNamespace
    {
        get => _personaNamespace.Value;
        set => _personaNamespace.Value = value;
    }

    public string LegalDocGameIdentifier
    {
        get => _legalDocGameIdentifier.Value;
        set => _legalDocGameIdentifier.Value = value;
    }

    public string Platform
    {
        get => _platform.Value;
        set => _platform.Value = value;
    }

    public string ParentalConsentEntitlementTag
    {
        get => _parentalConsentEntitlementTag.Value;
        set => _parentalConsentEntitlementTag.Value = value;
    }

    public Blaze3SDK.Blaze.QosConfigInfo? QosSettings
    {
        get => _qosSettings.Value;
        set => _qosSettings.Value = value;
    }

    public string RegistrationSource
    {
        get => _registrationSource.Value;
        set => _registrationSource.Value = value;
    }

    public string ServerVersion
    {
        get => _serverVersion.Value;
        set => _serverVersion.Value = value;
    }

}

