namespace Blaze2SDK.Components;

public enum ServerError : ushort {
    ERR_SYSTEM = 1,
    ERR_COMPONENT_NOT_FOUND = 2,
    ERR_COMMAND_NOT_FOUND = 3,
    ERR_AUTHENTICATION_REQUIRED = 4,
    ERR_TIMEOUT = 5,
    ERR_DISCONNECTED = 6,
    ERR_DUPLICATE_LOGIN = 7,
    ERR_AUTHORIZATION_REQUIRED = 8,
}

public enum SdkError : ushort {
    SDK_ERR_INVALID_STATE = 1,
    SDK_ERR_RPC_SEND_FAILED = 2,
    SDK_ERR_IN_PROGRESS = 3,
    SDK_ERR_RPC_TIMEOUT = 4,
    SDK_ERR_RPC_CANCELED = 5,
    SDK_ERR_NOT_CONNECTED = 6,
    SDK_ERR_INVALID_LOGIN_ACTION = 7,
    SDK_ERR_INVALID_USER_INDEX = 8,
    SDK_ERR_NO_CONSOLE_ID = 9,
    SDK_ERR_NO_CONSOLE_USERNAME = 10,
    SDK_ERR_TOS_UNAVAILABLE = 11,
    SDK_ERR_NO_MEM = 12,
    SDK_ERR_CONN_FAILED = 13,
    SDK_ERR_SERVER_DISCONNECT = 14,
    SDK_ERR_DISCONNECT_OVERFLOW = 15,
    SDK_ERR_DIRTYSOCK_UNINITIALIZED = 16,
    SDK_ERR_NO_MULTIPLAYER_PRIVILEGE = 17,
    SDK_ERR_MINIMUM_AGE_CHECK_FAILED = 18,
    SDK_ERR_USER_EXTENDED_DATA_NOT_AVAILABLE = 19,
    SDK_ERR_NO_CLIENT_NAME_PROVIDED = 20,
    SDK_ERR_NO_CLIENT_VERSION_PROVIDED = 21,
    SDK_ERR_NO_CLIENT_SKU_ID_PROVIDED = 22,
    SDK_ERR_NO_SERVICE_NAME_PROVIDED = 23,
    SDK_ERR_BLAZE_HUB_ALREADY_INITIALIZED = 24,
    SDK_ERR_QOS_PINGSITE_NOT_INITIALIZED = 25,
    SDK_ERR_DS_VERSION_MISMATCH = 26,
}

public static class RootComponentUtils
{
    public static ushort WithErrorPrefix(this ServerError error)
    {
        ushort errorCode = (ushort)error;
        errorCode |= 0x4000;
        return errorCode;
    }
    
    public static ushort WithErrorPrefix(this SdkError error)
    {
        ushort errorCode = (ushort)error;
        errorCode |= 0x8000;
        return errorCode;
    }
}
