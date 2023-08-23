using BlazeCommon;

namespace Blaze3SDK.Components
{
    public static class CensusDataComponentBase
    {
        public const ushort Id = 10;
        public const string Name = "CensusDataComponent";
        
        public class Server : BlazeComponent<CensusDataComponentCommand, CensusDataComponentNotification, Blaze3RpcError>
        {
            public Server() : base(CensusDataComponentBase.Id, CensusDataComponentBase.Name)
            {
                
            }
            
            [BlazeCommand((ushort)CensusDataComponentCommand.subscribeToCensusData)]
            public virtual Task<NullStruct> SubscribeToCensusDataAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)CensusDataComponentCommand.unsubscribeFromCensusData)]
            public virtual Task<NullStruct> UnsubscribeFromCensusDataAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)CensusDataComponentCommand.getRegionCounts)]
            public virtual Task<NullStruct> GetRegionCountsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)CensusDataComponentCommand.getLatestCensusData)]
            public virtual Task<NullStruct> GetLatestCensusDataAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
        }
        
        public class Client : BlazeComponent<CensusDataComponentCommand, CensusDataComponentNotification, Blaze3RpcError>
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
            getLatestCensusData = 4,
        }
        
        public enum CensusDataComponentNotification : ushort
        {
            NotifyServerCensusData = 1,
        }
        
    }
}
