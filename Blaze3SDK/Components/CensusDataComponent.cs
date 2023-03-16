using Blaze3SDK.Blaze;
using BlazeCommon;
using static Blaze3SDK.Components.CensusDataComponent;

namespace Blaze3SDK.Components
{
    public class CensusDataComponent : ComponentData<CensusDataComponentCommand, CensusDataComponentNotification, CensusDataComponentError>
    {
        public CensusDataComponent() : base((ushort)Component.CensusDataComponent)
        {

        }

        public override Type GetCommandErrorResponseType(CensusDataComponentCommand command) => command switch
        {
            CensusDataComponentCommand.subscribeToCensusData => throw new NotImplementedException(),
            CensusDataComponentCommand.unsubscribeFromCensusData => throw new NotImplementedException(),
            CensusDataComponentCommand.getRegionCounts => throw new NotImplementedException(),
            CensusDataComponentCommand.getLatestCensusData => throw new NotImplementedException(),
            _ => typeof(NullStruct)
        };

        public override Type GetCommandRequestType(CensusDataComponentCommand command) => command switch
        {
            CensusDataComponentCommand.subscribeToCensusData => throw new NotImplementedException(),
            CensusDataComponentCommand.unsubscribeFromCensusData => throw new NotImplementedException(),
            CensusDataComponentCommand.getRegionCounts => throw new NotImplementedException(),
            CensusDataComponentCommand.getLatestCensusData => throw new NotImplementedException(),
            _ => typeof(NullStruct)
        };

        public override Type GetCommandResponseType(CensusDataComponentCommand command) => command switch
        {
            CensusDataComponentCommand.subscribeToCensusData => throw new NotImplementedException(),
            CensusDataComponentCommand.unsubscribeFromCensusData => throw new NotImplementedException(),
            CensusDataComponentCommand.getRegionCounts => throw new NotImplementedException(),
            CensusDataComponentCommand.getLatestCensusData => throw new NotImplementedException(),
            _ => typeof(NullStruct)
        };

        public override Type GetNotificationType(CensusDataComponentNotification notification) => notification switch
        {
            CensusDataComponentNotification.NotifyServerCensusData => throw new NotImplementedException(),
            _ => typeof(NullStruct)
        };

        public enum CensusDataComponentCommand : ushort
        {
            subscribeToCensusData = 1,
            unsubscribeFromCensusData = 2,
            getRegionCounts = 3,
            getLatestCensusData = 4,
        }

        public enum CensusDataComponentNotification : ushort
        {
            NotifyServerCensusData = 1,
        }

        public enum CensusDataComponentError
        {
            CENSUSDATA_ERR_PLAYER_ALREADY_SUBSCRIBED = 65546,
            CENSUSDATA_ERR_PLAYER_NOT_SUBSCRIBED = 131082,
        }

    }
}
