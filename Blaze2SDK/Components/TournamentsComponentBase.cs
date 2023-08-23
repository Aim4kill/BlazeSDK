using BlazeCommon;

namespace Blaze2SDK.Components
{
    public static class TournamentsComponentBase
    {
        public const ushort Id = 23;
        public const string Name = "TournamentsComponent";
        
        public class Server : BlazeComponent<TournamentsComponentCommand, TournamentsComponentNotification, Blaze2RpcError>
        {
            public Server() : base(TournamentsComponentBase.Id, TournamentsComponentBase.Name)
            {
                
            }
            
            [BlazeCommand((ushort)TournamentsComponentCommand.getTournaments)]
            public virtual Task<NullStruct> GetTournamentsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)TournamentsComponentCommand.getMemberCounts)]
            public virtual Task<NullStruct> GetMemberCountsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)TournamentsComponentCommand.getTrophies)]
            public virtual Task<NullStruct> GetTrophiesAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)TournamentsComponentCommand.getMyTournamentId)]
            public virtual Task<NullStruct> GetMyTournamentIdAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)TournamentsComponentCommand.joinTournament)]
            public virtual Task<NullStruct> JoinTournamentAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)TournamentsComponentCommand.leaveTournament)]
            public virtual Task<NullStruct> LeaveTournamentAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)TournamentsComponentCommand.resetMyTournament)]
            public virtual Task<NullStruct> ResetMyTournamentAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)TournamentsComponentCommand.getMyTournamentDetails)]
            public virtual Task<NullStruct> GetMyTournamentDetailsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
        }
        
        public class Client : BlazeComponent<TournamentsComponentCommand, TournamentsComponentNotification, Blaze2RpcError>
        {
            public Client() : base(TournamentsComponentBase.Id, TournamentsComponentBase.Name)
            {
                
            }
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
        
    }
}
