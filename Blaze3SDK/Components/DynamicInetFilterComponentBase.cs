using Blaze.Core;
using EATDF;
using EATDF.Types;

namespace Blaze3SDK.Components;

public static class DynamicInetFilterComponentBase
{
    public const ushort Id = 2000;
    public const string Name = "DynamicInetFilterComponent";
    
    public enum Error : ushort {
        DYNAMICINETFILTER_ERR_ROW_NOT_FOUND = 1,
        DYNAMICINETFILTER_ERR_INVALID_GROUP = 2,
        DYNAMICINETFILTER_ERR_INVALID_OWNER = 3,
        DYNAMICINETFILTER_ERR_INVALID_SUBNET = 4,
        DYNAMICINETFILTER_ERR_INVALID_COMMENT = 5,
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
    
    public class Server : BlazeComponent {
        public override ushort Id => DynamicInetFilterComponentBase.Id;
        public override string Name => DynamicInetFilterComponentBase.Name;
        
        public virtual bool IsCommandSupported(DynamicInetFilterComponentCommand command) => false;
        
        public class DynamicInetFilterException : BlazeRpcException
        {
            public DynamicInetFilterException(Error error) : base((ushort)error, null) { }
            public DynamicInetFilterException(ServerError error) : base(error.WithErrorPrefix(), null) { }
            public DynamicInetFilterException(Error error, Tdf? errorResponse) : base((ushort)error, errorResponse) { }
            public DynamicInetFilterException(ServerError error, Tdf? errorResponse) : base(error.WithErrorPrefix(), errorResponse) { }
            public DynamicInetFilterException(Error error, Tdf? errorResponse, string? message) : base((ushort)error, errorResponse, message) { }
            public DynamicInetFilterException(ServerError error, Tdf? errorResponse, string? message) : base(error.WithErrorPrefix(), errorResponse, message) { }
            public DynamicInetFilterException(Error error, Tdf? errorResponse, string? message, Exception? innerException) : base((ushort)error, errorResponse, message, innerException) { }
            public DynamicInetFilterException(ServerError error, Tdf? errorResponse, string? message, Exception? innerException) : base(error.WithErrorPrefix(), errorResponse, message, innerException) { }
        }
        
        public Server()
        {
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)DynamicInetFilterComponentCommand.add,
                Name = "add",
                IsSupported = IsCommandSupported(DynamicInetFilterComponentCommand.add),
                Func = async (req, ctx) => await AddAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)DynamicInetFilterComponentCommand.update,
                Name = "update",
                IsSupported = IsCommandSupported(DynamicInetFilterComponentCommand.update),
                Func = async (req, ctx) => await UpdateAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)DynamicInetFilterComponentCommand.remove,
                Name = "remove",
                IsSupported = IsCommandSupported(DynamicInetFilterComponentCommand.remove),
                Func = async (req, ctx) => await RemoveAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)DynamicInetFilterComponentCommand.listInfo,
                Name = "listInfo",
                IsSupported = IsCommandSupported(DynamicInetFilterComponentCommand.listInfo),
                Func = async (req, ctx) => await ListInfoAsync(req, ctx).ConfigureAwait(false)
            });
            
        }
        
        public override string GetErrorName(ushort errorCode)
        {
            return ((Error)errorCode).ToString();
        }
        
        /// <summary>
        /// This method is called when server receives a <b>DynamicInetFilterComponent::add</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> AddAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new DynamicInetFilterException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>DynamicInetFilterComponent::update</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> UpdateAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new DynamicInetFilterException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>DynamicInetFilterComponent::remove</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> RemoveAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new DynamicInetFilterException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>DynamicInetFilterComponent::listInfo</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> ListInfoAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new DynamicInetFilterException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
    }
    
}

