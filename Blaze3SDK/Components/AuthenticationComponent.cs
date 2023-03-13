using Blaze3SDK.Blaze;
using Blaze3SDK.Blaze.Authentication;
using BlazeCommon;
using static Blaze3SDK.Components.AuthenticationComponent;

namespace Blaze3SDK.Components
{
    public class AuthenticationComponent : ComponentData<AuthenticationComponentCommand, AuthenticationComponentNotification, AuthenticationComponentError>
    {
        public AuthenticationComponent() : base((ushort)Component.AuthenticationComponent)
        {

        }

        public override Type GetCommandErrorResponseType(AuthenticationComponentCommand command)
        {
            throw new NotImplementedException();
        }

        public override Type GetCommandRequestType(AuthenticationComponentCommand command) => command switch
        {
            AuthenticationComponentCommand.createPersona => typeof(CreatePersonaRequest),
            AuthenticationComponentCommand.getAccount => typeof(NullStruct),
            AuthenticationComponentCommand.login => typeof(LoginRequest),
            AuthenticationComponentCommand.loginPersona => typeof(LoginPersonaRequest),
            AuthenticationComponentCommand.ps3Login => typeof(PS3LoginRequest),
            AuthenticationComponentCommand.checkSinglePlayerLogin => typeof(NullStruct), //todo: check if the request actually contains some data
            AuthenticationComponentCommand.silentLogin => typeof(SilentLoginRequest),
            _ => throw new NotImplementedException()
        };
        

        public override Type GetCommandResponseType(AuthenticationComponentCommand command) => command switch
        {
            AuthenticationComponentCommand.silentLogin => typeof(FullLoginResponse),
            AuthenticationComponentCommand.createAccount => throw new NotImplementedException(),
            AuthenticationComponentCommand.updateAccount => throw new NotImplementedException(),
            AuthenticationComponentCommand.updateParentalEmail => throw new NotImplementedException(),
            AuthenticationComponentCommand.listUserEntitlements2 => throw new NotImplementedException(),
            AuthenticationComponentCommand.getAccount => throw new NotImplementedException(),
            AuthenticationComponentCommand.grantEntitlement => throw new NotImplementedException(),
            AuthenticationComponentCommand.listEntitlements => throw new NotImplementedException(),
            AuthenticationComponentCommand.hasEntitlement => throw new NotImplementedException(),
            AuthenticationComponentCommand.getUseCount => throw new NotImplementedException(),
            AuthenticationComponentCommand.decrementUseCount => throw new NotImplementedException(),
            AuthenticationComponentCommand.getAuthToken => throw new NotImplementedException(),
            AuthenticationComponentCommand.getHandoffToken => throw new NotImplementedException(),
            AuthenticationComponentCommand.getPasswordRules => throw new NotImplementedException(),
            AuthenticationComponentCommand.grantEntitlement2 => throw new NotImplementedException(),
            AuthenticationComponentCommand.login => throw new NotImplementedException(),
            AuthenticationComponentCommand.acceptTos => throw new NotImplementedException(),
            AuthenticationComponentCommand.getTosInfo => throw new NotImplementedException(),
            AuthenticationComponentCommand.modifyEntitlement2 => throw new NotImplementedException(),
            AuthenticationComponentCommand.consumecode => throw new NotImplementedException(),
            AuthenticationComponentCommand.passwordForgot => throw new NotImplementedException(),
            AuthenticationComponentCommand.getTermsAndConditionsContent => throw new NotImplementedException(),
            AuthenticationComponentCommand.getPrivacyPolicyContent => throw new NotImplementedException(),
            AuthenticationComponentCommand.listPersonaEntitlements2 => throw new NotImplementedException(),
            AuthenticationComponentCommand.checkAgeReq => throw new NotImplementedException(),
            AuthenticationComponentCommand.getOptIn => throw new NotImplementedException(),
            AuthenticationComponentCommand.enableOptIn => throw new NotImplementedException(),
            AuthenticationComponentCommand.disableOptIn => throw new NotImplementedException(),
            AuthenticationComponentCommand.expressLogin => throw new NotImplementedException(),
            AuthenticationComponentCommand.logout => throw new NotImplementedException(),
            AuthenticationComponentCommand.createPersona => throw new NotImplementedException(),
            AuthenticationComponentCommand.getPersona => throw new NotImplementedException(),
            AuthenticationComponentCommand.listPersonas => throw new NotImplementedException(),
            AuthenticationComponentCommand.loginPersona => throw new NotImplementedException(),
            AuthenticationComponentCommand.logoutPersona => throw new NotImplementedException(),
            AuthenticationComponentCommand.deletePersona => throw new NotImplementedException(),
            AuthenticationComponentCommand.disablePersona => throw new NotImplementedException(),
            AuthenticationComponentCommand.listDeviceAccounts => throw new NotImplementedException(),
            AuthenticationComponentCommand.xboxCreateAccount => throw new NotImplementedException(),
            AuthenticationComponentCommand.originLogin => throw new NotImplementedException(),
            AuthenticationComponentCommand.xboxAssociateAccount => throw new NotImplementedException(),
            AuthenticationComponentCommand.xboxLogin => throw new NotImplementedException(),
            AuthenticationComponentCommand.ps3CreateAccount => throw new NotImplementedException(),
            AuthenticationComponentCommand.ps3AssociateAccount => throw new NotImplementedException(),
            AuthenticationComponentCommand.ps3Login => throw new NotImplementedException(),
            AuthenticationComponentCommand.validateSessionKey => throw new NotImplementedException(),
            AuthenticationComponentCommand.createWalUserSession => throw new NotImplementedException(),
            AuthenticationComponentCommand.acceptLegalDocs => throw new NotImplementedException(),
            AuthenticationComponentCommand.getLegalDocsInfo => throw new NotImplementedException(),
            AuthenticationComponentCommand.getTermsOfServiceContent => throw new NotImplementedException(),
            AuthenticationComponentCommand.deviceLoginGuest => throw new NotImplementedException(),
            AuthenticationComponentCommand.checkSinglePlayerLogin => throw new NotImplementedException(),
            _ => throw new NotImplementedException()
        };
        

        public override Type GetNotificationType(AuthenticationComponentNotification notification) => notification switch
        {
            _ => throw new NotImplementedException(),
        };
        

        public enum AuthenticationComponentCommand : ushort
        {
            createAccount = 10,
            updateAccount = 20,
            updateParentalEmail = 28,
            listUserEntitlements2,
            getAccount,
            grantEntitlement,
            listEntitlements,
            hasEntitlement,
            getUseCount,
            decrementUseCount,
            getAuthToken,
            getHandoffToken,
            getPasswordRules,
            grantEntitlement2,
            login,
            acceptTos,
            getTosInfo,
            modifyEntitlement2,
            consumecode,
            passwordForgot,
            getTermsAndConditionsContent,
            getPrivacyPolicyContent,
            listPersonaEntitlements2,
            silentLogin = 50,
            checkAgeReq,
            getOptIn,
            enableOptIn,
            disableOptIn,
            expressLogin = 60,
            logout = 70,
            createPersona = 80,
            getPersona = 90,
            listPersonas = 100,
            loginPersona = 110,
            logoutPersona = 120,
            deletePersona = 140,
            disablePersona,
            listDeviceAccounts = 143,
            xboxCreateAccount = 150,
            originLogin = 152,
            xboxAssociateAccount = 160,
            xboxLogin = 170,
            ps3CreateAccount = 180,
            ps3AssociateAccount = 190,
            ps3Login = 200,
            validateSessionKey = 210,
            createWalUserSession = 230,
            acceptLegalDocs = 241,
            getLegalDocsInfo,
            getTermsOfServiceContent = 246,
            deviceLoginGuest = 300,
            checkSinglePlayerLogin = 500,
        }

        public enum AuthenticationComponentNotification : ushort
        {

        }

        public enum AuthenticationComponentError
        {
            AUTH_ERR_GROUPNAME_REQUIRED = 4587521,
            AUTH_ERR_ENTITLEMENT_OTHER = 4456449,
            AUTH_ERR_ENTITLEMETNTAG_EMPTY = 4390913,
            AUTH_ERR_DEVICE_ID_ALREADY_USED = 4259841,
            AUTH_ERR_USECOUNT_ZERO = 4325377,
            AUTH_ERR_GROUP_NAME_DOES_NOT_MATCH = 4194305,
            AUTH_ERR_NO_SUCH_ENTITLEMENT = 4128769,
            AUTH_ERR_NO_SUCH_GROUP = 3997697,
            AUTH_ERR_WHITELIST = 3866625,
            AUTH_ERR_LINK_PERSONA = 3932161,
            AUTH_ERR_USER_DOES_NOT_MATCH_PERSONA = 3801089,
            AUTH_ERR_MISSING_PERSONAID = 3735553,
            AUTH_ERR_NO_SUCH_GROUP_NAME = 3670017,
            AUTH_ERR_NO_ASSOCIATED_PRODUCT = 3538945,
            AUTH_ERR_INVALID_MAPPING_ERROR = 3604481,
            AUTH_ERR_CODE_ALREADY_DISABLED = 3473409,
            AUTH_ERR_CODE_ALREADY_USED = 3342337,
            AUTH_ERR_INVALID_CODE = 3407873,
            AUTH_ERR_NEED_PCCDKEY = 3276801,
            AUTH_ERR_BANNED = 2818049,
            AUTH_ERR_DISABLED = 2883585,
            AUTH_ERR_PENDING = 2752513,
            AUTH_ERR_DEACTIVATED = 2686977,
            AUTH_ERR_INV_MASTER = 2621441,
            AUTH_ERR_INVALID_PERSONA = 2162689,
            AUTH_ERR_CURRENT_PASSWORD_REQUIRED = 2228225,
            AUTH_ERR_PERSONA_BANNED = 2097153,
            AUTH_ERR_INVALID_STATUS = 1507329,
            AUTH_ERR_INVALID_SESSION_KEY = 2031617,
            AUTH_ERR_INVALID_EMAIL = 1441793,
            AUTH_ERR_INVALID_PMAIL = 1310721,
            AUTH_ERR_INVALID_FIELD = 1376257,
            AUTH_ERR_PERSONA_INACTIVE = 1245185,
            AUTH_ERR_PERSONA_NOT_FOUND = 1179649,
            AUTH_ERR_NO_ACCOUNT = 1114113,
            AUTH_ERR_EXISTS = 983041,
            AUTH_ERR_TOO_YOUNG = 1048577,
            AUTH_ERR_EXPIRED_TOKEN = 917505,
            AUTH_ERR_INVALID_PASSWORD = 786433,
            AUTH_ERR_INVALID_TOKEN = 851969,
            AUTH_ERR_INVALID_USER = 720897,
            AUTH_ERR_TOS_REQUIRED = 131073,
            AUTH_ERR_INVALID_COUNTRY = 655361,
            AUTH_ERR_EXTERNAL_AUTH_EXISTS = 6029313,
            AUTH_ERR_NO_SUCH_PERSONA_REFERENCE = 5963777,
            AUTH_ERR_PARAMETER_TOO_LENGTH = 5898241,
            AUTH_ERR_APPLICATION_REQUIRED = 5767169,
            AUTH_ERR_TOKEN_REQUIRED = 5832705,
            AUTH_ERR_SOURCE_REQUIRED = 5701633,
            AUTH_ERR_AUTHID_REQUIRED = 5570561,
            AUTH_ERR_PERSONA_EXTREFID_REQUIRED = 5636097,
            AUTH_ERR_NO_SUCH_OPTIN = 5505025,
            AUTH_ERR_INVALID_OPTIN = 5373953,
            AUTH_ERR_OPTIN_MISMATCH = 5439489,
            AUTH_ERR_OPTIN_NAME_REQUIRED = 5308417,
            AUTH_ERR_EXCEED_PSU_LIMIT_TRIAL = 5242881,
            AUTH_ERR_UNKNOWN_ENTITLEMENT = 5177345,
            AUTH_ERR_USECOUNT_INCREMENT = 5046273,
            AUTH_ERR_TERMINATION_INVALID = 5111809,
            AUTH_ERR_MODIFIED_STATUS_INVALID = 4980737,
            AUTH_ERR_ENTITLEMENT_TAG_REQUIRED = 4849665,
            AUTH_ERR_PAGENO_ZERO = 4915201,
            AUTH_ERR_PAGESIZE_ZERO = 4784129,
            AUTH_ERR_GROUPNAME_INVALID = 4653057,
            AUTH_ERR_PAGESIZE_TOO_BIG = 4718593,
            AUTH_ERR_FIELD_TOO_LONG = 13303809,
            AUTH_ERR_FIELD_TOO_SHORT = 13238273,
            AUTH_ERR_FIELD_INVALID_CHARS = 13172737,
            AUTH_ERR_INVALID_NAMESPACE = 6881281,
            AUTH_ERR_EXPIRED_PS3_TICKET = 6946817,
            AUTH_ERR_INVALID_PS3_TICKET = 6815745,
            AUTH_ERR_UNEXPECTED_ACTIVATION = 6684673,
            AUTH_ERR_NAME_MISMATCH = 6750209,
            AUTH_ERR_USER_INACTIVE = 6619137,
            AUTH_ERR_INVALID_SOURCE = 6094849,
            AUTH_ERR_NO_SUCH_AUTH_DATA = 6160385,
            AUTH_ERR_FIELD_NEEDS_SPECIAL_CHARS = 13631489,
            AUTH_ERR_FIELD_NOT_ALLOWED = 13565953,
            AUTH_ERR_FIELD_INVALID = 13500417,
            AUTH_ERR_FIELD_MUST_BEGIN_WITH_LETTER = 13369345,
            AUTH_ERR_FIELD_MISSING = 13434881,
            AUTH_ERR_FIELD_TOO_YOUNG = 13828097,
            AUTH_ERR_FIELD_ALREADY_EXISTS = 13697025,
            AUTH_ERR_FIELD_NEEDS_CONSENT = 13762561,
            AUTH_ERR_TOO_MANY_PERSONA_FOR_NAMESPACE = 0x12C0001,
        }
    }
}
