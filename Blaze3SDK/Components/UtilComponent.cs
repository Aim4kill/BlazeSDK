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

        public override Type GetCommandErrorResponseType(UtilComponentCommand command) => command switch
        {
            UtilComponentCommand.fetchClientConfig => typeof(NullStruct),
            UtilComponentCommand.ping => typeof(NullStruct),
            UtilComponentCommand.setClientData => typeof(NullStruct),
            UtilComponentCommand.localizeStrings => typeof(NullStruct),
            UtilComponentCommand.getTelemetryServer => typeof(NullStruct),
            UtilComponentCommand.getTickerServer => typeof(NullStruct),
            UtilComponentCommand.preAuth => typeof(NullStruct),
            UtilComponentCommand.postAuth => typeof(NullStruct),
            UtilComponentCommand.userSettingsLoad => typeof(NullStruct),
            UtilComponentCommand.userSettingsSave => typeof(NullStruct),
            UtilComponentCommand.userSettingsLoadAll => typeof(NullStruct),
            UtilComponentCommand.deleteUserSettings => typeof(NullStruct),
            UtilComponentCommand.filterForProfanity => typeof(NullStruct),
            UtilComponentCommand.fetchQosConfig => typeof(NullStruct),
            UtilComponentCommand.setClientMetrics => typeof(NullStruct),
            UtilComponentCommand.setConnectionState => typeof(NullStruct),
            UtilComponentCommand.getPssConfig => typeof(NullStruct),
            UtilComponentCommand.getUserOptions => typeof(NullStruct),
            UtilComponentCommand.setUserOptions => typeof(NullStruct),
            UtilComponentCommand.suspendUserPing => typeof(NullStruct),
            _ => typeof(NullStruct),
        };

        public override Type GetCommandRequestType(UtilComponentCommand command) => command switch
        {
            UtilComponentCommand.fetchClientConfig => typeof(FetchClientConfigRequest),
            UtilComponentCommand.ping => typeof(NullStruct),
            UtilComponentCommand.setClientData => typeof(ClientData),
            UtilComponentCommand.localizeStrings => typeof(LocalizeStringsRequest),
            UtilComponentCommand.getTelemetryServer => typeof(GetTelemetryServerRequest),
            UtilComponentCommand.getTickerServer => typeof(NullStruct),
            UtilComponentCommand.preAuth => typeof(PreAuthRequest),
            UtilComponentCommand.postAuth => typeof(NullStruct),
            UtilComponentCommand.userSettingsLoad => typeof(UserSettingsLoadRequest),
            UtilComponentCommand.userSettingsSave => typeof(UserSettingsSaveRequest),
            UtilComponentCommand.userSettingsLoadAll => typeof(UserSettingsLoadAllRequest),
            UtilComponentCommand.deleteUserSettings => typeof(DeleteUserSettingsRequest),
            UtilComponentCommand.filterForProfanity => typeof(FilterUserTextResponse),
            UtilComponentCommand.fetchQosConfig => typeof(NullStruct),
            UtilComponentCommand.setClientMetrics => typeof(ClientMetrics),
            UtilComponentCommand.setConnectionState => typeof(SetConnectionStateRequest),
            UtilComponentCommand.getPssConfig => typeof(NullStruct),
            UtilComponentCommand.getUserOptions => typeof(GetUserOptionsRequest),
            UtilComponentCommand.setUserOptions => typeof(UserOptions),
            UtilComponentCommand.suspendUserPing => typeof(SuspendUserPingRequest),
            _ => typeof(NullStruct),
        };
        

        public override Type GetCommandResponseType(UtilComponentCommand command) => command switch
        {
            UtilComponentCommand.fetchClientConfig => typeof(FetchConfigResponse),
            UtilComponentCommand.ping => typeof(PingResponse),
            UtilComponentCommand.setClientData => typeof(NullStruct),
            UtilComponentCommand.localizeStrings => typeof(LocalizeStringsResponse),
            UtilComponentCommand.getTelemetryServer => typeof(GetTelemetryServerResponse),
            UtilComponentCommand.getTickerServer => typeof(GetTickerServerResponse),
            UtilComponentCommand.preAuth => typeof(PreAuthResponse),
            UtilComponentCommand.postAuth => typeof(PostAuthResponse),
            UtilComponentCommand.userSettingsLoad => typeof(UserSettingsResponse),
            UtilComponentCommand.userSettingsSave => typeof(NullStruct),
            UtilComponentCommand.userSettingsLoadAll => typeof(UserSettingsLoadAllResponse),
            UtilComponentCommand.deleteUserSettings => typeof(NullStruct),
            UtilComponentCommand.filterForProfanity => typeof(FilterUserTextResponse),
            UtilComponentCommand.fetchQosConfig => typeof(QosConfigInfo),
            UtilComponentCommand.setClientMetrics => typeof(NullStruct),
            UtilComponentCommand.setConnectionState => typeof(NullStruct),
            UtilComponentCommand.getPssConfig => typeof(PssConfig),
            UtilComponentCommand.getUserOptions => typeof(UserOptions),
            UtilComponentCommand.setUserOptions => typeof(NullStruct),
            UtilComponentCommand.suspendUserPing => typeof(NullStruct),
            _ => typeof(NullStruct),
        };
        

        public override Type GetNotificationType(UtilComponentNotification notification) => notification switch
        {
            _ => typeof(NullStruct),
        };

        public enum UtilComponentError
        {
            UTIL_CONFIG_NOT_FOUND = 6553609,
            UTIL_PSS_NO_SERVERS_AVAILABLE = 9502729,
            UTIL_TELEMETRY_NO_SERVERS_AVAILABLE = 9830409,
            UTIL_TELEMETRY_OUT_OF_MEMORY = 9895945,
            UTIL_TELEMETRY_KEY_TOO_LONG = 9961481,
            UTIL_TELEMETRY_INVALID_MAC_ADDRESS = 10027017,
            UTIL_TICKER_NO_SERVERS_AVAILABLE = 10158089,
            UTIL_TICKER_KEY_TOO_LONG = 10223625,
            UTIL_USS_RECORD_NOT_FOUND = 13107209,
            UTIL_USS_TOO_MANY_KEYS = 13172745,
            UTIL_USS_DB_ERROR = 13238281,
            UTIL_USS_USER_NO_EXTENDED_DATA = 16384009,
            UTIL_SUSPEND_PING_TIME_TOO_LARGE = 19660809,
            UTIL_SUSPEND_PING_TIME_TOO_SMALL = 19726345,
            UTIL_PING_SUSPENDED = 19791881
        }

        public enum UtilComponentCommand : ushort
        {
            fetchClientConfig = 1,
            ping = 2,
            setClientData = 3,
            localizeStrings = 4,
            getTelemetryServer = 5,
            getTickerServer = 6,
            preAuth = 7,
            postAuth = 8,
            userSettingsLoad = 10,
            userSettingsSave = 11,
            userSettingsLoadAll = 12,
            deleteUserSettings = 14,
            filterForProfanity = 20,
            fetchQosConfig = 21,
            setClientMetrics = 22,
            setConnectionState = 23,
            getPssConfig = 24,
            getUserOptions = 25,
            setUserOptions = 26,
            suspendUserPing = 27
        }

        public enum UtilComponentNotification : ushort
        {

        }
    }
}
