using BlazeCommon;

namespace Blaze3SDK.Components
{
    public static class GpsContentControllerComponentBase
    {
        public const ushort Id = 27;
        public const string Name = "GpsContentControllerComponent";
        
        public class Server : BlazeComponent<GpsContentControllerComponentCommand, GpsContentControllerComponentNotification, Blaze3RpcError>
        {
            public Server() : base(GpsContentControllerComponentBase.Id, GpsContentControllerComponentBase.Name)
            {
                
            }
            
            [BlazeCommand((ushort)GpsContentControllerComponentCommand.filePetition)]
            public virtual Task<NullStruct> FilePetitionAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GpsContentControllerComponentCommand.fetchContent)]
            public virtual Task<NullStruct> FetchContentAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)GpsContentControllerComponentCommand.showContent)]
            public virtual Task<NullStruct> ShowContentAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
        }
        
        public class Client : BlazeComponent<GpsContentControllerComponentCommand, GpsContentControllerComponentNotification, Blaze3RpcError>
        {
            public Client() : base(GpsContentControllerComponentBase.Id, GpsContentControllerComponentBase.Name)
            {
                
            }
        }
        
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
