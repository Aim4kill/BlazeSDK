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
            UtilComponentCommand.fetchClientConfig => throw new NotImplementedException(),
            UtilComponentCommand.ping => throw new NotImplementedException(),
            UtilComponentCommand.setClientData => throw new NotImplementedException(),
            UtilComponentCommand.localizeStrings => throw new NotImplementedException(),
            UtilComponentCommand.getTelemetryServer => throw new NotImplementedException(),
            UtilComponentCommand.getTickerServer => throw new NotImplementedException(),
            UtilComponentCommand.preAuth => throw new NotImplementedException(),
            UtilComponentCommand.postAuth => throw new NotImplementedException(),
            UtilComponentCommand.userSettingsLoad => throw new NotImplementedException(),
            UtilComponentCommand.userSettingsSave => throw new NotImplementedException(),
            UtilComponentCommand.userSettingsLoadAll => throw new NotImplementedException(),
            UtilComponentCommand.deleteUserSettings => throw new NotImplementedException(),
            UtilComponentCommand.filterForProfanity => throw new NotImplementedException(),
            UtilComponentCommand.fetchQosConfig => throw new NotImplementedException(),
            UtilComponentCommand.setClientMetrics => throw new NotImplementedException(),
            UtilComponentCommand.setConnectionState => throw new NotImplementedException(),
            UtilComponentCommand.getPssConfig => throw new NotImplementedException(),
            UtilComponentCommand.getUserOptions => throw new NotImplementedException(),
            UtilComponentCommand.setUserOptions => throw new NotImplementedException(),
            UtilComponentCommand.suspendUserPing => throw new NotImplementedException(),
            _ => typeof(NullStruct),
        };

        public override Type GetCommandRequestType(UtilComponentCommand command) => command switch
        {
            UtilComponentCommand.fetchClientConfig => typeof(FetchClientConfigRequest),
            UtilComponentCommand.ping => typeof(NullStruct),
            UtilComponentCommand.setClientData => throw new NotImplementedException(),
            UtilComponentCommand.localizeStrings => throw new NotImplementedException(),
            UtilComponentCommand.getTelemetryServer => typeof(GetTelemetryServerRequest),
            UtilComponentCommand.getTickerServer => throw new NotImplementedException(),
            UtilComponentCommand.preAuth => typeof(PreAuthRequest),
            UtilComponentCommand.postAuth => typeof(NullStruct),
            UtilComponentCommand.userSettingsLoad => typeof(UserSettingsLoadRequest),
            UtilComponentCommand.userSettingsSave => typeof(UserSettingsSaveRequest),
            UtilComponentCommand.userSettingsLoadAll => typeof(UserSettingsLoadAllRequest),
            UtilComponentCommand.deleteUserSettings => throw new NotImplementedException(),
            UtilComponentCommand.filterForProfanity => typeof(FilterUserTextResponse),
            UtilComponentCommand.fetchQosConfig => throw new NotImplementedException(),
            UtilComponentCommand.setClientMetrics => typeof(ClientMetrics),
            UtilComponentCommand.setConnectionState => throw new NotImplementedException(),
            UtilComponentCommand.getPssConfig => throw new NotImplementedException(),
            UtilComponentCommand.getUserOptions => throw new NotImplementedException(),
            UtilComponentCommand.setUserOptions => typeof(UserOptions),
            UtilComponentCommand.suspendUserPing => throw new NotImplementedException(),
            _ => typeof(NullStruct),
        };
        

        public override Type GetCommandResponseType(UtilComponentCommand command) => command switch
        {
            UtilComponentCommand.fetchClientConfig => throw new NotImplementedException(),
            UtilComponentCommand.ping => typeof(PingResponse),
            UtilComponentCommand.setClientData => throw new NotImplementedException(),
            UtilComponentCommand.localizeStrings => throw new NotImplementedException(),
            UtilComponentCommand.getTelemetryServer => typeof(GetTelemetryServerResponse),
            UtilComponentCommand.getTickerServer => throw new NotImplementedException(),
            UtilComponentCommand.preAuth => typeof(PreAuthResponse),
            UtilComponentCommand.postAuth => typeof(PostAuthResponse),
            UtilComponentCommand.userSettingsLoad => throw new NotImplementedException(),
            UtilComponentCommand.userSettingsSave => throw new NotImplementedException(),
            UtilComponentCommand.userSettingsLoadAll => typeof(UserSettingsLoadAllResponse),
            UtilComponentCommand.deleteUserSettings => throw new NotImplementedException(),
            UtilComponentCommand.filterForProfanity => throw new NotImplementedException(),
            UtilComponentCommand.fetchQosConfig => throw new NotImplementedException(),
            UtilComponentCommand.setClientMetrics => typeof(NullStruct),
            UtilComponentCommand.setConnectionState => throw new NotImplementedException(),
            UtilComponentCommand.getPssConfig => throw new NotImplementedException(),
            UtilComponentCommand.getUserOptions => throw new NotImplementedException(),
            UtilComponentCommand.setUserOptions => throw new NotImplementedException(),
            UtilComponentCommand.suspendUserPing => throw new NotImplementedException(),   
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
