using Blaze3SDK.Blaze.Association;
using BlazeCommon;

namespace Blaze3SDK.Components
{
    public static class AssociationListsComponentBase
    {
        public const ushort Id = 25;
        public const string Name = "AssociationListsComponent";
        
        public class Server : BlazeComponent<AssociationListsComponentCommand, AssociationListsComponentNotification, Blaze3RpcError>
        {
            public Server() : base(AssociationListsComponentBase.Id, AssociationListsComponentBase.Name)
            {
                
            }
            
            [BlazeCommand((ushort)AssociationListsComponentCommand.addUsersToList)]
            public virtual Task<UpdateListMembersResponse> AddUsersToListAsync(UpdateListMembersRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AssociationListsComponentCommand.removeUsersFromList)]
            public virtual Task<UpdateListMembersResponse> RemoveUsersFromListAsync(UpdateListMembersRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AssociationListsComponentCommand.clearLists)]
            public virtual Task<NullStruct> ClearListsAsync(UpdateListsRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AssociationListsComponentCommand.setUsersToList)]
            public virtual Task<UpdateListMembersResponse> SetUsersToListAsync(UpdateListMembersRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AssociationListsComponentCommand.getListForUser)]
            public virtual Task<ListMembers> GetListForUserAsync(GetListForUserRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AssociationListsComponentCommand.getLists)]
            public virtual Task<Lists> GetListsAsync(GetListsRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AssociationListsComponentCommand.subscribeToLists)]
            public virtual Task<NullStruct> SubscribeToListsAsync(UpdateListsRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AssociationListsComponentCommand.unsubscribeFromLists)]
            public virtual Task<NullStruct> UnsubscribeFromListsAsync(UpdateListsRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)AssociationListsComponentCommand.getConfigListsInfo)]
            public virtual Task<ConfigLists> GetConfigListsInfoAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            
            public static Task NotifyUpdateListMembershipAsync(BlazeServerConnection connection, UpdateListWithMembersRequest notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(AssociationListsComponentBase.Id, (ushort)AssociationListsComponentNotification.NotifyUpdateListMembership, notification, waitUntilFree);
            }
            
            public override Type GetCommandRequestType(AssociationListsComponentCommand command) => AssociationListsComponentBase.GetCommandRequestType(command);
            public override Type GetCommandResponseType(AssociationListsComponentCommand command) => AssociationListsComponentBase.GetCommandResponseType(command);
            public override Type GetCommandErrorResponseType(AssociationListsComponentCommand command) => AssociationListsComponentBase.GetCommandErrorResponseType(command);
            public override Type GetNotificationType(AssociationListsComponentNotification notification) => AssociationListsComponentBase.GetNotificationType(notification);
            
        }
        
        public class Client : BlazeComponent<AssociationListsComponentCommand, AssociationListsComponentNotification, Blaze3RpcError>
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
            AssociationListsComponentCommand.addUsersToList => typeof(UpdateListMembersRequest),
            AssociationListsComponentCommand.removeUsersFromList => typeof(UpdateListMembersRequest),
            AssociationListsComponentCommand.clearLists => typeof(UpdateListsRequest),
            AssociationListsComponentCommand.setUsersToList => typeof(UpdateListMembersRequest),
            AssociationListsComponentCommand.getListForUser => typeof(GetListForUserRequest),
            AssociationListsComponentCommand.getLists => typeof(GetListsRequest),
            AssociationListsComponentCommand.subscribeToLists => typeof(UpdateListsRequest),
            AssociationListsComponentCommand.unsubscribeFromLists => typeof(UpdateListsRequest),
            AssociationListsComponentCommand.getConfigListsInfo => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandResponseType(AssociationListsComponentCommand command) => command switch
        {
            AssociationListsComponentCommand.addUsersToList => typeof(UpdateListMembersResponse),
            AssociationListsComponentCommand.removeUsersFromList => typeof(UpdateListMembersResponse),
            AssociationListsComponentCommand.clearLists => typeof(NullStruct),
            AssociationListsComponentCommand.setUsersToList => typeof(UpdateListMembersResponse),
            AssociationListsComponentCommand.getListForUser => typeof(ListMembers),
            AssociationListsComponentCommand.getLists => typeof(Lists),
            AssociationListsComponentCommand.subscribeToLists => typeof(NullStruct),
            AssociationListsComponentCommand.unsubscribeFromLists => typeof(NullStruct),
            AssociationListsComponentCommand.getConfigListsInfo => typeof(ConfigLists),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandErrorResponseType(AssociationListsComponentCommand command) => command switch
        {
            AssociationListsComponentCommand.addUsersToList => typeof(NullStruct),
            AssociationListsComponentCommand.removeUsersFromList => typeof(NullStruct),
            AssociationListsComponentCommand.clearLists => typeof(NullStruct),
            AssociationListsComponentCommand.setUsersToList => typeof(NullStruct),
            AssociationListsComponentCommand.getListForUser => typeof(NullStruct),
            AssociationListsComponentCommand.getLists => typeof(NullStruct),
            AssociationListsComponentCommand.subscribeToLists => typeof(NullStruct),
            AssociationListsComponentCommand.unsubscribeFromLists => typeof(NullStruct),
            AssociationListsComponentCommand.getConfigListsInfo => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetNotificationType(AssociationListsComponentNotification notification) => notification switch
        {
            AssociationListsComponentNotification.NotifyUpdateListMembership => typeof(UpdateListWithMembersRequest),
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
        
    }
}
