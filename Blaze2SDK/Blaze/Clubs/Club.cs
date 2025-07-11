using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Clubs;

public class Club : Tdf
{
    public enum ClubConfigParams : int
    {
        CLUBS_MAX_MEMBER_COUNT = 0,
        CLUBS_MAX_GM_COUNT = 1,
        CLUBS_MAX_DIVISION_SIZE = 2,
        CLUBS_MAX_NEWS_COUNT = 3,
        CLUBS_MAX_INVITE_COUNT = 4,
        CLUBS_MAX_INACTIVE_DAYS = 5,
        CLUBS_PURGE_HOUR = 6,
    }
    
    public enum ClubOnlineStatusUpdateReason : int
    {
        CLUBS_USER_SESSION_CREATED = 0,
        CLUBS_USER_SESSION_DESTROYED = 1,
        CLUBS_USER_JOINED_CLUB = 2,
        CLUBS_USER_LEFT_CLUB = 3,
        CLUBS_USER_ONLINE_STATUS_UPDATED = 4,
        CLUBS_CLUB_DESTROYED = 5,
        CLUBS_CLUB_CREATED = 6,
        CLUBS_CLUB_SETTINGS_UPDATED = 7,
        CLUBS_USER_PROMOTED_TO_GM = 8,
    }
    
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClubId", "mClubId", 0x8ECA6400, TdfType.UInt32, 0, true), // CLID
        new TdfMemberInfo("ClubInfo", "mClubInfo", 0x8ECA6E00, TdfType.Struct, 1, true), // CLIN
        new TdfMemberInfo("ClubSettings", "mClubSettings", 0x8ECCF400, TdfType.Struct, 2, true), // CLST
        new TdfMemberInfo("Name", "mName", 0xBA1B6500, TdfType.String, 3, true), // NAME
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _clubId = new(__typeInfos[0]);
    private TdfStruct<Blaze2SDK.Blaze.Clubs.ClubInfo?> _clubInfo = new(__typeInfos[1]);
    private TdfStruct<Blaze2SDK.Blaze.Clubs.ClubSettings?> _clubSettings = new(__typeInfos[2]);
    private TdfString _name = new(__typeInfos[3]);

    public Club()
    {
        __members = [
            _clubId,
            _clubInfo,
            _clubSettings,
            _name,
        ];
    }

    public override Tdf CreateNew() => new Club();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "Club";
    public override string GetFullClassName() => "Blaze::Clubs::Club";

    public uint ClubId
    {
        get => _clubId.Value;
        set => _clubId.Value = value;
    }

    public Blaze2SDK.Blaze.Clubs.ClubInfo? ClubInfo
    {
        get => _clubInfo.Value;
        set => _clubInfo.Value = value;
    }

    public Blaze2SDK.Blaze.Clubs.ClubSettings? ClubSettings
    {
        get => _clubSettings.Value;
        set => _clubSettings.Value = value;
    }

    public string Name
    {
        get => _name.Value;
        set => _name.Value = value;
    }

}

