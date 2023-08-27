using Blaze2SDK.Blaze;
using Blaze2SDK.Blaze.GameManager;
using BlazeCommon;

namespace Blaze2SDK.Components
{
    public static class GameManagerBase
    {
        public const ushort Id = 4;
        public const string Name = "GameManager";
        
        public class Server : BlazeComponent<GameManagerCommand, GameManagerNotification, Blaze2RpcError>
        {
            public Server() : base(GameManagerBase.Id, GameManagerBase.Name)
            {
                
            }
            
            [BlazeCommand((ushort)GameManagerCommand.createGame)]
            public virtual Task<NullStruct> CreateGameAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.destroyGame)]
            public virtual Task<NullStruct> DestroyGameAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.advanceGameState)]
            public virtual Task<NullStruct> AdvanceGameStateAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.setGameSettings)]
            public virtual Task<NullStruct> SetGameSettingsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.setPlayerCapacity)]
            public virtual Task<NullStruct> SetPlayerCapacityAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.setGameAttributes)]
            public virtual Task<NullStruct> SetGameAttributesAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.setPlayerAttributes)]
            public virtual Task<NullStruct> SetPlayerAttributesAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.joinGame)]
            public virtual Task<JoinGameResponse> JoinGameAsync(JoinGameRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.updatePlayerConnection)]
            public virtual Task<NullStruct> UpdatePlayerConnectionAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.removePlayer)]
            public virtual Task<NullStruct> RemovePlayerAsync(RemovePlayerRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.startMatchmaking)]
            public virtual Task<StartMatchmakingResponse> StartMatchmakingAsync(StartMatchmakingRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.cancelMatchmaking)]
            public virtual Task<NullStruct> CancelMatchmakingAsync(CancelMatchmakingRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.finalizeGameCreation)]
            public virtual Task<NullStruct> FinalizeGameCreationAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.updateHostConnection)]
            public virtual Task<NullStruct> UpdateHostConnectionAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.listGames)]
            public virtual Task<NullStruct> ListGamesAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.setPlayerCustomData)]
            public virtual Task<NullStruct> SetPlayerCustomDataAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.replayGame)]
            public virtual Task<NullStruct> ReplayGameAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.returnDedicatedServerToPool)]
            public virtual Task<NullStruct> ReturnDedicatedServerToPoolAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.joinGameByGroup)]
            public virtual Task<NullStruct> JoinGameByGroupAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.leaveGameByGroup)]
            public virtual Task<NullStruct> LeaveGameByGroupAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.migrateGame)]
            public virtual Task<NullStruct> MigrateGameAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.resetDedicatedServer)]
            public virtual Task<NullStruct> ResetDedicatedServerAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.updateGameSession)]
            public virtual Task<NullStruct> UpdateGameSessionAsync(UpdateGameSessionRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.banPlayer)]
            public virtual Task<NullStruct> BanPlayerAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.matchmakingDedicatedServerOverride)]
            public virtual Task<NullStruct> MatchmakingDedicatedServerOverrideAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.updateMeshConnection)]
            public virtual Task<NullStruct> UpdateMeshConnectionAsync(UpdateMeshConnectionRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.joinGameByUserList)]
            public virtual Task<NullStruct> JoinGameByUserListAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.getGameListSnapshot)]
            public virtual Task<GetGameListResponse> GetGameListSnapshotAsync(GetGameListRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.getGameListSubscription)]
            public virtual Task<GetGameListResponse> GetGameListSubscriptionAsync(GetGameListRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.destroyGameList)]
            public virtual Task<NullStruct> DestroyGameListAsync(DestroyGameListRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.getFullGameData)]
            public virtual Task<GetFullGameDataResponse> GetFullGameDataAsync(GetFullGameDataRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.getMatchmakingConfig)]
            public virtual Task<NullStruct> GetMatchmakingConfigAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.getGameDataFromId)]
            public virtual Task<GameBrowserDataList> GetGameDataFromIdAsync(GetGameDataFromIdRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.addAdminPlayer)]
            public virtual Task<NullStruct> AddAdminPlayerAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.removeAdminPlayer)]
            public virtual Task<NullStruct> RemoveAdminPlayerAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.setPlayerTeam)]
            public virtual Task<NullStruct> SetPlayerTeamAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.changeGameTeamId)]
            public virtual Task<NullStruct> ChangeGameTeamIdAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.migrateAdminPlayer)]
            public virtual Task<NullStruct> MigrateAdminPlayerAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.registerDynamicDedicatedServerCreator)]
            public virtual Task<NullStruct> RegisterDynamicDedicatedServerCreatorAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.unregisterDynamicDedicatedServerCreator)]
            public virtual Task<NullStruct> UnregisterDynamicDedicatedServerCreatorAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            
            public static Task NotifyMatchmakingFinishedAsync(BlazeServerConnection connection, NotifyMatchmakingFinished notification)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyMatchmakingFinished, notification);
            }
            
            public static Task NotifyMatchmakingAsyncStatusAsync(BlazeServerConnection connection, NotifyMatchmakingAsyncStatus notification)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyMatchmakingAsyncStatus, notification);
            }
            
            public static Task NotifyGameCreatedAsync(BlazeServerConnection connection, NotifyGameCreated notification)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyGameCreated, notification);
            }
            
            public static Task NotifyGameRemovedAsync(BlazeServerConnection connection, NotifyGameRemoved notification)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyGameRemoved, notification);
            }
            
            public static Task NotifyJoinGameAsync(BlazeServerConnection connection, NotifyJoinGame notification)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyJoinGame, notification);
            }
            
            public static Task NotifyPlayerJoiningAsync(BlazeServerConnection connection, NotifyPlayerJoining notification)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyPlayerJoining, notification);
            }
            
            public static Task NotifyPlayerJoinCompletedAsync(BlazeServerConnection connection, NotifyPlayerJoinCompleted notification)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyPlayerJoinCompleted, notification);
            }
            
            public static Task NotifyGroupPreJoinedGameAsync(BlazeServerConnection connection, NotifyGroupPreJoinedGame notification)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyGroupPreJoinedGame, notification);
            }
            
            public static Task NotifyPlayerRemovedAsync(BlazeServerConnection connection, NotifyPlayerRemoved notification)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyPlayerRemoved, notification);
            }
            
            public static Task NotifyQueueChangedAsync(BlazeServerConnection connection, NotifyQueueChanged notification)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyQueueChanged, notification);
            }
            
            public static Task NotifyHostMigrationFinishedAsync(BlazeServerConnection connection, NotifyHostMigrationFinished notification)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyHostMigrationFinished, notification);
            }
            
            public static Task NotifyHostMigrationStartAsync(BlazeServerConnection connection, NotifyHostMigrationStart notification)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyHostMigrationStart, notification);
            }
            
            public static Task NotifyPlatformHostInitializedAsync(BlazeServerConnection connection, NotifyPlatformHostInitialized notification)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyPlatformHostInitialized, notification);
            }
            
            public static Task NotifyGameAttribChangeAsync(BlazeServerConnection connection, NotifyGameAttribChange notification)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyGameAttribChange, notification);
            }
            
            public static Task NotifyPlayerAttribChangeAsync(BlazeServerConnection connection, NotifyPlayerAttribChange notification)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyPlayerAttribChange, notification);
            }
            
            public static Task NotifyPlayerCustomDataChangeAsync(BlazeServerConnection connection, NotifyPlayerCustomDataChange notification)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyPlayerCustomDataChange, notification);
            }
            
            public static Task NotifyGameStateChangeAsync(BlazeServerConnection connection, NotifyGameStateChange notification)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyGameStateChange, notification);
            }
            
            public static Task NotifyGameSettingsChangeAsync(BlazeServerConnection connection, NotifyGameSettingsChange notification)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyGameSettingsChange, notification);
            }
            
            public static Task NotifyGameCapacityChangeAsync(BlazeServerConnection connection, NotifyGameCapacityChange notification)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyGameCapacityChange, notification);
            }
            
            public static Task NotifyGameResetAsync(BlazeServerConnection connection, NotifyGameReset notification)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyGameReset, notification);
            }
            
            public static Task NotifyGameReportingIdChangeAsync(BlazeServerConnection connection, NotifyGameReportingIdChange notification)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyGameReportingIdChange, notification);
            }
            
            public static Task NotifyGameSessionUpdatedAsync(BlazeServerConnection connection, GameSessionUpdatedNotification notification)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyGameSessionUpdated, notification);
            }
            
            public static Task NotifyGamePlayerStateChangeAsync(BlazeServerConnection connection, NotifyGamePlayerStateChange notification)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyGamePlayerStateChange, notification);
            }
            
            public static Task NotifyGamePlayerTeamChangeAsync(BlazeServerConnection connection, NotifyGamePlayerTeamChange notification)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyGamePlayerTeamChange, notification);
            }
            
            public static Task NotifyGameTeamIdChangeAsync(BlazeServerConnection connection, NotifyGameTeamIdChange notification)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyGameTeamIdChange, notification);
            }
            
            public static Task NotifyGameListUpdateAsync(BlazeServerConnection connection, NotifyGameListUpdate notification)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyGameListUpdate, notification);
            }
            
            public static Task NotifyAdminListChangeAsync(BlazeServerConnection connection, NotifyAdminListChange notification)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyAdminListChange, notification);
            }
            
            public static Task NotifyCreateDynamicDedicatedServerGameAsync(BlazeServerConnection connection, NotifyCreateDynamicDedicatedServerGame notification)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyCreateDynamicDedicatedServerGame, notification);
            }
            
            public override Type GetCommandRequestType(GameManagerCommand command) => GameManagerBase.GetCommandRequestType(command);
            public override Type GetCommandResponseType(GameManagerCommand command) => GameManagerBase.GetCommandResponseType(command);
            public override Type GetCommandErrorResponseType(GameManagerCommand command) => GameManagerBase.GetCommandErrorResponseType(command);
            public override Type GetNotificationType(GameManagerNotification notification) => GameManagerBase.GetNotificationType(notification);
            
        }
        
        public class Client : BlazeComponent<GameManagerCommand, GameManagerNotification, Blaze2RpcError>
        {
            public Client() : base(GameManagerBase.Id, GameManagerBase.Name)
            {
                
            }
            
            public override Type GetCommandRequestType(GameManagerCommand command) => GameManagerBase.GetCommandRequestType(command);
            public override Type GetCommandResponseType(GameManagerCommand command) => GameManagerBase.GetCommandResponseType(command);
            public override Type GetCommandErrorResponseType(GameManagerCommand command) => GameManagerBase.GetCommandErrorResponseType(command);
            public override Type GetNotificationType(GameManagerNotification notification) => GameManagerBase.GetNotificationType(notification);
            
        }
        
        public static Type GetCommandRequestType(GameManagerCommand command) => command switch
        {
            GameManagerCommand.createGame => typeof(NullStruct),
            GameManagerCommand.destroyGame => typeof(NullStruct),
            GameManagerCommand.advanceGameState => typeof(NullStruct),
            GameManagerCommand.setGameSettings => typeof(NullStruct),
            GameManagerCommand.setPlayerCapacity => typeof(NullStruct),
            GameManagerCommand.setGameAttributes => typeof(NullStruct),
            GameManagerCommand.setPlayerAttributes => typeof(NullStruct),
            GameManagerCommand.joinGame => typeof(JoinGameRequest),
            GameManagerCommand.updatePlayerConnection => typeof(NullStruct),
            GameManagerCommand.removePlayer => typeof(RemovePlayerRequest),
            GameManagerCommand.startMatchmaking => typeof(StartMatchmakingRequest),
            GameManagerCommand.cancelMatchmaking => typeof(CancelMatchmakingRequest),
            GameManagerCommand.finalizeGameCreation => typeof(NullStruct),
            GameManagerCommand.updateHostConnection => typeof(NullStruct),
            GameManagerCommand.listGames => typeof(NullStruct),
            GameManagerCommand.setPlayerCustomData => typeof(NullStruct),
            GameManagerCommand.replayGame => typeof(NullStruct),
            GameManagerCommand.returnDedicatedServerToPool => typeof(NullStruct),
            GameManagerCommand.joinGameByGroup => typeof(NullStruct),
            GameManagerCommand.leaveGameByGroup => typeof(NullStruct),
            GameManagerCommand.migrateGame => typeof(NullStruct),
            GameManagerCommand.resetDedicatedServer => typeof(NullStruct),
            GameManagerCommand.updateGameSession => typeof(UpdateGameSessionRequest),
            GameManagerCommand.banPlayer => typeof(NullStruct),
            GameManagerCommand.matchmakingDedicatedServerOverride => typeof(NullStruct),
            GameManagerCommand.updateMeshConnection => typeof(UpdateMeshConnectionRequest),
            GameManagerCommand.joinGameByUserList => typeof(NullStruct),
            GameManagerCommand.getGameListSnapshot => typeof(GetGameListRequest),
            GameManagerCommand.getGameListSubscription => typeof(GetGameListRequest),
            GameManagerCommand.destroyGameList => typeof(DestroyGameListRequest),
            GameManagerCommand.getFullGameData => typeof(GetFullGameDataRequest),
            GameManagerCommand.getMatchmakingConfig => typeof(NullStruct),
            GameManagerCommand.getGameDataFromId => typeof(GetGameDataFromIdRequest),
            GameManagerCommand.addAdminPlayer => typeof(NullStruct),
            GameManagerCommand.removeAdminPlayer => typeof(NullStruct),
            GameManagerCommand.setPlayerTeam => typeof(NullStruct),
            GameManagerCommand.changeGameTeamId => typeof(NullStruct),
            GameManagerCommand.migrateAdminPlayer => typeof(NullStruct),
            GameManagerCommand.registerDynamicDedicatedServerCreator => typeof(NullStruct),
            GameManagerCommand.unregisterDynamicDedicatedServerCreator => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandResponseType(GameManagerCommand command) => command switch
        {
            GameManagerCommand.createGame => typeof(NullStruct),
            GameManagerCommand.destroyGame => typeof(NullStruct),
            GameManagerCommand.advanceGameState => typeof(NullStruct),
            GameManagerCommand.setGameSettings => typeof(NullStruct),
            GameManagerCommand.setPlayerCapacity => typeof(NullStruct),
            GameManagerCommand.setGameAttributes => typeof(NullStruct),
            GameManagerCommand.setPlayerAttributes => typeof(NullStruct),
            GameManagerCommand.joinGame => typeof(JoinGameResponse),
            GameManagerCommand.updatePlayerConnection => typeof(NullStruct),
            GameManagerCommand.removePlayer => typeof(NullStruct),
            GameManagerCommand.startMatchmaking => typeof(StartMatchmakingResponse),
            GameManagerCommand.cancelMatchmaking => typeof(NullStruct),
            GameManagerCommand.finalizeGameCreation => typeof(NullStruct),
            GameManagerCommand.updateHostConnection => typeof(NullStruct),
            GameManagerCommand.listGames => typeof(NullStruct),
            GameManagerCommand.setPlayerCustomData => typeof(NullStruct),
            GameManagerCommand.replayGame => typeof(NullStruct),
            GameManagerCommand.returnDedicatedServerToPool => typeof(NullStruct),
            GameManagerCommand.joinGameByGroup => typeof(NullStruct),
            GameManagerCommand.leaveGameByGroup => typeof(NullStruct),
            GameManagerCommand.migrateGame => typeof(NullStruct),
            GameManagerCommand.resetDedicatedServer => typeof(NullStruct),
            GameManagerCommand.updateGameSession => typeof(NullStruct),
            GameManagerCommand.banPlayer => typeof(NullStruct),
            GameManagerCommand.matchmakingDedicatedServerOverride => typeof(NullStruct),
            GameManagerCommand.updateMeshConnection => typeof(NullStruct),
            GameManagerCommand.joinGameByUserList => typeof(NullStruct),
            GameManagerCommand.getGameListSnapshot => typeof(GetGameListResponse),
            GameManagerCommand.getGameListSubscription => typeof(GetGameListResponse),
            GameManagerCommand.destroyGameList => typeof(NullStruct),
            GameManagerCommand.getFullGameData => typeof(GetFullGameDataResponse),
            GameManagerCommand.getMatchmakingConfig => typeof(NullStruct),
            GameManagerCommand.getGameDataFromId => typeof(GameBrowserDataList),
            GameManagerCommand.addAdminPlayer => typeof(NullStruct),
            GameManagerCommand.removeAdminPlayer => typeof(NullStruct),
            GameManagerCommand.setPlayerTeam => typeof(NullStruct),
            GameManagerCommand.changeGameTeamId => typeof(NullStruct),
            GameManagerCommand.migrateAdminPlayer => typeof(NullStruct),
            GameManagerCommand.registerDynamicDedicatedServerCreator => typeof(NullStruct),
            GameManagerCommand.unregisterDynamicDedicatedServerCreator => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandErrorResponseType(GameManagerCommand command) => command switch
        {
            GameManagerCommand.createGame => typeof(NullStruct),
            GameManagerCommand.destroyGame => typeof(NullStruct),
            GameManagerCommand.advanceGameState => typeof(NullStruct),
            GameManagerCommand.setGameSettings => typeof(NullStruct),
            GameManagerCommand.setPlayerCapacity => typeof(NullStruct),
            GameManagerCommand.setGameAttributes => typeof(NullStruct),
            GameManagerCommand.setPlayerAttributes => typeof(NullStruct),
            GameManagerCommand.joinGame => typeof(EntryCriteriaError),
            GameManagerCommand.updatePlayerConnection => typeof(NullStruct),
            GameManagerCommand.removePlayer => typeof(NullStruct),
            GameManagerCommand.startMatchmaking => typeof(MatchmakingCriteriaError),
            GameManagerCommand.cancelMatchmaking => typeof(NullStruct),
            GameManagerCommand.finalizeGameCreation => typeof(NullStruct),
            GameManagerCommand.updateHostConnection => typeof(NullStruct),
            GameManagerCommand.listGames => typeof(NullStruct),
            GameManagerCommand.setPlayerCustomData => typeof(NullStruct),
            GameManagerCommand.replayGame => typeof(NullStruct),
            GameManagerCommand.returnDedicatedServerToPool => typeof(NullStruct),
            GameManagerCommand.joinGameByGroup => typeof(NullStruct),
            GameManagerCommand.leaveGameByGroup => typeof(NullStruct),
            GameManagerCommand.migrateGame => typeof(NullStruct),
            GameManagerCommand.resetDedicatedServer => typeof(NullStruct),
            GameManagerCommand.updateGameSession => typeof(NullStruct),
            GameManagerCommand.banPlayer => typeof(NullStruct),
            GameManagerCommand.matchmakingDedicatedServerOverride => typeof(NullStruct),
            GameManagerCommand.updateMeshConnection => typeof(NullStruct),
            GameManagerCommand.joinGameByUserList => typeof(NullStruct),
            GameManagerCommand.getGameListSnapshot => typeof(MatchmakingCriteriaError),
            GameManagerCommand.getGameListSubscription => typeof(MatchmakingCriteriaError),
            GameManagerCommand.destroyGameList => typeof(NullStruct),
            GameManagerCommand.getFullGameData => typeof(NullStruct),
            GameManagerCommand.getMatchmakingConfig => typeof(NullStruct),
            GameManagerCommand.getGameDataFromId => typeof(NullStruct),
            GameManagerCommand.addAdminPlayer => typeof(NullStruct),
            GameManagerCommand.removeAdminPlayer => typeof(NullStruct),
            GameManagerCommand.setPlayerTeam => typeof(NullStruct),
            GameManagerCommand.changeGameTeamId => typeof(NullStruct),
            GameManagerCommand.migrateAdminPlayer => typeof(NullStruct),
            GameManagerCommand.registerDynamicDedicatedServerCreator => typeof(NullStruct),
            GameManagerCommand.unregisterDynamicDedicatedServerCreator => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetNotificationType(GameManagerNotification notification) => notification switch
        {
            GameManagerNotification.NotifyMatchmakingFinished => typeof(NotifyMatchmakingFinished),
            GameManagerNotification.NotifyMatchmakingAsyncStatus => typeof(NotifyMatchmakingAsyncStatus),
            GameManagerNotification.NotifyGameCreated => typeof(NotifyGameCreated),
            GameManagerNotification.NotifyGameRemoved => typeof(NotifyGameRemoved),
            GameManagerNotification.NotifyJoinGame => typeof(NotifyJoinGame),
            GameManagerNotification.NotifyPlayerJoining => typeof(NotifyPlayerJoining),
            GameManagerNotification.NotifyPlayerJoinCompleted => typeof(NotifyPlayerJoinCompleted),
            GameManagerNotification.NotifyGroupPreJoinedGame => typeof(NotifyGroupPreJoinedGame),
            GameManagerNotification.NotifyPlayerRemoved => typeof(NotifyPlayerRemoved),
            GameManagerNotification.NotifyQueueChanged => typeof(NotifyQueueChanged),
            GameManagerNotification.NotifyHostMigrationFinished => typeof(NotifyHostMigrationFinished),
            GameManagerNotification.NotifyHostMigrationStart => typeof(NotifyHostMigrationStart),
            GameManagerNotification.NotifyPlatformHostInitialized => typeof(NotifyPlatformHostInitialized),
            GameManagerNotification.NotifyGameAttribChange => typeof(NotifyGameAttribChange),
            GameManagerNotification.NotifyPlayerAttribChange => typeof(NotifyPlayerAttribChange),
            GameManagerNotification.NotifyPlayerCustomDataChange => typeof(NotifyPlayerCustomDataChange),
            GameManagerNotification.NotifyGameStateChange => typeof(NotifyGameStateChange),
            GameManagerNotification.NotifyGameSettingsChange => typeof(NotifyGameSettingsChange),
            GameManagerNotification.NotifyGameCapacityChange => typeof(NotifyGameCapacityChange),
            GameManagerNotification.NotifyGameReset => typeof(NotifyGameReset),
            GameManagerNotification.NotifyGameReportingIdChange => typeof(NotifyGameReportingIdChange),
            GameManagerNotification.NotifyGameSessionUpdated => typeof(GameSessionUpdatedNotification),
            GameManagerNotification.NotifyGamePlayerStateChange => typeof(NotifyGamePlayerStateChange),
            GameManagerNotification.NotifyGamePlayerTeamChange => typeof(NotifyGamePlayerTeamChange),
            GameManagerNotification.NotifyGameTeamIdChange => typeof(NotifyGameTeamIdChange),
            GameManagerNotification.NotifyGameListUpdate => typeof(NotifyGameListUpdate),
            GameManagerNotification.NotifyAdminListChange => typeof(NotifyAdminListChange),
            GameManagerNotification.NotifyCreateDynamicDedicatedServerGame => typeof(NotifyCreateDynamicDedicatedServerGame),
            _ => typeof(NullStruct)
        };
        
        public enum GameManagerCommand : ushort
        {
            createGame = 1,
            destroyGame = 2,
            advanceGameState = 3,
            setGameSettings = 4,
            setPlayerCapacity = 5,
            setGameAttributes = 7,
            setPlayerAttributes = 8,
            joinGame = 9,
            updatePlayerConnection = 10,
            removePlayer = 11,
            startMatchmaking = 13,
            cancelMatchmaking = 14,
            finalizeGameCreation = 15,
            updateHostConnection = 16,
            listGames = 17,
            setPlayerCustomData = 18,
            replayGame = 19,
            returnDedicatedServerToPool = 20,
            joinGameByGroup = 21,
            leaveGameByGroup = 22,
            migrateGame = 23,
            resetDedicatedServer = 25,
            updateGameSession = 26,
            banPlayer = 27,
            matchmakingDedicatedServerOverride = 28,
            updateMeshConnection = 29,
            joinGameByUserList = 30,
            getGameListSnapshot = 100,
            getGameListSubscription = 101,
            destroyGameList = 102,
            getFullGameData = 103,
            getMatchmakingConfig = 104,
            getGameDataFromId = 105,
            addAdminPlayer = 106,
            removeAdminPlayer = 107,
            setPlayerTeam = 108,
            changeGameTeamId = 109,
            migrateAdminPlayer = 110,
            registerDynamicDedicatedServerCreator = 150,
            unregisterDynamicDedicatedServerCreator = 151,
        }
        
        public enum GameManagerNotification : ushort
        {
            NotifyMatchmakingFinished = 10,
            NotifyMatchmakingAsyncStatus = 12,
            NotifyGameCreated = 15,
            NotifyGameRemoved = 16,
            NotifyJoinGame = 20,
            NotifyPlayerJoining = 21,
            NotifyPlayerJoinCompleted = 30,
            NotifyGroupPreJoinedGame = 35,
            NotifyPlayerRemoved = 40,
            NotifyQueueChanged = 41,
            NotifyHostMigrationFinished = 60,
            NotifyHostMigrationStart = 70,
            NotifyPlatformHostInitialized = 71,
            NotifyGameAttribChange = 80,
            NotifyPlayerAttribChange = 90,
            NotifyPlayerCustomDataChange = 95,
            NotifyGameStateChange = 100,
            NotifyGameSettingsChange = 110,
            NotifyGameCapacityChange = 111,
            NotifyGameReset = 112,
            NotifyGameReportingIdChange = 113,
            NotifyGameSessionUpdated = 115,
            NotifyGamePlayerStateChange = 116,
            NotifyGamePlayerTeamChange = 117,
            NotifyGameTeamIdChange = 118,
            NotifyGameListUpdate = 201,
            NotifyAdminListChange = 202,
            NotifyCreateDynamicDedicatedServerGame = 220,
        }
        
    }
}
