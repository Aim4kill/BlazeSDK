using Blaze3SDK.Blaze;
using BlazeCommon;
using static Blaze3SDK.Components.MailComponent;

namespace Blaze3SDK.Components
{
    public class MailComponent : ComponentData<MailComponentCommand, MailComponentNotification, MailComponentError>
    {
        public MailComponent() : base((ushort)Component.MailComponent)
        {

        }

        public override Type GetCommandErrorResponseType(MailComponentCommand command) => command switch
        {
            MailComponentCommand.updateMailSettings => throw new NotImplementedException(),
            MailComponentCommand.sendMailToSelf => throw new NotImplementedException(),
            MailComponentCommand.setMailOptInFlags => throw new NotImplementedException(),
            MailComponentCommand.setMailPref => throw new NotImplementedException(),
            MailComponentCommand.getMailSettings => throw new NotImplementedException(),
            _ => typeof(NullStruct)
        };

        public override Type GetCommandRequestType(MailComponentCommand command) => command switch
        {
            MailComponentCommand.updateMailSettings => throw new NotImplementedException(),
            MailComponentCommand.sendMailToSelf => throw new NotImplementedException(),
            MailComponentCommand.setMailOptInFlags => throw new NotImplementedException(),
            MailComponentCommand.setMailPref => throw new NotImplementedException(),
            MailComponentCommand.getMailSettings => throw new NotImplementedException(),
            _ => typeof(NullStruct)
        };

        public override Type GetCommandResponseType(MailComponentCommand command) => command switch
        {
            MailComponentCommand.updateMailSettings => throw new NotImplementedException(),
            MailComponentCommand.sendMailToSelf => throw new NotImplementedException(),
            MailComponentCommand.setMailOptInFlags => throw new NotImplementedException(),
            MailComponentCommand.setMailPref => throw new NotImplementedException(),
            MailComponentCommand.getMailSettings => throw new NotImplementedException(),
            _ => typeof(NullStruct)
        };

        public override Type GetNotificationType(MailComponentNotification notification) => notification switch
        {
            _ => typeof(NullStruct)
        };

        public enum MailComponentCommand : ushort
        {
            updateMailSettings = 1,
            sendMailToSelf = 2,
            setMailOptInFlags = 3,
            setMailPref = 4,
            getMailSettings = 5,
        }

        public enum MailComponentNotification : ushort
        {
        }

        public enum MailComponentError
        {
            MAIL_ERR_INVALID_OPTIN_FLAGS = 65550,
            MAIL_ERR_INVALID_EMAIL_FORMAT = 131086,
            MAIL_ERR_USER_NOT_FOUND_IN_DB = 196622,
            MAIL_ERR_SEND_MAIL_INVALID_EMAIL = 1310734,
            MAIL_ERR_SEND_MAIL_INVALID_TEMPLATE = 1376270,
            MAIL_ERR_SEND_MAIL_MISSING_HEADER = 1441806,
            MAIL_ERR_SEND_MAIL_MISSING_VARIABLE_VALUE = 1507342,
        }

    }
}
