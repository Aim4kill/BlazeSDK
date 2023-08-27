using Blaze3SDK.Blaze.GameReportingLegacy;
using BlazeCommon;

namespace Blaze3SDK.Components
{
    public static class GameReportingLegacyComponentBase
    {
        public const ushort Id = 12;
        public const string Name = "GameReportingLegacyComponent";
        
        public class Server : BlazeComponent<GameReportingLegacyComponentCommand, GameReportingLegacyComponentNotification, Blaze3RpcError>
        {
            public Server() : base(GameReportingLegacyComponentBase.Id, GameReportingLegacyComponentBase.Name)
            {
                
            }
            
            [BlazeCommand((ushort)GameReportingLegacyComponentCommand.submitGameReport)]
            public virtual Task<NullStruct> SubmitGameReportAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameReportingLegacyComponentCommand.submitOfflineGameReport)]
            public virtual Task<NullStruct> SubmitOfflineGameReportAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameReportingLegacyComponentCommand.submitGameEvents)]
            public virtual Task<NullStruct> SubmitGameEventsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameReportingLegacyComponentCommand.getGameReports)]
            public virtual Task<NullStruct> GetGameReportsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameReportingLegacyComponentCommand.getGameReportView)]
            public virtual Task<NullStruct> GetGameReportViewAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameReportingLegacyComponentCommand.getGameReportViewInfo)]
            public virtual Task<NullStruct> GetGameReportViewInfoAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameReportingLegacyComponentCommand.getGameReportViewInfoList)]
            public virtual Task<NullStruct> GetGameReportViewInfoListAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameReportingLegacyComponentCommand.getGameReportTypes)]
            public virtual Task<NullStruct> GetGameReportTypesAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameReportingLegacyComponentCommand.submitTrustedMidGameReport)]
            public virtual Task<NullStruct> SubmitTrustedMidGameReportAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameReportingLegacyComponentCommand.submitTrustedEndGameReport)]
            public virtual Task<NullStruct> SubmitTrustedEndGameReportAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            
            public static Task NotifyResultNotificationAsync(BlazeServerConnection connection, ResultNotification notification)
            {
                return connection.NotifyAsync(GameReportingLegacyComponentBase.Id, (ushort)GameReportingLegacyComponentNotification.ResultNotification, notification);
            }
            
            public override Type GetCommandRequestType(GameReportingLegacyComponentCommand command) => GameReportingLegacyComponentBase.GetCommandRequestType(command);
            public override Type GetCommandResponseType(GameReportingLegacyComponentCommand command) => GameReportingLegacyComponentBase.GetCommandResponseType(command);
            public override Type GetCommandErrorResponseType(GameReportingLegacyComponentCommand command) => GameReportingLegacyComponentBase.GetCommandErrorResponseType(command);
            public override Type GetNotificationType(GameReportingLegacyComponentNotification notification) => GameReportingLegacyComponentBase.GetNotificationType(notification);
            
        }
        
        public class Client : BlazeComponent<GameReportingLegacyComponentCommand, GameReportingLegacyComponentNotification, Blaze3RpcError>
        {
            public Client() : base(GameReportingLegacyComponentBase.Id, GameReportingLegacyComponentBase.Name)
            {
                
            }
            
            public override Type GetCommandRequestType(GameReportingLegacyComponentCommand command) => GameReportingLegacyComponentBase.GetCommandRequestType(command);
            public override Type GetCommandResponseType(GameReportingLegacyComponentCommand command) => GameReportingLegacyComponentBase.GetCommandResponseType(command);
            public override Type GetCommandErrorResponseType(GameReportingLegacyComponentCommand command) => GameReportingLegacyComponentBase.GetCommandErrorResponseType(command);
            public override Type GetNotificationType(GameReportingLegacyComponentNotification notification) => GameReportingLegacyComponentBase.GetNotificationType(notification);
            
        }
        
        public static Type GetCommandRequestType(GameReportingLegacyComponentCommand command) => command switch
        {
            GameReportingLegacyComponentCommand.submitGameReport => typeof(NullStruct),
            GameReportingLegacyComponentCommand.submitOfflineGameReport => typeof(NullStruct),
            GameReportingLegacyComponentCommand.submitGameEvents => typeof(NullStruct),
            GameReportingLegacyComponentCommand.getGameReports => typeof(NullStruct),
            GameReportingLegacyComponentCommand.getGameReportView => typeof(NullStruct),
            GameReportingLegacyComponentCommand.getGameReportViewInfo => typeof(NullStruct),
            GameReportingLegacyComponentCommand.getGameReportViewInfoList => typeof(NullStruct),
            GameReportingLegacyComponentCommand.getGameReportTypes => typeof(NullStruct),
            GameReportingLegacyComponentCommand.submitTrustedMidGameReport => typeof(NullStruct),
            GameReportingLegacyComponentCommand.submitTrustedEndGameReport => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandResponseType(GameReportingLegacyComponentCommand command) => command switch
        {
            GameReportingLegacyComponentCommand.submitGameReport => typeof(NullStruct),
            GameReportingLegacyComponentCommand.submitOfflineGameReport => typeof(NullStruct),
            GameReportingLegacyComponentCommand.submitGameEvents => typeof(NullStruct),
            GameReportingLegacyComponentCommand.getGameReports => typeof(NullStruct),
            GameReportingLegacyComponentCommand.getGameReportView => typeof(NullStruct),
            GameReportingLegacyComponentCommand.getGameReportViewInfo => typeof(NullStruct),
            GameReportingLegacyComponentCommand.getGameReportViewInfoList => typeof(NullStruct),
            GameReportingLegacyComponentCommand.getGameReportTypes => typeof(NullStruct),
            GameReportingLegacyComponentCommand.submitTrustedMidGameReport => typeof(NullStruct),
            GameReportingLegacyComponentCommand.submitTrustedEndGameReport => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandErrorResponseType(GameReportingLegacyComponentCommand command) => command switch
        {
            GameReportingLegacyComponentCommand.submitGameReport => typeof(NullStruct),
            GameReportingLegacyComponentCommand.submitOfflineGameReport => typeof(NullStruct),
            GameReportingLegacyComponentCommand.submitGameEvents => typeof(NullStruct),
            GameReportingLegacyComponentCommand.getGameReports => typeof(NullStruct),
            GameReportingLegacyComponentCommand.getGameReportView => typeof(NullStruct),
            GameReportingLegacyComponentCommand.getGameReportViewInfo => typeof(NullStruct),
            GameReportingLegacyComponentCommand.getGameReportViewInfoList => typeof(NullStruct),
            GameReportingLegacyComponentCommand.getGameReportTypes => typeof(NullStruct),
            GameReportingLegacyComponentCommand.submitTrustedMidGameReport => typeof(NullStruct),
            GameReportingLegacyComponentCommand.submitTrustedEndGameReport => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetNotificationType(GameReportingLegacyComponentNotification notification) => notification switch
        {
            GameReportingLegacyComponentNotification.ResultNotification => typeof(ResultNotification),
            _ => typeof(NullStruct)
        };
        
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
        
    }
}
