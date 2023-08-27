using Blaze2SDK.Blaze.Messaging;
using BlazeCommon;

namespace Blaze2SDK.Components
{
    public static class MessagingComponentBase
    {
        public const ushort Id = 15;
        public const string Name = "MessagingComponent";
        
        public class Server : BlazeComponent<MessagingComponentCommand, MessagingComponentNotification, Blaze2RpcError>
        {
            public Server() : base(MessagingComponentBase.Id, MessagingComponentBase.Name)
            {
                
            }
            
            [BlazeCommand((ushort)MessagingComponentCommand.sendMessage)]
            public virtual Task<SendMessageResponse> SendMessageAsync(ClientMessage request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)MessagingComponentCommand.fetchMessages)]
            public virtual Task<FetchMessageResponse> FetchMessagesAsync(FetchMessageRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)MessagingComponentCommand.purgeMessages)]
            public virtual Task<PurgeMessageResponse> PurgeMessagesAsync(PurgeMessageRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)MessagingComponentCommand.touchMessages)]
            public virtual Task<TouchMessageResponse> TouchMessagesAsync(TouchMessageRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)MessagingComponentCommand.getMessages)]
            public virtual Task<NullStruct> GetMessagesAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            
            public static Task NotifyMessageAsync(BlazeServerConnection connection, ServerMessage notification)
            {
                return connection.NotifyAsync(MessagingComponentBase.Id, (ushort)MessagingComponentNotification.NotifyMessage, notification);
            }
            
            public override Type GetCommandRequestType(MessagingComponentCommand command) => MessagingComponentBase.GetCommandRequestType(command);
            public override Type GetCommandResponseType(MessagingComponentCommand command) => MessagingComponentBase.GetCommandResponseType(command);
            public override Type GetCommandErrorResponseType(MessagingComponentCommand command) => MessagingComponentBase.GetCommandErrorResponseType(command);
            public override Type GetNotificationType(MessagingComponentNotification notification) => MessagingComponentBase.GetNotificationType(notification);
            
        }
        
        public class Client : BlazeComponent<MessagingComponentCommand, MessagingComponentNotification, Blaze2RpcError>
        {
            public Client() : base(MessagingComponentBase.Id, MessagingComponentBase.Name)
            {
                
            }
            
            public override Type GetCommandRequestType(MessagingComponentCommand command) => MessagingComponentBase.GetCommandRequestType(command);
            public override Type GetCommandResponseType(MessagingComponentCommand command) => MessagingComponentBase.GetCommandResponseType(command);
            public override Type GetCommandErrorResponseType(MessagingComponentCommand command) => MessagingComponentBase.GetCommandErrorResponseType(command);
            public override Type GetNotificationType(MessagingComponentNotification notification) => MessagingComponentBase.GetNotificationType(notification);
            
        }
        
        public static Type GetCommandRequestType(MessagingComponentCommand command) => command switch
        {
            MessagingComponentCommand.sendMessage => typeof(ClientMessage),
            MessagingComponentCommand.fetchMessages => typeof(FetchMessageRequest),
            MessagingComponentCommand.purgeMessages => typeof(PurgeMessageRequest),
            MessagingComponentCommand.touchMessages => typeof(TouchMessageRequest),
            MessagingComponentCommand.getMessages => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandResponseType(MessagingComponentCommand command) => command switch
        {
            MessagingComponentCommand.sendMessage => typeof(SendMessageResponse),
            MessagingComponentCommand.fetchMessages => typeof(FetchMessageResponse),
            MessagingComponentCommand.purgeMessages => typeof(PurgeMessageResponse),
            MessagingComponentCommand.touchMessages => typeof(TouchMessageResponse),
            MessagingComponentCommand.getMessages => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandErrorResponseType(MessagingComponentCommand command) => command switch
        {
            MessagingComponentCommand.sendMessage => typeof(NullStruct),
            MessagingComponentCommand.fetchMessages => typeof(NullStruct),
            MessagingComponentCommand.purgeMessages => typeof(NullStruct),
            MessagingComponentCommand.touchMessages => typeof(NullStruct),
            MessagingComponentCommand.getMessages => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetNotificationType(MessagingComponentNotification notification) => notification switch
        {
            MessagingComponentNotification.NotifyMessage => typeof(ServerMessage),
            _ => typeof(NullStruct)
        };
        
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
        
    }
}
