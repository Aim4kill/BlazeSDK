using Blaze3SDK.Blaze;
using BlazeCommon;
using static Blaze3SDK.Components.GpsContentControllerComponent;

namespace Blaze3SDK.Components
{
    public class GpsContentControllerComponent : ComponentData<GpsContentControllerComponentCommand, GpsContentControllerComponentNotification, GpsContentControllerComponentError>
    {
        public GpsContentControllerComponent() : base((ushort)Component.GpsContentControllerComponent)
        {

        }

        public override Type GetCommandErrorResponseType(GpsContentControllerComponentCommand command) => command switch
        {
            GpsContentControllerComponentCommand.filePetition => throw new NotImplementedException(),
            GpsContentControllerComponentCommand.fetchContent => throw new NotImplementedException(),
            GpsContentControllerComponentCommand.showContent => throw new NotImplementedException(),
            _ => typeof(NullStruct)
        };

        public override Type GetCommandRequestType(GpsContentControllerComponentCommand command) => command switch
        {
            GpsContentControllerComponentCommand.filePetition => throw new NotImplementedException(),
            GpsContentControllerComponentCommand.fetchContent => throw new NotImplementedException(),
            GpsContentControllerComponentCommand.showContent => throw new NotImplementedException(),
            _ => typeof(NullStruct)
        };

        public override Type GetCommandResponseType(GpsContentControllerComponentCommand command) => command switch
        {
            GpsContentControllerComponentCommand.filePetition => throw new NotImplementedException(),
            GpsContentControllerComponentCommand.fetchContent => throw new NotImplementedException(),
            GpsContentControllerComponentCommand.showContent => throw new NotImplementedException(),
            _ => typeof(NullStruct)
        };

        public override Type GetNotificationType(GpsContentControllerComponentNotification notification) => notification switch
        {
            _ => typeof(NullStruct)
        };

        public enum GpsContentControllerComponentCommand : ushort
        {
            filePetition = 1,
            fetchContent = 2,
            showContent = 3,
        }

        public enum GpsContentControllerComponentNotification : ushort
        {
        }

        public enum GpsContentControllerComponentError
        {
            GPSCONTENTCONTROLLER_ERR_CONTENT_NOT_FOUND = 65563,
        }

    }
}
