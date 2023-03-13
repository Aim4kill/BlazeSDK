using BlazeCommon;
using static Blaze3SDK.Components.GameReportingComponent;

namespace Blaze3SDK.Components
{
    public class GameReportingComponent : ComponentData<GameReportingComponentCommand, GameReportingComponentNotification, GameReportingComponentError>
    {
        public GameReportingComponent() : base((ushort)Component.GameReportingComponent)
        {

        }

        public override Type GetCommandErrorResponseType(GameReportingComponentCommand command) => command switch
        {
            _ => throw new NotImplementedException()
        };

        public override Type GetCommandRequestType(GameReportingComponentCommand command) => command switch
        {
            _ => throw new NotImplementedException()
        };

        public override Type GetCommandResponseType(GameReportingComponentCommand command) => command switch
        {
            GameReportingComponentCommand.submitGameReport => throw new NotImplementedException(),
            GameReportingComponentCommand.submitOfflineGameReport => throw new NotImplementedException(),
            GameReportingComponentCommand.submitGameEvents => throw new NotImplementedException(),
            GameReportingComponentCommand.getGameReportQuery => throw new NotImplementedException(),
            GameReportingComponentCommand.getGameReportQueriesList => throw new NotImplementedException(),
            GameReportingComponentCommand.getGameReports => throw new NotImplementedException(),
            GameReportingComponentCommand.getGameReportView => throw new NotImplementedException(),
            GameReportingComponentCommand.getGameReportViewInfo => throw new NotImplementedException(),
            GameReportingComponentCommand.getGameReportViewInfoList => throw new NotImplementedException(),
            GameReportingComponentCommand.getGameReportTypes => throw new NotImplementedException(),
            GameReportingComponentCommand.updateMetric => throw new NotImplementedException(),
            GameReportingComponentCommand.getGameReportColumnInfo => throw new NotImplementedException(),
            GameReportingComponentCommand.getGameReportColumnValues => throw new NotImplementedException(),
            GameReportingComponentCommand.submitTrustedMidGameReport => throw new NotImplementedException(),
            GameReportingComponentCommand.submitTrustedEndGameReport => throw new NotImplementedException(),
            _ => throw new NotImplementedException(),
        };

        public override Type GetNotificationType(GameReportingComponentNotification notification) => notification switch
        {
            _ => throw new NotImplementedException(),
        };

        public enum GameReportingComponentCommand : ushort
        {
            submitGameReport = 1,
            submitOfflineGameReport,
            submitGameEvents,
            getGameReportQuery,
            getGameReportQueriesList,
            getGameReports,
            getGameReportView,
            getGameReportViewInfo,
            getGameReportViewInfoList,
            getGameReportTypes,
            updateMetric,
            getGameReportColumnInfo,
            getGameReportColumnValues,
            submitTrustedMidGameReport = 100,
            submitTrustedEndGameReport
        }

        public enum GameReportingComponentNotification : ushort
        {

        }

        public enum GameReportingComponentError : int
        {

        }
    }
}
