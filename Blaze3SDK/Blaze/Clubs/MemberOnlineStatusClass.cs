using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Clubs;

public class MemberOnlineStatusClass : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MemberOnlineStatus", "mMemberOnlineStatus", 0xB6FCF400, TdfType.Enum, 0, true), // MOST
        new TdfMemberInfo("MembershipStatus", "mMembershipStatus", 0xB73CF400, TdfType.Enum, 1, true), // MSST
    ];
    private ITdfMember[] __members;

    private TdfEnum<Blaze3SDK.Blaze.Clubs.MemberOnlineStatus> _memberOnlineStatus = new(__typeInfos[0]);
    private TdfEnum<Blaze3SDK.Blaze.Clubs.MembershipStatus> _membershipStatus = new(__typeInfos[1]);

    public MemberOnlineStatusClass()
    {
        __members = [
            _memberOnlineStatus,
            _membershipStatus,
        ];
    }

    public override Tdf CreateNew() => new MemberOnlineStatusClass();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "MemberOnlineStatusClass";
    public override string GetFullClassName() => "Blaze::Clubs::MemberOnlineStatusClass";

    public Blaze3SDK.Blaze.Clubs.MemberOnlineStatus MemberOnlineStatus
    {
        get => _memberOnlineStatus.Value;
        set => _memberOnlineStatus.Value = value;
    }

    public Blaze3SDK.Blaze.Clubs.MembershipStatus MembershipStatus
    {
        get => _membershipStatus.Value;
        set => _membershipStatus.Value = value;
    }

}

