using Blaze.Core;
using Blaze3SDK.Blaze.Association;
using EATDF;
using EATDF.Types;

namespace Blaze3SDK.Components;

public static class AssociationListsComponentBase
{
    public const ushort Id = 25;
    public const string Name = "AssociationListsComponent";
    
    public enum Error : ushort {
        ASSOCIATIONLIST_ERR_USER_NOT_FOUND = 1,
        ASSOCIATIONLIST_ERR_DUPLICATE_USER_FOUND = 2,
        ASSOCIATIONLIST_ERR_CANNOT_INCLUDE_SELF = 3,
        ASSOCIATIONLIST_ERR_INVALID_USER = 4,
        ASSOCIATIONLIST_ERR_MEMBER_ALREADY_IN_THE_LIST = 5,
        ASSOCIATIONLIST_ERR_MEMBER_NOT_FOUND_IN_THE_LIST = 6,
        ASSOCIATIONLIST_ERR_LIST_ALREADY_SUBSCRIBED = 7,
        ASSOCIATIONLIST_ERR_LIST_NOT_SUBSCRIBED = 8,
        ASSOCIATIONLIST_ERR_INVALID_LIST_NAME = 9,
        ASSOCIATIONLIST_ERR_LIST_NOT_FOUND = 10,
        ASSOCIATIONLIST_ERR_LIST_IS_FULL_OR_TOO_MANY_USERS = 11,
        ASSOCIATIONLIST_ERR_LIST_IS_EMPTY = 12,
        ASSOCIATIONLIST_ERR_LIST_DB_ERROR = 13,
        ASSOCIATIONLIST_ERR_MUTUAL_ACTION_NOT_SUPPORTED = 14,
        ASSOCIATIONLIST_ERR_NON_MUTUAL_ACTION_NOT_SUPPORTED = 15,
        ASSOCIATIONLIST_ERR_PAIRED_LIST_MODIFICATION_NOT_SUPPORTED = 16,
        ASSOCIATIONLIST_ERR_PAIRED_LIST_IS_FULL_OR_TOO_MANY_USERS = 17,
    }
    
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
            RegisterCommand(new RpcCommandFunc<UpdateListMembersRequest, UpdateListMembersResponse, EmptyMessage>()
            {
                Id = (ushort)AssociationListsComponentCommand.addUsersToList,
                Name = "addUsersToList",
                IsSupported = IsCommandSupported(AssociationListsComponentCommand.addUsersToList),
                Func = async (req, ctx) => await AddUsersToListAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<UpdateListMembersRequest, UpdateListMembersResponse, EmptyMessage>()
            {
                Id = (ushort)AssociationListsComponentCommand.removeUsersFromList,
                Name = "removeUsersFromList",
                IsSupported = IsCommandSupported(AssociationListsComponentCommand.removeUsersFromList),
                Func = async (req, ctx) => await RemoveUsersFromListAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<UpdateListsRequest, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)AssociationListsComponentCommand.clearLists,
                Name = "clearLists",
                IsSupported = IsCommandSupported(AssociationListsComponentCommand.clearLists),
                Func = async (req, ctx) => await ClearListsAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<UpdateListMembersRequest, UpdateListMembersResponse, EmptyMessage>()
            {
                Id = (ushort)AssociationListsComponentCommand.setUsersToList,
                Name = "setUsersToList",
                IsSupported = IsCommandSupported(AssociationListsComponentCommand.setUsersToList),
                Func = async (req, ctx) => await SetUsersToListAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<GetListForUserRequest, ListMembers, EmptyMessage>()
            {
                Id = (ushort)AssociationListsComponentCommand.getListForUser,
                Name = "getListForUser",
                IsSupported = IsCommandSupported(AssociationListsComponentCommand.getListForUser),
                Func = async (req, ctx) => await GetListForUserAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<GetListsRequest, Lists, EmptyMessage>()
            {
                Id = (ushort)AssociationListsComponentCommand.getLists,
                Name = "getLists",
                IsSupported = IsCommandSupported(AssociationListsComponentCommand.getLists),
                Func = async (req, ctx) => await GetListsAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<UpdateListsRequest, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)AssociationListsComponentCommand.subscribeToLists,
                Name = "subscribeToLists",
                IsSupported = IsCommandSupported(AssociationListsComponentCommand.subscribeToLists),
                Func = async (req, ctx) => await SubscribeToListsAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<UpdateListsRequest, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)AssociationListsComponentCommand.unsubscribeFromLists,
                Name = "unsubscribeFromLists",
                IsSupported = IsCommandSupported(AssociationListsComponentCommand.unsubscribeFromLists),
                Func = async (req, ctx) => await UnsubscribeFromListsAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, ConfigLists, EmptyMessage>()
            {
                Id = (ushort)AssociationListsComponentCommand.getConfigListsInfo,
                Name = "getConfigListsInfo",
                IsSupported = IsCommandSupported(AssociationListsComponentCommand.getConfigListsInfo),
                Func = async (req, ctx) => await GetConfigListsInfoAsync(req, ctx).ConfigureAwait(false)
            });
            
        }
        
        public override string GetErrorName(ushort errorCode)
        {
            return ((Error)errorCode).ToString();
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AssociationListsComponent::addUsersToList</b> command.<br/>
        /// Request type: <see cref="UpdateListMembersRequest"/><br/>
        /// Response type: <see cref="UpdateListMembersResponse"/><br/>
        /// </summary>
        public virtual Task<UpdateListMembersResponse> AddUsersToListAsync(UpdateListMembersRequest request, BlazeRpcContext context)
        {
            throw new AssociationListsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AssociationListsComponent::removeUsersFromList</b> command.<br/>
        /// Request type: <see cref="UpdateListMembersRequest"/><br/>
        /// Response type: <see cref="UpdateListMembersResponse"/><br/>
        /// </summary>
        public virtual Task<UpdateListMembersResponse> RemoveUsersFromListAsync(UpdateListMembersRequest request, BlazeRpcContext context)
        {
            throw new AssociationListsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AssociationListsComponent::clearLists</b> command.<br/>
        /// Request type: <see cref="UpdateListsRequest"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> ClearListsAsync(UpdateListsRequest request, BlazeRpcContext context)
        {
            throw new AssociationListsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AssociationListsComponent::setUsersToList</b> command.<br/>
        /// Request type: <see cref="UpdateListMembersRequest"/><br/>
        /// Response type: <see cref="UpdateListMembersResponse"/><br/>
        /// </summary>
        public virtual Task<UpdateListMembersResponse> SetUsersToListAsync(UpdateListMembersRequest request, BlazeRpcContext context)
        {
            throw new AssociationListsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AssociationListsComponent::getListForUser</b> command.<br/>
        /// Request type: <see cref="GetListForUserRequest"/><br/>
        /// Response type: <see cref="ListMembers"/><br/>
        /// </summary>
        public virtual Task<ListMembers> GetListForUserAsync(GetListForUserRequest request, BlazeRpcContext context)
        {
            throw new AssociationListsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AssociationListsComponent::getLists</b> command.<br/>
        /// Request type: <see cref="GetListsRequest"/><br/>
        /// Response type: <see cref="Lists"/><br/>
        /// </summary>
        public virtual Task<Lists> GetListsAsync(GetListsRequest request, BlazeRpcContext context)
        {
            throw new AssociationListsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AssociationListsComponent::subscribeToLists</b> command.<br/>
        /// Request type: <see cref="UpdateListsRequest"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SubscribeToListsAsync(UpdateListsRequest request, BlazeRpcContext context)
        {
            throw new AssociationListsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AssociationListsComponent::unsubscribeFromLists</b> command.<br/>
        /// Request type: <see cref="UpdateListsRequest"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> UnsubscribeFromListsAsync(UpdateListsRequest request, BlazeRpcContext context)
        {
            throw new AssociationListsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>AssociationListsComponent::getConfigListsInfo</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="ConfigLists"/><br/>
        /// </summary>
        public virtual Task<ConfigLists> GetConfigListsInfoAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new AssociationListsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>AssociationListsComponent::NotifyUpdateListMembership</b> notification.<br/>
        /// Notification type: <see cref="UpdateListWithMembersRequest"/><br/>
        /// </summary>
        public static Task NotifyNotifyUpdateListMembershipAsync(BlazeRpcConnection connection, UpdateListWithMembersRequest notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = AssociationListsComponentBase.Id;
                frame.Command = (ushort)AssociationListsComponentNotification.NotifyUpdateListMembership;
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

