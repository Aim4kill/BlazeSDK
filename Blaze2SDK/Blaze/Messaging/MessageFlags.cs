namespace Blaze2SDK.Blaze.Messaging;

[Flags]
public enum MessageFlags : uint
{
    None = 0,
    Persistent = 1,
    Echo = 2,
    FilterProfanity = 4,
}

