using BlazeCommon;

namespace Blaze2SDK.Components
{
    public static class ExampleComponentBase
    {
        public const ushort Id = 3;
        public const string Name = "ExampleComponent";
        
        public class Server : BlazeComponent<ExampleComponentCommand, ExampleComponentNotification, Blaze2RpcError>
        {
            public Server() : base(ExampleComponentBase.Id, ExampleComponentBase.Name)
            {
                
            }
            
            [BlazeCommand((ushort)ExampleComponentCommand.poke)]
            public virtual Task<NullStruct> PokeAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
        }
        
        public class Client : BlazeComponent<ExampleComponentCommand, ExampleComponentNotification, Blaze2RpcError>
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
