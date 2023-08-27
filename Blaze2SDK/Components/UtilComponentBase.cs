using Blaze2SDK.Blaze;
using Blaze2SDK.Blaze.Util;
using BlazeCommon;

namespace Blaze2SDK.Components
{
    public static class UtilComponentBase
    {
        public const ushort Id = 9;
        public const string Name = "UtilComponent";
        
        public class Server : BlazeComponent<UtilComponentCommand, UtilComponentNotification, Blaze2RpcError>
        {
            public Server() : base(UtilComponentBase.Id, UtilComponentBase.Name)
            {
                
            }
            
            [BlazeCommand((ushort)UtilComponentCommand.fetchClientConfig)]
            public virtual Task<NullStruct> FetchClientConfigAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UtilComponentCommand.ping)]
            public virtual Task<PingResponse> PingAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UtilComponentCommand.setClientData)]
            public virtual Task<NullStruct> SetClientDataAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UtilComponentCommand.localizeStrings)]
            public virtual Task<NullStruct> LocalizeStringsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UtilComponentCommand.getTelemetryServer)]
            public virtual Task<GetTelemetryServerResponse> GetTelemetryServerAsync(GetTelemetryServerRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UtilComponentCommand.getTickerServer)]
            public virtual Task<NullStruct> GetTickerServerAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UtilComponentCommand.preAuth)]
            public virtual Task<PreAuthResponse> PreAuthAsync(PreAuthRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UtilComponentCommand.postAuth)]
            public virtual Task<PostAuthResponse> PostAuthAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UtilComponentCommand.userSettingsLoad)]
            public virtual Task<NullStruct> UserSettingsLoadAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UtilComponentCommand.userSettingsSave)]
            public virtual Task<NullStruct> UserSettingsSaveAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UtilComponentCommand.userSettingsLoadAll)]
            public virtual Task<NullStruct> UserSettingsLoadAllAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UtilComponentCommand.userSettingsLoadAllForUserId)]
            public virtual Task<NullStruct> UserSettingsLoadAllForUserIdAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UtilComponentCommand.filterForProfanity)]
            public virtual Task<FilterUserTextResponse> FilterForProfanityAsync(FilterUserTextResponse request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UtilComponentCommand.fetchQosConfig)]
            public virtual Task<NullStruct> FetchQosConfigAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UtilComponentCommand.setClientMetrics)]
            public virtual Task<NullStruct> SetClientMetricsAsync(ClientMetrics request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UtilComponentCommand.setConnectionState)]
            public virtual Task<NullStruct> SetConnectionStateAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            
            public override Type GetCommandRequestType(UtilComponentCommand command) => UtilComponentBase.GetCommandRequestType(command);
            public override Type GetCommandResponseType(UtilComponentCommand command) => UtilComponentBase.GetCommandResponseType(command);
            public override Type GetCommandErrorResponseType(UtilComponentCommand command) => UtilComponentBase.GetCommandErrorResponseType(command);
            public override Type GetNotificationType(UtilComponentNotification notification) => UtilComponentBase.GetNotificationType(notification);
            
        }
        
        public class Client : BlazeComponent<UtilComponentCommand, UtilComponentNotification, Blaze2RpcError>
        {
            public Client() : base(UtilComponentBase.Id, UtilComponentBase.Name)
            {
                
            }
            
            public override Type GetCommandRequestType(UtilComponentCommand command) => UtilComponentBase.GetCommandRequestType(command);
            public override Type GetCommandResponseType(UtilComponentCommand command) => UtilComponentBase.GetCommandResponseType(command);
            public override Type GetCommandErrorResponseType(UtilComponentCommand command) => UtilComponentBase.GetCommandErrorResponseType(command);
            public override Type GetNotificationType(UtilComponentNotification notification) => UtilComponentBase.GetNotificationType(notification);
            
        }
        
        public static Type GetCommandRequestType(UtilComponentCommand command) => command switch
        {
            UtilComponentCommand.fetchClientConfig => typeof(NullStruct),
            UtilComponentCommand.ping => typeof(NullStruct),
            UtilComponentCommand.setClientData => typeof(NullStruct),
            UtilComponentCommand.localizeStrings => typeof(NullStruct),
            UtilComponentCommand.getTelemetryServer => typeof(GetTelemetryServerRequest),
            UtilComponentCommand.getTickerServer => typeof(NullStruct),
            UtilComponentCommand.preAuth => typeof(PreAuthRequest),
            UtilComponentCommand.postAuth => typeof(NullStruct),
            UtilComponentCommand.userSettingsLoad => typeof(NullStruct),
            UtilComponentCommand.userSettingsSave => typeof(NullStruct),
            UtilComponentCommand.userSettingsLoadAll => typeof(NullStruct),
            UtilComponentCommand.userSettingsLoadAllForUserId => typeof(NullStruct),
            UtilComponentCommand.filterForProfanity => typeof(FilterUserTextResponse),
            UtilComponentCommand.fetchQosConfig => typeof(NullStruct),
            UtilComponentCommand.setClientMetrics => typeof(ClientMetrics),
            UtilComponentCommand.setConnectionState => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandResponseType(UtilComponentCommand command) => command switch
        {
            UtilComponentCommand.fetchClientConfig => typeof(NullStruct),
            UtilComponentCommand.ping => typeof(PingResponse),
            UtilComponentCommand.setClientData => typeof(NullStruct),
            UtilComponentCommand.localizeStrings => typeof(NullStruct),
            UtilComponentCommand.getTelemetryServer => typeof(GetTelemetryServerResponse),
            UtilComponentCommand.getTickerServer => typeof(NullStruct),
            UtilComponentCommand.preAuth => typeof(PreAuthResponse),
            UtilComponentCommand.postAuth => typeof(PostAuthResponse),
            UtilComponentCommand.userSettingsLoad => typeof(NullStruct),
            UtilComponentCommand.userSettingsSave => typeof(NullStruct),
            UtilComponentCommand.userSettingsLoadAll => typeof(NullStruct),
            UtilComponentCommand.userSettingsLoadAllForUserId => typeof(NullStruct),
            UtilComponentCommand.filterForProfanity => typeof(FilterUserTextResponse),
            UtilComponentCommand.fetchQosConfig => typeof(NullStruct),
            UtilComponentCommand.setClientMetrics => typeof(NullStruct),
            UtilComponentCommand.setConnectionState => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandErrorResponseType(UtilComponentCommand command) => command switch
        {
            UtilComponentCommand.fetchClientConfig => typeof(NullStruct),
            UtilComponentCommand.ping => typeof(NullStruct),
            UtilComponentCommand.setClientData => typeof(NullStruct),
            UtilComponentCommand.localizeStrings => typeof(NullStruct),
            UtilComponentCommand.getTelemetryServer => typeof(NullStruct),
            UtilComponentCommand.getTickerServer => typeof(NullStruct),
            UtilComponentCommand.preAuth => typeof(NullStruct),
            UtilComponentCommand.postAuth => typeof(NullStruct),
            UtilComponentCommand.userSettingsLoad => typeof(NullStruct),
            UtilComponentCommand.userSettingsSave => typeof(NullStruct),
            UtilComponentCommand.userSettingsLoadAll => typeof(NullStruct),
            UtilComponentCommand.userSettingsLoadAllForUserId => typeof(NullStruct),
            UtilComponentCommand.filterForProfanity => typeof(NullStruct),
            UtilComponentCommand.fetchQosConfig => typeof(NullStruct),
            UtilComponentCommand.setClientMetrics => typeof(NullStruct),
            UtilComponentCommand.setConnectionState => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetNotificationType(UtilComponentNotification notification) => notification switch
        {
            _ => typeof(NullStruct)
        };
        
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
        
    }
}
