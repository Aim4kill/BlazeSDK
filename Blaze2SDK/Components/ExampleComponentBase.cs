using Blaze.Core;
using EATDF;
using EATDF.Types;

namespace Blaze2SDK.Components;

public static class ExampleComponentBase
{
    public const ushort Id = 3;
    public const string Name = "ExampleComponent";
    
    public enum Error : ushort {
        EXAMPLE_ERR_UNKNOWN = 1,
    }
    
    public enum ExampleComponentCommand : ushort
    {
        poke = 1,
    }
    
    public enum ExampleComponentNotification : ushort
    {
    }
    
    public class Server : BlazeComponent {
        public override ushort Id => ExampleComponentBase.Id;
        public override string Name => ExampleComponentBase.Name;
        
        public virtual bool IsCommandSupported(ExampleComponentCommand command) => false;
        
        public class ExampleException : BlazeRpcException
        {
            public ExampleException(Error error) : base((ushort)error, null) { }
            public ExampleException(ServerError error) : base(error.WithErrorPrefix(), null) { }
            public ExampleException(Error error, Tdf? errorResponse) : base((ushort)error, errorResponse) { }
            public ExampleException(ServerError error, Tdf? errorResponse) : base(error.WithErrorPrefix(), errorResponse) { }
            public ExampleException(Error error, Tdf? errorResponse, string? message) : base((ushort)error, errorResponse, message) { }
            public ExampleException(ServerError error, Tdf? errorResponse, string? message) : base(error.WithErrorPrefix(), errorResponse, message) { }
            public ExampleException(Error error, Tdf? errorResponse, string? message, Exception? innerException) : base((ushort)error, errorResponse, message, innerException) { }
            public ExampleException(ServerError error, Tdf? errorResponse, string? message, Exception? innerException) : base(error.WithErrorPrefix(), errorResponse, message, innerException) { }
        }
        
        public Server()
        {
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ExampleComponentCommand.poke,
                Name = "poke",
                IsSupported = IsCommandSupported(ExampleComponentCommand.poke),
                Func = async (req, ctx) => await PokeAsync(req, ctx).ConfigureAwait(false)
            });
            
        }
        
        public override string GetErrorName(ushort errorCode)
        {
            return ((Error)errorCode).ToString();
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ExampleComponent::poke</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> PokeAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ExampleException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
    }
    
}

