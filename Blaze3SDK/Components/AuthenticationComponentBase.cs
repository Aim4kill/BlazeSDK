using Blaze3SDK.Blaze.Authentication;
using BlazeCommon;

namespace Blaze3SDK.Components
{
    public static class AuthenticationComponentBase
    {
        public const ushort Id = 1;
        public const string Name = "AuthenticationComponent";
        
        public class Server : BlazeComponent<AuthenticationComponentCommand, AuthenticationComponentNotification, Blaze3RpcError>
        {
            public Server() : base(AuthenticationComponentBase.Id, AuthenticationComponentBase.Name)
            {
                
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.createAccount)]
            public virtual Task<CreateAccountResponse> CreateAccountAsync(CreateAccountParameters request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.updateAccount)]
            public virtual Task<UpdateAccountResponse> UpdateAccountAsync(UpdateAccountRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.updateParentalEmail)]
            public virtual Task<NullStruct> UpdateParentalEmailAsync(UpdateAccountRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.listUserEntitlements2)]
            public virtual Task<Entitlements> ListUserEntitlements2Async(ListUserEntitlements2Request request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.getAccount)]
            public virtual Task<AccountInfo> GetAccountAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.grantEntitlement)]
            public virtual Task<NullStruct> GrantEntitlementAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.listEntitlements)]
            public virtual Task<NullStruct> ListEntitlementsAsync(ListEntitlementsRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.hasEntitlement)]
            public virtual Task<NullStruct> HasEntitlementAsync(HasEntitlementRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.getUseCount)]
            public virtual Task<UseCount> GetUseCountAsync(GetUseCountRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.decrementUseCount)]
            public virtual Task<DecrementUseCount> DecrementUseCountAsync(DecrementUseCountRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.getAuthToken)]
            public virtual Task<GetAuthTokenResponse> GetAuthTokenAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.getHandoffToken)]
            public virtual Task<GetHandoffTokenResponse> GetHandoffTokenAsync(GetHandoffTokenRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.getPasswordRules)]
            public virtual Task<PasswordRulesInfo> GetPasswordRulesAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.grantEntitlement2)]
            public virtual Task<GrantEntitlement2Response> GrantEntitlement2Async(GrantEntitlement2Request request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.login)]
            public virtual Task<LoginResponse> LoginAsync(LoginRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.acceptTos)]
            public virtual Task<NullStruct> AcceptTosAsync(AcceptTosRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.getTosInfo)]
            public virtual Task<GetTosInfoResponse> GetTosInfoAsync(GetTosInfoRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.modifyEntitlement2)]
            public virtual Task<NullStruct> ModifyEntitlement2Async(ModifyEntitlement2Request request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.consumecode)]
            public virtual Task<ConsumecodeResponse> ConsumecodeAsync(ConsumecodeRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.passwordForgot)]
            public virtual Task<NullStruct> PasswordForgotAsync(PasswordForgotRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.getTermsAndConditionsContent)]
            public virtual Task<NullStruct> GetTermsAndConditionsContentAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.getPrivacyPolicyContent)]
            public virtual Task<GetLegalDocContentResponse> GetPrivacyPolicyContentAsync(GetLegalDocContentRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.listPersonaEntitlements2)]
            public virtual Task<NullStruct> ListPersonaEntitlements2Async(ListPersonaEntitlements2Request request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.silentLogin)]
            public virtual Task<FullLoginResponse> SilentLoginAsync(SilentLoginRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.checkAgeReq)]
            public virtual Task<CheckAgeReqResponse> CheckAgeReqAsync(CheckAgeReqRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.getOptIn)]
            public virtual Task<OptInValue> GetOptInAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.enableOptIn)]
            public virtual Task<NullStruct> EnableOptInAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.disableOptIn)]
            public virtual Task<NullStruct> DisableOptInAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.expressLogin)]
            public virtual Task<FullLoginResponse> ExpressLoginAsync(ExpressLoginRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.logout)]
            public virtual Task<NullStruct> LogoutAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.createPersona)]
            public virtual Task<PersonaDetails> CreatePersonaAsync(CreatePersonaRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.getPersona)]
            public virtual Task<GetPersonaResponse> GetPersonaAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.listPersonas)]
            public virtual Task<ListPersonasResponse> ListPersonasAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.loginPersona)]
            public virtual Task<SessionInfo> LoginPersonaAsync(LoginPersonaRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.logoutPersona)]
            public virtual Task<NullStruct> LogoutPersonaAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.deletePersona)]
            public virtual Task<NullStruct> DeletePersonaAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.disablePersona)]
            public virtual Task<NullStruct> DisablePersonaAsync(PersonaRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.listDeviceAccounts)]
            public virtual Task<ListDeviceAccountsResponse> ListDeviceAccountsAsync(ListDeviceAccountsRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.xboxCreateAccount)]
            public virtual Task<ConsoleCreateAccountResponse> XboxCreateAccountAsync(ConsoleCreateAccountRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.originLogin)]
            public virtual Task<FullLoginResponse> OriginLoginAsync(OriginLoginRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.xboxAssociateAccount)]
            public virtual Task<NullStruct> XboxAssociateAccountAsync(ConsoleAssociateAccountRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.xboxLogin)]
            public virtual Task<ConsoleLoginResponse> XboxLoginAsync(XboxLoginRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.ps3CreateAccount)]
            public virtual Task<ConsoleCreateAccountResponse> Ps3CreateAccountAsync(ConsoleCreateAccountRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.ps3AssociateAccount)]
            public virtual Task<NullStruct> Ps3AssociateAccountAsync(ConsoleAssociateAccountRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.ps3Login)]
            public virtual Task<ConsoleLoginResponse> Ps3LoginAsync(PS3LoginRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.validateSessionKey)]
            public virtual Task<NullStruct> ValidateSessionKeyAsync(ValidateSessionKeyRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.createWalUserSession)]
            public virtual Task<NullStruct> CreateWalUserSessionAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.acceptLegalDocs)]
            public virtual Task<NullStruct> AcceptLegalDocsAsync(AcceptLegalDocsRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.getLegalDocsInfo)]
            public virtual Task<GetLegalDocsInfoResponse> GetLegalDocsInfoAsync(GetLegalDocsInfoRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.getTermsOfServiceContent)]
            public virtual Task<GetLegalDocContentResponse> GetTermsOfServiceContentAsync(GetLegalDocContentRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.deviceLoginGuest)]
            public virtual Task<ConsoleLoginResponse> DeviceLoginGuestAsync(DeviceLoginGuestRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AuthenticationComponentCommand.checkSinglePlayerLogin)]
            public virtual Task<NullStruct> CheckSinglePlayerLoginAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            
            public override Type GetCommandRequestType(AuthenticationComponentCommand command) => AuthenticationComponentBase.GetCommandRequestType(command);
            public override Type GetCommandResponseType(AuthenticationComponentCommand command) => AuthenticationComponentBase.GetCommandResponseType(command);
            public override Type GetCommandErrorResponseType(AuthenticationComponentCommand command) => AuthenticationComponentBase.GetCommandErrorResponseType(command);
            public override Type GetNotificationType(AuthenticationComponentNotification notification) => AuthenticationComponentBase.GetNotificationType(notification);
            
        }
        
        public class Client : BlazeComponent<AuthenticationComponentCommand, AuthenticationComponentNotification, Blaze3RpcError>
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
            AuthenticationComponentCommand.listUserEntitlements2 => typeof(ListUserEntitlements2Request),
            AuthenticationComponentCommand.getAccount => typeof(NullStruct),
            AuthenticationComponentCommand.grantEntitlement => typeof(NullStruct),
            AuthenticationComponentCommand.listEntitlements => typeof(ListEntitlementsRequest),
            AuthenticationComponentCommand.hasEntitlement => typeof(HasEntitlementRequest),
            AuthenticationComponentCommand.getUseCount => typeof(GetUseCountRequest),
            AuthenticationComponentCommand.decrementUseCount => typeof(DecrementUseCountRequest),
            AuthenticationComponentCommand.getAuthToken => typeof(NullStruct),
            AuthenticationComponentCommand.getHandoffToken => typeof(GetHandoffTokenRequest),
            AuthenticationComponentCommand.getPasswordRules => typeof(NullStruct),
            AuthenticationComponentCommand.grantEntitlement2 => typeof(GrantEntitlement2Request),
            AuthenticationComponentCommand.login => typeof(LoginRequest),
            AuthenticationComponentCommand.acceptTos => typeof(AcceptTosRequest),
            AuthenticationComponentCommand.getTosInfo => typeof(GetTosInfoRequest),
            AuthenticationComponentCommand.modifyEntitlement2 => typeof(ModifyEntitlement2Request),
            AuthenticationComponentCommand.consumecode => typeof(ConsumecodeRequest),
            AuthenticationComponentCommand.passwordForgot => typeof(PasswordForgotRequest),
            AuthenticationComponentCommand.getTermsAndConditionsContent => typeof(NullStruct),
            AuthenticationComponentCommand.getPrivacyPolicyContent => typeof(GetLegalDocContentRequest),
            AuthenticationComponentCommand.listPersonaEntitlements2 => typeof(ListPersonaEntitlements2Request),
            AuthenticationComponentCommand.silentLogin => typeof(SilentLoginRequest),
            AuthenticationComponentCommand.checkAgeReq => typeof(CheckAgeReqRequest),
            AuthenticationComponentCommand.getOptIn => typeof(NullStruct),
            AuthenticationComponentCommand.enableOptIn => typeof(NullStruct),
            AuthenticationComponentCommand.disableOptIn => typeof(NullStruct),
            AuthenticationComponentCommand.expressLogin => typeof(ExpressLoginRequest),
            AuthenticationComponentCommand.logout => typeof(NullStruct),
            AuthenticationComponentCommand.createPersona => typeof(CreatePersonaRequest),
            AuthenticationComponentCommand.getPersona => typeof(NullStruct),
            AuthenticationComponentCommand.listPersonas => typeof(NullStruct),
            AuthenticationComponentCommand.loginPersona => typeof(LoginPersonaRequest),
            AuthenticationComponentCommand.logoutPersona => typeof(NullStruct),
            AuthenticationComponentCommand.deletePersona => typeof(NullStruct),
            AuthenticationComponentCommand.disablePersona => typeof(PersonaRequest),
            AuthenticationComponentCommand.listDeviceAccounts => typeof(ListDeviceAccountsRequest),
            AuthenticationComponentCommand.xboxCreateAccount => typeof(ConsoleCreateAccountRequest),
            AuthenticationComponentCommand.originLogin => typeof(OriginLoginRequest),
            AuthenticationComponentCommand.xboxAssociateAccount => typeof(ConsoleAssociateAccountRequest),
            AuthenticationComponentCommand.xboxLogin => typeof(XboxLoginRequest),
            AuthenticationComponentCommand.ps3CreateAccount => typeof(ConsoleCreateAccountRequest),
            AuthenticationComponentCommand.ps3AssociateAccount => typeof(ConsoleAssociateAccountRequest),
            AuthenticationComponentCommand.ps3Login => typeof(PS3LoginRequest),
            AuthenticationComponentCommand.validateSessionKey => typeof(ValidateSessionKeyRequest),
            AuthenticationComponentCommand.createWalUserSession => typeof(NullStruct),
            AuthenticationComponentCommand.acceptLegalDocs => typeof(AcceptLegalDocsRequest),
            AuthenticationComponentCommand.getLegalDocsInfo => typeof(GetLegalDocsInfoRequest),
            AuthenticationComponentCommand.getTermsOfServiceContent => typeof(GetLegalDocContentRequest),
            AuthenticationComponentCommand.deviceLoginGuest => typeof(DeviceLoginGuestRequest),
            AuthenticationComponentCommand.checkSinglePlayerLogin => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandResponseType(AuthenticationComponentCommand command) => command switch
        {
            AuthenticationComponentCommand.createAccount => typeof(CreateAccountResponse),
            AuthenticationComponentCommand.updateAccount => typeof(UpdateAccountResponse),
            AuthenticationComponentCommand.updateParentalEmail => typeof(NullStruct),
            AuthenticationComponentCommand.listUserEntitlements2 => typeof(Entitlements),
            AuthenticationComponentCommand.getAccount => typeof(AccountInfo),
            AuthenticationComponentCommand.grantEntitlement => typeof(NullStruct),
            AuthenticationComponentCommand.listEntitlements => typeof(NullStruct),
            AuthenticationComponentCommand.hasEntitlement => typeof(NullStruct),
            AuthenticationComponentCommand.getUseCount => typeof(UseCount),
            AuthenticationComponentCommand.decrementUseCount => typeof(DecrementUseCount),
            AuthenticationComponentCommand.getAuthToken => typeof(GetAuthTokenResponse),
            AuthenticationComponentCommand.getHandoffToken => typeof(GetHandoffTokenResponse),
            AuthenticationComponentCommand.getPasswordRules => typeof(PasswordRulesInfo),
            AuthenticationComponentCommand.grantEntitlement2 => typeof(GrantEntitlement2Response),
            AuthenticationComponentCommand.login => typeof(LoginResponse),
            AuthenticationComponentCommand.acceptTos => typeof(NullStruct),
            AuthenticationComponentCommand.getTosInfo => typeof(GetTosInfoResponse),
            AuthenticationComponentCommand.modifyEntitlement2 => typeof(NullStruct),
            AuthenticationComponentCommand.consumecode => typeof(ConsumecodeResponse),
            AuthenticationComponentCommand.passwordForgot => typeof(NullStruct),
            AuthenticationComponentCommand.getTermsAndConditionsContent => typeof(NullStruct),
            AuthenticationComponentCommand.getPrivacyPolicyContent => typeof(GetLegalDocContentResponse),
            AuthenticationComponentCommand.listPersonaEntitlements2 => typeof(NullStruct),
            AuthenticationComponentCommand.silentLogin => typeof(FullLoginResponse),
            AuthenticationComponentCommand.checkAgeReq => typeof(CheckAgeReqResponse),
            AuthenticationComponentCommand.getOptIn => typeof(OptInValue),
            AuthenticationComponentCommand.enableOptIn => typeof(NullStruct),
            AuthenticationComponentCommand.disableOptIn => typeof(NullStruct),
            AuthenticationComponentCommand.expressLogin => typeof(FullLoginResponse),
            AuthenticationComponentCommand.logout => typeof(NullStruct),
            AuthenticationComponentCommand.createPersona => typeof(PersonaDetails),
            AuthenticationComponentCommand.getPersona => typeof(GetPersonaResponse),
            AuthenticationComponentCommand.listPersonas => typeof(ListPersonasResponse),
            AuthenticationComponentCommand.loginPersona => typeof(SessionInfo),
            AuthenticationComponentCommand.logoutPersona => typeof(NullStruct),
            AuthenticationComponentCommand.deletePersona => typeof(NullStruct),
            AuthenticationComponentCommand.disablePersona => typeof(NullStruct),
            AuthenticationComponentCommand.listDeviceAccounts => typeof(ListDeviceAccountsResponse),
            AuthenticationComponentCommand.xboxCreateAccount => typeof(ConsoleCreateAccountResponse),
            AuthenticationComponentCommand.originLogin => typeof(FullLoginResponse),
            AuthenticationComponentCommand.xboxAssociateAccount => typeof(NullStruct),
            AuthenticationComponentCommand.xboxLogin => typeof(ConsoleLoginResponse),
            AuthenticationComponentCommand.ps3CreateAccount => typeof(ConsoleCreateAccountResponse),
            AuthenticationComponentCommand.ps3AssociateAccount => typeof(NullStruct),
            AuthenticationComponentCommand.ps3Login => typeof(ConsoleLoginResponse),
            AuthenticationComponentCommand.validateSessionKey => typeof(NullStruct),
            AuthenticationComponentCommand.createWalUserSession => typeof(NullStruct),
            AuthenticationComponentCommand.acceptLegalDocs => typeof(NullStruct),
            AuthenticationComponentCommand.getLegalDocsInfo => typeof(GetLegalDocsInfoResponse),
            AuthenticationComponentCommand.getTermsOfServiceContent => typeof(GetLegalDocContentResponse),
            AuthenticationComponentCommand.deviceLoginGuest => typeof(ConsoleLoginResponse),
            AuthenticationComponentCommand.checkSinglePlayerLogin => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandErrorResponseType(AuthenticationComponentCommand command) => command switch
        {
            AuthenticationComponentCommand.createAccount => typeof(FieldValidateErrorList),
            AuthenticationComponentCommand.updateAccount => typeof(NullStruct),
            AuthenticationComponentCommand.updateParentalEmail => typeof(NullStruct),
            AuthenticationComponentCommand.listUserEntitlements2 => typeof(NullStruct),
            AuthenticationComponentCommand.getAccount => typeof(NullStruct),
            AuthenticationComponentCommand.grantEntitlement => typeof(NullStruct),
            AuthenticationComponentCommand.listEntitlements => typeof(NullStruct),
            AuthenticationComponentCommand.hasEntitlement => typeof(NullStruct),
            AuthenticationComponentCommand.getUseCount => typeof(NullStruct),
            AuthenticationComponentCommand.decrementUseCount => typeof(NullStruct),
            AuthenticationComponentCommand.getAuthToken => typeof(NullStruct),
            AuthenticationComponentCommand.getHandoffToken => typeof(NullStruct),
            AuthenticationComponentCommand.getPasswordRules => typeof(NullStruct),
            AuthenticationComponentCommand.grantEntitlement2 => typeof(NullStruct),
            AuthenticationComponentCommand.login => typeof(CreateAccountResponse),
            AuthenticationComponentCommand.acceptTos => typeof(NullStruct),
            AuthenticationComponentCommand.getTosInfo => typeof(NullStruct),
            AuthenticationComponentCommand.modifyEntitlement2 => typeof(NullStruct),
            AuthenticationComponentCommand.consumecode => typeof(NullStruct),
            AuthenticationComponentCommand.passwordForgot => typeof(NullStruct),
            AuthenticationComponentCommand.getTermsAndConditionsContent => typeof(NullStruct),
            AuthenticationComponentCommand.getPrivacyPolicyContent => typeof(NullStruct),
            AuthenticationComponentCommand.listPersonaEntitlements2 => typeof(NullStruct),
            AuthenticationComponentCommand.silentLogin => typeof(NullStruct),
            AuthenticationComponentCommand.checkAgeReq => typeof(FieldValidateErrorList),
            AuthenticationComponentCommand.getOptIn => typeof(NullStruct),
            AuthenticationComponentCommand.enableOptIn => typeof(NullStruct),
            AuthenticationComponentCommand.disableOptIn => typeof(NullStruct),
            AuthenticationComponentCommand.expressLogin => typeof(NullStruct),
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
            AuthenticationComponentCommand.originLogin => typeof(NullStruct),
            AuthenticationComponentCommand.xboxAssociateAccount => typeof(NullStruct),
            AuthenticationComponentCommand.xboxLogin => typeof(NullStruct),
            AuthenticationComponentCommand.ps3CreateAccount => typeof(NullStruct),
            AuthenticationComponentCommand.ps3AssociateAccount => typeof(NullStruct),
            AuthenticationComponentCommand.ps3Login => typeof(NullStruct),
            AuthenticationComponentCommand.validateSessionKey => typeof(NullStruct),
            AuthenticationComponentCommand.createWalUserSession => typeof(NullStruct),
            AuthenticationComponentCommand.acceptLegalDocs => typeof(NullStruct),
            AuthenticationComponentCommand.getLegalDocsInfo => typeof(NullStruct),
            AuthenticationComponentCommand.getTermsOfServiceContent => typeof(NullStruct),
            AuthenticationComponentCommand.deviceLoginGuest => typeof(ConsoleCreateAccountRequest),
            AuthenticationComponentCommand.checkSinglePlayerLogin => typeof(NullStruct),
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
        
    }
}
