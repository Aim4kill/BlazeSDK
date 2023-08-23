using Blaze3SDK.Blaze.Redirector;
using BlazeCommon;

namespace Blaze3SDK.Components
{
    public static class RedirectorComponentBase
    {
        public const ushort Id = 5;
        public const string Name = "RedirectorComponent";
        
        public class Server : BlazeComponent<RedirectorComponentCommand, RedirectorComponentNotification, Blaze3RpcError>
        {
            public Server() : base(RedirectorComponentBase.Id, RedirectorComponentBase.Name)
            {
                
            }
            
            [BlazeCommand((ushort)RedirectorComponentCommand.getServerInstance)]
            public virtual Task<ServerInstanceInfo> GetServerInstanceAsync(ServerInstanceRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
        }
        
        public class Client : BlazeComponent<RedirectorComponentCommand, RedirectorComponentNotification, Blaze3RpcError>
        {
            public Client() : base(RedirectorComponentBase.Id, RedirectorComponentBase.Name)
            {
                
            }
        }
        
        public enum RedirectorComponentCommand : ushort
        {
            getServerInstance = 1,
        }
        
        public enum RedirectorComponentNotification : ushort
        {
        }
        
    }
}
