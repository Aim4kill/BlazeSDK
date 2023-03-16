using Blaze3SDK.Blaze;
using BlazeCommon;
using static Blaze3SDK.Components.LeagueComponent;

namespace Blaze3SDK.Components
{
    public class LeagueComponent : ComponentData<LeagueComponentCommand, LeagueComponentNotification, LeagueComponentError>
    {
        public LeagueComponent() : base((ushort)Component.LeagueComponent)
        {

        }

        public override Type GetCommandErrorResponseType(LeagueComponentCommand command) => command switch
        {
            LeagueComponentCommand.createLeague => throw new NotImplementedException(),
            LeagueComponentCommand.joinLeague => throw new NotImplementedException(),
            LeagueComponentCommand.getLeague => throw new NotImplementedException(),
            LeagueComponentCommand.getLeaguesByUser => throw new NotImplementedException(),
            LeagueComponentCommand.deleteLeague => throw new NotImplementedException(),
            LeagueComponentCommand.promoteToGM => throw new NotImplementedException(),
            LeagueComponentCommand.findLeagues => throw new NotImplementedException(),
            LeagueComponentCommand.findLeaguesAsync => throw new NotImplementedException(),
            LeagueComponentCommand.removeMember => throw new NotImplementedException(),
            LeagueComponentCommand.resetLeague => throw new NotImplementedException(),
            LeagueComponentCommand.updateLeagueSettings => throw new NotImplementedException(),
            LeagueComponentCommand.setMetadata => throw new NotImplementedException(),
            LeagueComponentCommand.postNews => throw new NotImplementedException(),
            LeagueComponentCommand.getNews => throw new NotImplementedException(),
            LeagueComponentCommand.setRoster => throw new NotImplementedException(),
            LeagueComponentCommand.sendInvitation => throw new NotImplementedException(),
            LeagueComponentCommand.getInvitations => throw new NotImplementedException(),
            LeagueComponentCommand.processInvitation => throw new NotImplementedException(),
            LeagueComponentCommand.proposeTrade => throw new NotImplementedException(),
            LeagueComponentCommand.processTrade => throw new NotImplementedException(),
            LeagueComponentCommand.getTrades => throw new NotImplementedException(),
            LeagueComponentCommand.getMembers => throw new NotImplementedException(),
            LeagueComponentCommand.submitStatistics => throw new NotImplementedException(),
            LeagueComponentCommand.getRecentGames => throw new NotImplementedException(),
            LeagueComponentCommand.submitScores => throw new NotImplementedException(),
            LeagueComponentCommand.getRoster => throw new NotImplementedException(),
            LeagueComponentCommand.runDraft => throw new NotImplementedException(),
            LeagueComponentCommand.getDraftProfile => throw new NotImplementedException(),
            LeagueComponentCommand.setDraftProfile => throw new NotImplementedException(),
            LeagueComponentCommand.getPlayoffSeries => throw new NotImplementedException(),
            _ => typeof(NullStruct)
        };

        public override Type GetCommandRequestType(LeagueComponentCommand command) => command switch
        {
            LeagueComponentCommand.createLeague => throw new NotImplementedException(),
            LeagueComponentCommand.joinLeague => throw new NotImplementedException(),
            LeagueComponentCommand.getLeague => throw new NotImplementedException(),
            LeagueComponentCommand.getLeaguesByUser => throw new NotImplementedException(),
            LeagueComponentCommand.deleteLeague => throw new NotImplementedException(),
            LeagueComponentCommand.promoteToGM => throw new NotImplementedException(),
            LeagueComponentCommand.findLeagues => throw new NotImplementedException(),
            LeagueComponentCommand.findLeaguesAsync => throw new NotImplementedException(),
            LeagueComponentCommand.removeMember => throw new NotImplementedException(),
            LeagueComponentCommand.resetLeague => throw new NotImplementedException(),
            LeagueComponentCommand.updateLeagueSettings => throw new NotImplementedException(),
            LeagueComponentCommand.setMetadata => throw new NotImplementedException(),
            LeagueComponentCommand.postNews => throw new NotImplementedException(),
            LeagueComponentCommand.getNews => throw new NotImplementedException(),
            LeagueComponentCommand.setRoster => throw new NotImplementedException(),
            LeagueComponentCommand.sendInvitation => throw new NotImplementedException(),
            LeagueComponentCommand.getInvitations => throw new NotImplementedException(),
            LeagueComponentCommand.processInvitation => throw new NotImplementedException(),
            LeagueComponentCommand.proposeTrade => throw new NotImplementedException(),
            LeagueComponentCommand.processTrade => throw new NotImplementedException(),
            LeagueComponentCommand.getTrades => throw new NotImplementedException(),
            LeagueComponentCommand.getMembers => throw new NotImplementedException(),
            LeagueComponentCommand.submitStatistics => throw new NotImplementedException(),
            LeagueComponentCommand.getRecentGames => throw new NotImplementedException(),
            LeagueComponentCommand.submitScores => throw new NotImplementedException(),
            LeagueComponentCommand.getRoster => throw new NotImplementedException(),
            LeagueComponentCommand.runDraft => throw new NotImplementedException(),
            LeagueComponentCommand.getDraftProfile => throw new NotImplementedException(),
            LeagueComponentCommand.setDraftProfile => throw new NotImplementedException(),
            LeagueComponentCommand.getPlayoffSeries => throw new NotImplementedException(),
            _ => typeof(NullStruct)
        };

        public override Type GetCommandResponseType(LeagueComponentCommand command) => command switch
        {
            LeagueComponentCommand.createLeague => throw new NotImplementedException(),
            LeagueComponentCommand.joinLeague => throw new NotImplementedException(),
            LeagueComponentCommand.getLeague => throw new NotImplementedException(),
            LeagueComponentCommand.getLeaguesByUser => throw new NotImplementedException(),
            LeagueComponentCommand.deleteLeague => throw new NotImplementedException(),
            LeagueComponentCommand.promoteToGM => throw new NotImplementedException(),
            LeagueComponentCommand.findLeagues => throw new NotImplementedException(),
            LeagueComponentCommand.findLeaguesAsync => throw new NotImplementedException(),
            LeagueComponentCommand.removeMember => throw new NotImplementedException(),
            LeagueComponentCommand.resetLeague => throw new NotImplementedException(),
            LeagueComponentCommand.updateLeagueSettings => throw new NotImplementedException(),
            LeagueComponentCommand.setMetadata => throw new NotImplementedException(),
            LeagueComponentCommand.postNews => throw new NotImplementedException(),
            LeagueComponentCommand.getNews => throw new NotImplementedException(),
            LeagueComponentCommand.setRoster => throw new NotImplementedException(),
            LeagueComponentCommand.sendInvitation => throw new NotImplementedException(),
            LeagueComponentCommand.getInvitations => throw new NotImplementedException(),
            LeagueComponentCommand.processInvitation => throw new NotImplementedException(),
            LeagueComponentCommand.proposeTrade => throw new NotImplementedException(),
            LeagueComponentCommand.processTrade => throw new NotImplementedException(),
            LeagueComponentCommand.getTrades => throw new NotImplementedException(),
            LeagueComponentCommand.getMembers => throw new NotImplementedException(),
            LeagueComponentCommand.submitStatistics => throw new NotImplementedException(),
            LeagueComponentCommand.getRecentGames => throw new NotImplementedException(),
            LeagueComponentCommand.submitScores => throw new NotImplementedException(),
            LeagueComponentCommand.getRoster => throw new NotImplementedException(),
            LeagueComponentCommand.runDraft => throw new NotImplementedException(),
            LeagueComponentCommand.getDraftProfile => throw new NotImplementedException(),
            LeagueComponentCommand.setDraftProfile => throw new NotImplementedException(),
            LeagueComponentCommand.getPlayoffSeries => throw new NotImplementedException(),
            _ => typeof(NullStruct)
        };

        public override Type GetNotificationType(LeagueComponentNotification notification) => notification switch
        {
            LeagueComponentNotification.FindLeaguesAsyncNotification => throw new NotImplementedException(),
            _ => typeof(NullStruct)
        };

        public enum LeagueComponentCommand : ushort
        {
            createLeague = 1,
            joinLeague = 2,
            getLeague = 3,
            getLeaguesByUser = 4,
            deleteLeague = 5,
            promoteToGM = 7,
            findLeagues = 8,
            findLeaguesAsync = 9,
            removeMember = 10,
            resetLeague = 11,
            updateLeagueSettings = 12,
            setMetadata = 13,
            postNews = 15,
            getNews = 16,
            setRoster = 20,
            sendInvitation = 22,
            getInvitations = 23,
            processInvitation = 24,
            proposeTrade = 26,
            processTrade = 27,
            getTrades = 29,
            getMembers = 31,
            submitStatistics = 103,
            getRecentGames = 104,
            submitScores = 105,
            getRoster = 107,
            runDraft = 109,
            getDraftProfile = 112,
            setDraftProfile = 113,
            getPlayoffSeries = 116,
        }

        public enum LeagueComponentNotification : ushort
        {
            FindLeaguesAsyncNotification = 118,
        }

        public enum LeagueComponentError
        {
            LEAGUE_ERR_INVALID_LEAGUEID = 65549,
            LEAGUE_ERR_INVALID_PLAYERID = 131085,
            LEAGUE_ERR_INVALID_TRADEID = 196621,
            LEAGUE_ERR_INVALID_ROSTERID = 262157,
            LEAGUE_ERR_INVALID_GAMEID = 327693,
            LEAGUE_ERR_INVALID_BLAZEID = 393229,
            LEAGUE_ERR_INVALID_ARGUMENT = 458765,
            LEAGUE_ERR_MAX_LEAGUES = 524301,
            LEAGUE_ERR_INCORRECT_PASSWORD = 589837,
            LEAGUE_ERR_LEAGUE_FULL = 655373,
            LEAGUE_ERR_REQUESTER_NOT_AUTHORIZED = 720909,
            LEAGUE_ERR_REQUESTER_NOT_A_MEMBER = 786445,
            LEAGUE_ERR_USER_NOT_A_MEMBER = 851981,
            LEAGUE_ERR_JOINS_DISABLED = 917517,
            LEAGUE_ERR_INVALID_OP_FOR_LEAGUE_STATE = 983053,
            LEAGUE_ERR_ALREADY_A_GM = 1048589,
            LEAGUE_ERR_ALREADY_A_MEMBER = 1114125,
            LEAGUE_ERR_LEAGUE_NAME_IN_USE = 1179661,
            LEAGUE_ERR_PROFANITY_FILTER = 1245197,
            LEAGUE_ERR_LAST_GM = 1310733,
            LEAGUE_ERR_INVALID_TRADE_PROPOSAL = 1376269,
            LEAGUE_ERR_TRADES_DISABLED = 1441805,
            LEAGUE_ERR_REP_TOO_LOW = 1507341,
            LEAGUE_ERR_DNF_TOO_HIGH = 1572877,
            LEAGUE_ERR_DATABASE_ERROR = 1638413,
            LEAGUE_ERR_REQUESTER_NOT_A_GM = 1703949,
            LEAGUE_ERR_LEAGUE_NOT_EMPTY = 1769485,
            LEAGUE_ERR_REQUESTER_IS_BANNED = 1835021,
            LEAGUE_ERR_INVALID_INVITATION = 1900557,
            LEAGUE_ERR_SERVER_ERROR = 1966093,
            LEAGUE_ERR_NOT_ENOUGH_MEMBERS_TO_RUN_DRAFT = 2031629,
            LEAGUE_ERR_DRAFT_DISABLED = 2097165,
            LEAGUE_ERR_LEAGUES_SERVER_UNAVAILABLE = 2162701,
            LEAGUE_ERR_TEAM_IN_USE = 2228237,
            LEAGUE_ERR_ROSTER_CRC_MISMATCH = 2293773,
            LEAGUE_ERR_INVALID_INVITEE = 2359309,
            LEAGUE_ERR_INVITEE_IS_BANNED = 2424845,
            LEAGUE_ERR_REQUESTER_IS_TEMP_BANNED = 2490381,
        }

    }
}
