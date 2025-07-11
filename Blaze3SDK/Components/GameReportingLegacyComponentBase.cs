using Blaze.Core;
using Blaze3SDK.Blaze.GameReportingLegacy;
using EATDF;
using EATDF.Types;

namespace Blaze3SDK.Components;

public static class GameReportingLegacyComponentBase
{
    public const ushort Id = 12;
    public const string Name = "GameReportingLegacyComponent";
    
    public enum Error : ushort {
        GAMEHISTORYLEGACY_ERR_INVALID_QUERY = 1,
        GAMEHISTORYLEGACY_ERR_UNKNOWN_VIEW = 2,
        GAMEHISTORYLEGACY_ERR_MISSING_QVARS = 3,
        GAMEREPORTINGLEGACY_COLLATION_ERR_NO_VALID_REPORTS = 100,
        GAMEREPORTINGLEGACY_COLLATION_ERR_NO_REPORTS = 101,
        GAMEREPORTINGLEGACY_COLLATION_REPORTS_INCONSISTENT = 102,
        GAMEREPORTINGLEGACY_COLLATION_ERR_MISSING_GAME_ATTRIBUTE = 103,
        GAMEREPORTINGLEGACY_COLLATION_ERR_INVALID_GAME_ATTRIBUTE = 104,
        GAMEREPORTINGLEGACY_CUSTOM_ERR_PROCESSING_FAILED = 200,
        GAMEREPORTINGLEGACY_CONFIG_ERR_MISSING_PROCESSOR_ATTRIBUTE = 201,
        GAMEREPORTINGLEGACY_CONFIG_ERR_INVALID_PROCESSOR_ATTRIBUTE = 202,
        GAMEREPORTINGLEGACY_CONFIG_ERR_STAT_UPDATE_FAILED = 203,
        GAMEREPORTINGLEGACY_CUSTOM_ERR_PROCESS_UPDATED_STATS_FAILED = 204,
        GAMEREPORTINGLEGACY_OFFLINE_ERR_FIRST_PLAYER_NOT_BLAZE_USER = 301,
        GAMEREPORTINGLEGACY_OFFLINE_ERR_INVALID_GAME_TYPE_ID = 302,
        GAMEREPORTINGLEGACY_OFFLINE_ERR_REPORT_INVALID = 303,
        GAMEREPORTINGLEGACY_TRUSTED_ERR_CLIENT_NOT_TRUSTED = 400,
        GAMEREPORTINGLEGACY_TRUSTED_ERR_INVALID_GAME_TYPE_ID = 401,
        GAMEREPORTINGLEGACY_TRUSTED_ERR_REPORT_INVALID = 402,
        GAMEREPORTINGLEGACY_ERR_UNEXPECTED_REPORT = 500,
    }
    
    public enum GameReportingLegacyComponentCommand : ushort
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
    
    public enum GameReportingLegacyComponentNotification : ushort
    {
        ResultNotification = 114,
    }
    
    public class Server : BlazeComponent {
        public override ushort Id => GameReportingLegacyComponentBase.Id;
        public override string Name => GameReportingLegacyComponentBase.Name;
        
        public virtual bool IsCommandSupported(GameReportingLegacyComponentCommand command) => false;
        
        public class GameReportingLegacyException : BlazeRpcException
        {
            public GameReportingLegacyException(Error error) : base((ushort)error, null) { }
            public GameReportingLegacyException(ServerError error) : base(error.WithErrorPrefix(), null) { }
            public GameReportingLegacyException(Error error, Tdf? errorResponse) : base((ushort)error, errorResponse) { }
            public GameReportingLegacyException(ServerError error, Tdf? errorResponse) : base(error.WithErrorPrefix(), errorResponse) { }
            public GameReportingLegacyException(Error error, Tdf? errorResponse, string? message) : base((ushort)error, errorResponse, message) { }
            public GameReportingLegacyException(ServerError error, Tdf? errorResponse, string? message) : base(error.WithErrorPrefix(), errorResponse, message) { }
            public GameReportingLegacyException(Error error, Tdf? errorResponse, string? message, Exception? innerException) : base((ushort)error, errorResponse, message, innerException) { }
            public GameReportingLegacyException(ServerError error, Tdf? errorResponse, string? message, Exception? innerException) : base(error.WithErrorPrefix(), errorResponse, message, innerException) { }
        }
        
        public Server()
        {
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameReportingLegacyComponentCommand.submitGameReport,
                Name = "submitGameReport",
                IsSupported = IsCommandSupported(GameReportingLegacyComponentCommand.submitGameReport),
                Func = async (req, ctx) => await SubmitGameReportAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameReportingLegacyComponentCommand.submitOfflineGameReport,
                Name = "submitOfflineGameReport",
                IsSupported = IsCommandSupported(GameReportingLegacyComponentCommand.submitOfflineGameReport),
                Func = async (req, ctx) => await SubmitOfflineGameReportAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameReportingLegacyComponentCommand.submitGameEvents,
                Name = "submitGameEvents",
                IsSupported = IsCommandSupported(GameReportingLegacyComponentCommand.submitGameEvents),
                Func = async (req, ctx) => await SubmitGameEventsAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameReportingLegacyComponentCommand.getGameReports,
                Name = "getGameReports",
                IsSupported = IsCommandSupported(GameReportingLegacyComponentCommand.getGameReports),
                Func = async (req, ctx) => await GetGameReportsAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameReportingLegacyComponentCommand.getGameReportView,
                Name = "getGameReportView",
                IsSupported = IsCommandSupported(GameReportingLegacyComponentCommand.getGameReportView),
                Func = async (req, ctx) => await GetGameReportViewAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameReportingLegacyComponentCommand.getGameReportViewInfo,
                Name = "getGameReportViewInfo",
                IsSupported = IsCommandSupported(GameReportingLegacyComponentCommand.getGameReportViewInfo),
                Func = async (req, ctx) => await GetGameReportViewInfoAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameReportingLegacyComponentCommand.getGameReportViewInfoList,
                Name = "getGameReportViewInfoList",
                IsSupported = IsCommandSupported(GameReportingLegacyComponentCommand.getGameReportViewInfoList),
                Func = async (req, ctx) => await GetGameReportViewInfoListAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameReportingLegacyComponentCommand.getGameReportTypes,
                Name = "getGameReportTypes",
                IsSupported = IsCommandSupported(GameReportingLegacyComponentCommand.getGameReportTypes),
                Func = async (req, ctx) => await GetGameReportTypesAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameReportingLegacyComponentCommand.submitTrustedMidGameReport,
                Name = "submitTrustedMidGameReport",
                IsSupported = IsCommandSupported(GameReportingLegacyComponentCommand.submitTrustedMidGameReport),
                Func = async (req, ctx) => await SubmitTrustedMidGameReportAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameReportingLegacyComponentCommand.submitTrustedEndGameReport,
                Name = "submitTrustedEndGameReport",
                IsSupported = IsCommandSupported(GameReportingLegacyComponentCommand.submitTrustedEndGameReport),
                Func = async (req, ctx) => await SubmitTrustedEndGameReportAsync(req, ctx).ConfigureAwait(false)
            });
            
        }
        
        public override string GetErrorName(ushort errorCode)
        {
            return ((Error)errorCode).ToString();
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameReportingLegacyComponent::submitGameReport</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SubmitGameReportAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new GameReportingLegacyException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameReportingLegacyComponent::submitOfflineGameReport</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SubmitOfflineGameReportAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new GameReportingLegacyException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameReportingLegacyComponent::submitGameEvents</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SubmitGameEventsAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new GameReportingLegacyException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameReportingLegacyComponent::getGameReports</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetGameReportsAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new GameReportingLegacyException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameReportingLegacyComponent::getGameReportView</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetGameReportViewAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new GameReportingLegacyException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameReportingLegacyComponent::getGameReportViewInfo</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetGameReportViewInfoAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new GameReportingLegacyException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameReportingLegacyComponent::getGameReportViewInfoList</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetGameReportViewInfoListAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new GameReportingLegacyException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameReportingLegacyComponent::getGameReportTypes</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetGameReportTypesAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new GameReportingLegacyException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameReportingLegacyComponent::submitTrustedMidGameReport</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SubmitTrustedMidGameReportAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new GameReportingLegacyException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameReportingLegacyComponent::submitTrustedEndGameReport</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SubmitTrustedEndGameReportAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new GameReportingLegacyException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>GameReportingLegacyComponent::ResultNotification</b> notification.<br/>
        /// Notification type: <see cref="ResultNotification"/><br/>
        /// </summary>
        public static Task NotifyResultNotificationAsync(BlazeRpcConnection connection, ResultNotification notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = GameReportingLegacyComponentBase.Id;
                frame.Command = (ushort)GameReportingLegacyComponentNotification.ResultNotification;
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

