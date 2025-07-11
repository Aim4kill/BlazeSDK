using Blaze.Core;
using Blaze2SDK.Blaze;
using Blaze2SDK.Blaze.GameManager;
using EATDF;
using EATDF.Types;

namespace Blaze2SDK.Components;

public static class GameManagerBase
{
    public const ushort Id = 4;
    public const string Name = "GameManager";
    
    public enum Error : ushort {
        GAMEMANAGER_ERR_INVALID_GAME_SETTINGS = 1,
        GAMEMANAGER_ERR_INVALID_GAME_ID = 2,
        GAMEMANAGER_ERR_JOIN_METHOD_NOT_SUPPORTED = 3,
        GAMEMANAGER_ERR_GAME_FULL = 4,
        GAMEMANAGER_ERR_INVALID_GAME_STATE_TRANSITION = 5,
        GAMEMANAGER_ERR_INVALID_GAME_STATE_ACTION = 6,
        GAMEMANAGER_ERR_FAILED_IN_GAME_DESTROY = 7,
        GAMEMANAGER_ERR_QUEUE_FULL = 8,
        GAMEMANAGER_ERR_INVALID_GAME_ENTRY_CRITERIA = 9,
        GAMEMANAGER_ERR_GAME_PROTOCOL_VERSION_MISMATCH = 10,
        GAMEMANAGER_ERR_GAME_IN_PROGRESS = 11,
        GAMEMANAGER_ERR_RESERVED_GAME_ID_INVALID = 12,
        GAMEMANAGER_ERR_INVALID_JOIN_METHOD = 13,
        GAMEMANAGER_ERR_PERMISSION_DENIED = 30,
        GAMEMANAGER_ERR_ALREADY_ADMIN = 31,
        GAMEMANAGER_ERR_NOT_IN_ADMIN_LIST = 32,
        GAMEMANAGER_ERR_DEDICATED_SERVER_HOST = 33,
        GAMEMANAGER_ERR_PLAYER_NOT_FOUND = 101,
        GAMEMANAGER_ERR_PLAYER_IN_QUEUE = 102,
        GAMEMANAGER_ERR_ALREADY_GAME_MEMBER = 103,
        GAMEMANAGER_ERR_REMOVE_PLAYER_FAILED = 104,
        GAMEMANAGER_ERR_INVALID_PLAYER_PASSEDIN = 107,
        GAMEMANAGER_ERR_JOIN_PLAYER_FAILED = 108,
        GAMEMANAGER_ERR_PLAYER_BANNED = 110,
        GAMEMANAGER_ERR_GAME_ENTRY_CRITERIA_FAILED = 111,
        GAMEMANAGER_ERR_ALREADY_IN_QUEUE = 112,
        GAMEMANAGER_ERR_ENFORCING_SINGLE_GROUP_JOINS = 113,
        GAMEMANAGER_ERR_MEMBER_PRE_JOIN_FAILED = 150,
        GAMEMANAGER_ERR_INVALID_GROUP_ID = 151,
        GAMEMANAGER_ERR_PLAYER_NOT_IN_GROUP = 152,
        GAMEMANAGER_ERR_INVALID_MATCHMAKING_CRITERIA = 200,
        GAMEMANAGER_ERR_UNKNOWN_MATCHMAKING_SESSION_ID = 201,
        GAMEMANAGER_ERR_NOT_MATCHMAKING_SESSION_OWNER = 202,
        GAMEMANAGER_ERR_PLAYER_CAPACITY_TOO_SMALL = 230,
        GAMEMANAGER_ERR_PLAYER_CAPACITY_TOO_LARGE = 231,
        GAMEMANAGER_ERR_PLAYER_CAPACITY_IS_ZERO = 232,
        GAMEMANAGER_ERR_MAX_PLAYER_CAPACITY_TOO_LARGE = 233,
        GAMEMANAGER_ERR_INVALID_TEAM_CAPACITIES_VECTOR_SIZE = 250,
        GAMEMANAGER_ERR_DUPLICATE_TEAM_CAPACITY = 251,
        GAMEMANAGER_ERR_INVALID_TEAM_ID_IN_TEAM_CAPACITIES_VECTOR = 252,
        GAMEMANAGER_ERR_TEAM_NOT_ALLOWED = 253,
        GAMEMANAGER_ERR_TOTAL_TEAM_CAPACITY_INVALID = 254,
        GAMEMANAGER_ERR_TEAM_FULL = 255,
        GAMEMANAGER_ERR_TEAMS_DISABLED = 256,
        GAMEMANAGER_ERR_NO_DEDICATED_SERVER_FOUND = 301,
        GAMEMANAGER_ERR_DEDICATED_SERVER_ONLY_ACTION = 302,
        GAMEMANAGER_ERR_DEDICATED_SERVER_HOST_CANNOT_JOIN = 303,
        GAMEMANGER_ERR_MACHINE_ID_LIST_EMPTY = 304,
        GAMEMANAGER_ERR_DYNAMIC_GAME_CREATION_TIMED_OUT = 305,
        GAMEMANAGER_ERR_DYNAMIC_GAME_CREATION_FAILED_NO_CAPACITY = 306,
        GAMEMANAGER_ERR_DYNAMIC_DEDICATED_SERVER_MODE_CONFLICT = 307,
        GAMEBROWSER_ERR_INVALID_CRITERIA = 401,
        GAMEBROWSER_ERR_INVALID_CAPACITY = 402,
        GAMEBROWSER_ERR_INVALID_LIST_ID = 403,
        GAMEBROWSER_ERR_NOT_LIST_OWNER = 404,
        GAMEBROWSER_ERR_INVALID_LIST_CONFIG_NAME = 405,
        GAMEMANAGER_ERR_GAME_CAPACITY_LESS_THAN_GROUP_MEMBER = 502,
        GAMEMANAGER_ERR_INVALID_ACTION_FOR_GROUP = 503,
        GAMEMANAGER_ERR_MIGRATION_NOT_SUPPORTED = 505,
        GAMEMANAGER_ERR_INVALID_NEWHOST = 506,
        GAMEMANAGER_ERR_USER_NOT_IN_ANY_GAME = 507,
        GAMEMANAGER_ERR_INVALID_PERSISTED_GAME_ID_OR_SECRET = 508,
        GAMEMANAGER_ERR_PERSISTED_GAME_ID_IN_USE = 509,
    }
    
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
    
    public class Server : BlazeComponent {
        public override ushort Id => GameManagerBase.Id;
        public override string Name => GameManagerBase.Name;
        
        public virtual bool IsCommandSupported(GameManagerCommand command) => false;
        
        public class GameManagerException : BlazeRpcException
        {
            public GameManagerException(Error error) : base((ushort)error, null) { }
            public GameManagerException(ServerError error) : base(error.WithErrorPrefix(), null) { }
            public GameManagerException(Error error, Tdf? errorResponse) : base((ushort)error, errorResponse) { }
            public GameManagerException(ServerError error, Tdf? errorResponse) : base(error.WithErrorPrefix(), errorResponse) { }
            public GameManagerException(Error error, Tdf? errorResponse, string? message) : base((ushort)error, errorResponse, message) { }
            public GameManagerException(ServerError error, Tdf? errorResponse, string? message) : base(error.WithErrorPrefix(), errorResponse, message) { }
            public GameManagerException(Error error, Tdf? errorResponse, string? message, Exception? innerException) : base((ushort)error, errorResponse, message, innerException) { }
            public GameManagerException(ServerError error, Tdf? errorResponse, string? message, Exception? innerException) : base(error.WithErrorPrefix(), errorResponse, message, innerException) { }
        }
        
        public Server()
        {
            RegisterCommand(new RpcCommandFunc<CreateGameRequest, CreateGameResponse, EmptyMessage>()
            {
                Id = (ushort)GameManagerCommand.createGame,
                Name = "createGame",
                IsSupported = IsCommandSupported(GameManagerCommand.createGame),
                Func = async (req, ctx) => await CreateGameAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<DestroyGameRequest, DestroyGameResponse, EmptyMessage>()
            {
                Id = (ushort)GameManagerCommand.destroyGame,
                Name = "destroyGame",
                IsSupported = IsCommandSupported(GameManagerCommand.destroyGame),
                Func = async (req, ctx) => await DestroyGameAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<AdvanceGameStateRequest, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameManagerCommand.advanceGameState,
                Name = "advanceGameState",
                IsSupported = IsCommandSupported(GameManagerCommand.advanceGameState),
                Func = async (req, ctx) => await AdvanceGameStateAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<SetGameSettingsRequest, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameManagerCommand.setGameSettings,
                Name = "setGameSettings",
                IsSupported = IsCommandSupported(GameManagerCommand.setGameSettings),
                Func = async (req, ctx) => await SetGameSettingsAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<SetPlayerCapacityRequest, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameManagerCommand.setPlayerCapacity,
                Name = "setPlayerCapacity",
                IsSupported = IsCommandSupported(GameManagerCommand.setPlayerCapacity),
                Func = async (req, ctx) => await SetPlayerCapacityAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<SetGameAttributesRequest, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameManagerCommand.setGameAttributes,
                Name = "setGameAttributes",
                IsSupported = IsCommandSupported(GameManagerCommand.setGameAttributes),
                Func = async (req, ctx) => await SetGameAttributesAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<SetPlayerAttributesRequest, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameManagerCommand.setPlayerAttributes,
                Name = "setPlayerAttributes",
                IsSupported = IsCommandSupported(GameManagerCommand.setPlayerAttributes),
                Func = async (req, ctx) => await SetPlayerAttributesAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<JoinGameRequest, JoinGameResponse, EntryCriteriaError>()
            {
                Id = (ushort)GameManagerCommand.joinGame,
                Name = "joinGame",
                IsSupported = IsCommandSupported(GameManagerCommand.joinGame),
                Func = async (req, ctx) => await JoinGameAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameManagerCommand.updatePlayerConnection,
                Name = "updatePlayerConnection",
                IsSupported = IsCommandSupported(GameManagerCommand.updatePlayerConnection),
                Func = async (req, ctx) => await UpdatePlayerConnectionAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<RemovePlayerRequest, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameManagerCommand.removePlayer,
                Name = "removePlayer",
                IsSupported = IsCommandSupported(GameManagerCommand.removePlayer),
                Func = async (req, ctx) => await RemovePlayerAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<StartMatchmakingRequest, StartMatchmakingResponse, MatchmakingCriteriaError>()
            {
                Id = (ushort)GameManagerCommand.startMatchmaking,
                Name = "startMatchmaking",
                IsSupported = IsCommandSupported(GameManagerCommand.startMatchmaking),
                Func = async (req, ctx) => await StartMatchmakingAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<CancelMatchmakingRequest, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameManagerCommand.cancelMatchmaking,
                Name = "cancelMatchmaking",
                IsSupported = IsCommandSupported(GameManagerCommand.cancelMatchmaking),
                Func = async (req, ctx) => await CancelMatchmakingAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<UpdateGameSessionRequest, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameManagerCommand.finalizeGameCreation,
                Name = "finalizeGameCreation",
                IsSupported = IsCommandSupported(GameManagerCommand.finalizeGameCreation),
                Func = async (req, ctx) => await FinalizeGameCreationAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameManagerCommand.updateHostConnection,
                Name = "updateHostConnection",
                IsSupported = IsCommandSupported(GameManagerCommand.updateHostConnection),
                Func = async (req, ctx) => await UpdateHostConnectionAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameManagerCommand.listGames,
                Name = "listGames",
                IsSupported = IsCommandSupported(GameManagerCommand.listGames),
                Func = async (req, ctx) => await ListGamesAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<SetPlayerCustomDataRequest, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameManagerCommand.setPlayerCustomData,
                Name = "setPlayerCustomData",
                IsSupported = IsCommandSupported(GameManagerCommand.setPlayerCustomData),
                Func = async (req, ctx) => await SetPlayerCustomDataAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<ReplayGameRequest, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameManagerCommand.replayGame,
                Name = "replayGame",
                IsSupported = IsCommandSupported(GameManagerCommand.replayGame),
                Func = async (req, ctx) => await ReplayGameAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<ReturnDedicatedServerToPoolRequest, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameManagerCommand.returnDedicatedServerToPool,
                Name = "returnDedicatedServerToPool",
                IsSupported = IsCommandSupported(GameManagerCommand.returnDedicatedServerToPool),
                Func = async (req, ctx) => await ReturnDedicatedServerToPoolAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<JoinGameRequest, JoinGameResponse, EntryCriteriaError>()
            {
                Id = (ushort)GameManagerCommand.joinGameByGroup,
                Name = "joinGameByGroup",
                IsSupported = IsCommandSupported(GameManagerCommand.joinGameByGroup),
                Func = async (req, ctx) => await JoinGameByGroupAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<RemovePlayerRequest, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameManagerCommand.leaveGameByGroup,
                Name = "leaveGameByGroup",
                IsSupported = IsCommandSupported(GameManagerCommand.leaveGameByGroup),
                Func = async (req, ctx) => await LeaveGameByGroupAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<MigrateHostRequest, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameManagerCommand.migrateGame,
                Name = "migrateGame",
                IsSupported = IsCommandSupported(GameManagerCommand.migrateGame),
                Func = async (req, ctx) => await MigrateGameAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<CreateGameRequest, JoinGameResponse, EmptyMessage>()
            {
                Id = (ushort)GameManagerCommand.resetDedicatedServer,
                Name = "resetDedicatedServer",
                IsSupported = IsCommandSupported(GameManagerCommand.resetDedicatedServer),
                Func = async (req, ctx) => await ResetDedicatedServerAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<UpdateGameSessionRequest, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameManagerCommand.updateGameSession,
                Name = "updateGameSession",
                IsSupported = IsCommandSupported(GameManagerCommand.updateGameSession),
                Func = async (req, ctx) => await UpdateGameSessionAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<BanPlayerRequest, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameManagerCommand.banPlayer,
                Name = "banPlayer",
                IsSupported = IsCommandSupported(GameManagerCommand.banPlayer),
                Func = async (req, ctx) => await BanPlayerAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameManagerCommand.matchmakingDedicatedServerOverride,
                Name = "matchmakingDedicatedServerOverride",
                IsSupported = IsCommandSupported(GameManagerCommand.matchmakingDedicatedServerOverride),
                Func = async (req, ctx) => await MatchmakingDedicatedServerOverrideAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<UpdateMeshConnectionRequest, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameManagerCommand.updateMeshConnection,
                Name = "updateMeshConnection",
                IsSupported = IsCommandSupported(GameManagerCommand.updateMeshConnection),
                Func = async (req, ctx) => await UpdateMeshConnectionAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameManagerCommand.joinGameByUserList,
                Name = "joinGameByUserList",
                IsSupported = IsCommandSupported(GameManagerCommand.joinGameByUserList),
                Func = async (req, ctx) => await JoinGameByUserListAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<GetGameListRequest, GetGameListResponse, MatchmakingCriteriaError>()
            {
                Id = (ushort)GameManagerCommand.getGameListSnapshot,
                Name = "getGameListSnapshot",
                IsSupported = IsCommandSupported(GameManagerCommand.getGameListSnapshot),
                Func = async (req, ctx) => await GetGameListSnapshotAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<GetGameListRequest, GetGameListResponse, MatchmakingCriteriaError>()
            {
                Id = (ushort)GameManagerCommand.getGameListSubscription,
                Name = "getGameListSubscription",
                IsSupported = IsCommandSupported(GameManagerCommand.getGameListSubscription),
                Func = async (req, ctx) => await GetGameListSubscriptionAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<DestroyGameListRequest, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameManagerCommand.destroyGameList,
                Name = "destroyGameList",
                IsSupported = IsCommandSupported(GameManagerCommand.destroyGameList),
                Func = async (req, ctx) => await DestroyGameListAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<GetFullGameDataRequest, GetFullGameDataResponse, EmptyMessage>()
            {
                Id = (ushort)GameManagerCommand.getFullGameData,
                Name = "getFullGameData",
                IsSupported = IsCommandSupported(GameManagerCommand.getFullGameData),
                Func = async (req, ctx) => await GetFullGameDataAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, GetMatchmakingConfigResponse, EmptyMessage>()
            {
                Id = (ushort)GameManagerCommand.getMatchmakingConfig,
                Name = "getMatchmakingConfig",
                IsSupported = IsCommandSupported(GameManagerCommand.getMatchmakingConfig),
                Func = async (req, ctx) => await GetMatchmakingConfigAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<GetGameDataFromIdRequest, GameBrowserDataList, EmptyMessage>()
            {
                Id = (ushort)GameManagerCommand.getGameDataFromId,
                Name = "getGameDataFromId",
                IsSupported = IsCommandSupported(GameManagerCommand.getGameDataFromId),
                Func = async (req, ctx) => await GetGameDataFromIdAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<UpdateAdminListRequest, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameManagerCommand.addAdminPlayer,
                Name = "addAdminPlayer",
                IsSupported = IsCommandSupported(GameManagerCommand.addAdminPlayer),
                Func = async (req, ctx) => await AddAdminPlayerAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<UpdateAdminListRequest, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameManagerCommand.removeAdminPlayer,
                Name = "removeAdminPlayer",
                IsSupported = IsCommandSupported(GameManagerCommand.removeAdminPlayer),
                Func = async (req, ctx) => await RemoveAdminPlayerAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<SetPlayerTeamRequest, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameManagerCommand.setPlayerTeam,
                Name = "setPlayerTeam",
                IsSupported = IsCommandSupported(GameManagerCommand.setPlayerTeam),
                Func = async (req, ctx) => await SetPlayerTeamAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<ChangeTeamIdRequest, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameManagerCommand.changeGameTeamId,
                Name = "changeGameTeamId",
                IsSupported = IsCommandSupported(GameManagerCommand.changeGameTeamId),
                Func = async (req, ctx) => await ChangeGameTeamIdAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<UpdateAdminListRequest, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameManagerCommand.migrateAdminPlayer,
                Name = "migrateAdminPlayer",
                IsSupported = IsCommandSupported(GameManagerCommand.migrateAdminPlayer),
                Func = async (req, ctx) => await MigrateAdminPlayerAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameManagerCommand.registerDynamicDedicatedServerCreator,
                Name = "registerDynamicDedicatedServerCreator",
                IsSupported = IsCommandSupported(GameManagerCommand.registerDynamicDedicatedServerCreator),
                Func = async (req, ctx) => await RegisterDynamicDedicatedServerCreatorAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameManagerCommand.unregisterDynamicDedicatedServerCreator,
                Name = "unregisterDynamicDedicatedServerCreator",
                IsSupported = IsCommandSupported(GameManagerCommand.unregisterDynamicDedicatedServerCreator),
                Func = async (req, ctx) => await UnregisterDynamicDedicatedServerCreatorAsync(req, ctx).ConfigureAwait(false)
            });
            
        }
        
        public override string GetErrorName(ushort errorCode)
        {
            return ((Error)errorCode).ToString();
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameManager::createGame</b> command.<br/>
        /// Request type: <see cref="CreateGameRequest"/><br/>
        /// Response type: <see cref="CreateGameResponse"/><br/>
        /// </summary>
        public virtual Task<CreateGameResponse> CreateGameAsync(CreateGameRequest request, BlazeRpcContext context)
        {
            throw new GameManagerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameManager::destroyGame</b> command.<br/>
        /// Request type: <see cref="DestroyGameRequest"/><br/>
        /// Response type: <see cref="DestroyGameResponse"/><br/>
        /// </summary>
        public virtual Task<DestroyGameResponse> DestroyGameAsync(DestroyGameRequest request, BlazeRpcContext context)
        {
            throw new GameManagerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameManager::advanceGameState</b> command.<br/>
        /// Request type: <see cref="AdvanceGameStateRequest"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> AdvanceGameStateAsync(AdvanceGameStateRequest request, BlazeRpcContext context)
        {
            throw new GameManagerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameManager::setGameSettings</b> command.<br/>
        /// Request type: <see cref="SetGameSettingsRequest"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SetGameSettingsAsync(SetGameSettingsRequest request, BlazeRpcContext context)
        {
            throw new GameManagerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameManager::setPlayerCapacity</b> command.<br/>
        /// Request type: <see cref="SetPlayerCapacityRequest"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SetPlayerCapacityAsync(SetPlayerCapacityRequest request, BlazeRpcContext context)
        {
            throw new GameManagerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameManager::setGameAttributes</b> command.<br/>
        /// Request type: <see cref="SetGameAttributesRequest"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SetGameAttributesAsync(SetGameAttributesRequest request, BlazeRpcContext context)
        {
            throw new GameManagerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameManager::setPlayerAttributes</b> command.<br/>
        /// Request type: <see cref="SetPlayerAttributesRequest"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SetPlayerAttributesAsync(SetPlayerAttributesRequest request, BlazeRpcContext context)
        {
            throw new GameManagerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameManager::joinGame</b> command.<br/>
        /// Request type: <see cref="JoinGameRequest"/><br/>
        /// Response type: <see cref="JoinGameResponse"/><br/>
        /// Error response type: <see cref="EntryCriteriaError"/><br/>
        /// </summary>
        public virtual Task<JoinGameResponse> JoinGameAsync(JoinGameRequest request, BlazeRpcContext context)
        {
            throw new GameManagerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameManager::updatePlayerConnection</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> UpdatePlayerConnectionAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new GameManagerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameManager::removePlayer</b> command.<br/>
        /// Request type: <see cref="RemovePlayerRequest"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> RemovePlayerAsync(RemovePlayerRequest request, BlazeRpcContext context)
        {
            throw new GameManagerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameManager::startMatchmaking</b> command.<br/>
        /// Request type: <see cref="StartMatchmakingRequest"/><br/>
        /// Response type: <see cref="StartMatchmakingResponse"/><br/>
        /// Error response type: <see cref="MatchmakingCriteriaError"/><br/>
        /// </summary>
        public virtual Task<StartMatchmakingResponse> StartMatchmakingAsync(StartMatchmakingRequest request, BlazeRpcContext context)
        {
            throw new GameManagerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameManager::cancelMatchmaking</b> command.<br/>
        /// Request type: <see cref="CancelMatchmakingRequest"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> CancelMatchmakingAsync(CancelMatchmakingRequest request, BlazeRpcContext context)
        {
            throw new GameManagerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameManager::finalizeGameCreation</b> command.<br/>
        /// Request type: <see cref="UpdateGameSessionRequest"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> FinalizeGameCreationAsync(UpdateGameSessionRequest request, BlazeRpcContext context)
        {
            throw new GameManagerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameManager::updateHostConnection</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> UpdateHostConnectionAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new GameManagerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameManager::listGames</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> ListGamesAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new GameManagerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameManager::setPlayerCustomData</b> command.<br/>
        /// Request type: <see cref="SetPlayerCustomDataRequest"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SetPlayerCustomDataAsync(SetPlayerCustomDataRequest request, BlazeRpcContext context)
        {
            throw new GameManagerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameManager::replayGame</b> command.<br/>
        /// Request type: <see cref="ReplayGameRequest"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> ReplayGameAsync(ReplayGameRequest request, BlazeRpcContext context)
        {
            throw new GameManagerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameManager::returnDedicatedServerToPool</b> command.<br/>
        /// Request type: <see cref="ReturnDedicatedServerToPoolRequest"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> ReturnDedicatedServerToPoolAsync(ReturnDedicatedServerToPoolRequest request, BlazeRpcContext context)
        {
            throw new GameManagerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameManager::joinGameByGroup</b> command.<br/>
        /// Request type: <see cref="JoinGameRequest"/><br/>
        /// Response type: <see cref="JoinGameResponse"/><br/>
        /// Error response type: <see cref="EntryCriteriaError"/><br/>
        /// </summary>
        public virtual Task<JoinGameResponse> JoinGameByGroupAsync(JoinGameRequest request, BlazeRpcContext context)
        {
            throw new GameManagerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameManager::leaveGameByGroup</b> command.<br/>
        /// Request type: <see cref="RemovePlayerRequest"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> LeaveGameByGroupAsync(RemovePlayerRequest request, BlazeRpcContext context)
        {
            throw new GameManagerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameManager::migrateGame</b> command.<br/>
        /// Request type: <see cref="MigrateHostRequest"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> MigrateGameAsync(MigrateHostRequest request, BlazeRpcContext context)
        {
            throw new GameManagerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameManager::resetDedicatedServer</b> command.<br/>
        /// Request type: <see cref="CreateGameRequest"/><br/>
        /// Response type: <see cref="JoinGameResponse"/><br/>
        /// </summary>
        public virtual Task<JoinGameResponse> ResetDedicatedServerAsync(CreateGameRequest request, BlazeRpcContext context)
        {
            throw new GameManagerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameManager::updateGameSession</b> command.<br/>
        /// Request type: <see cref="UpdateGameSessionRequest"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> UpdateGameSessionAsync(UpdateGameSessionRequest request, BlazeRpcContext context)
        {
            throw new GameManagerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameManager::banPlayer</b> command.<br/>
        /// Request type: <see cref="BanPlayerRequest"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> BanPlayerAsync(BanPlayerRequest request, BlazeRpcContext context)
        {
            throw new GameManagerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameManager::matchmakingDedicatedServerOverride</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> MatchmakingDedicatedServerOverrideAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new GameManagerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameManager::updateMeshConnection</b> command.<br/>
        /// Request type: <see cref="UpdateMeshConnectionRequest"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> UpdateMeshConnectionAsync(UpdateMeshConnectionRequest request, BlazeRpcContext context)
        {
            throw new GameManagerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameManager::joinGameByUserList</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> JoinGameByUserListAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new GameManagerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameManager::getGameListSnapshot</b> command.<br/>
        /// Request type: <see cref="GetGameListRequest"/><br/>
        /// Response type: <see cref="GetGameListResponse"/><br/>
        /// Error response type: <see cref="MatchmakingCriteriaError"/><br/>
        /// </summary>
        public virtual Task<GetGameListResponse> GetGameListSnapshotAsync(GetGameListRequest request, BlazeRpcContext context)
        {
            throw new GameManagerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameManager::getGameListSubscription</b> command.<br/>
        /// Request type: <see cref="GetGameListRequest"/><br/>
        /// Response type: <see cref="GetGameListResponse"/><br/>
        /// Error response type: <see cref="MatchmakingCriteriaError"/><br/>
        /// </summary>
        public virtual Task<GetGameListResponse> GetGameListSubscriptionAsync(GetGameListRequest request, BlazeRpcContext context)
        {
            throw new GameManagerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameManager::destroyGameList</b> command.<br/>
        /// Request type: <see cref="DestroyGameListRequest"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> DestroyGameListAsync(DestroyGameListRequest request, BlazeRpcContext context)
        {
            throw new GameManagerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameManager::getFullGameData</b> command.<br/>
        /// Request type: <see cref="GetFullGameDataRequest"/><br/>
        /// Response type: <see cref="GetFullGameDataResponse"/><br/>
        /// </summary>
        public virtual Task<GetFullGameDataResponse> GetFullGameDataAsync(GetFullGameDataRequest request, BlazeRpcContext context)
        {
            throw new GameManagerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameManager::getMatchmakingConfig</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="GetMatchmakingConfigResponse"/><br/>
        /// </summary>
        public virtual Task<GetMatchmakingConfigResponse> GetMatchmakingConfigAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new GameManagerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameManager::getGameDataFromId</b> command.<br/>
        /// Request type: <see cref="GetGameDataFromIdRequest"/><br/>
        /// Response type: <see cref="GameBrowserDataList"/><br/>
        /// </summary>
        public virtual Task<GameBrowserDataList> GetGameDataFromIdAsync(GetGameDataFromIdRequest request, BlazeRpcContext context)
        {
            throw new GameManagerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameManager::addAdminPlayer</b> command.<br/>
        /// Request type: <see cref="UpdateAdminListRequest"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> AddAdminPlayerAsync(UpdateAdminListRequest request, BlazeRpcContext context)
        {
            throw new GameManagerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameManager::removeAdminPlayer</b> command.<br/>
        /// Request type: <see cref="UpdateAdminListRequest"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> RemoveAdminPlayerAsync(UpdateAdminListRequest request, BlazeRpcContext context)
        {
            throw new GameManagerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameManager::setPlayerTeam</b> command.<br/>
        /// Request type: <see cref="SetPlayerTeamRequest"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SetPlayerTeamAsync(SetPlayerTeamRequest request, BlazeRpcContext context)
        {
            throw new GameManagerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameManager::changeGameTeamId</b> command.<br/>
        /// Request type: <see cref="ChangeTeamIdRequest"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> ChangeGameTeamIdAsync(ChangeTeamIdRequest request, BlazeRpcContext context)
        {
            throw new GameManagerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameManager::migrateAdminPlayer</b> command.<br/>
        /// Request type: <see cref="UpdateAdminListRequest"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> MigrateAdminPlayerAsync(UpdateAdminListRequest request, BlazeRpcContext context)
        {
            throw new GameManagerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameManager::registerDynamicDedicatedServerCreator</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> RegisterDynamicDedicatedServerCreatorAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new GameManagerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameManager::unregisterDynamicDedicatedServerCreator</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> UnregisterDynamicDedicatedServerCreatorAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new GameManagerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>GameManager::NotifyMatchmakingFinished</b> notification.<br/>
        /// Notification type: <see cref="NotifyMatchmakingFinished"/><br/>
        /// </summary>
        public static Task NotifyNotifyMatchmakingFinishedAsync(BlazeRpcConnection connection, NotifyMatchmakingFinished notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = GameManagerBase.Id;
                frame.Command = (ushort)GameManagerNotification.NotifyMatchmakingFinished;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>GameManager::NotifyMatchmakingAsyncStatus</b> notification.<br/>
        /// Notification type: <see cref="NotifyMatchmakingAsyncStatus"/><br/>
        /// </summary>
        public static Task NotifyNotifyMatchmakingAsyncStatusAsync(BlazeRpcConnection connection, NotifyMatchmakingAsyncStatus notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = GameManagerBase.Id;
                frame.Command = (ushort)GameManagerNotification.NotifyMatchmakingAsyncStatus;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>GameManager::NotifyGameCreated</b> notification.<br/>
        /// Notification type: <see cref="NotifyGameCreated"/><br/>
        /// </summary>
        public static Task NotifyNotifyGameCreatedAsync(BlazeRpcConnection connection, NotifyGameCreated notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = GameManagerBase.Id;
                frame.Command = (ushort)GameManagerNotification.NotifyGameCreated;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>GameManager::NotifyGameRemoved</b> notification.<br/>
        /// Notification type: <see cref="NotifyGameRemoved"/><br/>
        /// </summary>
        public static Task NotifyNotifyGameRemovedAsync(BlazeRpcConnection connection, NotifyGameRemoved notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = GameManagerBase.Id;
                frame.Command = (ushort)GameManagerNotification.NotifyGameRemoved;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>GameManager::NotifyJoinGame</b> notification.<br/>
        /// Notification type: <see cref="NotifyJoinGame"/><br/>
        /// </summary>
        public static Task NotifyNotifyJoinGameAsync(BlazeRpcConnection connection, NotifyJoinGame notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = GameManagerBase.Id;
                frame.Command = (ushort)GameManagerNotification.NotifyJoinGame;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>GameManager::NotifyPlayerJoining</b> notification.<br/>
        /// Notification type: <see cref="NotifyPlayerJoining"/><br/>
        /// </summary>
        public static Task NotifyNotifyPlayerJoiningAsync(BlazeRpcConnection connection, NotifyPlayerJoining notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = GameManagerBase.Id;
                frame.Command = (ushort)GameManagerNotification.NotifyPlayerJoining;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>GameManager::NotifyPlayerJoinCompleted</b> notification.<br/>
        /// Notification type: <see cref="NotifyPlayerJoinCompleted"/><br/>
        /// </summary>
        public static Task NotifyNotifyPlayerJoinCompletedAsync(BlazeRpcConnection connection, NotifyPlayerJoinCompleted notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = GameManagerBase.Id;
                frame.Command = (ushort)GameManagerNotification.NotifyPlayerJoinCompleted;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>GameManager::NotifyGroupPreJoinedGame</b> notification.<br/>
        /// Notification type: <see cref="NotifyGroupPreJoinedGame"/><br/>
        /// </summary>
        public static Task NotifyNotifyGroupPreJoinedGameAsync(BlazeRpcConnection connection, NotifyGroupPreJoinedGame notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = GameManagerBase.Id;
                frame.Command = (ushort)GameManagerNotification.NotifyGroupPreJoinedGame;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>GameManager::NotifyPlayerRemoved</b> notification.<br/>
        /// Notification type: <see cref="NotifyPlayerRemoved"/><br/>
        /// </summary>
        public static Task NotifyNotifyPlayerRemovedAsync(BlazeRpcConnection connection, NotifyPlayerRemoved notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = GameManagerBase.Id;
                frame.Command = (ushort)GameManagerNotification.NotifyPlayerRemoved;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>GameManager::NotifyQueueChanged</b> notification.<br/>
        /// Notification type: <see cref="NotifyQueueChanged"/><br/>
        /// </summary>
        public static Task NotifyNotifyQueueChangedAsync(BlazeRpcConnection connection, NotifyQueueChanged notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = GameManagerBase.Id;
                frame.Command = (ushort)GameManagerNotification.NotifyQueueChanged;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>GameManager::NotifyHostMigrationFinished</b> notification.<br/>
        /// Notification type: <see cref="NotifyHostMigrationFinished"/><br/>
        /// </summary>
        public static Task NotifyNotifyHostMigrationFinishedAsync(BlazeRpcConnection connection, NotifyHostMigrationFinished notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = GameManagerBase.Id;
                frame.Command = (ushort)GameManagerNotification.NotifyHostMigrationFinished;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>GameManager::NotifyHostMigrationStart</b> notification.<br/>
        /// Notification type: <see cref="NotifyHostMigrationStart"/><br/>
        /// </summary>
        public static Task NotifyNotifyHostMigrationStartAsync(BlazeRpcConnection connection, NotifyHostMigrationStart notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = GameManagerBase.Id;
                frame.Command = (ushort)GameManagerNotification.NotifyHostMigrationStart;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>GameManager::NotifyPlatformHostInitialized</b> notification.<br/>
        /// Notification type: <see cref="NotifyPlatformHostInitialized"/><br/>
        /// </summary>
        public static Task NotifyNotifyPlatformHostInitializedAsync(BlazeRpcConnection connection, NotifyPlatformHostInitialized notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = GameManagerBase.Id;
                frame.Command = (ushort)GameManagerNotification.NotifyPlatformHostInitialized;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>GameManager::NotifyGameAttribChange</b> notification.<br/>
        /// Notification type: <see cref="NotifyGameAttribChange"/><br/>
        /// </summary>
        public static Task NotifyNotifyGameAttribChangeAsync(BlazeRpcConnection connection, NotifyGameAttribChange notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = GameManagerBase.Id;
                frame.Command = (ushort)GameManagerNotification.NotifyGameAttribChange;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>GameManager::NotifyPlayerAttribChange</b> notification.<br/>
        /// Notification type: <see cref="NotifyPlayerAttribChange"/><br/>
        /// </summary>
        public static Task NotifyNotifyPlayerAttribChangeAsync(BlazeRpcConnection connection, NotifyPlayerAttribChange notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = GameManagerBase.Id;
                frame.Command = (ushort)GameManagerNotification.NotifyPlayerAttribChange;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>GameManager::NotifyPlayerCustomDataChange</b> notification.<br/>
        /// Notification type: <see cref="NotifyPlayerCustomDataChange"/><br/>
        /// </summary>
        public static Task NotifyNotifyPlayerCustomDataChangeAsync(BlazeRpcConnection connection, NotifyPlayerCustomDataChange notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = GameManagerBase.Id;
                frame.Command = (ushort)GameManagerNotification.NotifyPlayerCustomDataChange;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>GameManager::NotifyGameStateChange</b> notification.<br/>
        /// Notification type: <see cref="NotifyGameStateChange"/><br/>
        /// </summary>
        public static Task NotifyNotifyGameStateChangeAsync(BlazeRpcConnection connection, NotifyGameStateChange notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = GameManagerBase.Id;
                frame.Command = (ushort)GameManagerNotification.NotifyGameStateChange;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>GameManager::NotifyGameSettingsChange</b> notification.<br/>
        /// Notification type: <see cref="NotifyGameSettingsChange"/><br/>
        /// </summary>
        public static Task NotifyNotifyGameSettingsChangeAsync(BlazeRpcConnection connection, NotifyGameSettingsChange notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = GameManagerBase.Id;
                frame.Command = (ushort)GameManagerNotification.NotifyGameSettingsChange;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>GameManager::NotifyGameCapacityChange</b> notification.<br/>
        /// Notification type: <see cref="NotifyGameCapacityChange"/><br/>
        /// </summary>
        public static Task NotifyNotifyGameCapacityChangeAsync(BlazeRpcConnection connection, NotifyGameCapacityChange notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = GameManagerBase.Id;
                frame.Command = (ushort)GameManagerNotification.NotifyGameCapacityChange;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>GameManager::NotifyGameReset</b> notification.<br/>
        /// Notification type: <see cref="NotifyGameReset"/><br/>
        /// </summary>
        public static Task NotifyNotifyGameResetAsync(BlazeRpcConnection connection, NotifyGameReset notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = GameManagerBase.Id;
                frame.Command = (ushort)GameManagerNotification.NotifyGameReset;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>GameManager::NotifyGameReportingIdChange</b> notification.<br/>
        /// Notification type: <see cref="NotifyGameReportingIdChange"/><br/>
        /// </summary>
        public static Task NotifyNotifyGameReportingIdChangeAsync(BlazeRpcConnection connection, NotifyGameReportingIdChange notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = GameManagerBase.Id;
                frame.Command = (ushort)GameManagerNotification.NotifyGameReportingIdChange;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>GameManager::NotifyGameSessionUpdated</b> notification.<br/>
        /// Notification type: <see cref="GameSessionUpdatedNotification"/><br/>
        /// </summary>
        public static Task NotifyNotifyGameSessionUpdatedAsync(BlazeRpcConnection connection, GameSessionUpdatedNotification notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = GameManagerBase.Id;
                frame.Command = (ushort)GameManagerNotification.NotifyGameSessionUpdated;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>GameManager::NotifyGamePlayerStateChange</b> notification.<br/>
        /// Notification type: <see cref="NotifyGamePlayerStateChange"/><br/>
        /// </summary>
        public static Task NotifyNotifyGamePlayerStateChangeAsync(BlazeRpcConnection connection, NotifyGamePlayerStateChange notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = GameManagerBase.Id;
                frame.Command = (ushort)GameManagerNotification.NotifyGamePlayerStateChange;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>GameManager::NotifyGamePlayerTeamChange</b> notification.<br/>
        /// Notification type: <see cref="NotifyGamePlayerTeamChange"/><br/>
        /// </summary>
        public static Task NotifyNotifyGamePlayerTeamChangeAsync(BlazeRpcConnection connection, NotifyGamePlayerTeamChange notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = GameManagerBase.Id;
                frame.Command = (ushort)GameManagerNotification.NotifyGamePlayerTeamChange;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>GameManager::NotifyGameTeamIdChange</b> notification.<br/>
        /// Notification type: <see cref="NotifyGameTeamIdChange"/><br/>
        /// </summary>
        public static Task NotifyNotifyGameTeamIdChangeAsync(BlazeRpcConnection connection, NotifyGameTeamIdChange notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = GameManagerBase.Id;
                frame.Command = (ushort)GameManagerNotification.NotifyGameTeamIdChange;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>GameManager::NotifyGameListUpdate</b> notification.<br/>
        /// Notification type: <see cref="NotifyGameListUpdate"/><br/>
        /// </summary>
        public static Task NotifyNotifyGameListUpdateAsync(BlazeRpcConnection connection, NotifyGameListUpdate notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = GameManagerBase.Id;
                frame.Command = (ushort)GameManagerNotification.NotifyGameListUpdate;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>GameManager::NotifyAdminListChange</b> notification.<br/>
        /// Notification type: <see cref="NotifyAdminListChange"/><br/>
        /// </summary>
        public static Task NotifyNotifyAdminListChangeAsync(BlazeRpcConnection connection, NotifyAdminListChange notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = GameManagerBase.Id;
                frame.Command = (ushort)GameManagerNotification.NotifyAdminListChange;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>GameManager::NotifyCreateDynamicDedicatedServerGame</b> notification.<br/>
        /// Notification type: <see cref="NotifyCreateDynamicDedicatedServerGame"/><br/>
        /// </summary>
        public static Task NotifyNotifyCreateDynamicDedicatedServerGameAsync(BlazeRpcConnection connection, NotifyCreateDynamicDedicatedServerGame notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = GameManagerBase.Id;
                frame.Command = (ushort)GameManagerNotification.NotifyCreateDynamicDedicatedServerGame;
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

