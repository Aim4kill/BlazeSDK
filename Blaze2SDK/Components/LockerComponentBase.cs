using Blaze.Core;
using EATDF;
using EATDF.Types;

namespace Blaze2SDK.Components;

public static class LockerComponentBase
{
    public const ushort Id = 20;
    public const string Name = "LockerComponent";
    
    public enum Error : ushort {
        LOCKER_ERR_INVALID_LEADERBOARD_VIEW = 2,
        LOCKER_ERR_INVALID_CONTENT_ID = 3,
        LOCKER_ERR_UNKNOWN_CATEGORY = 4,
        LOCKER_ERR_ATTR_NOT_FOUND = 5,
        LOCKER_ERR_INVALID_LOCKER_TYPE = 6,
        LOCKER_ERR_UNKNOWN_STATUS = 7,
        LOCKER_ERR_INVALID_PERMISSION_TYPE = 8,
        LOCKER_ERR_NOT_AUTHORIZED = 9,
        LOCKER_ERR_MAX_ITEMS_REACHED = 10,
        LOCKER_ERR_MAX_SIZE = 11,
        LOCKER_ERR_INVALID_ENTITY_ID = 12,
        LOCKER_ERR_INVALID_GROUP_ID = 13,
        LOCKER_ERR_INVALID_CONTEXT_ID = 14,
        LOCKER_ERR_NON_SEARCHABLE_ATTR = 15,
        LOCKER_ERR_INVALID_RATING = 16,
        LOCKER_ERR_NOT_ACTIVE = 17,
        LOCKER_ERR_CONTENT_NOT_FOUND = 18,
        LOCKER_ERR_INVALID_LEADERBOARD_TYPE = 19,
        LOCKER_ERR_DB_CONNECTION_FAIL = 20,
        LOCKER_ERR_DB_ERROR = 21,
        LOCKER_ERR_INVALID_REFERENCE = 22,
        LOCKER_ERR_SUBCONTENT_ALREADY_EXISTS = 23,
        LOCKER_ERR_ACTION_NOT_ALLOWED = 24,
        LOCKER_ERR_INVALID_REFERENCE_TYPE = 25,
        LOCKER_ERR_INVALID_ATTRIBUTE_NAME = 26,
        LOCKER_ERR_ATTRIBUTE_VALUE_NOT_MATCH_WITH_TYPE = 27,
        LOCKER_ERR_NO_OWNER_GROUP = 28,
        LOCKER_ERR_INVALID_OWNER_GROUP = 29,
        LOCKER_ERR_INVALID_ENTITY_AND_GROUP_ID = 30,
    }
    
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
    }
    
    public enum LockerComponentNotification : ushort
    {
    }
    
    public class Server : BlazeComponent {
        public override ushort Id => LockerComponentBase.Id;
        public override string Name => LockerComponentBase.Name;
        
        public virtual bool IsCommandSupported(LockerComponentCommand command) => false;
        
        public class LockerException : BlazeRpcException
        {
            public LockerException(Error error) : base((ushort)error, null) { }
            public LockerException(ServerError error) : base(error.WithErrorPrefix(), null) { }
            public LockerException(Error error, Tdf? errorResponse) : base((ushort)error, errorResponse) { }
            public LockerException(ServerError error, Tdf? errorResponse) : base(error.WithErrorPrefix(), errorResponse) { }
            public LockerException(Error error, Tdf? errorResponse, string? message) : base((ushort)error, errorResponse, message) { }
            public LockerException(ServerError error, Tdf? errorResponse, string? message) : base(error.WithErrorPrefix(), errorResponse, message) { }
            public LockerException(Error error, Tdf? errorResponse, string? message, Exception? innerException) : base((ushort)error, errorResponse, message, innerException) { }
            public LockerException(ServerError error, Tdf? errorResponse, string? message, Exception? innerException) : base(error.WithErrorPrefix(), errorResponse, message, innerException) { }
        }
        
        public Server()
        {
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)LockerComponentCommand.createContent,
                Name = "createContent",
                IsSupported = IsCommandSupported(LockerComponentCommand.createContent),
                Func = async (req, ctx) => await CreateContentAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)LockerComponentCommand.createSubContent,
                Name = "createSubContent",
                IsSupported = IsCommandSupported(LockerComponentCommand.createSubContent),
                Func = async (req, ctx) => await CreateSubContentAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)LockerComponentCommand.confirmUpload,
                Name = "confirmUpload",
                IsSupported = IsCommandSupported(LockerComponentCommand.confirmUpload),
                Func = async (req, ctx) => await ConfirmUploadAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)LockerComponentCommand.updateContentInfo,
                Name = "updateContentInfo",
                IsSupported = IsCommandSupported(LockerComponentCommand.updateContentInfo),
                Func = async (req, ctx) => await UpdateContentInfoAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)LockerComponentCommand.deleteContent,
                Name = "deleteContent",
                IsSupported = IsCommandSupported(LockerComponentCommand.deleteContent),
                Func = async (req, ctx) => await DeleteContentAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)LockerComponentCommand.copyContentReference,
                Name = "copyContentReference",
                IsSupported = IsCommandSupported(LockerComponentCommand.copyContentReference),
                Func = async (req, ctx) => await CopyContentReferenceAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)LockerComponentCommand.bookmarkContentReference,
                Name = "bookmarkContentReference",
                IsSupported = IsCommandSupported(LockerComponentCommand.bookmarkContentReference),
                Func = async (req, ctx) => await BookmarkContentReferenceAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)LockerComponentCommand.getContentInfo,
                Name = "getContentInfo",
                IsSupported = IsCommandSupported(LockerComponentCommand.getContentInfo),
                Func = async (req, ctx) => await GetContentInfoAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)LockerComponentCommand.ListContent,
                Name = "ListContent",
                IsSupported = IsCommandSupported(LockerComponentCommand.ListContent),
                Func = async (req, ctx) => await ListContentAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)LockerComponentCommand.getTopN,
                Name = "getTopN",
                IsSupported = IsCommandSupported(LockerComponentCommand.getTopN),
                Func = async (req, ctx) => await GetTopNAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)LockerComponentCommand.getLeaderboardView,
                Name = "getLeaderboardView",
                IsSupported = IsCommandSupported(LockerComponentCommand.getLeaderboardView),
                Func = async (req, ctx) => await GetLeaderboardViewAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)LockerComponentCommand.updateRating,
                Name = "updateRating",
                IsSupported = IsCommandSupported(LockerComponentCommand.updateRating),
                Func = async (req, ctx) => await UpdateRatingAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)LockerComponentCommand.incrementUseCount,
                Name = "incrementUseCount",
                IsSupported = IsCommandSupported(LockerComponentCommand.incrementUseCount),
                Func = async (req, ctx) => await IncrementUseCountAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)LockerComponentCommand.setOwnerGroup,
                Name = "setOwnerGroup",
                IsSupported = IsCommandSupported(LockerComponentCommand.setOwnerGroup),
                Func = async (req, ctx) => await SetOwnerGroupAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)LockerComponentCommand.removeOwnerGroup,
                Name = "removeOwnerGroup",
                IsSupported = IsCommandSupported(LockerComponentCommand.removeOwnerGroup),
                Func = async (req, ctx) => await RemoveOwnerGroupAsync(req, ctx).ConfigureAwait(false)
            });
            
        }
        
        public override string GetErrorName(ushort errorCode)
        {
            return ((Error)errorCode).ToString();
        }
        
        /// <summary>
        /// This method is called when server receives a <b>LockerComponent::createContent</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> CreateContentAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new LockerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>LockerComponent::createSubContent</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> CreateSubContentAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new LockerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>LockerComponent::confirmUpload</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> ConfirmUploadAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new LockerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>LockerComponent::updateContentInfo</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> UpdateContentInfoAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new LockerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>LockerComponent::deleteContent</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> DeleteContentAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new LockerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>LockerComponent::copyContentReference</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> CopyContentReferenceAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new LockerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>LockerComponent::bookmarkContentReference</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> BookmarkContentReferenceAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new LockerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>LockerComponent::getContentInfo</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetContentInfoAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new LockerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>LockerComponent::ListContent</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> ListContentAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new LockerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>LockerComponent::getTopN</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetTopNAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new LockerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>LockerComponent::getLeaderboardView</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetLeaderboardViewAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new LockerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>LockerComponent::updateRating</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> UpdateRatingAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new LockerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>LockerComponent::incrementUseCount</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> IncrementUseCountAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new LockerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>LockerComponent::setOwnerGroup</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SetOwnerGroupAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new LockerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>LockerComponent::removeOwnerGroup</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> RemoveOwnerGroupAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new LockerException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
    }
    
}

