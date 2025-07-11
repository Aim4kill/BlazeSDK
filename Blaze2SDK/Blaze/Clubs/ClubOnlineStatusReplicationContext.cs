using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Clubs;

public class ClubOnlineStatusReplicationContext : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClubId", "mClubId", 0x8ECA6400, TdfType.UInt32, 0, true), // CLID
        new TdfMemberInfo("UpdateReason", "mUpdateReason", 0x8F5CA500, TdfType.Enum, 1, true), // CURE
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _clubId = new(__typeInfos[0]);
    private TdfEnum<Blaze2SDK.Blaze.Clubs.ClubOnlineStatusUpdateReason> _updateReason = new(__typeInfos[1]);

    public ClubOnlineStatusReplicationContext()
    {
        __members = [
            _clubId,
            _updateReason,
        ];
    }

    public override Tdf CreateNew() => new ClubOnlineStatusReplicationContext();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ClubOnlineStatusReplicationContext";
    public override string GetFullClassName() => "Blaze::Clubs::ClubOnlineStatusReplicationContext";

    public uint ClubId
    {
        get => _clubId.Value;
        set => _clubId.Value = value;
    }

    public Blaze2SDK.Blaze.Clubs.ClubOnlineStatusUpdateReason UpdateReason
    {
        get => _updateReason.Value;
        set => _updateReason.Value = value;
    }

}

