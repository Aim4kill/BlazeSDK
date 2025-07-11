using Blaze.Core;
using Blaze3SDK.Blaze.GameManager;
using EATDF;
using EATDF.Types;

namespace Blaze3SDK.Components;

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
        GAMEMANAGER_ERR_SLOT_OCCUPIED = 14,
        GAMEMANAGER_ERR_NOT_VIRTUAL_GAME = 15,
        GAMEMANAGER_ERR_NOT_TOPOLOGY_HOST = 16,
        GAMEMANAGER_ERR_PERMISSION_DENIED = 30,
        GAMEMANAGER_ERR_ALREADY_ADMIN = 31,
        GAMEMANAGER_ERR_NOT_IN_ADMIN_LIST = 32,
        GAMEMANAGER_ERR_DEDICATED_SERVER_HOST = 33,
        GAMEMANAGER_ERR_INVALID_QUEUE_METHOD = 50,
        GAMEMANAGER_ERR_PLAYER_NOT_IN_QUEUE = 51,
        GAMEMANAGER_ERR_DEQUEUE_WHILE_MIGRATING = 52,
        GAMEMANAGER_ERR_DEQUEUE_WHILE_IN_PROGRESS = 53,
        GAMEMANAGER_ERR_PLAYER_NOT_FOUND = 101,
        GAMEMANAGER_ERR_ALREADY_GAME_MEMBER = 103,
        GAMEMANAGER_ERR_REMOVE_PLAYER_FAILED = 104,
        GAMEMANAGER_ERR_INVALID_PLAYER_PASSEDIN = 107,
        GAMEMANAGER_ERR_JOIN_PLAYER_FAILED = 108,
        GAMEMANAGER_ERR_PLAYER_BANNED = 110,
        GAMEMANAGER_ERR_GAME_ENTRY_CRITERIA_FAILED = 111,
        GAMEMANAGER_ERR_ALREADY_IN_QUEUE = 112,
        GAMEMANAGER_ERR_ENFORCING_SINGLE_GROUP_JOINS = 113,
        GAMEMANAGER_ERR_BANNED_PLAYER_NOT_FOUND = 114,
        GAMEMANAGER_ERR_BANNED_LIST_MAX = 115,
        GAMEMANAGER_ERR_RESERVATION_ALREADY_EXISTS = 120,
        GAMEMANAGER_ERR_NO_RESERVATION_FOUND = 121,
        GAMEMANAGER_ERR_INVALID_GAME_ENTRY_TYPE = 122,
        GAMEMANAGER_ERR_INVALID_GROUP_ID = 151,
        GAMEMANAGER_ERR_PLAYER_NOT_IN_GROUP = 152,
        GAMEMANAGER_ERR_INVALID_MATCHMAKING_CRITERIA = 200,
        GAMEMANAGER_ERR_UNKNOWN_MATCHMAKING_SESSION_ID = 201,
        GAMEMANAGER_ERR_NOT_MATCHMAKING_SESSION_OWNER = 202,
        GAMEMANAGER_ERR_MATCHMAKING_NO_JOINABLE_GAMES = 203,
        GAMEMANAGER_ERR_MATCHMAKING_USERSESSION_NOT_FOUND = 205,
        GAMEMANAGER_ERR_MATCHMAKING_EXCEEDED_MAX_REQUESTS = 206,
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
        GAMEMANAGER_ERR_INVALID_TEAM_CAPACITY = 257,
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
        GAMEBROWSER_ERR_CANNOT_GET_USERSET = 406,
        GAMEMANAGER_ERR_GAME_CAPACITY_TOO_SMALL = 502,
        GAMEMANAGER_ERR_INVALID_ACTION_FOR_GROUP = 503,
        GAMEMANAGER_ERR_NOT_PLATFORM_HOST = 504,
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
            
            RegisterCommand(new RpcCommandFunc<SetPresenceModeRequest, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameManagerCommand.setPresenceMode,
                Name = "setPresenceMode",
                IsSupported = IsCommandSupported(GameManagerCommand.setPresenceMode),
                Func = async (req, ctx) => await SetPresenceModeAsync(req, ctx).ConfigureAwait(false)
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
            
            RegisterCommand(new RpcCommandFunc<JoinGameRequest, JoinGameResponse, EmptyMessage>()
            {
                Id = (ushort)GameManagerCommand.joinGame,
                Name = "joinGame",
                IsSupported = IsCommandSupported(GameManagerCommand.joinGame),
                Func = async (req, ctx) => await JoinGameAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<RemovePlayerRequest, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameManagerCommand.removePlayer,
                Name = "removePlayer",
                IsSupported = IsCommandSupported(GameManagerCommand.removePlayer),
                Func = async (req, ctx) => await RemovePlayerAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<StartMatchmakingRequest, StartMatchmakingResponse, EmptyMessage>()
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
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, ListGamesResponse, EmptyMessage>()
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
            
            RegisterCommand(new RpcCommandFunc<JoinGameRequest, EmptyMessage, EmptyMessage>()
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
            
            RegisterCommand(new RpcCommandFunc<UpdateGameHostMigrationStatusRequest, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameManagerCommand.updateGameHostMigrationStatus,
                Name = "updateGameHostMigrationStatus",
                IsSupported = IsCommandSupported(GameManagerCommand.updateGameHostMigrationStatus),
                Func = async (req, ctx) => await UpdateGameHostMigrationStatusAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<CreateGameRequest, EmptyMessage, EmptyMessage>()
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
            
            RegisterCommand(new RpcCommandFunc<UpdateMeshConnectionRequest, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameManagerCommand.updateMeshConnection,
                Name = "updateMeshConnection",
                IsSupported = IsCommandSupported(GameManagerCommand.updateMeshConnection),
                Func = async (req, ctx) => await UpdateMeshConnectionAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<RemovePlayerFromBannedListRequest, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameManagerCommand.removePlayerFromBannedList,
                Name = "removePlayerFromBannedList",
                IsSupported = IsCommandSupported(GameManagerCommand.removePlayerFromBannedList),
                Func = async (req, ctx) => await RemovePlayerFromBannedListAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<BannedListRequest, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameManagerCommand.clearBannedList,
                Name = "clearBannedList",
                IsSupported = IsCommandSupported(GameManagerCommand.clearBannedList),
                Func = async (req, ctx) => await ClearBannedListAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<BannedListRequest, BannedListResponse, EmptyMessage>()
            {
                Id = (ushort)GameManagerCommand.getBannedList,
                Name = "getBannedList",
                IsSupported = IsCommandSupported(GameManagerCommand.getBannedList),
                Func = async (req, ctx) => await GetBannedListAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<AddQueuedPlayerToGameRequest, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameManagerCommand.addQueuedPlayerToGame,
                Name = "addQueuedPlayerToGame",
                IsSupported = IsCommandSupported(GameManagerCommand.addQueuedPlayerToGame),
                Func = async (req, ctx) => await AddQueuedPlayerToGameAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<UpdateGameNameRequest, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameManagerCommand.updateGameName,
                Name = "updateGameName",
                IsSupported = IsCommandSupported(GameManagerCommand.updateGameName),
                Func = async (req, ctx) => await UpdateGameNameAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EjectHostRequest, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameManagerCommand.ejectHost,
                Name = "ejectHost",
                IsSupported = IsCommandSupported(GameManagerCommand.ejectHost),
                Func = async (req, ctx) => await EjectHostAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<GetGameListRequest, GetGameListResponse, EmptyMessage>()
            {
                Id = (ushort)GameManagerCommand.getGameListSnapshot,
                Name = "getGameListSnapshot",
                IsSupported = IsCommandSupported(GameManagerCommand.getGameListSnapshot),
                Func = async (req, ctx) => await GetGameListSnapshotAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<GetGameListRequest, GetGameListResponse, EmptyMessage>()
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
            
            RegisterCommand(new RpcCommandFunc<GetGameDataFromIdRequest, EmptyMessage, EmptyMessage>()
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
            
            RegisterCommand(new RpcCommandFunc<GetUserSetGameListSubscriptionRequest, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameManagerCommand.getUserSetGameListSubscription,
                Name = "getUserSetGameListSubscription",
                IsSupported = IsCommandSupported(GameManagerCommand.getUserSetGameListSubscription),
                Func = async (req, ctx) => await GetUserSetGameListSubscriptionAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<SwapPlayersTeamRequest, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)GameManagerCommand.swapPlayersTeam,
                Name = "swapPlayersTeam",
                IsSupported = IsCommandSupported(GameManagerCommand.swapPlayersTeam),
                Func = async (req, ctx) => await SwapPlayersTeamAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<RegisterDynamicDedicatedServerCreatorRequest, RegisterDynamicDedicatedServerCreatorResponse, EmptyMessage>()
            {
                Id = (ushort)GameManagerCommand.registerDynamicDedicatedServerCreator,
                Name = "registerDynamicDedicatedServerCreator",
                IsSupported = IsCommandSupported(GameManagerCommand.registerDynamicDedicatedServerCreator),
                Func = async (req, ctx) => await RegisterDynamicDedicatedServerCreatorAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<UnregisterDynamicDedicatedServerCreatorRequest, UnregisterDynamicDedicatedServerCreatorResponse, EmptyMessage>()
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
        /// This method is called when server receives a <b>GameManager::setPresenceMode</b> command.<br/>
        /// Request type: <see cref="SetPresenceModeRequest"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SetPresenceModeAsync(SetPresenceModeRequest request, BlazeRpcContext context)
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
        /// </summary>
        public virtual Task<JoinGameResponse> JoinGameAsync(JoinGameRequest request, BlazeRpcContext context)
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
        /// This method is called when server receives a <b>GameManager::listGames</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="ListGamesResponse"/><br/>
        /// </summary>
        public virtual Task<ListGamesResponse> ListGamesAsync(EmptyMessage request, BlazeRpcContext context)
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
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> JoinGameByGroupAsync(JoinGameRequest request, BlazeRpcContext context)
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
        /// This method is called when server receives a <b>GameManager::updateGameHostMigrationStatus</b> command.<br/>
        /// Request type: <see cref="UpdateGameHostMigrationStatusRequest"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> UpdateGameHostMigrationStatusAsync(UpdateGameHostMigrationStatusRequest request, BlazeRpcContext context)
        {
            throw new GameManagerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameManager::resetDedicatedServer</b> command.<br/>
        /// Request type: <see cref="CreateGameRequest"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> ResetDedicatedServerAsync(CreateGameRequest request, BlazeRpcContext context)
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
        /// This method is called when server receives a <b>GameManager::updateMeshConnection</b> command.<br/>
        /// Request type: <see cref="UpdateMeshConnectionRequest"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> UpdateMeshConnectionAsync(UpdateMeshConnectionRequest request, BlazeRpcContext context)
        {
            throw new GameManagerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameManager::removePlayerFromBannedList</b> command.<br/>
        /// Request type: <see cref="RemovePlayerFromBannedListRequest"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> RemovePlayerFromBannedListAsync(RemovePlayerFromBannedListRequest request, BlazeRpcContext context)
        {
            throw new GameManagerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameManager::clearBannedList</b> command.<br/>
        /// Request type: <see cref="BannedListRequest"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> ClearBannedListAsync(BannedListRequest request, BlazeRpcContext context)
        {
            throw new GameManagerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameManager::getBannedList</b> command.<br/>
        /// Request type: <see cref="BannedListRequest"/><br/>
        /// Response type: <see cref="BannedListResponse"/><br/>
        /// </summary>
        public virtual Task<BannedListResponse> GetBannedListAsync(BannedListRequest request, BlazeRpcContext context)
        {
            throw new GameManagerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameManager::addQueuedPlayerToGame</b> command.<br/>
        /// Request type: <see cref="AddQueuedPlayerToGameRequest"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> AddQueuedPlayerToGameAsync(AddQueuedPlayerToGameRequest request, BlazeRpcContext context)
        {
            throw new GameManagerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameManager::updateGameName</b> command.<br/>
        /// Request type: <see cref="UpdateGameNameRequest"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> UpdateGameNameAsync(UpdateGameNameRequest request, BlazeRpcContext context)
        {
            throw new GameManagerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameManager::ejectHost</b> command.<br/>
        /// Request type: <see cref="EjectHostRequest"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> EjectHostAsync(EjectHostRequest request, BlazeRpcContext context)
        {
            throw new GameManagerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameManager::getGameListSnapshot</b> command.<br/>
        /// Request type: <see cref="GetGameListRequest"/><br/>
        /// Response type: <see cref="GetGameListResponse"/><br/>
        /// </summary>
        public virtual Task<GetGameListResponse> GetGameListSnapshotAsync(GetGameListRequest request, BlazeRpcContext context)
        {
            throw new GameManagerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameManager::getGameListSubscription</b> command.<br/>
        /// Request type: <see cref="GetGameListRequest"/><br/>
        /// Response type: <see cref="GetGameListResponse"/><br/>
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
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetGameDataFromIdAsync(GetGameDataFromIdRequest request, BlazeRpcContext context)
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
        /// This method is called when server receives a <b>GameManager::getUserSetGameListSubscription</b> command.<br/>
        /// Request type: <see cref="GetUserSetGameListSubscriptionRequest"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetUserSetGameListSubscriptionAsync(GetUserSetGameListSubscriptionRequest request, BlazeRpcContext context)
        {
            throw new GameManagerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameManager::swapPlayersTeam</b> command.<br/>
        /// Request type: <see cref="SwapPlayersTeamRequest"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SwapPlayersTeamAsync(SwapPlayersTeamRequest request, BlazeRpcContext context)
        {
            throw new GameManagerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameManager::registerDynamicDedicatedServerCreator</b> command.<br/>
        /// Request type: <see cref="RegisterDynamicDedicatedServerCreatorRequest"/><br/>
        /// Response type: <see cref="RegisterDynamicDedicatedServerCreatorResponse"/><br/>
        /// </summary>
        public virtual Task<RegisterDynamicDedicatedServerCreatorResponse> RegisterDynamicDedicatedServerCreatorAsync(RegisterDynamicDedicatedServerCreatorRequest request, BlazeRpcContext context)
        {
            throw new GameManagerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>GameManager::unregisterDynamicDedicatedServerCreator</b> command.<br/>
        /// Request type: <see cref="UnregisterDynamicDedicatedServerCreatorRequest"/><br/>
        /// Response type: <see cref="UnregisterDynamicDedicatedServerCreatorResponse"/><br/>
        /// </summary>
        public virtual Task<UnregisterDynamicDedicatedServerCreatorResponse> UnregisterDynamicDedicatedServerCreatorAsync(UnregisterDynamicDedicatedServerCreatorRequest request, BlazeRpcContext context)
        {
            throw new GameManagerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>GameManager::NotifyMatchmakingFailed</b> notification.<br/>
        /// Notification type: <see cref="NotifyMatchmakingFailed"/><br/>
        /// </summary>
        public static Task NotifyNotifyMatchmakingFailedAsync(BlazeRpcConnection connection, NotifyMatchmakingFailed notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = GameManagerBase.Id;
                frame.Command = (ushort)GameManagerNotification.NotifyMatchmakingFailed;
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
        /// Call this method when you want to send to client a <b>GameManager::NotifyGameSetup</b> notification.<br/>
        /// Notification type: <see cref="NotifyGameSetup"/><br/>
        /// </summary>
        public static Task NotifyNotifyGameSetupAsync(BlazeRpcConnection connection, NotifyGameSetup notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = GameManagerBase.Id;
                frame.Command = (ushort)GameManagerNotification.NotifyGameSetup;
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
        /// Call this method when you want to send to client a <b>GameManager::NotifyJoiningPlayerInitiateConnections</b> notification.<br/>
        /// Notification type: <see cref="NotifyGameSetup"/><br/>
        /// </summary>
        public static Task NotifyNotifyJoiningPlayerInitiateConnectionsAsync(BlazeRpcConnection connection, NotifyGameSetup notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = GameManagerBase.Id;
                frame.Command = (ushort)GameManagerNotification.NotifyJoiningPlayerInitiateConnections;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>GameManager::NotifyPlayerJoiningQueue</b> notification.<br/>
        /// Notification type: <see cref="NotifyPlayerJoining"/><br/>
        /// </summary>
        public static Task NotifyNotifyPlayerJoiningQueueAsync(BlazeRpcConnection connection, NotifyPlayerJoining notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = GameManagerBase.Id;
                frame.Command = (ushort)GameManagerNotification.NotifyPlayerJoiningQueue;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>GameManager::NotifyPlayerPromotedFromQueue</b> notification.<br/>
        /// Notification type: <see cref="NotifyPlayerJoining"/><br/>
        /// </summary>
        public static Task NotifyNotifyPlayerPromotedFromQueueAsync(BlazeRpcConnection connection, NotifyPlayerJoining notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = GameManagerBase.Id;
                frame.Command = (ushort)GameManagerNotification.NotifyPlayerPromotedFromQueue;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>GameManager::NotifyPlayerClaimingReservation</b> notification.<br/>
        /// Notification type: <see cref="NotifyPlayerJoining"/><br/>
        /// </summary>
        public static Task NotifyNotifyPlayerClaimingReservationAsync(BlazeRpcConnection connection, NotifyPlayerJoining notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = GameManagerBase.Id;
                frame.Command = (ushort)GameManagerNotification.NotifyPlayerClaimingReservation;
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
        /// Call this method when you want to send to client a <b>GameManager::NotifyProcessQueue</b> notification.<br/>
        /// Notification type: <see cref="NotifyProcessQueue"/><br/>
        /// </summary>
        public static Task NotifyNotifyProcessQueueAsync(BlazeRpcConnection connection, NotifyProcessQueue notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = GameManagerBase.Id;
                frame.Command = (ushort)GameManagerNotification.NotifyProcessQueue;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>GameManager::NotifyPresenceModeChanged</b> notification.<br/>
        /// Notification type: <see cref="NotifyPresenceModeChanged"/><br/>
        /// </summary>
        public static Task NotifyNotifyPresenceModeChangedAsync(BlazeRpcConnection connection, NotifyPresenceModeChanged notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = GameManagerBase.Id;
                frame.Command = (ushort)GameManagerNotification.NotifyPresenceModeChanged;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>GameManager::NotifyGamePlayerQueuePositionChange</b> notification.<br/>
        /// Notification type: <see cref="NotifyGamePlayerQueuePositionChange"/><br/>
        /// </summary>
        public static Task NotifyNotifyGamePlayerQueuePositionChangeAsync(BlazeRpcConnection connection, NotifyGamePlayerQueuePositionChange notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = GameManagerBase.Id;
                frame.Command = (ushort)GameManagerNotification.NotifyGamePlayerQueuePositionChange;
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
        
        /// <summary>
        /// Call this method when you want to send to client a <b>GameManager::NotifyGameNameChange</b> notification.<br/>
        /// Notification type: <see cref="NotifyGameNameChange"/><br/>
        /// </summary>
        public static Task NotifyNotifyGameNameChangeAsync(BlazeRpcConnection connection, NotifyGameNameChange notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = GameManagerBase.Id;
                frame.Command = (ushort)GameManagerNotification.NotifyGameNameChange;
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

