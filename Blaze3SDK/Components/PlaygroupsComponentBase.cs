using Blaze3SDK.Blaze.Playgroups;
using BlazeCommon;

namespace Blaze3SDK.Components
{
    public static class PlaygroupsComponentBase
    {
        public const ushort Id = 6;
        public const string Name = "PlaygroupsComponent";
        
        public class Server : BlazeComponent<PlaygroupsComponentCommand, PlaygroupsComponentNotification, Blaze3RpcError>
        {
            public Server() : base(PlaygroupsComponentBase.Id, PlaygroupsComponentBase.Name)
            {
                
            }
            
            [BlazeCommand((ushort)PlaygroupsComponentCommand.createPlaygroup)]
            public virtual Task<NullStruct> CreatePlaygroupAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)PlaygroupsComponentCommand.destroyPlaygroup)]
            public virtual Task<NullStruct> DestroyPlaygroupAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)PlaygroupsComponentCommand.joinPlaygroup)]
            public virtual Task<NullStruct> JoinPlaygroupAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)PlaygroupsComponentCommand.leavePlaygroup)]
            public virtual Task<NullStruct> LeavePlaygroupAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)PlaygroupsComponentCommand.setPlaygroupAttributes)]
            public virtual Task<NullStruct> SetPlaygroupAttributesAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)PlaygroupsComponentCommand.setMemberAttributes)]
            public virtual Task<NullStruct> SetMemberAttributesAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)PlaygroupsComponentCommand.kickPlaygroupMember)]
            public virtual Task<NullStruct> KickPlaygroupMemberAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)PlaygroupsComponentCommand.setPlaygroupJoinControls)]
            public virtual Task<NullStruct> SetPlaygroupJoinControlsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)PlaygroupsComponentCommand.finalizePlaygroupCreation)]
            public virtual Task<NullStruct> FinalizePlaygroupCreationAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)PlaygroupsComponentCommand.lookupPlaygroupInfo)]
            public virtual Task<NullStruct> LookupPlaygroupInfoAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)PlaygroupsComponentCommand.resetPlaygroupSession)]
            public virtual Task<NullStruct> ResetPlaygroupSessionAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            
            public static Task NotifyDestroyPlaygroupAsync(BlazeServerConnection connection, NotifyDestroyPlaygroup notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(PlaygroupsComponentBase.Id, (ushort)PlaygroupsComponentNotification.NotifyDestroyPlaygroup, notification, waitUntilFree);
            }
            
            public static Task NotifyJoinPlaygroupAsync(BlazeServerConnection connection, NotifyJoinPlaygroup notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(PlaygroupsComponentBase.Id, (ushort)PlaygroupsComponentNotification.NotifyJoinPlaygroup, notification, waitUntilFree);
            }
            
            public static Task NotifyMemberJoinedPlaygroupAsync(BlazeServerConnection connection, NotifyMemberJoinedPlaygroup notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(PlaygroupsComponentBase.Id, (ushort)PlaygroupsComponentNotification.NotifyMemberJoinedPlaygroup, notification, waitUntilFree);
            }
            
            public static Task NotifyMemberRemovedFromPlaygroupAsync(BlazeServerConnection connection, NotifyMemberRemoveFromPlaygroup notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(PlaygroupsComponentBase.Id, (ushort)PlaygroupsComponentNotification.NotifyMemberRemovedFromPlaygroup, notification, waitUntilFree);
            }
            
            public static Task NotifyPlaygroupAttributesSetAsync(BlazeServerConnection connection, NotifyPlaygroupAttributesSet notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(PlaygroupsComponentBase.Id, (ushort)PlaygroupsComponentNotification.NotifyPlaygroupAttributesSet, notification, waitUntilFree);
            }
            
            public static Task NotifyMemberAttributesSetAsync(BlazeServerConnection connection, NotifyMemberAttributesSet notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(PlaygroupsComponentBase.Id, (ushort)PlaygroupsComponentNotification.NotifyMemberAttributesSet, notification, waitUntilFree);
            }
            
            public static Task NotifyLeaderChangeAsync(BlazeServerConnection connection, NotifyLeaderChange notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(PlaygroupsComponentBase.Id, (ushort)PlaygroupsComponentNotification.NotifyLeaderChange, notification, waitUntilFree);
            }
            
            public static Task NotifyMemberPermissionsChangeAsync(BlazeServerConnection connection, NotifyMemberPermissionsChange notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(PlaygroupsComponentBase.Id, (ushort)PlaygroupsComponentNotification.NotifyMemberPermissionsChange, notification, waitUntilFree);
            }
            
            public static Task NotifyJoinControlsChangeAsync(BlazeServerConnection connection, NotifyJoinControlsChange notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(PlaygroupsComponentBase.Id, (ushort)PlaygroupsComponentNotification.NotifyJoinControlsChange, notification, waitUntilFree);
            }
            
            public static Task NotifyXboxSessionInfoAsync(BlazeServerConnection connection, NotifyXboxSessionInfo notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(PlaygroupsComponentBase.Id, (ushort)PlaygroupsComponentNotification.NotifyXboxSessionInfo, notification, waitUntilFree);
            }
            
            public static Task NotifyXboxSessionChangeAsync(BlazeServerConnection connection, NotifyXboxSessionInfo notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(PlaygroupsComponentBase.Id, (ushort)PlaygroupsComponentNotification.NotifyXboxSessionChange, notification, waitUntilFree);
            }
            
            public override Type GetCommandRequestType(PlaygroupsComponentCommand command) => PlaygroupsComponentBase.GetCommandRequestType(command);
            public override Type GetCommandResponseType(PlaygroupsComponentCommand command) => PlaygroupsComponentBase.GetCommandResponseType(command);
            public override Type GetCommandErrorResponseType(PlaygroupsComponentCommand command) => PlaygroupsComponentBase.GetCommandErrorResponseType(command);
            public override Type GetNotificationType(PlaygroupsComponentNotification notification) => PlaygroupsComponentBase.GetNotificationType(notification);
            
        }
        
        public class Client : BlazeComponent<PlaygroupsComponentCommand, PlaygroupsComponentNotification, Blaze3RpcError>
        {
            public Client() : base(PlaygroupsComponentBase.Id, PlaygroupsComponentBase.Name)
            {
                
            }
            
            public override Type GetCommandRequestType(PlaygroupsComponentCommand command) => PlaygroupsComponentBase.GetCommandRequestType(command);
            public override Type GetCommandResponseType(PlaygroupsComponentCommand command) => PlaygroupsComponentBase.GetCommandResponseType(command);
            public override Type GetCommandErrorResponseType(PlaygroupsComponentCommand command) => PlaygroupsComponentBase.GetCommandErrorResponseType(command);
            public override Type GetNotificationType(PlaygroupsComponentNotification notification) => PlaygroupsComponentBase.GetNotificationType(notification);
            
        }
        
        public static Type GetCommandRequestType(PlaygroupsComponentCommand command) => command switch
        {
            PlaygroupsComponentCommand.createPlaygroup => typeof(NullStruct),
            PlaygroupsComponentCommand.destroyPlaygroup => typeof(NullStruct),
            PlaygroupsComponentCommand.joinPlaygroup => typeof(NullStruct),
            PlaygroupsComponentCommand.leavePlaygroup => typeof(NullStruct),
            PlaygroupsComponentCommand.setPlaygroupAttributes => typeof(NullStruct),
            PlaygroupsComponentCommand.setMemberAttributes => typeof(NullStruct),
            PlaygroupsComponentCommand.kickPlaygroupMember => typeof(NullStruct),
            PlaygroupsComponentCommand.setPlaygroupJoinControls => typeof(NullStruct),
            PlaygroupsComponentCommand.finalizePlaygroupCreation => typeof(NullStruct),
            PlaygroupsComponentCommand.lookupPlaygroupInfo => typeof(NullStruct),
            PlaygroupsComponentCommand.resetPlaygroupSession => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandResponseType(PlaygroupsComponentCommand command) => command switch
        {
            PlaygroupsComponentCommand.createPlaygroup => typeof(NullStruct),
            PlaygroupsComponentCommand.destroyPlaygroup => typeof(NullStruct),
            PlaygroupsComponentCommand.joinPlaygroup => typeof(NullStruct),
            PlaygroupsComponentCommand.leavePlaygroup => typeof(NullStruct),
            PlaygroupsComponentCommand.setPlaygroupAttributes => typeof(NullStruct),
            PlaygroupsComponentCommand.setMemberAttributes => typeof(NullStruct),
            PlaygroupsComponentCommand.kickPlaygroupMember => typeof(NullStruct),
            PlaygroupsComponentCommand.setPlaygroupJoinControls => typeof(NullStruct),
            PlaygroupsComponentCommand.finalizePlaygroupCreation => typeof(NullStruct),
            PlaygroupsComponentCommand.lookupPlaygroupInfo => typeof(NullStruct),
            PlaygroupsComponentCommand.resetPlaygroupSession => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandErrorResponseType(PlaygroupsComponentCommand command) => command switch
        {
            PlaygroupsComponentCommand.createPlaygroup => typeof(NullStruct),
            PlaygroupsComponentCommand.destroyPlaygroup => typeof(NullStruct),
            PlaygroupsComponentCommand.joinPlaygroup => typeof(NullStruct),
            PlaygroupsComponentCommand.leavePlaygroup => typeof(NullStruct),
            PlaygroupsComponentCommand.setPlaygroupAttributes => typeof(NullStruct),
            PlaygroupsComponentCommand.setMemberAttributes => typeof(NullStruct),
            PlaygroupsComponentCommand.kickPlaygroupMember => typeof(NullStruct),
            PlaygroupsComponentCommand.setPlaygroupJoinControls => typeof(NullStruct),
            PlaygroupsComponentCommand.finalizePlaygroupCreation => typeof(NullStruct),
            PlaygroupsComponentCommand.lookupPlaygroupInfo => typeof(NullStruct),
            PlaygroupsComponentCommand.resetPlaygroupSession => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetNotificationType(PlaygroupsComponentNotification notification) => notification switch
        {
            PlaygroupsComponentNotification.NotifyDestroyPlaygroup => typeof(NotifyDestroyPlaygroup),
            PlaygroupsComponentNotification.NotifyJoinPlaygroup => typeof(NotifyJoinPlaygroup),
            PlaygroupsComponentNotification.NotifyMemberJoinedPlaygroup => typeof(NotifyMemberJoinedPlaygroup),
            PlaygroupsComponentNotification.NotifyMemberRemovedFromPlaygroup => typeof(NotifyMemberRemoveFromPlaygroup),
            PlaygroupsComponentNotification.NotifyPlaygroupAttributesSet => typeof(NotifyPlaygroupAttributesSet),
            PlaygroupsComponentNotification.NotifyMemberAttributesSet => typeof(NotifyMemberAttributesSet),
            PlaygroupsComponentNotification.NotifyLeaderChange => typeof(NotifyLeaderChange),
            PlaygroupsComponentNotification.NotifyMemberPermissionsChange => typeof(NotifyMemberPermissionsChange),
            PlaygroupsComponentNotification.NotifyJoinControlsChange => typeof(NotifyJoinControlsChange),
            PlaygroupsComponentNotification.NotifyXboxSessionInfo => typeof(NotifyXboxSessionInfo),
            PlaygroupsComponentNotification.NotifyXboxSessionChange => typeof(NotifyXboxSessionInfo),
            _ => typeof(NullStruct)
        };
        
        public enum PlaygroupsComponentCommand : ushort
        {
            createPlaygroup = 1,
            destroyPlaygroup = 2,
            joinPlaygroup = 3,
            leavePlaygroup = 4,
            setPlaygroupAttributes = 5,
            setMemberAttributes = 6,
            kickPlaygroupMember = 7,
            setPlaygroupJoinControls = 8,
            finalizePlaygroupCreation = 9,
            lookupPlaygroupInfo = 10,
            resetPlaygroupSession = 11,
        }
        
        public enum PlaygroupsComponentNotification : ushort
        {
            NotifyDestroyPlaygroup = 50,
            NotifyJoinPlaygroup = 51,
            NotifyMemberJoinedPlaygroup = 52,
            NotifyMemberRemovedFromPlaygroup = 53,
            NotifyPlaygroupAttributesSet = 54,
            NotifyMemberAttributesSet = 75,
            NotifyLeaderChange = 79,
            NotifyMemberPermissionsChange = 80,
            NotifyJoinControlsChange = 85,
            NotifyXboxSessionInfo = 86,
            NotifyXboxSessionChange = 87,
        }
        
    }
}
