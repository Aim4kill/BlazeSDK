using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Clubs;

public class ClubOnlineStatusData : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MemberMap", "mMemberMap", 0x8ECB6C00, TdfType.Map, 0, true), // CLML
        new TdfMemberInfo("ClubSettings", "mClubSettings", 0x8F397400, TdfType.Struct, 1, true), // CSET
        new TdfMemberInfo("MemberOnlineStatusCounts", "mMemberOnlineStatusCounts", 0xB738EF00, TdfType.Map, 2, true), // MSCO
    ];
    private ITdfMember[] __members;

    private TdfMap<uint, Blaze2SDK.Blaze.Clubs.ClubMember> _memberMap = new(__typeInfos[0]);
    private TdfStruct<Blaze2SDK.Blaze.Clubs.ClubSettings?> _clubSettings = new(__typeInfos[1]);
    private TdfMap<Blaze2SDK.Blaze.Clubs.MemberOnlineStatus, ushort> _memberOnlineStatusCounts = new(__typeInfos[2]);

    public ClubOnlineStatusData()
    {
        __members = [
            _memberMap,
            _clubSettings,
            _memberOnlineStatusCounts,
        ];
    }

    public override Tdf CreateNew() => new ClubOnlineStatusData();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ClubOnlineStatusData";
    public override string GetFullClassName() => "Blaze::Clubs::ClubOnlineStatusData";

    public IDictionary<uint, Blaze2SDK.Blaze.Clubs.ClubMember> MemberMap
    {
        get => _memberMap.Value;
        set => _memberMap.Value = value;
    }

    public Blaze2SDK.Blaze.Clubs.ClubSettings? ClubSettings
    {
        get => _clubSettings.Value;
        set => _clubSettings.Value = value;
    }

    public IDictionary<Blaze2SDK.Blaze.Clubs.MemberOnlineStatus, ushort> MemberOnlineStatusCounts
    {
        get => _memberOnlineStatusCounts.Value;
        set => _memberOnlineStatusCounts.Value = value;
    }

}

