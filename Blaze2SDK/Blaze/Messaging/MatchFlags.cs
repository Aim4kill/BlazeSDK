namespace Blaze2SDK.Blaze.Messaging;

[Flags]
public enum MatchFlags : uint
{
    None = 0,
    MatchId = 1,
    MatchSource = 2,
    MatchType = 4,
}

