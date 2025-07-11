using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Clubs;

public class ClubMember : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("BlazeId", "mBlazeId", 0x8ACA6400, TdfType.Int64, 0, true), // BLID
        new TdfMemberInfo("MembershipStatus", "mMembershipStatus", 0x8EDD3000, TdfType.Enum, 1, true), // CMTP
        new TdfMemberInfo("OnlineStatus", "mOnlineStatus", 0xB62BF300, TdfType.Enum, 2, true), // MBOS
        new TdfMemberInfo("MetaData", "mMetaData", 0xB65D2100, TdfType.Map, 3, true), // META
        new TdfMemberInfo("MembershipSinceTime", "mMembershipSinceTime", 0xB73D2D00, TdfType.UInt32, 4, true), // MSTM
        new TdfMemberInfo("Persona", "mPersona", 0xC25CB300, TdfType.String, 5, true), // PERS
    ];
    private ITdfMember[] __members;

    private TdfInt64 _blazeId = new(__typeInfos[0]);
    private TdfEnum<Blaze3SDK.Blaze.Clubs.MembershipStatus> _membershipStatus = new(__typeInfos[1]);
    private TdfEnum<Blaze3SDK.Blaze.Clubs.MemberOnlineStatus> _onlineStatus = new(__typeInfos[2]);
    private TdfMap<string, string> _metaData = new(__typeInfos[3]);
    private TdfUInt32 _membershipSinceTime = new(__typeInfos[4]);
    private TdfString _persona = new(__typeInfos[5]);

    public ClubMember()
    {
        __members = [
            _blazeId,
            _membershipStatus,
            _onlineStatus,
            _metaData,
            _membershipSinceTime,
            _persona,
        ];
    }

    public override Tdf CreateNew() => new ClubMember();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ClubMember";
    public override string GetFullClassName() => "Blaze::Clubs::ClubMember";

    public long BlazeId
    {
        get => _blazeId.Value;
        set => _blazeId.Value = value;
    }

    public Blaze3SDK.Blaze.Clubs.MembershipStatus MembershipStatus
    {
        get => _membershipStatus.Value;
        set => _membershipStatus.Value = value;
    }

    public Blaze3SDK.Blaze.Clubs.MemberOnlineStatus OnlineStatus
    {
        get => _onlineStatus.Value;
        set => _onlineStatus.Value = value;
    }

    public IDictionary<string, string> MetaData
    {
        get => _metaData.Value;
        set => _metaData.Value = value;
    }

    public uint MembershipSinceTime
    {
        get => _membershipSinceTime.Value;
        set => _membershipSinceTime.Value = value;
    }

    public string Persona
    {
        get => _persona.Value;
        set => _persona.Value = value;
    }

}

