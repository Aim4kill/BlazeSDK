using BlazeCommon;

namespace Blaze3SDK.Components
{
    public static class RoomsComponentBase
    {
        public const ushort Id = 21;
        public const string Name = "RoomsComponent";
        
        public class Server : BlazeComponent<RoomsComponentCommand, RoomsComponentNotification, Blaze3RpcError>
        {
            public Server() : base(RoomsComponentBase.Id, RoomsComponentBase.Name)
            {
                
            }
            
            [BlazeCommand((ushort)RoomsComponentCommand.selectViewUpdates)]
            public virtual Task<NullStruct> SelectViewUpdatesAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RoomsComponentCommand.selectCategoryUpdates)]
            public virtual Task<NullStruct> SelectCategoryUpdatesAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RoomsComponentCommand.joinRoom)]
            public virtual Task<NullStruct> JoinRoomAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RoomsComponentCommand.leaveRoom)]
            public virtual Task<NullStruct> LeaveRoomAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RoomsComponentCommand.kickUser)]
            public virtual Task<NullStruct> KickUserAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RoomsComponentCommand.transferRoomHost)]
            public virtual Task<NullStruct> TransferRoomHostAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RoomsComponentCommand.createRoomCategory)]
            public virtual Task<NullStruct> CreateRoomCategoryAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RoomsComponentCommand.removeRoomCategory)]
            public virtual Task<NullStruct> RemoveRoomCategoryAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RoomsComponentCommand.createRoom)]
            public virtual Task<NullStruct> CreateRoomAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RoomsComponentCommand.removeRoom)]
            public virtual Task<NullStruct> RemoveRoomAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RoomsComponentCommand.clearBannedUsers)]
            public virtual Task<NullStruct> ClearBannedUsersAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RoomsComponentCommand.unbanUser)]
            public virtual Task<NullStruct> UnbanUserAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RoomsComponentCommand.getViews)]
            public virtual Task<NullStruct> GetViewsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RoomsComponentCommand.createScheduledCategory)]
            public virtual Task<NullStruct> CreateScheduledCategoryAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RoomsComponentCommand.deleteScheduledCategory)]
            public virtual Task<NullStruct> DeleteScheduledCategoryAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RoomsComponentCommand.getScheduledCategories)]
            public virtual Task<NullStruct> GetScheduledCategoriesAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RoomsComponentCommand.lookupRoomData)]
            public virtual Task<NullStruct> LookupRoomDataAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RoomsComponentCommand.listBannedUsers)]
            public virtual Task<NullStruct> ListBannedUsersAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RoomsComponentCommand.setRoomAttributes)]
            public virtual Task<NullStruct> SetRoomAttributesAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RoomsComponentCommand.checkEntryCriteria)]
            public virtual Task<NullStruct> CheckEntryCriteriaAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RoomsComponentCommand.toggleJoinedRoomNotifications)]
            public virtual Task<NullStruct> ToggleJoinedRoomNotificationsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RoomsComponentCommand.selectPseudoRoomUpdates)]
            public virtual Task<NullStruct> SelectPseudoRoomUpdatesAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RoomsComponentCommand.setMemberAttributes)]
            public virtual Task<NullStruct> SetMemberAttributesAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
        }
        
        public class Client : BlazeComponent<RoomsComponentCommand, RoomsComponentNotification, Blaze3RpcError>
        {
            public Client() : base(RoomsComponentBase.Id, RoomsComponentBase.Name)
            {
                
            }
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
        
    }
}
