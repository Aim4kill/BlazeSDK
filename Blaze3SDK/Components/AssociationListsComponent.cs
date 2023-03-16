using Blaze3SDK.Blaze;
using BlazeCommon;
using static Blaze3SDK.Components.AssociationListsComponent;

namespace Blaze3SDK.Components
{
    public class AssociationListsComponent : ComponentData<AssociationListsComponentCommand, AssociationListsComponentNotification, AssociationListsComponentError>
    {
        public AssociationListsComponent() : base((ushort)Component.AssociationListsComponent)
        {

        }

        public override Type GetCommandErrorResponseType(AssociationListsComponentCommand command) => command switch
        {
            AssociationListsComponentCommand.addUsersToList => throw new NotImplementedException(),
            AssociationListsComponentCommand.removeUsersFromList => throw new NotImplementedException(),
            AssociationListsComponentCommand.clearLists => throw new NotImplementedException(),
            AssociationListsComponentCommand.setUsersToList => throw new NotImplementedException(),
            AssociationListsComponentCommand.getListForUser => throw new NotImplementedException(),
            AssociationListsComponentCommand.getLists => throw new NotImplementedException(),
            AssociationListsComponentCommand.subscribeToLists => throw new NotImplementedException(),
            AssociationListsComponentCommand.unsubscribeFromLists => throw new NotImplementedException(),
            AssociationListsComponentCommand.getConfigListsInfo => throw new NotImplementedException(),
            _ => typeof(NullStruct)
        };

        public override Type GetCommandRequestType(AssociationListsComponentCommand command) => command switch
        {
            AssociationListsComponentCommand.addUsersToList => throw new NotImplementedException(),
            AssociationListsComponentCommand.removeUsersFromList => throw new NotImplementedException(),
            AssociationListsComponentCommand.clearLists => throw new NotImplementedException(),
            AssociationListsComponentCommand.setUsersToList => throw new NotImplementedException(),
            AssociationListsComponentCommand.getListForUser => throw new NotImplementedException(),
            AssociationListsComponentCommand.getLists => throw new NotImplementedException(),
            AssociationListsComponentCommand.subscribeToLists => throw new NotImplementedException(),
            AssociationListsComponentCommand.unsubscribeFromLists => throw new NotImplementedException(),
            AssociationListsComponentCommand.getConfigListsInfo => throw new NotImplementedException(),
            _ => typeof(NullStruct)
        };

        public override Type GetCommandResponseType(AssociationListsComponentCommand command) => command switch
        {
            AssociationListsComponentCommand.addUsersToList => throw new NotImplementedException(),
            AssociationListsComponentCommand.removeUsersFromList => throw new NotImplementedException(),
            AssociationListsComponentCommand.clearLists => throw new NotImplementedException(),
            AssociationListsComponentCommand.setUsersToList => throw new NotImplementedException(),
            AssociationListsComponentCommand.getListForUser => throw new NotImplementedException(),
            AssociationListsComponentCommand.getLists => throw new NotImplementedException(),
            AssociationListsComponentCommand.subscribeToLists => throw new NotImplementedException(),
            AssociationListsComponentCommand.unsubscribeFromLists => throw new NotImplementedException(),
            AssociationListsComponentCommand.getConfigListsInfo => throw new NotImplementedException(),
            _ => typeof(NullStruct)
        };

        public override Type GetNotificationType(AssociationListsComponentNotification notification) => notification switch
        {
            AssociationListsComponentNotification.NotifyUpdateListMembership => throw new NotImplementedException(),
            _ => typeof(NullStruct)
        };

        public enum AssociationListsComponentCommand : ushort
        {
            addUsersToList = 1,
            removeUsersFromList = 2,
            clearLists = 3,
            setUsersToList = 4,
            getListForUser = 5,
            getLists = 6,
            subscribeToLists = 7,
            unsubscribeFromLists = 8,
            getConfigListsInfo = 9,
        }

        public enum AssociationListsComponentNotification : ushort
        {
            NotifyUpdateListMembership = 1,
        }

        public enum AssociationListsComponentError
        {
            ASSOCIATIONLIST_ERR_USER_NOT_FOUND = 65561,
            ASSOCIATIONLIST_ERR_DUPLICATE_USER_FOUND = 131097,
            ASSOCIATIONLIST_ERR_CANNOT_INCLUDE_SELF = 196633,
            ASSOCIATIONLIST_ERR_INVALID_USER = 262169,
            ASSOCIATIONLIST_ERR_MEMBER_ALREADY_IN_THE_LIST = 327705,
            ASSOCIATIONLIST_ERR_MEMBER_NOT_FOUND_IN_THE_LIST = 393241,
            ASSOCIATIONLIST_ERR_LIST_ALREADY_SUBSCRIBED = 458777,
            ASSOCIATIONLIST_ERR_LIST_NOT_SUBSCRIBED = 524313,
            ASSOCIATIONLIST_ERR_INVALID_LIST_NAME = 589849,
            ASSOCIATIONLIST_ERR_LIST_NOT_FOUND = 655385,
            ASSOCIATIONLIST_ERR_LIST_IS_FULL_OR_TOO_MANY_USERS = 720921,
            ASSOCIATIONLIST_ERR_LIST_IS_EMPTY = 786457,
            ASSOCIATIONLIST_ERR_LIST_DB_ERROR = 851993,
            ASSOCIATIONLIST_ERR_MUTUAL_ACTION_NOT_SUPPORTED = 917529,
            ASSOCIATIONLIST_ERR_NON_MUTUAL_ACTION_NOT_SUPPORTED = 983065,
            ASSOCIATIONLIST_ERR_PAIRED_LIST_MODIFICATION_NOT_SUPPORTED = 1048601,
            ASSOCIATIONLIST_ERR_PAIRED_LIST_IS_FULL_OR_TOO_MANY_USERS = 1114137,
        }

    }
}
