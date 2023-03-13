namespace Blaze3SDK.Blaze.GameManager
{
    public enum GameDestructionReason
    {
        SYS_GAME_ENDING = 0x0,
        SYS_CREATION_FAILED = 0x1,
        HOST_LEAVING = 0x2,
        HOST_INJECTION = 0x3,
        HOST_EJECTION = 0x4,
        LOCAL_PLAYER_LEAVING = 0x5,
        TITLE_REASON_BASE_GAME_DESTRUCTION_REASON = 0x6,
    }
}
