namespace Blaze2SDK.Blaze.GameManager;

public enum PlayerRemovedReason : int
{
    PLAYER_JOIN_TIMEOUT = 0,
    PLAYER_CONN_LOST = 1,
    BLAZESERVER_CONN_LOST = 2,
    MIGRATION_FAILED = 3,
    GAME_DESTROYED = 4,
    GAME_ENDED = 5,
    PLAYER_LEFT = 6,
    GROUP_LEFT = 7,
    PLAYER_KICKED = 8,
    PLAYER_KICKED_WITH_BAN = 9,
    PLAYER_JOIN_FROM_QUEUE_FAILED = 10,
}

