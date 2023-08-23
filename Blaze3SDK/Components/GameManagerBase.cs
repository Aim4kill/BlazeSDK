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
        }
        
        public class Client : BlazeComponent<GameManagerCommand, GameManagerNotification, Blaze3RpcError>
        {
            public Client() : base(GameManagerBase.Id, GameManagerBase.Name)
            {
                
            }
        }
        
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
