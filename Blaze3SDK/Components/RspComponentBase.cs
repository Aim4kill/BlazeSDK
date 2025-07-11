using Blaze.Core;
using Blaze3SDK.Blaze.Rsp;
using EATDF;
using EATDF.Types;

namespace Blaze3SDK.Components;

public static class RspComponentBase
{
    public const ushort Id = 2049;
    public const string Name = "RspComponent";
    
    public enum Error : ushort {
        RSP_ERR_NO_GAMEMANAGER = 1,
        RSP_ERR_INVALID_USER_ID = 2,
        RSP_ERR_INVALID_SERVER_ID = 3,
        RSP_ERR_INVALID_CONSUMABLE_ID = 4,
        RSP_ERR_INVALID_PURCHASE_ID = 5,
        RSP_ERR_INVALID_PURCHASE_STATUS = 6,
        RSP_ERR_INVALID_PURCHASE_QUANTITY = 7,
        RSP_ERR_PURCHASE_EXISTS = 8,
        RSP_ERR_SERVER_NOT_ACTIVATED = 9,
        RSP_ERR_SERVER_HAS_EXPIRED = 10,
        RSP_ERR_SERVER_NOT_EXTANDABLE = 11,
        RSP_ERR_INVALID_PRESET_ID = 12,
        RSP_ERR_INVALID_PING_SITE_ALIAS = 13,
        RSP_ERR_INVALID_SERVER_NAME_PROFANITY = 14,
        RSP_ERR_INVALID_SERVER_DESCRIPTION_PROFANITY = 15,
        RSP_ERR_INVALID_SERVER_MESSAGE_PROFANITY = 16,
        RSP_ERR_INVALID_SERVER_PASSWORD_PROFANITY = 17,
        RSP_ERR_INVALID_SERVER_PRESET_TYPE = 18,
        RSP_ERR_INVALID_SERVER_PRESET_SETTINGS = 19,
        RSP_ERR_USER_IS_ALREADY_ADMIN = 20,
        RSP_ERR_USER_IS_NOT_ADMIN = 21,
        RSP_ERR_USER_ADMIN_MAX = 22,
        RSP_ERR_SERVER_ADMIN_MAX = 23,
        RSP_ERR_NO_VIRTUAL_GAME = 24,
        RSP_ERR_USER_IS_ALREADY_BANNED = 25,
        RSP_ERR_USER_IS_NOT_BANNED = 26,
        RSP_ERR_USER_CANNOT_BE_BANNED = 27,
        RSP_ERR_SERVER_BAN_MAX = 28,
        RSP_ERR_GAME_UPDATE_FAILED = 29,
        RSP_ERR_INVALID_GAME_ID = 30,
        RSP_ERR_INVALID_PERSISTED_GAME_ID = 31,
        RSP_ERR_INVALID_MAP_ROTATION_ID = 32,
        RSP_ERR_INVALID_MAP_ROTATION_MOD = 33,
        RSP_ERR_INVALID_MAP_ROTATION_ENTRIES = 34,
        RSP_ERR_INVALID_MAP_ROTATION_SETTINGS = 35,
        RSP_ERR_PING_SITE_CAPACITY_MAX = 36,
        RSP_ERR_SERVER_NOT_RESTARTABLE = 37,
        RSP_ERR_INVALID_BANNER_ID = 38,
        RSP_ERR_USER_IS_ALREADY_VIP = 39,
        RSP_ERR_USER_IS_NOT_VIP = 40,
        RSP_ERR_SERVER_VIP_MAX = 41,
        RSP_ERR_INVALID_EXPIRATION_DATE = 42,
        RSP_ERR_INVALID_SLAVE_SESSION_ID = 43,
        RSP_ERR_USER_OWNER_MAX = 44,
        RSP_ERR_INVALID_SERVER_NAME = 45,
        RSP_ERR_INVALID_PRESET_FOR_RANKED_SERVER = 46,
        RSP_ERR_NO_PASSWORD_FOR_PRIVATE_SERVER = 47,
        RSP_ERR_MATCH_ALREADY_RUNNING = 48,
        RSP_ERR_MATCH_NOT_RUNNING = 49,
        RSP_ERR_MATCH_EXPIRATION_DATE_PASSED = 50,
        RSP_ERR_MATCH_EMPTY_ROSTER = 51,
        RSP_ERR_MATCH_ROSTER_TOO_BIG = 52,
        RSP_ERR_INVALID_MATCH_ID = 53,
        RSP_ERR_WRONG_MATCH_ID = 54,
        RSP_ERR_INVALID_SERVER_PRESET_NAME_PROFANITY = 55,
        RSP_ERR_INVALID_MAP_ROTATION_NAME_PROFANITY = 56,
        RSP_ERR_INVALID_GAME_STATE_ACTION = 57,
        RSP_ERR_GAME_PERMISSION_DENIED = 58,
        RSP_ERR_INVALID_ACTIVE_PRESET_FOR_RANKED_SERVER = 59,
        RSP_ERR_SERVER_RANKED = 60,
        RSP_ERR_MATCH_RUNNING = 61,
    }
    
    public enum RspComponentCommand : ushort
    {
        startPurchase = 10,
        updatePurchase = 11,
        finishPurchase = 12,
        listPurchases = 15,
        listServers = 20,
        getServerDetails = 21,
        restartServer = 23,
        updateServerBanner = 24,
        updateServerSettings = 25,
        updateServerPreset = 26,
        updateServerMapRotation = 27,
        addServerAdmin = 31,
        removeServerAdmin = 32,
        addServerBan = 33,
        removeServerBan = 34,
        addServerVip = 35,
        removeServerVip = 36,
        getConfig = 50,
        getPingSites = 51,
        getGameData = 60,
        addGameBan = 61,
        createServer = 70,
        updateServer = 71,
        listAllServers = 72,
        startMatch = 80,
        abortMatch = 81,
        endMatch = 82,
    }
    
    public enum RspComponentNotification : ushort
    {
    }
    
    public class Server : BlazeComponent {
        public override ushort Id => RspComponentBase.Id;
        public override string Name => RspComponentBase.Name;
        
        public virtual bool IsCommandSupported(RspComponentCommand command) => false;
        
        public class RspException : BlazeRpcException
        {
            public RspException(Error error) : base((ushort)error, null) { }
            public RspException(ServerError error) : base(error.WithErrorPrefix(), null) { }
            public RspException(Error error, Tdf? errorResponse) : base((ushort)error, errorResponse) { }
            public RspException(ServerError error, Tdf? errorResponse) : base(error.WithErrorPrefix(), errorResponse) { }
            public RspException(Error error, Tdf? errorResponse, string? message) : base((ushort)error, errorResponse, message) { }
            public RspException(ServerError error, Tdf? errorResponse, string? message) : base(error.WithErrorPrefix(), errorResponse, message) { }
            public RspException(Error error, Tdf? errorResponse, string? message, Exception? innerException) : base((ushort)error, errorResponse, message, innerException) { }
            public RspException(ServerError error, Tdf? errorResponse, string? message, Exception? innerException) : base(error.WithErrorPrefix(), errorResponse, message, innerException) { }
        }
        
        public Server()
        {
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RspComponentCommand.startPurchase,
                Name = "startPurchase",
                IsSupported = IsCommandSupported(RspComponentCommand.startPurchase),
                Func = async (req, ctx) => await StartPurchaseAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RspComponentCommand.updatePurchase,
                Name = "updatePurchase",
                IsSupported = IsCommandSupported(RspComponentCommand.updatePurchase),
                Func = async (req, ctx) => await UpdatePurchaseAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RspComponentCommand.finishPurchase,
                Name = "finishPurchase",
                IsSupported = IsCommandSupported(RspComponentCommand.finishPurchase),
                Func = async (req, ctx) => await FinishPurchaseAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RspComponentCommand.listPurchases,
                Name = "listPurchases",
                IsSupported = IsCommandSupported(RspComponentCommand.listPurchases),
                Func = async (req, ctx) => await ListPurchasesAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RspComponentCommand.listServers,
                Name = "listServers",
                IsSupported = IsCommandSupported(RspComponentCommand.listServers),
                Func = async (req, ctx) => await ListServersAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RspComponentCommand.getServerDetails,
                Name = "getServerDetails",
                IsSupported = IsCommandSupported(RspComponentCommand.getServerDetails),
                Func = async (req, ctx) => await GetServerDetailsAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RspComponentCommand.restartServer,
                Name = "restartServer",
                IsSupported = IsCommandSupported(RspComponentCommand.restartServer),
                Func = async (req, ctx) => await RestartServerAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RspComponentCommand.updateServerBanner,
                Name = "updateServerBanner",
                IsSupported = IsCommandSupported(RspComponentCommand.updateServerBanner),
                Func = async (req, ctx) => await UpdateServerBannerAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RspComponentCommand.updateServerSettings,
                Name = "updateServerSettings",
                IsSupported = IsCommandSupported(RspComponentCommand.updateServerSettings),
                Func = async (req, ctx) => await UpdateServerSettingsAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RspComponentCommand.updateServerPreset,
                Name = "updateServerPreset",
                IsSupported = IsCommandSupported(RspComponentCommand.updateServerPreset),
                Func = async (req, ctx) => await UpdateServerPresetAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RspComponentCommand.updateServerMapRotation,
                Name = "updateServerMapRotation",
                IsSupported = IsCommandSupported(RspComponentCommand.updateServerMapRotation),
                Func = async (req, ctx) => await UpdateServerMapRotationAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RspComponentCommand.addServerAdmin,
                Name = "addServerAdmin",
                IsSupported = IsCommandSupported(RspComponentCommand.addServerAdmin),
                Func = async (req, ctx) => await AddServerAdminAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RspComponentCommand.removeServerAdmin,
                Name = "removeServerAdmin",
                IsSupported = IsCommandSupported(RspComponentCommand.removeServerAdmin),
                Func = async (req, ctx) => await RemoveServerAdminAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RspComponentCommand.addServerBan,
                Name = "addServerBan",
                IsSupported = IsCommandSupported(RspComponentCommand.addServerBan),
                Func = async (req, ctx) => await AddServerBanAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RspComponentCommand.removeServerBan,
                Name = "removeServerBan",
                IsSupported = IsCommandSupported(RspComponentCommand.removeServerBan),
                Func = async (req, ctx) => await RemoveServerBanAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RspComponentCommand.addServerVip,
                Name = "addServerVip",
                IsSupported = IsCommandSupported(RspComponentCommand.addServerVip),
                Func = async (req, ctx) => await AddServerVipAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RspComponentCommand.removeServerVip,
                Name = "removeServerVip",
                IsSupported = IsCommandSupported(RspComponentCommand.removeServerVip),
                Func = async (req, ctx) => await RemoveServerVipAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, GetConfigResponse, EmptyMessage>()
            {
                Id = (ushort)RspComponentCommand.getConfig,
                Name = "getConfig",
                IsSupported = IsCommandSupported(RspComponentCommand.getConfig),
                Func = async (req, ctx) => await GetConfigAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RspComponentCommand.getPingSites,
                Name = "getPingSites",
                IsSupported = IsCommandSupported(RspComponentCommand.getPingSites),
                Func = async (req, ctx) => await GetPingSitesAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RspComponentCommand.getGameData,
                Name = "getGameData",
                IsSupported = IsCommandSupported(RspComponentCommand.getGameData),
                Func = async (req, ctx) => await GetGameDataAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RspComponentCommand.addGameBan,
                Name = "addGameBan",
                IsSupported = IsCommandSupported(RspComponentCommand.addGameBan),
                Func = async (req, ctx) => await AddGameBanAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RspComponentCommand.createServer,
                Name = "createServer",
                IsSupported = IsCommandSupported(RspComponentCommand.createServer),
                Func = async (req, ctx) => await CreateServerAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RspComponentCommand.updateServer,
                Name = "updateServer",
                IsSupported = IsCommandSupported(RspComponentCommand.updateServer),
                Func = async (req, ctx) => await UpdateServerAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RspComponentCommand.listAllServers,
                Name = "listAllServers",
                IsSupported = IsCommandSupported(RspComponentCommand.listAllServers),
                Func = async (req, ctx) => await ListAllServersAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RspComponentCommand.startMatch,
                Name = "startMatch",
                IsSupported = IsCommandSupported(RspComponentCommand.startMatch),
                Func = async (req, ctx) => await StartMatchAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RspComponentCommand.abortMatch,
                Name = "abortMatch",
                IsSupported = IsCommandSupported(RspComponentCommand.abortMatch),
                Func = async (req, ctx) => await AbortMatchAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RspComponentCommand.endMatch,
                Name = "endMatch",
                IsSupported = IsCommandSupported(RspComponentCommand.endMatch),
                Func = async (req, ctx) => await EndMatchAsync(req, ctx).ConfigureAwait(false)
            });
            
        }
        
        public override string GetErrorName(ushort errorCode)
        {
            return ((Error)errorCode).ToString();
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RspComponent::startPurchase</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> StartPurchaseAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RspException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RspComponent::updatePurchase</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> UpdatePurchaseAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RspException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RspComponent::finishPurchase</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> FinishPurchaseAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RspException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RspComponent::listPurchases</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> ListPurchasesAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RspException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RspComponent::listServers</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> ListServersAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RspException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RspComponent::getServerDetails</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetServerDetailsAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RspException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RspComponent::restartServer</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> RestartServerAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RspException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RspComponent::updateServerBanner</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> UpdateServerBannerAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RspException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RspComponent::updateServerSettings</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> UpdateServerSettingsAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RspException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RspComponent::updateServerPreset</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> UpdateServerPresetAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RspException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RspComponent::updateServerMapRotation</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> UpdateServerMapRotationAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RspException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RspComponent::addServerAdmin</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> AddServerAdminAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RspException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RspComponent::removeServerAdmin</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> RemoveServerAdminAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RspException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RspComponent::addServerBan</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> AddServerBanAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RspException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RspComponent::removeServerBan</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> RemoveServerBanAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RspException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RspComponent::addServerVip</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> AddServerVipAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RspException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RspComponent::removeServerVip</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> RemoveServerVipAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RspException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RspComponent::getConfig</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="GetConfigResponse"/><br/>
        /// </summary>
        public virtual Task<GetConfigResponse> GetConfigAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RspException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RspComponent::getPingSites</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetPingSitesAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RspException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RspComponent::getGameData</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetGameDataAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RspException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RspComponent::addGameBan</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> AddGameBanAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RspException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RspComponent::createServer</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> CreateServerAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RspException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RspComponent::updateServer</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> UpdateServerAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RspException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RspComponent::listAllServers</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> ListAllServersAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RspException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RspComponent::startMatch</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> StartMatchAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RspException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RspComponent::abortMatch</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> AbortMatchAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RspException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RspComponent::endMatch</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> EndMatchAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RspException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
    }
    
}

