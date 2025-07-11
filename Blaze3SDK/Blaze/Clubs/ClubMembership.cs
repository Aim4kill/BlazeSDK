using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Clubs;

public class ClubMembership : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClubId", "mClubId", 0x8ECA6400, TdfType.UInt32, 0, true), // CLID
        new TdfMemberInfo("ClubDomainId", "mClubDomainId", 0x92DA6400, TdfType.UInt32, 1, true), // DMID
        new TdfMemberInfo("ClubMember", "mClubMember", 0xB6297200, TdfType.Struct, 2, true), // MBER
        new TdfMemberInfo("ClubName", "mClubName", 0xBA1B6500, TdfType.String, 3, true), // NAME
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _clubId = new(__typeInfos[0]);
    private TdfUInt32 _clubDomainId = new(__typeInfos[1]);
    private TdfStruct<Blaze3SDK.Blaze.Clubs.ClubMember?> _clubMember = new(__typeInfos[2]);
    private TdfString _clubName = new(__typeInfos[3]);

    public ClubMembership()
    {
        __members = [
            _clubId,
            _clubDomainId,
            _clubMember,
            _clubName,
        ];
    }

    public override Tdf CreateNew() => new ClubMembership();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ClubMembership";
    public override string GetFullClassName() => "Blaze::Clubs::ClubMembership";

    public uint ClubId
    {
        get => _clubId.Value;
        set => _clubId.Value = value;
    }

    public uint ClubDomainId
    {
        get => _clubDomainId.Value;
        set => _clubDomainId.Value = value;
    }

    public Blaze3SDK.Blaze.Clubs.ClubMember? ClubMember
    {
        get => _clubMember.Value;
        set => _clubMember.Value = value;
    }

    public string ClubName
    {
        get => _clubName.Value;
        set => _clubName.Value = value;
    }

}

