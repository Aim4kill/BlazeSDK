namespace Blaze2SDK.Blaze.GameManager
{
    public enum JoinMethod : int
    {
        JOIN_BY_BROWSING = 0x1,
        JOIN_BY_MATCHMAKING = 0x2,
        JOIN_BY_INVITES = 0x4,
        JOIN_BY_PLAYER = 0x8,
        SYS_JOIN_BY_FOLLOWLEADER_CREATEGAME = 0xF,
        SYS_JOIN_BY_RESETDEDICATEDSERVER = 0x10,
        SYS_JOIN_BY_FOLLOWLEADER_RESETDEDICATEDSERVER = 0x20,
        SYS_JOIN_BY_FOLLOWLEADER_CREATEGAME_HOST = 0x40,
    }
}
