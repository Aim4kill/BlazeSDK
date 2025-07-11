using Blaze.Core;
using Blaze2SDK.Blaze.Playgroups;
using EATDF;
using EATDF.Types;

namespace Blaze2SDK.Components;

public static class PlaygroupsComponentBase
{
    public const ushort Id = 6;
    public const string Name = "PlaygroupsComponent";
    
    public enum Error : ushort {
        PLAYGROUPS_ERR_NOT_IN_GROUP = 1,
        PLAYGROUPS_ERR_NOT_AUTHORIZED = 2,
        PLAYGROUPS_ERR_GROUP_FULL = 3,
        PLAYGROUPS_ERR_INVALID_ENTITY = 4,
        PLAYGROUPS_ERR_GROUP_NOT_FOUND = 5,
        PLAYGROUPS_ERR_GROUP_CLOSED = 6,
        PLAYGROUPS_ERR_USER_NOT_IN_ANY_GROUP = 7,
        PLAYGROUPS_ERR_GROUP_ALREADY_EXISTS = 8,
    }
    
    public enum PlaygroupsComponentCommand : ushort
    {
        createPlaygroup = 1,
        destroyPlaygroup = 2,
        joinPlaygroup = 3,
        leavePlaygroup = 4,
        setPlaygroupAttributes = 5,
        setMemberAttributes = 6,
        kickPlaygroupMember = 7,
        setPlaygroupJoinControls = 8,
        finalizePlaygroupCreation = 9,
        lookupPlaygroupInfo = 10,
    }
    
    public enum PlaygroupsComponentNotification : ushort
    {
        NotifyDestroyPlaygroup = 50,
        NotifyJoinPlaygroup = 51,
        NotifyMemberJoinedPlaygroup = 52,
        NotifyMemberRemovedFromPlaygroup = 53,
        NotifyPlaygroupAttributesSet = 54,
        NotifyMemberAttributesSet = 75,
        NotifyLeaderChange = 79,
        NotifyMemberPermissionsChange = 80,
        NotifyJoinControlsChange = 85,
        NotifyXboxSessionInfo = 86,
    }
    
    public class Server : BlazeComponent {
        public override ushort Id => PlaygroupsComponentBase.Id;
        public override string Name => PlaygroupsComponentBase.Name;
        
        public virtual bool IsCommandSupported(PlaygroupsComponentCommand command) => false;
        
        public class PlaygroupsException : BlazeRpcException
        {
            public PlaygroupsException(Error error) : base((ushort)error, null) { }
            public PlaygroupsException(ServerError error) : base(error.WithErrorPrefix(), null) { }
            public PlaygroupsException(Error error, Tdf? errorResponse) : base((ushort)error, errorResponse) { }
            public PlaygroupsException(ServerError error, Tdf? errorResponse) : base(error.WithErrorPrefix(), errorResponse) { }
            public PlaygroupsException(Error error, Tdf? errorResponse, string? message) : base((ushort)error, errorResponse, message) { }
            public PlaygroupsException(ServerError error, Tdf? errorResponse, string? message) : base(error.WithErrorPrefix(), errorResponse, message) { }
            public PlaygroupsException(Error error, Tdf? errorResponse, string? message, Exception? innerException) : base((ushort)error, errorResponse, message, innerException) { }
            public PlaygroupsException(ServerError error, Tdf? errorResponse, string? message, Exception? innerException) : base(error.WithErrorPrefix(), errorResponse, message, innerException) { }
        }
        
        public Server()
        {
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)PlaygroupsComponentCommand.createPlaygroup,
                Name = "createPlaygroup",
                IsSupported = IsCommandSupported(PlaygroupsComponentCommand.createPlaygroup),
                Func = async (req, ctx) => await CreatePlaygroupAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)PlaygroupsComponentCommand.destroyPlaygroup,
                Name = "destroyPlaygroup",
                IsSupported = IsCommandSupported(PlaygroupsComponentCommand.destroyPlaygroup),
                Func = async (req, ctx) => await DestroyPlaygroupAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)PlaygroupsComponentCommand.joinPlaygroup,
                Name = "joinPlaygroup",
                IsSupported = IsCommandSupported(PlaygroupsComponentCommand.joinPlaygroup),
                Func = async (req, ctx) => await JoinPlaygroupAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)PlaygroupsComponentCommand.leavePlaygroup,
                Name = "leavePlaygroup",
                IsSupported = IsCommandSupported(PlaygroupsComponentCommand.leavePlaygroup),
                Func = async (req, ctx) => await LeavePlaygroupAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)PlaygroupsComponentCommand.setPlaygroupAttributes,
                Name = "setPlaygroupAttributes",
                IsSupported = IsCommandSupported(PlaygroupsComponentCommand.setPlaygroupAttributes),
                Func = async (req, ctx) => await SetPlaygroupAttributesAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)PlaygroupsComponentCommand.setMemberAttributes,
                Name = "setMemberAttributes",
                IsSupported = IsCommandSupported(PlaygroupsComponentCommand.setMemberAttributes),
                Func = async (req, ctx) => await SetMemberAttributesAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)PlaygroupsComponentCommand.kickPlaygroupMember,
                Name = "kickPlaygroupMember",
                IsSupported = IsCommandSupported(PlaygroupsComponentCommand.kickPlaygroupMember),
                Func = async (req, ctx) => await KickPlaygroupMemberAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)PlaygroupsComponentCommand.setPlaygroupJoinControls,
                Name = "setPlaygroupJoinControls",
                IsSupported = IsCommandSupported(PlaygroupsComponentCommand.setPlaygroupJoinControls),
                Func = async (req, ctx) => await SetPlaygroupJoinControlsAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)PlaygroupsComponentCommand.finalizePlaygroupCreation,
                Name = "finalizePlaygroupCreation",
                IsSupported = IsCommandSupported(PlaygroupsComponentCommand.finalizePlaygroupCreation),
                Func = async (req, ctx) => await FinalizePlaygroupCreationAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)PlaygroupsComponentCommand.lookupPlaygroupInfo,
                Name = "lookupPlaygroupInfo",
                IsSupported = IsCommandSupported(PlaygroupsComponentCommand.lookupPlaygroupInfo),
                Func = async (req, ctx) => await LookupPlaygroupInfoAsync(req, ctx).ConfigureAwait(false)
            });
            
        }
        
        public override string GetErrorName(ushort errorCode)
        {
            return ((Error)errorCode).ToString();
        }
        
        /// <summary>
        /// This method is called when server receives a <b>PlaygroupsComponent::createPlaygroup</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> CreatePlaygroupAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new PlaygroupsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>PlaygroupsComponent::destroyPlaygroup</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> DestroyPlaygroupAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new PlaygroupsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>PlaygroupsComponent::joinPlaygroup</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> JoinPlaygroupAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new PlaygroupsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>PlaygroupsComponent::leavePlaygroup</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> LeavePlaygroupAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new PlaygroupsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>PlaygroupsComponent::setPlaygroupAttributes</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SetPlaygroupAttributesAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new PlaygroupsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>PlaygroupsComponent::setMemberAttributes</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SetMemberAttributesAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new PlaygroupsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>PlaygroupsComponent::kickPlaygroupMember</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> KickPlaygroupMemberAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new PlaygroupsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>PlaygroupsComponent::setPlaygroupJoinControls</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SetPlaygroupJoinControlsAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new PlaygroupsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>PlaygroupsComponent::finalizePlaygroupCreation</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> FinalizePlaygroupCreationAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new PlaygroupsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>PlaygroupsComponent::lookupPlaygroupInfo</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> LookupPlaygroupInfoAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new PlaygroupsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>PlaygroupsComponent::NotifyDestroyPlaygroup</b> notification.<br/>
        /// Notification type: <see cref="NotifyDestroyPlaygroup"/><br/>
        /// </summary>
        public static Task NotifyNotifyDestroyPlaygroupAsync(BlazeRpcConnection connection, NotifyDestroyPlaygroup notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = PlaygroupsComponentBase.Id;
                frame.Command = (ushort)PlaygroupsComponentNotification.NotifyDestroyPlaygroup;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>PlaygroupsComponent::NotifyJoinPlaygroup</b> notification.<br/>
        /// Notification type: <see cref="NotifyJoinPlaygroup"/><br/>
        /// </summary>
        public static Task NotifyNotifyJoinPlaygroupAsync(BlazeRpcConnection connection, NotifyJoinPlaygroup notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = PlaygroupsComponentBase.Id;
                frame.Command = (ushort)PlaygroupsComponentNotification.NotifyJoinPlaygroup;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>PlaygroupsComponent::NotifyMemberJoinedPlaygroup</b> notification.<br/>
        /// Notification type: <see cref="NotifyMemberJoinedPlaygroup"/><br/>
        /// </summary>
        public static Task NotifyNotifyMemberJoinedPlaygroupAsync(BlazeRpcConnection connection, NotifyMemberJoinedPlaygroup notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = PlaygroupsComponentBase.Id;
                frame.Command = (ushort)PlaygroupsComponentNotification.NotifyMemberJoinedPlaygroup;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>PlaygroupsComponent::NotifyMemberRemovedFromPlaygroup</b> notification.<br/>
        /// Notification type: <see cref="NotifyMemberRemoveFromPlaygroup"/><br/>
        /// </summary>
        public static Task NotifyNotifyMemberRemovedFromPlaygroupAsync(BlazeRpcConnection connection, NotifyMemberRemoveFromPlaygroup notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = PlaygroupsComponentBase.Id;
                frame.Command = (ushort)PlaygroupsComponentNotification.NotifyMemberRemovedFromPlaygroup;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>PlaygroupsComponent::NotifyPlaygroupAttributesSet</b> notification.<br/>
        /// Notification type: <see cref="NotifyPlaygroupAttributesSet"/><br/>
        /// </summary>
        public static Task NotifyNotifyPlaygroupAttributesSetAsync(BlazeRpcConnection connection, NotifyPlaygroupAttributesSet notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = PlaygroupsComponentBase.Id;
                frame.Command = (ushort)PlaygroupsComponentNotification.NotifyPlaygroupAttributesSet;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>PlaygroupsComponent::NotifyMemberAttributesSet</b> notification.<br/>
        /// Notification type: <see cref="NotifyMemberAttributesSet"/><br/>
        /// </summary>
        public static Task NotifyNotifyMemberAttributesSetAsync(BlazeRpcConnection connection, NotifyMemberAttributesSet notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = PlaygroupsComponentBase.Id;
                frame.Command = (ushort)PlaygroupsComponentNotification.NotifyMemberAttributesSet;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>PlaygroupsComponent::NotifyLeaderChange</b> notification.<br/>
        /// Notification type: <see cref="NotifyLeaderChange"/><br/>
        /// </summary>
        public static Task NotifyNotifyLeaderChangeAsync(BlazeRpcConnection connection, NotifyLeaderChange notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = PlaygroupsComponentBase.Id;
                frame.Command = (ushort)PlaygroupsComponentNotification.NotifyLeaderChange;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>PlaygroupsComponent::NotifyMemberPermissionsChange</b> notification.<br/>
        /// Notification type: <see cref="NotifyMemberPermissionsChange"/><br/>
        /// </summary>
        public static Task NotifyNotifyMemberPermissionsChangeAsync(BlazeRpcConnection connection, NotifyMemberPermissionsChange notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = PlaygroupsComponentBase.Id;
                frame.Command = (ushort)PlaygroupsComponentNotification.NotifyMemberPermissionsChange;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>PlaygroupsComponent::NotifyJoinControlsChange</b> notification.<br/>
        /// Notification type: <see cref="NotifyJoinControlsChange"/><br/>
        /// </summary>
        public static Task NotifyNotifyJoinControlsChangeAsync(BlazeRpcConnection connection, NotifyJoinControlsChange notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = PlaygroupsComponentBase.Id;
                frame.Command = (ushort)PlaygroupsComponentNotification.NotifyJoinControlsChange;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>PlaygroupsComponent::NotifyXboxSessionInfo</b> notification.<br/>
        /// Notification type: <see cref="NotifyXboxSessionInfo"/><br/>
        /// </summary>
        public static Task NotifyNotifyXboxSessionInfoAsync(BlazeRpcConnection connection, NotifyXboxSessionInfo notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = PlaygroupsComponentBase.Id;
                frame.Command = (ushort)PlaygroupsComponentNotification.NotifyXboxSessionInfo;
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

