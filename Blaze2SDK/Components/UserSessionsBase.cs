using Blaze.Core;
using Blaze2SDK.Blaze;
using EATDF;
using EATDF.Types;

namespace Blaze2SDK.Components;

public static class UserSessionsBase
{
    public const ushort Id = 30722;
    public const string Name = "UserSessions";
    
    public enum Error : ushort {
        USER_ERR_USER_NOT_FOUND = 1,
        USER_ERR_SESSION_NOT_FOUND = 2,
        USER_ERR_DUPLICATE_SESSION = 3,
        USER_ERR_NO_EXTENDED_DATA = 4,
        USER_ERR_MAX_DATA_REACHED = 5,
        USER_ERR_KEY_NOT_FOUND = 6,
        USER_ERR_INVALID_SESSION_INSTANCE = 7,
        USER_ERR_INVALID_PARAM = 8,
        ACCESS_GROUP_ERR_INVALID_GROUP = 10,
        ACCESS_GROUP_ERR_DEFAULT_GROUP = 11,
        ACCESS_GROUP_ERR_NOT_CURRENT_GROUP = 12,
        ACCESS_GROUP_ERR_CURRENT_GROUP = 13,
        ACCESS_GROUP_ERR_NO_GROUP_FOUND = 14,
    }
    
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
    
    public class Server : BlazeComponent {
        public override ushort Id => UserSessionsBase.Id;
        public override string Name => UserSessionsBase.Name;
        
        public virtual bool IsCommandSupported(UserSessionsCommand command) => false;
        
        public class UserSessionsException : BlazeRpcException
        {
            public UserSessionsException(Error error) : base((ushort)error, null) { }
            public UserSessionsException(ServerError error) : base(error.WithErrorPrefix(), null) { }
            public UserSessionsException(Error error, Tdf? errorResponse) : base((ushort)error, errorResponse) { }
            public UserSessionsException(ServerError error, Tdf? errorResponse) : base(error.WithErrorPrefix(), errorResponse) { }
            public UserSessionsException(Error error, Tdf? errorResponse, string? message) : base((ushort)error, errorResponse, message) { }
            public UserSessionsException(ServerError error, Tdf? errorResponse, string? message) : base(error.WithErrorPrefix(), errorResponse, message) { }
            public UserSessionsException(Error error, Tdf? errorResponse, string? message, Exception? innerException) : base((ushort)error, errorResponse, message, innerException) { }
            public UserSessionsException(ServerError error, Tdf? errorResponse, string? message, Exception? innerException) : base(error.WithErrorPrefix(), errorResponse, message, innerException) { }
        }
        
        public Server()
        {
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)UserSessionsCommand.lookupUserInformation,
                Name = "lookupUserInformation",
                IsSupported = IsCommandSupported(UserSessionsCommand.lookupUserInformation),
                Func = async (req, ctx) => await LookupUserInformationAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)UserSessionsCommand.lookupUsersInformation,
                Name = "lookupUsersInformation",
                IsSupported = IsCommandSupported(UserSessionsCommand.lookupUsersInformation),
                Func = async (req, ctx) => await LookupUsersInformationAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)UserSessionsCommand.fetchExtendedData,
                Name = "fetchExtendedData",
                IsSupported = IsCommandSupported(UserSessionsCommand.fetchExtendedData),
                Func = async (req, ctx) => await FetchExtendedDataAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)UserSessionsCommand.updatePingSiteLatency,
                Name = "updatePingSiteLatency",
                IsSupported = IsCommandSupported(UserSessionsCommand.updatePingSiteLatency),
                Func = async (req, ctx) => await UpdatePingSiteLatencyAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<UpdateUserSessionAttributeRequest, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)UserSessionsCommand.updateExtendedDataAttribute,
                Name = "updateExtendedDataAttribute",
                IsSupported = IsCommandSupported(UserSessionsCommand.updateExtendedDataAttribute),
                Func = async (req, ctx) => await UpdateExtendedDataAttributeAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)UserSessionsCommand.assignUserToGroup,
                Name = "assignUserToGroup",
                IsSupported = IsCommandSupported(UserSessionsCommand.assignUserToGroup),
                Func = async (req, ctx) => await AssignUserToGroupAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)UserSessionsCommand.removeUserFromGroup,
                Name = "removeUserFromGroup",
                IsSupported = IsCommandSupported(UserSessionsCommand.removeUserFromGroup),
                Func = async (req, ctx) => await RemoveUserFromGroupAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<UpdateHardwareFlagsRequest, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)UserSessionsCommand.updateHardwareFlags,
                Name = "updateHardwareFlags",
                IsSupported = IsCommandSupported(UserSessionsCommand.updateHardwareFlags),
                Func = async (req, ctx) => await UpdateHardwareFlagsAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)UserSessionsCommand.getPermissions,
                Name = "getPermissions",
                IsSupported = IsCommandSupported(UserSessionsCommand.getPermissions),
                Func = async (req, ctx) => await GetPermissionsAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)UserSessionsCommand.getAccessGroup,
                Name = "getAccessGroup",
                IsSupported = IsCommandSupported(UserSessionsCommand.getAccessGroup),
                Func = async (req, ctx) => await GetAccessGroupAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)UserSessionsCommand.checkOnlineStatus,
                Name = "checkOnlineStatus",
                IsSupported = IsCommandSupported(UserSessionsCommand.checkOnlineStatus),
                Func = async (req, ctx) => await CheckOnlineStatusAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<UserIdentification, UserData, EmptyMessage>()
            {
                Id = (ushort)UserSessionsCommand.lookupUser,
                Name = "lookupUser",
                IsSupported = IsCommandSupported(UserSessionsCommand.lookupUser),
                Func = async (req, ctx) => await LookupUserAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<LookupUsersRequest, UserDataResponse, EmptyMessage>()
            {
                Id = (ushort)UserSessionsCommand.lookupUsers,
                Name = "lookupUsers",
                IsSupported = IsCommandSupported(UserSessionsCommand.lookupUsers),
                Func = async (req, ctx) => await LookupUsersAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<NetworkInfo, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)UserSessionsCommand.updateNetworkInfo,
                Name = "updateNetworkInfo",
                IsSupported = IsCommandSupported(UserSessionsCommand.updateNetworkInfo),
                Func = async (req, ctx) => await UpdateNetworkInfoAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)UserSessionsCommand.listDefaultAccessGroup,
                Name = "listDefaultAccessGroup",
                IsSupported = IsCommandSupported(UserSessionsCommand.listDefaultAccessGroup),
                Func = async (req, ctx) => await ListDefaultAccessGroupAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)UserSessionsCommand.listAuthorization,
                Name = "listAuthorization",
                IsSupported = IsCommandSupported(UserSessionsCommand.listAuthorization),
                Func = async (req, ctx) => await ListAuthorizationAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<UserIdentification, GeoLocationData, EmptyMessage>()
            {
                Id = (ushort)UserSessionsCommand.lookupUserGeoIPData,
                Name = "lookupUserGeoIPData",
                IsSupported = IsCommandSupported(UserSessionsCommand.lookupUserGeoIPData),
                Func = async (req, ctx) => await LookupUserGeoIPDataAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<GeoLocationData, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)UserSessionsCommand.overrideUserGeoIPData,
                Name = "overrideUserGeoIPData",
                IsSupported = IsCommandSupported(UserSessionsCommand.overrideUserGeoIPData),
                Func = async (req, ctx) => await OverrideUserGeoIPDataAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<SetUserInfoAttributeRequest, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)UserSessionsCommand.setUserInfoAttribute,
                Name = "setUserInfoAttribute",
                IsSupported = IsCommandSupported(UserSessionsCommand.setUserInfoAttribute),
                Func = async (req, ctx) => await SetUserInfoAttributeAsync(req, ctx).ConfigureAwait(false)
            });
            
        }
        
        public override string GetErrorName(ushort errorCode)
        {
            return ((Error)errorCode).ToString();
        }
        
        /// <summary>
        /// This method is called when server receives a <b>UserSessions::lookupUserInformation</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> LookupUserInformationAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new UserSessionsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>UserSessions::lookupUsersInformation</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> LookupUsersInformationAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new UserSessionsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>UserSessions::fetchExtendedData</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> FetchExtendedDataAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new UserSessionsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>UserSessions::updatePingSiteLatency</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> UpdatePingSiteLatencyAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new UserSessionsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>UserSessions::updateExtendedDataAttribute</b> command.<br/>
        /// Request type: <see cref="UpdateUserSessionAttributeRequest"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> UpdateExtendedDataAttributeAsync(UpdateUserSessionAttributeRequest request, BlazeRpcContext context)
        {
            throw new UserSessionsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>UserSessions::assignUserToGroup</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> AssignUserToGroupAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new UserSessionsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>UserSessions::removeUserFromGroup</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> RemoveUserFromGroupAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new UserSessionsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>UserSessions::updateHardwareFlags</b> command.<br/>
        /// Request type: <see cref="UpdateHardwareFlagsRequest"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> UpdateHardwareFlagsAsync(UpdateHardwareFlagsRequest request, BlazeRpcContext context)
        {
            throw new UserSessionsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>UserSessions::getPermissions</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetPermissionsAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new UserSessionsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>UserSessions::getAccessGroup</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetAccessGroupAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new UserSessionsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>UserSessions::checkOnlineStatus</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> CheckOnlineStatusAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new UserSessionsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>UserSessions::lookupUser</b> command.<br/>
        /// Request type: <see cref="UserIdentification"/><br/>
        /// Response type: <see cref="UserData"/><br/>
        /// </summary>
        public virtual Task<UserData> LookupUserAsync(UserIdentification request, BlazeRpcContext context)
        {
            throw new UserSessionsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>UserSessions::lookupUsers</b> command.<br/>
        /// Request type: <see cref="LookupUsersRequest"/><br/>
        /// Response type: <see cref="UserDataResponse"/><br/>
        /// </summary>
        public virtual Task<UserDataResponse> LookupUsersAsync(LookupUsersRequest request, BlazeRpcContext context)
        {
            throw new UserSessionsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>UserSessions::updateNetworkInfo</b> command.<br/>
        /// Request type: <see cref="NetworkInfo"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> UpdateNetworkInfoAsync(NetworkInfo request, BlazeRpcContext context)
        {
            throw new UserSessionsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>UserSessions::listDefaultAccessGroup</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> ListDefaultAccessGroupAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new UserSessionsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>UserSessions::listAuthorization</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> ListAuthorizationAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new UserSessionsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>UserSessions::lookupUserGeoIPData</b> command.<br/>
        /// Request type: <see cref="UserIdentification"/><br/>
        /// Response type: <see cref="GeoLocationData"/><br/>
        /// </summary>
        public virtual Task<GeoLocationData> LookupUserGeoIPDataAsync(UserIdentification request, BlazeRpcContext context)
        {
            throw new UserSessionsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>UserSessions::overrideUserGeoIPData</b> command.<br/>
        /// Request type: <see cref="GeoLocationData"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> OverrideUserGeoIPDataAsync(GeoLocationData request, BlazeRpcContext context)
        {
            throw new UserSessionsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>UserSessions::setUserInfoAttribute</b> command.<br/>
        /// Request type: <see cref="SetUserInfoAttributeRequest"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SetUserInfoAttributeAsync(SetUserInfoAttributeRequest request, BlazeRpcContext context)
        {
            throw new UserSessionsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>UserSessions::UserSessionExtendedDataUpdate</b> notification.<br/>
        /// Notification type: <see cref="UserSessionExtendedDataUpdate"/><br/>
        /// </summary>
        public static Task NotifyUserSessionExtendedDataUpdateAsync(BlazeRpcConnection connection, UserSessionExtendedDataUpdate notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = UserSessionsBase.Id;
                frame.Command = (ushort)UserSessionsNotification.UserSessionExtendedDataUpdate;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>UserSessions::UserAdded</b> notification.<br/>
        /// Notification type: <see cref="UserIdentification"/><br/>
        /// </summary>
        public static Task NotifyUserAddedAsync(BlazeRpcConnection connection, UserIdentification notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = UserSessionsBase.Id;
                frame.Command = (ushort)UserSessionsNotification.UserAdded;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>UserSessions::UserSessionUnsubscribed</b> notification.<br/>
        /// Notification type: <see cref="UserIdentification"/><br/>
        /// </summary>
        public static Task NotifyUserSessionUnsubscribedAsync(BlazeRpcConnection connection, UserIdentification notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = UserSessionsBase.Id;
                frame.Command = (ushort)UserSessionsNotification.UserSessionUnsubscribed;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>UserSessions::UserSessionDisconnected</b> notification.<br/>
        /// Notification type: <see cref="UserSessionDisconnectReason"/><br/>
        /// </summary>
        public static Task NotifyUserSessionDisconnectedAsync(BlazeRpcConnection connection, UserSessionDisconnectReason notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = UserSessionsBase.Id;
                frame.Command = (ushort)UserSessionsNotification.UserSessionDisconnected;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
    }
    
}

