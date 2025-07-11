namespace Blaze3SDK.Blaze.Clubs;

public enum UpdateReason : int
{
    UPDATE_REASON_USER_SESSION_CREATED = 0,
    UPDATE_REASON_USER_SESSION_DESTROYED = 1,
    UPDATE_REASON_USER_JOINED_CLUB = 2,
    UPDATE_REASON_USER_LEFT_CLUB = 3,
    UPDATE_REASON_USER_ONLINE_STATUS_UPDATED = 4,
    UPDATE_REASON_CLUB_DESTROYED = 5,
    UPDATE_REASON_CLUB_CREATED = 6,
    UPDATE_REASON_CLUB_SETTINGS_UPDATED = 7,
    UPDATE_REASON_USER_PROMOTED_TO_GM = 8,
    UPDATE_REASON_USER_DEMOTED_TO_MEMBER = 9,
    UPDATE_REASON_TRANSFER_OWNERSHIP = 10,
}

