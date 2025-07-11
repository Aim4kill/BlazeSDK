using Blaze.Core;
using Blaze2SDK.Blaze.GameReporting;
using EATDF;
using EATDF.Types;

namespace Blaze2SDK.Components;

public static class GameReportingComponentBase
{
    public const ushort Id = 12;
    public const string Name = "GameReportingComponent";
    
    public enum Error : ushort {
        GAMEHISTORY_ERR_INVALID_QUERY = 1,
        GAMEHISTORY_ERR_UNKNOWN_VIEW = 2,
        GAMEHISTORY_ERR_MISSING_QVARS = 3,
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
        GAMEREPORTING_OFFLINE_ERR_FIRST_PLAYER_NOT_BLAZE_USER = 301,
        GAMEREPORTING_OFFLINE_ERR_INVALID_GAME_TYPE_ID = 302,
        GAMEREPORTING_OFFLINE_ERR_REPORT_INVALID = 303,
        GAMEREPORTING_TRUSTED_ERR_CLIENT_NOT_TRUSTED = 400,
        GAMEREPORTING_TRUSTED_ERR_INVALID_GAME_TYPE_ID = 401,
        GAMEREPORTING_TRUSTED_ERR_REPORT_INVALID = 402,
        GAMEREPORTING_ERR_UNEXPECTED_REPORT = 500,
    }
    
    public enum GameReportingComponentCommand : ushort
    {
        submitGameReport = 1,
        submitOfflineGameReport = 2,
        submitGameEvents = 3,
        getGameReports = 4,
        getGameReportView = 5,
        getGameReportViewInfo = 6,
        getGameReportViewInfoList = 7,
        getGameReportTypes = 8,
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
            RegisterCommand(new RpcCommandFunc<GameReport, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameReportingComponentCommand.submitGameReport,
                Name = "submitGameReport",
                IsSupported = IsCommandSupported(GameReportingComponentCommand.submitGameReport),
                Func = async (req, ctx) => await SubmitGameReportAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<GameReport, EmptyMessage, EmptyMessage>()
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
                Id = (ushort)GameReportingComponentCommand.getGameReports,
                Name = "getGameReports",
                IsSupported = IsCommandSupported(GameReportingComponentCommand.getGameReports),
                Func = async (req, ctx) => await GetGameReportsAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameReportingComponentCommand.getGameReportView,
                Name = "getGameReportView",
                IsSupported = IsCommandSupported(GameReportingComponentCommand.getGameReportView),
                Func = async (req, ctx) => await GetGameReportViewAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameReportingComponentCommand.getGameReportViewInfo,
                Name = "getGameReportViewInfo",
                IsSupported = IsCommandSupported(GameReportingComponentCommand.getGameReportViewInfo),
                Func = async (req, ctx) => await GetGameReportViewInfoAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameReportingComponentCommand.getGameReportViewInfoList,
                Name = "getGameReportViewInfoList",
                IsSupported = IsCommandSupported(GameReportingComponentCommand.getGameReportViewInfoList),
                Func = async (req, ctx) => await GetGameReportViewInfoListAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameReportingComponentCommand.getGameReportTypes,
                Name = "getGameReportTypes",
                IsSupported = IsCommandSupported(GameReportingComponentCommand.getGameReportTypes),
                Func = async (req, ctx) => await GetGameReportTypesAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<GameReport, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameReportingComponentCommand.submitTrustedMidGameReport,
                Name = "submitTrustedMidGameReport",
                IsSupported = IsCommandSupported(GameReportingComponentCommand.submitTrustedMidGameReport),
                Func = async (req, ctx) => await SubmitTrustedMidGameReportAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<GameReport, EmptyMessage, EmptyMessage>()
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
        /// Request type: <see cref="GameReport"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SubmitGameReportAsync(GameReport request, BlazeRpcContext context)
        {
            throw new GameReportingException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameReportingComponent::submitOfflineGameReport</b> command.<br/>
        /// Request type: <see cref="GameReport"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SubmitOfflineGameReportAsync(GameReport request, BlazeRpcContext context)
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
        /// This method is called when server receives a <b>GameReportingComponent::getGameReports</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetGameReportsAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new GameReportingException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameReportingComponent::getGameReportView</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetGameReportViewAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new GameReportingException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameReportingComponent::getGameReportViewInfo</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetGameReportViewInfoAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new GameReportingException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameReportingComponent::getGameReportViewInfoList</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetGameReportViewInfoListAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new GameReportingException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameReportingComponent::getGameReportTypes</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetGameReportTypesAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new GameReportingException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameReportingComponent::submitTrustedMidGameReport</b> command.<br/>
        /// Request type: <see cref="GameReport"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SubmitTrustedMidGameReportAsync(GameReport request, BlazeRpcContext context)
        {
            throw new GameReportingException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameReportingComponent::submitTrustedEndGameReport</b> command.<br/>
        /// Request type: <see cref="GameReport"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SubmitTrustedEndGameReportAsync(GameReport request, BlazeRpcContext context)
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

