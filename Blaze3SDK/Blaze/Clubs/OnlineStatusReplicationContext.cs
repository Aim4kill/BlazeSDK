using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Clubs;

public class OnlineStatusReplicationContext : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("OldSpecificClubId", "mOldSpecificClubId", 0x8ECA6400, TdfType.UInt32, 0, true), // CLID
        new TdfMemberInfo("UpdateReason", "mUpdateReason", 0x8F5CA500, TdfType.Enum, 1, true), // CURE
        new TdfMemberInfo("OldMemberOnlineStatus", "mOldMemberOnlineStatus", 0xBEC93300, TdfType.Enum, 2, true), // OLDS
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _oldSpecificClubId = new(__typeInfos[0]);
    private TdfEnum<Blaze3SDK.Blaze.Clubs.UpdateReason> _updateReason = new(__typeInfos[1]);
    private TdfEnum<Blaze3SDK.Blaze.Clubs.MemberOnlineStatus> _oldMemberOnlineStatus = new(__typeInfos[2]);

    public OnlineStatusReplicationContext()
    {
        __members = [
            _oldSpecificClubId,
            _updateReason,
            _oldMemberOnlineStatus,
        ];
    }

    public override Tdf CreateNew() => new OnlineStatusReplicationContext();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "OnlineStatusReplicationContext";
    public override string GetFullClassName() => "Blaze::Clubs::OnlineStatusReplicationContext";

    public uint OldSpecificClubId
    {
        get => _oldSpecificClubId.Value;
        set => _oldSpecificClubId.Value = value;
    }

    public Blaze3SDK.Blaze.Clubs.UpdateReason UpdateReason
    {
        get => _updateReason.Value;
        set => _updateReason.Value = value;
    }

    public Blaze3SDK.Blaze.Clubs.MemberOnlineStatus OldMemberOnlineStatus
    {
        get => _oldMemberOnlineStatus.Value;
        set => _oldMemberOnlineStatus.Value = value;
    }

}

