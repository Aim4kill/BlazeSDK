using BlazeCommon;

namespace Blaze3SDK.Components
{
    public static class DynamicInetFilterComponentBase
    {
        public const ushort Id = 2000;
        public const string Name = "DynamicInetFilterComponent";
        
        public class Server : BlazeComponent<DynamicInetFilterComponentCommand, DynamicInetFilterComponentNotification, Blaze3RpcError>
        {
            public Server() : base(DynamicInetFilterComponentBase.Id, DynamicInetFilterComponentBase.Name)
            {
                
            }
            
            [BlazeCommand((ushort)DynamicInetFilterComponentCommand.add)]
            public virtual Task<NullStruct> AddAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)DynamicInetFilterComponentCommand.update)]
            public virtual Task<NullStruct> UpdateAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)DynamicInetFilterComponentCommand.remove)]
            public virtual Task<NullStruct> RemoveAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)DynamicInetFilterComponentCommand.listInfo)]
            public virtual Task<NullStruct> ListInfoAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            
            public override Type GetCommandRequestType(DynamicInetFilterComponentCommand command) => DynamicInetFilterComponentBase.GetCommandRequestType(command);
            public override Type GetCommandResponseType(DynamicInetFilterComponentCommand command) => DynamicInetFilterComponentBase.GetCommandResponseType(command);
            public override Type GetCommandErrorResponseType(DynamicInetFilterComponentCommand command) => DynamicInetFilterComponentBase.GetCommandErrorResponseType(command);
            public override Type GetNotificationType(DynamicInetFilterComponentNotification notification) => DynamicInetFilterComponentBase.GetNotificationType(notification);
            
        }
        
        public class Client : BlazeComponent<DynamicInetFilterComponentCommand, DynamicInetFilterComponentNotification, Blaze3RpcError>
        {
            public Client() : base(DynamicInetFilterComponentBase.Id, DynamicInetFilterComponentBase.Name)
            {
                
            }
            
            public override Type GetCommandRequestType(DynamicInetFilterComponentCommand command) => DynamicInetFilterComponentBase.GetCommandRequestType(command);
            public override Type GetCommandResponseType(DynamicInetFilterComponentCommand command) => DynamicInetFilterComponentBase.GetCommandResponseType(command);
            public override Type GetCommandErrorResponseType(DynamicInetFilterComponentCommand command) => DynamicInetFilterComponentBase.GetCommandErrorResponseType(command);
            public override Type GetNotificationType(DynamicInetFilterComponentNotification notification) => DynamicInetFilterComponentBase.GetNotificationType(notification);
            
        }
        
        public static Type GetCommandRequestType(DynamicInetFilterComponentCommand command) => command switch
        {
            DynamicInetFilterComponentCommand.add => typeof(NullStruct),
            DynamicInetFilterComponentCommand.update => typeof(NullStruct),
            DynamicInetFilterComponentCommand.remove => typeof(NullStruct),
            DynamicInetFilterComponentCommand.listInfo => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandResponseType(DynamicInetFilterComponentCommand command) => command switch
        {
            DynamicInetFilterComponentCommand.add => typeof(NullStruct),
            DynamicInetFilterComponentCommand.update => typeof(NullStruct),
            DynamicInetFilterComponentCommand.remove => typeof(NullStruct),
            DynamicInetFilterComponentCommand.listInfo => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandErrorResponseType(DynamicInetFilterComponentCommand command) => command switch
        {
            DynamicInetFilterComponentCommand.add => typeof(NullStruct),
            DynamicInetFilterComponentCommand.update => typeof(NullStruct),
            DynamicInetFilterComponentCommand.remove => typeof(NullStruct),
            DynamicInetFilterComponentCommand.listInfo => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetNotificationType(DynamicInetFilterComponentNotification notification) => notification switch
        {
            _ => typeof(NullStruct)
        };
        
        public enum DynamicInetFilterComponentCommand : ushort
        {
            add = 1,
            update = 2,
            remove = 3,
            listInfo = 4,
        }
        
        public enum DynamicInetFilterComponentNotification : ushort
        {
        }
        
    }
}
