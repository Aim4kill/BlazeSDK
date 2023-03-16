using Blaze3SDK.Blaze;
using BlazeCommon;
using static Blaze3SDK.Components.UserSessions;

namespace Blaze3SDK.Components
{
    public class UserSessions : ComponentData<UserSessionsCommand, UserSessionsNotification, UserSessionsError>
    {
        public UserSessions() : base((ushort)Component.UserSessions)
        {

        }

        public override Type GetCommandErrorResponseType(UserSessionsCommand command) => command switch
        {
            UserSessionsCommand.fetchExtendedData => throw new NotImplementedException(),
            UserSessionsCommand.updateExtendedDataAttribute => throw new NotImplementedException(),
            UserSessionsCommand.updateHardwareFlags => throw new NotImplementedException(),
            UserSessionsCommand.lookupUser => throw new NotImplementedException(),
            UserSessionsCommand.lookupUsers => throw new NotImplementedException(),
            UserSessionsCommand.lookupUsersByPrefix => throw new NotImplementedException(),
            UserSessionsCommand.updateNetworkInfo => throw new NotImplementedException(),
            UserSessionsCommand.lookupUserGeoIPData => throw new NotImplementedException(),
            UserSessionsCommand.overrideUserGeoIPData => throw new NotImplementedException(),
            UserSessionsCommand.updateUserSessionClientData => throw new NotImplementedException(),
            UserSessionsCommand.setUserInfoAttribute => throw new NotImplementedException(),
            UserSessionsCommand.resetUserGeoIPData => throw new NotImplementedException(),
            UserSessionsCommand.lookupUserSessionId => throw new NotImplementedException(),
            UserSessionsCommand.fetchLastLocaleUsedAndAuthError => throw new NotImplementedException(),
            UserSessionsCommand.fetchUserFirstLastAuthTime => throw new NotImplementedException(),
            UserSessionsCommand.resumeSession => throw new NotImplementedException(),
            _ => typeof(NullStruct)
        };

        public override Type GetCommandRequestType(UserSessionsCommand command) => command switch
        {
            UserSessionsCommand.fetchExtendedData => throw new NotImplementedException(),
            UserSessionsCommand.updateExtendedDataAttribute => throw new NotImplementedException(),
            UserSessionsCommand.updateHardwareFlags => typeof(UpdateHardwareFlagsRequest),
            UserSessionsCommand.lookupUser => throw new NotImplementedException(),
            UserSessionsCommand.lookupUsers => throw new NotImplementedException(),
            UserSessionsCommand.lookupUsersByPrefix => throw new NotImplementedException(),
            UserSessionsCommand.updateNetworkInfo => typeof(NetworkInfo),
            UserSessionsCommand.lookupUserGeoIPData => throw new NotImplementedException(),
            UserSessionsCommand.overrideUserGeoIPData => throw new NotImplementedException(),
            UserSessionsCommand.updateUserSessionClientData => throw new NotImplementedException(),
            UserSessionsCommand.setUserInfoAttribute => throw new NotImplementedException(),
            UserSessionsCommand.resetUserGeoIPData => throw new NotImplementedException(),
            UserSessionsCommand.lookupUserSessionId => throw new NotImplementedException(),
            UserSessionsCommand.fetchLastLocaleUsedAndAuthError => throw new NotImplementedException(),
            UserSessionsCommand.fetchUserFirstLastAuthTime => throw new NotImplementedException(),
            UserSessionsCommand.resumeSession => throw new NotImplementedException(),
            _ => typeof(NullStruct)
        };

        public override Type GetCommandResponseType(UserSessionsCommand command) => command switch
        {
            UserSessionsCommand.fetchExtendedData => throw new NotImplementedException(),
            UserSessionsCommand.updateExtendedDataAttribute => throw new NotImplementedException(),
            UserSessionsCommand.updateHardwareFlags => throw new NotImplementedException(),
            UserSessionsCommand.lookupUser => throw new NotImplementedException(),
            UserSessionsCommand.lookupUsers => throw new NotImplementedException(),
            UserSessionsCommand.lookupUsersByPrefix => throw new NotImplementedException(),
            UserSessionsCommand.updateNetworkInfo => typeof(NullStruct),
            UserSessionsCommand.lookupUserGeoIPData => throw new NotImplementedException(),
            UserSessionsCommand.overrideUserGeoIPData => throw new NotImplementedException(),
            UserSessionsCommand.updateUserSessionClientData => throw new NotImplementedException(),
            UserSessionsCommand.setUserInfoAttribute => throw new NotImplementedException(),
            UserSessionsCommand.resetUserGeoIPData => throw new NotImplementedException(),
            UserSessionsCommand.lookupUserSessionId => throw new NotImplementedException(),
            UserSessionsCommand.fetchLastLocaleUsedAndAuthError => throw new NotImplementedException(),
            UserSessionsCommand.fetchUserFirstLastAuthTime => throw new NotImplementedException(),
            UserSessionsCommand.resumeSession => throw new NotImplementedException(),
            _ => typeof(NullStruct)
        };

        public override Type GetNotificationType(UserSessionsNotification notification) => notification switch
        {
            UserSessionsNotification.UserSessionExtendedDataUpdate => typeof(UserSessionExtendedDataUpdate),
            UserSessionsNotification.UserAdded => typeof(NotifyUserAdded),
            UserSessionsNotification.UserRemoved => typeof(NotifyUserRemoved),
            UserSessionsNotification.UserSessionDisconnected => throw new NotImplementedException(),
            UserSessionsNotification.UserUpdated => typeof(UserStatus),
            _ => throw new NotImplementedException(),
        };

        public enum UserSessionsCommand : ushort
        {
            fetchExtendedData = 3,
            updateExtendedDataAttribute = 5,
            updateHardwareFlags = 8,
            lookupUser = 12,
            lookupUsers = 13,
            lookupUsersByPrefix = 14,
            updateNetworkInfo = 20,
            lookupUserGeoIPData = 23,
            overrideUserGeoIPData = 24,
            updateUserSessionClientData = 25,
            setUserInfoAttribute = 26,
            resetUserGeoIPData = 27,
            lookupUserSessionId = 32,
            fetchLastLocaleUsedAndAuthError = 33,
            fetchUserFirstLastAuthTime = 34,
            resumeSession = 35,
        }

        public enum UserSessionsNotification : ushort
        {
            UserSessionExtendedDataUpdate = 1,
            UserAdded = 2,
            UserRemoved = 3,
            UserSessionDisconnected = 4,
            UserUpdated = 5,
        }

        public enum UserSessionsError
        {
            USER_ERR_USER_NOT_FOUND = 96258,
            USER_ERR_SESSION_NOT_FOUND = 161794,
            USER_ERR_DUPLICATE_SESSION = 227330,
            USER_ERR_NO_EXTENDED_DATA = 292866,
            USER_ERR_MAX_DATA_REACHED = 358402,
            USER_ERR_KEY_NOT_FOUND = 423938,
            USER_ERR_INVALID_SESSION_INSTANCE = 489474,
            USER_ERR_INVALID_PARAM = 555010,
            USER_ERR_MINIMUM_CHARACTERS = 620546,
            ACCESS_GROUP_ERR_INVALID_GROUP = 686082,
            ACCESS_GROUP_ERR_DEFAULT_GROUP = 751618,
            ACCESS_GROUP_ERR_NOT_CURRENT_GROUP = 817154,
            ACCESS_GROUP_ERR_CURRENT_GROUP = 882690,
            ACCESS_GROUP_ERR_NO_GROUP_FOUND = 948226,
            GEOIP_INCOMPLETE_PARAMETERS = 1013762,
            GEOIP_UNABLE_TO_RESOLVE = 1079298,
            ERR_ENTITY_TYPE_NOT_FOUND = 1144834,
            ERR_ENTITY_NOT_FOUND = 1210370,
            ERR_NOT_SUPPORTED = 1275906,
            USER_ERR_EXISTS = 1341442,
            USER_ERR_RESUMABLE_SESSION_CONNECTION_INVALID = 1406978,
            USER_ERR_RESUMABLE_SESSION_NOT_FOUND = 1472514,
        }

    }
}
