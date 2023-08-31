using Blaze3SDK.Blaze.GameManager;
using BlazeCommon;

namespace Blaze3SDK.Components
{
    public static class GameManagerBase
    {
        public const ushort Id = 4;
        public const string Name = "GameManager";
        
        public class Server : BlazeComponent<GameManagerCommand, GameManagerNotification, Blaze3RpcError>
        {
            public Server() : base(GameManagerBase.Id, GameManagerBase.Name)
            {
                
            }
            
            [BlazeCommand((ushort)GameManagerCommand.createGame)]
            public virtual Task<CreateGameResponse> CreateGameAsync(CreateGameRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.destroyGame)]
            public virtual Task<DestroyGameResponse> DestroyGameAsync(DestroyGameRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.advanceGameState)]
            public virtual Task<NullStruct> AdvanceGameStateAsync(AdvanceGameStateRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.setGameSettings)]
            public virtual Task<NullStruct> SetGameSettingsAsync(SetGameSettingsRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.setPlayerCapacity)]
            public virtual Task<NullStruct> SetPlayerCapacityAsync(SetPlayerCapacityRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.setPresenceMode)]
            public virtual Task<NullStruct> SetPresenceModeAsync(SetPresenceModeRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.setGameAttributes)]
            public virtual Task<NullStruct> SetGameAttributesAsync(SetGameAttributesRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.setPlayerAttributes)]
            public virtual Task<NullStruct> SetPlayerAttributesAsync(SetPlayerAttributesRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.joinGame)]
            public virtual Task<JoinGameResponse> JoinGameAsync(JoinGameRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.removePlayer)]
            public virtual Task<NullStruct> RemovePlayerAsync(RemovePlayerRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.startMatchmaking)]
            public virtual Task<StartMatchmakingResponse> StartMatchmakingAsync(StartMatchmakingRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.cancelMatchmaking)]
            public virtual Task<NullStruct> CancelMatchmakingAsync(CancelMatchmakingRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.finalizeGameCreation)]
            public virtual Task<NullStruct> FinalizeGameCreationAsync(UpdateGameSessionRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.listGames)]
            public virtual Task<ListGamesResponse> ListGamesAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.setPlayerCustomData)]
            public virtual Task<NullStruct> SetPlayerCustomDataAsync(SetPlayerCustomDataRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.replayGame)]
            public virtual Task<NullStruct> ReplayGameAsync(ReplayGameRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.returnDedicatedServerToPool)]
            public virtual Task<NullStruct> ReturnDedicatedServerToPoolAsync(ReturnDedicatedServerToPoolRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.joinGameByGroup)]
            public virtual Task<NullStruct> JoinGameByGroupAsync(JoinGameRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.leaveGameByGroup)]
            public virtual Task<NullStruct> LeaveGameByGroupAsync(RemovePlayerRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.migrateGame)]
            public virtual Task<NullStruct> MigrateGameAsync(MigrateHostRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.updateGameHostMigrationStatus)]
            public virtual Task<NullStruct> UpdateGameHostMigrationStatusAsync(UpdateGameHostMigrationStatusRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.resetDedicatedServer)]
            public virtual Task<NullStruct> ResetDedicatedServerAsync(CreateGameRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.updateGameSession)]
            public virtual Task<NullStruct> UpdateGameSessionAsync(UpdateGameSessionRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.banPlayer)]
            public virtual Task<NullStruct> BanPlayerAsync(BanPlayerRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.updateMeshConnection)]
            public virtual Task<NullStruct> UpdateMeshConnectionAsync(UpdateMeshConnectionRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.removePlayerFromBannedList)]
            public virtual Task<NullStruct> RemovePlayerFromBannedListAsync(RemovePlayerFromBannedListRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.clearBannedList)]
            public virtual Task<NullStruct> ClearBannedListAsync(BannedListRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.getBannedList)]
            public virtual Task<BannedListResponse> GetBannedListAsync(BannedListRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.addQueuedPlayerToGame)]
            public virtual Task<NullStruct> AddQueuedPlayerToGameAsync(AddQueuedPlayerToGameRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.updateGameName)]
            public virtual Task<NullStruct> UpdateGameNameAsync(UpdateGameNameRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.ejectHost)]
            public virtual Task<NullStruct> EjectHostAsync(EjectHostRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.getGameListSnapshot)]
            public virtual Task<GetGameListResponse> GetGameListSnapshotAsync(GetGameListRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.getGameListSubscription)]
            public virtual Task<GetGameListResponse> GetGameListSubscriptionAsync(GetGameListRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.destroyGameList)]
            public virtual Task<NullStruct> DestroyGameListAsync(DestroyGameListRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.getFullGameData)]
            public virtual Task<GetFullGameDataResponse> GetFullGameDataAsync(GetFullGameDataRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.getMatchmakingConfig)]
            public virtual Task<GetMatchmakingConfigResponse> GetMatchmakingConfigAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.getGameDataFromId)]
            public virtual Task<NullStruct> GetGameDataFromIdAsync(GetGameDataFromIdRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.addAdminPlayer)]
            public virtual Task<NullStruct> AddAdminPlayerAsync(UpdateAdminListRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.removeAdminPlayer)]
            public virtual Task<NullStruct> RemoveAdminPlayerAsync(UpdateAdminListRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.setPlayerTeam)]
            public virtual Task<NullStruct> SetPlayerTeamAsync(SetPlayerTeamRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.changeGameTeamId)]
            public virtual Task<NullStruct> ChangeGameTeamIdAsync(ChangeTeamIdRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.migrateAdminPlayer)]
            public virtual Task<NullStruct> MigrateAdminPlayerAsync(UpdateAdminListRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.getUserSetGameListSubscription)]
            public virtual Task<NullStruct> GetUserSetGameListSubscriptionAsync(GetUserSetGameListSubscriptionRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.swapPlayersTeam)]
            public virtual Task<NullStruct> SwapPlayersTeamAsync(SwapPlayersTeamRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.registerDynamicDedicatedServerCreator)]
            public virtual Task<RegisterDynamicDedicatedServerCreatorResponse> RegisterDynamicDedicatedServerCreatorAsync(RegisterDynamicDedicatedServerCreatorRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GameManagerCommand.unregisterDynamicDedicatedServerCreator)]
            public virtual Task<UnregisterDynamicDedicatedServerCreatorResponse> UnregisterDynamicDedicatedServerCreatorAsync(UnregisterDynamicDedicatedServerCreatorRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            
            public static Task NotifyMatchmakingFailedAsync(BlazeServerConnection connection, NotifyMatchmakingFailed notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyMatchmakingFailed, notification, waitUntilFree);
            }
            
            public static Task NotifyMatchmakingAsyncStatusAsync(BlazeServerConnection connection, NotifyMatchmakingAsyncStatus notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyMatchmakingAsyncStatus, notification, waitUntilFree);
            }
            
            public static Task NotifyGameCreatedAsync(BlazeServerConnection connection, NotifyGameCreated notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyGameCreated, notification, waitUntilFree);
            }
            
            public static Task NotifyGameRemovedAsync(BlazeServerConnection connection, NotifyGameRemoved notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyGameRemoved, notification, waitUntilFree);
            }
            
            public static Task NotifyGameSetupAsync(BlazeServerConnection connection, NotifyGameSetup notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyGameSetup, notification, waitUntilFree);
            }
            
            public static Task NotifyPlayerJoiningAsync(BlazeServerConnection connection, NotifyPlayerJoining notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyPlayerJoining, notification, waitUntilFree);
            }
            
            public static Task NotifyJoiningPlayerInitiateConnectionsAsync(BlazeServerConnection connection, NotifyGameSetup notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyJoiningPlayerInitiateConnections, notification, waitUntilFree);
            }
            
            public static Task NotifyPlayerJoiningQueueAsync(BlazeServerConnection connection, NotifyPlayerJoining notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyPlayerJoiningQueue, notification, waitUntilFree);
            }
            
            public static Task NotifyPlayerPromotedFromQueueAsync(BlazeServerConnection connection, NotifyPlayerJoining notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyPlayerPromotedFromQueue, notification, waitUntilFree);
            }
            
            public static Task NotifyPlayerClaimingReservationAsync(BlazeServerConnection connection, NotifyPlayerJoining notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyPlayerClaimingReservation, notification, waitUntilFree);
            }
            
            public static Task NotifyPlayerJoinCompletedAsync(BlazeServerConnection connection, NotifyPlayerJoinCompleted notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyPlayerJoinCompleted, notification, waitUntilFree);
            }
            
            public static Task NotifyPlayerRemovedAsync(BlazeServerConnection connection, NotifyPlayerRemoved notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyPlayerRemoved, notification, waitUntilFree);
            }
            
            public static Task NotifyHostMigrationFinishedAsync(BlazeServerConnection connection, NotifyHostMigrationFinished notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyHostMigrationFinished, notification, waitUntilFree);
            }
            
            public static Task NotifyHostMigrationStartAsync(BlazeServerConnection connection, NotifyHostMigrationStart notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyHostMigrationStart, notification, waitUntilFree);
            }
            
            public static Task NotifyPlatformHostInitializedAsync(BlazeServerConnection connection, NotifyPlatformHostInitialized notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyPlatformHostInitialized, notification, waitUntilFree);
            }
            
            public static Task NotifyGameAttribChangeAsync(BlazeServerConnection connection, NotifyGameAttribChange notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyGameAttribChange, notification, waitUntilFree);
            }
            
            public static Task NotifyPlayerAttribChangeAsync(BlazeServerConnection connection, NotifyPlayerAttribChange notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyPlayerAttribChange, notification, waitUntilFree);
            }
            
            public static Task NotifyPlayerCustomDataChangeAsync(BlazeServerConnection connection, NotifyPlayerCustomDataChange notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyPlayerCustomDataChange, notification, waitUntilFree);
            }
            
            public static Task NotifyGameStateChangeAsync(BlazeServerConnection connection, NotifyGameStateChange notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyGameStateChange, notification, waitUntilFree);
            }
            
            public static Task NotifyGameSettingsChangeAsync(BlazeServerConnection connection, NotifyGameSettingsChange notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyGameSettingsChange, notification, waitUntilFree);
            }
            
            public static Task NotifyGameCapacityChangeAsync(BlazeServerConnection connection, NotifyGameCapacityChange notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyGameCapacityChange, notification, waitUntilFree);
            }
            
            public static Task NotifyGameResetAsync(BlazeServerConnection connection, NotifyGameReset notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyGameReset, notification, waitUntilFree);
            }
            
            public static Task NotifyGameReportingIdChangeAsync(BlazeServerConnection connection, NotifyGameReportingIdChange notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyGameReportingIdChange, notification, waitUntilFree);
            }
            
            public static Task NotifyGameSessionUpdatedAsync(BlazeServerConnection connection, GameSessionUpdatedNotification notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyGameSessionUpdated, notification, waitUntilFree);
            }
            
            public static Task NotifyGamePlayerStateChangeAsync(BlazeServerConnection connection, NotifyGamePlayerStateChange notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyGamePlayerStateChange, notification, waitUntilFree);
            }
            
            public static Task NotifyGamePlayerTeamChangeAsync(BlazeServerConnection connection, NotifyGamePlayerTeamChange notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyGamePlayerTeamChange, notification, waitUntilFree);
            }
            
            public static Task NotifyGameTeamIdChangeAsync(BlazeServerConnection connection, NotifyGameTeamIdChange notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyGameTeamIdChange, notification, waitUntilFree);
            }
            
            public static Task NotifyProcessQueueAsync(BlazeServerConnection connection, NotifyProcessQueue notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyProcessQueue, notification, waitUntilFree);
            }
            
            public static Task NotifyPresenceModeChangedAsync(BlazeServerConnection connection, NotifyPresenceModeChanged notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyPresenceModeChanged, notification, waitUntilFree);
            }
            
            public static Task NotifyGamePlayerQueuePositionChangeAsync(BlazeServerConnection connection, NotifyGamePlayerQueuePositionChange notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyGamePlayerQueuePositionChange, notification, waitUntilFree);
            }
            
            public static Task NotifyGameListUpdateAsync(BlazeServerConnection connection, NotifyGameListUpdate notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyGameListUpdate, notification, waitUntilFree);
            }
            
            public static Task NotifyAdminListChangeAsync(BlazeServerConnection connection, NotifyAdminListChange notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyAdminListChange, notification, waitUntilFree);
            }
            
            public static Task NotifyCreateDynamicDedicatedServerGameAsync(BlazeServerConnection connection, NotifyCreateDynamicDedicatedServerGame notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyCreateDynamicDedicatedServerGame, notification, waitUntilFree);
            }
            
            public static Task NotifyGameNameChangeAsync(BlazeServerConnection connection, NotifyGameNameChange notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(GameManagerBase.Id, (ushort)GameManagerNotification.NotifyGameNameChange, notification, waitUntilFree);
            }
            
            public override Type GetCommandRequestType(GameManagerCommand command) => GameManagerBase.GetCommandRequestType(command);
            public override Type GetCommandResponseType(GameManagerCommand command) => GameManagerBase.GetCommandResponseType(command);
            public override Type GetCommandErrorResponseType(GameManagerCommand command) => GameManagerBase.GetCommandErrorResponseType(command);
            public override Type GetNotificationType(GameManagerNotification notification) => GameManagerBase.GetNotificationType(notification);
            
        }
        
        public class Client : BlazeComponent<GameManagerCommand, GameManagerNotification, Blaze3RpcError>
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
            GameManagerCommand.createGame => typeof(CreateGameRequest),
            GameManagerCommand.destroyGame => typeof(DestroyGameRequest),
            GameManagerCommand.advanceGameState => typeof(AdvanceGameStateRequest),
            GameManagerCommand.setGameSettings => typeof(SetGameSettingsRequest),
            GameManagerCommand.setPlayerCapacity => typeof(SetPlayerCapacityRequest),
            GameManagerCommand.setPresenceMode => typeof(SetPresenceModeRequest),
            GameManagerCommand.setGameAttributes => typeof(SetGameAttributesRequest),
            GameManagerCommand.setPlayerAttributes => typeof(SetPlayerAttributesRequest),
            GameManagerCommand.joinGame => typeof(JoinGameRequest),
            GameManagerCommand.removePlayer => typeof(RemovePlayerRequest),
            GameManagerCommand.startMatchmaking => typeof(StartMatchmakingRequest),
            GameManagerCommand.cancelMatchmaking => typeof(CancelMatchmakingRequest),
            GameManagerCommand.finalizeGameCreation => typeof(UpdateGameSessionRequest),
            GameManagerCommand.listGames => typeof(NullStruct),
            GameManagerCommand.setPlayerCustomData => typeof(SetPlayerCustomDataRequest),
            GameManagerCommand.replayGame => typeof(ReplayGameRequest),
            GameManagerCommand.returnDedicatedServerToPool => typeof(ReturnDedicatedServerToPoolRequest),
            GameManagerCommand.joinGameByGroup => typeof(JoinGameRequest),
            GameManagerCommand.leaveGameByGroup => typeof(RemovePlayerRequest),
            GameManagerCommand.migrateGame => typeof(MigrateHostRequest),
            GameManagerCommand.updateGameHostMigrationStatus => typeof(UpdateGameHostMigrationStatusRequest),
            GameManagerCommand.resetDedicatedServer => typeof(CreateGameRequest),
            GameManagerCommand.updateGameSession => typeof(UpdateGameSessionRequest),
            GameManagerCommand.banPlayer => typeof(BanPlayerRequest),
            GameManagerCommand.updateMeshConnection => typeof(UpdateMeshConnectionRequest),
            GameManagerCommand.removePlayerFromBannedList => typeof(RemovePlayerFromBannedListRequest),
            GameManagerCommand.clearBannedList => typeof(BannedListRequest),
            GameManagerCommand.getBannedList => typeof(BannedListRequest),
            GameManagerCommand.addQueuedPlayerToGame => typeof(AddQueuedPlayerToGameRequest),
            GameManagerCommand.updateGameName => typeof(UpdateGameNameRequest),
            GameManagerCommand.ejectHost => typeof(EjectHostRequest),
            GameManagerCommand.getGameListSnapshot => typeof(GetGameListRequest),
            GameManagerCommand.getGameListSubscription => typeof(GetGameListRequest),
            GameManagerCommand.destroyGameList => typeof(DestroyGameListRequest),
            GameManagerCommand.getFullGameData => typeof(GetFullGameDataRequest),
            GameManagerCommand.getMatchmakingConfig => typeof(NullStruct),
            GameManagerCommand.getGameDataFromId => typeof(GetGameDataFromIdRequest),
            GameManagerCommand.addAdminPlayer => typeof(UpdateAdminListRequest),
            GameManagerCommand.removeAdminPlayer => typeof(UpdateAdminListRequest),
            GameManagerCommand.setPlayerTeam => typeof(SetPlayerTeamRequest),
            GameManagerCommand.changeGameTeamId => typeof(ChangeTeamIdRequest),
            GameManagerCommand.migrateAdminPlayer => typeof(UpdateAdminListRequest),
            GameManagerCommand.getUserSetGameListSubscription => typeof(GetUserSetGameListSubscriptionRequest),
            GameManagerCommand.swapPlayersTeam => typeof(SwapPlayersTeamRequest),
            GameManagerCommand.registerDynamicDedicatedServerCreator => typeof(RegisterDynamicDedicatedServerCreatorRequest),
            GameManagerCommand.unregisterDynamicDedicatedServerCreator => typeof(UnregisterDynamicDedicatedServerCreatorRequest),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandResponseType(GameManagerCommand command) => command switch
        {
            GameManagerCommand.createGame => typeof(CreateGameResponse),
            GameManagerCommand.destroyGame => typeof(DestroyGameResponse),
            GameManagerCommand.advanceGameState => typeof(NullStruct),
            GameManagerCommand.setGameSettings => typeof(NullStruct),
            GameManagerCommand.setPlayerCapacity => typeof(NullStruct),
            GameManagerCommand.setPresenceMode => typeof(NullStruct),
            GameManagerCommand.setGameAttributes => typeof(NullStruct),
            GameManagerCommand.setPlayerAttributes => typeof(NullStruct),
            GameManagerCommand.joinGame => typeof(JoinGameResponse),
            GameManagerCommand.removePlayer => typeof(NullStruct),
            GameManagerCommand.startMatchmaking => typeof(StartMatchmakingResponse),
            GameManagerCommand.cancelMatchmaking => typeof(NullStruct),
            GameManagerCommand.finalizeGameCreation => typeof(NullStruct),
            GameManagerCommand.listGames => typeof(ListGamesResponse),
            GameManagerCommand.setPlayerCustomData => typeof(NullStruct),
            GameManagerCommand.replayGame => typeof(NullStruct),
            GameManagerCommand.returnDedicatedServerToPool => typeof(NullStruct),
            GameManagerCommand.joinGameByGroup => typeof(NullStruct),
            GameManagerCommand.leaveGameByGroup => typeof(NullStruct),
            GameManagerCommand.migrateGame => typeof(NullStruct),
            GameManagerCommand.updateGameHostMigrationStatus => typeof(NullStruct),
            GameManagerCommand.resetDedicatedServer => typeof(NullStruct),
            GameManagerCommand.updateGameSession => typeof(NullStruct),
            GameManagerCommand.banPlayer => typeof(NullStruct),
            GameManagerCommand.updateMeshConnection => typeof(NullStruct),
            GameManagerCommand.removePlayerFromBannedList => typeof(NullStruct),
            GameManagerCommand.clearBannedList => typeof(NullStruct),
            GameManagerCommand.getBannedList => typeof(BannedListResponse),
            GameManagerCommand.addQueuedPlayerToGame => typeof(NullStruct),
            GameManagerCommand.updateGameName => typeof(NullStruct),
            GameManagerCommand.ejectHost => typeof(NullStruct),
            GameManagerCommand.getGameListSnapshot => typeof(GetGameListResponse),
            GameManagerCommand.getGameListSubscription => typeof(GetGameListResponse),
            GameManagerCommand.destroyGameList => typeof(NullStruct),
            GameManagerCommand.getFullGameData => typeof(GetFullGameDataResponse),
            GameManagerCommand.getMatchmakingConfig => typeof(GetMatchmakingConfigResponse),
            GameManagerCommand.getGameDataFromId => typeof(NullStruct),
            GameManagerCommand.addAdminPlayer => typeof(NullStruct),
            GameManagerCommand.removeAdminPlayer => typeof(NullStruct),
            GameManagerCommand.setPlayerTeam => typeof(NullStruct),
            GameManagerCommand.changeGameTeamId => typeof(NullStruct),
            GameManagerCommand.migrateAdminPlayer => typeof(NullStruct),
            GameManagerCommand.getUserSetGameListSubscription => typeof(NullStruct),
            GameManagerCommand.swapPlayersTeam => typeof(NullStruct),
            GameManagerCommand.registerDynamicDedicatedServerCreator => typeof(RegisterDynamicDedicatedServerCreatorResponse),
            GameManagerCommand.unregisterDynamicDedicatedServerCreator => typeof(UnregisterDynamicDedicatedServerCreatorResponse),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandErrorResponseType(GameManagerCommand command) => command switch
        {
            GameManagerCommand.createGame => typeof(NullStruct),
            GameManagerCommand.destroyGame => typeof(NullStruct),
            GameManagerCommand.advanceGameState => typeof(NullStruct),
            GameManagerCommand.setGameSettings => typeof(NullStruct),
            GameManagerCommand.setPlayerCapacity => typeof(NullStruct),
            GameManagerCommand.setPresenceMode => typeof(NullStruct),
            GameManagerCommand.setGameAttributes => typeof(NullStruct),
            GameManagerCommand.setPlayerAttributes => typeof(NullStruct),
            GameManagerCommand.joinGame => typeof(NullStruct),
            GameManagerCommand.removePlayer => typeof(NullStruct),
            GameManagerCommand.startMatchmaking => typeof(NullStruct),
            GameManagerCommand.cancelMatchmaking => typeof(NullStruct),
            GameManagerCommand.finalizeGameCreation => typeof(NullStruct),
            GameManagerCommand.listGames => typeof(NullStruct),
            GameManagerCommand.setPlayerCustomData => typeof(NullStruct),
            GameManagerCommand.replayGame => typeof(NullStruct),
            GameManagerCommand.returnDedicatedServerToPool => typeof(NullStruct),
            GameManagerCommand.joinGameByGroup => typeof(NullStruct),
            GameManagerCommand.leaveGameByGroup => typeof(NullStruct),
            GameManagerCommand.migrateGame => typeof(NullStruct),
            GameManagerCommand.updateGameHostMigrationStatus => typeof(NullStruct),
            GameManagerCommand.resetDedicatedServer => typeof(NullStruct),
            GameManagerCommand.updateGameSession => typeof(NullStruct),
            GameManagerCommand.banPlayer => typeof(NullStruct),
            GameManagerCommand.updateMeshConnection => typeof(NullStruct),
            GameManagerCommand.removePlayerFromBannedList => typeof(NullStruct),
            GameManagerCommand.clearBannedList => typeof(NullStruct),
            GameManagerCommand.getBannedList => typeof(NullStruct),
            GameManagerCommand.addQueuedPlayerToGame => typeof(NullStruct),
            GameManagerCommand.updateGameName => typeof(NullStruct),
            GameManagerCommand.ejectHost => typeof(NullStruct),
            GameManagerCommand.getGameListSnapshot => typeof(NullStruct),
            GameManagerCommand.getGameListSubscription => typeof(NullStruct),
            GameManagerCommand.destroyGameList => typeof(NullStruct),
            GameManagerCommand.getFullGameData => typeof(NullStruct),
            GameManagerCommand.getMatchmakingConfig => typeof(NullStruct),
            GameManagerCommand.getGameDataFromId => typeof(NullStruct),
            GameManagerCommand.addAdminPlayer => typeof(NullStruct),
            GameManagerCommand.removeAdminPlayer => typeof(NullStruct),
            GameManagerCommand.setPlayerTeam => typeof(NullStruct),
            GameManagerCommand.changeGameTeamId => typeof(NullStruct),
            GameManagerCommand.migrateAdminPlayer => typeof(NullStruct),
            GameManagerCommand.getUserSetGameListSubscription => typeof(NullStruct),
            GameManagerCommand.swapPlayersTeam => typeof(NullStruct),
            GameManagerCommand.registerDynamicDedicatedServerCreator => typeof(NullStruct),
            GameManagerCommand.unregisterDynamicDedicatedServerCreator => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetNotificationType(GameManagerNotification notification) => notification switch
        {
            GameManagerNotification.NotifyMatchmakingFailed => typeof(NotifyMatchmakingFailed),
            GameManagerNotification.NotifyMatchmakingAsyncStatus => typeof(NotifyMatchmakingAsyncStatus),
            GameManagerNotification.NotifyGameCreated => typeof(NotifyGameCreated),
            GameManagerNotification.NotifyGameRemoved => typeof(NotifyGameRemoved),
            GameManagerNotification.NotifyGameSetup => typeof(NotifyGameSetup),
            GameManagerNotification.NotifyPlayerJoining => typeof(NotifyPlayerJoining),
            GameManagerNotification.NotifyJoiningPlayerInitiateConnections => typeof(NotifyGameSetup),
            GameManagerNotification.NotifyPlayerJoiningQueue => typeof(NotifyPlayerJoining),
            GameManagerNotification.NotifyPlayerPromotedFromQueue => typeof(NotifyPlayerJoining),
            GameManagerNotification.NotifyPlayerClaimingReservation => typeof(NotifyPlayerJoining),
            GameManagerNotification.NotifyPlayerJoinCompleted => typeof(NotifyPlayerJoinCompleted),
            GameManagerNotification.NotifyPlayerRemoved => typeof(NotifyPlayerRemoved),
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
            GameManagerNotification.NotifyProcessQueue => typeof(NotifyProcessQueue),
            GameManagerNotification.NotifyPresenceModeChanged => typeof(NotifyPresenceModeChanged),
            GameManagerNotification.NotifyGamePlayerQueuePositionChange => typeof(NotifyGamePlayerQueuePositionChange),
            GameManagerNotification.NotifyGameListUpdate => typeof(NotifyGameListUpdate),
            GameManagerNotification.NotifyAdminListChange => typeof(NotifyAdminListChange),
            GameManagerNotification.NotifyCreateDynamicDedicatedServerGame => typeof(NotifyCreateDynamicDedicatedServerGame),
            GameManagerNotification.NotifyGameNameChange => typeof(NotifyGameNameChange),
            _ => typeof(NullStruct)
        };
        
        public enum GameManagerCommand : ushort
        {
            createGame = 1,
            destroyGame = 2,
            advanceGameState = 3,
            setGameSettings = 4,
            setPlayerCapacity = 5,
            setPresenceMode = 6,
            setGameAttributes = 7,
            setPlayerAttributes = 8,
            joinGame = 9,
            removePlayer = 11,
            startMatchmaking = 13,
            cancelMatchmaking = 14,
            finalizeGameCreation = 15,
            listGames = 17,
            setPlayerCustomData = 18,
            replayGame = 19,
            returnDedicatedServerToPool = 20,
            joinGameByGroup = 21,
            leaveGameByGroup = 22,
            migrateGame = 23,
            updateGameHostMigrationStatus = 24,
            resetDedicatedServer = 25,
            updateGameSession = 26,
            banPlayer = 27,
            updateMeshConnection = 29,
            removePlayerFromBannedList = 31,
            clearBannedList = 32,
            getBannedList = 33,
            addQueuedPlayerToGame = 38,
            updateGameName = 39,
            ejectHost = 40,
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
            getUserSetGameListSubscription = 111,
            swapPlayersTeam = 112,
            registerDynamicDedicatedServerCreator = 150,
            unregisterDynamicDedicatedServerCreator = 151,
        }
        
        public enum GameManagerNotification : ushort
        {
            NotifyMatchmakingFailed = 10,
            NotifyMatchmakingAsyncStatus = 12,
            NotifyGameCreated = 15,
            NotifyGameRemoved = 16,
            NotifyGameSetup = 20,
            NotifyPlayerJoining = 21,
            NotifyJoiningPlayerInitiateConnections = 22,
            NotifyPlayerJoiningQueue = 23,
            NotifyPlayerPromotedFromQueue = 24,
            NotifyPlayerClaimingReservation = 25,
            NotifyPlayerJoinCompleted = 30,
            NotifyPlayerRemoved = 40,
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
            NotifyProcessQueue = 119,
            NotifyPresenceModeChanged = 120,
            NotifyGamePlayerQueuePositionChange = 121,
            NotifyGameListUpdate = 201,
            NotifyAdminListChange = 202,
            NotifyCreateDynamicDedicatedServerGame = 220,
            NotifyGameNameChange = 230,
        }
        
    }
}
