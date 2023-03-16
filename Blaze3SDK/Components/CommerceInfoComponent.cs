using Blaze3SDK.Blaze;
using BlazeCommon;
using static Blaze3SDK.Components.CommerceInfoComponent;

namespace Blaze3SDK.Components
{
    public class CommerceInfoComponent : ComponentData<CommerceInfoComponentCommand, CommerceInfoComponentNotification, CommerceInfoComponentError>
    {
        public CommerceInfoComponent() : base((ushort)Component.CommerceInfoComponent)
        {

        }

        public override Type GetCommandErrorResponseType(CommerceInfoComponentCommand command) => command switch
        {
            CommerceInfoComponentCommand.getCatalogMap => throw new NotImplementedException(),
            CommerceInfoComponentCommand.getCategoryMap => throw new NotImplementedException(),
            CommerceInfoComponentCommand.getProductList => throw new NotImplementedException(),
            CommerceInfoComponentCommand.getProductAssociation => throw new NotImplementedException(),
            CommerceInfoComponentCommand.getWalletBalance => throw new NotImplementedException(),
            CommerceInfoComponentCommand.checkoutProducts => throw new NotImplementedException(),
            _ => typeof(NullStruct)
        };

        public override Type GetCommandRequestType(CommerceInfoComponentCommand command) => command switch
        {
            CommerceInfoComponentCommand.getCatalogMap => throw new NotImplementedException(),
            CommerceInfoComponentCommand.getCategoryMap => throw new NotImplementedException(),
            CommerceInfoComponentCommand.getProductList => throw new NotImplementedException(),
            CommerceInfoComponentCommand.getProductAssociation => throw new NotImplementedException(),
            CommerceInfoComponentCommand.getWalletBalance => throw new NotImplementedException(),
            CommerceInfoComponentCommand.checkoutProducts => throw new NotImplementedException(),
            _ => typeof(NullStruct)
        };

        public override Type GetCommandResponseType(CommerceInfoComponentCommand command) => command switch
        {
            CommerceInfoComponentCommand.getCatalogMap => throw new NotImplementedException(),
            CommerceInfoComponentCommand.getCategoryMap => throw new NotImplementedException(),
            CommerceInfoComponentCommand.getProductList => throw new NotImplementedException(),
            CommerceInfoComponentCommand.getProductAssociation => throw new NotImplementedException(),
            CommerceInfoComponentCommand.getWalletBalance => throw new NotImplementedException(),
            CommerceInfoComponentCommand.checkoutProducts => throw new NotImplementedException(),
            _ => typeof(NullStruct)
        };

        public override Type GetNotificationType(CommerceInfoComponentNotification notification) => notification switch
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

        public enum CommerceInfoComponentError
        {
            COMMERCEINFO_ERR_STORE_NOT_EXIST = 65560,
            COMMERCEINFO_ERR_INVALID_CATALOG_NAME = 131096,
            COMMERCEINFO_ERR_INVALID_CATEGORY_NAME = 196632,
            COMMERCEINFO_ERR_CATALOG_NOT_FOUND = 262168,
            COMMERCEINFO_ERR_CATEGORY_NOT_FOUND = 327704,
            COMMERCEINFO_ERR_PAGE_SIZE_TOO_BIG = 393240,
            COMMERCEINFO_ERR_PAGE_SIZE_IS_ZERO = 458776,
            COMMERCEINFO_ERR_REFRESH_IS_UNDERGOING = 524312,
            COMMERCEINFO_ERR_KEYMAST_CODE_NOT_EXIST = 589848,
            COMMERCEINFO_ERR_WALLET_IS_INVALID = 655384,
            COMMERCEINFO_ERR_WALLET_NOT_FOUND = 720920,
            COMMERCEINFO_ERR_PRODUCT_NOT_FOUND = 786456,
            COMMERCEINFO_ERR_BALANCE_INSUFFICIENT_FUND = 851992,
            COMMERCEINFO_ERR_WALLET_CURRENCY_NOT_EARNABLE = 917528,
            COMMERCEINFO_ERR_BILLING_SYSTEM = 983064,
            COMMERCEINFO_ERR_FUSION_SYSTEM = 1048600,
            COMMERCEINFO_ERR_WALLET_CURRENCY_NOT_MATCH = 1114136,
            COMMERCEINFO_ERR_EMPTY_PRODUCT_LIST = 1179672,
        }

    }
}
