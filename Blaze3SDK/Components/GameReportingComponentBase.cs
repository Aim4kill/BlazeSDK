using Blaze.Core;
using Blaze3SDK.Blaze.GameReporting;
using EATDF;
using EATDF.Types;

namespace Blaze3SDK.Components;

public static class GameReportingComponentBase
{
    public const ushort Id = 28;
    public const string Name = "GameReportingComponent";
    
    public enum Error : ushort {
        GAMEREPORTING_ERR_UNEXPECTED_REPORT = 1,
        GAMEREPORTING_COLLATION_ERR_NO_VALID_REPORTS = 100,
        GAMEREPORTING_COLLATION_ERR_NO_REPORTS = 101,
        GAMEREPORTING_COLLATION_REPORTS_INCONSISTENT = 102,
        GAMEREPORTING_COLLATION_ERR_MISSING_GAME_ATTRIBUTE = 103,
        GAMEREPORTING_COLLATION_ERR_INVALID_GAME_ATTRIBUTE = 104,
        GAMEREPORTING_CUSTOM_ERR_PROCESSING_FAILED = 200,
        GAMEREPORTING_CONFIG_ERR_MISSING_PROCESSOR_ATTRIBUTE = 201,
        GAMEREPORTING_CONFIG_ERR_INVALID_PROCESSOR_ATTRIBUTE = 202,
        GAMEREPORTING_CONFIG_ERR_STAT_UPDATE_FAILED = 203,
        GAMEREPORTING_CUSTOM_ERR_PROCESS_UPDATED_STATS_FAILED = 204,
        GAMEREPORTING_ERR_INVALID_GAME_TYPE = 205,
        GAMEREPORTING_OFFLINE_ERR_INVALID_GAME_TYPE = 301,
        GAMEREPORTING_OFFLINE_ERR_REPORT_INVALID = 302,
        GAMEREPORTING_TRUSTED_ERR_INVALID_GAME_TYPE = 401,
        GAMEREPORTING_TRUSTED_ERR_REPORT_INVALID = 402,
        GAMEREPORTING_TRUSTED_ERR_CLIENT_NOT_TRUSTED = 403,
        GAMEHISTORY_ERR_UNKNOWN_QUERY = 501,
        GAMEHISTORY_ERR_INVALID_COLUMNKEY = 502,
        GAMEHISTORY_ERR_INVALID_FILTER = 503,
        GAMEHISTORY_ERR_INVALID_GAMETYPE = 504,
        GAMEHISTORY_ERR_UNKNOWN_VIEW = 505,
        GAMEHISTORY_ERR_INVALID_QUERY = 506,
        GAMEHISTORY_ERR_MISSING_QVARS = 507,
        GAMEHISTORY_ERR_INVALID_QVARS = 508,
    }
    
    public enum GameReportingComponentCommand : ushort
    {
        submitGameReport = 1,
        submitOfflineGameReport = 2,
        submitGameEvents = 3,
        getGameReportQuery = 4,
        getGameReportQueriesList = 5,
        getGameReports = 6,
        getGameReportView = 7,
        getGameReportViewInfo = 8,
        getGameReportViewInfoList = 9,
        getGameReportTypes = 10,
        updateMetric = 11,
        getGameReportColumnInfo = 12,
        getGameReportColumnValues = 13,
        submitTrustedMidGameReport = 100,
        submitTrustedEndGameReport = 101,
    }
    
    public enum GameReportingComponentNotification : ushort
    {
        ResultNotification = 114,
    }
    
    public class Server : BlazeComponent {
        public override ushort Id => GameReportingComponentBase.Id;
        public override string Name => GameReportingComponentBase.Name;
        
        public virtual bool IsCommandSupported(GameReportingComponentCommand command) => false;
        
        public class GameReportingException : BlazeRpcException
        {
            public GameReportingException(Error error) : base((ushort)error, null) { }
            public GameReportingException(ServerError error) : base(error.WithErrorPrefix(), null) { }
            public GameReportingException(Error error, Tdf? errorResponse) : base((ushort)error, errorResponse) { }
            public GameReportingException(ServerError error, Tdf? errorResponse) : base(error.WithErrorPrefix(), errorResponse) { }
            public GameReportingException(Error error, Tdf? errorResponse, string? message) : base((ushort)error, errorResponse, message) { }
            public GameReportingException(ServerError error, Tdf? errorResponse, string? message) : base(error.WithErrorPrefix(), errorResponse, message) { }
            public GameReportingException(Error error, Tdf? errorResponse, string? message, Exception? innerException) : base((ushort)error, errorResponse, message, innerException) { }
            public GameReportingException(ServerError error, Tdf? errorResponse, string? message, Exception? innerException) : base(error.WithErrorPrefix(), errorResponse, message, innerException) { }
        }
        
        public Server()
        {
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameReportingComponentCommand.submitGameReport,
                Name = "submitGameReport",
                IsSupported = IsCommandSupported(GameReportingComponentCommand.submitGameReport),
                Func = async (req, ctx) => await SubmitGameReportAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameReportingComponentCommand.submitOfflineGameReport,
                Name = "submitOfflineGameReport",
                IsSupported = IsCommandSupported(GameReportingComponentCommand.submitOfflineGameReport),
                Func = async (req, ctx) => await SubmitOfflineGameReportAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameReportingComponentCommand.submitGameEvents,
                Name = "submitGameEvents",
                IsSupported = IsCommandSupported(GameReportingComponentCommand.submitGameEvents),
                Func = async (req, ctx) => await SubmitGameEventsAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameReportingComponentCommand.getGameReportQuery,
                Name = "getGameReportQuery",
                IsSupported = IsCommandSupported(GameReportingComponentCommand.getGameReportQuery),
                Func = async (req, ctx) => await GetGameReportQueryAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, GameReportQueriesList, EmptyMessage>()
            {
                Id = (ushort)GameReportingComponentCommand.getGameReportQueriesList,
                Name = "getGameReportQueriesList",
                IsSupported = IsCommandSupported(GameReportingComponentCommand.getGameReportQueriesList),
                Func = async (req, ctx) => await GetGameReportQueriesListAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<GetGameReports, GameReportsList, EmptyMessage>()
            {
                Id = (ushort)GameReportingComponentCommand.getGameReports,
                Name = "getGameReports",
                IsSupported = IsCommandSupported(GameReportingComponentCommand.getGameReports),
                Func = async (req, ctx) => await GetGameReportsAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<GetGameReportViewRequest, GetGameReportViewResponse, EmptyMessage>()
            {
                Id = (ushort)GameReportingComponentCommand.getGameReportView,
                Name = "getGameReportView",
                IsSupported = IsCommandSupported(GameReportingComponentCommand.getGameReportView),
                Func = async (req, ctx) => await GetGameReportViewAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<GetGameReportViewInfo, GameReportViewInfo, EmptyMessage>()
            {
                Id = (ushort)GameReportingComponentCommand.getGameReportViewInfo,
                Name = "getGameReportViewInfo",
                IsSupported = IsCommandSupported(GameReportingComponentCommand.getGameReportViewInfo),
                Func = async (req, ctx) => await GetGameReportViewInfoAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, GameReportViewInfosList, EmptyMessage>()
            {
                Id = (ushort)GameReportingComponentCommand.getGameReportViewInfoList,
                Name = "getGameReportViewInfoList",
                IsSupported = IsCommandSupported(GameReportingComponentCommand.getGameReportViewInfoList),
                Func = async (req, ctx) => await GetGameReportViewInfoListAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, GetGameReportTypesResponse, EmptyMessage>()
            {
                Id = (ushort)GameReportingComponentCommand.getGameReportTypes,
                Name = "getGameReportTypes",
                IsSupported = IsCommandSupported(GameReportingComponentCommand.getGameReportTypes),
                Func = async (req, ctx) => await GetGameReportTypesAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameReportingComponentCommand.updateMetric,
                Name = "updateMetric",
                IsSupported = IsCommandSupported(GameReportingComponentCommand.updateMetric),
                Func = async (req, ctx) => await UpdateMetricAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<GetGameReportColumnInfo, GameReportColumnInfoResponse, EmptyMessage>()
            {
                Id = (ushort)GameReportingComponentCommand.getGameReportColumnInfo,
                Name = "getGameReportColumnInfo",
                IsSupported = IsCommandSupported(GameReportingComponentCommand.getGameReportColumnInfo),
                Func = async (req, ctx) => await GetGameReportColumnInfoAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, GetGameReportColumnValuesResponse, EmptyMessage>()
            {
                Id = (ushort)GameReportingComponentCommand.getGameReportColumnValues,
                Name = "getGameReportColumnValues",
                IsSupported = IsCommandSupported(GameReportingComponentCommand.getGameReportColumnValues),
                Func = async (req, ctx) => await GetGameReportColumnValuesAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameReportingComponentCommand.submitTrustedMidGameReport,
                Name = "submitTrustedMidGameReport",
                IsSupported = IsCommandSupported(GameReportingComponentCommand.submitTrustedMidGameReport),
                Func = async (req, ctx) => await SubmitTrustedMidGameReportAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameReportingComponentCommand.submitTrustedEndGameReport,
                Name = "submitTrustedEndGameReport",
                IsSupported = IsCommandSupported(GameReportingComponentCommand.submitTrustedEndGameReport),
                Func = async (req, ctx) => await SubmitTrustedEndGameReportAsync(req, ctx).ConfigureAwait(false)
            });
            
        }
        
        public override string GetErrorName(ushort errorCode)
        {
            return ((Error)errorCode).ToString();
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameReportingComponent::submitGameReport</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SubmitGameReportAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new GameReportingException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameReportingComponent::submitOfflineGameReport</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SubmitOfflineGameReportAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new GameReportingException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameReportingComponent::submitGameEvents</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SubmitGameEventsAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new GameReportingException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameReportingComponent::getGameReportQuery</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetGameReportQueryAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new GameReportingException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameReportingComponent::getGameReportQueriesList</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="GameReportQueriesList"/><br/>
        /// </summary>
        public virtual Task<GameReportQueriesList> GetGameReportQueriesListAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new GameReportingException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameReportingComponent::getGameReports</b> command.<br/>
        /// Request type: <see cref="GetGameReports"/><br/>
        /// Response type: <see cref="GameReportsList"/><br/>
        /// </summary>
        public virtual Task<GameReportsList> GetGameReportsAsync(GetGameReports request, BlazeRpcContext context)
        {
            throw new GameReportingException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameReportingComponent::getGameReportView</b> command.<br/>
        /// Request type: <see cref="GetGameReportViewRequest"/><br/>
        /// Response type: <see cref="GetGameReportViewResponse"/><br/>
        /// </summary>
        public virtual Task<GetGameReportViewResponse> GetGameReportViewAsync(GetGameReportViewRequest request, BlazeRpcContext context)
        {
            throw new GameReportingException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameReportingComponent::getGameReportViewInfo</b> command.<br/>
        /// Request type: <see cref="GetGameReportViewInfo"/><br/>
        /// Response type: <see cref="GameReportViewInfo"/><br/>
        /// </summary>
        public virtual Task<GameReportViewInfo> GetGameReportViewInfoAsync(GetGameReportViewInfo request, BlazeRpcContext context)
        {
            throw new GameReportingException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameReportingComponent::getGameReportViewInfoList</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="GameReportViewInfosList"/><br/>
        /// </summary>
        public virtual Task<GameReportViewInfosList> GetGameReportViewInfoListAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new GameReportingException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameReportingComponent::getGameReportTypes</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="GetGameReportTypesResponse"/><br/>
        /// </summary>
        public virtual Task<GetGameReportTypesResponse> GetGameReportTypesAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new GameReportingException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameReportingComponent::updateMetric</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> UpdateMetricAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new GameReportingException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameReportingComponent::getGameReportColumnInfo</b> command.<br/>
        /// Request type: <see cref="GetGameReportColumnInfo"/><br/>
        /// Response type: <see cref="GameReportColumnInfoResponse"/><br/>
        /// </summary>
        public virtual Task<GameReportColumnInfoResponse> GetGameReportColumnInfoAsync(GetGameReportColumnInfo request, BlazeRpcContext context)
        {
            throw new GameReportingException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameReportingComponent::getGameReportColumnValues</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="GetGameReportColumnValuesResponse"/><br/>
        /// </summary>
        public virtual Task<GetGameReportColumnValuesResponse> GetGameReportColumnValuesAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new GameReportingException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameReportingComponent::submitTrustedMidGameReport</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SubmitTrustedMidGameReportAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new GameReportingException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameReportingComponent::submitTrustedEndGameReport</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SubmitTrustedEndGameReportAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new GameReportingException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>GameReportingComponent::ResultNotification</b> notification.<br/>
        /// Notification type: <see cref="ResultNotification"/><br/>
        /// </summary>
        public static Task NotifyResultNotificationAsync(BlazeRpcConnection connection, ResultNotification notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = GameReportingComponentBase.Id;
                frame.Command = (ushort)GameReportingComponentNotification.ResultNotification;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
    }
    
}

