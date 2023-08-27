using Blaze2SDK.Blaze.Authentication;
using BlazeCommon;

namespace Blaze2SDK.Components
{
    public static class AuthenticationComponentBase
    {
        public const ushort Id = 1;
        public const string Name = "AuthenticationComponent";
        
        public class Server : BlazeComponent<AuthenticationComponentCommand, AuthenticationComponentNotification, Blaze2RpcError>
        {
            public Server() : base(AuthenticationComponentBase.Id, AuthenticationComponentBase.Name)
            {
                
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.createAccount)]
            public virtual Task<CreateAccountResponse> CreateAccountAsync(CreateAccountParameters request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.updateAccount)]
            public virtual Task<NullStruct> UpdateAccountAsync(UpdateAccountRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.updateParentalEmail)]
            public virtual Task<NullStruct> UpdateParentalEmailAsync(UpdateAccountRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.getAccount)]
            public virtual Task<AccountInfo> GetAccountAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.grantEntitlement)]
            public virtual Task<NullStruct> GrantEntitlementAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.getEntitlements)]
            public virtual Task<Entitlements> GetEntitlementsAsync(ListEntitlementsRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.hasEntitlement)]
            public virtual Task<NullStruct> HasEntitlementAsync(HasEntitlementRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.getUseCount)]
            public virtual Task<NullStruct> GetUseCountAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.decrementUseCount)]
            public virtual Task<NullStruct> DecrementUseCountAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.getAuthToken)]
            public virtual Task<NullStruct> GetAuthTokenAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.getHandoffToken)]
            public virtual Task<NullStruct> GetHandoffTokenAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.listEntitlement2)]
            public virtual Task<NullStruct> ListEntitlement2Async(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.login)]
            public virtual Task<LoginResponse> LoginAsync(LoginRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.acceptTos)]
            public virtual Task<NullStruct> AcceptTosAsync(AcceptTosRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.getTosInfo)]
            public virtual Task<GetTosInfoResponse> GetTosInfoAsync(GetTosInfoRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.consumecode)]
            public virtual Task<ConsumecodeResponse> ConsumecodeAsync(ConsumecodeRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.passwordForgot)]
            public virtual Task<NullStruct> PasswordForgotAsync(PasswordForgotRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.silentLogin)]
            public virtual Task<FullLoginResponse> SilentLoginAsync(SilentLoginRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.checkAgeReq)]
            public virtual Task<CheckAgeReqResponse> CheckAgeReqAsync(CheckAgeReqRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.expressLogin)]
            public virtual Task<FullLoginResponse> ExpressLoginAsync(ExpressLoginRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.stressLogin)]
            public virtual Task<NullStruct> StressLoginAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.logout)]
            public virtual Task<NullStruct> LogoutAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.createPersona)]
            public virtual Task<PersonaDetails> CreatePersonaAsync(CreatePersonaRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.getPersona)]
            public virtual Task<NullStruct> GetPersonaAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.listPersonas)]
            public virtual Task<ListPersonasResponse> ListPersonasAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.loginPersona)]
            public virtual Task<SessionInfo> LoginPersonaAsync(LoginPersonaRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.logoutPersona)]
            public virtual Task<NullStruct> LogoutPersonaAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.deletePersona)]
            public virtual Task<NullStruct> DeletePersonaAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.disablePersona)]
            public virtual Task<PersonaDetails> DisablePersonaAsync(PersonaRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.listDeviceAccounts)]
            public virtual Task<ListDeviceAccountsResponse> ListDeviceAccountsAsync(ListDeviceAccountsRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.xboxCreateAccount)]
            public virtual Task<NullStruct> XboxCreateAccountAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.xboxAssociateAccount)]
            public virtual Task<NullStruct> XboxAssociateAccountAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.xboxLogin)]
            public virtual Task<NullStruct> XboxLoginAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.ps3CreateAccount)]
            public virtual Task<NullStruct> Ps3CreateAccountAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.ps3AssociateAccount)]
            public virtual Task<NullStruct> Ps3AssociateAccountAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.ps3Login)]
            public virtual Task<NullStruct> Ps3LoginAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.validateSessionKey)]
            public virtual Task<NullStruct> ValidateSessionKeyAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.createWalUserSession)]
            public virtual Task<NullStruct> CreateWalUserSessionAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.deviceLoginGuest)]
            public virtual Task<ConsoleLoginResponse> DeviceLoginGuestAsync(DeviceLoginGuestRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            
            public override Type GetCommandRequestType(AuthenticationComponentCommand command) => AuthenticationComponentBase.GetCommandRequestType(command);
            public override Type GetCommandResponseType(AuthenticationComponentCommand command) => AuthenticationComponentBase.GetCommandResponseType(command);
            public override Type GetCommandErrorResponseType(AuthenticationComponentCommand command) => AuthenticationComponentBase.GetCommandErrorResponseType(command);
            public override Type GetNotificationType(AuthenticationComponentNotification notification) => AuthenticationComponentBase.GetNotificationType(notification);
            
        }
        
        public class Client : BlazeComponent<AuthenticationComponentCommand, AuthenticationComponentNotification, Blaze2RpcError>
        {
            public Client() : base(AuthenticationComponentBase.Id, AuthenticationComponentBase.Name)
            {
                
            }
            
            public override Type GetCommandRequestType(AuthenticationComponentCommand command) => AuthenticationComponentBase.GetCommandRequestType(command);
            public override Type GetCommandResponseType(AuthenticationComponentCommand command) => AuthenticationComponentBase.GetCommandResponseType(command);
            public override Type GetCommandErrorResponseType(AuthenticationComponentCommand command) => AuthenticationComponentBase.GetCommandErrorResponseType(command);
            public override Type GetNotificationType(AuthenticationComponentNotification notification) => AuthenticationComponentBase.GetNotificationType(notification);
            
        }
        
        public static Type GetCommandRequestType(AuthenticationComponentCommand command) => command switch
        {
            AuthenticationComponentCommand.createAccount => typeof(CreateAccountParameters),
            AuthenticationComponentCommand.updateAccount => typeof(UpdateAccountRequest),
            AuthenticationComponentCommand.updateParentalEmail => typeof(UpdateAccountRequest),
            AuthenticationComponentCommand.getAccount => typeof(NullStruct),
            AuthenticationComponentCommand.grantEntitlement => typeof(NullStruct),
            AuthenticationComponentCommand.getEntitlements => typeof(ListEntitlementsRequest),
            AuthenticationComponentCommand.hasEntitlement => typeof(HasEntitlementRequest),
            AuthenticationComponentCommand.getUseCount => typeof(NullStruct),
            AuthenticationComponentCommand.decrementUseCount => typeof(NullStruct),
            AuthenticationComponentCommand.getAuthToken => typeof(NullStruct),
            AuthenticationComponentCommand.getHandoffToken => typeof(NullStruct),
            AuthenticationComponentCommand.listEntitlement2 => typeof(NullStruct),
            AuthenticationComponentCommand.login => typeof(LoginRequest),
            AuthenticationComponentCommand.acceptTos => typeof(AcceptTosRequest),
            AuthenticationComponentCommand.getTosInfo => typeof(GetTosInfoRequest),
            AuthenticationComponentCommand.consumecode => typeof(ConsumecodeRequest),
            AuthenticationComponentCommand.passwordForgot => typeof(PasswordForgotRequest),
            AuthenticationComponentCommand.silentLogin => typeof(SilentLoginRequest),
            AuthenticationComponentCommand.checkAgeReq => typeof(CheckAgeReqRequest),
            AuthenticationComponentCommand.expressLogin => typeof(ExpressLoginRequest),
            AuthenticationComponentCommand.stressLogin => typeof(NullStruct),
            AuthenticationComponentCommand.logout => typeof(NullStruct),
            AuthenticationComponentCommand.createPersona => typeof(CreatePersonaRequest),
            AuthenticationComponentCommand.getPersona => typeof(NullStruct),
            AuthenticationComponentCommand.listPersonas => typeof(NullStruct),
            AuthenticationComponentCommand.loginPersona => typeof(LoginPersonaRequest),
            AuthenticationComponentCommand.logoutPersona => typeof(NullStruct),
            AuthenticationComponentCommand.deletePersona => typeof(NullStruct),
            AuthenticationComponentCommand.disablePersona => typeof(PersonaRequest),
            AuthenticationComponentCommand.listDeviceAccounts => typeof(ListDeviceAccountsRequest),
            AuthenticationComponentCommand.xboxCreateAccount => typeof(NullStruct),
            AuthenticationComponentCommand.xboxAssociateAccount => typeof(NullStruct),
            AuthenticationComponentCommand.xboxLogin => typeof(NullStruct),
            AuthenticationComponentCommand.ps3CreateAccount => typeof(NullStruct),
            AuthenticationComponentCommand.ps3AssociateAccount => typeof(NullStruct),
            AuthenticationComponentCommand.ps3Login => typeof(NullStruct),
            AuthenticationComponentCommand.validateSessionKey => typeof(NullStruct),
            AuthenticationComponentCommand.createWalUserSession => typeof(NullStruct),
            AuthenticationComponentCommand.deviceLoginGuest => typeof(DeviceLoginGuestRequest),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandResponseType(AuthenticationComponentCommand command) => command switch
        {
            AuthenticationComponentCommand.createAccount => typeof(CreateAccountResponse),
            AuthenticationComponentCommand.updateAccount => typeof(NullStruct),
            AuthenticationComponentCommand.updateParentalEmail => typeof(NullStruct),
            AuthenticationComponentCommand.getAccount => typeof(AccountInfo),
            AuthenticationComponentCommand.grantEntitlement => typeof(NullStruct),
            AuthenticationComponentCommand.getEntitlements => typeof(Entitlements),
            AuthenticationComponentCommand.hasEntitlement => typeof(NullStruct),
            AuthenticationComponentCommand.getUseCount => typeof(NullStruct),
            AuthenticationComponentCommand.decrementUseCount => typeof(NullStruct),
            AuthenticationComponentCommand.getAuthToken => typeof(NullStruct),
            AuthenticationComponentCommand.getHandoffToken => typeof(NullStruct),
            AuthenticationComponentCommand.listEntitlement2 => typeof(NullStruct),
            AuthenticationComponentCommand.login => typeof(LoginResponse),
            AuthenticationComponentCommand.acceptTos => typeof(NullStruct),
            AuthenticationComponentCommand.getTosInfo => typeof(GetTosInfoResponse),
            AuthenticationComponentCommand.consumecode => typeof(ConsumecodeResponse),
            AuthenticationComponentCommand.passwordForgot => typeof(NullStruct),
            AuthenticationComponentCommand.silentLogin => typeof(FullLoginResponse),
            AuthenticationComponentCommand.checkAgeReq => typeof(CheckAgeReqResponse),
            AuthenticationComponentCommand.expressLogin => typeof(FullLoginResponse),
            AuthenticationComponentCommand.stressLogin => typeof(NullStruct),
            AuthenticationComponentCommand.logout => typeof(NullStruct),
            AuthenticationComponentCommand.createPersona => typeof(PersonaDetails),
            AuthenticationComponentCommand.getPersona => typeof(NullStruct),
            AuthenticationComponentCommand.listPersonas => typeof(ListPersonasResponse),
            AuthenticationComponentCommand.loginPersona => typeof(SessionInfo),
            AuthenticationComponentCommand.logoutPersona => typeof(NullStruct),
            AuthenticationComponentCommand.deletePersona => typeof(NullStruct),
            AuthenticationComponentCommand.disablePersona => typeof(PersonaDetails),
            AuthenticationComponentCommand.listDeviceAccounts => typeof(ListDeviceAccountsResponse),
            AuthenticationComponentCommand.xboxCreateAccount => typeof(NullStruct),
            AuthenticationComponentCommand.xboxAssociateAccount => typeof(NullStruct),
            AuthenticationComponentCommand.xboxLogin => typeof(NullStruct),
            AuthenticationComponentCommand.ps3CreateAccount => typeof(NullStruct),
            AuthenticationComponentCommand.ps3AssociateAccount => typeof(NullStruct),
            AuthenticationComponentCommand.ps3Login => typeof(NullStruct),
            AuthenticationComponentCommand.validateSessionKey => typeof(NullStruct),
            AuthenticationComponentCommand.createWalUserSession => typeof(NullStruct),
            AuthenticationComponentCommand.deviceLoginGuest => typeof(ConsoleLoginResponse),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandErrorResponseType(AuthenticationComponentCommand command) => command switch
        {
            AuthenticationComponentCommand.createAccount => typeof(FieldValidateErrorList),
            AuthenticationComponentCommand.updateAccount => typeof(NullStruct),
            AuthenticationComponentCommand.updateParentalEmail => typeof(NullStruct),
            AuthenticationComponentCommand.getAccount => typeof(NullStruct),
            AuthenticationComponentCommand.grantEntitlement => typeof(NullStruct),
            AuthenticationComponentCommand.getEntitlements => typeof(NullStruct),
            AuthenticationComponentCommand.hasEntitlement => typeof(NullStruct),
            AuthenticationComponentCommand.getUseCount => typeof(NullStruct),
            AuthenticationComponentCommand.decrementUseCount => typeof(NullStruct),
            AuthenticationComponentCommand.getAuthToken => typeof(NullStruct),
            AuthenticationComponentCommand.getHandoffToken => typeof(NullStruct),
            AuthenticationComponentCommand.listEntitlement2 => typeof(NullStruct),
            AuthenticationComponentCommand.login => typeof(CreateAccountResponse),
            AuthenticationComponentCommand.acceptTos => typeof(NullStruct),
            AuthenticationComponentCommand.getTosInfo => typeof(NullStruct),
            AuthenticationComponentCommand.consumecode => typeof(NullStruct),
            AuthenticationComponentCommand.passwordForgot => typeof(NullStruct),
            AuthenticationComponentCommand.silentLogin => typeof(NullStruct),
            AuthenticationComponentCommand.checkAgeReq => typeof(FieldValidateErrorList),
            AuthenticationComponentCommand.expressLogin => typeof(NullStruct),
            AuthenticationComponentCommand.stressLogin => typeof(NullStruct),
            AuthenticationComponentCommand.logout => typeof(NullStruct),
            AuthenticationComponentCommand.createPersona => typeof(FieldValidateErrorList),
            AuthenticationComponentCommand.getPersona => typeof(NullStruct),
            AuthenticationComponentCommand.listPersonas => typeof(NullStruct),
            AuthenticationComponentCommand.loginPersona => typeof(NullStruct),
            AuthenticationComponentCommand.logoutPersona => typeof(NullStruct),
            AuthenticationComponentCommand.deletePersona => typeof(NullStruct),
            AuthenticationComponentCommand.disablePersona => typeof(NullStruct),
            AuthenticationComponentCommand.listDeviceAccounts => typeof(NullStruct),
            AuthenticationComponentCommand.xboxCreateAccount => typeof(NullStruct),
            AuthenticationComponentCommand.xboxAssociateAccount => typeof(NullStruct),
            AuthenticationComponentCommand.xboxLogin => typeof(NullStruct),
            AuthenticationComponentCommand.ps3CreateAccount => typeof(NullStruct),
            AuthenticationComponentCommand.ps3AssociateAccount => typeof(NullStruct),
            AuthenticationComponentCommand.ps3Login => typeof(NullStruct),
            AuthenticationComponentCommand.validateSessionKey => typeof(NullStruct),
            AuthenticationComponentCommand.createWalUserSession => typeof(NullStruct),
            AuthenticationComponentCommand.deviceLoginGuest => typeof(ConsoleCreateAccountRequest),
            _ => typeof(NullStruct)
        };
        
        public static Type GetNotificationType(AuthenticationComponentNotification notification) => notification switch
        {
            _ => typeof(NullStruct)
        };
        
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
        
    }
}
