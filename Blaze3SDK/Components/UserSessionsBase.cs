using Blaze.Core;
using Blaze3SDK.Blaze;
using EATDF;
using EATDF.Types;

namespace Blaze3SDK.Components;

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
        USER_ERR_MINIMUM_CHARACTERS = 9,
        ACCESS_GROUP_ERR_INVALID_GROUP = 10,
        ACCESS_GROUP_ERR_DEFAULT_GROUP = 11,
        ACCESS_GROUP_ERR_NOT_CURRENT_GROUP = 12,
        ACCESS_GROUP_ERR_CURRENT_GROUP = 13,
        ACCESS_GROUP_ERR_NO_GROUP_FOUND = 14,
        GEOIP_INCOMPLETE_PARAMETERS = 15,
        GEOIP_UNABLE_TO_RESOLVE = 16,
        ERR_ENTITY_TYPE_NOT_FOUND = 17,
        ERR_ENTITY_NOT_FOUND = 18,
        ERR_NOT_SUPPORTED = 19,
        USER_ERR_EXISTS = 20,
        USER_ERR_RESUMABLE_SESSION_CONNECTION_INVALID = 21,
        USER_ERR_RESUMABLE_SESSION_NOT_FOUND = 22,
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
                Id = (ushort)UserSessionsCommand.fetchExtendedData,
                Name = "fetchExtendedData",
                IsSupported = IsCommandSupported(UserSessionsCommand.fetchExtendedData),
                Func = async (req, ctx) => await FetchExtendedDataAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)UserSessionsCommand.updateExtendedDataAttribute,
                Name = "updateExtendedDataAttribute",
                IsSupported = IsCommandSupported(UserSessionsCommand.updateExtendedDataAttribute),
                Func = async (req, ctx) => await UpdateExtendedDataAttributeAsync(req, ctx).ConfigureAwait(false)
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
            
            RegisterCommand(new RpcCommandFunc<LookupUsersByPrefixRequest, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)UserSessionsCommand.lookupUsersByPrefix,
                Name = "lookupUsersByPrefix",
                IsSupported = IsCommandSupported(UserSessionsCommand.lookupUsersByPrefix),
                Func = async (req, ctx) => await LookupUsersByPrefixAsync(req, ctx).ConfigureAwait(false)
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
                Id = (ushort)UserSessionsCommand.lookupUserGeoIPData,
                Name = "lookupUserGeoIPData",
                IsSupported = IsCommandSupported(UserSessionsCommand.lookupUserGeoIPData),
                Func = async (req, ctx) => await LookupUserGeoIPDataAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)UserSessionsCommand.overrideUserGeoIPData,
                Name = "overrideUserGeoIPData",
                IsSupported = IsCommandSupported(UserSessionsCommand.overrideUserGeoIPData),
                Func = async (req, ctx) => await OverrideUserGeoIPDataAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)UserSessionsCommand.updateUserSessionClientData,
                Name = "updateUserSessionClientData",
                IsSupported = IsCommandSupported(UserSessionsCommand.updateUserSessionClientData),
                Func = async (req, ctx) => await UpdateUserSessionClientDataAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)UserSessionsCommand.setUserInfoAttribute,
                Name = "setUserInfoAttribute",
                IsSupported = IsCommandSupported(UserSessionsCommand.setUserInfoAttribute),
                Func = async (req, ctx) => await SetUserInfoAttributeAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)UserSessionsCommand.resetUserGeoIPData,
                Name = "resetUserGeoIPData",
                IsSupported = IsCommandSupported(UserSessionsCommand.resetUserGeoIPData),
                Func = async (req, ctx) => await ResetUserGeoIPDataAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)UserSessionsCommand.lookupUserSessionId,
                Name = "lookupUserSessionId",
                IsSupported = IsCommandSupported(UserSessionsCommand.lookupUserSessionId),
                Func = async (req, ctx) => await LookupUserSessionIdAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)UserSessionsCommand.fetchLastLocaleUsedAndAuthError,
                Name = "fetchLastLocaleUsedAndAuthError",
                IsSupported = IsCommandSupported(UserSessionsCommand.fetchLastLocaleUsedAndAuthError),
                Func = async (req, ctx) => await FetchLastLocaleUsedAndAuthErrorAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)UserSessionsCommand.fetchUserFirstLastAuthTime,
                Name = "fetchUserFirstLastAuthTime",
                IsSupported = IsCommandSupported(UserSessionsCommand.fetchUserFirstLastAuthTime),
                Func = async (req, ctx) => await FetchUserFirstLastAuthTimeAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)UserSessionsCommand.resumeSession,
                Name = "resumeSession",
                IsSupported = IsCommandSupported(UserSessionsCommand.resumeSession),
                Func = async (req, ctx) => await ResumeSessionAsync(req, ctx).ConfigureAwait(false)
            });
            
        }
        
        public override string GetErrorName(ushort errorCode)
        {
            return ((Error)errorCode).ToString();
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
        /// This method is called when server receives a <b>UserSessions::updateExtendedDataAttribute</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> UpdateExtendedDataAttributeAsync(EmptyMessage request, BlazeRpcContext context)
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
        /// This method is called when server receives a <b>UserSessions::lookupUser</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> LookupUserAsync(EmptyMessage request, BlazeRpcContext context)
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
        /// This method is called when server receives a <b>UserSessions::lookupUsersByPrefix</b> command.<br/>
        /// Request type: <see cref="LookupUsersByPrefixRequest"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> LookupUsersByPrefixAsync(LookupUsersByPrefixRequest request, BlazeRpcContext context)
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
        /// This method is called when server receives a <b>UserSessions::lookupUserGeoIPData</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> LookupUserGeoIPDataAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new UserSessionsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>UserSessions::overrideUserGeoIPData</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> OverrideUserGeoIPDataAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new UserSessionsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>UserSessions::updateUserSessionClientData</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> UpdateUserSessionClientDataAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new UserSessionsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>UserSessions::setUserInfoAttribute</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SetUserInfoAttributeAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new UserSessionsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>UserSessions::resetUserGeoIPData</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> ResetUserGeoIPDataAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new UserSessionsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>UserSessions::lookupUserSessionId</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> LookupUserSessionIdAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new UserSessionsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>UserSessions::fetchLastLocaleUsedAndAuthError</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> FetchLastLocaleUsedAndAuthErrorAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new UserSessionsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>UserSessions::fetchUserFirstLastAuthTime</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> FetchUserFirstLastAuthTimeAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new UserSessionsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>UserSessions::resumeSession</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> ResumeSessionAsync(EmptyMessage request, BlazeRpcContext context)
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
        /// Notification type: <see cref="NotifyUserAdded"/><br/>
        /// </summary>
        public static Task NotifyUserAddedAsync(BlazeRpcConnection connection, NotifyUserAdded notification, bool sendNow = false)
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
        /// Call this method when you want to send to client a <b>UserSessions::UserRemoved</b> notification.<br/>
        /// Notification type: <see cref="NotifyUserRemoved"/><br/>
        /// </summary>
        public static Task NotifyUserRemovedAsync(BlazeRpcConnection connection, NotifyUserRemoved notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = UserSessionsBase.Id;
                frame.Command = (ushort)UserSessionsNotification.UserRemoved;
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
        
        /// <summary>
        /// Call this method when you want to send to client a <b>UserSessions::UserUpdated</b> notification.<br/>
        /// Notification type: <see cref="UserStatus"/><br/>
        /// </summary>
        public static Task NotifyUserUpdatedAsync(BlazeRpcConnection connection, UserStatus notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = UserSessionsBase.Id;
                frame.Command = (ushort)UserSessionsNotification.UserUpdated;
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

