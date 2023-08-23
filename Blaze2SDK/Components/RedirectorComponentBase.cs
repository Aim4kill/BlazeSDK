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
        }

        public class Client : BlazeComponent<RedirectorComponentCommand, RedirectorComponentNotification, Blaze2RpcError>
        {
            public Client() : base(RedirectorComponentBase.Id, RedirectorComponentBase.Name)
            {

            }
        }

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
