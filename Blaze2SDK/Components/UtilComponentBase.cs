using Blaze.Core;
using Blaze2SDK.Blaze;
using Blaze2SDK.Blaze.Util;
using EATDF;
using EATDF.Types;

namespace Blaze2SDK.Components;

public static class UtilComponentBase
{
    public const ushort Id = 9;
    public const string Name = "UtilComponent";
    
    public enum Error : ushort {
        UTIL_CONFIG_NOT_FOUND = 100,
        UTIL_TELEMETRY_NO_SERVERS_AVAILABLE = 150,
        UTIL_TELEMETRY_OUT_OF_MEMORY = 151,
        UTIL_TELEMETRY_KEY_TOO_LONG = 152,
        UTIL_TELEMETRY_INVALID_MAC_ADDRESS = 153,
        UTIL_TICKER_NO_SERVERS_AVAILABLE = 155,
        UTIL_TICKER_KEY_TOO_LONG = 156,
        UTIL_USS_RECORD_NOT_FOUND = 200,
        UTIL_USS_TOO_MANY_KEYS = 201,
        UTIL_USS_DB_ERROR = 202,
        UTIL_USS_USER_NO_EXTENDED_DATA = 250,
    }
    
    public enum UtilComponentCommand : ushort
    {
        fetchClientConfig = 1,
        ping = 2,
        setClientData = 3,
        localizeStrings = 4,
        getTelemetryServer = 5,
        getTickerServer = 6,
        preAuth = 7,
        postAuth = 8,
        userSettingsLoad = 10,
        userSettingsSave = 11,
        userSettingsLoadAll = 12,
        userSettingsLoadAllForUserId = 13,
        filterForProfanity = 20,
        fetchQosConfig = 21,
        setClientMetrics = 22,
        setConnectionState = 23,
    }
    
    public enum UtilComponentNotification : ushort
    {
    }
    
    public class Server : BlazeComponent {
        public override ushort Id => UtilComponentBase.Id;
        public override string Name => UtilComponentBase.Name;
        
        public virtual bool IsCommandSupported(UtilComponentCommand command) => false;
        
        public class UtilException : BlazeRpcException
        {
            public UtilException(Error error) : base((ushort)error, null) { }
            public UtilException(ServerError error) : base(error.WithErrorPrefix(), null) { }
            public UtilException(Error error, Tdf? errorResponse) : base((ushort)error, errorResponse) { }
            public UtilException(ServerError error, Tdf? errorResponse) : base(error.WithErrorPrefix(), errorResponse) { }
            public UtilException(Error error, Tdf? errorResponse, string? message) : base((ushort)error, errorResponse, message) { }
            public UtilException(ServerError error, Tdf? errorResponse, string? message) : base(error.WithErrorPrefix(), errorResponse, message) { }
            public UtilException(Error error, Tdf? errorResponse, string? message, Exception? innerException) : base((ushort)error, errorResponse, message, innerException) { }
            public UtilException(ServerError error, Tdf? errorResponse, string? message, Exception? innerException) : base(error.WithErrorPrefix(), errorResponse, message, innerException) { }
        }
        
        public Server()
        {
            RegisterCommand(new RpcCommandFunc<FetchClientConfigRequest, FetchConfigResponse, EmptyMessage>()
            {
                Id = (ushort)UtilComponentCommand.fetchClientConfig,
                Name = "fetchClientConfig",
                IsSupported = IsCommandSupported(UtilComponentCommand.fetchClientConfig),
                Func = async (req, ctx) => await FetchClientConfigAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, PingResponse, EmptyMessage>()
            {
                Id = (ushort)UtilComponentCommand.ping,
                Name = "ping",
                IsSupported = IsCommandSupported(UtilComponentCommand.ping),
                Func = async (req, ctx) => await PingAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<ClientData, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)UtilComponentCommand.setClientData,
                Name = "setClientData",
                IsSupported = IsCommandSupported(UtilComponentCommand.setClientData),
                Func = async (req, ctx) => await SetClientDataAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)UtilComponentCommand.localizeStrings,
                Name = "localizeStrings",
                IsSupported = IsCommandSupported(UtilComponentCommand.localizeStrings),
                Func = async (req, ctx) => await LocalizeStringsAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<GetTelemetryServerRequest, GetTelemetryServerResponse, EmptyMessage>()
            {
                Id = (ushort)UtilComponentCommand.getTelemetryServer,
                Name = "getTelemetryServer",
                IsSupported = IsCommandSupported(UtilComponentCommand.getTelemetryServer),
                Func = async (req, ctx) => await GetTelemetryServerAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, GetTickerServerResponse, EmptyMessage>()
            {
                Id = (ushort)UtilComponentCommand.getTickerServer,
                Name = "getTickerServer",
                IsSupported = IsCommandSupported(UtilComponentCommand.getTickerServer),
                Func = async (req, ctx) => await GetTickerServerAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<PreAuthRequest, PreAuthResponse, EmptyMessage>()
            {
                Id = (ushort)UtilComponentCommand.preAuth,
                Name = "preAuth",
                IsSupported = IsCommandSupported(UtilComponentCommand.preAuth),
                Func = async (req, ctx) => await PreAuthAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, PostAuthResponse, EmptyMessage>()
            {
                Id = (ushort)UtilComponentCommand.postAuth,
                Name = "postAuth",
                IsSupported = IsCommandSupported(UtilComponentCommand.postAuth),
                Func = async (req, ctx) => await PostAuthAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)UtilComponentCommand.userSettingsLoad,
                Name = "userSettingsLoad",
                IsSupported = IsCommandSupported(UtilComponentCommand.userSettingsLoad),
                Func = async (req, ctx) => await UserSettingsLoadAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)UtilComponentCommand.userSettingsSave,
                Name = "userSettingsSave",
                IsSupported = IsCommandSupported(UtilComponentCommand.userSettingsSave),
                Func = async (req, ctx) => await UserSettingsSaveAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)UtilComponentCommand.userSettingsLoadAll,
                Name = "userSettingsLoadAll",
                IsSupported = IsCommandSupported(UtilComponentCommand.userSettingsLoadAll),
                Func = async (req, ctx) => await UserSettingsLoadAllAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)UtilComponentCommand.userSettingsLoadAllForUserId,
                Name = "userSettingsLoadAllForUserId",
                IsSupported = IsCommandSupported(UtilComponentCommand.userSettingsLoadAllForUserId),
                Func = async (req, ctx) => await UserSettingsLoadAllForUserIdAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<FilterUserTextResponse, FilterUserTextResponse, EmptyMessage>()
            {
                Id = (ushort)UtilComponentCommand.filterForProfanity,
                Name = "filterForProfanity",
                IsSupported = IsCommandSupported(UtilComponentCommand.filterForProfanity),
                Func = async (req, ctx) => await FilterForProfanityAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, QosConfigInfo, EmptyMessage>()
            {
                Id = (ushort)UtilComponentCommand.fetchQosConfig,
                Name = "fetchQosConfig",
                IsSupported = IsCommandSupported(UtilComponentCommand.fetchQosConfig),
                Func = async (req, ctx) => await FetchQosConfigAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<ClientMetrics, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)UtilComponentCommand.setClientMetrics,
                Name = "setClientMetrics",
                IsSupported = IsCommandSupported(UtilComponentCommand.setClientMetrics),
                Func = async (req, ctx) => await SetClientMetricsAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)UtilComponentCommand.setConnectionState,
                Name = "setConnectionState",
                IsSupported = IsCommandSupported(UtilComponentCommand.setConnectionState),
                Func = async (req, ctx) => await SetConnectionStateAsync(req, ctx).ConfigureAwait(false)
            });
            
        }
        
        public override string GetErrorName(ushort errorCode)
        {
            return ((Error)errorCode).ToString();
        }
        
        /// <summary>
        /// This method is called when server receives a <b>UtilComponent::fetchClientConfig</b> command.<br/>
        /// Request type: <see cref="FetchClientConfigRequest"/><br/>
        /// Response type: <see cref="FetchConfigResponse"/><br/>
        /// </summary>
        public virtual Task<FetchConfigResponse> FetchClientConfigAsync(FetchClientConfigRequest request, BlazeRpcContext context)
        {
            throw new UtilException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>UtilComponent::ping</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="PingResponse"/><br/>
        /// </summary>
        public virtual Task<PingResponse> PingAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new UtilException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>UtilComponent::setClientData</b> command.<br/>
        /// Request type: <see cref="ClientData"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SetClientDataAsync(ClientData request, BlazeRpcContext context)
        {
            throw new UtilException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>UtilComponent::localizeStrings</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> LocalizeStringsAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new UtilException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>UtilComponent::getTelemetryServer</b> command.<br/>
        /// Request type: <see cref="GetTelemetryServerRequest"/><br/>
        /// Response type: <see cref="GetTelemetryServerResponse"/><br/>
        /// </summary>
        public virtual Task<GetTelemetryServerResponse> GetTelemetryServerAsync(GetTelemetryServerRequest request, BlazeRpcContext context)
        {
            throw new UtilException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>UtilComponent::getTickerServer</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="GetTickerServerResponse"/><br/>
        /// </summary>
        public virtual Task<GetTickerServerResponse> GetTickerServerAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new UtilException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>UtilComponent::preAuth</b> command.<br/>
        /// Request type: <see cref="PreAuthRequest"/><br/>
        /// Response type: <see cref="PreAuthResponse"/><br/>
        /// </summary>
        public virtual Task<PreAuthResponse> PreAuthAsync(PreAuthRequest request, BlazeRpcContext context)
        {
            throw new UtilException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>UtilComponent::postAuth</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="PostAuthResponse"/><br/>
        /// </summary>
        public virtual Task<PostAuthResponse> PostAuthAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new UtilException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>UtilComponent::userSettingsLoad</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> UserSettingsLoadAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new UtilException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>UtilComponent::userSettingsSave</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> UserSettingsSaveAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new UtilException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>UtilComponent::userSettingsLoadAll</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> UserSettingsLoadAllAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new UtilException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>UtilComponent::userSettingsLoadAllForUserId</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> UserSettingsLoadAllForUserIdAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new UtilException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>UtilComponent::filterForProfanity</b> command.<br/>
        /// Request type: <see cref="FilterUserTextResponse"/><br/>
        /// Response type: <see cref="FilterUserTextResponse"/><br/>
        /// </summary>
        public virtual Task<FilterUserTextResponse> FilterForProfanityAsync(FilterUserTextResponse request, BlazeRpcContext context)
        {
            throw new UtilException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>UtilComponent::fetchQosConfig</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="QosConfigInfo"/><br/>
        /// </summary>
        public virtual Task<QosConfigInfo> FetchQosConfigAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new UtilException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>UtilComponent::setClientMetrics</b> command.<br/>
        /// Request type: <see cref="ClientMetrics"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SetClientMetricsAsync(ClientMetrics request, BlazeRpcContext context)
        {
            throw new UtilException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>UtilComponent::setConnectionState</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SetConnectionStateAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new UtilException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
    }
    
}

