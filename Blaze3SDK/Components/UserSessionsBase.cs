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
            
            
            public static Task NotifyUserSessionExtendedDataUpdateAsync(BlazeServerConnection connection, UserSessionExtendedDataUpdate notification)
            {
                return connection.NotifyAsync(UserSessionsBase.Id, (ushort)UserSessionsNotification.UserSessionExtendedDataUpdate, notification);
            }
            
            public static Task NotifyUserAddedAsync(BlazeServerConnection connection, NotifyUserAdded notification)
            {
                return connection.NotifyAsync(UserSessionsBase.Id, (ushort)UserSessionsNotification.UserAdded, notification);
            }
            
            public static Task NotifyUserRemovedAsync(BlazeServerConnection connection, NotifyUserRemoved notification)
            {
                return connection.NotifyAsync(UserSessionsBase.Id, (ushort)UserSessionsNotification.UserRemoved, notification);
            }
            
            public static Task NotifyUserSessionDisconnectedAsync(BlazeServerConnection connection, UserSessionDisconnectReason notification)
            {
                return connection.NotifyAsync(UserSessionsBase.Id, (ushort)UserSessionsNotification.UserSessionDisconnected, notification);
            }
            
            public static Task NotifyUserUpdatedAsync(BlazeServerConnection connection, UserStatus notification)
            {
                return connection.NotifyAsync(UserSessionsBase.Id, (ushort)UserSessionsNotification.UserUpdated, notification);
            }
            
            public override Type GetCommandRequestType(UserSessionsCommand command) => UserSessionsBase.GetCommandRequestType(command);
            public override Type GetCommandResponseType(UserSessionsCommand command) => UserSessionsBase.GetCommandResponseType(command);
            public override Type GetCommandErrorResponseType(UserSessionsCommand command) => UserSessionsBase.GetCommandErrorResponseType(command);
            public override Type GetNotificationType(UserSessionsNotification notification) => UserSessionsBase.GetNotificationType(notification);
            
        }
        
        public class Client : BlazeComponent<UserSessionsCommand, UserSessionsNotification, Blaze3RpcError>
        {
            public Client() : base(UserSessionsBase.Id, UserSessionsBase.Name)
            {
                
            }
            
            public override Type GetCommandRequestType(UserSessionsCommand command) => UserSessionsBase.GetCommandRequestType(command);
            public override Type GetCommandResponseType(UserSessionsCommand command) => UserSessionsBase.GetCommandResponseType(command);
            public override Type GetCommandErrorResponseType(UserSessionsCommand command) => UserSessionsBase.GetCommandErrorResponseType(command);
            public override Type GetNotificationType(UserSessionsNotification notification) => UserSessionsBase.GetNotificationType(notification);
            
        }
        
        public static Type GetCommandRequestType(UserSessionsCommand command) => command switch
        {
            UserSessionsCommand.fetchExtendedData => typeof(NullStruct),
            UserSessionsCommand.updateExtendedDataAttribute => typeof(NullStruct),
            UserSessionsCommand.updateHardwareFlags => typeof(UpdateHardwareFlagsRequest),
            UserSessionsCommand.lookupUser => typeof(NullStruct),
            UserSessionsCommand.lookupUsers => typeof(LookupUsersRequest),
            UserSessionsCommand.lookupUsersByPrefix => typeof(LookupUsersByPrefixRequest),
            UserSessionsCommand.updateNetworkInfo => typeof(NetworkInfo),
            UserSessionsCommand.lookupUserGeoIPData => typeof(NullStruct),
            UserSessionsCommand.overrideUserGeoIPData => typeof(NullStruct),
            UserSessionsCommand.updateUserSessionClientData => typeof(NullStruct),
            UserSessionsCommand.setUserInfoAttribute => typeof(NullStruct),
            UserSessionsCommand.resetUserGeoIPData => typeof(NullStruct),
            UserSessionsCommand.lookupUserSessionId => typeof(NullStruct),
            UserSessionsCommand.fetchLastLocaleUsedAndAuthError => typeof(NullStruct),
            UserSessionsCommand.fetchUserFirstLastAuthTime => typeof(NullStruct),
            UserSessionsCommand.resumeSession => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandResponseType(UserSessionsCommand command) => command switch
        {
            UserSessionsCommand.fetchExtendedData => typeof(NullStruct),
            UserSessionsCommand.updateExtendedDataAttribute => typeof(NullStruct),
            UserSessionsCommand.updateHardwareFlags => typeof(NullStruct),
            UserSessionsCommand.lookupUser => typeof(NullStruct),
            UserSessionsCommand.lookupUsers => typeof(UserDataResponse),
            UserSessionsCommand.lookupUsersByPrefix => typeof(NullStruct),
            UserSessionsCommand.updateNetworkInfo => typeof(NullStruct),
            UserSessionsCommand.lookupUserGeoIPData => typeof(NullStruct),
            UserSessionsCommand.overrideUserGeoIPData => typeof(NullStruct),
            UserSessionsCommand.updateUserSessionClientData => typeof(NullStruct),
            UserSessionsCommand.setUserInfoAttribute => typeof(NullStruct),
            UserSessionsCommand.resetUserGeoIPData => typeof(NullStruct),
            UserSessionsCommand.lookupUserSessionId => typeof(NullStruct),
            UserSessionsCommand.fetchLastLocaleUsedAndAuthError => typeof(NullStruct),
            UserSessionsCommand.fetchUserFirstLastAuthTime => typeof(NullStruct),
            UserSessionsCommand.resumeSession => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandErrorResponseType(UserSessionsCommand command) => command switch
        {
            UserSessionsCommand.fetchExtendedData => typeof(NullStruct),
            UserSessionsCommand.updateExtendedDataAttribute => typeof(NullStruct),
            UserSessionsCommand.updateHardwareFlags => typeof(NullStruct),
            UserSessionsCommand.lookupUser => typeof(NullStruct),
            UserSessionsCommand.lookupUsers => typeof(NullStruct),
            UserSessionsCommand.lookupUsersByPrefix => typeof(NullStruct),
            UserSessionsCommand.updateNetworkInfo => typeof(NullStruct),
            UserSessionsCommand.lookupUserGeoIPData => typeof(NullStruct),
            UserSessionsCommand.overrideUserGeoIPData => typeof(NullStruct),
            UserSessionsCommand.updateUserSessionClientData => typeof(NullStruct),
            UserSessionsCommand.setUserInfoAttribute => typeof(NullStruct),
            UserSessionsCommand.resetUserGeoIPData => typeof(NullStruct),
            UserSessionsCommand.lookupUserSessionId => typeof(NullStruct),
            UserSessionsCommand.fetchLastLocaleUsedAndAuthError => typeof(NullStruct),
            UserSessionsCommand.fetchUserFirstLastAuthTime => typeof(NullStruct),
            UserSessionsCommand.resumeSession => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetNotificationType(UserSessionsNotification notification) => notification switch
        {
            UserSessionsNotification.UserSessionExtendedDataUpdate => typeof(UserSessionExtendedDataUpdate),
            UserSessionsNotification.UserAdded => typeof(NotifyUserAdded),
            UserSessionsNotification.UserRemoved => typeof(NotifyUserRemoved),
            UserSessionsNotification.UserSessionDisconnected => typeof(UserSessionDisconnectReason),
            UserSessionsNotification.UserUpdated => typeof(UserStatus),
            _ => typeof(NullStruct)
        };
        
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
