using Blaze.Core;
using Blaze2SDK.Blaze.Stats;
using EATDF;
using EATDF.Types;

namespace Blaze2SDK.Components;

public static class StatsComponentBase
{
    public const ushort Id = 7;
    public const string Name = "StatsComponent";
    
    public enum Error : ushort {
        STATS_ERR_CONFIG_NOTAVAILABLE = 1,
        STATS_ERR_INVALID_LEADERBOARD_ID = 2,
        STATS_ERR_INVALID_FOLDER_ID = 3,
        STATS_ERR_UNKNOWN_CATEGORY = 4,
        STATS_ERR_STAT_NOT_FOUND = 5,
        STATS_ERR_BAD_PERIOD_TYPE = 6,
        STATS_ERR_NO_DB_CONNECTION = 7,
        STATS_ERR_DB_DATA_NOT_AVAILABLE = 8,
        STATS_ERR_UNKNOWN_STAT_GROUP = 9,
        STATS_ERR_DB_TRANSACTION_ERROR = 10,
        STATS_ERR_INVALID_UPDATE_TYPE = 11,
        STATS_ERR_UNKNOWN_CONTEXT = 12,
        STATS_ERR_DB_QUERY_FAILED = 13,
        STATS_ERR_RANK_OUT_OF_RANGE = 14,
        STATS_ERR_BAD_PERIOD_OFFSET = 15,
        STATS_ERR_BAD_SCOPE_INFO = 16,
        STATS_ERR_INVALID_FOLDER_NAME = 17,
        STATS_ERR_OPERATION_IN_PROGRESS = 18,
        STATS_ERR_DATA_NOT_AVAILABLE = 19,
        STATS_ERR_INAVLID_OPERATION = 20,
        STATS_ERR_ASSOCIATION_LIST_NAME_NOT_FOUND = 21,
        STATS_ERR_BAD_PERIOD_COUNTER = 22,
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
    
    public class Server : BlazeComponent {
        public override ushort Id => StatsComponentBase.Id;
        public override string Name => StatsComponentBase.Name;
        
        public virtual bool IsCommandSupported(StatsComponentCommand command) => false;
        
        public class StatsException : BlazeRpcException
        {
            public StatsException(Error error) : base((ushort)error, null) { }
            public StatsException(ServerError error) : base(error.WithErrorPrefix(), null) { }
            public StatsException(Error error, Tdf? errorResponse) : base((ushort)error, errorResponse) { }
            public StatsException(ServerError error, Tdf? errorResponse) : base(error.WithErrorPrefix(), errorResponse) { }
            public StatsException(Error error, Tdf? errorResponse, string? message) : base((ushort)error, errorResponse, message) { }
            public StatsException(ServerError error, Tdf? errorResponse, string? message) : base(error.WithErrorPrefix(), errorResponse, message) { }
            public StatsException(Error error, Tdf? errorResponse, string? message, Exception? innerException) : base((ushort)error, errorResponse, message, innerException) { }
            public StatsException(ServerError error, Tdf? errorResponse, string? message, Exception? innerException) : base(error.WithErrorPrefix(), errorResponse, message, innerException) { }
        }
        
        public Server()
        {
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)StatsComponentCommand.getStatDescs,
                Name = "getStatDescs",
                IsSupported = IsCommandSupported(StatsComponentCommand.getStatDescs),
                Func = async (req, ctx) => await GetStatDescsAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)StatsComponentCommand.getStats,
                Name = "getStats",
                IsSupported = IsCommandSupported(StatsComponentCommand.getStats),
                Func = async (req, ctx) => await GetStatsAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, StatGroupList, EmptyMessage>()
            {
                Id = (ushort)StatsComponentCommand.getStatGroupList,
                Name = "getStatGroupList",
                IsSupported = IsCommandSupported(StatsComponentCommand.getStatGroupList),
                Func = async (req, ctx) => await GetStatGroupListAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<GetStatGroupRequest, StatGroupResponse, EmptyMessage>()
            {
                Id = (ushort)StatsComponentCommand.getStatGroup,
                Name = "getStatGroup",
                IsSupported = IsCommandSupported(StatsComponentCommand.getStatGroup),
                Func = async (req, ctx) => await GetStatGroupAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)StatsComponentCommand.getStatsByGroup,
                Name = "getStatsByGroup",
                IsSupported = IsCommandSupported(StatsComponentCommand.getStatsByGroup),
                Func = async (req, ctx) => await GetStatsByGroupAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)StatsComponentCommand.getDateRange,
                Name = "getDateRange",
                IsSupported = IsCommandSupported(StatsComponentCommand.getDateRange),
                Func = async (req, ctx) => await GetDateRangeAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)StatsComponentCommand.getEntityCount,
                Name = "getEntityCount",
                IsSupported = IsCommandSupported(StatsComponentCommand.getEntityCount),
                Func = async (req, ctx) => await GetEntityCountAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)StatsComponentCommand.updateStats,
                Name = "updateStats",
                IsSupported = IsCommandSupported(StatsComponentCommand.updateStats),
                Func = async (req, ctx) => await UpdateStatsAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)StatsComponentCommand.wipeStats,
                Name = "wipeStats",
                IsSupported = IsCommandSupported(StatsComponentCommand.wipeStats),
                Func = async (req, ctx) => await WipeStatsAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<LeaderboardGroupRequest, LeaderboardGroupResponse, EmptyMessage>()
            {
                Id = (ushort)StatsComponentCommand.getLeaderboardGroup,
                Name = "getLeaderboardGroup",
                IsSupported = IsCommandSupported(StatsComponentCommand.getLeaderboardGroup),
                Func = async (req, ctx) => await GetLeaderboardGroupAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<LeaderboardFolderGroupRequest, LeaderboardFolderGroup, EmptyMessage>()
            {
                Id = (ushort)StatsComponentCommand.getLeaderboardFolderGroup,
                Name = "getLeaderboardFolderGroup",
                IsSupported = IsCommandSupported(StatsComponentCommand.getLeaderboardFolderGroup),
                Func = async (req, ctx) => await GetLeaderboardFolderGroupAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<LeaderboardStatsRequest, LeaderboardStatValues, EmptyMessage>()
            {
                Id = (ushort)StatsComponentCommand.getLeaderboard,
                Name = "getLeaderboard",
                IsSupported = IsCommandSupported(StatsComponentCommand.getLeaderboard),
                Func = async (req, ctx) => await GetLeaderboardAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<CenteredLeaderboardStatsRequest, LeaderboardStatValues, EmptyMessage>()
            {
                Id = (ushort)StatsComponentCommand.getCenteredLeaderboard,
                Name = "getCenteredLeaderboard",
                IsSupported = IsCommandSupported(StatsComponentCommand.getCenteredLeaderboard),
                Func = async (req, ctx) => await GetCenteredLeaderboardAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<FilteredLeaderboardStatsRequest, LeaderboardStatValues, EmptyMessage>()
            {
                Id = (ushort)StatsComponentCommand.getFilteredLeaderboard,
                Name = "getFilteredLeaderboard",
                IsSupported = IsCommandSupported(StatsComponentCommand.getFilteredLeaderboard),
                Func = async (req, ctx) => await GetFilteredLeaderboardAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, KeyScopes, EmptyMessage>()
            {
                Id = (ushort)StatsComponentCommand.getKeyScopesMap,
                Name = "getKeyScopesMap",
                IsSupported = IsCommandSupported(StatsComponentCommand.getKeyScopesMap),
                Func = async (req, ctx) => await GetKeyScopesMapAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<GetStatsByGroupRequest, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)StatsComponentCommand.getStatsByGroupAsync,
                Name = "getStatsByGroupAsync",
                IsSupported = IsCommandSupported(StatsComponentCommand.getStatsByGroupAsync),
                Func = async (req, ctx) => await GetStatsByGroupAsyncAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<GetLeaderboardTreeRequest, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)StatsComponentCommand.getLeaderboardTreeAsync,
                Name = "getLeaderboardTreeAsync",
                IsSupported = IsCommandSupported(StatsComponentCommand.getLeaderboardTreeAsync),
                Func = async (req, ctx) => await GetLeaderboardTreeAsyncAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<LeaderboardEntityCountRequest, EntityCount, EmptyMessage>()
            {
                Id = (ushort)StatsComponentCommand.getLeaderboardEntityCount,
                Name = "getLeaderboardEntityCount",
                IsSupported = IsCommandSupported(StatsComponentCommand.getLeaderboardEntityCount),
                Func = async (req, ctx) => await GetLeaderboardEntityCountAsync(req, ctx).ConfigureAwait(false)
            });
            
        }
        
        public override string GetErrorName(ushort errorCode)
        {
            return ((Error)errorCode).ToString();
        }
        
        /// <summary>
        /// This method is called when server receives a <b>StatsComponent::getStatDescs</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetStatDescsAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new StatsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>StatsComponent::getStats</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetStatsAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new StatsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>StatsComponent::getStatGroupList</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="StatGroupList"/><br/>
        /// </summary>
        public virtual Task<StatGroupList> GetStatGroupListAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new StatsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>StatsComponent::getStatGroup</b> command.<br/>
        /// Request type: <see cref="GetStatGroupRequest"/><br/>
        /// Response type: <see cref="StatGroupResponse"/><br/>
        /// </summary>
        public virtual Task<StatGroupResponse> GetStatGroupAsync(GetStatGroupRequest request, BlazeRpcContext context)
        {
            throw new StatsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>StatsComponent::getStatsByGroup</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetStatsByGroupAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new StatsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>StatsComponent::getDateRange</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetDateRangeAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new StatsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>StatsComponent::getEntityCount</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetEntityCountAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new StatsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>StatsComponent::updateStats</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> UpdateStatsAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new StatsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>StatsComponent::wipeStats</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> WipeStatsAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new StatsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>StatsComponent::getLeaderboardGroup</b> command.<br/>
        /// Request type: <see cref="LeaderboardGroupRequest"/><br/>
        /// Response type: <see cref="LeaderboardGroupResponse"/><br/>
        /// </summary>
        public virtual Task<LeaderboardGroupResponse> GetLeaderboardGroupAsync(LeaderboardGroupRequest request, BlazeRpcContext context)
        {
            throw new StatsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>StatsComponent::getLeaderboardFolderGroup</b> command.<br/>
        /// Request type: <see cref="LeaderboardFolderGroupRequest"/><br/>
        /// Response type: <see cref="LeaderboardFolderGroup"/><br/>
        /// </summary>
        public virtual Task<LeaderboardFolderGroup> GetLeaderboardFolderGroupAsync(LeaderboardFolderGroupRequest request, BlazeRpcContext context)
        {
            throw new StatsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>StatsComponent::getLeaderboard</b> command.<br/>
        /// Request type: <see cref="LeaderboardStatsRequest"/><br/>
        /// Response type: <see cref="LeaderboardStatValues"/><br/>
        /// </summary>
        public virtual Task<LeaderboardStatValues> GetLeaderboardAsync(LeaderboardStatsRequest request, BlazeRpcContext context)
        {
            throw new StatsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>StatsComponent::getCenteredLeaderboard</b> command.<br/>
        /// Request type: <see cref="CenteredLeaderboardStatsRequest"/><br/>
        /// Response type: <see cref="LeaderboardStatValues"/><br/>
        /// </summary>
        public virtual Task<LeaderboardStatValues> GetCenteredLeaderboardAsync(CenteredLeaderboardStatsRequest request, BlazeRpcContext context)
        {
            throw new StatsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>StatsComponent::getFilteredLeaderboard</b> command.<br/>
        /// Request type: <see cref="FilteredLeaderboardStatsRequest"/><br/>
        /// Response type: <see cref="LeaderboardStatValues"/><br/>
        /// </summary>
        public virtual Task<LeaderboardStatValues> GetFilteredLeaderboardAsync(FilteredLeaderboardStatsRequest request, BlazeRpcContext context)
        {
            throw new StatsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>StatsComponent::getKeyScopesMap</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="KeyScopes"/><br/>
        /// </summary>
        public virtual Task<KeyScopes> GetKeyScopesMapAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new StatsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>StatsComponent::getStatsByGroupAsync</b> command.<br/>
        /// Request type: <see cref="GetStatsByGroupRequest"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetStatsByGroupAsyncAsync(GetStatsByGroupRequest request, BlazeRpcContext context)
        {
            throw new StatsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>StatsComponent::getLeaderboardTreeAsync</b> command.<br/>
        /// Request type: <see cref="GetLeaderboardTreeRequest"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetLeaderboardTreeAsyncAsync(GetLeaderboardTreeRequest request, BlazeRpcContext context)
        {
            throw new StatsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>StatsComponent::getLeaderboardEntityCount</b> command.<br/>
        /// Request type: <see cref="LeaderboardEntityCountRequest"/><br/>
        /// Response type: <see cref="EntityCount"/><br/>
        /// </summary>
        public virtual Task<EntityCount> GetLeaderboardEntityCountAsync(LeaderboardEntityCountRequest request, BlazeRpcContext context)
        {
            throw new StatsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>StatsComponent::GetStatsAsyncNotification</b> notification.<br/>
        /// Notification type: <see cref="KeyScopedStatValues"/><br/>
        /// </summary>
        public static Task NotifyGetStatsAsyncNotificationAsync(BlazeRpcConnection connection, KeyScopedStatValues notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = StatsComponentBase.Id;
                frame.Command = (ushort)StatsComponentNotification.GetStatsAsyncNotification;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>StatsComponent::GetLeaderboardTreeNotification</b> notification.<br/>
        /// Notification type: <see cref="LeaderboardTreeNode"/><br/>
        /// </summary>
        public static Task NotifyGetLeaderboardTreeNotificationAsync(BlazeRpcConnection connection, LeaderboardTreeNode notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = StatsComponentBase.Id;
                frame.Command = (ushort)StatsComponentNotification.GetLeaderboardTreeNotification;
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

