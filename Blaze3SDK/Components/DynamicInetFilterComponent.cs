using Blaze3SDK.Blaze;
using BlazeCommon;
using static Blaze3SDK.Components.DynamicInetFilterComponent;

namespace Blaze3SDK.Components
{
    public class DynamicInetFilterComponent : ComponentData<DynamicInetFilterComponentCommand, DynamicInetFilterComponentNotification, DynamicInetFilterComponentError>
    {
        public DynamicInetFilterComponent() : base((ushort)Component.DynamicInetFilterComponent)
        {

        }

        public override Type GetCommandErrorResponseType(DynamicInetFilterComponentCommand command) => command switch
        {
            DynamicInetFilterComponentCommand.add => throw new NotImplementedException(),
            DynamicInetFilterComponentCommand.update => throw new NotImplementedException(),
            DynamicInetFilterComponentCommand.remove => throw new NotImplementedException(),
            DynamicInetFilterComponentCommand.listInfo => throw new NotImplementedException(),
            _ => typeof(NullStruct)
        };

        public override Type GetCommandRequestType(DynamicInetFilterComponentCommand command) => command switch
        {
            DynamicInetFilterComponentCommand.add => throw new NotImplementedException(),
            DynamicInetFilterComponentCommand.update => throw new NotImplementedException(),
            DynamicInetFilterComponentCommand.remove => throw new NotImplementedException(),
            DynamicInetFilterComponentCommand.listInfo => throw new NotImplementedException(),
            _ => typeof(NullStruct)
        };

        public override Type GetCommandResponseType(DynamicInetFilterComponentCommand command) => command switch
        {
            DynamicInetFilterComponentCommand.add => throw new NotImplementedException(),
            DynamicInetFilterComponentCommand.update => throw new NotImplementedException(),
            DynamicInetFilterComponentCommand.remove => throw new NotImplementedException(),
            DynamicInetFilterComponentCommand.listInfo => throw new NotImplementedException(),
            _ => typeof(NullStruct)
        };

        public override Type GetNotificationType(DynamicInetFilterComponentNotification notification) => notification switch
        {
            _ => typeof(NullStruct)
        };

        public enum DynamicInetFilterComponentCommand : ushort
        {
            add = 1,
            update = 2,
            remove = 3,
            listInfo = 4,
        }

        public enum DynamicInetFilterComponentNotification : ushort
        {
        }

        public enum DynamicInetFilterComponentError
        {
            DYNAMICINETFILTER_ERR_ROW_NOT_FOUND = 67536,
            DYNAMICINETFILTER_ERR_INVALID_GROUP = 133072,
            DYNAMICINETFILTER_ERR_INVALID_OWNER = 198608,
            DYNAMICINETFILTER_ERR_INVALID_SUBNET = 264144,
            DYNAMICINETFILTER_ERR_INVALID_COMMENT = 329680,
        }

    }
}
