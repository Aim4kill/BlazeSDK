using Blaze3SDK.Blaze.League;
using BlazeCommon;

namespace Blaze3SDK.Components
{
    public static class LeagueComponentBase
    {
        public const ushort Id = 13;
        public const string Name = "LeagueComponent";
        
        public class Server : BlazeComponent<LeagueComponentCommand, LeagueComponentNotification, Blaze3RpcError>
        {
            public Server() : base(LeagueComponentBase.Id, LeagueComponentBase.Name)
            {
                
            }
            
            [BlazeCommand((ushort)LeagueComponentCommand.createLeague)]
            public virtual Task<NullStruct> CreateLeagueAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)LeagueComponentCommand.joinLeague)]
            public virtual Task<NullStruct> JoinLeagueAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)LeagueComponentCommand.getLeague)]
            public virtual Task<NullStruct> GetLeagueAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)LeagueComponentCommand.getLeaguesByUser)]
            public virtual Task<NullStruct> GetLeaguesByUserAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)LeagueComponentCommand.deleteLeague)]
            public virtual Task<NullStruct> DeleteLeagueAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)LeagueComponentCommand.promoteToGM)]
            public virtual Task<NullStruct> PromoteToGMAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)LeagueComponentCommand.findLeagues)]
            public virtual Task<NullStruct> FindLeaguesAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)LeagueComponentCommand.findLeaguesAsync)]
            public virtual Task<NullStruct> FindLeaguesAsyncAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)LeagueComponentCommand.removeMember)]
            public virtual Task<NullStruct> RemoveMemberAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)LeagueComponentCommand.resetLeague)]
            public virtual Task<NullStruct> ResetLeagueAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)LeagueComponentCommand.updateLeagueSettings)]
            public virtual Task<NullStruct> UpdateLeagueSettingsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)LeagueComponentCommand.setMetadata)]
            public virtual Task<NullStruct> SetMetadataAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)LeagueComponentCommand.postNews)]
            public virtual Task<NullStruct> PostNewsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)LeagueComponentCommand.getNews)]
            public virtual Task<NullStruct> GetNewsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)LeagueComponentCommand.setRoster)]
            public virtual Task<NullStruct> SetRosterAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)LeagueComponentCommand.sendInvitation)]
            public virtual Task<NullStruct> SendInvitationAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)LeagueComponentCommand.getInvitations)]
            public virtual Task<NullStruct> GetInvitationsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)LeagueComponentCommand.processInvitation)]
            public virtual Task<NullStruct> ProcessInvitationAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)LeagueComponentCommand.proposeTrade)]
            public virtual Task<NullStruct> ProposeTradeAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)LeagueComponentCommand.processTrade)]
            public virtual Task<NullStruct> ProcessTradeAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)LeagueComponentCommand.getTrades)]
            public virtual Task<NullStruct> GetTradesAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)LeagueComponentCommand.getMembers)]
            public virtual Task<NullStruct> GetMembersAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)LeagueComponentCommand.submitStatistics)]
            public virtual Task<NullStruct> SubmitStatisticsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)LeagueComponentCommand.getRecentGames)]
            public virtual Task<NullStruct> GetRecentGamesAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)LeagueComponentCommand.submitScores)]
            public virtual Task<NullStruct> SubmitScoresAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)LeagueComponentCommand.getRoster)]
            public virtual Task<NullStruct> GetRosterAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)LeagueComponentCommand.runDraft)]
            public virtual Task<NullStruct> RunDraftAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)LeagueComponentCommand.getDraftProfile)]
            public virtual Task<NullStruct> GetDraftProfileAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)LeagueComponentCommand.setDraftProfile)]
            public virtual Task<NullStruct> SetDraftProfileAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)LeagueComponentCommand.getPlayoffSeries)]
            public virtual Task<NullStruct> GetPlayoffSeriesAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            
            public static Task NotifyFindLeaguesAsyncNotificationAsync(BlazeServerConnection connection, FindLeaguesAsyncNotification notification)
            {
                return connection.NotifyAsync(LeagueComponentBase.Id, (ushort)LeagueComponentNotification.FindLeaguesAsyncNotification, notification);
            }
            
            public override Type GetCommandRequestType(LeagueComponentCommand command) => LeagueComponentBase.GetCommandRequestType(command);
            public override Type GetCommandResponseType(LeagueComponentCommand command) => LeagueComponentBase.GetCommandResponseType(command);
            public override Type GetCommandErrorResponseType(LeagueComponentCommand command) => LeagueComponentBase.GetCommandErrorResponseType(command);
            public override Type GetNotificationType(LeagueComponentNotification notification) => LeagueComponentBase.GetNotificationType(notification);
            
        }
        
        public class Client : BlazeComponent<LeagueComponentCommand, LeagueComponentNotification, Blaze3RpcError>
        {
            public Client() : base(LeagueComponentBase.Id, LeagueComponentBase.Name)
            {
                
            }
            
            public override Type GetCommandRequestType(LeagueComponentCommand command) => LeagueComponentBase.GetCommandRequestType(command);
            public override Type GetCommandResponseType(LeagueComponentCommand command) => LeagueComponentBase.GetCommandResponseType(command);
            public override Type GetCommandErrorResponseType(LeagueComponentCommand command) => LeagueComponentBase.GetCommandErrorResponseType(command);
            public override Type GetNotificationType(LeagueComponentNotification notification) => LeagueComponentBase.GetNotificationType(notification);
            
        }
        
        public static Type GetCommandRequestType(LeagueComponentCommand command) => command switch
        {
            LeagueComponentCommand.createLeague => typeof(NullStruct),
            LeagueComponentCommand.joinLeague => typeof(NullStruct),
            LeagueComponentCommand.getLeague => typeof(NullStruct),
            LeagueComponentCommand.getLeaguesByUser => typeof(NullStruct),
            LeagueComponentCommand.deleteLeague => typeof(NullStruct),
            LeagueComponentCommand.promoteToGM => typeof(NullStruct),
            LeagueComponentCommand.findLeagues => typeof(NullStruct),
            LeagueComponentCommand.findLeaguesAsync => typeof(NullStruct),
            LeagueComponentCommand.removeMember => typeof(NullStruct),
            LeagueComponentCommand.resetLeague => typeof(NullStruct),
            LeagueComponentCommand.updateLeagueSettings => typeof(NullStruct),
            LeagueComponentCommand.setMetadata => typeof(NullStruct),
            LeagueComponentCommand.postNews => typeof(NullStruct),
            LeagueComponentCommand.getNews => typeof(NullStruct),
            LeagueComponentCommand.setRoster => typeof(NullStruct),
            LeagueComponentCommand.sendInvitation => typeof(NullStruct),
            LeagueComponentCommand.getInvitations => typeof(NullStruct),
            LeagueComponentCommand.processInvitation => typeof(NullStruct),
            LeagueComponentCommand.proposeTrade => typeof(NullStruct),
            LeagueComponentCommand.processTrade => typeof(NullStruct),
            LeagueComponentCommand.getTrades => typeof(NullStruct),
            LeagueComponentCommand.getMembers => typeof(NullStruct),
            LeagueComponentCommand.submitStatistics => typeof(NullStruct),
            LeagueComponentCommand.getRecentGames => typeof(NullStruct),
            LeagueComponentCommand.submitScores => typeof(NullStruct),
            LeagueComponentCommand.getRoster => typeof(NullStruct),
            LeagueComponentCommand.runDraft => typeof(NullStruct),
            LeagueComponentCommand.getDraftProfile => typeof(NullStruct),
            LeagueComponentCommand.setDraftProfile => typeof(NullStruct),
            LeagueComponentCommand.getPlayoffSeries => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandResponseType(LeagueComponentCommand command) => command switch
        {
            LeagueComponentCommand.createLeague => typeof(NullStruct),
            LeagueComponentCommand.joinLeague => typeof(NullStruct),
            LeagueComponentCommand.getLeague => typeof(NullStruct),
            LeagueComponentCommand.getLeaguesByUser => typeof(NullStruct),
            LeagueComponentCommand.deleteLeague => typeof(NullStruct),
            LeagueComponentCommand.promoteToGM => typeof(NullStruct),
            LeagueComponentCommand.findLeagues => typeof(NullStruct),
            LeagueComponentCommand.findLeaguesAsync => typeof(NullStruct),
            LeagueComponentCommand.removeMember => typeof(NullStruct),
            LeagueComponentCommand.resetLeague => typeof(NullStruct),
            LeagueComponentCommand.updateLeagueSettings => typeof(NullStruct),
            LeagueComponentCommand.setMetadata => typeof(NullStruct),
            LeagueComponentCommand.postNews => typeof(NullStruct),
            LeagueComponentCommand.getNews => typeof(NullStruct),
            LeagueComponentCommand.setRoster => typeof(NullStruct),
            LeagueComponentCommand.sendInvitation => typeof(NullStruct),
            LeagueComponentCommand.getInvitations => typeof(NullStruct),
            LeagueComponentCommand.processInvitation => typeof(NullStruct),
            LeagueComponentCommand.proposeTrade => typeof(NullStruct),
            LeagueComponentCommand.processTrade => typeof(NullStruct),
            LeagueComponentCommand.getTrades => typeof(NullStruct),
            LeagueComponentCommand.getMembers => typeof(NullStruct),
            LeagueComponentCommand.submitStatistics => typeof(NullStruct),
            LeagueComponentCommand.getRecentGames => typeof(NullStruct),
            LeagueComponentCommand.submitScores => typeof(NullStruct),
            LeagueComponentCommand.getRoster => typeof(NullStruct),
            LeagueComponentCommand.runDraft => typeof(NullStruct),
            LeagueComponentCommand.getDraftProfile => typeof(NullStruct),
            LeagueComponentCommand.setDraftProfile => typeof(NullStruct),
            LeagueComponentCommand.getPlayoffSeries => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandErrorResponseType(LeagueComponentCommand command) => command switch
        {
            LeagueComponentCommand.createLeague => typeof(NullStruct),
            LeagueComponentCommand.joinLeague => typeof(NullStruct),
            LeagueComponentCommand.getLeague => typeof(NullStruct),
            LeagueComponentCommand.getLeaguesByUser => typeof(NullStruct),
            LeagueComponentCommand.deleteLeague => typeof(NullStruct),
            LeagueComponentCommand.promoteToGM => typeof(NullStruct),
            LeagueComponentCommand.findLeagues => typeof(NullStruct),
            LeagueComponentCommand.findLeaguesAsync => typeof(NullStruct),
            LeagueComponentCommand.removeMember => typeof(NullStruct),
            LeagueComponentCommand.resetLeague => typeof(NullStruct),
            LeagueComponentCommand.updateLeagueSettings => typeof(NullStruct),
            LeagueComponentCommand.setMetadata => typeof(NullStruct),
            LeagueComponentCommand.postNews => typeof(NullStruct),
            LeagueComponentCommand.getNews => typeof(NullStruct),
            LeagueComponentCommand.setRoster => typeof(NullStruct),
            LeagueComponentCommand.sendInvitation => typeof(NullStruct),
            LeagueComponentCommand.getInvitations => typeof(NullStruct),
            LeagueComponentCommand.processInvitation => typeof(NullStruct),
            LeagueComponentCommand.proposeTrade => typeof(NullStruct),
            LeagueComponentCommand.processTrade => typeof(NullStruct),
            LeagueComponentCommand.getTrades => typeof(NullStruct),
            LeagueComponentCommand.getMembers => typeof(NullStruct),
            LeagueComponentCommand.submitStatistics => typeof(NullStruct),
            LeagueComponentCommand.getRecentGames => typeof(NullStruct),
            LeagueComponentCommand.submitScores => typeof(NullStruct),
            LeagueComponentCommand.getRoster => typeof(NullStruct),
            LeagueComponentCommand.runDraft => typeof(NullStruct),
            LeagueComponentCommand.getDraftProfile => typeof(NullStruct),
            LeagueComponentCommand.setDraftProfile => typeof(NullStruct),
            LeagueComponentCommand.getPlayoffSeries => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetNotificationType(LeagueComponentNotification notification) => notification switch
        {
            LeagueComponentNotification.FindLeaguesAsyncNotification => typeof(FindLeaguesAsyncNotification),
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
        
    }
}
