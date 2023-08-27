using Blaze2SDK.Blaze.GameReporting;
using BlazeCommon;

namespace Blaze2SDK.Components
{
    public static class GameReportingComponentBase
    {
        public const ushort Id = 12;
        public const string Name = "GameReportingComponent";
        
        public class Server : BlazeComponent<GameReportingComponentCommand, GameReportingComponentNotification, Blaze2RpcError>
        {
            public Server() : base(GameReportingComponentBase.Id, GameReportingComponentBase.Name)
            {
                
            }
            
            [BlazeCommand((ushort)GameReportingComponentCommand.submitGameReport)]
            public virtual Task<NullStruct> SubmitGameReportAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameReportingComponentCommand.submitOfflineGameReport)]
            public virtual Task<NullStruct> SubmitOfflineGameReportAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameReportingComponentCommand.submitGameEvents)]
            public virtual Task<NullStruct> SubmitGameEventsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameReportingComponentCommand.getGameReports)]
            public virtual Task<NullStruct> GetGameReportsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameReportingComponentCommand.getGameReportView)]
            public virtual Task<NullStruct> GetGameReportViewAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameReportingComponentCommand.getGameReportViewInfo)]
            public virtual Task<NullStruct> GetGameReportViewInfoAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameReportingComponentCommand.getGameReportViewInfoList)]
            public virtual Task<NullStruct> GetGameReportViewInfoListAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameReportingComponentCommand.getGameReportTypes)]
            public virtual Task<NullStruct> GetGameReportTypesAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameReportingComponentCommand.submitTrustedMidGameReport)]
            public virtual Task<NullStruct> SubmitTrustedMidGameReportAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameReportingComponentCommand.submitTrustedEndGameReport)]
            public virtual Task<NullStruct> SubmitTrustedEndGameReportAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            
            public static Task NotifyResultNotificationAsync(BlazeServerConnection connection, ResultNotification notification)
            {
                return connection.NotifyAsync(GameReportingComponentBase.Id, (ushort)GameReportingComponentNotification.ResultNotification, notification);
            }
            
            public override Type GetCommandRequestType(GameReportingComponentCommand command) => GameReportingComponentBase.GetCommandRequestType(command);
            public override Type GetCommandResponseType(GameReportingComponentCommand command) => GameReportingComponentBase.GetCommandResponseType(command);
            public override Type GetCommandErrorResponseType(GameReportingComponentCommand command) => GameReportingComponentBase.GetCommandErrorResponseType(command);
            public override Type GetNotificationType(GameReportingComponentNotification notification) => GameReportingComponentBase.GetNotificationType(notification);
            
        }
        
        public class Client : BlazeComponent<GameReportingComponentCommand, GameReportingComponentNotification, Blaze2RpcError>
        {
            public Client() : base(GameReportingComponentBase.Id, GameReportingComponentBase.Name)
            {
                
            }
            
            public override Type GetCommandRequestType(GameReportingComponentCommand command) => GameReportingComponentBase.GetCommandRequestType(command);
            public override Type GetCommandResponseType(GameReportingComponentCommand command) => GameReportingComponentBase.GetCommandResponseType(command);
            public override Type GetCommandErrorResponseType(GameReportingComponentCommand command) => GameReportingComponentBase.GetCommandErrorResponseType(command);
            public override Type GetNotificationType(GameReportingComponentNotification notification) => GameReportingComponentBase.GetNotificationType(notification);
            
        }
        
        public static Type GetCommandRequestType(GameReportingComponentCommand command) => command switch
        {
            GameReportingComponentCommand.submitGameReport => typeof(NullStruct),
            GameReportingComponentCommand.submitOfflineGameReport => typeof(NullStruct),
            GameReportingComponentCommand.submitGameEvents => typeof(NullStruct),
            GameReportingComponentCommand.getGameReports => typeof(NullStruct),
            GameReportingComponentCommand.getGameReportView => typeof(NullStruct),
            GameReportingComponentCommand.getGameReportViewInfo => typeof(NullStruct),
            GameReportingComponentCommand.getGameReportViewInfoList => typeof(NullStruct),
            GameReportingComponentCommand.getGameReportTypes => typeof(NullStruct),
            GameReportingComponentCommand.submitTrustedMidGameReport => typeof(NullStruct),
            GameReportingComponentCommand.submitTrustedEndGameReport => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandResponseType(GameReportingComponentCommand command) => command switch
        {
            GameReportingComponentCommand.submitGameReport => typeof(NullStruct),
            GameReportingComponentCommand.submitOfflineGameReport => typeof(NullStruct),
            GameReportingComponentCommand.submitGameEvents => typeof(NullStruct),
            GameReportingComponentCommand.getGameReports => typeof(NullStruct),
            GameReportingComponentCommand.getGameReportView => typeof(NullStruct),
            GameReportingComponentCommand.getGameReportViewInfo => typeof(NullStruct),
            GameReportingComponentCommand.getGameReportViewInfoList => typeof(NullStruct),
            GameReportingComponentCommand.getGameReportTypes => typeof(NullStruct),
            GameReportingComponentCommand.submitTrustedMidGameReport => typeof(NullStruct),
            GameReportingComponentCommand.submitTrustedEndGameReport => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandErrorResponseType(GameReportingComponentCommand command) => command switch
        {
            GameReportingComponentCommand.submitGameReport => typeof(NullStruct),
            GameReportingComponentCommand.submitOfflineGameReport => typeof(NullStruct),
            GameReportingComponentCommand.submitGameEvents => typeof(NullStruct),
            GameReportingComponentCommand.getGameReports => typeof(NullStruct),
            GameReportingComponentCommand.getGameReportView => typeof(NullStruct),
            GameReportingComponentCommand.getGameReportViewInfo => typeof(NullStruct),
            GameReportingComponentCommand.getGameReportViewInfoList => typeof(NullStruct),
            GameReportingComponentCommand.getGameReportTypes => typeof(NullStruct),
            GameReportingComponentCommand.submitTrustedMidGameReport => typeof(NullStruct),
            GameReportingComponentCommand.submitTrustedEndGameReport => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetNotificationType(GameReportingComponentNotification notification) => notification switch
        {
            GameReportingComponentNotification.ResultNotification => typeof(ResultNotification),
            _ => typeof(NullStruct)
        };
        
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
        
    }
}
