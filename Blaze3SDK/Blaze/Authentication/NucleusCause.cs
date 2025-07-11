namespace Blaze3SDK.Blaze.Authentication;

public enum NucleusCause : int
{
    UNKNOWN = 0,
    INVALID_VALUE = 1,
    ILLEGAL_VALUE = 2,
    MISSING_VALUE = 3,
    DUPLICATE_VALUE = 4,
    INVALID_EMAIL_DOMAIN = 5,
    SPACES_NOT_ALLOWED = 6,
    TOO_SHORT = 7,
    TOO_LONG = 8,
    TOO_YOUNG = 9,
    TOO_OLD = 10,
    ILLEGAL_FOR_COUNTRY = 11,
    BANNED_COUNTRY = 12,
    NOT_ALLOWED = 13,
    TOKEN_EXPIRED = 14,
    OPTIN_MISMATCH = 15,
}

