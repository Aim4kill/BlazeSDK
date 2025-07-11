using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Clubs;

public class ReplicatedCachedMemberInfo : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MetaData", "mMetaData", 0xB6D92100, TdfType.Map, 0, true), // MMDA
        new TdfMemberInfo("MembershipStatus", "mMembershipStatus", 0xB73D2100, TdfType.Enum, 1, true), // MSTA
        new TdfMemberInfo("MembershipSinceTime", "mMembershipSinceTime", 0xCEED2400, TdfType.UInt32, 2, true), // SNTD
    ];
    private ITdfMember[] __members;

    private TdfMap<string, string> _metaData = new(__typeInfos[0]);
    private TdfEnum<Blaze3SDK.Blaze.Clubs.MembershipStatus> _membershipStatus = new(__typeInfos[1]);
    private TdfUInt32 _membershipSinceTime = new(__typeInfos[2]);

    public ReplicatedCachedMemberInfo()
    {
        __members = [
            _metaData,
            _membershipStatus,
            _membershipSinceTime,
        ];
    }

    public override Tdf CreateNew() => new ReplicatedCachedMemberInfo();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ReplicatedCachedMemberInfo";
    public override string GetFullClassName() => "Blaze::Clubs::ReplicatedCachedMemberInfo";

    public IDictionary<string, string> MetaData
    {
        get => _metaData.Value;
        set => _metaData.Value = value;
    }

    public Blaze3SDK.Blaze.Clubs.MembershipStatus MembershipStatus
    {
        get => _membershipStatus.Value;
        set => _membershipStatus.Value = value;
    }

    public uint MembershipSinceTime
    {
        get => _membershipSinceTime.Value;
        set => _membershipSinceTime.Value = value;
    }

}

