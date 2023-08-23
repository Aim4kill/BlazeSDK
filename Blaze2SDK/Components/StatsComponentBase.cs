using Blaze2SDK.Blaze.Stats;
using BlazeCommon;

namespace Blaze2SDK.Components
{
    public static class StatsComponentBase
    {
        public const ushort Id = 7;
        public const string Name = "StatsComponent";
        
        public class Server : BlazeComponent<StatsComponentCommand, StatsComponentNotification, Blaze2RpcError>
        {
            public Server() : base(StatsComponentBase.Id, StatsComponentBase.Name)
            {
                
            }
            
            [BlazeCommand((ushort)StatsComponentCommand.getStatDescs)]
            public virtual Task<NullStruct> GetStatDescsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)StatsComponentCommand.getStats)]
            public virtual Task<NullStruct> GetStatsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)StatsComponentCommand.getStatGroupList)]
            public virtual Task<StatGroupList> GetStatGroupListAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)StatsComponentCommand.getStatGroup)]
            public virtual Task<StatGroupResponse> GetStatGroupAsync(GetStatGroupRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)StatsComponentCommand.getStatsByGroup)]
            public virtual Task<NullStruct> GetStatsByGroupAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)StatsComponentCommand.getDateRange)]
            public virtual Task<NullStruct> GetDateRangeAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)StatsComponentCommand.getEntityCount)]
            public virtual Task<NullStruct> GetEntityCountAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)StatsComponentCommand.updateStats)]
            public virtual Task<NullStruct> UpdateStatsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)StatsComponentCommand.wipeStats)]
            public virtual Task<NullStruct> WipeStatsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)StatsComponentCommand.getLeaderboardGroup)]
            public virtual Task<LeaderboardGroupResponse> GetLeaderboardGroupAsync(LeaderboardGroupRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)StatsComponentCommand.getLeaderboardFolderGroup)]
            public virtual Task<LeaderboardFolderGroup> GetLeaderboardFolderGroupAsync(LeaderboardFolderGroupRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)StatsComponentCommand.getLeaderboard)]
            public virtual Task<LeaderboardStatValues> GetLeaderboardAsync(LeaderboardStatsRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)StatsComponentCommand.getCenteredLeaderboard)]
            public virtual Task<LeaderboardStatValues> GetCenteredLeaderboardAsync(CenteredLeaderboardStatsRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)StatsComponentCommand.getFilteredLeaderboard)]
            public virtual Task<LeaderboardStatValues> GetFilteredLeaderboardAsync(FilteredLeaderboardStatsRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)StatsComponentCommand.getKeyScopesMap)]
            public virtual Task<KeyScopes> GetKeyScopesMapAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)StatsComponentCommand.getStatsByGroupAsync)]
            public virtual Task<NullStruct> GetStatsByGroupAsyncAsync(GetStatsByGroupRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)StatsComponentCommand.getLeaderboardTreeAsync)]
            public virtual Task<NullStruct> GetLeaderboardTreeAsyncAsync(GetLeaderboardTreeRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)StatsComponentCommand.getLeaderboardEntityCount)]
            public virtual Task<EntityCount> GetLeaderboardEntityCountAsync(LeaderboardEntityCountRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
        }
        
        public class Client : BlazeComponent<StatsComponentCommand, StatsComponentNotification, Blaze2RpcError>
        {
            public Client() : base(StatsComponentBase.Id, StatsComponentBase.Name)
            {
                
            }
        }
        
        public enum StatsComponentCommand : ushort
        {
            getStatDescs = 1,
            getStats = 2,
            getStatGroupList = 3,
            getStatGroup = 4,
            getStatsByGroup = 5,
            getDateRange = 6,
            getEntityCount = 7,
            updateStats = 8,
            wipeStats = 9,
            getLeaderboardGroup = 10,
            getLeaderboardFolderGroup = 11,
            getLeaderboard = 12,
            getCenteredLeaderboard = 13,
            getFilteredLeaderboard = 14,
            getKeyScopesMap = 15,
            getStatsByGroupAsync = 16,
            getLeaderboardTreeAsync = 17,
            getLeaderboardEntityCount = 18,
        }
        
        public enum StatsComponentNotification : ushort
        {
            GetStatsAsyncNotification = 50,
            GetLeaderboardTreeNotification = 51,
        }
        
    }
}
