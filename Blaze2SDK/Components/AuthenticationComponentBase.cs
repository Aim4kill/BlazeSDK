using Blaze.Core;
using Blaze2SDK.Blaze.Authentication;
using EATDF;
using EATDF.Types;

namespace Blaze2SDK.Components;

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
        AUTH_ERR_USER_INACTIVE = 101,
        AUTH_ERR_UNEXPECTED_ACTIVATION = 102,
        AUTH_ERR_NAME_MISMATCH = 103,
        AUTH_ERR_INVALID_PS3_TICKET = 104,
        AUTH_ERR_INVALID_NAMESPACE = 105,
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
        AUTH_ERR_BETA_MISSING_BC2_ENTITLEMENT = 400,
    }
    
    public enum AuthenticationComponentCommand : ushort
    {
        createAccount = 10,
        updateAccount = 20,
        updateParentalEmail = 28,
        getAccount = 30,
        grantEntitlement = 31,
        getEntitlements = 32,
        hasEntitlement = 33,
        getUseCount = 34,
        decrementUseCount = 35,
        getAuthToken = 36,
        getHandoffToken = 37,
        listEntitlement2 = 38,
        login = 40,
        acceptTos = 41,
        getTosInfo = 42,
        consumecode = 44,
        passwordForgot = 45,
        silentLogin = 50,
        checkAgeReq = 51,
        expressLogin = 60,
        stressLogin = 61,
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
        xboxAssociateAccount = 160,
        xboxLogin = 170,
        ps3CreateAccount = 180,
        ps3AssociateAccount = 190,
        ps3Login = 200,
        validateSessionKey = 210,
        createWalUserSession = 230,
        deviceLoginGuest = 300,
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
            
            RegisterCommand(new RpcCommandFunc<UpdateAccountRequest, EmptyMessage, EmptyMessage>()
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
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, AccountInfo, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.getAccount,
                Name = "getAccount",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.getAccount),
                Func = async (req, ctx) => await GetAccountAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<Entitlement, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.grantEntitlement,
                Name = "grantEntitlement",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.grantEntitlement),
                Func = async (req, ctx) => await GrantEntitlementAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<ListEntitlementsRequest, Entitlements, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.getEntitlements,
                Name = "getEntitlements",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.getEntitlements),
                Func = async (req, ctx) => await GetEntitlementsAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<HasEntitlementRequest, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.hasEntitlement,
                Name = "hasEntitlement",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.hasEntitlement),
                Func = async (req, ctx) => await HasEntitlementAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.getUseCount,
                Name = "getUseCount",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.getUseCount),
                Func = async (req, ctx) => await GetUseCountAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.decrementUseCount,
                Name = "decrementUseCount",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.decrementUseCount),
                Func = async (req, ctx) => await DecrementUseCountAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.getAuthToken,
                Name = "getAuthToken",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.getAuthToken),
                Func = async (req, ctx) => await GetAuthTokenAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.getHandoffToken,
                Name = "getHandoffToken",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.getHandoffToken),
                Func = async (req, ctx) => await GetHandoffTokenAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.listEntitlement2,
                Name = "listEntitlement2",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.listEntitlement2),
                Func = async (req, ctx) => await ListEntitlement2Async(req, ctx).ConfigureAwait(false)
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
            
            RegisterCommand(new RpcCommandFunc<ExpressLoginRequest, FullLoginResponse, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.expressLogin,
                Name = "expressLogin",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.expressLogin),
                Func = async (req, ctx) => await ExpressLoginAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)AuthenticationComponentCommand.stressLogin,
                Name = "stressLogin",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.stressLogin),
                Func = async (req, ctx) => await StressLoginAsync(req, ctx).ConfigureAwait(false)
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
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
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
            
            RegisterCommand(new RpcCommandFunc<PersonaRequest, PersonaDetails, EmptyMessage>()
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
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
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
            
            RegisterCommand(new RpcCommandFunc<ConsoleAssociateAccountRequest, SessionInfo, EmptyMessage>()
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
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
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
            
            RegisterCommand(new RpcCommandFunc<DeviceLoginGuestRequest, ConsoleLoginResponse, ConsoleCreateAccountRequest>()
            {
                Id = (ushort)AuthenticationComponentCommand.deviceLoginGuest,
                Name = "deviceLoginGuest",
                IsSupported = IsCommandSupported(AuthenticationComponentCommand.deviceLoginGuest),
                Func = async (req, ctx) => await DeviceLoginGuestAsync(req, ctx).ConfigureAwait(false)
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
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> UpdateAccountAsync(UpdateAccountRequest request, BlazeRpcContext context)
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
        /// Request type: <see cref="Entitlement"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GrantEntitlementAsync(Entitlement request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::getEntitlements</b> command.<br/>
        /// Request type: <see cref="ListEntitlementsRequest"/><br/>
        /// Response type: <see cref="Entitlements"/><br/>
        /// </summary>
        public virtual Task<Entitlements> GetEntitlementsAsync(ListEntitlementsRequest request, BlazeRpcContext context)
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
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetUseCountAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::decrementUseCount</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> DecrementUseCountAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::getAuthToken</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetAuthTokenAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::getHandoffToken</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetHandoffTokenAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::listEntitlement2</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> ListEntitlement2Async(EmptyMessage request, BlazeRpcContext context)
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
        /// This method is called when server receives a <b>AuthenticationComponent::expressLogin</b> command.<br/>
        /// Request type: <see cref="ExpressLoginRequest"/><br/>
        /// Response type: <see cref="FullLoginResponse"/><br/>
        /// </summary>
        public virtual Task<FullLoginResponse> ExpressLoginAsync(ExpressLoginRequest request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AuthenticationComponent::stressLogin</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> StressLoginAsync(EmptyMessage request, BlazeRpcContext context)
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
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetPersonaAsync(EmptyMessage request, BlazeRpcContext context)
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
        /// Response type: <see cref="PersonaDetails"/><br/>
        /// </summary>
        public virtual Task<PersonaDetails> DisablePersonaAsync(PersonaRequest request, BlazeRpcContext context)
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
        /// This method is called when server receives a <b>AuthenticationComponent::xboxAssociateAccount</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> XboxAssociateAccountAsync(EmptyMessage request, BlazeRpcContext context)
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
        /// Response type: <see cref="SessionInfo"/><br/>
        /// </summary>
        public virtual Task<SessionInfo> Ps3AssociateAccountAsync(ConsoleAssociateAccountRequest request, BlazeRpcContext context)
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
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> ValidateSessionKeyAsync(EmptyMessage request, BlazeRpcContext context)
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
        /// This method is called when server receives a <b>AuthenticationComponent::deviceLoginGuest</b> command.<br/>
        /// Request type: <see cref="DeviceLoginGuestRequest"/><br/>
        /// Response type: <see cref="ConsoleLoginResponse"/><br/>
        /// Error response type: <see cref="ConsoleCreateAccountRequest"/><br/>
        /// </summary>
        public virtual Task<ConsoleLoginResponse> DeviceLoginGuestAsync(DeviceLoginGuestRequest request, BlazeRpcContext context)
        {
            throw new AuthenticationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
    }
    
}

