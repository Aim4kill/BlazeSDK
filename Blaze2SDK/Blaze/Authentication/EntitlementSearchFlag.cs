namespace Blaze2SDK.Blaze.Authentication;

[Flags]
public enum EntitlementSearchFlag : int
{
    None = 0,
    IncludePersonaLink = 1,
    IncludeUnlinked = 2,
}

