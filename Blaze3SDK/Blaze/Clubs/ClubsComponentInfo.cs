using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Clubs;

public class ClubsComponentInfo : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClubsCount", "mClubsCount", 0x8EC8EE00, TdfType.UInt32, 0, true), // CLCN
        new TdfMemberInfo("ClubsByDomain", "mClubsByDomain", 0x8EC92D00, TdfType.Map, 1, true), // CLDM
        new TdfMemberInfo("MembersCount", "mMembersCount", 0xB628EE00, TdfType.UInt32, 2, true), // MBCN
        new TdfMemberInfo("MembersByDomain", "mMembersByDomain", 0xB6292D00, TdfType.Map, 3, true), // MBDM
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _clubsCount = new(__typeInfos[0]);
    private TdfMap<uint, uint> _clubsByDomain = new(__typeInfos[1]);
    private TdfUInt32 _membersCount = new(__typeInfos[2]);
    private TdfMap<uint, uint> _membersByDomain = new(__typeInfos[3]);

    public ClubsComponentInfo()
    {
        __members = [
            _clubsCount,
            _clubsByDomain,
            _membersCount,
            _membersByDomain,
        ];
    }

    public override Tdf CreateNew() => new ClubsComponentInfo();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ClubsComponentInfo";
    public override string GetFullClassName() => "Blaze::Clubs::ClubsComponentInfo";

    public uint ClubsCount
    {
        get => _clubsCount.Value;
        set => _clubsCount.Value = value;
    }

    public IDictionary<uint, uint> ClubsByDomain
    {
        get => _clubsByDomain.Value;
        set => _clubsByDomain.Value = value;
    }

    public uint MembersCount
    {
        get => _membersCount.Value;
        set => _membersCount.Value = value;
    }

    public IDictionary<uint, uint> MembersByDomain
    {
        get => _membersByDomain.Value;
        set => _membersByDomain.Value = value;
    }

}

