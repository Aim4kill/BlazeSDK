using Blaze3SDK.Blaze;
using Blaze3SDK.Blaze.Playgroups;
using BlazeCommon;
using static Blaze3SDK.Components.PlaygroupsComponent;

namespace Blaze3SDK.Components
{
    public class PlaygroupsComponent : ComponentData<PlaygroupsComponentCommand, PlaygroupsComponentNotification, PlaygroupsComponentCommand>
    {
        public PlaygroupsComponent() : base((ushort)Component.PlaygroupsComponent)
        {

        }

        public override Type GetCommandErrorResponseType(PlaygroupsComponentCommand command) => command switch
        {
            PlaygroupsComponentCommand.createPlaygroup => throw new NotImplementedException(),
            PlaygroupsComponentCommand.destroyPlaygroup => throw new NotImplementedException(),
            PlaygroupsComponentCommand.joinPlaygroup => throw new NotImplementedException(),
            PlaygroupsComponentCommand.leavePlaygroup => throw new NotImplementedException(),
            PlaygroupsComponentCommand.setPlaygroupAttributes => throw new NotImplementedException(),
            PlaygroupsComponentCommand.setMemberAttributes => throw new NotImplementedException(),
            PlaygroupsComponentCommand.kickPlaygroupMember => throw new NotImplementedException(),
            PlaygroupsComponentCommand.setPlaygroupJoinControls => throw new NotImplementedException(),
            PlaygroupsComponentCommand.finalizePlaygroupCreation => throw new NotImplementedException(),
            PlaygroupsComponentCommand.lookupPlaygroupInfo => throw new NotImplementedException(),
            PlaygroupsComponentCommand.resetPlaygroupSession => throw new NotImplementedException(),
            _ => typeof(NullStruct),
        };

        public override Type GetCommandRequestType(PlaygroupsComponentCommand command) => command switch
        {
            PlaygroupsComponentCommand.createPlaygroup => throw new NotImplementedException(),
            PlaygroupsComponentCommand.destroyPlaygroup => throw new NotImplementedException(),
            PlaygroupsComponentCommand.joinPlaygroup => throw new NotImplementedException(),
            PlaygroupsComponentCommand.leavePlaygroup => throw new NotImplementedException(),
            PlaygroupsComponentCommand.setPlaygroupAttributes => throw new NotImplementedException(),
            PlaygroupsComponentCommand.setMemberAttributes => throw new NotImplementedException(),
            PlaygroupsComponentCommand.kickPlaygroupMember => throw new NotImplementedException(),
            PlaygroupsComponentCommand.setPlaygroupJoinControls => throw new NotImplementedException(),
            PlaygroupsComponentCommand.finalizePlaygroupCreation => throw new NotImplementedException(),
            PlaygroupsComponentCommand.lookupPlaygroupInfo => throw new NotImplementedException(),
            PlaygroupsComponentCommand.resetPlaygroupSession => throw new NotImplementedException(),
            _ => typeof(NullStruct),
        };

        public override Type GetCommandResponseType(PlaygroupsComponentCommand command) => command switch
        {
            PlaygroupsComponentCommand.createPlaygroup => throw new NotImplementedException(),
            PlaygroupsComponentCommand.destroyPlaygroup => throw new NotImplementedException(),
            PlaygroupsComponentCommand.joinPlaygroup => throw new NotImplementedException(),
            PlaygroupsComponentCommand.leavePlaygroup => throw new NotImplementedException(),
            PlaygroupsComponentCommand.setPlaygroupAttributes => throw new NotImplementedException(),
            PlaygroupsComponentCommand.setMemberAttributes => throw new NotImplementedException(),
            PlaygroupsComponentCommand.kickPlaygroupMember => throw new NotImplementedException(),
            PlaygroupsComponentCommand.setPlaygroupJoinControls => throw new NotImplementedException(),
            PlaygroupsComponentCommand.finalizePlaygroupCreation => throw new NotImplementedException(),
            PlaygroupsComponentCommand.lookupPlaygroupInfo => throw new NotImplementedException(),
            PlaygroupsComponentCommand.resetPlaygroupSession => throw new NotImplementedException(),
            _ => typeof(NullStruct),
        };

        public override Type GetNotificationType(PlaygroupsComponentNotification notification) => notification switch
        {
            PlaygroupsComponentNotification.NotifyDestroyPlaygroup => typeof(NotifyDestroyPlaygroup),
            PlaygroupsComponentNotification.NotifyJoinPlaygroup => typeof(NotifyJoinPlaygroup),
            PlaygroupsComponentNotification.NotifyMemberJoinedPlaygroup => typeof(NotifyMemberJoinedPlaygroup),
            PlaygroupsComponentNotification.NotifyMemberRemovedFromPlaygroup => typeof(NotifyMemberRemoveFromPlaygroup),
            PlaygroupsComponentNotification.NotifyPlaygroupAttributesSet => typeof(NotifyPlaygroupAttributesSet),
            PlaygroupsComponentNotification.NotifyMemberAttributesSet => typeof(NotifyMemberAttributesSet),
            PlaygroupsComponentNotification.NotifyLeaderChange => typeof(NotifyLeaderChange),
            PlaygroupsComponentNotification.NotifyMemberPermissionsChange => typeof(NotifyMemberPermissionsChange),
            PlaygroupsComponentNotification.NotifyJoinControlsChange => typeof(NotifyJoinControlsChange),
            PlaygroupsComponentNotification.NotifyXboxSessionInfo => typeof(NotifyXboxSessionInfo),
            PlaygroupsComponentNotification.NotifyXboxSessionChange => typeof(NotifyXboxSessionInfo),
            _ => typeof(NullStruct),
        };

        public enum PlaygroupsComponentError
        {
            PLAYGROUPS_ERR_NOT_IN_GROUP = 65542,
            PLAYGROUPS_ERR_NOT_AUTHORIZED = 131078,
            PLAYGROUPS_ERR_GROUP_FULL = 196614,
            PLAYGROUPS_ERR_INVALID_ENTITY = 262150,
            PLAYGROUPS_ERR_GROUP_NOT_FOUND = 327686,
            PLAYGROUPS_ERR_GROUP_CLOSED = 393222,
            PLAYGROUPS_ERR_USER_NOT_IN_ANY_GROUP = 458758,
            PLAYGROUPS_ERR_GROUP_ALREADY_EXISTS = 524294,
            PLAYGROUPS_ERR_ALREADY_IN_GROUP = 589830
        }

        public enum PlaygroupsComponentCommand : ushort
        {
            createPlaygroup = 1,
            destroyPlaygroup = 2,
            joinPlaygroup = 3,
            leavePlaygroup = 4,
            setPlaygroupAttributes = 5,
            setMemberAttributes = 6,
            kickPlaygroupMember = 7,
            setPlaygroupJoinControls = 8,
            finalizePlaygroupCreation = 9,
            lookupPlaygroupInfo = 10,
            resetPlaygroupSession = 11
        }

        public enum PlaygroupsComponentNotification : ushort
        {
            NotifyDestroyPlaygroup = 50,
            NotifyJoinPlaygroup = 51,
            NotifyMemberJoinedPlaygroup = 52,
            NotifyMemberRemovedFromPlaygroup = 53,
            NotifyPlaygroupAttributesSet = 54,
            NotifyMemberAttributesSet = 75,
            NotifyLeaderChange = 79,
            NotifyMemberPermissionsChange = 80,
            NotifyJoinControlsChange = 85,
            NotifyXboxSessionInfo = 86,
            NotifyXboxSessionChange = 87
        }

    }
}
