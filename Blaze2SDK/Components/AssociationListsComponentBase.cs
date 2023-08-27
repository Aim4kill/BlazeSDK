using Blaze2SDK.Blaze.Association;
using BlazeCommon;

namespace Blaze2SDK.Components
{
    public static class AssociationListsComponentBase
    {
        public const ushort Id = 25;
        public const string Name = "AssociationListsComponent";
        
        public class Server : BlazeComponent<AssociationListsComponentCommand, AssociationListsComponentNotification, Blaze2RpcError>
        {
            public Server() : base(AssociationListsComponentBase.Id, AssociationListsComponentBase.Name)
            {
                
            }
            
            [BlazeCommand((ushort)AssociationListsComponentCommand.addUsersToList)]
            public virtual Task<UpdateListResponse> AddUsersToListAsync(UpdateList request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AssociationListsComponentCommand.removeUsersFromList)]
            public virtual Task<UpdateListResponse> RemoveUsersFromListAsync(UpdateList request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AssociationListsComponentCommand.clearList)]
            public virtual Task<NullStruct> ClearListAsync(ClearList request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AssociationListsComponentCommand.setUsersToList)]
            public virtual Task<UpdateListResponse> SetUsersToListAsync(UpdateList request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AssociationListsComponentCommand.getListForUser)]
            public virtual Task<AssociationListInfo> GetListForUserAsync(GetListForUser request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AssociationListsComponentCommand.getLists)]
            public virtual Task<AssociationListCollectionInfo> GetListsAsync(GetUserLists request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AssociationListsComponentCommand.subscribeToLists)]
            public virtual Task<NullStruct> SubscribeToListsAsync(SubscriptionInfo request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AssociationListsComponentCommand.unsubscribeFromLists)]
            public virtual Task<NullStruct> UnsubscribeFromListsAsync(SubscriptionInfo request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            
            public static Task NotifyListMemberUpdatedAsync(BlazeServerConnection connection, MemberInfo notification)
            {
                return connection.NotifyAsync(AssociationListsComponentBase.Id, (ushort)AssociationListsComponentNotification.NotifyListMemberUpdated, notification);
            }
            
            public static Task NotifyListMemberRemovedAsync(BlazeServerConnection connection, AssociationListInfo notification)
            {
                return connection.NotifyAsync(AssociationListsComponentBase.Id, (ushort)AssociationListsComponentNotification.NotifyListMemberRemoved, notification);
            }
            
            public override Type GetCommandRequestType(AssociationListsComponentCommand command) => AssociationListsComponentBase.GetCommandRequestType(command);
            public override Type GetCommandResponseType(AssociationListsComponentCommand command) => AssociationListsComponentBase.GetCommandResponseType(command);
            public override Type GetCommandErrorResponseType(AssociationListsComponentCommand command) => AssociationListsComponentBase.GetCommandErrorResponseType(command);
            public override Type GetNotificationType(AssociationListsComponentNotification notification) => AssociationListsComponentBase.GetNotificationType(notification);
            
        }
        
        public class Client : BlazeComponent<AssociationListsComponentCommand, AssociationListsComponentNotification, Blaze2RpcError>
        {
            public Client() : base(AssociationListsComponentBase.Id, AssociationListsComponentBase.Name)
            {
                
            }
            
            public override Type GetCommandRequestType(AssociationListsComponentCommand command) => AssociationListsComponentBase.GetCommandRequestType(command);
            public override Type GetCommandResponseType(AssociationListsComponentCommand command) => AssociationListsComponentBase.GetCommandResponseType(command);
            public override Type GetCommandErrorResponseType(AssociationListsComponentCommand command) => AssociationListsComponentBase.GetCommandErrorResponseType(command);
            public override Type GetNotificationType(AssociationListsComponentNotification notification) => AssociationListsComponentBase.GetNotificationType(notification);
            
        }
        
        public static Type GetCommandRequestType(AssociationListsComponentCommand command) => command switch
        {
            AssociationListsComponentCommand.addUsersToList => typeof(UpdateList),
            AssociationListsComponentCommand.removeUsersFromList => typeof(UpdateList),
            AssociationListsComponentCommand.clearList => typeof(ClearList),
            AssociationListsComponentCommand.setUsersToList => typeof(UpdateList),
            AssociationListsComponentCommand.getListForUser => typeof(GetListForUser),
            AssociationListsComponentCommand.getLists => typeof(GetUserLists),
            AssociationListsComponentCommand.subscribeToLists => typeof(SubscriptionInfo),
            AssociationListsComponentCommand.unsubscribeFromLists => typeof(SubscriptionInfo),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandResponseType(AssociationListsComponentCommand command) => command switch
        {
            AssociationListsComponentCommand.addUsersToList => typeof(UpdateListResponse),
            AssociationListsComponentCommand.removeUsersFromList => typeof(UpdateListResponse),
            AssociationListsComponentCommand.clearList => typeof(NullStruct),
            AssociationListsComponentCommand.setUsersToList => typeof(UpdateListResponse),
            AssociationListsComponentCommand.getListForUser => typeof(AssociationListInfo),
            AssociationListsComponentCommand.getLists => typeof(AssociationListCollectionInfo),
            AssociationListsComponentCommand.subscribeToLists => typeof(NullStruct),
            AssociationListsComponentCommand.unsubscribeFromLists => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandErrorResponseType(AssociationListsComponentCommand command) => command switch
        {
            AssociationListsComponentCommand.addUsersToList => typeof(NullStruct),
            AssociationListsComponentCommand.removeUsersFromList => typeof(NullStruct),
            AssociationListsComponentCommand.clearList => typeof(NullStruct),
            AssociationListsComponentCommand.setUsersToList => typeof(NullStruct),
            AssociationListsComponentCommand.getListForUser => typeof(NullStruct),
            AssociationListsComponentCommand.getLists => typeof(NullStruct),
            AssociationListsComponentCommand.subscribeToLists => typeof(NullStruct),
            AssociationListsComponentCommand.unsubscribeFromLists => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetNotificationType(AssociationListsComponentNotification notification) => notification switch
        {
            AssociationListsComponentNotification.NotifyListMemberUpdated => typeof(MemberInfo),
            AssociationListsComponentNotification.NotifyListMemberRemoved => typeof(AssociationListInfo),
            _ => typeof(NullStruct)
        };
        
        public enum AssociationListsComponentCommand : ushort
        {
            addUsersToList = 1,
            removeUsersFromList = 2,
            clearList = 3,
            setUsersToList = 4,
            getListForUser = 5,
            getLists = 6,
            subscribeToLists = 7,
            unsubscribeFromLists = 8,
        }
        
        public enum AssociationListsComponentNotification : ushort
        {
            NotifyListMemberUpdated = 1,
            NotifyListMemberRemoved = 2,
        }
        
    }
}
