using Blaze3SDK.Blaze;
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
            _ => typeof(NullStruct)
        };

        public override Type GetCommandRequestType(GameReportingComponentCommand command) => command switch
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
            _ => typeof(NullStruct)
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
            _ => typeof(NullStruct)
        };

        public override Type GetNotificationType(GameReportingComponentNotification notification) => notification switch
        {
            GameReportingComponentNotification.ResultNotification => throw new NotImplementedException(),
            _ => typeof(NullStruct)
        };

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

        public enum GameReportingComponentError
        {
            GAMEREPORTING_ERR_UNEXPECTED_REPORT = 65564,
            GAMEREPORTING_COLLATION_ERR_NO_VALID_REPORTS = 6553628,
            GAMEREPORTING_COLLATION_ERR_NO_REPORTS = 6619164,
            GAMEREPORTING_COLLATION_REPORTS_INCONSISTENT = 6684700,
            GAMEREPORTING_COLLATION_ERR_MISSING_GAME_ATTRIBUTE = 6750236,
            GAMEREPORTING_COLLATION_ERR_INVALID_GAME_ATTRIBUTE = 6815772,
            GAMEREPORTING_CUSTOM_ERR_PROCESSING_FAILED = 13107228,
            GAMEREPORTING_CONFIG_ERR_MISSING_PROCESSOR_ATTRIBUTE = 13172764,
            GAMEREPORTING_CONFIG_ERR_INVALID_PROCESSOR_ATTRIBUTE = 13238300,
            GAMEREPORTING_CONFIG_ERR_STAT_UPDATE_FAILED = 13303836,
            GAMEREPORTING_CUSTOM_ERR_PROCESS_UPDATED_STATS_FAILED = 13369372,
            GAMEREPORTING_ERR_INVALID_GAME_TYPE = 13434908,
            GAMEREPORTING_OFFLINE_ERR_INVALID_GAME_TYPE = 19726364,
            GAMEREPORTING_OFFLINE_ERR_REPORT_INVALID = 19791900,
            GAMEREPORTING_TRUSTED_ERR_INVALID_GAME_TYPE = 26279964,
            GAMEREPORTING_TRUSTED_ERR_REPORT_INVALID = 26345500,
            GAMEREPORTING_TRUSTED_ERR_CLIENT_NOT_TRUSTED = 26411036,
            GAMEHISTORY_ERR_UNKNOWN_QUERY = 32833564,
            GAMEHISTORY_ERR_INVALID_COLUMNKEY = 32899100,
            GAMEHISTORY_ERR_INVALID_FILTER = 32964636,
            GAMEHISTORY_ERR_INVALID_GAMETYPE = 33030172,
            GAMEHISTORY_ERR_UNKNOWN_VIEW = 33095708,
            GAMEHISTORY_ERR_INVALID_QUERY = 33161244,
            GAMEHISTORY_ERR_MISSING_QVARS = 33226780,
            GAMEHISTORY_ERR_INVALID_QVARS = 33292316,
        }

    }
}
