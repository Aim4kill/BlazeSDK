using Blaze3SDK.Blaze;
using Blaze3SDK.Blaze.Redirector;
using BlazeCommon;
using static Blaze3SDK.Components.RedirectorComponent;

namespace Blaze3SDK.Components
{
    public class RedirectorComponent : ComponentData<RedirectorComponentCommand, RedirectorComponentNotification, RedirectorComponentError>
    {
        public RedirectorComponent() : base((ushort)Component.RedirectorComponent)
        {
            
        }
        
        public override Type GetCommandErrorResponseType(RedirectorComponentCommand command) => command switch
        {
            RedirectorComponentCommand.getServerInstance => typeof(ServerInstanceError),
            _ => typeof(NullStruct)
        };

        public override Type GetCommandRequestType(RedirectorComponentCommand command) => command switch
        {
            RedirectorComponentCommand.getServerInstance => typeof(ServerInstanceRequest),
            _ => typeof(NullStruct)
        };

        public override Type GetCommandResponseType(RedirectorComponentCommand command) => command switch
        {
            RedirectorComponentCommand.getServerInstance => typeof(ServerInstanceInfo),
            _ => typeof(NullStruct)
        };

        public override Type GetNotificationType(RedirectorComponentNotification notification) => notification switch
        {
            _ => typeof(NullStruct),
        };

        //commands dumped from latest bf3 server files
        public enum RedirectorComponentCommand : ushort
        {
            getServerInstance = 1
        }
        
        //looks like there is no notifications for this component
        public enum RedirectorComponentNotification : ushort
        {

        }

        //errors dumped from latest bf3 server files
        public enum RedirectorComponentError : int
        {
            REDIRECTOR_SERVER_NOT_FOUND = 65541,
            REDIRECTOR_NO_SERVER_CAPACITY = 131077,
            REDIRECTOR_NO_MATCHING_INSTANCE = 196613,
            REDIRECTOR_SERVER_NAME_ALREADY_IN_USE = 262149,
            REDIRECTOR_CLIENT_NOT_COMPATIBLE = 327685,
            REDIRECTOR_CLIENT_UNKNOWN = 393221,
            REDIRECTOR_UNKNOWN_CONNECTION_PROFILE = 458757,
            REDIRECTOR_SERVER_SUNSET = 524293,
            REDIRECTOR_SERVER_DOWN = 589829,
            REDIRECTOR_INVALID_PARAMETER = 655365,
            REDIRECTOR_UNKNOWN_SERVICE_NAME = 720901,
            REDIRECTOR_PAST_EVENT = 786437,
            REDIRECTOR_UNKNOWN_SCHEDULE_ID = 851973
        }
    }
}
