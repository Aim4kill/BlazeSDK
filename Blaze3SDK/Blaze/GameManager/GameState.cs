namespace Blaze3SDK.Blaze.GameManager
{
    public enum GameState
    {
        NEW_STATE = 0x0,
        INITIALIZING = 0x1,
        VIRTUAL = 0x2,
        PRE_GAME = 0x82,
        IN_GAME = 0x83,
        POST_GAME = 0x4,
        MIGRATING = 0x5,
        DESTRUCTING = 0x6,
        RESETABLE = 0x7,
        REPLAY_SETUP = 0x8
    }
}
