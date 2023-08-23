using Blaze3SDK.Blaze;
using BlazeCommon;

namespace Blaze3SDK.Components
{
    public static class UserSessionsBase
    {
        public const ushort Id = 30722;
        public const string Name = "UserSessions";
        
        public class Server : BlazeComponent<UserSessionsCommand, UserSessionsNotification, Blaze3RpcError>
        {
            public Server() : base(UserSessionsBase.Id, UserSessionsBase.Name)
            {
                
            }
            
            [BlazeCommand((ushort)UserSessionsCommand.fetchExtendedData)]
            public virtual Task<NullStruct> FetchExtendedDataAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UserSessionsCommand.updateExtendedDataAttribute)]
            public virtual Task<NullStruct> UpdateExtendedDataAttributeAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UserSessionsCommand.updateHardwareFlags)]
            public virtual Task<NullStruct> UpdateHardwareFlagsAsync(UpdateHardwareFlagsRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UserSessionsCommand.lookupUser)]
            public virtual Task<NullStruct> LookupUserAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UserSessionsCommand.lookupUsers)]
            public virtual Task<UserDataResponse> LookupUsersAsync(LookupUsersRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UserSessionsCommand.lookupUsersByPrefix)]
            public virtual Task<NullStruct> LookupUsersByPrefixAsync(LookupUsersByPrefixRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UserSessionsCommand.updateNetworkInfo)]
            public virtual Task<NullStruct> UpdateNetworkInfoAsync(NetworkInfo request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UserSessionsCommand.lookupUserGeoIPData)]
            public virtual Task<NullStruct> LookupUserGeoIPDataAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UserSessionsCommand.overrideUserGeoIPData)]
            public virtual Task<NullStruct> OverrideUserGeoIPDataAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UserSessionsCommand.updateUserSessionClientData)]
            public virtual Task<NullStruct> UpdateUserSessionClientDataAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UserSessionsCommand.setUserInfoAttribute)]
            public virtual Task<NullStruct> SetUserInfoAttributeAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UserSessionsCommand.resetUserGeoIPData)]
            public virtual Task<NullStruct> ResetUserGeoIPDataAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UserSessionsCommand.lookupUserSessionId)]
            public virtual Task<NullStruct> LookupUserSessionIdAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UserSessionsCommand.fetchLastLocaleUsedAndAuthError)]
            public virtual Task<NullStruct> FetchLastLocaleUsedAndAuthErrorAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UserSessionsCommand.fetchUserFirstLastAuthTime)]
            public virtual Task<NullStruct> FetchUserFirstLastAuthTimeAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UserSessionsCommand.resumeSession)]
            public virtual Task<NullStruct> ResumeSessionAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
        }
        
        public class Client : BlazeComponent<UserSessionsCommand, UserSessionsNotification, Blaze3RpcError>
        {
            public Client() : base(UserSessionsBase.Id, UserSessionsBase.Name)
            {
                
            }
        }
        
        public enum UserSessionsCommand : ushort
        {
            fetchExtendedData = 3,
            updateExtendedDataAttribute = 5,
            updateHardwareFlags = 8,
            lookupUser = 12,
            lookupUsers = 13,
            lookupUsersByPrefix = 14,
            updateNetworkInfo = 20,
            lookupUserGeoIPData = 23,
            overrideUserGeoIPData = 24,
            updateUserSessionClientData = 25,
            setUserInfoAttribute = 26,
            resetUserGeoIPData = 27,
            lookupUserSessionId = 32,
            fetchLastLocaleUsedAndAuthError = 33,
            fetchUserFirstLastAuthTime = 34,
            resumeSession = 35,
        }
        
        public enum UserSessionsNotification : ushort
        {
            UserSessionExtendedDataUpdate = 1,
            UserAdded = 2,
            UserRemoved = 3,
            UserSessionDisconnected = 4,
            UserUpdated = 5,
        }
        
    }
}
