using BlazeCommon;

namespace Blaze3SDK.Components
{
    public static class MessagingComponentBase
    {
        public const ushort Id = 15;
        public const string Name = "MessagingComponent";
        
        public class Server : BlazeComponent<MessagingComponentCommand, MessagingComponentNotification, Blaze3RpcError>
        {
            public Server() : base(MessagingComponentBase.Id, MessagingComponentBase.Name)
            {
                
            }
            
            [BlazeCommand((ushort)MessagingComponentCommand.sendMessage)]
            public virtual Task<NullStruct> SendMessageAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)MessagingComponentCommand.fetchMessages)]
            public virtual Task<NullStruct> FetchMessagesAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)MessagingComponentCommand.purgeMessages)]
            public virtual Task<NullStruct> PurgeMessagesAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)MessagingComponentCommand.touchMessages)]
            public virtual Task<NullStruct> TouchMessagesAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)MessagingComponentCommand.getMessages)]
            public virtual Task<NullStruct> GetMessagesAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
        }
        
        public class Client : BlazeComponent<MessagingComponentCommand, MessagingComponentNotification, Blaze3RpcError>
        {
            public Client() : base(MessagingComponentBase.Id, MessagingComponentBase.Name)
            {
                
            }
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
        
    }
}
