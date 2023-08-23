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
        }
        
        public class Client : BlazeComponent<AssociationListsComponentCommand, AssociationListsComponentNotification, Blaze2RpcError>
        {
            public Client() : base(AssociationListsComponentBase.Id, AssociationListsComponentBase.Name)
            {
                
            }
        }
        
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
