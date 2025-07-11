using Blaze.Core;
using Blaze3SDK.Blaze.Messaging;
using EATDF;
using EATDF.Types;

namespace Blaze3SDK.Components;

public static class MessagingComponentBase
{
    public const ushort Id = 15;
    public const string Name = "MessagingComponent";
    
    public enum Error : ushort {
        MESSAGING_ERR_UNKNOWN = 1,
        MESSAGING_ERR_MAX_ATTR_EXCEEDED = 2,
        MESSAGING_ERR_DATABASE = 3,
        MESSAGING_ERR_TARGET_NOT_FOUND = 4,
        MESSAGING_ERR_TARGET_TYPE_INVALID = 5,
        MESSAGING_ERR_TARGET_INBOX_FULL = 6,
        MESSAGING_ERR_MATCH_NOT_FOUND = 7,
        MESSAGING_ERR_FEATURE_DISABLED = 8,
        MESSAGING_ERR_INVALID_PARAM = 9,
    }
    
    public enum MessagingComponentCommand : ushort
    {
        sendMessage = 1,
        fetchMessages = 2,
        purgeMessages = 3,
        touchMessages = 4,
        getMessages = 5,
    }
    
    public enum MessagingComponentNotification : ushort
    {
        NotifyMessage = 1,
    }
    
    public class Server : BlazeComponent {
        public override ushort Id => MessagingComponentBase.Id;
        public override string Name => MessagingComponentBase.Name;
        
        public virtual bool IsCommandSupported(MessagingComponentCommand command) => false;
        
        public class MessagingException : BlazeRpcException
        {
            public MessagingException(Error error) : base((ushort)error, null) { }
            public MessagingException(ServerError error) : base(error.WithErrorPrefix(), null) { }
            public MessagingException(Error error, Tdf? errorResponse) : base((ushort)error, errorResponse) { }
            public MessagingException(ServerError error, Tdf? errorResponse) : base(error.WithErrorPrefix(), errorResponse) { }
            public MessagingException(Error error, Tdf? errorResponse, string? message) : base((ushort)error, errorResponse, message) { }
            public MessagingException(ServerError error, Tdf? errorResponse, string? message) : base(error.WithErrorPrefix(), errorResponse, message) { }
            public MessagingException(Error error, Tdf? errorResponse, string? message, Exception? innerException) : base((ushort)error, errorResponse, message, innerException) { }
            public MessagingException(ServerError error, Tdf? errorResponse, string? message, Exception? innerException) : base(error.WithErrorPrefix(), errorResponse, message, innerException) { }
        }
        
        public Server()
        {
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)MessagingComponentCommand.sendMessage,
                Name = "sendMessage",
                IsSupported = IsCommandSupported(MessagingComponentCommand.sendMessage),
                Func = async (req, ctx) => await SendMessageAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)MessagingComponentCommand.fetchMessages,
                Name = "fetchMessages",
                IsSupported = IsCommandSupported(MessagingComponentCommand.fetchMessages),
                Func = async (req, ctx) => await FetchMessagesAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)MessagingComponentCommand.purgeMessages,
                Name = "purgeMessages",
                IsSupported = IsCommandSupported(MessagingComponentCommand.purgeMessages),
                Func = async (req, ctx) => await PurgeMessagesAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)MessagingComponentCommand.touchMessages,
                Name = "touchMessages",
                IsSupported = IsCommandSupported(MessagingComponentCommand.touchMessages),
                Func = async (req, ctx) => await TouchMessagesAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)MessagingComponentCommand.getMessages,
                Name = "getMessages",
                IsSupported = IsCommandSupported(MessagingComponentCommand.getMessages),
                Func = async (req, ctx) => await GetMessagesAsync(req, ctx).ConfigureAwait(false)
            });
            
        }
        
        public override string GetErrorName(ushort errorCode)
        {
            return ((Error)errorCode).ToString();
        }
        
        /// <summary>
        /// This method is called when server receives a <b>MessagingComponent::sendMessage</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SendMessageAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new MessagingException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>MessagingComponent::fetchMessages</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> FetchMessagesAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new MessagingException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>MessagingComponent::purgeMessages</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> PurgeMessagesAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new MessagingException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>MessagingComponent::touchMessages</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> TouchMessagesAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new MessagingException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>MessagingComponent::getMessages</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetMessagesAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new MessagingException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>MessagingComponent::NotifyMessage</b> notification.<br/>
        /// Notification type: <see cref="ServerMessage"/><br/>
        /// </summary>
        public static Task NotifyNotifyMessageAsync(BlazeRpcConnection connection, ServerMessage notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = MessagingComponentBase.Id;
                frame.Command = (ushort)MessagingComponentNotification.NotifyMessage;
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

