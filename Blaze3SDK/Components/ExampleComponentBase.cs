using Blaze3SDK.Blaze.Example;
using BlazeCommon;

namespace Blaze3SDK.Components
{
    public static class ExampleComponentBase
    {
        public const ushort Id = 3;
        public const string Name = "ExampleComponent";
        
        public class Server : BlazeComponent<ExampleComponentCommand, ExampleComponentNotification, Blaze3RpcError>
        {
            public Server() : base(ExampleComponentBase.Id, ExampleComponentBase.Name)
            {
                
            }
            
            [BlazeCommand((ushort)ExampleComponentCommand.poke)]
            public virtual Task<ExampleResponse> PokeAsync(ExampleRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
        }
        
        public class Client : BlazeComponent<ExampleComponentCommand, ExampleComponentNotification, Blaze3RpcError>
        {
            public Client() : base(ExampleComponentBase.Id, ExampleComponentBase.Name)
            {
                
            }
        }
        
        public enum ExampleComponentCommand : ushort
        {
            poke = 1,
        }
        
        public enum ExampleComponentNotification : ushort
        {
        }
        
    }
}
