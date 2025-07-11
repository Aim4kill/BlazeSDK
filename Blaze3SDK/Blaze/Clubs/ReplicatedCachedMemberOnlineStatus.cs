using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Clubs;

public class ReplicatedCachedMemberOnlineStatus : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClubId", "mClubId", 0x8ECA6400, TdfType.UInt32, 0, true), // CLID
        new TdfMemberInfo("MemberOnlineStatus", "mMemberOnlineStatus", 0x8EDBF300, TdfType.Enum, 1, true), // CMOS
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _clubId = new(__typeInfos[0]);
    private TdfEnum<Blaze3SDK.Blaze.Clubs.MemberOnlineStatus> _memberOnlineStatus = new(__typeInfos[1]);

    public ReplicatedCachedMemberOnlineStatus()
    {
        __members = [
            _clubId,
            _memberOnlineStatus,
        ];
    }

    public override Tdf CreateNew() => new ReplicatedCachedMemberOnlineStatus();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ReplicatedCachedMemberOnlineStatus";
    public override string GetFullClassName() => "Blaze::Clubs::ReplicatedCachedMemberOnlineStatus";

    public uint ClubId
    {
        get => _clubId.Value;
        set => _clubId.Value = value;
    }

    public Blaze3SDK.Blaze.Clubs.MemberOnlineStatus MemberOnlineStatus
    {
        get => _memberOnlineStatus.Value;
        set => _memberOnlineStatus.Value = value;
    }

}

