using Blaze.Core;
using EATDF;
using EATDF.Types;

namespace Blaze2SDK.Components;

public static class TournamentsComponentBase
{
    public const ushort Id = 23;
    public const string Name = "TournamentsComponent";
    
    public enum Error : ushort {
        TOURN_ERR_TOURNAMENT_GENERIC = 1,
        TOURN_ERR_TOURNAMENT_NOT_FOUND = 2,
        TOURN_ERR_ALREADY_IN_TOURNAMENT = 3,
        TOURN_ERR_USER_NOT_IN_TOURNAMENT = 4,
        TOURN_ERR_USER_NOT_FOUND = 5,
        TOURN_ERR_TOURNAMENT_DISABLED = 6,
        TOURN_ERR_TIES_NOT_SUPPORTED = 7,
    }
    
    public enum TournamentsComponentCommand : ushort
    {
        getTournaments = 1,
        getMemberCounts = 2,
        getTrophies = 4,
        getMyTournamentId = 5,
        joinTournament = 6,
        leaveTournament = 7,
        resetMyTournament = 8,
        getMyTournamentDetails = 9,
    }
    
    public enum TournamentsComponentNotification : ushort
    {
    }
    
    public class Server : BlazeComponent {
        public override ushort Id => TournamentsComponentBase.Id;
        public override string Name => TournamentsComponentBase.Name;
        
        public virtual bool IsCommandSupported(TournamentsComponentCommand command) => false;
        
        public class TournamentsException : BlazeRpcException
        {
            public TournamentsException(Error error) : base((ushort)error, null) { }
            public TournamentsException(ServerError error) : base(error.WithErrorPrefix(), null) { }
            public TournamentsException(Error error, Tdf? errorResponse) : base((ushort)error, errorResponse) { }
            public TournamentsException(ServerError error, Tdf? errorResponse) : base(error.WithErrorPrefix(), errorResponse) { }
            public TournamentsException(Error error, Tdf? errorResponse, string? message) : base((ushort)error, errorResponse, message) { }
            public TournamentsException(ServerError error, Tdf? errorResponse, string? message) : base(error.WithErrorPrefix(), errorResponse, message) { }
            public TournamentsException(Error error, Tdf? errorResponse, string? message, Exception? innerException) : base((ushort)error, errorResponse, message, innerException) { }
            public TournamentsException(ServerError error, Tdf? errorResponse, string? message, Exception? innerException) : base(error.WithErrorPrefix(), errorResponse, message, innerException) { }
        }
        
        public Server()
        {
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)TournamentsComponentCommand.getTournaments,
                Name = "getTournaments",
                IsSupported = IsCommandSupported(TournamentsComponentCommand.getTournaments),
                Func = async (req, ctx) => await GetTournamentsAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)TournamentsComponentCommand.getMemberCounts,
                Name = "getMemberCounts",
                IsSupported = IsCommandSupported(TournamentsComponentCommand.getMemberCounts),
                Func = async (req, ctx) => await GetMemberCountsAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)TournamentsComponentCommand.getTrophies,
                Name = "getTrophies",
                IsSupported = IsCommandSupported(TournamentsComponentCommand.getTrophies),
                Func = async (req, ctx) => await GetTrophiesAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)TournamentsComponentCommand.getMyTournamentId,
                Name = "getMyTournamentId",
                IsSupported = IsCommandSupported(TournamentsComponentCommand.getMyTournamentId),
                Func = async (req, ctx) => await GetMyTournamentIdAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)TournamentsComponentCommand.joinTournament,
                Name = "joinTournament",
                IsSupported = IsCommandSupported(TournamentsComponentCommand.joinTournament),
                Func = async (req, ctx) => await JoinTournamentAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)TournamentsComponentCommand.leaveTournament,
                Name = "leaveTournament",
                IsSupported = IsCommandSupported(TournamentsComponentCommand.leaveTournament),
                Func = async (req, ctx) => await LeaveTournamentAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)TournamentsComponentCommand.resetMyTournament,
                Name = "resetMyTournament",
                IsSupported = IsCommandSupported(TournamentsComponentCommand.resetMyTournament),
                Func = async (req, ctx) => await ResetMyTournamentAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)TournamentsComponentCommand.getMyTournamentDetails,
                Name = "getMyTournamentDetails",
                IsSupported = IsCommandSupported(TournamentsComponentCommand.getMyTournamentDetails),
                Func = async (req, ctx) => await GetMyTournamentDetailsAsync(req, ctx).ConfigureAwait(false)
            });
            
        }
        
        public override string GetErrorName(ushort errorCode)
        {
            return ((Error)errorCode).ToString();
        }
        
        /// <summary>
        /// This method is called when server receives a <b>TournamentsComponent::getTournaments</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetTournamentsAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new TournamentsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>TournamentsComponent::getMemberCounts</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetMemberCountsAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new TournamentsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>TournamentsComponent::getTrophies</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetTrophiesAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new TournamentsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>TournamentsComponent::getMyTournamentId</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetMyTournamentIdAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new TournamentsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>TournamentsComponent::joinTournament</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> JoinTournamentAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new TournamentsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>TournamentsComponent::leaveTournament</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> LeaveTournamentAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new TournamentsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>TournamentsComponent::resetMyTournament</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> ResetMyTournamentAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new TournamentsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>TournamentsComponent::getMyTournamentDetails</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetMyTournamentDetailsAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new TournamentsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
    }
    
}

