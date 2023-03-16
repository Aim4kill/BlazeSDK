using Blaze3SDK.Blaze;
using BlazeCommon;
using static Blaze3SDK.Components.LockerComponent;

namespace Blaze3SDK.Components
{
    public class LockerComponent : ComponentData<LockerComponentCommand, LockerComponentNotification, LockerComponentError>
    {
        public LockerComponent() : base((ushort)Component.LockerComponent)
        {

        }

        public override Type GetCommandErrorResponseType(LockerComponentCommand command) => command switch
        {
            LockerComponentCommand.createContent => throw new NotImplementedException(),
            LockerComponentCommand.createSubContent => throw new NotImplementedException(),
            LockerComponentCommand.confirmUpload => throw new NotImplementedException(),
            LockerComponentCommand.updateContentInfo => throw new NotImplementedException(),
            LockerComponentCommand.deleteContent => throw new NotImplementedException(),
            LockerComponentCommand.copyContentReference => throw new NotImplementedException(),
            LockerComponentCommand.bookmarkContentReference => throw new NotImplementedException(),
            LockerComponentCommand.getContentInfo => throw new NotImplementedException(),
            LockerComponentCommand.ListContent => throw new NotImplementedException(),
            LockerComponentCommand.getTopN => throw new NotImplementedException(),
            LockerComponentCommand.getLeaderboardView => throw new NotImplementedException(),
            LockerComponentCommand.updateRating => throw new NotImplementedException(),
            LockerComponentCommand.incrementUseCount => throw new NotImplementedException(),
            LockerComponentCommand.setOwnerGroup => throw new NotImplementedException(),
            LockerComponentCommand.removeOwnerGroup => throw new NotImplementedException(),
            LockerComponentCommand.listContentForUsers => throw new NotImplementedException(),
            LockerComponentCommand.WipeContent => throw new NotImplementedException(),
            LockerComponentCommand.getCategoryList => throw new NotImplementedException(),
            LockerComponentCommand.getLeaderboardList => throw new NotImplementedException(),
            _ => typeof(NullStruct)
        };

        public override Type GetCommandRequestType(LockerComponentCommand command) => command switch
        {
            LockerComponentCommand.createContent => throw new NotImplementedException(),
            LockerComponentCommand.createSubContent => throw new NotImplementedException(),
            LockerComponentCommand.confirmUpload => throw new NotImplementedException(),
            LockerComponentCommand.updateContentInfo => throw new NotImplementedException(),
            LockerComponentCommand.deleteContent => throw new NotImplementedException(),
            LockerComponentCommand.copyContentReference => throw new NotImplementedException(),
            LockerComponentCommand.bookmarkContentReference => throw new NotImplementedException(),
            LockerComponentCommand.getContentInfo => throw new NotImplementedException(),
            LockerComponentCommand.ListContent => throw new NotImplementedException(),
            LockerComponentCommand.getTopN => throw new NotImplementedException(),
            LockerComponentCommand.getLeaderboardView => throw new NotImplementedException(),
            LockerComponentCommand.updateRating => throw new NotImplementedException(),
            LockerComponentCommand.incrementUseCount => throw new NotImplementedException(),
            LockerComponentCommand.setOwnerGroup => throw new NotImplementedException(),
            LockerComponentCommand.removeOwnerGroup => throw new NotImplementedException(),
            LockerComponentCommand.listContentForUsers => throw new NotImplementedException(),
            LockerComponentCommand.WipeContent => throw new NotImplementedException(),
            LockerComponentCommand.getCategoryList => throw new NotImplementedException(),
            LockerComponentCommand.getLeaderboardList => throw new NotImplementedException(),
            _ => typeof(NullStruct)
        };

        public override Type GetCommandResponseType(LockerComponentCommand command) => command switch
        {
            LockerComponentCommand.createContent => throw new NotImplementedException(),
            LockerComponentCommand.createSubContent => throw new NotImplementedException(),
            LockerComponentCommand.confirmUpload => throw new NotImplementedException(),
            LockerComponentCommand.updateContentInfo => throw new NotImplementedException(),
            LockerComponentCommand.deleteContent => throw new NotImplementedException(),
            LockerComponentCommand.copyContentReference => throw new NotImplementedException(),
            LockerComponentCommand.bookmarkContentReference => throw new NotImplementedException(),
            LockerComponentCommand.getContentInfo => throw new NotImplementedException(),
            LockerComponentCommand.ListContent => throw new NotImplementedException(),
            LockerComponentCommand.getTopN => throw new NotImplementedException(),
            LockerComponentCommand.getLeaderboardView => throw new NotImplementedException(),
            LockerComponentCommand.updateRating => throw new NotImplementedException(),
            LockerComponentCommand.incrementUseCount => throw new NotImplementedException(),
            LockerComponentCommand.setOwnerGroup => throw new NotImplementedException(),
            LockerComponentCommand.removeOwnerGroup => throw new NotImplementedException(),
            LockerComponentCommand.listContentForUsers => throw new NotImplementedException(),
            LockerComponentCommand.WipeContent => throw new NotImplementedException(),
            LockerComponentCommand.getCategoryList => throw new NotImplementedException(),
            LockerComponentCommand.getLeaderboardList => throw new NotImplementedException(),
            _ => typeof(NullStruct)
        };

        public override Type GetNotificationType(LockerComponentNotification notification) => notification switch
        {
            _ => typeof(NullStruct)
        };

        public enum LockerComponentCommand : ushort
        {
            createContent = 1,
            createSubContent = 2,
            confirmUpload = 3,
            updateContentInfo = 4,
            deleteContent = 5,
            copyContentReference = 6,
            bookmarkContentReference = 7,
            getContentInfo = 8,
            ListContent = 9,
            getTopN = 10,
            getLeaderboardView = 11,
            updateRating = 12,
            incrementUseCount = 13,
            setOwnerGroup = 14,
            removeOwnerGroup = 15,
            listContentForUsers = 16,
            WipeContent = 17,
            getCategoryList = 18,
            getLeaderboardList = 19,
        }

        public enum LockerComponentNotification : ushort
        {
        }

        public enum LockerComponentError
        {
            LOCKER_ERR_INVALID_LEADERBOARD_VIEW = 131092,
            LOCKER_ERR_INVALID_CONTENT_ID = 196628,
            LOCKER_ERR_ATTR_NOT_FOUND = 327700,
            LOCKER_ERR_INVALID_LOCKER_TYPE = 393236,
            LOCKER_ERR_UNKNOWN_STATUS = 458772,
            LOCKER_ERR_INVALID_PERMISSION_TYPE = 524308,
            LOCKER_ERR_NOT_AUTHORIZED = 589844,
            LOCKER_ERR_MAX_ITEMS_REACHED = 655380,
            LOCKER_ERR_MAX_SIZE = 720916,
            LOCKER_ERR_INVALID_ENTITY_ID = 786452,
            LOCKER_ERR_INVALID_GROUP_ID = 851988,
            LOCKER_ERR_NON_SEARCHABLE_ATTR = 983060,
            LOCKER_ERR_NOT_ACTIVE = 1114132,
            LOCKER_ERR_CONTENT_NOT_FOUND = 1179668,
            LOCKER_ERR_INVALID_LEADERBOARD_TYPE = 1245204,
            LOCKER_ERR_INVALID_REFERENCE = 1441812,
            LOCKER_ERR_SUBCONTENT_ALREADY_EXISTS = 1507348,
            LOCKER_ERR_ACTION_NOT_ALLOWED = 1572884,
            LOCKER_ERR_INVALID_REFERENCE_TYPE = 1638420,
            LOCKER_ERR_INVALID_ATTRIBUTE_NAME = 1703956,
            LOCKER_ERR_ATTRIBUTE_VALUE_NOT_MATCH_WITH_TYPE = 1769492,
            LOCKER_ERR_NO_OWNER_GROUP = 1835028,
            LOCKER_ERR_INVALID_OWNER_GROUP = 1900564,
            LOCKER_ERR_INVALID_ENTITY_AND_GROUP_ID = 1966100,
            LOCKER_ERR_LEADERBOARD_NOT_SUPPORTED = 2031636,
            LOCKER_ERR_TOO_MANY_SUBCONTENT_ITEMS = 2097172,
            LOCKER_ERR_CONTENT_ALREADY_CONFIRMED = 2162708,
            LOCKER_ERR_INVALID_SUBCONTENT_NAME = 2228244,
            LOCKER_ERR_INVALID_ENTITY_LIST_AND_GROUP_ID_AND_OBJECT_ID = 2293780,
        }

    }
}
