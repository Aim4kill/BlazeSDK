using Blaze2SDK.Blaze;
using BlazeCommon;

namespace Blaze2SDK.Components
{
    public static class UserSessionsBase
    {
        public const ushort Id = 30722;
        public const string Name = "UserSessions";
        
        public class Server : BlazeComponent<UserSessionsCommand, UserSessionsNotification, Blaze2RpcError>
        {
            public Server() : base(UserSessionsBase.Id, UserSessionsBase.Name)
            {
                
            }
            
            [BlazeCommand((ushort)UserSessionsCommand.lookupUserInformation)]
            public virtual Task<NullStruct> LookupUserInformationAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UserSessionsCommand.lookupUsersInformation)]
            public virtual Task<NullStruct> LookupUsersInformationAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UserSessionsCommand.fetchExtendedData)]
            public virtual Task<NullStruct> FetchExtendedDataAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UserSessionsCommand.updatePingSiteLatency)]
            public virtual Task<NullStruct> UpdatePingSiteLatencyAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UserSessionsCommand.updateExtendedDataAttribute)]
            public virtual Task<NullStruct> UpdateExtendedDataAttributeAsync(UpdateUserSessionAttributeRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UserSessionsCommand.assignUserToGroup)]
            public virtual Task<NullStruct> AssignUserToGroupAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UserSessionsCommand.removeUserFromGroup)]
            public virtual Task<NullStruct> RemoveUserFromGroupAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UserSessionsCommand.updateHardwareFlags)]
            public virtual Task<NullStruct> UpdateHardwareFlagsAsync(UpdateHardwareFlagsRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UserSessionsCommand.getPermissions)]
            public virtual Task<NullStruct> GetPermissionsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UserSessionsCommand.getAccessGroup)]
            public virtual Task<NullStruct> GetAccessGroupAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UserSessionsCommand.checkOnlineStatus)]
            public virtual Task<NullStruct> CheckOnlineStatusAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UserSessionsCommand.lookupUser)]
            public virtual Task<UserData> LookupUserAsync(UserIdentification request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UserSessionsCommand.lookupUsers)]
            public virtual Task<UserDataResponse> LookupUsersAsync(LookupUsersRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UserSessionsCommand.updateNetworkInfo)]
            public virtual Task<NullStruct> UpdateNetworkInfoAsync(NetworkInfo request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UserSessionsCommand.listDefaultAccessGroup)]
            public virtual Task<NullStruct> ListDefaultAccessGroupAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UserSessionsCommand.listAuthorization)]
            public virtual Task<NullStruct> ListAuthorizationAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UserSessionsCommand.lookupUserGeoIPData)]
            public virtual Task<GeoLocationData> LookupUserGeoIPDataAsync(UserIdentification request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UserSessionsCommand.overrideUserGeoIPData)]
            public virtual Task<NullStruct> OverrideUserGeoIPDataAsync(GeoLocationData request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UserSessionsCommand.setUserInfoAttribute)]
            public virtual Task<NullStruct> SetUserInfoAttributeAsync(SetUserInfoAttributeRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            
            public static Task NotifyUserSessionExtendedDataUpdateAsync(BlazeServerConnection connection, UserSessionExtendedDataUpdate notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(UserSessionsBase.Id, (ushort)UserSessionsNotification.UserSessionExtendedDataUpdate, notification, waitUntilFree);
            }
            
            public static Task NotifyUserAddedAsync(BlazeServerConnection connection, UserIdentification notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(UserSessionsBase.Id, (ushort)UserSessionsNotification.UserAdded, notification, waitUntilFree);
            }
            
            public static Task NotifyUserSessionUnsubscribedAsync(BlazeServerConnection connection, UserIdentification notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(UserSessionsBase.Id, (ushort)UserSessionsNotification.UserSessionUnsubscribed, notification, waitUntilFree);
            }
            
            public static Task NotifyUserSessionDisconnectedAsync(BlazeServerConnection connection, UserSessionDisconnectReason notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(UserSessionsBase.Id, (ushort)UserSessionsNotification.UserSessionDisconnected, notification, waitUntilFree);
            }
            
            public override Type GetCommandRequestType(UserSessionsCommand command) => UserSessionsBase.GetCommandRequestType(command);
            public override Type GetCommandResponseType(UserSessionsCommand command) => UserSessionsBase.GetCommandResponseType(command);
            public override Type GetCommandErrorResponseType(UserSessionsCommand command) => UserSessionsBase.GetCommandErrorResponseType(command);
            public override Type GetNotificationType(UserSessionsNotification notification) => UserSessionsBase.GetNotificationType(notification);
            
        }
        
        public class Client : BlazeComponent<UserSessionsCommand, UserSessionsNotification, Blaze2RpcError>
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
            UserSessionsCommand.lookupUserInformation => typeof(NullStruct),
            UserSessionsCommand.lookupUsersInformation => typeof(NullStruct),
            UserSessionsCommand.fetchExtendedData => typeof(NullStruct),
            UserSessionsCommand.updatePingSiteLatency => typeof(NullStruct),
            UserSessionsCommand.updateExtendedDataAttribute => typeof(UpdateUserSessionAttributeRequest),
            UserSessionsCommand.assignUserToGroup => typeof(NullStruct),
            UserSessionsCommand.removeUserFromGroup => typeof(NullStruct),
            UserSessionsCommand.updateHardwareFlags => typeof(UpdateHardwareFlagsRequest),
            UserSessionsCommand.getPermissions => typeof(NullStruct),
            UserSessionsCommand.getAccessGroup => typeof(NullStruct),
            UserSessionsCommand.checkOnlineStatus => typeof(NullStruct),
            UserSessionsCommand.lookupUser => typeof(UserIdentification),
            UserSessionsCommand.lookupUsers => typeof(LookupUsersRequest),
            UserSessionsCommand.updateNetworkInfo => typeof(NetworkInfo),
            UserSessionsCommand.listDefaultAccessGroup => typeof(NullStruct),
            UserSessionsCommand.listAuthorization => typeof(NullStruct),
            UserSessionsCommand.lookupUserGeoIPData => typeof(UserIdentification),
            UserSessionsCommand.overrideUserGeoIPData => typeof(GeoLocationData),
            UserSessionsCommand.setUserInfoAttribute => typeof(SetUserInfoAttributeRequest),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandResponseType(UserSessionsCommand command) => command switch
        {
            UserSessionsCommand.lookupUserInformation => typeof(NullStruct),
            UserSessionsCommand.lookupUsersInformation => typeof(NullStruct),
            UserSessionsCommand.fetchExtendedData => typeof(NullStruct),
            UserSessionsCommand.updatePingSiteLatency => typeof(NullStruct),
            UserSessionsCommand.updateExtendedDataAttribute => typeof(NullStruct),
            UserSessionsCommand.assignUserToGroup => typeof(NullStruct),
            UserSessionsCommand.removeUserFromGroup => typeof(NullStruct),
            UserSessionsCommand.updateHardwareFlags => typeof(NullStruct),
            UserSessionsCommand.getPermissions => typeof(NullStruct),
            UserSessionsCommand.getAccessGroup => typeof(NullStruct),
            UserSessionsCommand.checkOnlineStatus => typeof(NullStruct),
            UserSessionsCommand.lookupUser => typeof(UserData),
            UserSessionsCommand.lookupUsers => typeof(UserDataResponse),
            UserSessionsCommand.updateNetworkInfo => typeof(NullStruct),
            UserSessionsCommand.listDefaultAccessGroup => typeof(NullStruct),
            UserSessionsCommand.listAuthorization => typeof(NullStruct),
            UserSessionsCommand.lookupUserGeoIPData => typeof(GeoLocationData),
            UserSessionsCommand.overrideUserGeoIPData => typeof(NullStruct),
            UserSessionsCommand.setUserInfoAttribute => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandErrorResponseType(UserSessionsCommand command) => command switch
        {
            UserSessionsCommand.lookupUserInformation => typeof(NullStruct),
            UserSessionsCommand.lookupUsersInformation => typeof(NullStruct),
            UserSessionsCommand.fetchExtendedData => typeof(NullStruct),
            UserSessionsCommand.updatePingSiteLatency => typeof(NullStruct),
            UserSessionsCommand.updateExtendedDataAttribute => typeof(NullStruct),
            UserSessionsCommand.assignUserToGroup => typeof(NullStruct),
            UserSessionsCommand.removeUserFromGroup => typeof(NullStruct),
            UserSessionsCommand.updateHardwareFlags => typeof(NullStruct),
            UserSessionsCommand.getPermissions => typeof(NullStruct),
            UserSessionsCommand.getAccessGroup => typeof(NullStruct),
            UserSessionsCommand.checkOnlineStatus => typeof(NullStruct),
            UserSessionsCommand.lookupUser => typeof(NullStruct),
            UserSessionsCommand.lookupUsers => typeof(NullStruct),
            UserSessionsCommand.updateNetworkInfo => typeof(NullStruct),
            UserSessionsCommand.listDefaultAccessGroup => typeof(NullStruct),
            UserSessionsCommand.listAuthorization => typeof(NullStruct),
            UserSessionsCommand.lookupUserGeoIPData => typeof(NullStruct),
            UserSessionsCommand.overrideUserGeoIPData => typeof(NullStruct),
            UserSessionsCommand.setUserInfoAttribute => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetNotificationType(UserSessionsNotification notification) => notification switch
        {
            UserSessionsNotification.UserSessionExtendedDataUpdate => typeof(UserSessionExtendedDataUpdate),
            UserSessionsNotification.UserAdded => typeof(UserIdentification),
            UserSessionsNotification.UserSessionUnsubscribed => typeof(UserIdentification),
            UserSessionsNotification.UserSessionDisconnected => typeof(UserSessionDisconnectReason),
            _ => typeof(NullStruct)
        };
        
        public enum UserSessionsCommand : ushort
        {
            lookupUserInformation = 1,
            lookupUsersInformation = 2,
            fetchExtendedData = 3,
            updatePingSiteLatency = 4,
            updateExtendedDataAttribute = 5,
            assignUserToGroup = 6,
            removeUserFromGroup = 7,
            updateHardwareFlags = 8,
            getPermissions = 9,
            getAccessGroup = 10,
            checkOnlineStatus = 11,
            lookupUser = 12,
            lookupUsers = 13,
            updateNetworkInfo = 20,
            listDefaultAccessGroup = 21,
            listAuthorization = 22,
            lookupUserGeoIPData = 23,
            overrideUserGeoIPData = 24,
            setUserInfoAttribute = 25,
        }
        
        public enum UserSessionsNotification : ushort
        {
            UserSessionExtendedDataUpdate = 1,
            UserAdded = 2,
            UserSessionUnsubscribed = 3,
            UserSessionDisconnected = 4,
        }
        
    }
}
