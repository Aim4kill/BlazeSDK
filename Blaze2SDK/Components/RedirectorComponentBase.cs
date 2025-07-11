using Blaze.Core;
using Blaze2SDK.Blaze.Redirector;
using EATDF;
using EATDF.Types;

namespace Blaze2SDK.Components;

public static class RedirectorComponentBase
{
    public const ushort Id = 5;
    public const string Name = "RedirectorComponent";
    
    public enum Error : ushort 
    {
        REDIRECTOR_SERVER_NOT_FOUND = 1,
        REDIRECTOR_NO_SERVER_CAPACITY = 2,
        REDIRECTOR_NO_MATCHING_INSTANCE = 3,
        REDIRECTOR_SERVER_NAME_ALREADY_IN_USE = 4,
        REDIRECTOR_CLIENT_NOT_COMPATIBLE = 5,
        REDIRECTOR_CLIENT_UNKNOWN = 6,
        REDIRECTOR_UNKNOWN_CONNECTION_PROFILE = 7,
        REDIRECTOR_SERVER_SUNSET = 8,
        REDIRECTOR_SERVER_DOWN = 9,
    }
    
    public enum RedirectorComponentCommand : ushort
    {
        getServerInstance = 1,
        getServerList = 2,
        scheduleServerDowntime = 3,
        cancelServerDowntime = 4,
        getDowntimeList = 5,
        getDowntimeMessageTypes = 6,
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
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RedirectorComponentCommand.getServerList,
                Name = "getServerList",
                IsSupported = IsCommandSupported(RedirectorComponentCommand.getServerList),
                Func = async (req, ctx) => await GetServerListAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RedirectorComponentCommand.scheduleServerDowntime,
                Name = "scheduleServerDowntime",
                IsSupported = IsCommandSupported(RedirectorComponentCommand.scheduleServerDowntime),
                Func = async (req, ctx) => await ScheduleServerDowntimeAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RedirectorComponentCommand.cancelServerDowntime,
                Name = "cancelServerDowntime",
                IsSupported = IsCommandSupported(RedirectorComponentCommand.cancelServerDowntime),
                Func = async (req, ctx) => await CancelServerDowntimeAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RedirectorComponentCommand.getDowntimeList,
                Name = "getDowntimeList",
                IsSupported = IsCommandSupported(RedirectorComponentCommand.getDowntimeList),
                Func = async (req, ctx) => await GetDowntimeListAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RedirectorComponentCommand.getDowntimeMessageTypes,
                Name = "getDowntimeMessageTypes",
                IsSupported = IsCommandSupported(RedirectorComponentCommand.getDowntimeMessageTypes),
                Func = async (req, ctx) => await GetDowntimeMessageTypesAsync(req, ctx).ConfigureAwait(false)
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
        
        /// <summary>
        /// This method is called when server receives a <b>RedirectorComponent::getServerList</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetServerListAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RedirectorException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RedirectorComponent::scheduleServerDowntime</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> ScheduleServerDowntimeAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RedirectorException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RedirectorComponent::cancelServerDowntime</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> CancelServerDowntimeAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RedirectorException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RedirectorComponent::getDowntimeList</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetDowntimeListAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RedirectorException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RedirectorComponent::getDowntimeMessageTypes</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetDowntimeMessageTypesAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RedirectorException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
    }
    
}

