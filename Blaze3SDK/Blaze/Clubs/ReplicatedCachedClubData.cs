using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Clubs;

public class ReplicatedCachedClubData : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClubSettings", "mClubSettings", 0x8ECCF400, TdfType.Struct, 0, true), // CLST
        new TdfMemberInfo("ClubDomainId", "mClubDomainId", 0x92DA6400, TdfType.UInt32, 1, true), // DMID
        new TdfMemberInfo("Name", "mName", 0xBA1B6500, TdfType.String, 2, true), // NAME
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze3SDK.Blaze.Clubs.ClubSettings?> _clubSettings = new(__typeInfos[0]);
    private TdfUInt32 _clubDomainId = new(__typeInfos[1]);
    private TdfString _name = new(__typeInfos[2]);

    public ReplicatedCachedClubData()
    {
        __members = [
            _clubSettings,
            _clubDomainId,
            _name,
        ];
    }

    public override Tdf CreateNew() => new ReplicatedCachedClubData();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ReplicatedCachedClubData";
    public override string GetFullClassName() => "Blaze::Clubs::ReplicatedCachedClubData";

    public Blaze3SDK.Blaze.Clubs.ClubSettings? ClubSettings
    {
        get => _clubSettings.Value;
        set => _clubSettings.Value = value;
    }

    public uint ClubDomainId
    {
        get => _clubDomainId.Value;
        set => _clubDomainId.Value = value;
    }

    public string Name
    {
        get => _name.Value;
        set => _name.Value = value;
    }

}

