using Blaze.Core;
using Blaze3SDK.Blaze.Redirector;
using EATDF;
using EATDF.Types;

namespace Blaze3SDK.Components;

public static class RedirectorComponentBase
{
    public const ushort Id = 5;
    public const string Name = "RedirectorComponent";
    
    public enum Error : ushort {
        REDIRECTOR_SERVER_NOT_FOUND = 1,
        REDIRECTOR_NO_SERVER_CAPACITY = 2,
        REDIRECTOR_NO_MATCHING_INSTANCE = 3,
        REDIRECTOR_SERVER_NAME_ALREADY_IN_USE = 4,
        REDIRECTOR_CLIENT_NOT_COMPATIBLE = 5,
        REDIRECTOR_CLIENT_UNKNOWN = 6,
        REDIRECTOR_UNKNOWN_CONNECTION_PROFILE = 7,
        REDIRECTOR_SERVER_SUNSET = 8,
        REDIRECTOR_SERVER_DOWN = 9,
        REDIRECTOR_INVALID_PARAMETER = 10,
        REDIRECTOR_UNKNOWN_SERVICE_NAME = 11,
        REDIRECTOR_PAST_EVENT = 12,
        REDIRECTOR_UNKNOWN_SCHEDULE_ID = 13,
    }
    
    public enum RedirectorComponentCommand : ushort
    {
        getServerInstance = 1,
    }
    
    public enum RedirectorComponentNotification : ushort
    {
    }
    
    public class Server : BlazeComponent {
        public override ushort Id => RedirectorComponentBase.Id;
        public override string Name => RedirectorComponentBase.Name;
        
        public virtual bool IsCommandSupported(RedirectorComponentCommand command) => false;
        
        public class RedirectorException : BlazeRpcException
        {
            public RedirectorException(Error error) : base((ushort)error, null) { }
            public RedirectorException(ServerError error) : base(error.WithErrorPrefix(), null) { }
            public RedirectorException(Error error, Tdf? errorResponse) : base((ushort)error, errorResponse) { }
            public RedirectorException(ServerError error, Tdf? errorResponse) : base(error.WithErrorPrefix(), errorResponse) { }
            public RedirectorException(Error error, Tdf? errorResponse, string? message) : base((ushort)error, errorResponse, message) { }
            public RedirectorException(ServerError error, Tdf? errorResponse, string? message) : base(error.WithErrorPrefix(), errorResponse, message) { }
            public RedirectorException(Error error, Tdf? errorResponse, string? message, Exception? innerException) : base((ushort)error, errorResponse, message, innerException) { }
            public RedirectorException(ServerError error, Tdf? errorResponse, string? message, Exception? innerException) : base(error.WithErrorPrefix(), errorResponse, message, innerException) { }
        }
        
        public Server()
        {
            RegisterCommand(new RpcCommandFunc<ServerInstanceRequest, ServerInstanceInfo, ServerInstanceError>()
            {
                Id = (ushort)RedirectorComponentCommand.getServerInstance,
                Name = "getServerInstance",
                IsSupported = IsCommandSupported(RedirectorComponentCommand.getServerInstance),
                Func = async (req, ctx) => await GetServerInstanceAsync(req, ctx).ConfigureAwait(false)
            });
            
        }
        
        public override string GetErrorName(ushort errorCode)
        {
            return ((Error)errorCode).ToString();
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RedirectorComponent::getServerInstance</b> command.<br/>
        /// Request type: <see cref="ServerInstanceRequest"/><br/>
        /// Response type: <see cref="ServerInstanceInfo"/><br/>
        /// Error response type: <see cref="ServerInstanceError"/><br/>
        /// </summary>
        public virtual Task<ServerInstanceInfo> GetServerInstanceAsync(ServerInstanceRequest request, BlazeRpcContext context)
        {
            throw new RedirectorException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
    }
    
}

