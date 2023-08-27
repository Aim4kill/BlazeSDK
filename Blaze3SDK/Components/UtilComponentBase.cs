using Blaze3SDK.Blaze;
using Blaze3SDK.Blaze.Util;
using BlazeCommon;

namespace Blaze3SDK.Components
{
    public static class UtilComponentBase
    {
        public const ushort Id = 9;
        public const string Name = "UtilComponent";
        
        public class Server : BlazeComponent<UtilComponentCommand, UtilComponentNotification, Blaze3RpcError>
        {
            public Server() : base(UtilComponentBase.Id, UtilComponentBase.Name)
            {
                
            }
            
            [BlazeCommand((ushort)UtilComponentCommand.fetchClientConfig)]
            public virtual Task<FetchConfigResponse> FetchClientConfigAsync(FetchClientConfigRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UtilComponentCommand.ping)]
            public virtual Task<PingResponse> PingAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UtilComponentCommand.setClientData)]
            public virtual Task<NullStruct> SetClientDataAsync(ClientData request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UtilComponentCommand.localizeStrings)]
            public virtual Task<LocalizeStringsResponse> LocalizeStringsAsync(LocalizeStringsRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UtilComponentCommand.getTelemetryServer)]
            public virtual Task<GetTelemetryServerResponse> GetTelemetryServerAsync(GetTelemetryServerRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UtilComponentCommand.getTickerServer)]
            public virtual Task<GetTickerServerResponse> GetTickerServerAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UtilComponentCommand.preAuth)]
            public virtual Task<PreAuthResponse> PreAuthAsync(PreAuthRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UtilComponentCommand.postAuth)]
            public virtual Task<PostAuthResponse> PostAuthAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UtilComponentCommand.userSettingsLoad)]
            public virtual Task<UserSettingsResponse> UserSettingsLoadAsync(UserSettingsLoadRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UtilComponentCommand.userSettingsSave)]
            public virtual Task<NullStruct> UserSettingsSaveAsync(UserSettingsSaveRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UtilComponentCommand.userSettingsLoadAll)]
            public virtual Task<UserSettingsLoadAllResponse> UserSettingsLoadAllAsync(UserSettingsLoadAllRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UtilComponentCommand.deleteUserSettings)]
            public virtual Task<NullStruct> DeleteUserSettingsAsync(DeleteUserSettingsRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UtilComponentCommand.filterForProfanity)]
            public virtual Task<FilterUserTextResponse> FilterForProfanityAsync(FilterUserTextResponse request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UtilComponentCommand.fetchQosConfig)]
            public virtual Task<QosConfigInfo> FetchQosConfigAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UtilComponentCommand.setClientMetrics)]
            public virtual Task<NullStruct> SetClientMetricsAsync(ClientMetrics request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UtilComponentCommand.setConnectionState)]
            public virtual Task<NullStruct> SetConnectionStateAsync(SetConnectionStateRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UtilComponentCommand.getPssConfig)]
            public virtual Task<PssConfig> GetPssConfigAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UtilComponentCommand.getUserOptions)]
            public virtual Task<UserOptions> GetUserOptionsAsync(GetUserOptionsRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UtilComponentCommand.setUserOptions)]
            public virtual Task<NullStruct> SetUserOptionsAsync(UserOptions request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)UtilComponentCommand.suspendUserPing)]
            public virtual Task<NullStruct> SuspendUserPingAsync(SuspendUserPingRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            
            public override Type GetCommandRequestType(UtilComponentCommand command) => UtilComponentBase.GetCommandRequestType(command);
            public override Type GetCommandResponseType(UtilComponentCommand command) => UtilComponentBase.GetCommandResponseType(command);
            public override Type GetCommandErrorResponseType(UtilComponentCommand command) => UtilComponentBase.GetCommandErrorResponseType(command);
            public override Type GetNotificationType(UtilComponentNotification notification) => UtilComponentBase.GetNotificationType(notification);
            
        }
        
        public class Client : BlazeComponent<UtilComponentCommand, UtilComponentNotification, Blaze3RpcError>
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
            UtilComponentCommand.fetchClientConfig => typeof(FetchClientConfigRequest),
            UtilComponentCommand.ping => typeof(NullStruct),
            UtilComponentCommand.setClientData => typeof(ClientData),
            UtilComponentCommand.localizeStrings => typeof(LocalizeStringsRequest),
            UtilComponentCommand.getTelemetryServer => typeof(GetTelemetryServerRequest),
            UtilComponentCommand.getTickerServer => typeof(NullStruct),
            UtilComponentCommand.preAuth => typeof(PreAuthRequest),
            UtilComponentCommand.postAuth => typeof(NullStruct),
            UtilComponentCommand.userSettingsLoad => typeof(UserSettingsLoadRequest),
            UtilComponentCommand.userSettingsSave => typeof(UserSettingsSaveRequest),
            UtilComponentCommand.userSettingsLoadAll => typeof(UserSettingsLoadAllRequest),
            UtilComponentCommand.deleteUserSettings => typeof(DeleteUserSettingsRequest),
            UtilComponentCommand.filterForProfanity => typeof(FilterUserTextResponse),
            UtilComponentCommand.fetchQosConfig => typeof(NullStruct),
            UtilComponentCommand.setClientMetrics => typeof(ClientMetrics),
            UtilComponentCommand.setConnectionState => typeof(SetConnectionStateRequest),
            UtilComponentCommand.getPssConfig => typeof(NullStruct),
            UtilComponentCommand.getUserOptions => typeof(GetUserOptionsRequest),
            UtilComponentCommand.setUserOptions => typeof(UserOptions),
            UtilComponentCommand.suspendUserPing => typeof(SuspendUserPingRequest),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandResponseType(UtilComponentCommand command) => command switch
        {
            UtilComponentCommand.fetchClientConfig => typeof(FetchConfigResponse),
            UtilComponentCommand.ping => typeof(PingResponse),
            UtilComponentCommand.setClientData => typeof(NullStruct),
            UtilComponentCommand.localizeStrings => typeof(LocalizeStringsResponse),
            UtilComponentCommand.getTelemetryServer => typeof(GetTelemetryServerResponse),
            UtilComponentCommand.getTickerServer => typeof(GetTickerServerResponse),
            UtilComponentCommand.preAuth => typeof(PreAuthResponse),
            UtilComponentCommand.postAuth => typeof(PostAuthResponse),
            UtilComponentCommand.userSettingsLoad => typeof(UserSettingsResponse),
            UtilComponentCommand.userSettingsSave => typeof(NullStruct),
            UtilComponentCommand.userSettingsLoadAll => typeof(UserSettingsLoadAllResponse),
            UtilComponentCommand.deleteUserSettings => typeof(NullStruct),
            UtilComponentCommand.filterForProfanity => typeof(FilterUserTextResponse),
            UtilComponentCommand.fetchQosConfig => typeof(QosConfigInfo),
            UtilComponentCommand.setClientMetrics => typeof(NullStruct),
            UtilComponentCommand.setConnectionState => typeof(NullStruct),
            UtilComponentCommand.getPssConfig => typeof(PssConfig),
            UtilComponentCommand.getUserOptions => typeof(UserOptions),
            UtilComponentCommand.setUserOptions => typeof(NullStruct),
            UtilComponentCommand.suspendUserPing => typeof(NullStruct),
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
            UtilComponentCommand.deleteUserSettings => typeof(NullStruct),
            UtilComponentCommand.filterForProfanity => typeof(NullStruct),
            UtilComponentCommand.fetchQosConfig => typeof(NullStruct),
            UtilComponentCommand.setClientMetrics => typeof(NullStruct),
            UtilComponentCommand.setConnectionState => typeof(NullStruct),
            UtilComponentCommand.getPssConfig => typeof(NullStruct),
            UtilComponentCommand.getUserOptions => typeof(NullStruct),
            UtilComponentCommand.setUserOptions => typeof(NullStruct),
            UtilComponentCommand.suspendUserPing => typeof(NullStruct),
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
            deleteUserSettings = 14,
            filterForProfanity = 20,
            fetchQosConfig = 21,
            setClientMetrics = 22,
            setConnectionState = 23,
            getPssConfig = 24,
            getUserOptions = 25,
            setUserOptions = 26,
            suspendUserPing = 27,
        }
        
        public enum UtilComponentNotification : ushort
        {
        }
        
    }
}
