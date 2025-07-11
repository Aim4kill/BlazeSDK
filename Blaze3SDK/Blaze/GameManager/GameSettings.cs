namespace Blaze3SDK.Blaze.GameManager;

[Flags]
public enum GameSettings : int
{
    None = 0,
    OpenToBrowsing = 1,
    OpenToMatchmaking = 2,
    OpenToInvites = 4,
    OpenToJoinByPlayer = 8,
    HostMigratable = 16,
    Ranked = 32,
    AdminOnlyInvites = 64,
    EnforceSingleGroupJoin = 128,
    JoinInProgressSupported = 256,
    AdminInvitesOnlyIgnoreEntryChecks = 512,
    IgnoreEntryCriteriaWithInvite = 1024,
    EnablePersistedGameId = 2048,
    AllowSameTeamId = 4096,
    Virtualized = 8192,
    SendOrphanedGameReportEvent = 16384,
    AllowAnyReputation = 32768,
    LockedAsBusy = 65536,
    DisconnectReservation = 131072,
    DynamicReputationRequirement = 262144,
    FriendsBypassClosedToJoinByPlayer = 524288,
    AllowMemberGameAttributeEdit = 1048576,
}

