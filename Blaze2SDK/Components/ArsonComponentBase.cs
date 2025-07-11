using Blaze.Core;
using EATDF;
using EATDF.Types;

namespace Blaze2SDK.Components;

public static class ArsonComponentBase
{
    public const ushort Id = 32;
    public const string Name = "ArsonComponent";
    
    public enum Error : ushort {
        ARSON_ERR_INVALID_PARAMETER = 1,
        ARSON_ERR_KEY_NOT_FOUND = 2,
        ARSON_ERR_DATA_NOT_FOUND = 3,
        ARSON_ERR_TOURN_COMPONENT_NOT_FOUND = 4,
        ARSON_ERR_REGISTRATION_GAME_INCREMENT = 5,
        ARSON_ERR_TOURNAMENT_NOT_FOUND = 6,
        ARSON_ERR_USER_NOT_IN_TOURNAMENT = 7,
        ARSON_ERR_TIES_NOT_SUPPORTED = 8,
        ARSON_ERR_INVALID_GAME_ID = 9,
        ARSON_ERR_GAME_FULL = 10,
        ARSON_ERR_QUEUE_FULL = 11,
        ARSON_ERR_MEMBER_PRE_JOIN_FAILED = 12,
        ARSON_ERR_JOIN_METHOD_NOT_SUPPORTED = 13,
        ARSON_ERR_PLAYER_NOT_FOUND = 14,
        ARSON_ERR_GAME_ENTRY_CRITERIA_FAILED = 15,
        ARSON_ERR_GAME_PROTOCOL_VERSION_MISMATCH = 16,
        ARSON_ERR_ENFORCING_SINGLE_GROUP_JOINS = 17,
        ARSON_ERR_GAMEMANAGER_COMPONENT_NOT_FOUND = 18,
        ARSON_ERR_TOURNAMENT_DB_ERROR = 19,
        ARSON_ERR_ROOMS_NOT_FOUND = 20,
        ARSON_ERR_COMMERCEINFO_WALLET_IS_INVALID = 21,
        ARSON_ERR_COMMERCEINFO_WALLET_NOT_FOUND = 22,
        ARSON_ERR_COMMERCEINFO_WALLET_CURRENCY_NOT_EARNABLE = 23,
        ARSON_ERR_COMMERCEINFO_WALLET_CURRENCY_NOT_MATCH = 24,
        ARSON_ERR_COMMERCEINFO_BILLING_SYSTEM = 25,
    }
    
    public enum ArsonComponentCommand : ushort
    {
        getUserExtendedData = 1,
        updateUserExtendedData = 2,
        reportTournamentResult = 3,
        updateRegistrationGameIncrement = 4,
        joinGameByUserList = 5,
        reconfigure = 6,
        getTournamentMemberStatus = 7,
        setRoomCategoryClientMetaData = 8,
        getRoomCategoryClientMetaData = 9,
        setRoomAttributes = 10,
        getRoomAttributes = 11,
        getRoomCategory = 12,
        setComponentState = 13,
        addPointsToWallet = 14,
    }
    
    public enum ArsonComponentNotification : ushort
    {
        NotifyReconfigureCompleted = 1,
    }
    
    public class Server : BlazeComponent {
        public override ushort Id => ArsonComponentBase.Id;
        public override string Name => ArsonComponentBase.Name;
        
        public virtual bool IsCommandSupported(ArsonComponentCommand command) => false;
        
        public class ArsonException : BlazeRpcException
        {
            public ArsonException(Error error) : base((ushort)error, null) { }
            public ArsonException(ServerError error) : base(error.WithErrorPrefix(), null) { }
            public ArsonException(Error error, Tdf? errorResponse) : base((ushort)error, errorResponse) { }
            public ArsonException(ServerError error, Tdf? errorResponse) : base(error.WithErrorPrefix(), errorResponse) { }
            public ArsonException(Error error, Tdf? errorResponse, string? message) : base((ushort)error, errorResponse, message) { }
            public ArsonException(ServerError error, Tdf? errorResponse, string? message) : base(error.WithErrorPrefix(), errorResponse, message) { }
            public ArsonException(Error error, Tdf? errorResponse, string? message, Exception? innerException) : base((ushort)error, errorResponse, message, innerException) { }
            public ArsonException(ServerError error, Tdf? errorResponse, string? message, Exception? innerException) : base(error.WithErrorPrefix(), errorResponse, message, innerException) { }
        }
        
        public Server()
        {
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ArsonComponentCommand.getUserExtendedData,
                Name = "getUserExtendedData",
                IsSupported = IsCommandSupported(ArsonComponentCommand.getUserExtendedData),
                Func = async (req, ctx) => await GetUserExtendedDataAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ArsonComponentCommand.updateUserExtendedData,
                Name = "updateUserExtendedData",
                IsSupported = IsCommandSupported(ArsonComponentCommand.updateUserExtendedData),
                Func = async (req, ctx) => await UpdateUserExtendedDataAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ArsonComponentCommand.reportTournamentResult,
                Name = "reportTournamentResult",
                IsSupported = IsCommandSupported(ArsonComponentCommand.reportTournamentResult),
                Func = async (req, ctx) => await ReportTournamentResultAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ArsonComponentCommand.updateRegistrationGameIncrement,
                Name = "updateRegistrationGameIncrement",
                IsSupported = IsCommandSupported(ArsonComponentCommand.updateRegistrationGameIncrement),
                Func = async (req, ctx) => await UpdateRegistrationGameIncrementAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ArsonComponentCommand.joinGameByUserList,
                Name = "joinGameByUserList",
                IsSupported = IsCommandSupported(ArsonComponentCommand.joinGameByUserList),
                Func = async (req, ctx) => await JoinGameByUserListAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ArsonComponentCommand.reconfigure,
                Name = "reconfigure",
                IsSupported = IsCommandSupported(ArsonComponentCommand.reconfigure),
                Func = async (req, ctx) => await ReconfigureAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ArsonComponentCommand.getTournamentMemberStatus,
                Name = "getTournamentMemberStatus",
                IsSupported = IsCommandSupported(ArsonComponentCommand.getTournamentMemberStatus),
                Func = async (req, ctx) => await GetTournamentMemberStatusAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ArsonComponentCommand.setRoomCategoryClientMetaData,
                Name = "setRoomCategoryClientMetaData",
                IsSupported = IsCommandSupported(ArsonComponentCommand.setRoomCategoryClientMetaData),
                Func = async (req, ctx) => await SetRoomCategoryClientMetaDataAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ArsonComponentCommand.getRoomCategoryClientMetaData,
                Name = "getRoomCategoryClientMetaData",
                IsSupported = IsCommandSupported(ArsonComponentCommand.getRoomCategoryClientMetaData),
                Func = async (req, ctx) => await GetRoomCategoryClientMetaDataAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ArsonComponentCommand.setRoomAttributes,
                Name = "setRoomAttributes",
                IsSupported = IsCommandSupported(ArsonComponentCommand.setRoomAttributes),
                Func = async (req, ctx) => await SetRoomAttributesAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ArsonComponentCommand.getRoomAttributes,
                Name = "getRoomAttributes",
                IsSupported = IsCommandSupported(ArsonComponentCommand.getRoomAttributes),
                Func = async (req, ctx) => await GetRoomAttributesAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ArsonComponentCommand.getRoomCategory,
                Name = "getRoomCategory",
                IsSupported = IsCommandSupported(ArsonComponentCommand.getRoomCategory),
                Func = async (req, ctx) => await GetRoomCategoryAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ArsonComponentCommand.setComponentState,
                Name = "setComponentState",
                IsSupported = IsCommandSupported(ArsonComponentCommand.setComponentState),
                Func = async (req, ctx) => await SetComponentStateAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ArsonComponentCommand.addPointsToWallet,
                Name = "addPointsToWallet",
                IsSupported = IsCommandSupported(ArsonComponentCommand.addPointsToWallet),
                Func = async (req, ctx) => await AddPointsToWalletAsync(req, ctx).ConfigureAwait(false)
            });
            
        }
        
        public override string GetErrorName(ushort errorCode)
        {
            return ((Error)errorCode).ToString();
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ArsonComponent::getUserExtendedData</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetUserExtendedDataAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ArsonException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ArsonComponent::updateUserExtendedData</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> UpdateUserExtendedDataAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ArsonException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ArsonComponent::reportTournamentResult</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> ReportTournamentResultAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ArsonException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ArsonComponent::updateRegistrationGameIncrement</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> UpdateRegistrationGameIncrementAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ArsonException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ArsonComponent::joinGameByUserList</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> JoinGameByUserListAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ArsonException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ArsonComponent::reconfigure</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> ReconfigureAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ArsonException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ArsonComponent::getTournamentMemberStatus</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetTournamentMemberStatusAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ArsonException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ArsonComponent::setRoomCategoryClientMetaData</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SetRoomCategoryClientMetaDataAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ArsonException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ArsonComponent::getRoomCategoryClientMetaData</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetRoomCategoryClientMetaDataAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ArsonException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ArsonComponent::setRoomAttributes</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SetRoomAttributesAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ArsonException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ArsonComponent::getRoomAttributes</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetRoomAttributesAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ArsonException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ArsonComponent::getRoomCategory</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetRoomCategoryAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ArsonException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ArsonComponent::setComponentState</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SetComponentStateAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ArsonException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ArsonComponent::addPointsToWallet</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> AddPointsToWalletAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ArsonException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>ArsonComponent::NotifyReconfigureCompleted</b> notification.<br/>
        /// Notification type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public static Task NotifyNotifyReconfigureCompletedAsync(BlazeRpcConnection connection, EmptyMessage notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = ArsonComponentBase.Id;
                frame.Command = (ushort)ArsonComponentNotification.NotifyReconfigureCompleted;
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

