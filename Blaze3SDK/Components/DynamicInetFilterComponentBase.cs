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
        }
        
        public class Client : BlazeComponent<DynamicInetFilterComponentCommand, DynamicInetFilterComponentNotification, Blaze3RpcError>
        {
            public Client() : base(DynamicInetFilterComponentBase.Id, DynamicInetFilterComponentBase.Name)
            {
                
            }
        }
        
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
