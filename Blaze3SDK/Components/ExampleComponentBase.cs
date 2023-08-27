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
            
            
            public override Type GetCommandRequestType(ExampleComponentCommand command) => ExampleComponentBase.GetCommandRequestType(command);
            public override Type GetCommandResponseType(ExampleComponentCommand command) => ExampleComponentBase.GetCommandResponseType(command);
            public override Type GetCommandErrorResponseType(ExampleComponentCommand command) => ExampleComponentBase.GetCommandErrorResponseType(command);
            public override Type GetNotificationType(ExampleComponentNotification notification) => ExampleComponentBase.GetNotificationType(notification);
            
        }
        
        public class Client : BlazeComponent<ExampleComponentCommand, ExampleComponentNotification, Blaze3RpcError>
        {
            public Client() : base(ExampleComponentBase.Id, ExampleComponentBase.Name)
            {
                
            }
            
            public override Type GetCommandRequestType(ExampleComponentCommand command) => ExampleComponentBase.GetCommandRequestType(command);
            public override Type GetCommandResponseType(ExampleComponentCommand command) => ExampleComponentBase.GetCommandResponseType(command);
            public override Type GetCommandErrorResponseType(ExampleComponentCommand command) => ExampleComponentBase.GetCommandErrorResponseType(command);
            public override Type GetNotificationType(ExampleComponentNotification notification) => ExampleComponentBase.GetNotificationType(notification);
            
        }
        
        public static Type GetCommandRequestType(ExampleComponentCommand command) => command switch
        {
            ExampleComponentCommand.poke => typeof(ExampleRequest),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandResponseType(ExampleComponentCommand command) => command switch
        {
            ExampleComponentCommand.poke => typeof(ExampleResponse),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandErrorResponseType(ExampleComponentCommand command) => command switch
        {
            ExampleComponentCommand.poke => typeof(ExampleError),
            _ => typeof(NullStruct)
        };
        
        public static Type GetNotificationType(ExampleComponentNotification notification) => notification switch
        {
            _ => typeof(NullStruct)
        };
        
        public enum ExampleComponentCommand : ushort
        {
            poke = 1,
        }
        
        public enum ExampleComponentNotification : ushort
        {
        }
        
    }
}
