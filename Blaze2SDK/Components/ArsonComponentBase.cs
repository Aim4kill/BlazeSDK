using BlazeCommon;

namespace Blaze2SDK.Components
{
    public static class ArsonComponentBase
    {
        public const ushort Id = 32;
        public const string Name = "ArsonComponent";
        
        public class Server : BlazeComponent<ArsonComponentCommand, ArsonComponentNotification, Blaze2RpcError>
        {
            public Server() : base(ArsonComponentBase.Id, ArsonComponentBase.Name)
            {
                
            }
            
            [BlazeCommand((ushort)ArsonComponentCommand.getUserExtendedData)]
            public virtual Task<NullStruct> GetUserExtendedDataAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ArsonComponentCommand.updateUserExtendedData)]
            public virtual Task<NullStruct> UpdateUserExtendedDataAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ArsonComponentCommand.reportTournamentResult)]
            public virtual Task<NullStruct> ReportTournamentResultAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ArsonComponentCommand.updateRegistrationGameIncrement)]
            public virtual Task<NullStruct> UpdateRegistrationGameIncrementAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ArsonComponentCommand.joinGameByUserList)]
            public virtual Task<NullStruct> JoinGameByUserListAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ArsonComponentCommand.reconfigure)]
            public virtual Task<NullStruct> ReconfigureAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ArsonComponentCommand.getTournamentMemberStatus)]
            public virtual Task<NullStruct> GetTournamentMemberStatusAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ArsonComponentCommand.setRoomCategoryClientMetaData)]
            public virtual Task<NullStruct> SetRoomCategoryClientMetaDataAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ArsonComponentCommand.getRoomCategoryClientMetaData)]
            public virtual Task<NullStruct> GetRoomCategoryClientMetaDataAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ArsonComponentCommand.setRoomAttributes)]
            public virtual Task<NullStruct> SetRoomAttributesAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ArsonComponentCommand.getRoomAttributes)]
            public virtual Task<NullStruct> GetRoomAttributesAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ArsonComponentCommand.getRoomCategory)]
            public virtual Task<NullStruct> GetRoomCategoryAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ArsonComponentCommand.setComponentState)]
            public virtual Task<NullStruct> SetComponentStateAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ArsonComponentCommand.addPointsToWallet)]
            public virtual Task<NullStruct> AddPointsToWalletAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            
            public static Task NotifyReconfigureCompletedAsync(BlazeServerConnection connection, NullStruct notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(ArsonComponentBase.Id, (ushort)ArsonComponentNotification.NotifyReconfigureCompleted, notification, waitUntilFree);
            }
            
            public override Type GetCommandRequestType(ArsonComponentCommand command) => ArsonComponentBase.GetCommandRequestType(command);
            public override Type GetCommandResponseType(ArsonComponentCommand command) => ArsonComponentBase.GetCommandResponseType(command);
            public override Type GetCommandErrorResponseType(ArsonComponentCommand command) => ArsonComponentBase.GetCommandErrorResponseType(command);
            public override Type GetNotificationType(ArsonComponentNotification notification) => ArsonComponentBase.GetNotificationType(notification);
            
        }
        
        public class Client : BlazeComponent<ArsonComponentCommand, ArsonComponentNotification, Blaze2RpcError>
        {
            public Client() : base(ArsonComponentBase.Id, ArsonComponentBase.Name)
            {
                
            }
            
            public override Type GetCommandRequestType(ArsonComponentCommand command) => ArsonComponentBase.GetCommandRequestType(command);
            public override Type GetCommandResponseType(ArsonComponentCommand command) => ArsonComponentBase.GetCommandResponseType(command);
            public override Type GetCommandErrorResponseType(ArsonComponentCommand command) => ArsonComponentBase.GetCommandErrorResponseType(command);
            public override Type GetNotificationType(ArsonComponentNotification notification) => ArsonComponentBase.GetNotificationType(notification);
            
        }
        
        public static Type GetCommandRequestType(ArsonComponentCommand command) => command switch
        {
            ArsonComponentCommand.getUserExtendedData => typeof(NullStruct),
            ArsonComponentCommand.updateUserExtendedData => typeof(NullStruct),
            ArsonComponentCommand.reportTournamentResult => typeof(NullStruct),
            ArsonComponentCommand.updateRegistrationGameIncrement => typeof(NullStruct),
            ArsonComponentCommand.joinGameByUserList => typeof(NullStruct),
            ArsonComponentCommand.reconfigure => typeof(NullStruct),
            ArsonComponentCommand.getTournamentMemberStatus => typeof(NullStruct),
            ArsonComponentCommand.setRoomCategoryClientMetaData => typeof(NullStruct),
            ArsonComponentCommand.getRoomCategoryClientMetaData => typeof(NullStruct),
            ArsonComponentCommand.setRoomAttributes => typeof(NullStruct),
            ArsonComponentCommand.getRoomAttributes => typeof(NullStruct),
            ArsonComponentCommand.getRoomCategory => typeof(NullStruct),
            ArsonComponentCommand.setComponentState => typeof(NullStruct),
            ArsonComponentCommand.addPointsToWallet => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandResponseType(ArsonComponentCommand command) => command switch
        {
            ArsonComponentCommand.getUserExtendedData => typeof(NullStruct),
            ArsonComponentCommand.updateUserExtendedData => typeof(NullStruct),
            ArsonComponentCommand.reportTournamentResult => typeof(NullStruct),
            ArsonComponentCommand.updateRegistrationGameIncrement => typeof(NullStruct),
            ArsonComponentCommand.joinGameByUserList => typeof(NullStruct),
            ArsonComponentCommand.reconfigure => typeof(NullStruct),
            ArsonComponentCommand.getTournamentMemberStatus => typeof(NullStruct),
            ArsonComponentCommand.setRoomCategoryClientMetaData => typeof(NullStruct),
            ArsonComponentCommand.getRoomCategoryClientMetaData => typeof(NullStruct),
            ArsonComponentCommand.setRoomAttributes => typeof(NullStruct),
            ArsonComponentCommand.getRoomAttributes => typeof(NullStruct),
            ArsonComponentCommand.getRoomCategory => typeof(NullStruct),
            ArsonComponentCommand.setComponentState => typeof(NullStruct),
            ArsonComponentCommand.addPointsToWallet => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandErrorResponseType(ArsonComponentCommand command) => command switch
        {
            ArsonComponentCommand.getUserExtendedData => typeof(NullStruct),
            ArsonComponentCommand.updateUserExtendedData => typeof(NullStruct),
            ArsonComponentCommand.reportTournamentResult => typeof(NullStruct),
            ArsonComponentCommand.updateRegistrationGameIncrement => typeof(NullStruct),
            ArsonComponentCommand.joinGameByUserList => typeof(NullStruct),
            ArsonComponentCommand.reconfigure => typeof(NullStruct),
            ArsonComponentCommand.getTournamentMemberStatus => typeof(NullStruct),
            ArsonComponentCommand.setRoomCategoryClientMetaData => typeof(NullStruct),
            ArsonComponentCommand.getRoomCategoryClientMetaData => typeof(NullStruct),
            ArsonComponentCommand.setRoomAttributes => typeof(NullStruct),
            ArsonComponentCommand.getRoomAttributes => typeof(NullStruct),
            ArsonComponentCommand.getRoomCategory => typeof(NullStruct),
            ArsonComponentCommand.setComponentState => typeof(NullStruct),
            ArsonComponentCommand.addPointsToWallet => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetNotificationType(ArsonComponentNotification notification) => notification switch
        {
            ArsonComponentNotification.NotifyReconfigureCompleted => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public enum ArsonComponentCommand : ushort
        {
            getUserExtendedData = 1,
            updateUserExtendedData = 2,
            reportTournamentResult = 3,
            updateRegistrationGameIncrement = 4,
            joinGameByUserList = 5,
            reconfigure = 6,
            getTournamentMemberStatus = 7,
            setRoomCategoryClientMetaData = 8,
            getRoomCategoryClientMetaData = 9,
            setRoomAttributes = 10,
            getRoomAttributes = 11,
            getRoomCategory = 12,
            setComponentState = 13,
            addPointsToWallet = 14,
        }
        
        public enum ArsonComponentNotification : ushort
        {
            NotifyReconfigureCompleted = 1,
        }
        
    }
}
