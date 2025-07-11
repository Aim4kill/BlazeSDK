using Blaze.Core;
using EATDF;
using EATDF.Types;

namespace Blaze2SDK.Components;

public static class GpsContentControllerComponentBase
{
    public const ushort Id = 27;
    public const string Name = "GpsContentControllerComponent";
    
    public enum Error : ushort {
        GPSCONTENTCONTROLLER_ERR_CONTENT_NOT_FOUND = 1,
    }
    
    public enum GpsContentControllerComponentCommand : ushort
    {
        filePetition = 1,
        fetchContent = 2,
        showContent = 3,
    }
    
    public enum GpsContentControllerComponentNotification : ushort
    {
    }
    
    public class Server : BlazeComponent {
        public override ushort Id => GpsContentControllerComponentBase.Id;
        public override string Name => GpsContentControllerComponentBase.Name;
        
        public virtual bool IsCommandSupported(GpsContentControllerComponentCommand command) => false;
        
        public class GpsContentControllerException : BlazeRpcException
        {
            public GpsContentControllerException(Error error) : base((ushort)error, null) { }
            public GpsContentControllerException(ServerError error) : base(error.WithErrorPrefix(), null) { }
            public GpsContentControllerException(Error error, Tdf? errorResponse) : base((ushort)error, errorResponse) { }
            public GpsContentControllerException(ServerError error, Tdf? errorResponse) : base(error.WithErrorPrefix(), errorResponse) { }
            public GpsContentControllerException(Error error, Tdf? errorResponse, string? message) : base((ushort)error, errorResponse, message) { }
            public GpsContentControllerException(ServerError error, Tdf? errorResponse, string? message) : base(error.WithErrorPrefix(), errorResponse, message) { }
            public GpsContentControllerException(Error error, Tdf? errorResponse, string? message, Exception? innerException) : base((ushort)error, errorResponse, message, innerException) { }
            public GpsContentControllerException(ServerError error, Tdf? errorResponse, string? message, Exception? innerException) : base(error.WithErrorPrefix(), errorResponse, message, innerException) { }
        }
        
        public Server()
        {
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GpsContentControllerComponentCommand.filePetition,
                Name = "filePetition",
                IsSupported = IsCommandSupported(GpsContentControllerComponentCommand.filePetition),
                Func = async (req, ctx) => await FilePetitionAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GpsContentControllerComponentCommand.fetchContent,
                Name = "fetchContent",
                IsSupported = IsCommandSupported(GpsContentControllerComponentCommand.fetchContent),
                Func = async (req, ctx) => await FetchContentAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GpsContentControllerComponentCommand.showContent,
                Name = "showContent",
                IsSupported = IsCommandSupported(GpsContentControllerComponentCommand.showContent),
                Func = async (req, ctx) => await ShowContentAsync(req, ctx).ConfigureAwait(false)
            });
            
        }
        
        public override string GetErrorName(ushort errorCode)
        {
            return ((Error)errorCode).ToString();
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GpsContentControllerComponent::filePetition</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> FilePetitionAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new GpsContentControllerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GpsContentControllerComponent::fetchContent</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> FetchContentAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new GpsContentControllerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GpsContentControllerComponent::showContent</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> ShowContentAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new GpsContentControllerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
    }
    
}

