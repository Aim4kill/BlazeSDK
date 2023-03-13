using Blaze3SDK.Blaze;
using Blaze3SDK.Blaze.Util;
using BlazeCommon;
using static Blaze3SDK.Components.UtilComponent;

namespace Blaze3SDK.Components
{
    public class UtilComponent : ComponentData<UtilComponentCommand, UtilComponentNotification, UtilComponentError>
    {
        public UtilComponent() : base((ushort)Component.UtilComponent)
        {


        }

        public override Type GetCommandErrorResponseType(UtilComponentCommand command)
        {
            throw new NotImplementedException();
        }

        public override Type GetCommandRequestType(UtilComponentCommand command) => command switch
        {
            UtilComponentCommand.ping =>                typeof(NullStruct),
            UtilComponentCommand.getTelemetryServer =>  typeof(GetTelemetryServerRequest),
            UtilComponentCommand.preAuth =>             typeof(PreAuthRequest),
            UtilComponentCommand.postAuth =>            typeof(NullStruct),
            UtilComponentCommand.setUserOptions =>      typeof(UserOptions),
            UtilComponentCommand.fetchClientConfig =>   typeof(FetchClientConfigRequest),
            UtilComponentCommand.userSettingsLoadAll => typeof(UserSettingsLoadAllRequest),
            UtilComponentCommand.setClientMetrics => typeof(ClientMetrics),
            //UtilComponentCommand.userSettingsLoad =>    typeof(UserSettingsLoadRequest),
            //UtilComponentCommand.userSettingsSave =>    typeof(UserSettingsSaveRequest),
            //UtilComponentCommand.filterForProfanity =>  typeof(FilterUserTextResponse),
            _ => throw new NotImplementedException()
        };
        

        public override Type GetCommandResponseType(UtilComponentCommand command) => command switch
        {
            UtilComponentCommand.postAuth => typeof(PostAuthResponse),
            UtilComponentCommand.userSettingsLoadAll => typeof(UserSettingsLoadAllResponse),
            UtilComponentCommand.getTelemetryServer => typeof(GetTelemetryServerResponse),
            UtilComponentCommand.preAuth => typeof(PreAuthResponse),
            UtilComponentCommand.ping => typeof(PingResponse),
            UtilComponentCommand.setClientMetrics => typeof(NullStruct),
            _ => throw new NotImplementedException()
        };
        

        public override Type GetNotificationType(UtilComponentNotification notification) => notification switch
        {
            _ => throw new NotImplementedException()
        };

        public enum UtilComponentError : int
        {
            UTIL_TICKER_KEY_TOO_LONG = 10223625,
            UTIL_TELEMETRY_KEY_TOO_LONG = 9961481,
            UTIL_TELEMETRY_INVALID_MAC_ADDRESS = 10027017,
            UTIL_TICKER_NO_SERVERS_AVAILABLE = 10158089,
            UTIL_TELEMETRY_OUT_OF_MEMORY = 9895945,
            UTIL_CONFIG_NOT_FOUND = 6553609,
            UTIL_PSS_NO_SERVERS_AVAILABLE = 9502729,
            UTIL_TELEMETRY_NO_SERVERS_AVAILABLE = 9830409,
            UTIL_USS_USER_NO_EXTENDED_DATA = 16384009,
            UTIL_USS_RECORD_NOT_FOUND = 13107209,
            UTIL_USS_TOO_MANY_KEYS = 13172745,
            UTIL_USS_DB_ERROR = 13238281,
            UTIL_SUSPEND_PING_TIME_TOO_LARGE = 19660809,
            UTIL_SUSPEND_PING_TIME_TOO_SMALL = 67860,
            UTIL_PING_SUSPENDED = 19791881
        }

        public enum UtilComponentCommand : ushort
        {
            fetchClientConfig = 1,
            ping,
            setClientData,
            localizeStrings,
            getTelemetryServer,
            getTickerServer,
            preAuth,
            postAuth,
            userSettingsLoad = 10,
            userSettingsSave,
            userSettingsLoadAll,
            deleteUserSettings = 14,
            filterForProfanity = 20,
            fetchQosConfig,
            setClientMetrics,
            setConnectionState,
            getPssConfig,
            getUserOptions,
            setUserOptions,
            suspendUserPing
        }

        public enum UtilComponentNotification : ushort
        {

        }
    }
}
