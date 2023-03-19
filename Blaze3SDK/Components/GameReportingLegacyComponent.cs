using Blaze3SDK.Blaze;
using Blaze3SDK.Blaze.GameReportingLegacy;
using BlazeCommon;
using static Blaze3SDK.Components.GameReportingLegacyComponent;

namespace Blaze3SDK.Components
{
    public class GameReportingLegacyComponent : ComponentData<GameReportingLegacyComponentCommand, GameReportingLegacyComponentNotification, GameReportingLegacyComponentError>
    {
        public GameReportingLegacyComponent() : base((ushort)Component.GameReportingLegacyComponent)
        {

        }

        public override Type GetCommandErrorResponseType(GameReportingLegacyComponentCommand command) => command switch
        {
            GameReportingLegacyComponentCommand.submitGameReport => throw new NotImplementedException(),
            GameReportingLegacyComponentCommand.submitOfflineGameReport => throw new NotImplementedException(),
            GameReportingLegacyComponentCommand.submitGameEvents => throw new NotImplementedException(),
            GameReportingLegacyComponentCommand.getGameReports => throw new NotImplementedException(),
            GameReportingLegacyComponentCommand.getGameReportView => throw new NotImplementedException(),
            GameReportingLegacyComponentCommand.getGameReportViewInfo => throw new NotImplementedException(),
            GameReportingLegacyComponentCommand.getGameReportViewInfoList => throw new NotImplementedException(),
            GameReportingLegacyComponentCommand.getGameReportTypes => throw new NotImplementedException(),
            GameReportingLegacyComponentCommand.submitTrustedMidGameReport => throw new NotImplementedException(),
            GameReportingLegacyComponentCommand.submitTrustedEndGameReport => throw new NotImplementedException(),
            _ => typeof(NullStruct)
        };

        public override Type GetCommandRequestType(GameReportingLegacyComponentCommand command) => command switch
        {
            GameReportingLegacyComponentCommand.submitGameReport => throw new NotImplementedException(),
            GameReportingLegacyComponentCommand.submitOfflineGameReport => throw new NotImplementedException(),
            GameReportingLegacyComponentCommand.submitGameEvents => throw new NotImplementedException(),
            GameReportingLegacyComponentCommand.getGameReports => throw new NotImplementedException(),
            GameReportingLegacyComponentCommand.getGameReportView => throw new NotImplementedException(),
            GameReportingLegacyComponentCommand.getGameReportViewInfo => throw new NotImplementedException(),
            GameReportingLegacyComponentCommand.getGameReportViewInfoList => throw new NotImplementedException(),
            GameReportingLegacyComponentCommand.getGameReportTypes => throw new NotImplementedException(),
            GameReportingLegacyComponentCommand.submitTrustedMidGameReport => throw new NotImplementedException(),
            GameReportingLegacyComponentCommand.submitTrustedEndGameReport => throw new NotImplementedException(),
            _ => typeof(NullStruct)
        };

        public override Type GetCommandResponseType(GameReportingLegacyComponentCommand command) => command switch
        {
            GameReportingLegacyComponentCommand.submitGameReport => throw new NotImplementedException(),
            GameReportingLegacyComponentCommand.submitOfflineGameReport => throw new NotImplementedException(),
            GameReportingLegacyComponentCommand.submitGameEvents => throw new NotImplementedException(),
            GameReportingLegacyComponentCommand.getGameReports => throw new NotImplementedException(),
            GameReportingLegacyComponentCommand.getGameReportView => throw new NotImplementedException(),
            GameReportingLegacyComponentCommand.getGameReportViewInfo => throw new NotImplementedException(),
            GameReportingLegacyComponentCommand.getGameReportViewInfoList => throw new NotImplementedException(),
            GameReportingLegacyComponentCommand.getGameReportTypes => throw new NotImplementedException(),
            GameReportingLegacyComponentCommand.submitTrustedMidGameReport => throw new NotImplementedException(),
            GameReportingLegacyComponentCommand.submitTrustedEndGameReport => throw new NotImplementedException(),
            _ => typeof(NullStruct)
        };

        public override Type GetNotificationType(GameReportingLegacyComponentNotification notification) => notification switch
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

        public enum GameReportingLegacyComponentError
        {
            GAMEHISTORYLEGACY_ERR_INVALID_QUERY = 65548,
            GAMEHISTORYLEGACY_ERR_UNKNOWN_VIEW = 131084,
            GAMEHISTORYLEGACY_ERR_MISSING_QVARS = 196620,
            GAMEREPORTINGLEGACY_COLLATION_ERR_NO_VALID_REPORTS = 6553612,
            GAMEREPORTINGLEGACY_COLLATION_ERR_NO_REPORTS = 6619148,
            GAMEREPORTINGLEGACY_COLLATION_REPORTS_INCONSISTENT = 6684684,
            GAMEREPORTINGLEGACY_COLLATION_ERR_MISSING_GAME_ATTRIBUTE = 6750220,
            GAMEREPORTINGLEGACY_COLLATION_ERR_INVALID_GAME_ATTRIBUTE = 6815756,
            GAMEREPORTINGLEGACY_CUSTOM_ERR_PROCESSING_FAILED = 13107212,
            GAMEREPORTINGLEGACY_CONFIG_ERR_MISSING_PROCESSOR_ATTRIBUTE = 13172748,
            GAMEREPORTINGLEGACY_CONFIG_ERR_INVALID_PROCESSOR_ATTRIBUTE = 13238284,
            GAMEREPORTINGLEGACY_CONFIG_ERR_STAT_UPDATE_FAILED = 13303820,
            GAMEREPORTINGLEGACY_CUSTOM_ERR_PROCESS_UPDATED_STATS_FAILED = 13369356,
            GAMEREPORTINGLEGACY_OFFLINE_ERR_FIRST_PLAYER_NOT_BLAZE_USER = 19726348,
            GAMEREPORTINGLEGACY_OFFLINE_ERR_INVALID_GAME_TYPE_ID = 19791884,
            GAMEREPORTINGLEGACY_OFFLINE_ERR_REPORT_INVALID = 19857420,
            GAMEREPORTINGLEGACY_TRUSTED_ERR_CLIENT_NOT_TRUSTED = 26214412,
            GAMEREPORTINGLEGACY_TRUSTED_ERR_INVALID_GAME_TYPE_ID = 26279948,
            GAMEREPORTINGLEGACY_TRUSTED_ERR_REPORT_INVALID = 26345484,
            GAMEREPORTINGLEGACY_ERR_UNEXPECTED_REPORT = 32768012,
        }

    }
}
