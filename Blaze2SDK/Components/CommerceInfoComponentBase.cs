using BlazeCommon;

namespace Blaze2SDK.Components
{
    public static class CommerceInfoComponentBase
    {
        public const ushort Id = 24;
        public const string Name = "CommerceInfoComponent";
        
        public class Server : BlazeComponent<CommerceInfoComponentCommand, CommerceInfoComponentNotification, Blaze2RpcError>
        {
            public Server() : base(CommerceInfoComponentBase.Id, CommerceInfoComponentBase.Name)
            {
                
            }
            
            [BlazeCommand((ushort)CommerceInfoComponentCommand.getCatalogMap)]
            public virtual Task<NullStruct> GetCatalogMapAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)CommerceInfoComponentCommand.getCategoryMap)]
            public virtual Task<NullStruct> GetCategoryMapAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)CommerceInfoComponentCommand.getProductList)]
            public virtual Task<NullStruct> GetProductListAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)CommerceInfoComponentCommand.refreshOfbCache)]
            public virtual Task<NullStruct> RefreshOfbCacheAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)CommerceInfoComponentCommand.getProductAssociation)]
            public virtual Task<NullStruct> GetProductAssociationAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)CommerceInfoComponentCommand.getWalletBalance)]
            public virtual Task<NullStruct> GetWalletBalanceAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)CommerceInfoComponentCommand.checkoutProducts)]
            public virtual Task<NullStruct> CheckoutProductsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
        }
        
        public class Client : BlazeComponent<CommerceInfoComponentCommand, CommerceInfoComponentNotification, Blaze2RpcError>
        {
            public Client() : base(CommerceInfoComponentBase.Id, CommerceInfoComponentBase.Name)
            {
                
            }
        }
        
        public enum CommerceInfoComponentCommand : ushort
        {
            getCatalogMap = 1,
            getCategoryMap = 2,
            getProductList = 3,
            refreshOfbCache = 4,
            getProductAssociation = 5,
            getWalletBalance = 6,
            checkoutProducts = 7,
        }
        
        public enum CommerceInfoComponentNotification : ushort
        {
        }
        
    }
}
