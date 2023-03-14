using Blaze3SDK.Blaze;
using BlazeCommon;
using static Blaze3SDK.Components.ExampleComponent;

namespace Blaze3SDK.Components
{
    public class ExampleComponent : ComponentData<ExampleComponentCommand, ExampleComponentNotification, ExampleComponentError>
    {
        public ExampleComponent() : base((ushort)Component.ExampleComponent)
        {
            
        }

        public override Type GetCommandErrorResponseType(ExampleComponentCommand command) => command switch
        {
            ExampleComponentCommand.poke => throw new NotImplementedException(),
            _ => typeof(NullStruct),
        };
        
        public override Type GetCommandRequestType(ExampleComponentCommand command) => command switch
        {
            ExampleComponentCommand.poke => throw new NotImplementedException(),
            _ => typeof(NullStruct),
        };

        public override Type GetCommandResponseType(ExampleComponentCommand command) => command switch
        {
            ExampleComponentCommand.poke => throw new NotImplementedException(),
            _ => typeof(NullStruct),
        };

        public override Type GetNotificationType(ExampleComponentNotification notification) => notification switch
        {
            _ => typeof(NullStruct),
        };

        //commands dumped from latest bf3 server files
        public enum ExampleComponentCommand : ushort
        {
            poke = 1
        }

        //looks like there is no notifications for this component
        public enum ExampleComponentNotification : ushort
        {

        }

        //errors dumped from latest bf3 server files
        public enum ExampleComponentError
        {
            EXAMPLE_ERR_UNKNOWN = 65539
        }
    }
}
