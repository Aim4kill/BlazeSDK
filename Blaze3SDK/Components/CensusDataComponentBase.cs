using Blaze3SDK.Blaze.CensusData;
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
            
            
            public static Task NotifyServerCensusDataAsync(BlazeServerConnection connection, NotifyServerCensusData notification)
            {
                return connection.NotifyAsync(CensusDataComponentBase.Id, (ushort)CensusDataComponentNotification.NotifyServerCensusData, notification);
            }
            
            public override Type GetCommandRequestType(CensusDataComponentCommand command) => CensusDataComponentBase.GetCommandRequestType(command);
            public override Type GetCommandResponseType(CensusDataComponentCommand command) => CensusDataComponentBase.GetCommandResponseType(command);
            public override Type GetCommandErrorResponseType(CensusDataComponentCommand command) => CensusDataComponentBase.GetCommandErrorResponseType(command);
            public override Type GetNotificationType(CensusDataComponentNotification notification) => CensusDataComponentBase.GetNotificationType(notification);
            
        }
        
        public class Client : BlazeComponent<CensusDataComponentCommand, CensusDataComponentNotification, Blaze3RpcError>
        {
            public Client() : base(CensusDataComponentBase.Id, CensusDataComponentBase.Name)
            {
                
            }
            
            public override Type GetCommandRequestType(CensusDataComponentCommand command) => CensusDataComponentBase.GetCommandRequestType(command);
            public override Type GetCommandResponseType(CensusDataComponentCommand command) => CensusDataComponentBase.GetCommandResponseType(command);
            public override Type GetCommandErrorResponseType(CensusDataComponentCommand command) => CensusDataComponentBase.GetCommandErrorResponseType(command);
            public override Type GetNotificationType(CensusDataComponentNotification notification) => CensusDataComponentBase.GetNotificationType(notification);
            
        }
        
        public static Type GetCommandRequestType(CensusDataComponentCommand command) => command switch
        {
            CensusDataComponentCommand.subscribeToCensusData => typeof(NullStruct),
            CensusDataComponentCommand.unsubscribeFromCensusData => typeof(NullStruct),
            CensusDataComponentCommand.getRegionCounts => typeof(NullStruct),
            CensusDataComponentCommand.getLatestCensusData => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandResponseType(CensusDataComponentCommand command) => command switch
        {
            CensusDataComponentCommand.subscribeToCensusData => typeof(NullStruct),
            CensusDataComponentCommand.unsubscribeFromCensusData => typeof(NullStruct),
            CensusDataComponentCommand.getRegionCounts => typeof(NullStruct),
            CensusDataComponentCommand.getLatestCensusData => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandErrorResponseType(CensusDataComponentCommand command) => command switch
        {
            CensusDataComponentCommand.subscribeToCensusData => typeof(NullStruct),
            CensusDataComponentCommand.unsubscribeFromCensusData => typeof(NullStruct),
            CensusDataComponentCommand.getRegionCounts => typeof(NullStruct),
            CensusDataComponentCommand.getLatestCensusData => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetNotificationType(CensusDataComponentNotification notification) => notification switch
        {
            CensusDataComponentNotification.NotifyServerCensusData => typeof(NotifyServerCensusData),
            _ => typeof(NullStruct)
        };
        
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
