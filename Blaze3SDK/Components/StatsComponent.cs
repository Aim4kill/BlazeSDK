using Blaze3SDK.Blaze;
using Blaze3SDK.Blaze.Stats;
using BlazeCommon;
using static Blaze3SDK.Components.StatsComponent;

namespace Blaze3SDK.Components
{
    public class StatsComponent : ComponentData<StatsComponentCommand, StatsComponentNotification, StatsComponentError>
    {
        public StatsComponent() : base((ushort)Component.StatsComponent)
        {

        }

        public override Type GetCommandErrorResponseType(StatsComponentCommand command)
        {
            throw new NotImplementedException();
        }

        public override Type GetCommandRequestType(StatsComponentCommand command) => command switch
        {
            StatsComponentCommand.getStatDescs => throw new NotImplementedException(),
            StatsComponentCommand.getStats => throw new NotImplementedException(),
            StatsComponentCommand.getStatGroupList => throw new NotImplementedException(),
            StatsComponentCommand.getStatGroup => typeof(GetStatGroupRequest),
            StatsComponentCommand.getStatsByGroup => throw new NotImplementedException(),
            StatsComponentCommand.getDateRange => throw new NotImplementedException(),
            StatsComponentCommand.getEntityCount => throw new NotImplementedException(),
            StatsComponentCommand.getLeaderboardGroup => throw new NotImplementedException(),
            StatsComponentCommand.getLeaderboardFolderGroup => throw new NotImplementedException(),
            StatsComponentCommand.getLeaderboard => throw new NotImplementedException(),
            StatsComponentCommand.getCenteredLeaderboard => throw new NotImplementedException(),
            StatsComponentCommand.getFilteredLeaderboard => throw new NotImplementedException(),
            StatsComponentCommand.getKeyScopesMap => throw new NotImplementedException(),
            StatsComponentCommand.getStatsByGroupAsync => typeof(GetStatsByGroupRequest),
            StatsComponentCommand.getLeaderboardTreeAsync => throw new NotImplementedException(),
            StatsComponentCommand.getLeaderboardEntityCount => throw new NotImplementedException(),
            StatsComponentCommand.getStatCategoryList => throw new NotImplementedException(),
            StatsComponentCommand.getPeriodIds => throw new NotImplementedException(),
            StatsComponentCommand.getLeaderboardRaw => throw new NotImplementedException(),
            StatsComponentCommand.getCenteredLeaderboardRaw => throw new NotImplementedException(),
            StatsComponentCommand.getFilteredLeaderboardRaw => throw new NotImplementedException(),
            StatsComponentCommand.changeKeyscopeValue => throw new NotImplementedException(),
            _ => throw new NotImplementedException()
        };
        

        public override Type GetCommandResponseType(StatsComponentCommand command) => command switch
        {
            StatsComponentCommand.getStatDescs => throw new NotImplementedException(),
            StatsComponentCommand.getStats => throw new NotImplementedException(),
            StatsComponentCommand.getStatGroupList => throw new NotImplementedException(),
            StatsComponentCommand.getStatGroup => typeof(StatGroupResponse),
            StatsComponentCommand.getStatsByGroup => throw new NotImplementedException(),
            StatsComponentCommand.getDateRange => throw new NotImplementedException(),
            StatsComponentCommand.getEntityCount => throw new NotImplementedException(),
            StatsComponentCommand.getLeaderboardGroup => throw new NotImplementedException(),
            StatsComponentCommand.getLeaderboardFolderGroup => throw new NotImplementedException(),
            StatsComponentCommand.getLeaderboard => throw new NotImplementedException(),
            StatsComponentCommand.getCenteredLeaderboard => throw new NotImplementedException(),
            StatsComponentCommand.getFilteredLeaderboard => throw new NotImplementedException(),
            StatsComponentCommand.getKeyScopesMap => throw new NotImplementedException(),
            StatsComponentCommand.getStatsByGroupAsync => typeof(NullStruct),
            StatsComponentCommand.getLeaderboardTreeAsync => throw new NotImplementedException(),
            StatsComponentCommand.getLeaderboardEntityCount => throw new NotImplementedException(),
            StatsComponentCommand.getStatCategoryList => throw new NotImplementedException(),
            StatsComponentCommand.getPeriodIds => throw new NotImplementedException(),
            StatsComponentCommand.getLeaderboardRaw => throw new NotImplementedException(),
            StatsComponentCommand.getCenteredLeaderboardRaw => throw new NotImplementedException(),
            StatsComponentCommand.getFilteredLeaderboardRaw => throw new NotImplementedException(),
            StatsComponentCommand.changeKeyscopeValue => throw new NotImplementedException(),
            _ => throw new NotImplementedException(),
        };

        public override Type GetNotificationType(StatsComponentNotification notification) => notification switch
        {
            StatsComponentNotification.GetStatsAsyncNotification => typeof(KeyScopedStatValues),
            StatsComponentNotification.GetLeaderboardTreeNotification => throw new NotImplementedException(),
            _ => throw new NotImplementedException(),
        };

        public enum StatsComponentCommand : ushort
        {
            getStatDescs = 1,
            getStats = 2,
            getStatGroupList = 3,
            getStatGroup = 4,
            getStatsByGroup = 5,
            getDateRange = 6,
            getEntityCount = 7,
            getLeaderboardGroup = 10,
            getLeaderboardFolderGroup = 11,
            getLeaderboard = 12,
            getCenteredLeaderboard = 13,
            getFilteredLeaderboard = 14,
            getKeyScopesMap = 15,
            getStatsByGroupAsync = 16,
            getLeaderboardTreeAsync = 17,
            getLeaderboardEntityCount = 18,
            getStatCategoryList = 19,
            getPeriodIds = 20,
            getLeaderboardRaw = 21,
            getCenteredLeaderboardRaw = 22,
            getFilteredLeaderboardRaw = 23,
            changeKeyscopeValue = 24
        }

        public enum StatsComponentNotification : ushort
        {
            GetStatsAsyncNotification = 50,
            GetLeaderboardTreeNotification = 51
        }

        public enum StatsComponentError : int
        {
            STATS_ERR_CONFIG_NOTAVAILABLE = 65543,
            STATS_ERR_INVALID_LEADERBOARD_ID = 131079,
            STATS_ERR_INVALID_FOLDER_ID = 196615,
            STATS_ERR_UNKNOWN_CATEGORY = 262151,
            STATS_ERR_STAT_NOT_FOUND = 327687,
            STATS_ERR_BAD_PERIOD_TYPE = 393223,
            STATS_ERR_NO_DB_CONNECTION = 458759,
            STATS_ERR_DB_DATA_NOT_AVAILABLE = 524295,
            STATS_ERR_UNKNOWN_STAT_GROUP = 589831,
            STATS_ERR_DB_TRANSACTION_ERROR = 655367,
            STATS_ERR_INVALID_UPDATE_TYPE = 720903,
            STATS_ERR_DB_QUERY_FAILED = 851975,
            STATS_ERR_RANK_OUT_OF_RANGE = 917511,
            STATS_ERR_BAD_PERIOD_OFFSET = 983047,
            STATS_ERR_BAD_SCOPE_INFO = 1048583,
            STATS_ERR_INVALID_FOLDER_NAME = 1114119,
            STATS_ERR_OPERATION_IN_PROGRESS = 1179655,
            STATS_ERR_INVALID_OPERATION = 1310727,
            STATS_ERR_INVALID_OBJECT_ID = 1376263,
            STATS_ERR_BAD_PERIOD_COUNTER = 1441799
        }
    }
}
