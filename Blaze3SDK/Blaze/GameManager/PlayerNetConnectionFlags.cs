namespace Blaze3SDK.Blaze.GameManager;

[Flags]
public enum PlayerNetConnectionFlags : int
{
    None = 0,
    _DEPRECATED = 1,
    ConnectionDemangled = 2,
    ConnectionPktReceived = 4,
}

