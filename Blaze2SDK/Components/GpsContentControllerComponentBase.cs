using BlazeCommon;

namespace Blaze2SDK.Components
{
    public static class GpsContentControllerComponentBase
    {
        public const ushort Id = 27;
        public const string Name = "GpsContentControllerComponent";
        
        public class Server : BlazeComponent<GpsContentControllerComponentCommand, GpsContentControllerComponentNotification, Blaze2RpcError>
        {
            public Server() : base(GpsContentControllerComponentBase.Id, GpsContentControllerComponentBase.Name)
            {
                
            }
            
            [BlazeCommand((ushort)GpsContentControllerComponentCommand.filePetition)]
            public virtual Task<NullStruct> FilePetitionAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GpsContentControllerComponentCommand.fetchContent)]
            public virtual Task<NullStruct> FetchContentAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GpsContentControllerComponentCommand.showContent)]
            public virtual Task<NullStruct> ShowContentAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            
            public override Type GetCommandRequestType(GpsContentControllerComponentCommand command) => GpsContentControllerComponentBase.GetCommandRequestType(command);
            public override Type GetCommandResponseType(GpsContentControllerComponentCommand command) => GpsContentControllerComponentBase.GetCommandResponseType(command);
            public override Type GetCommandErrorResponseType(GpsContentControllerComponentCommand command) => GpsContentControllerComponentBase.GetCommandErrorResponseType(command);
            public override Type GetNotificationType(GpsContentControllerComponentNotification notification) => GpsContentControllerComponentBase.GetNotificationType(notification);
            
        }
        
        public class Client : BlazeComponent<GpsContentControllerComponentCommand, GpsContentControllerComponentNotification, Blaze2RpcError>
        {
            public Client() : base(GpsContentControllerComponentBase.Id, GpsContentControllerComponentBase.Name)
            {
                
            }
            
            public override Type GetCommandRequestType(GpsContentControllerComponentCommand command) => GpsContentControllerComponentBase.GetCommandRequestType(command);
            public override Type GetCommandResponseType(GpsContentControllerComponentCommand command) => GpsContentControllerComponentBase.GetCommandResponseType(command);
            public override Type GetCommandErrorResponseType(GpsContentControllerComponentCommand command) => GpsContentControllerComponentBase.GetCommandErrorResponseType(command);
            public override Type GetNotificationType(GpsContentControllerComponentNotification notification) => GpsContentControllerComponentBase.GetNotificationType(notification);
            
        }
        
        public static Type GetCommandRequestType(GpsContentControllerComponentCommand command) => command switch
        {
            GpsContentControllerComponentCommand.filePetition => typeof(NullStruct),
            GpsContentControllerComponentCommand.fetchContent => typeof(NullStruct),
            GpsContentControllerComponentCommand.showContent => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandResponseType(GpsContentControllerComponentCommand command) => command switch
        {
            GpsContentControllerComponentCommand.filePetition => typeof(NullStruct),
            GpsContentControllerComponentCommand.fetchContent => typeof(NullStruct),
            GpsContentControllerComponentCommand.showContent => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandErrorResponseType(GpsContentControllerComponentCommand command) => command switch
        {
            GpsContentControllerComponentCommand.filePetition => typeof(NullStruct),
            GpsContentControllerComponentCommand.fetchContent => typeof(NullStruct),
            GpsContentControllerComponentCommand.showContent => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetNotificationType(GpsContentControllerComponentNotification notification) => notification switch
        {
            _ => typeof(NullStruct)
        };
        
        public enum GpsContentControllerComponentCommand : ushort
        {
            filePetition = 1,
            fetchContent = 2,
            showContent = 3,
        }
        
        public enum GpsContentControllerComponentNotification : ushort
        {
        }
        
    }
}
