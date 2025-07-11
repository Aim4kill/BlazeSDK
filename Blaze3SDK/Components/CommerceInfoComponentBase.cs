using Blaze.Core;
using EATDF;
using EATDF.Types;

namespace Blaze3SDK.Components;

public static class CommerceInfoComponentBase
{
    public const ushort Id = 24;
    public const string Name = "CommerceInfoComponent";
    
    public enum Error : ushort {
        COMMERCEINFO_ERR_STORE_NOT_EXIST = 1,
        COMMERCEINFO_ERR_INVALID_CATALOG_NAME = 2,
        COMMERCEINFO_ERR_INVALID_CATEGORY_NAME = 3,
        COMMERCEINFO_ERR_CATALOG_NOT_FOUND = 4,
        COMMERCEINFO_ERR_CATEGORY_NOT_FOUND = 5,
        COMMERCEINFO_ERR_PAGE_SIZE_TOO_BIG = 6,
        COMMERCEINFO_ERR_PAGE_SIZE_IS_ZERO = 7,
        COMMERCEINFO_ERR_REFRESH_IS_UNDERGOING = 8,
        COMMERCEINFO_ERR_KEYMAST_CODE_NOT_EXIST = 9,
        COMMERCEINFO_ERR_WALLET_IS_INVALID = 10,
        COMMERCEINFO_ERR_WALLET_NOT_FOUND = 11,
        COMMERCEINFO_ERR_PRODUCT_NOT_FOUND = 12,
        COMMERCEINFO_ERR_BALANCE_INSUFFICIENT_FUND = 13,
        COMMERCEINFO_ERR_WALLET_CURRENCY_NOT_EARNABLE = 14,
        COMMERCEINFO_ERR_BILLING_SYSTEM = 15,
        COMMERCEINFO_ERR_FUSION_SYSTEM = 16,
        COMMERCEINFO_ERR_WALLET_CURRENCY_NOT_MATCH = 17,
        COMMERCEINFO_ERR_EMPTY_PRODUCT_LIST = 18,
    }
    
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
    
    public class Server : BlazeComponent {
        public override ushort Id => CommerceInfoComponentBase.Id;
        public override string Name => CommerceInfoComponentBase.Name;
        
        public virtual bool IsCommandSupported(CommerceInfoComponentCommand command) => false;
        
        public class CommerceInfoException : BlazeRpcException
        {
            public CommerceInfoException(Error error) : base((ushort)error, null) { }
            public CommerceInfoException(ServerError error) : base(error.WithErrorPrefix(), null) { }
            public CommerceInfoException(Error error, Tdf? errorResponse) : base((ushort)error, errorResponse) { }
            public CommerceInfoException(ServerError error, Tdf? errorResponse) : base(error.WithErrorPrefix(), errorResponse) { }
            public CommerceInfoException(Error error, Tdf? errorResponse, string? message) : base((ushort)error, errorResponse, message) { }
            public CommerceInfoException(ServerError error, Tdf? errorResponse, string? message) : base(error.WithErrorPrefix(), errorResponse, message) { }
            public CommerceInfoException(Error error, Tdf? errorResponse, string? message, Exception? innerException) : base((ushort)error, errorResponse, message, innerException) { }
            public CommerceInfoException(ServerError error, Tdf? errorResponse, string? message, Exception? innerException) : base(error.WithErrorPrefix(), errorResponse, message, innerException) { }
        }
        
        public Server()
        {
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)CommerceInfoComponentCommand.getCatalogMap,
                Name = "getCatalogMap",
                IsSupported = IsCommandSupported(CommerceInfoComponentCommand.getCatalogMap),
                Func = async (req, ctx) => await GetCatalogMapAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)CommerceInfoComponentCommand.getCategoryMap,
                Name = "getCategoryMap",
                IsSupported = IsCommandSupported(CommerceInfoComponentCommand.getCategoryMap),
                Func = async (req, ctx) => await GetCategoryMapAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)CommerceInfoComponentCommand.getProductList,
                Name = "getProductList",
                IsSupported = IsCommandSupported(CommerceInfoComponentCommand.getProductList),
                Func = async (req, ctx) => await GetProductListAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)CommerceInfoComponentCommand.getProductAssociation,
                Name = "getProductAssociation",
                IsSupported = IsCommandSupported(CommerceInfoComponentCommand.getProductAssociation),
                Func = async (req, ctx) => await GetProductAssociationAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)CommerceInfoComponentCommand.getWalletBalance,
                Name = "getWalletBalance",
                IsSupported = IsCommandSupported(CommerceInfoComponentCommand.getWalletBalance),
                Func = async (req, ctx) => await GetWalletBalanceAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)CommerceInfoComponentCommand.checkoutProducts,
                Name = "checkoutProducts",
                IsSupported = IsCommandSupported(CommerceInfoComponentCommand.checkoutProducts),
                Func = async (req, ctx) => await CheckoutProductsAsync(req, ctx).ConfigureAwait(false)
            });
            
        }
        
        public override string GetErrorName(ushort errorCode)
        {
            return ((Error)errorCode).ToString();
        }
        
        /// <summary>
        /// This method is called when server receives a <b>CommerceInfoComponent::getCatalogMap</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetCatalogMapAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new CommerceInfoException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>CommerceInfoComponent::getCategoryMap</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetCategoryMapAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new CommerceInfoException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>CommerceInfoComponent::getProductList</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetProductListAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new CommerceInfoException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>CommerceInfoComponent::getProductAssociation</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetProductAssociationAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new CommerceInfoException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>CommerceInfoComponent::getWalletBalance</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetWalletBalanceAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new CommerceInfoException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>CommerceInfoComponent::checkoutProducts</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> CheckoutProductsAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new CommerceInfoException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
    }
    
}

