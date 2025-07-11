using Blaze.Core;
using Blaze3SDK.Blaze.Authentication;
using EATDF;
using EATDF.Types;

namespace Blaze3SDK.Components;

public static class AuthenticationComponentBase
{
    public const ushort Id = 1;
    public const string Name = "AuthenticationComponent";
    
    public enum Error : ushort {
        AUTH_ERR_TOS_REQUIRED = 2,
        AUTH_ERR_INVALID_COUNTRY = 10,
        AUTH_ERR_INVALID_USER = 11,
        AUTH_ERR_INVALID_PASSWORD = 12,
        AUTH_ERR_INVALID_TOKEN = 13,
        AUTH_ERR_EXPIRED_TOKEN = 14,
        AUTH_ERR_EXISTS = 15,
        AUTH_ERR_TOO_YOUNG = 16,
        AUTH_ERR_NO_ACCOUNT = 17,
        AUTH_ERR_PERSONA_NOT_FOUND = 18,
        AUTH_ERR_PERSONA_INACTIVE = 19,
        AUTH_ERR_INVALID_PMAIL = 20,
        AUTH_ERR_INVALID_FIELD = 21,
        AUTH_ERR_INVALID_EMAIL = 22,
        AUTH_ERR_INVALID_STATUS = 23,
        AUTH_ERR_INVALID_SESSION_KEY = 31,
        AUTH_ERR_PERSONA_BANNED = 32,
        AUTH_ERR_INVALID_PERSONA = 33,
        AUTH_ERR_CURRENT_PASSWORD_REQUIRED = 34,
        AUTH_ERR_INV_MASTER = 40,
        AUTH_ERR_DEACTIVATED = 41,
        AUTH_ERR_PENDING = 42,
        AUTH_ERR_BANNED = 43,
        AUTH_ERR_DISABLED = 44,
        AUTH_ERR_NEED_PCCDKEY = 50,
        AUTH_ERR_CODE_ALREADY_USED = 51,
        AUTH_ERR_INVALID_CODE = 52,
        AUTH_ERR_CODE_ALREADY_DISABLED = 53,
        AUTH_ERR_NO_ASSOCIATED_PRODUCT = 54,
        AUTH_ERR_INVALID_MAPPING_ERROR = 55,
        AUTH_ERR_NO_SUCH_GROUP_NAME = 56,
        AUTH_ERR_MISSING_PERSONAID = 57,
        AUTH_ERR_USER_DOES_NOT_MATCH_PERSONA = 58,
        AUTH_ERR_WHITELIST = 59,
        AUTH_ERR_LINK_PERSONA = 60,
        AUTH_ERR_NO_SUCH_GROUP = 61,
        AUTH_ERR_NO_SUCH_ENTITLEMENT = 63,
        AUTH_ERR_GROUP_NAME_DOES_NOT_MATCH = 64,
        AUTH_ERR_DEVICE_ID_ALREADY_USED = 65,
        AUTH_ERR_USECOUNT_ZERO = 66,
        AUTH_ERR_ENTITLEMETNTAG_EMPTY = 67,
        AUTH_ERR_ENTITLEMENT_OTHER = 68,
        AUTH_ERR_GROUPNAME_REQUIRED = 70,
        AUTH_ERR_GROUPNAME_INVALID = 71,
        AUTH_ERR_PAGESIZE_TOO_BIG = 72,
        AUTH_ERR_PAGESIZE_ZERO = 73,
        AUTH_ERR_ENTITLEMENT_TAG_REQUIRED = 74,
        AUTH_ERR_PAGENO_ZERO = 75,
        AUTH_ERR_MODIFIED_STATUS_INVALID = 76,
        AUTH_ERR_USECOUNT_INCREMENT = 77,
        AUTH_ERR_TERMINATION_INVALID = 78,
        AUTH_ERR_UNKNOWN_ENTITLEMENT = 79,
        AUTH_ERR_EXCEED_PSU_LIMIT_TRIAL = 80,
        AUTH_ERR_OPTIN_NAME_REQUIRED = 81,
        AUTH_ERR_INVALID_OPTIN = 82,
        AUTH_ERR_OPTIN_MISMATCH = 83,
        AUTH_ERR_NO_SUCH_OPTIN = 84,
        AUTH_ERR_AUTHID_REQUIRED = 85,
        AUTH_ERR_PERSONA_EXTREFID_REQUIRED = 86,
        AUTH_ERR_SOURCE_REQUIRED = 87,
        AUTH_ERR_APPLICATION_REQUIRED = 88,
        AUTH_ERR_TOKEN_REQUIRED = 89,
        AUTH_ERR_PARAMETER_TOO_LENGTH = 90,
        AUTH_ERR_NO_SUCH_PERSONA_REFERENCE = 91,
        AUTH_ERR_EXTERNAL_AUTH_EXISTS = 92,
        AUTH_ERR_INVALID_SOURCE = 93,
        AUTH_ERR_NO_SUCH_AUTH_DATA = 94,
        AUTH_ERR_USER_INACTIVE = 101,
        AUTH_ERR_UNEXPECTED_ACTIVATION = 102,
        AUTH_ERR_NAME_MISMATCH = 103,
        AUTH_ERR_INVALID_PS3_TICKET = 104,
        AUTH_ERR_INVALID_NAMESPACE = 105,
        AUTH_ERR_EXPIRED_PS3_TICKET = 106,
        AUTH_ERR_FIELD_INVALID_CHARS = 201,
        AUTH_ERR_FIELD_TOO_SHORT = 202,
        AUTH_ERR_FIELD_TOO_LONG = 203,
        AUTH_ERR_FIELD_MUST_BEGIN_WITH_LETTER = 204,
        AUTH_ERR_FIELD_MISSING = 205,
        AUTH_ERR_FIELD_INVALID = 206,
        AUTH_ERR_FIELD_NOT_ALLOWED = 207,
        AUTH_ERR_FIELD_NEEDS_SPECIAL_CHARS = 208,
        AUTH_ERR_FIELD_ALREADY_EXISTS = 209,
        AUTH_ERR_FIELD_NEEDS_CONSENT = 210,
        AUTH_ERR_FIELD_TOO_YOUNG = 211,
        AUTH_ERR_TOO_MANY_PERSONA_FOR_NAMESPACE = 300,
    }
    
    public enum AuthenticationComponentCommand : ushort
    {
        createAccount = 10,
        updateAccount = 20,
        updateParentalEmail = 28,
        listUserEntitlements2 = 29,
        getAccount = 30,
        grantEntitlement = 31,
        listEntitlements = 32,
        hasEntitlement = 33,
        getUseCount = 34,
        decrementUseCount = 35,
        getAuthToken = 36,
        getHandoffToken = 37,
        getPasswordRules = 38,
        grantEntitlement2 = 39,
        login = 40,
        acceptTos = 41,
        getTosInfo = 42,
        modifyEntitlement2 = 43,
        consumecode = 44,
        passwordForgot = 45,
        getTermsAndConditionsContent = 46,
        getPrivacyPolicyContent = 47,
        listPersonaEntitlements2 = 48,
        silentLogin = 50,
        checkAgeReq = 51,
        getOptIn = 52,
        enableOptIn = 53,
        disableOptIn = 54,
        expressLogin = 60,
        logout = 70,
        createPersona = 80,
        getPersona = 90,
        listPersonas = 100,
        loginPersona = 110,
        logoutPersona = 120,
        deletePersona = 140,
        disablePersona = 141,
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
        getLegalDocsInfo = 242,
        getTermsOfServiceContent = 246,
        deviceLoginGuest = 300,
        checkSinglePlayerLogin = 500,
    }
    
    public enum AuthenticationComponentNotification : ushort
    {
    }
    
    public class Server : BlazeComponent {
        public override ushort Id => AuthenticationComponentBase.Id;
        public override string Name => AuthenticationComponentBase.Name;
        
        public virtual bool IsCommandSupported(AuthenticationComponentCommand command) => false;
        
        public class AuthenticationException : BlazeRpcException
        {
            public AuthenticationException(Error error) : base((ushort)error, null) { }
            public AuthenticationException(ServerError error) : base(error.WithErrorPrefix(), null) { }
            public AuthenticationException(Error error, Tdf? errorResponse) : base((ushort)error, errorResponse) { }
            public AuthenticationException(ServerError error, Tdf? errorResponse) : base(error.WithErrorPrefix(), errorResponse) { }
            public AuthenticationException(Error error, Tdf? errorResponse, string? message) : base((ushort)error, errorResponse, message) { }
            public AuthenticationException(ServerError error, Tdf? errorResponse, string? message) : base(error.WithErrorPrefix(), errorResponse, message) { }
            public AuthenticationException(Error error, Tdf? errorResponse, string? message, Exception? innerException) : base((ushort)error, errorResponse, message, innerException) { }
            public AuthenticationException(ServerError error, Tdf? errorResponse, string? message, Exception? innerException) : base(error.WithErrorPrefix(), errorResponse, message, innerException) { }
        }
        
        public Server()
        {
            RegisterCommand(new RpcCommandFunc<CreateAccountParameters, CreateAccountResponse, FieldValidateErrorList>()
            {
                Id = (ushort)AuthenticationComponentCommand.createAccount,
                Name = "createAccount",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.createAccount),
                Func = async (req, ctx) => await CreateAccountAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<UpdateAccountRequest, UpdateAccountResponse, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.updateAccount,
                Name = "updateAccount",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.updateAccount),
                Func = async (req, ctx) => await UpdateAccountAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<UpdateAccountRequest, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.updateParentalEmail,
                Name = "updateParentalEmail",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.updateParentalEmail),
                Func = async (req, ctx) => await UpdateParentalEmailAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<ListUserEntitlements2Request, Entitlements, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.listUserEntitlements2,
                Name = "listUserEntitlements2",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.listUserEntitlements2),
                Func = async (req, ctx) => await ListUserEntitlements2Async(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, AccountInfo, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.getAccount,
                Name = "getAccount",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.getAccount),
                Func = async (req, ctx) => await GetAccountAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.grantEntitlement,
                Name = "grantEntitlement",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.grantEntitlement),
                Func = async (req, ctx) => await GrantEntitlementAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<ListEntitlementsRequest, Entitlements, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.listEntitlements,
                Name = "listEntitlements",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.listEntitlements),
                Func = async (req, ctx) => await ListEntitlementsAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<HasEntitlementRequest, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.hasEntitlement,
                Name = "hasEntitlement",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.hasEntitlement),
                Func = async (req, ctx) => await HasEntitlementAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<GetUseCountRequest, UseCount, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.getUseCount,
                Name = "getUseCount",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.getUseCount),
                Func = async (req, ctx) => await GetUseCountAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<DecrementUseCountRequest, DecrementUseCount, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.decrementUseCount,
                Name = "decrementUseCount",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.decrementUseCount),
                Func = async (req, ctx) => await DecrementUseCountAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, GetAuthTokenResponse, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.getAuthToken,
                Name = "getAuthToken",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.getAuthToken),
                Func = async (req, ctx) => await GetAuthTokenAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<GetHandoffTokenRequest, GetHandoffTokenResponse, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.getHandoffToken,
                Name = "getHandoffToken",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.getHandoffToken),
                Func = async (req, ctx) => await GetHandoffTokenAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, PasswordRulesInfo, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.getPasswordRules,
                Name = "getPasswordRules",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.getPasswordRules),
                Func = async (req, ctx) => await GetPasswordRulesAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<GrantEntitlement2Request, GrantEntitlement2Response, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.grantEntitlement2,
                Name = "grantEntitlement2",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.grantEntitlement2),
                Func = async (req, ctx) => await GrantEntitlement2Async(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<LoginRequest, LoginResponse, CreateAccountResponse>()
            {
                Id = (ushort)AuthenticationComponentCommand.login,
                Name = "login",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.login),
                Func = async (req, ctx) => await LoginAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<AcceptTosRequest, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.acceptTos,
                Name = "acceptTos",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.acceptTos),
                Func = async (req, ctx) => await AcceptTosAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<GetTosInfoRequest, GetTosInfoResponse, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.getTosInfo,
                Name = "getTosInfo",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.getTosInfo),
                Func = async (req, ctx) => await GetTosInfoAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<ModifyEntitlement2Request, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.modifyEntitlement2,
                Name = "modifyEntitlement2",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.modifyEntitlement2),
                Func = async (req, ctx) => await ModifyEntitlement2Async(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<ConsumecodeRequest, ConsumecodeResponse, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.consumecode,
                Name = "consumecode",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.consumecode),
                Func = async (req, ctx) => await ConsumecodeAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<PasswordForgotRequest, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.passwordForgot,
                Name = "passwordForgot",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.passwordForgot),
                Func = async (req, ctx) => await PasswordForgotAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.getTermsAndConditionsContent,
                Name = "getTermsAndConditionsContent",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.getTermsAndConditionsContent),
                Func = async (req, ctx) => await GetTermsAndConditionsContentAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<GetLegalDocContentRequest, GetLegalDocContentResponse, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.getPrivacyPolicyContent,
                Name = "getPrivacyPolicyContent",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.getPrivacyPolicyContent),
                Func = async (req, ctx) => await GetPrivacyPolicyContentAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<ListPersonaEntitlements2Request, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.listPersonaEntitlements2,
                Name = "listPersonaEntitlements2",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.listPersonaEntitlements2),
                Func = async (req, ctx) => await ListPersonaEntitlements2Async(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<SilentLoginRequest, FullLoginResponse, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.silentLogin,
                Name = "silentLogin",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.silentLogin),
                Func = async (req, ctx) => await SilentLoginAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<CheckAgeReqRequest, CheckAgeReqResponse, FieldValidateErrorList>()
            {
                Id = (ushort)AuthenticationComponentCommand.checkAgeReq,
                Name = "checkAgeReq",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.checkAgeReq),
                Func = async (req, ctx) => await CheckAgeReqAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, OptInValue, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.getOptIn,
                Name = "getOptIn",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.getOptIn),
                Func = async (req, ctx) => await GetOptInAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.enableOptIn,
                Name = "enableOptIn",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.enableOptIn),
                Func = async (req, ctx) => await EnableOptInAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.disableOptIn,
                Name = "disableOptIn",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.disableOptIn),
                Func = async (req, ctx) => await DisableOptInAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<ExpressLoginRequest, FullLoginResponse, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.expressLogin,
                Name = "expressLogin",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.expressLogin),
                Func = async (req, ctx) => await ExpressLoginAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.logout,
                Name = "logout",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.logout),
                Func = async (req, ctx) => await LogoutAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<CreatePersonaRequest, PersonaDetails, FieldValidateErrorList>()
            {
                Id = (ushort)AuthenticationComponentCommand.createPersona,
                Name = "createPersona",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.createPersona),
                Func = async (req, ctx) => await CreatePersonaAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, GetPersonaResponse, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.getPersona,
                Name = "getPersona",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.getPersona),
                Func = async (req, ctx) => await GetPersonaAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, ListPersonasResponse, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.listPersonas,
                Name = "listPersonas",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.listPersonas),
                Func = async (req, ctx) => await ListPersonasAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<LoginPersonaRequest, SessionInfo, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.loginPersona,
                Name = "loginPersona",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.loginPersona),
                Func = async (req, ctx) => await LoginPersonaAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.logoutPersona,
                Name = "logoutPersona",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.logoutPersona),
                Func = async (req, ctx) => await LogoutPersonaAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.deletePersona,
                Name = "deletePersona",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.deletePersona),
                Func = async (req, ctx) => await DeletePersonaAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<PersonaRequest, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.disablePersona,
                Name = "disablePersona",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.disablePersona),
                Func = async (req, ctx) => await DisablePersonaAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<ListDeviceAccountsRequest, ListDeviceAccountsResponse, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.listDeviceAccounts,
                Name = "listDeviceAccounts",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.listDeviceAccounts),
                Func = async (req, ctx) => await ListDeviceAccountsAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<ConsoleCreateAccountRequest, ConsoleCreateAccountResponse, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.xboxCreateAccount,
                Name = "xboxCreateAccount",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.xboxCreateAccount),
                Func = async (req, ctx) => await XboxCreateAccountAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<OriginLoginRequest, FullLoginResponse, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.originLogin,
                Name = "originLogin",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.originLogin),
                Func = async (req, ctx) => await OriginLoginAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<ConsoleAssociateAccountRequest, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.xboxAssociateAccount,
                Name = "xboxAssociateAccount",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.xboxAssociateAccount),
                Func = async (req, ctx) => await XboxAssociateAccountAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<XboxLoginRequest, ConsoleLoginResponse, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.xboxLogin,
                Name = "xboxLogin",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.xboxLogin),
                Func = async (req, ctx) => await XboxLoginAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<ConsoleCreateAccountRequest, ConsoleCreateAccountResponse, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.ps3CreateAccount,
                Name = "ps3CreateAccount",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.ps3CreateAccount),
                Func = async (req, ctx) => await Ps3CreateAccountAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<ConsoleAssociateAccountRequest, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.ps3AssociateAccount,
                Name = "ps3AssociateAccount",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.ps3AssociateAccount),
                Func = async (req, ctx) => await Ps3AssociateAccountAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<PS3LoginRequest, ConsoleLoginResponse, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.ps3Login,
                Name = "ps3Login",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.ps3Login),
                Func = async (req, ctx) => await Ps3LoginAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<ValidateSessionKeyRequest, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.validateSessionKey,
                Name = "validateSessionKey",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.validateSessionKey),
                Func = async (req, ctx) => await ValidateSessionKeyAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.createWalUserSession,
                Name = "createWalUserSession",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.createWalUserSession),
                Func = async (req, ctx) => await CreateWalUserSessionAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<AcceptLegalDocsRequest, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.acceptLegalDocs,
                Name = "acceptLegalDocs",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.acceptLegalDocs),
                Func = async (req, ctx) => await AcceptLegalDocsAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<GetLegalDocsInfoRequest, GetLegalDocsInfoResponse, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.getLegalDocsInfo,
                Name = "getLegalDocsInfo",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.getLegalDocsInfo),
                Func = async (req, ctx) => await GetLegalDocsInfoAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<GetLegalDocContentRequest, GetLegalDocContentResponse, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.getTermsOfServiceContent,
                Name = "getTermsOfServiceContent",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.getTermsOfServiceContent),
                Func = async (req, ctx) => await GetTermsOfServiceContentAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<DeviceLoginGuestRequest, ConsoleLoginResponse, ConsoleCreateAccountRequest>()
            {
                Id = (ushort)AuthenticationComponentCommand.deviceLoginGuest,
                Name = "deviceLoginGuest",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.deviceLoginGuest),
                Func = async (req, ctx) => await DeviceLoginGuestAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.checkSinglePlayerLogin,
                Name = "checkSinglePlayerLogin",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.checkSinglePlayerLogin),
                Func = async (req, ctx) => await CheckSinglePlayerLoginAsync(req, ctx).ConfigureAwait(false)
            });
            
        }
        
        public override string GetErrorName(ushort errorCode)
        {
            return ((Error)errorCode).ToString();
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::createAccount</b> command.<br/>
        /// Request type: <see cref="CreateAccountParameters"/><br/>
        /// Response type: <see cref="CreateAccountResponse"/><br/>
        /// Error response type: <see cref="FieldValidateErrorList"/><br/>
        /// </summary>
        public virtual Task<CreateAccountResponse> CreateAccountAsync(CreateAccountParameters request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::updateAccount</b> command.<br/>
        /// Request type: <see cref="UpdateAccountRequest"/><br/>
        /// Response type: <see cref="UpdateAccountResponse"/><br/>
        /// </summary>
        public virtual Task<UpdateAccountResponse> UpdateAccountAsync(UpdateAccountRequest request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::updateParentalEmail</b> command.<br/>
        /// Request type: <see cref="UpdateAccountRequest"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> UpdateParentalEmailAsync(UpdateAccountRequest request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::listUserEntitlements2</b> command.<br/>
        /// Request type: <see cref="ListUserEntitlements2Request"/><br/>
        /// Response type: <see cref="Entitlements"/><br/>
        /// </summary>
        public virtual Task<Entitlements> ListUserEntitlements2Async(ListUserEntitlements2Request request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::getAccount</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="AccountInfo"/><br/>
        /// </summary>
        public virtual Task<AccountInfo> GetAccountAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::grantEntitlement</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GrantEntitlementAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::listEntitlements</b> command.<br/>
        /// Request type: <see cref="ListEntitlementsRequest"/><br/>
        /// Response type: <see cref="Entitlements"/><br/>
        /// </summary>
        public virtual Task<Entitlements> ListEntitlementsAsync(ListEntitlementsRequest request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::hasEntitlement</b> command.<br/>
        /// Request type: <see cref="HasEntitlementRequest"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> HasEntitlementAsync(HasEntitlementRequest request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::getUseCount</b> command.<br/>
        /// Request type: <see cref="GetUseCountRequest"/><br/>
        /// Response type: <see cref="UseCount"/><br/>
        /// </summary>
        public virtual Task<UseCount> GetUseCountAsync(GetUseCountRequest request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::decrementUseCount</b> command.<br/>
        /// Request type: <see cref="DecrementUseCountRequest"/><br/>
        /// Response type: <see cref="DecrementUseCount"/><br/>
        /// </summary>
        public virtual Task<DecrementUseCount> DecrementUseCountAsync(DecrementUseCountRequest request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::getAuthToken</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="GetAuthTokenResponse"/><br/>
        /// </summary>
        public virtual Task<GetAuthTokenResponse> GetAuthTokenAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::getHandoffToken</b> command.<br/>
        /// Request type: <see cref="GetHandoffTokenRequest"/><br/>
        /// Response type: <see cref="GetHandoffTokenResponse"/><br/>
        /// </summary>
        public virtual Task<GetHandoffTokenResponse> GetHandoffTokenAsync(GetHandoffTokenRequest request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::getPasswordRules</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="PasswordRulesInfo"/><br/>
        /// </summary>
        public virtual Task<PasswordRulesInfo> GetPasswordRulesAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::grantEntitlement2</b> command.<br/>
        /// Request type: <see cref="GrantEntitlement2Request"/><br/>
        /// Response type: <see cref="GrantEntitlement2Response"/><br/>
        /// </summary>
        public virtual Task<GrantEntitlement2Response> GrantEntitlement2Async(GrantEntitlement2Request request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::login</b> command.<br/>
        /// Request type: <see cref="LoginRequest"/><br/>
        /// Response type: <see cref="LoginResponse"/><br/>
        /// Error response type: <see cref="CreateAccountResponse"/><br/>
        /// </summary>
        public virtual Task<LoginResponse> LoginAsync(LoginRequest request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::acceptTos</b> command.<br/>
        /// Request type: <see cref="AcceptTosRequest"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> AcceptTosAsync(AcceptTosRequest request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::getTosInfo</b> command.<br/>
        /// Request type: <see cref="GetTosInfoRequest"/><br/>
        /// Response type: <see cref="GetTosInfoResponse"/><br/>
        /// </summary>
        public virtual Task<GetTosInfoResponse> GetTosInfoAsync(GetTosInfoRequest request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::modifyEntitlement2</b> command.<br/>
        /// Request type: <see cref="ModifyEntitlement2Request"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> ModifyEntitlement2Async(ModifyEntitlement2Request request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::consumecode</b> command.<br/>
        /// Request type: <see cref="ConsumecodeRequest"/><br/>
        /// Response type: <see cref="ConsumecodeResponse"/><br/>
        /// </summary>
        public virtual Task<ConsumecodeResponse> ConsumecodeAsync(ConsumecodeRequest request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::passwordForgot</b> command.<br/>
        /// Request type: <see cref="PasswordForgotRequest"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> PasswordForgotAsync(PasswordForgotRequest request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::getTermsAndConditionsContent</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetTermsAndConditionsContentAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::getPrivacyPolicyContent</b> command.<br/>
        /// Request type: <see cref="GetLegalDocContentRequest"/><br/>
        /// Response type: <see cref="GetLegalDocContentResponse"/><br/>
        /// </summary>
        public virtual Task<GetLegalDocContentResponse> GetPrivacyPolicyContentAsync(GetLegalDocContentRequest request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::listPersonaEntitlements2</b> command.<br/>
        /// Request type: <see cref="ListPersonaEntitlements2Request"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> ListPersonaEntitlements2Async(ListPersonaEntitlements2Request request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::silentLogin</b> command.<br/>
        /// Request type: <see cref="SilentLoginRequest"/><br/>
        /// Response type: <see cref="FullLoginResponse"/><br/>
        /// </summary>
        public virtual Task<FullLoginResponse> SilentLoginAsync(SilentLoginRequest request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::checkAgeReq</b> command.<br/>
        /// Request type: <see cref="CheckAgeReqRequest"/><br/>
        /// Response type: <see cref="CheckAgeReqResponse"/><br/>
        /// Error response type: <see cref="FieldValidateErrorList"/><br/>
        /// </summary>
        public virtual Task<CheckAgeReqResponse> CheckAgeReqAsync(CheckAgeReqRequest request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::getOptIn</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="OptInValue"/><br/>
        /// </summary>
        public virtual Task<OptInValue> GetOptInAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::enableOptIn</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> EnableOptInAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::disableOptIn</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> DisableOptInAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::expressLogin</b> command.<br/>
        /// Request type: <see cref="ExpressLoginRequest"/><br/>
        /// Response type: <see cref="FullLoginResponse"/><br/>
        /// </summary>
        public virtual Task<FullLoginResponse> ExpressLoginAsync(ExpressLoginRequest request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::logout</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> LogoutAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::createPersona</b> command.<br/>
        /// Request type: <see cref="CreatePersonaRequest"/><br/>
        /// Response type: <see cref="PersonaDetails"/><br/>
        /// Error response type: <see cref="FieldValidateErrorList"/><br/>
        /// </summary>
        public virtual Task<PersonaDetails> CreatePersonaAsync(CreatePersonaRequest request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::getPersona</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="GetPersonaResponse"/><br/>
        /// </summary>
        public virtual Task<GetPersonaResponse> GetPersonaAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::listPersonas</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="ListPersonasResponse"/><br/>
        /// </summary>
        public virtual Task<ListPersonasResponse> ListPersonasAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::loginPersona</b> command.<br/>
        /// Request type: <see cref="LoginPersonaRequest"/><br/>
        /// Response type: <see cref="SessionInfo"/><br/>
        /// </summary>
        public virtual Task<SessionInfo> LoginPersonaAsync(LoginPersonaRequest request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::logoutPersona</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> LogoutPersonaAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::deletePersona</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> DeletePersonaAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::disablePersona</b> command.<br/>
        /// Request type: <see cref="PersonaRequest"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> DisablePersonaAsync(PersonaRequest request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::listDeviceAccounts</b> command.<br/>
        /// Request type: <see cref="ListDeviceAccountsRequest"/><br/>
        /// Response type: <see cref="ListDeviceAccountsResponse"/><br/>
        /// </summary>
        public virtual Task<ListDeviceAccountsResponse> ListDeviceAccountsAsync(ListDeviceAccountsRequest request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::xboxCreateAccount</b> command.<br/>
        /// Request type: <see cref="ConsoleCreateAccountRequest"/><br/>
        /// Response type: <see cref="ConsoleCreateAccountResponse"/><br/>
        /// </summary>
        public virtual Task<ConsoleCreateAccountResponse> XboxCreateAccountAsync(ConsoleCreateAccountRequest request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::originLogin</b> command.<br/>
        /// Request type: <see cref="OriginLoginRequest"/><br/>
        /// Response type: <see cref="FullLoginResponse"/><br/>
        /// </summary>
        public virtual Task<FullLoginResponse> OriginLoginAsync(OriginLoginRequest request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::xboxAssociateAccount</b> command.<br/>
        /// Request type: <see cref="ConsoleAssociateAccountRequest"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> XboxAssociateAccountAsync(ConsoleAssociateAccountRequest request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::xboxLogin</b> command.<br/>
        /// Request type: <see cref="XboxLoginRequest"/><br/>
        /// Response type: <see cref="ConsoleLoginResponse"/><br/>
        /// </summary>
        public virtual Task<ConsoleLoginResponse> XboxLoginAsync(XboxLoginRequest request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::ps3CreateAccount</b> command.<br/>
        /// Request type: <see cref="ConsoleCreateAccountRequest"/><br/>
        /// Response type: <see cref="ConsoleCreateAccountResponse"/><br/>
        /// </summary>
        public virtual Task<ConsoleCreateAccountResponse> Ps3CreateAccountAsync(ConsoleCreateAccountRequest request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::ps3AssociateAccount</b> command.<br/>
        /// Request type: <see cref="ConsoleAssociateAccountRequest"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> Ps3AssociateAccountAsync(ConsoleAssociateAccountRequest request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::ps3Login</b> command.<br/>
        /// Request type: <see cref="PS3LoginRequest"/><br/>
        /// Response type: <see cref="ConsoleLoginResponse"/><br/>
        /// </summary>
        public virtual Task<ConsoleLoginResponse> Ps3LoginAsync(PS3LoginRequest request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::validateSessionKey</b> command.<br/>
        /// Request type: <see cref="ValidateSessionKeyRequest"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> ValidateSessionKeyAsync(ValidateSessionKeyRequest request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::createWalUserSession</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> CreateWalUserSessionAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::acceptLegalDocs</b> command.<br/>
        /// Request type: <see cref="AcceptLegalDocsRequest"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> AcceptLegalDocsAsync(AcceptLegalDocsRequest request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::getLegalDocsInfo</b> command.<br/>
        /// Request type: <see cref="GetLegalDocsInfoRequest"/><br/>
        /// Response type: <see cref="GetLegalDocsInfoResponse"/><br/>
        /// </summary>
        public virtual Task<GetLegalDocsInfoResponse> GetLegalDocsInfoAsync(GetLegalDocsInfoRequest request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::getTermsOfServiceContent</b> command.<br/>
        /// Request type: <see cref="GetLegalDocContentRequest"/><br/>
        /// Response type: <see cref="GetLegalDocContentResponse"/><br/>
        /// </summary>
        public virtual Task<GetLegalDocContentResponse> GetTermsOfServiceContentAsync(GetLegalDocContentRequest request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::deviceLoginGuest</b> command.<br/>
        /// Request type: <see cref="DeviceLoginGuestRequest"/><br/>
        /// Response type: <see cref="ConsoleLoginResponse"/><br/>
        /// Error response type: <see cref="ConsoleCreateAccountRequest"/><br/>
        /// </summary>
        public virtual Task<ConsoleLoginResponse> DeviceLoginGuestAsync(DeviceLoginGuestRequest request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::checkSinglePlayerLogin</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> CheckSinglePlayerLoginAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
    }
    
}

