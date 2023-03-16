using Blaze3SDK.Blaze;
using BlazeCommon;
using static Blaze3SDK.Components.MessagingComponent;

namespace Blaze3SDK.Components
{
    public class MessagingComponent : ComponentData<MessagingComponentCommand, MessagingComponentNotification, MessagingComponentError>
    {
        public MessagingComponent() : base((ushort)Component.MessagingComponent)
        {

        }

        public override Type GetCommandErrorResponseType(MessagingComponentCommand command) => command switch
        {
            MessagingComponentCommand.sendMessage => throw new NotImplementedException(),
            MessagingComponentCommand.fetchMessages => throw new NotImplementedException(),
            MessagingComponentCommand.purgeMessages => throw new NotImplementedException(),
            MessagingComponentCommand.touchMessages => throw new NotImplementedException(),
            MessagingComponentCommand.getMessages => throw new NotImplementedException(),
            _ => typeof(NullStruct)
        };

        public override Type GetCommandRequestType(MessagingComponentCommand command) => command switch
        {
            MessagingComponentCommand.sendMessage => throw new NotImplementedException(),
            MessagingComponentCommand.fetchMessages => throw new NotImplementedException(),
            MessagingComponentCommand.purgeMessages => throw new NotImplementedException(),
            MessagingComponentCommand.touchMessages => throw new NotImplementedException(),
            MessagingComponentCommand.getMessages => throw new NotImplementedException(),
            _ => typeof(NullStruct)
        };

        public override Type GetCommandResponseType(MessagingComponentCommand command) => command switch
        {
            MessagingComponentCommand.sendMessage => throw new NotImplementedException(),
            MessagingComponentCommand.fetchMessages => throw new NotImplementedException(),
            MessagingComponentCommand.purgeMessages => throw new NotImplementedException(),
            MessagingComponentCommand.touchMessages => throw new NotImplementedException(),
            MessagingComponentCommand.getMessages => throw new NotImplementedException(),
            _ => typeof(NullStruct)
        };

        public override Type GetNotificationType(MessagingComponentNotification notification) => notification switch
        {
            MessagingComponentNotification.NotifyMessage => throw new NotImplementedException(),
            _ => typeof(NullStruct)
        };

        public enum MessagingComponentCommand : ushort
        {
            sendMessage = 1,
            fetchMessages = 2,
            purgeMessages = 3,
            touchMessages = 4,
            getMessages = 5,
        }

        public enum MessagingComponentNotification : ushort
        {
            NotifyMessage = 1,
        }

        public enum MessagingComponentError
        {
            MESSAGING_ERR_UNKNOWN = 65551,
            MESSAGING_ERR_MAX_ATTR_EXCEEDED = 131087,
            MESSAGING_ERR_DATABASE = 196623,
            MESSAGING_ERR_TARGET_NOT_FOUND = 262159,
            MESSAGING_ERR_TARGET_TYPE_INVALID = 327695,
            MESSAGING_ERR_TARGET_INBOX_FULL = 393231,
            MESSAGING_ERR_MATCH_NOT_FOUND = 458767,
            MESSAGING_ERR_FEATURE_DISABLED = 524303,
            MESSAGING_ERR_INVALID_PARAM = 589839,
        }

    }
}
