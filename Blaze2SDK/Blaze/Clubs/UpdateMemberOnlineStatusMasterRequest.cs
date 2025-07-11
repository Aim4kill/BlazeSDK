using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Clubs;

public class UpdateMemberOnlineStatusMasterRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClubId", "mClubId", 0x8ECA6400, TdfType.UInt32, 0, true), // CLID
        new TdfMemberInfo("MembershipStatus", "mMembershipStatus", 0x8EDD3000, TdfType.Enum, 1, true), // CMTP
        new TdfMemberInfo("ClubSettings", "mClubSettings", 0x8F397400, TdfType.Struct, 2, true), // CSET
        new TdfMemberInfo("Reason", "mReason", 0xCA587300, TdfType.Enum, 3, true), // REAS
        new TdfMemberInfo("NewStatus", "mNewStatus", 0xCF487400, TdfType.Enum, 4, true), // STAT
        new TdfMemberInfo("UserId", "mUserId", 0xD73A6400, TdfType.UInt32, 5, true), // USID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _clubId = new(__typeInfos[0]);
    private TdfEnum<Blaze2SDK.Blaze.Clubs.MembershipStatus> _membershipStatus = new(__typeInfos[1]);
    private TdfStruct<Blaze2SDK.Blaze.Clubs.ClubSettings?> _clubSettings = new(__typeInfos[2]);
    private TdfEnum<Blaze2SDK.Blaze.Clubs.ClubOnlineStatusUpdateReason> _reason = new(__typeInfos[3]);
    private TdfEnum<Blaze2SDK.Blaze.Clubs.MemberOnlineStatus> _newStatus = new(__typeInfos[4]);
    private TdfUInt32 _userId = new(__typeInfos[5]);

    public UpdateMemberOnlineStatusMasterRequest()
    {
        __members = [
            _clubId,
            _membershipStatus,
            _clubSettings,
            _reason,
            _newStatus,
            _userId,
        ];
    }

    public override Tdf CreateNew() => new UpdateMemberOnlineStatusMasterRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpdateMemberOnlineStatusMasterRequest";
    public override string GetFullClassName() => "Blaze::Clubs::UpdateMemberOnlineStatusMasterRequest";

    public uint ClubId
    {
        get => _clubId.Value;
        set => _clubId.Value = value;
    }

    public Blaze2SDK.Blaze.Clubs.MembershipStatus MembershipStatus
    {
        get => _membershipStatus.Value;
        set => _membershipStatus.Value = value;
    }

    public Blaze2SDK.Blaze.Clubs.ClubSettings? ClubSettings
    {
        get => _clubSettings.Value;
        set => _clubSettings.Value = value;
    }

    public Blaze2SDK.Blaze.Clubs.ClubOnlineStatusUpdateReason Reason
    {
        get => _reason.Value;
        set => _reason.Value = value;
    }

    public Blaze2SDK.Blaze.Clubs.MemberOnlineStatus NewStatus
    {
        get => _newStatus.Value;
        set => _newStatus.Value = value;
    }

    public uint UserId
    {
        get => _userId.Value;
        set => _userId.Value = value;
    }

}

