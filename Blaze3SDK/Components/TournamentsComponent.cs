using Blaze3SDK.Blaze;
using BlazeCommon;
using static Blaze3SDK.Components.TournamentsComponent;

namespace Blaze3SDK.Components
{
    public class TournamentsComponent : ComponentData<TournamentsComponentCommand, TournamentsComponentNotification, TournamentsComponentError>
    {
        public TournamentsComponent() : base((ushort)Component.TournamentsComponent)
        {

        }

        public override Type GetCommandErrorResponseType(TournamentsComponentCommand command) => command switch
        {
            TournamentsComponentCommand.getTournaments => throw new NotImplementedException(),
            TournamentsComponentCommand.getMemberCounts => throw new NotImplementedException(),
            TournamentsComponentCommand.getTrophies => throw new NotImplementedException(),
            TournamentsComponentCommand.getMyTournamentId => throw new NotImplementedException(),
            TournamentsComponentCommand.joinTournament => throw new NotImplementedException(),
            TournamentsComponentCommand.leaveTournament => throw new NotImplementedException(),
            TournamentsComponentCommand.resetMyTournament => throw new NotImplementedException(),
            TournamentsComponentCommand.getMyTournamentDetails => throw new NotImplementedException(),
            _ => typeof(NullStruct)
        };

        public override Type GetCommandRequestType(TournamentsComponentCommand command) => command switch
        {
            TournamentsComponentCommand.getTournaments => throw new NotImplementedException(),
            TournamentsComponentCommand.getMemberCounts => throw new NotImplementedException(),
            TournamentsComponentCommand.getTrophies => throw new NotImplementedException(),
            TournamentsComponentCommand.getMyTournamentId => throw new NotImplementedException(),
            TournamentsComponentCommand.joinTournament => throw new NotImplementedException(),
            TournamentsComponentCommand.leaveTournament => throw new NotImplementedException(),
            TournamentsComponentCommand.resetMyTournament => throw new NotImplementedException(),
            TournamentsComponentCommand.getMyTournamentDetails => throw new NotImplementedException(),
            _ => typeof(NullStruct)
        };

        public override Type GetCommandResponseType(TournamentsComponentCommand command) => command switch
        {
            TournamentsComponentCommand.getTournaments => throw new NotImplementedException(),
            TournamentsComponentCommand.getMemberCounts => throw new NotImplementedException(),
            TournamentsComponentCommand.getTrophies => throw new NotImplementedException(),
            TournamentsComponentCommand.getMyTournamentId => throw new NotImplementedException(),
            TournamentsComponentCommand.joinTournament => throw new NotImplementedException(),
            TournamentsComponentCommand.leaveTournament => throw new NotImplementedException(),
            TournamentsComponentCommand.resetMyTournament => throw new NotImplementedException(),
            TournamentsComponentCommand.getMyTournamentDetails => throw new NotImplementedException(),
            _ => typeof(NullStruct)
        };

        public override Type GetNotificationType(TournamentsComponentNotification notification) => notification switch
        {
            _ => typeof(NullStruct)
        };

        public enum TournamentsComponentCommand : ushort
        {
            getTournaments = 1,
            getMemberCounts = 2,
            getTrophies = 4,
            getMyTournamentId = 5,
            joinTournament = 6,
            leaveTournament = 7,
            resetMyTournament = 8,
            getMyTournamentDetails = 9,
        }

        public enum TournamentsComponentNotification : ushort
        {
        }

        public enum TournamentsComponentError
        {
            TOURN_ERR_TOURNAMENT_GENERIC = 65559,
            TOURN_ERR_TOURNAMENT_NOT_FOUND = 131095,
            TOURN_ERR_ALREADY_IN_TOURNAMENT = 196631,
            TOURN_ERR_USER_NOT_IN_TOURNAMENT = 262167,
            TOURN_ERR_USER_NOT_FOUND = 327703,
            TOURN_ERR_TOURNAMENT_DISABLED = 393239,
            TOURN_ERR_TIES_NOT_SUPPORTED = 458775,
        }

    }
}
