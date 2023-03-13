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

        public override Type GetCommandErrorResponseType(UserSessionsCommand command)
        {
            throw new NotImplementedException();
        }

        public override Type GetCommandRequestType(UserSessionsCommand command) => command switch
        {
            UserSessionsCommand.updateHardwareFlags => typeof(UpdateHardwareFlagsRequest),
            UserSessionsCommand.updateNetworkInfo => typeof(NetworkInfo),
            _ => throw new NotImplementedException()
        };
        

        public override Type GetCommandResponseType(UserSessionsCommand command) => command switch
        {
            UserSessionsCommand.updateNetworkInfo => typeof(NullStruct),
            UserSessionsCommand.fetchExtendedData => throw new NotImplementedException(),
            UserSessionsCommand.updateExtendedDataAttribute => throw new NotImplementedException(),
            UserSessionsCommand.updateHardwareFlags => throw new NotImplementedException(),
            UserSessionsCommand.lookupUser => throw new NotImplementedException(),
            UserSessionsCommand.lookupUsers => throw new NotImplementedException(),
            UserSessionsCommand.lookupUsersByPrefix => throw new NotImplementedException(),
            UserSessionsCommand.lookupUserGeoIPData => throw new NotImplementedException(),
            UserSessionsCommand.overrideUserGeoIPData => throw new NotImplementedException(),
            UserSessionsCommand.updateUserSessionClientData => throw new NotImplementedException(),
            UserSessionsCommand.setUserInfoAttribute => throw new NotImplementedException(),
            UserSessionsCommand.resetUserGeoIPData => throw new NotImplementedException(),
            UserSessionsCommand.lookupUserSessionId => throw new NotImplementedException(),
            UserSessionsCommand.fetchLastLocaleUsedAndAuthError => throw new NotImplementedException(),
            UserSessionsCommand.fetchUserFirstLastAuthTime => throw new NotImplementedException(),
            UserSessionsCommand.resumeSession => throw new NotImplementedException(),
            _ => throw new NotImplementedException()
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
            lookupUsers,
            lookupUsersByPrefix,
            updateNetworkInfo = 20,
            lookupUserGeoIPData = 23,
            overrideUserGeoIPData,
            updateUserSessionClientData,
            setUserInfoAttribute,
            resetUserGeoIPData,
            lookupUserSessionId = 32,
            fetchLastLocaleUsedAndAuthError,
            fetchUserFirstLastAuthTime,
            resumeSession
        }

        public enum UserSessionsNotification : ushort
        {
            UserSessionExtendedDataUpdate = 1,
            UserAdded,
            UserRemoved,
            UserSessionDisconnected,
            UserUpdated
        }

        public enum UserSessionsError : int
        {

        }
    }
}
