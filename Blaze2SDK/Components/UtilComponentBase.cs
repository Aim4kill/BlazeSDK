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
        }
        
        public class Client : BlazeComponent<UtilComponentCommand, UtilComponentNotification, Blaze2RpcError>
        {
            public Client() : base(UtilComponentBase.Id, UtilComponentBase.Name)
            {
                
            }
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
        
    }
}
