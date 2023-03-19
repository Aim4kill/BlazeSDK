using Blaze3SDK.Blaze;
using Blaze3SDK.Blaze.Rooms;
using BlazeCommon;
using static Blaze3SDK.Components.RoomsComponent;

namespace Blaze3SDK.Components
{
    public class RoomsComponent : ComponentData<RoomsComponentCommand, RoomsComponentNotification, RoomsComponentError>
    {
        public RoomsComponent() : base((ushort)Component.RoomsComponent)
        {

        }

        public override Type GetCommandErrorResponseType(RoomsComponentCommand command) => command switch
        {
            RoomsComponentCommand.selectViewUpdates => throw new NotImplementedException(),
            RoomsComponentCommand.selectCategoryUpdates => throw new NotImplementedException(),
            RoomsComponentCommand.joinRoom => throw new NotImplementedException(),
            RoomsComponentCommand.leaveRoom => throw new NotImplementedException(),
            RoomsComponentCommand.kickUser => throw new NotImplementedException(),
            RoomsComponentCommand.transferRoomHost => throw new NotImplementedException(),
            RoomsComponentCommand.createRoomCategory => throw new NotImplementedException(),
            RoomsComponentCommand.removeRoomCategory => throw new NotImplementedException(),
            RoomsComponentCommand.createRoom => throw new NotImplementedException(),
            RoomsComponentCommand.removeRoom => throw new NotImplementedException(),
            RoomsComponentCommand.clearBannedUsers => throw new NotImplementedException(),
            RoomsComponentCommand.unbanUser => throw new NotImplementedException(),
            RoomsComponentCommand.getViews => throw new NotImplementedException(),
            RoomsComponentCommand.createScheduledCategory => throw new NotImplementedException(),
            RoomsComponentCommand.deleteScheduledCategory => throw new NotImplementedException(),
            RoomsComponentCommand.getScheduledCategories => throw new NotImplementedException(),
            RoomsComponentCommand.lookupRoomData => throw new NotImplementedException(),
            RoomsComponentCommand.listBannedUsers => throw new NotImplementedException(),
            RoomsComponentCommand.setRoomAttributes => throw new NotImplementedException(),
            RoomsComponentCommand.checkEntryCriteria => throw new NotImplementedException(),
            RoomsComponentCommand.toggleJoinedRoomNotifications => throw new NotImplementedException(),
            RoomsComponentCommand.selectPseudoRoomUpdates => throw new NotImplementedException(),
            RoomsComponentCommand.setMemberAttributes => throw new NotImplementedException(),
            _ => typeof(NullStruct)
        };

        public override Type GetCommandRequestType(RoomsComponentCommand command) => command switch
        {
            RoomsComponentCommand.selectViewUpdates => throw new NotImplementedException(),
            RoomsComponentCommand.selectCategoryUpdates => throw new NotImplementedException(),
            RoomsComponentCommand.joinRoom => throw new NotImplementedException(),
            RoomsComponentCommand.leaveRoom => throw new NotImplementedException(),
            RoomsComponentCommand.kickUser => throw new NotImplementedException(),
            RoomsComponentCommand.transferRoomHost => throw new NotImplementedException(),
            RoomsComponentCommand.createRoomCategory => throw new NotImplementedException(),
            RoomsComponentCommand.removeRoomCategory => throw new NotImplementedException(),
            RoomsComponentCommand.createRoom => throw new NotImplementedException(),
            RoomsComponentCommand.removeRoom => throw new NotImplementedException(),
            RoomsComponentCommand.clearBannedUsers => throw new NotImplementedException(),
            RoomsComponentCommand.unbanUser => throw new NotImplementedException(),
            RoomsComponentCommand.getViews => throw new NotImplementedException(),
            RoomsComponentCommand.createScheduledCategory => throw new NotImplementedException(),
            RoomsComponentCommand.deleteScheduledCategory => throw new NotImplementedException(),
            RoomsComponentCommand.getScheduledCategories => throw new NotImplementedException(),
            RoomsComponentCommand.lookupRoomData => throw new NotImplementedException(),
            RoomsComponentCommand.listBannedUsers => throw new NotImplementedException(),
            RoomsComponentCommand.setRoomAttributes => throw new NotImplementedException(),
            RoomsComponentCommand.checkEntryCriteria => throw new NotImplementedException(),
            RoomsComponentCommand.toggleJoinedRoomNotifications => throw new NotImplementedException(),
            RoomsComponentCommand.selectPseudoRoomUpdates => throw new NotImplementedException(),
            RoomsComponentCommand.setMemberAttributes => throw new NotImplementedException(),
            _ => typeof(NullStruct)
        };

        public override Type GetCommandResponseType(RoomsComponentCommand command) => command switch
        {
            RoomsComponentCommand.selectViewUpdates => throw new NotImplementedException(),
            RoomsComponentCommand.selectCategoryUpdates => throw new NotImplementedException(),
            RoomsComponentCommand.joinRoom => throw new NotImplementedException(),
            RoomsComponentCommand.leaveRoom => throw new NotImplementedException(),
            RoomsComponentCommand.kickUser => throw new NotImplementedException(),
            RoomsComponentCommand.transferRoomHost => throw new NotImplementedException(),
            RoomsComponentCommand.createRoomCategory => throw new NotImplementedException(),
            RoomsComponentCommand.removeRoomCategory => throw new NotImplementedException(),
            RoomsComponentCommand.createRoom => throw new NotImplementedException(),
            RoomsComponentCommand.removeRoom => throw new NotImplementedException(),
            RoomsComponentCommand.clearBannedUsers => throw new NotImplementedException(),
            RoomsComponentCommand.unbanUser => throw new NotImplementedException(),
            RoomsComponentCommand.getViews => throw new NotImplementedException(),
            RoomsComponentCommand.createScheduledCategory => throw new NotImplementedException(),
            RoomsComponentCommand.deleteScheduledCategory => throw new NotImplementedException(),
            RoomsComponentCommand.getScheduledCategories => throw new NotImplementedException(),
            RoomsComponentCommand.lookupRoomData => throw new NotImplementedException(),
            RoomsComponentCommand.listBannedUsers => throw new NotImplementedException(),
            RoomsComponentCommand.setRoomAttributes => throw new NotImplementedException(),
            RoomsComponentCommand.checkEntryCriteria => throw new NotImplementedException(),
            RoomsComponentCommand.toggleJoinedRoomNotifications => throw new NotImplementedException(),
            RoomsComponentCommand.selectPseudoRoomUpdates => throw new NotImplementedException(),
            RoomsComponentCommand.setMemberAttributes => throw new NotImplementedException(),
            _ => typeof(NullStruct)
        };

        public override Type GetNotificationType(RoomsComponentNotification notification) => notification switch
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
            RoomsComponentNotification.MemberAttributesSet => typeof(MemberAttributesSet),
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

        public enum RoomsComponentError
        {
            ROOMS_ERR_GENERIC = 65557,
            ROOMS_ERR_MISSING_PARAM = 131093,
            ROOMS_ERR_BAD_PARAM = 196629,
            ROOMS_ERR_CONFIG_ERROR = 262165,
            ROOMS_ERR_DB_ERROR = 327701,
            ROOMS_ERR_NO_PERMISSION = 655381,
            ROOMS_ERR_NOT_FOUND = 720917,
            ROOMS_ERR_ROOM_FULL = 786453,
            ROOMS_ERR_UNKNOWN_VIEW = 851989,
            ROOMS_ERR_ALREADY_MEMBER = 917525,
            ROOMS_ERR_NOT_MEMBER = 983061,
            ROOMS_ERR_ALREADY_REGISTERED = 1048597,
            ROOMS_ERR_NOT_REGISTERED = 1114133,
            ROOMS_ERR_JOIN_CRITERIA_FAILED = 1179669,
            ROOMS_ERR_JOIN_WRONG_PASSWORD = 1245205,
            ROOMS_ERR_CREATE_UNKNOWN_VIEW = 1310741,
            ROOMS_ERR_CREATE_SMALL_CAPACITY = 1376277,
            ROOMS_ERR_CREATE_BLANK_NAME = 1441813,
            ROOMS_ERR_CREATE_DUPLICATE_NAME = 1507349,
            ROOMS_ERR_CREATE_MAX_ROOMS = 1572885,
            ROOMS_ERR_CREATE_UNKNOWN_CATEGORY = 1638421,
            ROOMS_ERR_INVALID_CRITERIA = 1703957,
            ROOMS_ERR_CREATE_PROFANE_NAME = 1769493,
            ROOMS_ERR_JOIN_BANNED = 1835029,
            ROOMS_ERR_MEMBER_NOT_FOUND = 1900565,
        }

    }
}
