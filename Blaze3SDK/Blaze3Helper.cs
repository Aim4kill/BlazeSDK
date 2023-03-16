using Blaze3SDK.Blaze;
using Blaze3SDK.Components;
using BlazeCommon;

namespace Blaze3SDK
{
    public class Blaze3Helper : IBlazeHelper
    {
        static Dictionary<Component, IComponentData> _componentDataMap;

        static Blaze3Helper()
        {
            _componentDataMap = new Dictionary<Component, IComponentData>()
            {
                { Component.AuthenticationComponent,        new AuthenticationComponent() },
                { Component.ExampleComponent,               new ExampleComponent()},
                { Component.GameManager,                    new GameManager() },
                { Component.RedirectorComponent,            new RedirectorComponent() },
                { Component.PlaygroupsComponent,            new PlaygroupsComponent() },
                { Component.StatsComponent,                 new StatsComponent() },
                { Component.UtilComponent,                  new UtilComponent() },
                { Component.CensusDataComponent,            new CensusDataComponent() },
                { Component.ClubsComponent,                 new ClubsComponent() },
                { Component.GameReportingLegacyComponent,   new GameReportingLegacyComponent() },
                { Component.LeagueComponent,                new LeagueComponent() },
                { Component.MailComponent,                  new MailComponent() },
                { Component.MessagingComponent,             new MessagingComponent() },
                { Component.LockerComponent,                new LockerComponent() },
                { Component.RoomsComponent,                 new RoomsComponent() },
                { Component.TournamentsComponent,           new TournamentsComponent() },
                { Component.CommerceInfoComponent,          new CommerceInfoComponent() },
                { Component.AssociationListsComponent,      new AssociationListsComponent() },
                { Component.GpsContentControllerComponent,  new GpsContentControllerComponent() },
                { Component.GameReportingComponent,         new GameReportingComponent() },
                { Component.DynamicInetFilterComponent,     new DynamicInetFilterComponent() },


                { Component.RspComponent,               new RspComponent() },
                { Component.UserSessions,               new UserSessions() }
            };
        }

        public Type GetCommandErrorResponseType(ushort componentId, ushort commandId)
        {
            //TODO: Implement this
            return typeof(NullStruct);
        }

        public string GetCommandName(ushort componentId, ushort commandId) => GetCommandName((Component)componentId, commandId);
        public string GetCommandName(Component component, ushort commandId)
        {
            if (!_componentDataMap.TryGetValue(component, out var componentData))
                return string.Empty;
            return componentData.GetCommandName(commandId);
        }

        public Type GetCommandRequestType(ushort componentId, ushort commandId)
        {
            if (!_componentDataMap.TryGetValue((Component)componentId, out var componentData))
                return typeof(NullStruct);

            return componentData.GetCommandRequestType(commandId);
        }

        public Type GetCommandResponseType(ushort componentId, ushort commandId)
        {
            if (!_componentDataMap.TryGetValue((Component)componentId, out var componentData))
                return typeof(NullStruct);

            return componentData.GetCommandResponseType(commandId);
        }

        public string GetComponentName(ushort componentId)
        {
            return Enum.GetName(typeof(Component), componentId) ?? string.Empty;
        }

        public string GetComponentName(Component component)
        {
            return Enum.GetName(typeof(Component), component) ?? string.Empty;
        }

        public string GetErrorName(int errorCode)
        {
            return Enum.GetName(typeof(GlobalError), errorCode) ?? GetErrorName((ushort)(errorCode & 0xFFFF), (ushort)(errorCode >> 16 & 0xFFFF));

        }

        public string GetErrorName(ushort componentId, ushort errorCode)
        {
            int err = errorCode << 16 | componentId;

            if (componentId == 0)
                return Enum.GetName(typeof(GlobalError), err) ?? string.Empty;
            
            if (!_componentDataMap.TryGetValue((Component)componentId, out var componentData))
                return string.Empty;

            return componentData.GetErrorName(err);
        }

        public string GetNotificationName(ushort componentId, ushort command)
        {
            if (!_componentDataMap.TryGetValue((Component)componentId, out var componentData))
                return string.Empty;

            return componentData.GetNotificationName(command);
        }

        public Type GetNotificationType(ushort componentId, ushort command)
        {
            if (!_componentDataMap.TryGetValue((Component)componentId, out var componentData))
                return typeof(NullStruct);

            return componentData.GetNotificationType(command);
        }

        public Type GetNullType()
        {
            return typeof(NullStruct);
        }
    }

    public enum GlobalError
    {
        ERR_DB_DROP_PARTITION_NON_EXISTENT = 1081081856,
        ERR_DB_SAME_NAME_PARTITION = 1081147392,
        ERR_DB_LOCK_DEADLOCK = 1081016320,
        ERR_DB_TIMEOUT = 1080819712,
        ERR_DB_INIT_FAILURE = 1080885248,
        ERR_DB_TRANSACTION_NOT_COMPLETE = 1080950784,
        ERR_DB_DISCONNECTED = 1080754176,
        ERR_DB_NO_CONNECTION_AVAILABLE = 1080557568,
        ERR_DB_DUP_ENTRY = 1080623104,
        ERR_DB_NO_SUCH_TABLE = 1080688640,
        ERR_DB_NOT_SUPPORTED = 1080492032,
        ERR_INVALID_ENUM_VALUE = 1074593792,
        ERR_DB_SYSTEM = 1080360960,
        ERR_DB_NOT_CONNECTED = 1080426496,
        ERR_STRING_TOO_LONG = 1074528256,
        ERR_CUSTOM_REQUEST_HOOK_FAILED = 1074397184,
        ERR_CUSTOM_RESPONSE_HOOK_FAILED = 1074462720,
        ERR_CANCELED = 1074331648,
        ERR_DISCONNECTED = 1074135040,
        ERR_DUPLICATE_LOGIN = 1074200576,
        ERR_AUTHORIZATION_REQUIRED = 1074266112,
        ERR_TIMEOUT = 1074069504,
        ERR_COMPONENT_NOT_FOUND = 1073872896,
        ERR_COMMAND_NOT_FOUND = 1073938432,
        ERR_AUTHENTICATION_REQUIRED = 1074003968,
        ERR_SYSTEM = 1073807360,
        SDK_ERR_RESOLVER_TIMEOUT = -2145452032,
        SDK_ERR_BLAZE_CONN_TIMEOUT = -2145386496,
        SDK_ERR_BLAZE_CONN_FAILED = -2145320960,
        SDK_ERR_NETWORK_CONN_TIMEOUT = -2145714176,
        SDK_ERR_BLAZE_HUB_ALREADY_INITIALIZED = -2145910784,
        SDK_ERR_QOS_PINGSITE_NOT_INITIALIZED = -2145845248,
        SDK_ERR_DS_VERSION_MISMATCH = -2145779712,
        SDK_ERR_NO_CLIENT_NAME_PROVIDED = -2146172928,
        SDK_ERR_NO_CLIENT_VERSION_PROVIDED = -2146107392,
        SDK_ERR_NO_CLIENT_SKU_ID_PROVIDED = -2146041856,
        SDK_ERR_USER_EXTENDED_DATA_NOT_AVAILABLE = -2146238464,
        SDK_ERR_DIRTYSOCK_UNINITIALIZED = -2146435072,
        SDK_ERR_NO_MULTIPLAYER_PRIVILEGE = -2146369536,
        SDK_ERR_MINIMUM_AGE_CHECK_FAILED = -2146304000,
        SDK_ERR_NO_MEM = -2146697216,
        SDK_ERR_NO_CONSOLE_ID = -2146893824,
        SDK_ERR_NO_CONSOLE_USERNAME = -2146828288,
        SDK_ERR_TOS_UNAVAILABLE = -2146762752,
        SDK_ERR_RPC_CANCELED = -2147155968,
        SDK_ERR_NOT_CONNECTED = -2147090432,
        SDK_ERR_INVALID_LOGIN_ACTION = -2147024896,
        SDK_ERR_RPC_TIMEOUT = -2147221504,
        SDK_ERR_INVALID_STATE = -2147418112,
        SDK_ERR_RPC_SEND_FAILED = -2147352576,
        SDK_ERR_IN_PROGRESS = -2147287040,
        SDK_ERR_LSP_LOOKUP = -2145517568,
        SDK_ERR_NETWORK_CONN_FAILED = -2145648640,
        SDK_ERR_NETWORK_DISCONNECTED = -2145583104,
        SDK_ERR_NO_SERVICE_NAME_PROVIDED = -2145976320,
        SDK_ERR_DISCONNECT_OVERFLOW = -2146500608,
        SDK_ERR_CONN_FAILED = -2146631680,
        SDK_ERR_SERVER_DISCONNECT = -2146566144,
        SDK_ERR_INVALID_USER_INDEX = -2146959360
    }
}
