using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Clubs;

public class FindClubsRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Abbrev", "mAbbrev", 0x862CB600, TdfType.String, 0, true), // ABRV
        new TdfMemberInfo("AcceptanceFlags", "mAcceptanceFlags", 0x86396600, TdfType.Enum, 1, true), // ACEF
        new TdfMemberInfo("AcceptanceMask", "mAcceptanceMask", 0x863B7300, TdfType.Enum, 2, true), // ACMS
        new TdfMemberInfo("AnyTeamId", "mAnyTeamId", 0x874A6400, TdfType.Bool, 3, true), // ATID
        new TdfMemberInfo("ClubFilterList", "mClubFilterList", 0x8E6B2900, TdfType.List, 4, true), // CFLI
        new TdfMemberInfo("MinMemberOnlineStatusCounts", "mMinMemberOnlineStatusCounts", 0x8EDB6F00, TdfType.List, 5, true), // CMMO
        new TdfMemberInfo("Name", "mName", 0x8EE86D00, TdfType.String, 6, true), // CNAM
        new TdfMemberInfo("Region", "mRegion", 0x8F296700, TdfType.UInt32, 7, true), // CREG
        new TdfMemberInfo("Language", "mLanguage", 0xB21BA700, TdfType.String, 8, true), // LANG
        new TdfMemberInfo("MaxMemberCount", "mMaxMemberCount", 0xB61B6300, TdfType.UInt32, 9, true), // MAMC
        new TdfMemberInfo("MinMemberCount", "mMinMemberCount", 0xB69B6300, TdfType.UInt32, 10, true), // MIMC
        new TdfMemberInfo("MaxResultCount", "mMaxResultCount", 0xB78CA300, TdfType.UInt32, 11, true), // MXRC
        new TdfMemberInfo("Offset", "mOffset", 0xBE6CA300, TdfType.UInt32, 12, true), // OFRC
        new TdfMemberInfo("SeasonLevel", "mSeasonLevel", 0xCE586C00, TdfType.UInt32, 13, true), // SEAL
        new TdfMemberInfo("SkipMetadata", "mSkipMetadata", 0xCEBB6400, TdfType.UInt8, 14, true), // SKMD
        new TdfMemberInfo("TeamId", "mTeamId", 0xD2DA6400, TdfType.UInt32, 15, true), // TMID
        new TdfMemberInfo("MemberFilterList", "mMemberFilterList", 0xD66B2900, TdfType.List, 16, true), // UFLI
    ];
    private ITdfMember[] __members;

    private TdfString _abbrev = new(__typeInfos[0]);
    private TdfEnum<Blaze2SDK.Blaze.Clubs.ClubAcceptanceFlags> _acceptanceFlags = new(__typeInfos[1]);
    private TdfEnum<Blaze2SDK.Blaze.Clubs.ClubAcceptanceFlags> _acceptanceMask = new(__typeInfos[2]);
    private TdfBool _anyTeamId = new(__typeInfos[3]);
    private TdfList<uint> _clubFilterList = new(__typeInfos[4]);
    private TdfList<uint> _minMemberOnlineStatusCounts = new(__typeInfos[5]);
    private TdfString _name = new(__typeInfos[6]);
    private TdfUInt32 _region = new(__typeInfos[7]);
    private TdfString _language = new(__typeInfos[8]);
    private TdfUInt32 _maxMemberCount = new(__typeInfos[9]);
    private TdfUInt32 _minMemberCount = new(__typeInfos[10]);
    private TdfUInt32 _maxResultCount = new(__typeInfos[11]);
    private TdfUInt32 _offset = new(__typeInfos[12]);
    private TdfUInt32 _seasonLevel = new(__typeInfos[13]);
    private TdfUInt8 _skipMetadata = new(__typeInfos[14]);
    private TdfUInt32 _teamId = new(__typeInfos[15]);
    private TdfList<uint> _memberFilterList = new(__typeInfos[16]);

    public FindClubsRequest()
    {
        __members = [
            _abbrev,
            _acceptanceFlags,
            _acceptanceMask,
            _anyTeamId,
            _clubFilterList,
            _minMemberOnlineStatusCounts,
            _name,
            _region,
            _language,
            _maxMemberCount,
            _minMemberCount,
            _maxResultCount,
            _offset,
            _seasonLevel,
            _skipMetadata,
            _teamId,
            _memberFilterList,
        ];
    }

    public override Tdf CreateNew() => new FindClubsRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "FindClubsRequest";
    public override string GetFullClassName() => "Blaze::Clubs::FindClubsRequest";

    public string Abbrev
    {
        get => _abbrev.Value;
        set => _abbrev.Value = value;
    }

    public Blaze2SDK.Blaze.Clubs.ClubAcceptanceFlags AcceptanceFlags
    {
        get => _acceptanceFlags.Value;
        set => _acceptanceFlags.Value = value;
    }

    public Blaze2SDK.Blaze.Clubs.ClubAcceptanceFlags AcceptanceMask
    {
        get => _acceptanceMask.Value;
        set => _acceptanceMask.Value = value;
    }

    public bool AnyTeamId
    {
        get => _anyTeamId.Value;
        set => _anyTeamId.Value = value;
    }

    public IList<uint> ClubFilterList
    {
        get => _clubFilterList.Value;
        set => _clubFilterList.Value = value;
    }

    public IList<uint> MinMemberOnlineStatusCounts
    {
        get => _minMemberOnlineStatusCounts.Value;
        set => _minMemberOnlineStatusCounts.Value = value;
    }

    public string Name
    {
        get => _name.Value;
        set => _name.Value = value;
    }

    public uint Region
    {
        get => _region.Value;
        set => _region.Value = value;
    }

    public string Language
    {
        get => _language.Value;
        set => _language.Value = value;
    }

    public uint MaxMemberCount
    {
        get => _maxMemberCount.Value;
        set => _maxMemberCount.Value = value;
    }

    public uint MinMemberCount
    {
        get => _minMemberCount.Value;
        set => _minMemberCount.Value = value;
    }

    public uint MaxResultCount
    {
        get => _maxResultCount.Value;
        set => _maxResultCount.Value = value;
    }

    public uint Offset
    {
        get => _offset.Value;
        set => _offset.Value = value;
    }

    public uint SeasonLevel
    {
        get => _seasonLevel.Value;
        set => _seasonLevel.Value = value;
    }

    public byte SkipMetadata
    {
        get => _skipMetadata.Value;
        set => _skipMetadata.Value = value;
    }

    public uint TeamId
    {
        get => _teamId.Value;
        set => _teamId.Value = value;
    }

    public IList<uint> MemberFilterList
    {
        get => _memberFilterList.Value;
        set => _memberFilterList.Value = value;
    }

}

