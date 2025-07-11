using Blaze.Core;
using Blaze2SDK.Blaze.League;
using EATDF;
using EATDF.Types;

namespace Blaze2SDK.Components;

public static class LeagueComponentBase
{
    public const ushort Id = 13;
    public const string Name = "LeagueComponent";
    
    public enum Error : ushort {
        LEAGUE_ERR_INVALID_LEAGUEID = 1,
        LEAGUE_ERR_INVALID_PLAYERID = 2,
        LEAGUE_ERR_INVALID_TRADEID = 3,
        LEAGUE_ERR_INVALID_ROSTERID = 4,
        LEAGUE_ERR_INVALID_GAMEID = 5,
        LEAGUE_ERR_INVALID_BLAZEID = 6,
        LEAGUE_ERR_INVALID_ARGUMENT = 7,
        LEAGUE_ERR_MAX_LEAGUES = 8,
        LEAGUE_ERR_INCORRECT_PASSWORD = 9,
        LEAGUE_ERR_LEAGUE_FULL = 10,
        LEAGUE_ERR_REQUESTER_NOT_AUTHORIZED = 11,
        LEAGUE_ERR_REQUESTER_NOT_A_MEMBER = 12,
        LEAGUE_ERR_USER_NOT_A_MEMBER = 13,
        LEAGUE_ERR_JOINS_DISABLED = 14,
        LEAGUE_ERR_INVALID_OP_FOR_LEAGUE_STATE = 15,
        LEAGUE_ERR_ALREADY_A_GM = 16,
        LEAGUE_ERR_ALREADY_A_MEMBER = 17,
        LEAGUE_ERR_LEAGUE_NAME_IN_USE = 18,
        LEAGUE_ERR_PROFANITY_FILTER = 19,
        LEAGUE_ERR_LAST_GM = 20,
        LEAGUE_ERR_INVALID_TRADE_PROPOSAL = 21,
        LEAGUE_ERR_TRADES_DISABLED = 22,
        LEAGUE_ERR_REP_TOO_LOW = 23,
        LEAGUE_ERR_DNF_TOO_HIGH = 24,
        LEAGUE_ERR_DATABASE_ERROR = 25,
        LEAGUE_ERR_REQUESTER_NOT_A_GM = 26,
        LEAGUE_ERR_LEAGUE_NOT_EMPTY = 27,
        LEAGUE_ERR_REQUESTER_IS_BANNED = 28,
        LEAGUE_ERR_INVALID_INVITATION = 29,
        LEAGUE_ERR_SERVER_ERROR = 30,
        LEAGUE_ERR_NOT_ENOUGH_MEMBERS_TO_RUN_DRAFT = 31,
        LEAGUE_ERR_DRAFT_DISABLED = 32,
        LEAGUE_ERR_LEAGUES_SERVER_UNAVAILABLE = 33,
        LEAGUE_ERR_TEAM_IN_USE = 34,
        LEAGUE_ERR_ROSTER_CRC_MISMATCH = 35,
        LEAGUE_ERR_INVALID_INVITEE = 36,
        LEAGUE_ERR_INVITEE_IS_BANNED = 37,
        LEAGUE_ERR_REQUESTER_IS_TEMP_BANNED = 38,
    }
    
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
    
    public class Server : BlazeComponent {
        public override ushort Id => LeagueComponentBase.Id;
        public override string Name => LeagueComponentBase.Name;
        
        public virtual bool IsCommandSupported(LeagueComponentCommand command) => false;
        
        public class LeagueException : BlazeRpcException
        {
            public LeagueException(Error error) : base((ushort)error, null) { }
            public LeagueException(ServerError error) : base(error.WithErrorPrefix(), null) { }
            public LeagueException(Error error, Tdf? errorResponse) : base((ushort)error, errorResponse) { }
            public LeagueException(ServerError error, Tdf? errorResponse) : base(error.WithErrorPrefix(), errorResponse) { }
            public LeagueException(Error error, Tdf? errorResponse, string? message) : base((ushort)error, errorResponse, message) { }
            public LeagueException(ServerError error, Tdf? errorResponse, string? message) : base(error.WithErrorPrefix(), errorResponse, message) { }
            public LeagueException(Error error, Tdf? errorResponse, string? message, Exception? innerException) : base((ushort)error, errorResponse, message, innerException) { }
            public LeagueException(ServerError error, Tdf? errorResponse, string? message, Exception? innerException) : base(error.WithErrorPrefix(), errorResponse, message, innerException) { }
        }
        
        public Server()
        {
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)LeagueComponentCommand.createLeague,
                Name = "createLeague",
                IsSupported = IsCommandSupported(LeagueComponentCommand.createLeague),
                Func = async (req, ctx) => await CreateLeagueAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)LeagueComponentCommand.joinLeague,
                Name = "joinLeague",
                IsSupported = IsCommandSupported(LeagueComponentCommand.joinLeague),
                Func = async (req, ctx) => await JoinLeagueAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)LeagueComponentCommand.getLeague,
                Name = "getLeague",
                IsSupported = IsCommandSupported(LeagueComponentCommand.getLeague),
                Func = async (req, ctx) => await GetLeagueAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)LeagueComponentCommand.getLeaguesByUser,
                Name = "getLeaguesByUser",
                IsSupported = IsCommandSupported(LeagueComponentCommand.getLeaguesByUser),
                Func = async (req, ctx) => await GetLeaguesByUserAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)LeagueComponentCommand.deleteLeague,
                Name = "deleteLeague",
                IsSupported = IsCommandSupported(LeagueComponentCommand.deleteLeague),
                Func = async (req, ctx) => await DeleteLeagueAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)LeagueComponentCommand.promoteToGM,
                Name = "promoteToGM",
                IsSupported = IsCommandSupported(LeagueComponentCommand.promoteToGM),
                Func = async (req, ctx) => await PromoteToGMAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)LeagueComponentCommand.findLeagues,
                Name = "findLeagues",
                IsSupported = IsCommandSupported(LeagueComponentCommand.findLeagues),
                Func = async (req, ctx) => await FindLeaguesAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)LeagueComponentCommand.findLeaguesAsync,
                Name = "findLeaguesAsync",
                IsSupported = IsCommandSupported(LeagueComponentCommand.findLeaguesAsync),
                Func = async (req, ctx) => await FindLeaguesAsyncAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)LeagueComponentCommand.removeMember,
                Name = "removeMember",
                IsSupported = IsCommandSupported(LeagueComponentCommand.removeMember),
                Func = async (req, ctx) => await RemoveMemberAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)LeagueComponentCommand.resetLeague,
                Name = "resetLeague",
                IsSupported = IsCommandSupported(LeagueComponentCommand.resetLeague),
                Func = async (req, ctx) => await ResetLeagueAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)LeagueComponentCommand.updateLeagueSettings,
                Name = "updateLeagueSettings",
                IsSupported = IsCommandSupported(LeagueComponentCommand.updateLeagueSettings),
                Func = async (req, ctx) => await UpdateLeagueSettingsAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)LeagueComponentCommand.setMetadata,
                Name = "setMetadata",
                IsSupported = IsCommandSupported(LeagueComponentCommand.setMetadata),
                Func = async (req, ctx) => await SetMetadataAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)LeagueComponentCommand.postNews,
                Name = "postNews",
                IsSupported = IsCommandSupported(LeagueComponentCommand.postNews),
                Func = async (req, ctx) => await PostNewsAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)LeagueComponentCommand.getNews,
                Name = "getNews",
                IsSupported = IsCommandSupported(LeagueComponentCommand.getNews),
                Func = async (req, ctx) => await GetNewsAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)LeagueComponentCommand.setRoster,
                Name = "setRoster",
                IsSupported = IsCommandSupported(LeagueComponentCommand.setRoster),
                Func = async (req, ctx) => await SetRosterAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)LeagueComponentCommand.sendInvitation,
                Name = "sendInvitation",
                IsSupported = IsCommandSupported(LeagueComponentCommand.sendInvitation),
                Func = async (req, ctx) => await SendInvitationAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)LeagueComponentCommand.getInvitations,
                Name = "getInvitations",
                IsSupported = IsCommandSupported(LeagueComponentCommand.getInvitations),
                Func = async (req, ctx) => await GetInvitationsAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)LeagueComponentCommand.processInvitation,
                Name = "processInvitation",
                IsSupported = IsCommandSupported(LeagueComponentCommand.processInvitation),
                Func = async (req, ctx) => await ProcessInvitationAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)LeagueComponentCommand.proposeTrade,
                Name = "proposeTrade",
                IsSupported = IsCommandSupported(LeagueComponentCommand.proposeTrade),
                Func = async (req, ctx) => await ProposeTradeAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)LeagueComponentCommand.processTrade,
                Name = "processTrade",
                IsSupported = IsCommandSupported(LeagueComponentCommand.processTrade),
                Func = async (req, ctx) => await ProcessTradeAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)LeagueComponentCommand.getTrades,
                Name = "getTrades",
                IsSupported = IsCommandSupported(LeagueComponentCommand.getTrades),
                Func = async (req, ctx) => await GetTradesAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)LeagueComponentCommand.getMembers,
                Name = "getMembers",
                IsSupported = IsCommandSupported(LeagueComponentCommand.getMembers),
                Func = async (req, ctx) => await GetMembersAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)LeagueComponentCommand.submitStatistics,
                Name = "submitStatistics",
                IsSupported = IsCommandSupported(LeagueComponentCommand.submitStatistics),
                Func = async (req, ctx) => await SubmitStatisticsAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)LeagueComponentCommand.getRecentGames,
                Name = "getRecentGames",
                IsSupported = IsCommandSupported(LeagueComponentCommand.getRecentGames),
                Func = async (req, ctx) => await GetRecentGamesAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)LeagueComponentCommand.submitScores,
                Name = "submitScores",
                IsSupported = IsCommandSupported(LeagueComponentCommand.submitScores),
                Func = async (req, ctx) => await SubmitScoresAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)LeagueComponentCommand.getRoster,
                Name = "getRoster",
                IsSupported = IsCommandSupported(LeagueComponentCommand.getRoster),
                Func = async (req, ctx) => await GetRosterAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)LeagueComponentCommand.runDraft,
                Name = "runDraft",
                IsSupported = IsCommandSupported(LeagueComponentCommand.runDraft),
                Func = async (req, ctx) => await RunDraftAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)LeagueComponentCommand.getDraftProfile,
                Name = "getDraftProfile",
                IsSupported = IsCommandSupported(LeagueComponentCommand.getDraftProfile),
                Func = async (req, ctx) => await GetDraftProfileAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)LeagueComponentCommand.setDraftProfile,
                Name = "setDraftProfile",
                IsSupported = IsCommandSupported(LeagueComponentCommand.setDraftProfile),
                Func = async (req, ctx) => await SetDraftProfileAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)LeagueComponentCommand.getPlayoffSeries,
                Name = "getPlayoffSeries",
                IsSupported = IsCommandSupported(LeagueComponentCommand.getPlayoffSeries),
                Func = async (req, ctx) => await GetPlayoffSeriesAsync(req, ctx).ConfigureAwait(false)
            });
            
        }
        
        public override string GetErrorName(ushort errorCode)
        {
            return ((Error)errorCode).ToString();
        }
        
        /// <summary>
        /// This method is called when server receives a <b>LeagueComponent::createLeague</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> CreateLeagueAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new LeagueException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>LeagueComponent::joinLeague</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> JoinLeagueAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new LeagueException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>LeagueComponent::getLeague</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetLeagueAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new LeagueException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>LeagueComponent::getLeaguesByUser</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetLeaguesByUserAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new LeagueException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>LeagueComponent::deleteLeague</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> DeleteLeagueAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new LeagueException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>LeagueComponent::promoteToGM</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> PromoteToGMAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new LeagueException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>LeagueComponent::findLeagues</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> FindLeaguesAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new LeagueException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>LeagueComponent::findLeaguesAsync</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> FindLeaguesAsyncAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new LeagueException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>LeagueComponent::removeMember</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> RemoveMemberAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new LeagueException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>LeagueComponent::resetLeague</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> ResetLeagueAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new LeagueException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>LeagueComponent::updateLeagueSettings</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> UpdateLeagueSettingsAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new LeagueException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>LeagueComponent::setMetadata</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SetMetadataAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new LeagueException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>LeagueComponent::postNews</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> PostNewsAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new LeagueException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>LeagueComponent::getNews</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetNewsAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new LeagueException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>LeagueComponent::setRoster</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SetRosterAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new LeagueException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>LeagueComponent::sendInvitation</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SendInvitationAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new LeagueException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>LeagueComponent::getInvitations</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetInvitationsAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new LeagueException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>LeagueComponent::processInvitation</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> ProcessInvitationAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new LeagueException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>LeagueComponent::proposeTrade</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> ProposeTradeAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new LeagueException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>LeagueComponent::processTrade</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> ProcessTradeAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new LeagueException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>LeagueComponent::getTrades</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetTradesAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new LeagueException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>LeagueComponent::getMembers</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetMembersAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new LeagueException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>LeagueComponent::submitStatistics</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SubmitStatisticsAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new LeagueException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>LeagueComponent::getRecentGames</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetRecentGamesAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new LeagueException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>LeagueComponent::submitScores</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SubmitScoresAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new LeagueException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>LeagueComponent::getRoster</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetRosterAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new LeagueException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>LeagueComponent::runDraft</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> RunDraftAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new LeagueException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>LeagueComponent::getDraftProfile</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetDraftProfileAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new LeagueException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>LeagueComponent::setDraftProfile</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SetDraftProfileAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new LeagueException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>LeagueComponent::getPlayoffSeries</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetPlayoffSeriesAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new LeagueException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>LeagueComponent::FindLeaguesAsyncNotification</b> notification.<br/>
        /// Notification type: <see cref="FindLeaguesAsyncNotification"/><br/>
        /// </summary>
        public static Task NotifyFindLeaguesAsyncNotificationAsync(BlazeRpcConnection connection, FindLeaguesAsyncNotification notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = LeagueComponentBase.Id;
                frame.Command = (ushort)LeagueComponentNotification.FindLeaguesAsyncNotification;
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

