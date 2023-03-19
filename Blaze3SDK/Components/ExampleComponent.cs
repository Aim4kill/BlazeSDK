using Blaze3SDK.Blaze;
using Blaze3SDK.Blaze.Example;
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
            ExampleComponentCommand.poke => typeof(ExampleError),
            _ => typeof(NullStruct),
        };
        
        public override Type GetCommandRequestType(ExampleComponentCommand command) => command switch
        {
            ExampleComponentCommand.poke => typeof(ExampleRequest),
            _ => typeof(NullStruct),
        };

        public override Type GetCommandResponseType(ExampleComponentCommand command) => command switch
        {
            ExampleComponentCommand.poke => typeof(ExampleResponse),
            _ => typeof(NullStruct),
        };

        public override Type GetNotificationType(ExampleComponentNotification notification) => notification switch
        {
            _ => typeof(NullStruct),
        };

        public enum ExampleComponentCommand : ushort
        {
            poke = 1
        }

        public enum ExampleComponentNotification : ushort
        {

        }

        public enum ExampleComponentError
        {
            EXAMPLE_ERR_UNKNOWN = 65539
        }
    }
}
