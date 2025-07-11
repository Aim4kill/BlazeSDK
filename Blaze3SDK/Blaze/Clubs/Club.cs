using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Clubs;

public class Club : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClubId", "mClubId", 0x8ECA6400, TdfType.UInt32, 0, true), // CLID
        new TdfMemberInfo("ClubInfo", "mClubInfo", 0x8ECA6E00, TdfType.Struct, 1, true), // CLIN
        new TdfMemberInfo("ClubSettings", "mClubSettings", 0x8ECCF400, TdfType.Struct, 2, true), // CLST
        new TdfMemberInfo("TagList", "mTagList", 0x8ECD2700, TdfType.List, 3, true), // CLTG
        new TdfMemberInfo("ClubDomainId", "mClubDomainId", 0x92DA6400, TdfType.UInt32, 4, true), // DMID
        new TdfMemberInfo("Name", "mName", 0xBA1B6500, TdfType.String, 5, true), // NAME
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _clubId = new(__typeInfos[0]);
    private TdfStruct<Blaze3SDK.Blaze.Clubs.ClubInfo?> _clubInfo = new(__typeInfos[1]);
    private TdfStruct<Blaze3SDK.Blaze.Clubs.ClubSettings?> _clubSettings = new(__typeInfos[2]);
    private TdfList<string> _tagList = new(__typeInfos[3]);
    private TdfUInt32 _clubDomainId = new(__typeInfos[4]);
    private TdfString _name = new(__typeInfos[5]);

    public Club()
    {
        __members = [
            _clubId,
            _clubInfo,
            _clubSettings,
            _tagList,
            _clubDomainId,
            _name,
        ];
    }

    public override Tdf CreateNew() => new Club();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "Club";
    public override string GetFullClassName() => "Blaze::Clubs::Club";

    public uint ClubId
    {
        get => _clubId.Value;
        set => _clubId.Value = value;
    }

    public Blaze3SDK.Blaze.Clubs.ClubInfo? ClubInfo
    {
        get => _clubInfo.Value;
        set => _clubInfo.Value = value;
    }

    public Blaze3SDK.Blaze.Clubs.ClubSettings? ClubSettings
    {
        get => _clubSettings.Value;
        set => _clubSettings.Value = value;
    }

    public IList<string> TagList
    {
        get => _tagList.Value;
        set => _tagList.Value = value;
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

