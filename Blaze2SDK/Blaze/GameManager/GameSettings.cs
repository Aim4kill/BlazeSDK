namespace Blaze2SDK.Blaze.GameManager;

[Flags]
public enum GameSettings : uint
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
    EnablePersistedGameId = 1024,
    AllowSameTeamId = 2048,
}

