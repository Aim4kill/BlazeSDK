using Blaze.Core;
using EATDF;
using EATDF.Types;

namespace Blaze2SDK.Components;

public static class RegistrationComponentBase
{
    public const ushort Id = 22;
    public const string Name = "RegistrationComponent";
    
    public enum Error : ushort {
        REGISTRATION_ERR_UNKNOWN = 1,
        REGISTRATION_ERR_INVALID_ARGUMENTS = 3,
        REGISTRATION_ERR_NO_UPDATE = 4,
        REGISTRATION_ERR_USER_NOT_EXIST = 5,
    }
    
    public enum RegistrationComponentCommand : ushort
    {
        check = 2,
        addrow = 3,
        ban = 4,
        remrow = 5,
        returnusers = 9,
        numusers = 10,
        updatenote = 13,
        wipestats = 14,
        updateflags = 15,
        getDbCredentials = 16,
    }
    
    public enum RegistrationComponentNotification : ushort
    {
    }
    
    public class Server : BlazeComponent {
        public override ushort Id => RegistrationComponentBase.Id;
        public override string Name => RegistrationComponentBase.Name;
        
        public virtual bool IsCommandSupported(RegistrationComponentCommand command) => false;
        
        public class RegistrationException : BlazeRpcException
        {
            public RegistrationException(Error error) : base((ushort)error, null) { }
            public RegistrationException(ServerError error) : base(error.WithErrorPrefix(), null) { }
            public RegistrationException(Error error, Tdf? errorResponse) : base((ushort)error, errorResponse) { }
            public RegistrationException(ServerError error, Tdf? errorResponse) : base(error.WithErrorPrefix(), errorResponse) { }
            public RegistrationException(Error error, Tdf? errorResponse, string? message) : base((ushort)error, errorResponse, message) { }
            public RegistrationException(ServerError error, Tdf? errorResponse, string? message) : base(error.WithErrorPrefix(), errorResponse, message) { }
            public RegistrationException(Error error, Tdf? errorResponse, string? message, Exception? innerException) : base((ushort)error, errorResponse, message, innerException) { }
            public RegistrationException(ServerError error, Tdf? errorResponse, string? message, Exception? innerException) : base(error.WithErrorPrefix(), errorResponse, message, innerException) { }
        }
        
        public Server()
        {
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RegistrationComponentCommand.check,
                Name = "check",
                IsSupported = IsCommandSupported(RegistrationComponentCommand.check),
                Func = async (req, ctx) => await CheckAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RegistrationComponentCommand.addrow,
                Name = "addrow",
                IsSupported = IsCommandSupported(RegistrationComponentCommand.addrow),
                Func = async (req, ctx) => await AddrowAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RegistrationComponentCommand.ban,
                Name = "ban",
                IsSupported = IsCommandSupported(RegistrationComponentCommand.ban),
                Func = async (req, ctx) => await BanAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RegistrationComponentCommand.remrow,
                Name = "remrow",
                IsSupported = IsCommandSupported(RegistrationComponentCommand.remrow),
                Func = async (req, ctx) => await RemrowAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RegistrationComponentCommand.returnusers,
                Name = "returnusers",
                IsSupported = IsCommandSupported(RegistrationComponentCommand.returnusers),
                Func = async (req, ctx) => await ReturnusersAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RegistrationComponentCommand.numusers,
                Name = "numusers",
                IsSupported = IsCommandSupported(RegistrationComponentCommand.numusers),
                Func = async (req, ctx) => await NumusersAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RegistrationComponentCommand.updatenote,
                Name = "updatenote",
                IsSupported = IsCommandSupported(RegistrationComponentCommand.updatenote),
                Func = async (req, ctx) => await UpdatenoteAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RegistrationComponentCommand.wipestats,
                Name = "wipestats",
                IsSupported = IsCommandSupported(RegistrationComponentCommand.wipestats),
                Func = async (req, ctx) => await WipestatsAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RegistrationComponentCommand.updateflags,
                Name = "updateflags",
                IsSupported = IsCommandSupported(RegistrationComponentCommand.updateflags),
                Func = async (req, ctx) => await UpdateflagsAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RegistrationComponentCommand.getDbCredentials,
                Name = "getDbCredentials",
                IsSupported = IsCommandSupported(RegistrationComponentCommand.getDbCredentials),
                Func = async (req, ctx) => await GetDbCredentialsAsync(req, ctx).ConfigureAwait(false)
            });
            
        }
        
        public override string GetErrorName(ushort errorCode)
        {
            return ((Error)errorCode).ToString();
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RegistrationComponent::check</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> CheckAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RegistrationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RegistrationComponent::addrow</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> AddrowAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RegistrationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RegistrationComponent::ban</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> BanAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RegistrationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RegistrationComponent::remrow</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> RemrowAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RegistrationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RegistrationComponent::returnusers</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> ReturnusersAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RegistrationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RegistrationComponent::numusers</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> NumusersAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RegistrationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RegistrationComponent::updatenote</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> UpdatenoteAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RegistrationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RegistrationComponent::wipestats</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> WipestatsAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RegistrationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RegistrationComponent::updateflags</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> UpdateflagsAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RegistrationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RegistrationComponent::getDbCredentials</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetDbCredentialsAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RegistrationException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
    }
    
}

