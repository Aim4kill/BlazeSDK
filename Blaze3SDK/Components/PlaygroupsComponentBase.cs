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
        }
        
        public class Client : BlazeComponent<PlaygroupsComponentCommand, PlaygroupsComponentNotification, Blaze3RpcError>
        {
            public Client() : base(PlaygroupsComponentBase.Id, PlaygroupsComponentBase.Name)
            {
                
            }
        }
        
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
