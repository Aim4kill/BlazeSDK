using Blaze.Core;
using Blaze3SDK.Blaze.Rooms;
using EATDF;
using EATDF.Types;

namespace Blaze3SDK.Components;

public static class RoomsComponentBase
{
    public const ushort Id = 21;
    public const string Name = "RoomsComponent";
    
    public enum Error : ushort {
        ROOMS_ERR_GENERIC = 1,
        ROOMS_ERR_MISSING_PARAM = 2,
        ROOMS_ERR_BAD_PARAM = 3,
        ROOMS_ERR_CONFIG_ERROR = 4,
        ROOMS_ERR_DB_ERROR = 5,
        ROOMS_ERR_NO_PERMISSION = 10,
        ROOMS_ERR_NOT_FOUND = 11,
        ROOMS_ERR_ROOM_FULL = 12,
        ROOMS_ERR_UNKNOWN_VIEW = 13,
        ROOMS_ERR_ALREADY_MEMBER = 14,
        ROOMS_ERR_NOT_MEMBER = 15,
        ROOMS_ERR_ALREADY_REGISTERED = 16,
        ROOMS_ERR_NOT_REGISTERED = 17,
        ROOMS_ERR_JOIN_CRITERIA_FAILED = 18,
        ROOMS_ERR_JOIN_WRONG_PASSWORD = 19,
        ROOMS_ERR_CREATE_UNKNOWN_VIEW = 20,
        ROOMS_ERR_CREATE_SMALL_CAPACITY = 21,
        ROOMS_ERR_CREATE_BLANK_NAME = 22,
        ROOMS_ERR_CREATE_DUPLICATE_NAME = 23,
        ROOMS_ERR_CREATE_MAX_ROOMS = 24,
        ROOMS_ERR_CREATE_UNKNOWN_CATEGORY = 25,
        ROOMS_ERR_INVALID_CRITERIA = 26,
        ROOMS_ERR_CREATE_PROFANE_NAME = 27,
        ROOMS_ERR_JOIN_BANNED = 28,
        ROOMS_ERR_MEMBER_NOT_FOUND = 29,
    }
    
    public enum RoomsComponentCommand : ushort
    {
        selectViewUpdates = 10,
        selectCategoryUpdates = 11,
        joinRoom = 20,
        leaveRoom = 21,
        kickUser = 31,
        transferRoomHost = 40,
        createRoomCategory = 100,
        removeRoomCategory = 101,
        createRoom = 102,
        removeRoom = 103,
        clearBannedUsers = 104,
        unbanUser = 105,
        getViews = 109,
        createScheduledCategory = 110,
        deleteScheduledCategory = 111,
        getScheduledCategories = 112,
        lookupRoomData = 120,
        listBannedUsers = 122,
        setRoomAttributes = 130,
        checkEntryCriteria = 140,
        toggleJoinedRoomNotifications = 150,
        selectPseudoRoomUpdates = 160,
        setMemberAttributes = 170,
    }
    
    public enum RoomsComponentNotification : ushort
    {
        RoomViewUpdatedNotification = 10,
        RoomViewAddedNotification = 11,
        RoomViewRemovedNotification = 12,
        RoomCategoryUpdatedNotification = 20,
        RoomCategoryAddedNotification = 21,
        RoomCategoryRemovedNotification = 22,
        RoomUpdatedNotification = 30,
        RoomAddedNotification = 31,
        RoomRemovedNotification = 32,
        RoomPopulationUpdated = 40,
        RoomMemberJoined = 50,
        RoomMemberLeft = 51,
        RoomMemberUpdated = 52,
        RoomKick = 60,
        RoomHostTransfer = 70,
        RoomAttributesSet = 80,
        MemberAttributesSet = 90,
    }
    
    public class Server : BlazeComponent {
        public override ushort Id => RoomsComponentBase.Id;
        public override string Name => RoomsComponentBase.Name;
        
        public virtual bool IsCommandSupported(RoomsComponentCommand command) => false;
        
        public class RoomsException : BlazeRpcException
        {
            public RoomsException(Error error) : base((ushort)error, null) { }
            public RoomsException(ServerError error) : base(error.WithErrorPrefix(), null) { }
            public RoomsException(Error error, Tdf? errorResponse) : base((ushort)error, errorResponse) { }
            public RoomsException(ServerError error, Tdf? errorResponse) : base(error.WithErrorPrefix(), errorResponse) { }
            public RoomsException(Error error, Tdf? errorResponse, string? message) : base((ushort)error, errorResponse, message) { }
            public RoomsException(ServerError error, Tdf? errorResponse, string? message) : base(error.WithErrorPrefix(), errorResponse, message) { }
            public RoomsException(Error error, Tdf? errorResponse, string? message, Exception? innerException) : base((ushort)error, errorResponse, message, innerException) { }
            public RoomsException(ServerError error, Tdf? errorResponse, string? message, Exception? innerException) : base(error.WithErrorPrefix(), errorResponse, message, innerException) { }
        }
        
        public Server()
        {
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RoomsComponentCommand.selectViewUpdates,
                Name = "selectViewUpdates",
                IsSupported = IsCommandSupported(RoomsComponentCommand.selectViewUpdates),
                Func = async (req, ctx) => await SelectViewUpdatesAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RoomsComponentCommand.selectCategoryUpdates,
                Name = "selectCategoryUpdates",
                IsSupported = IsCommandSupported(RoomsComponentCommand.selectCategoryUpdates),
                Func = async (req, ctx) => await SelectCategoryUpdatesAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RoomsComponentCommand.joinRoom,
                Name = "joinRoom",
                IsSupported = IsCommandSupported(RoomsComponentCommand.joinRoom),
                Func = async (req, ctx) => await JoinRoomAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RoomsComponentCommand.leaveRoom,
                Name = "leaveRoom",
                IsSupported = IsCommandSupported(RoomsComponentCommand.leaveRoom),
                Func = async (req, ctx) => await LeaveRoomAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RoomsComponentCommand.kickUser,
                Name = "kickUser",
                IsSupported = IsCommandSupported(RoomsComponentCommand.kickUser),
                Func = async (req, ctx) => await KickUserAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RoomsComponentCommand.transferRoomHost,
                Name = "transferRoomHost",
                IsSupported = IsCommandSupported(RoomsComponentCommand.transferRoomHost),
                Func = async (req, ctx) => await TransferRoomHostAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RoomsComponentCommand.createRoomCategory,
                Name = "createRoomCategory",
                IsSupported = IsCommandSupported(RoomsComponentCommand.createRoomCategory),
                Func = async (req, ctx) => await CreateRoomCategoryAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RoomsComponentCommand.removeRoomCategory,
                Name = "removeRoomCategory",
                IsSupported = IsCommandSupported(RoomsComponentCommand.removeRoomCategory),
                Func = async (req, ctx) => await RemoveRoomCategoryAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RoomsComponentCommand.createRoom,
                Name = "createRoom",
                IsSupported = IsCommandSupported(RoomsComponentCommand.createRoom),
                Func = async (req, ctx) => await CreateRoomAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RoomsComponentCommand.removeRoom,
                Name = "removeRoom",
                IsSupported = IsCommandSupported(RoomsComponentCommand.removeRoom),
                Func = async (req, ctx) => await RemoveRoomAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RoomsComponentCommand.clearBannedUsers,
                Name = "clearBannedUsers",
                IsSupported = IsCommandSupported(RoomsComponentCommand.clearBannedUsers),
                Func = async (req, ctx) => await ClearBannedUsersAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RoomsComponentCommand.unbanUser,
                Name = "unbanUser",
                IsSupported = IsCommandSupported(RoomsComponentCommand.unbanUser),
                Func = async (req, ctx) => await UnbanUserAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RoomsComponentCommand.getViews,
                Name = "getViews",
                IsSupported = IsCommandSupported(RoomsComponentCommand.getViews),
                Func = async (req, ctx) => await GetViewsAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RoomsComponentCommand.createScheduledCategory,
                Name = "createScheduledCategory",
                IsSupported = IsCommandSupported(RoomsComponentCommand.createScheduledCategory),
                Func = async (req, ctx) => await CreateScheduledCategoryAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RoomsComponentCommand.deleteScheduledCategory,
                Name = "deleteScheduledCategory",
                IsSupported = IsCommandSupported(RoomsComponentCommand.deleteScheduledCategory),
                Func = async (req, ctx) => await DeleteScheduledCategoryAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RoomsComponentCommand.getScheduledCategories,
                Name = "getScheduledCategories",
                IsSupported = IsCommandSupported(RoomsComponentCommand.getScheduledCategories),
                Func = async (req, ctx) => await GetScheduledCategoriesAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RoomsComponentCommand.lookupRoomData,
                Name = "lookupRoomData",
                IsSupported = IsCommandSupported(RoomsComponentCommand.lookupRoomData),
                Func = async (req, ctx) => await LookupRoomDataAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RoomsComponentCommand.listBannedUsers,
                Name = "listBannedUsers",
                IsSupported = IsCommandSupported(RoomsComponentCommand.listBannedUsers),
                Func = async (req, ctx) => await ListBannedUsersAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RoomsComponentCommand.setRoomAttributes,
                Name = "setRoomAttributes",
                IsSupported = IsCommandSupported(RoomsComponentCommand.setRoomAttributes),
                Func = async (req, ctx) => await SetRoomAttributesAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RoomsComponentCommand.checkEntryCriteria,
                Name = "checkEntryCriteria",
                IsSupported = IsCommandSupported(RoomsComponentCommand.checkEntryCriteria),
                Func = async (req, ctx) => await CheckEntryCriteriaAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RoomsComponentCommand.toggleJoinedRoomNotifications,
                Name = "toggleJoinedRoomNotifications",
                IsSupported = IsCommandSupported(RoomsComponentCommand.toggleJoinedRoomNotifications),
                Func = async (req, ctx) => await ToggleJoinedRoomNotificationsAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RoomsComponentCommand.selectPseudoRoomUpdates,
                Name = "selectPseudoRoomUpdates",
                IsSupported = IsCommandSupported(RoomsComponentCommand.selectPseudoRoomUpdates),
                Func = async (req, ctx) => await SelectPseudoRoomUpdatesAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)RoomsComponentCommand.setMemberAttributes,
                Name = "setMemberAttributes",
                IsSupported = IsCommandSupported(RoomsComponentCommand.setMemberAttributes),
                Func = async (req, ctx) => await SetMemberAttributesAsync(req, ctx).ConfigureAwait(false)
            });
            
        }
        
        public override string GetErrorName(ushort errorCode)
        {
            return ((Error)errorCode).ToString();
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RoomsComponent::selectViewUpdates</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SelectViewUpdatesAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RoomsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RoomsComponent::selectCategoryUpdates</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SelectCategoryUpdatesAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RoomsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RoomsComponent::joinRoom</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> JoinRoomAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RoomsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RoomsComponent::leaveRoom</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> LeaveRoomAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RoomsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RoomsComponent::kickUser</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> KickUserAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RoomsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RoomsComponent::transferRoomHost</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> TransferRoomHostAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RoomsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RoomsComponent::createRoomCategory</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> CreateRoomCategoryAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RoomsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RoomsComponent::removeRoomCategory</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> RemoveRoomCategoryAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RoomsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RoomsComponent::createRoom</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> CreateRoomAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RoomsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RoomsComponent::removeRoom</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> RemoveRoomAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RoomsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RoomsComponent::clearBannedUsers</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> ClearBannedUsersAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RoomsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RoomsComponent::unbanUser</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> UnbanUserAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RoomsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RoomsComponent::getViews</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetViewsAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RoomsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RoomsComponent::createScheduledCategory</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> CreateScheduledCategoryAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RoomsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RoomsComponent::deleteScheduledCategory</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> DeleteScheduledCategoryAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RoomsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RoomsComponent::getScheduledCategories</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetScheduledCategoriesAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RoomsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RoomsComponent::lookupRoomData</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> LookupRoomDataAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RoomsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RoomsComponent::listBannedUsers</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> ListBannedUsersAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RoomsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RoomsComponent::setRoomAttributes</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SetRoomAttributesAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RoomsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RoomsComponent::checkEntryCriteria</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> CheckEntryCriteriaAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RoomsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RoomsComponent::toggleJoinedRoomNotifications</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> ToggleJoinedRoomNotificationsAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RoomsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RoomsComponent::selectPseudoRoomUpdates</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SelectPseudoRoomUpdatesAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RoomsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>RoomsComponent::setMemberAttributes</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SetMemberAttributesAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new RoomsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>RoomsComponent::RoomViewUpdatedNotification</b> notification.<br/>
        /// Notification type: <see cref="RoomViewData"/><br/>
        /// </summary>
        public static Task NotifyRoomViewUpdatedNotificationAsync(BlazeRpcConnection connection, RoomViewData notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = RoomsComponentBase.Id;
                frame.Command = (ushort)RoomsComponentNotification.RoomViewUpdatedNotification;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>RoomsComponent::RoomViewAddedNotification</b> notification.<br/>
        /// Notification type: <see cref="RoomViewData"/><br/>
        /// </summary>
        public static Task NotifyRoomViewAddedNotificationAsync(BlazeRpcConnection connection, RoomViewData notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = RoomsComponentBase.Id;
                frame.Command = (ushort)RoomsComponentNotification.RoomViewAddedNotification;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>RoomsComponent::RoomViewRemovedNotification</b> notification.<br/>
        /// Notification type: <see cref="RoomViewRemoved"/><br/>
        /// </summary>
        public static Task NotifyRoomViewRemovedNotificationAsync(BlazeRpcConnection connection, RoomViewRemoved notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = RoomsComponentBase.Id;
                frame.Command = (ushort)RoomsComponentNotification.RoomViewRemovedNotification;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>RoomsComponent::RoomCategoryUpdatedNotification</b> notification.<br/>
        /// Notification type: <see cref="RoomCategoryData"/><br/>
        /// </summary>
        public static Task NotifyRoomCategoryUpdatedNotificationAsync(BlazeRpcConnection connection, RoomCategoryData notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = RoomsComponentBase.Id;
                frame.Command = (ushort)RoomsComponentNotification.RoomCategoryUpdatedNotification;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>RoomsComponent::RoomCategoryAddedNotification</b> notification.<br/>
        /// Notification type: <see cref="RoomCategoryData"/><br/>
        /// </summary>
        public static Task NotifyRoomCategoryAddedNotificationAsync(BlazeRpcConnection connection, RoomCategoryData notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = RoomsComponentBase.Id;
                frame.Command = (ushort)RoomsComponentNotification.RoomCategoryAddedNotification;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>RoomsComponent::RoomCategoryRemovedNotification</b> notification.<br/>
        /// Notification type: <see cref="RoomCategoryRemoved"/><br/>
        /// </summary>
        public static Task NotifyRoomCategoryRemovedNotificationAsync(BlazeRpcConnection connection, RoomCategoryRemoved notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = RoomsComponentBase.Id;
                frame.Command = (ushort)RoomsComponentNotification.RoomCategoryRemovedNotification;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>RoomsComponent::RoomUpdatedNotification</b> notification.<br/>
        /// Notification type: <see cref="RoomData"/><br/>
        /// </summary>
        public static Task NotifyRoomUpdatedNotificationAsync(BlazeRpcConnection connection, RoomData notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = RoomsComponentBase.Id;
                frame.Command = (ushort)RoomsComponentNotification.RoomUpdatedNotification;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>RoomsComponent::RoomAddedNotification</b> notification.<br/>
        /// Notification type: <see cref="RoomData"/><br/>
        /// </summary>
        public static Task NotifyRoomAddedNotificationAsync(BlazeRpcConnection connection, RoomData notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = RoomsComponentBase.Id;
                frame.Command = (ushort)RoomsComponentNotification.RoomAddedNotification;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>RoomsComponent::RoomRemovedNotification</b> notification.<br/>
        /// Notification type: <see cref="RoomRemoved"/><br/>
        /// </summary>
        public static Task NotifyRoomRemovedNotificationAsync(BlazeRpcConnection connection, RoomRemoved notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = RoomsComponentBase.Id;
                frame.Command = (ushort)RoomsComponentNotification.RoomRemovedNotification;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>RoomsComponent::RoomPopulationUpdated</b> notification.<br/>
        /// Notification type: <see cref="RoomsPopulationUpdate"/><br/>
        /// </summary>
        public static Task NotifyRoomPopulationUpdatedAsync(BlazeRpcConnection connection, RoomsPopulationUpdate notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = RoomsComponentBase.Id;
                frame.Command = (ushort)RoomsComponentNotification.RoomPopulationUpdated;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>RoomsComponent::RoomMemberJoined</b> notification.<br/>
        /// Notification type: <see cref="RoomMemberData"/><br/>
        /// </summary>
        public static Task NotifyRoomMemberJoinedAsync(BlazeRpcConnection connection, RoomMemberData notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = RoomsComponentBase.Id;
                frame.Command = (ushort)RoomsComponentNotification.RoomMemberJoined;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>RoomsComponent::RoomMemberLeft</b> notification.<br/>
        /// Notification type: <see cref="RoomMemberRemoved"/><br/>
        /// </summary>
        public static Task NotifyRoomMemberLeftAsync(BlazeRpcConnection connection, RoomMemberRemoved notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = RoomsComponentBase.Id;
                frame.Command = (ushort)RoomsComponentNotification.RoomMemberLeft;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>RoomsComponent::RoomMemberUpdated</b> notification.<br/>
        /// Notification type: <see cref="RoomMemberData"/><br/>
        /// </summary>
        public static Task NotifyRoomMemberUpdatedAsync(BlazeRpcConnection connection, RoomMemberData notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = RoomsComponentBase.Id;
                frame.Command = (ushort)RoomsComponentNotification.RoomMemberUpdated;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>RoomsComponent::RoomKick</b> notification.<br/>
        /// Notification type: <see cref="RoomMemberKicked"/><br/>
        /// </summary>
        public static Task NotifyRoomKickAsync(BlazeRpcConnection connection, RoomMemberKicked notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = RoomsComponentBase.Id;
                frame.Command = (ushort)RoomsComponentNotification.RoomKick;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>RoomsComponent::RoomHostTransfer</b> notification.<br/>
        /// Notification type: <see cref="RoomHostTransfered"/><br/>
        /// </summary>
        public static Task NotifyRoomHostTransferAsync(BlazeRpcConnection connection, RoomHostTransfered notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = RoomsComponentBase.Id;
                frame.Command = (ushort)RoomsComponentNotification.RoomHostTransfer;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>RoomsComponent::RoomAttributesSet</b> notification.<br/>
        /// Notification type: <see cref="RoomAttributesSet"/><br/>
        /// </summary>
        public static Task NotifyRoomAttributesSetAsync(BlazeRpcConnection connection, RoomAttributesSet notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = RoomsComponentBase.Id;
                frame.Command = (ushort)RoomsComponentNotification.RoomAttributesSet;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>RoomsComponent::MemberAttributesSet</b> notification.<br/>
        /// Notification type: <see cref="MemberAttributesSet"/><br/>
        /// </summary>
        public static Task NotifyMemberAttributesSetAsync(BlazeRpcConnection connection, MemberAttributesSet notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = RoomsComponentBase.Id;
                frame.Command = (ushort)RoomsComponentNotification.MemberAttributesSet;
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

