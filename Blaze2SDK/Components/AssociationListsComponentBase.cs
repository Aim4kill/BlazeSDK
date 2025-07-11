using Blaze.Core;
using Blaze2SDK.Blaze.Association;
using EATDF;
using EATDF.Types;

namespace Blaze2SDK.Components;

public static class AssociationListsComponentBase
{
    public const ushort Id = 25;
    public const string Name = "AssociationListsComponent";
    
    public enum Error : ushort {
        ASSOCIATIONLIST_ERR_USER_NOT_FOUND = 1,
        ASSOCIATIONLIST_ERR_DUPLICATE_USER_FOUND = 2,
        ASSOCIATIONLIST_ERR_USER_CAN_NOT_ADD_SELF = 3,
        ASSOCIATIONLIST_ERR_INVALID_USER = 4,
        ASSOCIATIONLIST_MEMBER_ALREADY_IN_THE_LIST = 5,
        ASSOCIATIONLIST_MEMBER_NOT_FOUND_IN_THE_LIST = 6,
        ASSOCIATIONLIST_MEMBER_DUPLICATE = 7,
        ASSOCIATIONLIST_ERR_ALREADY_SUBSCRIBED_TO_LST = 8,
        ASSOCIATIONLIST_ERR_NOT_SUBSCRIBED_TO_LST = 9,
        ASSOCIATIONLIST_ERR_INVALID_LIST_NAME = 10,
        ASSOCIATIONLIST_ERR_LIST_NOT_FOUND = 11,
        ASSOCIATIONLIST_ERR_LIST_IS_FULL_OR_TOO_MANY_USERS = 12,
        ASSOCIATIONLIST_ERR_LIST_IS_EMPTY = 13,
        ASSOCIATIONLIST_ERR_LIST_ALREADY_SUBSCRIBED = 14,
        ASSOCIATIONLIST_ERR_LIST_NOT_SUBSCRIBED = 15,
        ASSOCIATIONLIST_ERR_LIST_DB_ERROR = 16,
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
    
    public class Server : BlazeComponent {
        public override ushort Id => AssociationListsComponentBase.Id;
        public override string Name => AssociationListsComponentBase.Name;
        
        public virtual bool IsCommandSupported(AssociationListsComponentCommand command) => false;
        
        public class AssociationListsException : BlazeRpcException
        {
            public AssociationListsException(Error error) : base((ushort)error, null) { }
            public AssociationListsException(ServerError error) : base(error.WithErrorPrefix(), null) { }
            public AssociationListsException(Error error, Tdf? errorResponse) : base((ushort)error, errorResponse) { }
            public AssociationListsException(ServerError error, Tdf? errorResponse) : base(error.WithErrorPrefix(), errorResponse) { }
            public AssociationListsException(Error error, Tdf? errorResponse, string? message) : base((ushort)error, errorResponse, message) { }
            public AssociationListsException(ServerError error, Tdf? errorResponse, string? message) : base(error.WithErrorPrefix(), errorResponse, message) { }
            public AssociationListsException(Error error, Tdf? errorResponse, string? message, Exception? innerException) : base((ushort)error, errorResponse, message, innerException) { }
            public AssociationListsException(ServerError error, Tdf? errorResponse, string? message, Exception? innerException) : base(error.WithErrorPrefix(), errorResponse, message, innerException) { }
        }
        
        public Server()
        {
            RegisterCommand(new RpcCommandFunc<UpdateList, UpdateListResponse, EmptyMessage>()
            {
                Id = (ushort)AssociationListsComponentCommand.addUsersToList,
                Name = "addUsersToList",
                IsSupported = IsCommandSupported(AssociationListsComponentCommand.addUsersToList),
                Func = async (req, ctx) => await AddUsersToListAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<UpdateList, UpdateListResponse, EmptyMessage>()
            {
                Id = (ushort)AssociationListsComponentCommand.removeUsersFromList,
                Name = "removeUsersFromList",
                IsSupported = IsCommandSupported(AssociationListsComponentCommand.removeUsersFromList),
                Func = async (req, ctx) => await RemoveUsersFromListAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<ClearList, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)AssociationListsComponentCommand.clearList,
                Name = "clearList",
                IsSupported = IsCommandSupported(AssociationListsComponentCommand.clearList),
                Func = async (req, ctx) => await ClearListAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<UpdateList, UpdateListResponse, EmptyMessage>()
            {
                Id = (ushort)AssociationListsComponentCommand.setUsersToList,
                Name = "setUsersToList",
                IsSupported = IsCommandSupported(AssociationListsComponentCommand.setUsersToList),
                Func = async (req, ctx) => await SetUsersToListAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<GetListForUser, AssociationListInfo, EmptyMessage>()
            {
                Id = (ushort)AssociationListsComponentCommand.getListForUser,
                Name = "getListForUser",
                IsSupported = IsCommandSupported(AssociationListsComponentCommand.getListForUser),
                Func = async (req, ctx) => await GetListForUserAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<GetUserLists, AssociationListCollectionInfo, EmptyMessage>()
            {
                Id = (ushort)AssociationListsComponentCommand.getLists,
                Name = "getLists",
                IsSupported = IsCommandSupported(AssociationListsComponentCommand.getLists),
                Func = async (req, ctx) => await GetListsAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<SubscriptionInfo, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)AssociationListsComponentCommand.subscribeToLists,
                Name = "subscribeToLists",
                IsSupported = IsCommandSupported(AssociationListsComponentCommand.subscribeToLists),
                Func = async (req, ctx) => await SubscribeToListsAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<SubscriptionInfo, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)AssociationListsComponentCommand.unsubscribeFromLists,
                Name = "unsubscribeFromLists",
                IsSupported = IsCommandSupported(AssociationListsComponentCommand.unsubscribeFromLists),
                Func = async (req, ctx) => await UnsubscribeFromListsAsync(req, ctx).ConfigureAwait(false)
            });
            
        }
        
        public override string GetErrorName(ushort errorCode)
        {
            return ((Error)errorCode).ToString();
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AssociationListsComponent::addUsersToList</b> command.<br/>
        /// Request type: <see cref="UpdateList"/><br/>
        /// Response type: <see cref="UpdateListResponse"/><br/>
        /// </summary>
        public virtual Task<UpdateListResponse> AddUsersToListAsync(UpdateList request, BlazeRpcContext context)
        {
            throw new AssociationListsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AssociationListsComponent::removeUsersFromList</b> command.<br/>
        /// Request type: <see cref="UpdateList"/><br/>
        /// Response type: <see cref="UpdateListResponse"/><br/>
        /// </summary>
        public virtual Task<UpdateListResponse> RemoveUsersFromListAsync(UpdateList request, BlazeRpcContext context)
        {
            throw new AssociationListsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AssociationListsComponent::clearList</b> command.<br/>
        /// Request type: <see cref="ClearList"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> ClearListAsync(ClearList request, BlazeRpcContext context)
        {
            throw new AssociationListsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AssociationListsComponent::setUsersToList</b> command.<br/>
        /// Request type: <see cref="UpdateList"/><br/>
        /// Response type: <see cref="UpdateListResponse"/><br/>
        /// </summary>
        public virtual Task<UpdateListResponse> SetUsersToListAsync(UpdateList request, BlazeRpcContext context)
        {
            throw new AssociationListsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AssociationListsComponent::getListForUser</b> command.<br/>
        /// Request type: <see cref="GetListForUser"/><br/>
        /// Response type: <see cref="AssociationListInfo"/><br/>
        /// </summary>
        public virtual Task<AssociationListInfo> GetListForUserAsync(GetListForUser request, BlazeRpcContext context)
        {
            throw new AssociationListsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AssociationListsComponent::getLists</b> command.<br/>
        /// Request type: <see cref="GetUserLists"/><br/>
        /// Response type: <see cref="AssociationListCollectionInfo"/><br/>
        /// </summary>
        public virtual Task<AssociationListCollectionInfo> GetListsAsync(GetUserLists request, BlazeRpcContext context)
        {
            throw new AssociationListsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AssociationListsComponent::subscribeToLists</b> command.<br/>
        /// Request type: <see cref="SubscriptionInfo"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SubscribeToListsAsync(SubscriptionInfo request, BlazeRpcContext context)
        {
            throw new AssociationListsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AssociationListsComponent::unsubscribeFromLists</b> command.<br/>
        /// Request type: <see cref="SubscriptionInfo"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> UnsubscribeFromListsAsync(SubscriptionInfo request, BlazeRpcContext context)
        {
            throw new AssociationListsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>AssociationListsComponent::NotifyListMemberUpdated</b> notification.<br/>
        /// Notification type: <see cref="MemberInfo"/><br/>
        /// </summary>
        public static Task NotifyNotifyListMemberUpdatedAsync(BlazeRpcConnection connection, MemberInfo notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = AssociationListsComponentBase.Id;
                frame.Command = (ushort)AssociationListsComponentNotification.NotifyListMemberUpdated;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>AssociationListsComponent::NotifyListMemberRemoved</b> notification.<br/>
        /// Notification type: <see cref="AssociationListInfo"/><br/>
        /// </summary>
        public static Task NotifyNotifyListMemberRemovedAsync(BlazeRpcConnection connection, AssociationListInfo notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = AssociationListsComponentBase.Id;
                frame.Command = (ushort)AssociationListsComponentNotification.NotifyListMemberRemoved;
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

