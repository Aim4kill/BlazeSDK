using BlazeCommon;

namespace Blaze3SDK.Components
{
    public static class CommerceInfoComponentBase
    {
        public const ushort Id = 24;
        public const string Name = "CommerceInfoComponent";
        
        public class Server : BlazeComponent<CommerceInfoComponentCommand, CommerceInfoComponentNotification, Blaze3RpcError>
        {
            public Server() : base(CommerceInfoComponentBase.Id, CommerceInfoComponentBase.Name)
            {
                
            }
            
            [BlazeCommand((ushort)CommerceInfoComponentCommand.getCatalogMap)]
            public virtual Task<NullStruct> GetCatalogMapAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)CommerceInfoComponentCommand.getCategoryMap)]
            public virtual Task<NullStruct> GetCategoryMapAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)CommerceInfoComponentCommand.getProductList)]
            public virtual Task<NullStruct> GetProductListAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)CommerceInfoComponentCommand.getProductAssociation)]
            public virtual Task<NullStruct> GetProductAssociationAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)CommerceInfoComponentCommand.getWalletBalance)]
            public virtual Task<NullStruct> GetWalletBalanceAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)CommerceInfoComponentCommand.checkoutProducts)]
            public virtual Task<NullStruct> CheckoutProductsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            
            public override Type GetCommandRequestType(CommerceInfoComponentCommand command) => CommerceInfoComponentBase.GetCommandRequestType(command);
            public override Type GetCommandResponseType(CommerceInfoComponentCommand command) => CommerceInfoComponentBase.GetCommandResponseType(command);
            public override Type GetCommandErrorResponseType(CommerceInfoComponentCommand command) => CommerceInfoComponentBase.GetCommandErrorResponseType(command);
            public override Type GetNotificationType(CommerceInfoComponentNotification notification) => CommerceInfoComponentBase.GetNotificationType(notification);
            
        }
        
        public class Client : BlazeComponent<CommerceInfoComponentCommand, CommerceInfoComponentNotification, Blaze3RpcError>
        {
            public Client() : base(CommerceInfoComponentBase.Id, CommerceInfoComponentBase.Name)
            {
                
            }
            
            public override Type GetCommandRequestType(CommerceInfoComponentCommand command) => CommerceInfoComponentBase.GetCommandRequestType(command);
            public override Type GetCommandResponseType(CommerceInfoComponentCommand command) => CommerceInfoComponentBase.GetCommandResponseType(command);
            public override Type GetCommandErrorResponseType(CommerceInfoComponentCommand command) => CommerceInfoComponentBase.GetCommandErrorResponseType(command);
            public override Type GetNotificationType(CommerceInfoComponentNotification notification) => CommerceInfoComponentBase.GetNotificationType(notification);
            
        }
        
        public static Type GetCommandRequestType(CommerceInfoComponentCommand command) => command switch
        {
            CommerceInfoComponentCommand.getCatalogMap => typeof(NullStruct),
            CommerceInfoComponentCommand.getCategoryMap => typeof(NullStruct),
            CommerceInfoComponentCommand.getProductList => typeof(NullStruct),
            CommerceInfoComponentCommand.getProductAssociation => typeof(NullStruct),
            CommerceInfoComponentCommand.getWalletBalance => typeof(NullStruct),
            CommerceInfoComponentCommand.checkoutProducts => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandResponseType(CommerceInfoComponentCommand command) => command switch
        {
            CommerceInfoComponentCommand.getCatalogMap => typeof(NullStruct),
            CommerceInfoComponentCommand.getCategoryMap => typeof(NullStruct),
            CommerceInfoComponentCommand.getProductList => typeof(NullStruct),
            CommerceInfoComponentCommand.getProductAssociation => typeof(NullStruct),
            CommerceInfoComponentCommand.getWalletBalance => typeof(NullStruct),
            CommerceInfoComponentCommand.checkoutProducts => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandErrorResponseType(CommerceInfoComponentCommand command) => command switch
        {
            CommerceInfoComponentCommand.getCatalogMap => typeof(NullStruct),
            CommerceInfoComponentCommand.getCategoryMap => typeof(NullStruct),
            CommerceInfoComponentCommand.getProductList => typeof(NullStruct),
            CommerceInfoComponentCommand.getProductAssociation => typeof(NullStruct),
            CommerceInfoComponentCommand.getWalletBalance => typeof(NullStruct),
            CommerceInfoComponentCommand.checkoutProducts => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetNotificationType(CommerceInfoComponentNotification notification) => notification switch
        {
            _ => typeof(NullStruct)
        };
        
        public enum CommerceInfoComponentCommand : ushort
        {
            getCatalogMap = 1,
            getCategoryMap = 2,
            getProductList = 3,
            getProductAssociation = 5,
            getWalletBalance = 6,
            checkoutProducts = 7,
        }
        
        public enum CommerceInfoComponentNotification : ushort
        {
        }
        
    }
}
