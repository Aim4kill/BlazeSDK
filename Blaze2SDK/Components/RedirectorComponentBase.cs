using Blaze2SDK.Blaze.Redirector;
using BlazeCommon;

namespace Blaze2SDK.Components
{
    public static class RedirectorComponentBase
    {
        public const ushort Id = 5;
        public const string Name = "RedirectorComponent";
        
        public class Server : BlazeComponent<RedirectorComponentCommand, RedirectorComponentNotification, Blaze2RpcError>
        {
            public Server() : base(RedirectorComponentBase.Id, RedirectorComponentBase.Name)
            {
                
            }
            
            [BlazeCommand((ushort)RedirectorComponentCommand.getServerInstance)]
            public virtual Task<ServerInstanceInfo> GetServerInstanceAsync(ServerInstanceRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RedirectorComponentCommand.getServerList)]
            public virtual Task<NullStruct> GetServerListAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RedirectorComponentCommand.scheduleServerDowntime)]
            public virtual Task<NullStruct> ScheduleServerDowntimeAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RedirectorComponentCommand.cancelServerDowntime)]
            public virtual Task<NullStruct> CancelServerDowntimeAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RedirectorComponentCommand.getDowntimeList)]
            public virtual Task<NullStruct> GetDowntimeListAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RedirectorComponentCommand.getDowntimeMessageTypes)]
            public virtual Task<NullStruct> GetDowntimeMessageTypesAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            
            public override Type GetCommandRequestType(RedirectorComponentCommand command) => RedirectorComponentBase.GetCommandRequestType(command);
            public override Type GetCommandResponseType(RedirectorComponentCommand command) => RedirectorComponentBase.GetCommandResponseType(command);
            public override Type GetCommandErrorResponseType(RedirectorComponentCommand command) => RedirectorComponentBase.GetCommandErrorResponseType(command);
            public override Type GetNotificationType(RedirectorComponentNotification notification) => RedirectorComponentBase.GetNotificationType(notification);
            
        }
        
        public class Client : BlazeComponent<RedirectorComponentCommand, RedirectorComponentNotification, Blaze2RpcError>
        {
            public Client() : base(RedirectorComponentBase.Id, RedirectorComponentBase.Name)
            {
                
            }
            
            public override Type GetCommandRequestType(RedirectorComponentCommand command) => RedirectorComponentBase.GetCommandRequestType(command);
            public override Type GetCommandResponseType(RedirectorComponentCommand command) => RedirectorComponentBase.GetCommandResponseType(command);
            public override Type GetCommandErrorResponseType(RedirectorComponentCommand command) => RedirectorComponentBase.GetCommandErrorResponseType(command);
            public override Type GetNotificationType(RedirectorComponentNotification notification) => RedirectorComponentBase.GetNotificationType(notification);
            
        }
        
        public static Type GetCommandRequestType(RedirectorComponentCommand command) => command switch
        {
            RedirectorComponentCommand.getServerInstance => typeof(ServerInstanceRequest),
            RedirectorComponentCommand.getServerList => typeof(NullStruct),
            RedirectorComponentCommand.scheduleServerDowntime => typeof(NullStruct),
            RedirectorComponentCommand.cancelServerDowntime => typeof(NullStruct),
            RedirectorComponentCommand.getDowntimeList => typeof(NullStruct),
            RedirectorComponentCommand.getDowntimeMessageTypes => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandResponseType(RedirectorComponentCommand command) => command switch
        {
            RedirectorComponentCommand.getServerInstance => typeof(ServerInstanceInfo),
            RedirectorComponentCommand.getServerList => typeof(NullStruct),
            RedirectorComponentCommand.scheduleServerDowntime => typeof(NullStruct),
            RedirectorComponentCommand.cancelServerDowntime => typeof(NullStruct),
            RedirectorComponentCommand.getDowntimeList => typeof(NullStruct),
            RedirectorComponentCommand.getDowntimeMessageTypes => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandErrorResponseType(RedirectorComponentCommand command) => command switch
        {
            RedirectorComponentCommand.getServerInstance => typeof(ServerInstanceError),
            RedirectorComponentCommand.getServerList => typeof(NullStruct),
            RedirectorComponentCommand.scheduleServerDowntime => typeof(NullStruct),
            RedirectorComponentCommand.cancelServerDowntime => typeof(NullStruct),
            RedirectorComponentCommand.getDowntimeList => typeof(NullStruct),
            RedirectorComponentCommand.getDowntimeMessageTypes => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetNotificationType(RedirectorComponentNotification notification) => notification switch
        {
            _ => typeof(NullStruct)
        };
        
        public enum RedirectorComponentCommand : ushort
        {
            getServerInstance = 1,
            getServerList = 2,
            scheduleServerDowntime = 3,
            cancelServerDowntime = 4,
            getDowntimeList = 5,
            getDowntimeMessageTypes = 6,
        }
        
        public enum RedirectorComponentNotification : ushort
        {
        }
        
    }
}
