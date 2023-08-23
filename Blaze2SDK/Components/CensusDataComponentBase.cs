using BlazeCommon;

namespace Blaze2SDK.Components
{
    public static class CensusDataComponentBase
    {
        public const ushort Id = 10;
        public const string Name = "CensusDataComponent";
        
        public class Server : BlazeComponent<CensusDataComponentCommand, CensusDataComponentNotification, Blaze2RpcError>
        {
            public Server() : base(CensusDataComponentBase.Id, CensusDataComponentBase.Name)
            {
                
            }
            
            [BlazeCommand((ushort)CensusDataComponentCommand.subscribeToCensusData)]
            public virtual Task<NullStruct> SubscribeToCensusDataAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)CensusDataComponentCommand.unsubscribeFromCensusData)]
            public virtual Task<NullStruct> UnsubscribeFromCensusDataAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)CensusDataComponentCommand.getRegionCounts)]
            public virtual Task<NullStruct> GetRegionCountsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
        }
        
        public class Client : BlazeComponent<CensusDataComponentCommand, CensusDataComponentNotification, Blaze2RpcError>
        {
            public Client() : base(CensusDataComponentBase.Id, CensusDataComponentBase.Name)
            {
                
            }
        }
        
        public enum CensusDataComponentCommand : ushort
        {
            subscribeToCensusData = 1,
            unsubscribeFromCensusData = 2,
            getRegionCounts = 3,
        }
        
        public enum CensusDataComponentNotification : ushort
        {
            NotifyServerCensusData = 1,
        }
        
    }
}
