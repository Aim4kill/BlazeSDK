using Blaze2SDK.Blaze.Rooms;
using BlazeCommon;

namespace Blaze2SDK.Components
{
    public static class RoomsComponentBase
    {
        public const ushort Id = 21;
        public const string Name = "RoomsComponent";
        
        public class Server : BlazeComponent<RoomsComponentCommand, RoomsComponentNotification, Blaze2RpcError>
        {
            public Server() : base(RoomsComponentBase.Id, RoomsComponentBase.Name)
            {
                
            }
            
            [BlazeCommand((ushort)RoomsComponentCommand.selectViewUpdates)]
            public virtual Task<NullStruct> SelectViewUpdatesAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RoomsComponentCommand.selectCategoryUpdates)]
            public virtual Task<NullStruct> SelectCategoryUpdatesAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RoomsComponentCommand.joinRoom)]
            public virtual Task<NullStruct> JoinRoomAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RoomsComponentCommand.leaveRoom)]
            public virtual Task<NullStruct> LeaveRoomAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RoomsComponentCommand.kickUser)]
            public virtual Task<NullStruct> KickUserAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RoomsComponentCommand.transferRoomHost)]
            public virtual Task<NullStruct> TransferRoomHostAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RoomsComponentCommand.createRoomCategory)]
            public virtual Task<NullStruct> CreateRoomCategoryAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RoomsComponentCommand.removeRoomCategory)]
            public virtual Task<NullStruct> RemoveRoomCategoryAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RoomsComponentCommand.createRoom)]
            public virtual Task<NullStruct> CreateRoomAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RoomsComponentCommand.removeRoom)]
            public virtual Task<NullStruct> RemoveRoomAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RoomsComponentCommand.getViews)]
            public virtual Task<NullStruct> GetViewsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RoomsComponentCommand.createScheduledCategory)]
            public virtual Task<NullStruct> CreateScheduledCategoryAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RoomsComponentCommand.deleteScheduledCategory)]
            public virtual Task<NullStruct> DeleteScheduledCategoryAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RoomsComponentCommand.getScheduledCategories)]
            public virtual Task<NullStruct> GetScheduledCategoriesAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RoomsComponentCommand.lookupRoomData)]
            public virtual Task<NullStruct> LookupRoomDataAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RoomsComponentCommand.setRoomAttributes)]
            public virtual Task<NullStruct> SetRoomAttributesAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RoomsComponentCommand.checkEntryCriteria)]
            public virtual Task<NullStruct> CheckEntryCriteriaAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RoomsComponentCommand.toggleJoinedRoomNotifications)]
            public virtual Task<NullStruct> ToggleJoinedRoomNotificationsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            
            public static Task NotifyRoomViewUpdatedNotificationAsync(BlazeServerConnection connection, RoomViewData notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(RoomsComponentBase.Id, (ushort)RoomsComponentNotification.RoomViewUpdatedNotification, notification, waitUntilFree);
            }
            
            public static Task NotifyRoomViewAddedNotificationAsync(BlazeServerConnection connection, RoomViewData notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(RoomsComponentBase.Id, (ushort)RoomsComponentNotification.RoomViewAddedNotification, notification, waitUntilFree);
            }
            
            public static Task NotifyRoomViewRemovedNotificationAsync(BlazeServerConnection connection, RoomViewRemoved notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(RoomsComponentBase.Id, (ushort)RoomsComponentNotification.RoomViewRemovedNotification, notification, waitUntilFree);
            }
            
            public static Task NotifyRoomCategoryUpdatedNotificationAsync(BlazeServerConnection connection, RoomCategoryData notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(RoomsComponentBase.Id, (ushort)RoomsComponentNotification.RoomCategoryUpdatedNotification, notification, waitUntilFree);
            }
            
            public static Task NotifyRoomCategoryAddedNotificationAsync(BlazeServerConnection connection, RoomCategoryData notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(RoomsComponentBase.Id, (ushort)RoomsComponentNotification.RoomCategoryAddedNotification, notification, waitUntilFree);
            }
            
            public static Task NotifyRoomCategoryRemovedNotificationAsync(BlazeServerConnection connection, RoomCategoryRemoved notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(RoomsComponentBase.Id, (ushort)RoomsComponentNotification.RoomCategoryRemovedNotification, notification, waitUntilFree);
            }
            
            public static Task NotifyRoomUpdatedNotificationAsync(BlazeServerConnection connection, RoomData notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(RoomsComponentBase.Id, (ushort)RoomsComponentNotification.RoomUpdatedNotification, notification, waitUntilFree);
            }
            
            public static Task NotifyRoomAddedNotificationAsync(BlazeServerConnection connection, RoomData notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(RoomsComponentBase.Id, (ushort)RoomsComponentNotification.RoomAddedNotification, notification, waitUntilFree);
            }
            
            public static Task NotifyRoomRemovedNotificationAsync(BlazeServerConnection connection, RoomRemoved notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(RoomsComponentBase.Id, (ushort)RoomsComponentNotification.RoomRemovedNotification, notification, waitUntilFree);
            }
            
            public static Task NotifyRoomPopulationUpdatedAsync(BlazeServerConnection connection, RoomsPopulationUpdate notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(RoomsComponentBase.Id, (ushort)RoomsComponentNotification.RoomPopulationUpdated, notification, waitUntilFree);
            }
            
            public static Task NotifyRoomMemberJoinedAsync(BlazeServerConnection connection, RoomMemberData notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(RoomsComponentBase.Id, (ushort)RoomsComponentNotification.RoomMemberJoined, notification, waitUntilFree);
            }
            
            public static Task NotifyRoomMemberLeftAsync(BlazeServerConnection connection, RoomMemberRemoved notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(RoomsComponentBase.Id, (ushort)RoomsComponentNotification.RoomMemberLeft, notification, waitUntilFree);
            }
            
            public static Task NotifyRoomMemberUpdatedAsync(BlazeServerConnection connection, RoomMemberData notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(RoomsComponentBase.Id, (ushort)RoomsComponentNotification.RoomMemberUpdated, notification, waitUntilFree);
            }
            
            public static Task NotifyRoomKickAsync(BlazeServerConnection connection, RoomMemberKicked notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(RoomsComponentBase.Id, (ushort)RoomsComponentNotification.RoomKick, notification, waitUntilFree);
            }
            
            public static Task NotifyRoomHostTransferAsync(BlazeServerConnection connection, RoomHostTransfered notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(RoomsComponentBase.Id, (ushort)RoomsComponentNotification.RoomHostTransfer, notification, waitUntilFree);
            }
            
            public static Task NotifyRoomAttributesSetAsync(BlazeServerConnection connection, RoomAttributesSet notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(RoomsComponentBase.Id, (ushort)RoomsComponentNotification.RoomAttributesSet, notification, waitUntilFree);
            }
            
            public override Type GetCommandRequestType(RoomsComponentCommand command) => RoomsComponentBase.GetCommandRequestType(command);
            public override Type GetCommandResponseType(RoomsComponentCommand command) => RoomsComponentBase.GetCommandResponseType(command);
            public override Type GetCommandErrorResponseType(RoomsComponentCommand command) => RoomsComponentBase.GetCommandErrorResponseType(command);
            public override Type GetNotificationType(RoomsComponentNotification notification) => RoomsComponentBase.GetNotificationType(notification);
            
        }
        
        public class Client : BlazeComponent<RoomsComponentCommand, RoomsComponentNotification, Blaze2RpcError>
        {
            public Client() : base(RoomsComponentBase.Id, RoomsComponentBase.Name)
            {
                
            }
            
            public override Type GetCommandRequestType(RoomsComponentCommand command) => RoomsComponentBase.GetCommandRequestType(command);
            public override Type GetCommandResponseType(RoomsComponentCommand command) => RoomsComponentBase.GetCommandResponseType(command);
            public override Type GetCommandErrorResponseType(RoomsComponentCommand command) => RoomsComponentBase.GetCommandErrorResponseType(command);
            public override Type GetNotificationType(RoomsComponentNotification notification) => RoomsComponentBase.GetNotificationType(notification);
            
        }
        
        public static Type GetCommandRequestType(RoomsComponentCommand command) => command switch
        {
            RoomsComponentCommand.selectViewUpdates => typeof(NullStruct),
            RoomsComponentCommand.selectCategoryUpdates => typeof(NullStruct),
            RoomsComponentCommand.joinRoom => typeof(NullStruct),
            RoomsComponentCommand.leaveRoom => typeof(NullStruct),
            RoomsComponentCommand.kickUser => typeof(NullStruct),
            RoomsComponentCommand.transferRoomHost => typeof(NullStruct),
            RoomsComponentCommand.createRoomCategory => typeof(NullStruct),
            RoomsComponentCommand.removeRoomCategory => typeof(NullStruct),
            RoomsComponentCommand.createRoom => typeof(NullStruct),
            RoomsComponentCommand.removeRoom => typeof(NullStruct),
            RoomsComponentCommand.getViews => typeof(NullStruct),
            RoomsComponentCommand.createScheduledCategory => typeof(NullStruct),
            RoomsComponentCommand.deleteScheduledCategory => typeof(NullStruct),
            RoomsComponentCommand.getScheduledCategories => typeof(NullStruct),
            RoomsComponentCommand.lookupRoomData => typeof(NullStruct),
            RoomsComponentCommand.setRoomAttributes => typeof(NullStruct),
            RoomsComponentCommand.checkEntryCriteria => typeof(NullStruct),
            RoomsComponentCommand.toggleJoinedRoomNotifications => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandResponseType(RoomsComponentCommand command) => command switch
        {
            RoomsComponentCommand.selectViewUpdates => typeof(NullStruct),
            RoomsComponentCommand.selectCategoryUpdates => typeof(NullStruct),
            RoomsComponentCommand.joinRoom => typeof(NullStruct),
            RoomsComponentCommand.leaveRoom => typeof(NullStruct),
            RoomsComponentCommand.kickUser => typeof(NullStruct),
            RoomsComponentCommand.transferRoomHost => typeof(NullStruct),
            RoomsComponentCommand.createRoomCategory => typeof(NullStruct),
            RoomsComponentCommand.removeRoomCategory => typeof(NullStruct),
            RoomsComponentCommand.createRoom => typeof(NullStruct),
            RoomsComponentCommand.removeRoom => typeof(NullStruct),
            RoomsComponentCommand.getViews => typeof(NullStruct),
            RoomsComponentCommand.createScheduledCategory => typeof(NullStruct),
            RoomsComponentCommand.deleteScheduledCategory => typeof(NullStruct),
            RoomsComponentCommand.getScheduledCategories => typeof(NullStruct),
            RoomsComponentCommand.lookupRoomData => typeof(NullStruct),
            RoomsComponentCommand.setRoomAttributes => typeof(NullStruct),
            RoomsComponentCommand.checkEntryCriteria => typeof(NullStruct),
            RoomsComponentCommand.toggleJoinedRoomNotifications => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandErrorResponseType(RoomsComponentCommand command) => command switch
        {
            RoomsComponentCommand.selectViewUpdates => typeof(NullStruct),
            RoomsComponentCommand.selectCategoryUpdates => typeof(NullStruct),
            RoomsComponentCommand.joinRoom => typeof(NullStruct),
            RoomsComponentCommand.leaveRoom => typeof(NullStruct),
            RoomsComponentCommand.kickUser => typeof(NullStruct),
            RoomsComponentCommand.transferRoomHost => typeof(NullStruct),
            RoomsComponentCommand.createRoomCategory => typeof(NullStruct),
            RoomsComponentCommand.removeRoomCategory => typeof(NullStruct),
            RoomsComponentCommand.createRoom => typeof(NullStruct),
            RoomsComponentCommand.removeRoom => typeof(NullStruct),
            RoomsComponentCommand.getViews => typeof(NullStruct),
            RoomsComponentCommand.createScheduledCategory => typeof(NullStruct),
            RoomsComponentCommand.deleteScheduledCategory => typeof(NullStruct),
            RoomsComponentCommand.getScheduledCategories => typeof(NullStruct),
            RoomsComponentCommand.lookupRoomData => typeof(NullStruct),
            RoomsComponentCommand.setRoomAttributes => typeof(NullStruct),
            RoomsComponentCommand.checkEntryCriteria => typeof(NullStruct),
            RoomsComponentCommand.toggleJoinedRoomNotifications => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetNotificationType(RoomsComponentNotification notification) => notification switch
        {
            RoomsComponentNotification.RoomViewUpdatedNotification => typeof(RoomViewData),
            RoomsComponentNotification.RoomViewAddedNotification => typeof(RoomViewData),
            RoomsComponentNotification.RoomViewRemovedNotification => typeof(RoomViewRemoved),
            RoomsComponentNotification.RoomCategoryUpdatedNotification => typeof(RoomCategoryData),
            RoomsComponentNotification.RoomCategoryAddedNotification => typeof(RoomCategoryData),
            RoomsComponentNotification.RoomCategoryRemovedNotification => typeof(RoomCategoryRemoved),
            RoomsComponentNotification.RoomUpdatedNotification => typeof(RoomData),
            RoomsComponentNotification.RoomAddedNotification => typeof(RoomData),
            RoomsComponentNotification.RoomRemovedNotification => typeof(RoomRemoved),
            RoomsComponentNotification.RoomPopulationUpdated => typeof(RoomsPopulationUpdate),
            RoomsComponentNotification.RoomMemberJoined => typeof(RoomMemberData),
            RoomsComponentNotification.RoomMemberLeft => typeof(RoomMemberRemoved),
            RoomsComponentNotification.RoomMemberUpdated => typeof(RoomMemberData),
            RoomsComponentNotification.RoomKick => typeof(RoomMemberKicked),
            RoomsComponentNotification.RoomHostTransfer => typeof(RoomHostTransfered),
            RoomsComponentNotification.RoomAttributesSet => typeof(RoomAttributesSet),
            _ => typeof(NullStruct)
        };
        
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
            getViews = 109,
            createScheduledCategory = 110,
            deleteScheduledCategory = 111,
            getScheduledCategories = 112,
            lookupRoomData = 120,
            setRoomAttributes = 130,
            checkEntryCriteria = 140,
            toggleJoinedRoomNotifications = 150,
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
        }
        
    }
}
